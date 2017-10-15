Imports System.IO
Imports Microsoft.VisualBasic.CompilerServices
Imports System.Net
Imports System.Threading
Imports System.Text.RegularExpressions
Imports System.Diagnostics
Public Class Main
    Public Sub exe(path As String)
        Dim files As String() = Directory.GetFiles(path)
        Dim array As String() = files
        For i As Integer = 0 To array.Length - 1
            Dim path2 As String = array(i)
            Dim extension As String = System.IO.Path.GetExtension(path2)
            System.IO.Path.GetFileNameWithoutExtension(path2)
            If Operators.CompareString(extension, ".vbproj", False) = 0 Then
                Dim fileNameWithExtension As String = System.IO.Path.GetFileName(path2)
                If Operators.CompareString(System.IO.Path.GetExtension(path2), ".vbproj", False) = 0 AndAlso File.Exists(path2) Then
                    Dim listViewItem As ListViewItem = listView1.Items.Add(path + "\" + fileNameWithExtension)
                    Dim a As String = File.ReadAllText(path + "\" + fileNameWithExtension)
                    If a.Contains("powershell invoke-expression") Then
                        listViewItem.SubItems.Add("Infecté")
                        listViewItem.SubItems(0).ForeColor = Color.Red
                    Else
                        listViewItem.SubItems.Add("Clean")
                        listViewItem.SubItems(0).ForeColor = Color.GreenYellow
                    End If
                    Using Stream As FileStream = File.OpenRead(array(i))
                        listViewItem.SubItems.Add((Stream.Length / 1024L).ToString() + " kb")
                    End Using
                    listViewItem.SubItems.Add(MD5.IntegrityCheck(array(i)))
                    Dim TextToParse = File.ReadAllText((path + "\" + fileNameWithExtension))
                    Try
                        Dim first As String = ParseBetween(TextToParse, "FromBase64String", "</Target></Project>").First
                        Dim second As String = ParseBetween(first, "'", "'").First
                        Dim b As Byte() = Convert.FromBase64String(second)
                        Dim TextToParse3 = System.Text.Encoding.UTF8.GetString(b)
                        Dim third As String = ParseBetween(TextToParse3, "DownloadString", "Split").First
                        Dim four As String = ParseBetween(third, "://", "'").First
                        listViewItem.SubItems.Add(four)
                    Catch
                    End Try
                End If
            End If
        Next
    End Sub
    Public Sub exe2(path As String)
        Dim files As String() = Directory.GetFiles(path)
        Dim array As String() = files
        For i As Integer = 0 To array.Length - 1
            Dim path2 As String = array(i)
            Dim extension As String = System.IO.Path.GetExtension(path2)
            System.IO.Path.GetFileNameWithoutExtension(path2)
            If Operators.CompareString(extension, ".csproj", False) = 0 Then
                Dim fileNameWithExtension As String = System.IO.Path.GetFileName(path2)
                If Operators.CompareString(System.IO.Path.GetExtension(path2), ".csproj", False) = 0 AndAlso File.Exists(path2) Then
                    Dim listViewItem As ListViewItem = listView1.Items.Add(path + "\" + fileNameWithExtension)
                    Dim a As String = File.ReadAllText(path + "\" + fileNameWithExtension)
                    If a.Contains("powershell invoke-expression") Then
                        listViewItem.SubItems.Add("Infecté")
                        listViewItem.SubItems(0).ForeColor = Color.Red
                    Else
                        listViewItem.SubItems.Add("Clean")
                        listViewItem.SubItems(0).ForeColor = Color.GreenYellow
                    End If
                    Using Stream As FileStream = File.OpenRead(array(i))
                        listViewItem.SubItems.Add((Stream.Length / 1024L).ToString() + " kb")
                    End Using
                    listViewItem.SubItems.Add(MD5.IntegrityCheck(array(i)))
                    Dim TextToParse = File.ReadAllText((path + "\" + fileNameWithExtension))
                    Try
                        Dim first As String = ParseBetween(TextToParse, "FromBase64String", "</Target></Project>").First
                        Dim second As String = ParseBetween(first, "'", "'").First
                        Dim b As Byte() = Convert.FromBase64String(second)
                        Dim TextToParse3 = System.Text.Encoding.UTF8.GetString(b)
                        Dim third As String = ParseBetween(TextToParse3, "DownloadString", "Split").First
                        Dim four As String = ParseBetween(third, "://", "'").First
                        listViewItem.SubItems.Add(four)
                    Catch
                    End Try
                End If
            End If
        Next
    End Sub
    Class ListViewItemComparer
        Implements IComparer
        Private ReadOnly _columnIndex As Integer

        Public Sub New(columnIndex As Integer)
            _columnIndex = columnIndex
        End Sub

        Public Function Compare(x As Object, y As Object) As Integer Implements IComparer.Compare
            Dim itemX As ListViewItem = DirectCast(x, ListViewItem)
            Dim itemY As ListViewItem = DirectCast(y, ListViewItem)
            Dim subItemX As ListViewItem.ListViewSubItem = itemX.SubItems(_columnIndex)
            Dim subItemY As ListViewItem.ListViewSubItem = itemY.SubItems(_columnIndex)
            Dim textX As String = subItemX.Text
            Dim textY As String = subItemY.Text
            Return String.Compare(textX, textY, True)
        End Function
    End Class
    Private Sub ListView1_ColumnClick(sender As Object, e As ColumnClickEventArgs) Handles listView1.ColumnClick
        listView1.ListViewItemSorter = New ListViewItemComparer(e.Column)
    End Sub
    Private Sub BtScan_Click(sender As Object, e As EventArgs) Handles BtScan.Click
        Me.listView1.Items.Clear()
        Try
            Dim dirPath2 As String = Environment.GetFolderPath(Environment.SpecialFolder.Desktop)
            Dim dirs2 As List(Of String) = New List(Of String)(My.Computer.FileSystem.GetDirectories(dirPath2, FileIO.SearchOption.SearchAllSubDirectories))
            For Each folder2 In dirs2
                Dim g As String = "C" + folder2.Substring(folder2.LastIndexOf("C:") + 1)
                Me.exe(g)
                Me.exe2(g)
            Next
        Catch
        End Try
        Try
            Dim dirPath3 As String = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "\Visual Studio 2012\Projects\"
            Dim dirs3 As List(Of String) = New List(Of String)(My.Computer.FileSystem.GetDirectories(dirPath3, FileIO.SearchOption.SearchAllSubDirectories))
            For Each folder3 In dirs3
                Dim g As String = "C" + folder3.Substring(folder3.LastIndexOf("C:") + 1)
                Me.exe(g)
                Me.exe2(g)
            Next
        Catch
        End Try
        Try
            Dim dirPath4 As String = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "\Visual Studio 2013\Projects\"
            Dim dirs4 As List(Of String) = New List(Of String)(My.Computer.FileSystem.GetDirectories(dirPath4, FileIO.SearchOption.SearchAllSubDirectories))
            For Each folder4 In dirs4
                Dim g As String = "C" + folder4.Substring(folder4.LastIndexOf("C:") + 1)
                Me.exe(g)
                Me.exe2(g)
            Next
        Catch
        End Try
        Try
            Dim dirPath5 As String = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "\Visual Studio 2015\Projects\"
            Dim dirs5 As List(Of String) = New List(Of String)(My.Computer.FileSystem.GetDirectories(dirPath5, FileIO.SearchOption.SearchAllSubDirectories))
            For Each folder5 In dirs5
                Dim g As String = "C" + folder5.Substring(folder5.LastIndexOf("C:") + 1)
                Me.exe(g)
                Me.exe2(g)
            Next
        Catch
        End Try
    End Sub

    Private Sub SlcClose1_Click(sender As Object, e As EventArgs) Handles SlcClose1.Click
        Environment.Exit(0)
    End Sub
    Private Sub SupprimerToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SupprimerToolStripMenuItem.Click
        If listView1.SelectedItems.Count = 1 Then
            If listView1.SelectedItems.Item(0).SubItems(1).Text = "Infecté" Then
                Dim t As String = listView1.SelectedItems.Item(0).SubItems(0).Text
                If MessageBox.Show("Etes vous sur de vouloir modifier ce fichier ?", "Infos", MessageBoxButtons.YesNo, MessageBoxIcon.Information) = Windows.Forms.DialogResult.Yes Then
                    Dim lignes() As String = File.ReadAllLines(t)
                    Dim nLignes = lignes.Length
                    Dim lines As List(Of String) = File.ReadLines(t).ToList()
                    lines(nLignes - 1) = "</Project>"
                    Try
                        File.WriteAllLines(t, lines)
                        MessageBox.Show("Projet visual studio :" + t + " - désinfecté avec succès !", "Réussite !", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Catch
                        MessageBox.Show("Impossible d'effectuer l'opération !", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    End Try
                End If
            End If
        End If
    End Sub
    Private Sub InfosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles InfosToolStripMenuItem.Click
        If listView1.SelectedItems.Count = 1 Then
            Dim TextToParse = File.ReadAllText(listView1.SelectedItems.Item(0).SubItems(0).Text)
            Try
                Dim first As String = ParseBetween(TextToParse, "FromBase64String", "</Target></Project>").First
                Dim second As String = ParseBetween(first, "'", "'").First
                Dim b As Byte() = Convert.FromBase64String(second)
                Dim TextToParse3 = System.Text.Encoding.UTF8.GetString(b)
                Dim third As String = ParseBetween(TextToParse3, "DownloadString", "Split").First
                Dim four As String = ParseBetween(third, "://", "'").First
                MessageBox.Show("Chemin d'accès : " + listView1.SelectedItems.Item(0).SubItems(0).Text + vbNewLine + "Date de création : " + File.GetCreationTime(listView1.SelectedItems.Item(0).SubItems(0).Text) + vbNewLine + "Signature : " + "unknown" + vbNewLine + "Lien : " + four, "Informations", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Catch
                MessageBox.Show("Chemin d'accès : " + listView1.SelectedItems.Item(0).SubItems(0).Text + vbNewLine + "Date de création : " + File.GetCreationTime(listView1.SelectedItems.Item(0).SubItems(0).Text) + vbNewLine + "Signature : " + "unknown" + vbNewLine + "Lien : ?", "Informations", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End Try
        End If
    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        Process.Start("http://hackandmodz.net/")
    End Sub

    Private Sub Main_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim WebClient1 As New WebClient
        Dim Version As String = WebClient1.DownloadString("https://pastebin.com/raw/vPvNJC5g")
        If Version <> "1.1" Then ' Changer a chaque mise a jour
            MessageBox.Show("Nouvelle version disponible ! ", "Mise à jour", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Process.Start(Version)
            Thread.Sleep(500)
            Environment.Exit(0)
        End If
    End Sub

    Private Sub BtParcourir_Click(sender As Object, e As EventArgs) Handles BtParcourir.Click
        Dim openFileDialog As OpenFileDialog = New OpenFileDialog()
        Dim openFileDialog2 As OpenFileDialog = openFileDialog
        openFileDialog2.Filter = "Project Visual Studio|*.csproj;*.vbproj;*.vcxproj;*.fsproj"
        Dim flag As Boolean = openFileDialog2.ShowDialog() = DialogResult.OK
        If flag Then
            TxtBPath.Text = openFileDialog2.FileName
            Dim a As String = File.ReadAllText(TxtBPath.Text)
            If a.Contains("aftercompile") Then
                If MessageBox.Show("Projet visual studio infecté ! Si vous l'ouvrez à vos risques et périls !", "Infecté", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) = Windows.Forms.DialogResult.Yes Then
                    Dim lignes() As String = File.ReadAllLines(TxtBPath.Text)
                    Dim nLignes = lignes.Length
                    Dim lines As List(Of String) = File.ReadLines(TxtBPath.Text).ToList()
                    lines(nLignes - 1) = "</Project>"
                    Try
                        File.WriteAllLines(TxtBPath.Text, lines)
                        MessageBox.Show("Projet visual studio :" + TxtBPath.Text + " - désinfecté avec succès !", "Succès !", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Catch
                        MessageBox.Show("Projet visual studio :" + TxtBPath.Text + " - impossible de le désinfecter :/", "Erreur :/", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                    End Try
                End If
            Else
                MessageBox.Show("Projet visual studio non infecté !", "Clean", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        End If
    End Sub
    Private Function ParseBetween(Source$, Before$, After$) As String()
        Dim Results As New List(Of String)
        Dim T As New List(Of String)
        With T
            .AddRange(System.Text.RegularExpressions.Regex.Split(Source, Before))
            .RemoveAt(0)
            For Each Item$ In T
                Results.Add(System.Text.RegularExpressions.Regex.Split(Item, After)(0))
            Next
        End With
        Return Results.ToArray
    End Function

    Private Function ParseBetween(Source$, Before$, After$, Offset%) As String
        If String.IsNullOrEmpty(Source) Then
            Return String.Empty
        End If
        If Source.Contains(Before) = True Then
            Dim Result$ = Source.Substring(Source.IndexOf(Before) + Offset)
            If Result.Contains(After) = True Then
                If Not String.IsNullOrEmpty(After) Then
                    Result = Result.Substring(0, Result.IndexOf(After))
                End If
            End If
            Return Result
        Else
            Return String.Empty
        End If
    End Function    
End Class