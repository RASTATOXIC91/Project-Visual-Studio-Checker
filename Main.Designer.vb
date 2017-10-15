<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Main
    Inherits System.Windows.Forms.Form

    'Form remplace la méthode Dispose pour nettoyer la liste des composants.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requise par le Concepteur Windows Form
    Private components As System.ComponentModel.IContainer

    'REMARQUE : la procédure suivante est requise par le Concepteur Windows Form
    'Elle peut être modifiée à l'aide du Concepteur Windows Form.  
    'Ne la modifiez pas à l'aide de l'éditeur de code.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Main))
        Dim ListViewGroup1 As System.Windows.Forms.ListViewGroup = New System.Windows.Forms.ListViewGroup("Clean", System.Windows.Forms.HorizontalAlignment.Left)
        Dim ListViewGroup2 As System.Windows.Forms.ListViewGroup = New System.Windows.Forms.ListViewGroup("Infecté", System.Windows.Forms.HorizontalAlignment.Left)
        Me.ContextMenuStrip3 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.SupprimerToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.InfosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SlcTheme1 = New Project_VS_Cleaner.SLCTheme()
        Me.SlCbtn1 = New Project_VS_Cleaner.SLCbtn()
        Me.TxtBPath = New Project_VS_Cleaner.SLCTextBox()
        Me.BtParcourir = New Project_VS_Cleaner.SLCbtn()
        Me.SlcLabel1 = New Project_VS_Cleaner.SLCLabel()
        Me.LinkLabel1 = New System.Windows.Forms.LinkLabel()
        Me.SlcClose1 = New Project_VS_Cleaner.SLCClose()
        Me.BtScan = New Project_VS_Cleaner.SLCbtn()
        Me.listView1 = New System.Windows.Forms.ListView()
        Me.columnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.columnHeader2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.columnHeader4 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.columnHeader5 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader3 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ContextMenuStrip3.SuspendLayout()
        Me.SlcTheme1.SuspendLayout()
        Me.SuspendLayout()
        '
        'ContextMenuStrip3
        '
        Me.ContextMenuStrip3.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SupprimerToolStripMenuItem, Me.InfosToolStripMenuItem})
        Me.ContextMenuStrip3.Name = "ContextMenuStrip3"
        Me.ContextMenuStrip3.Size = New System.Drawing.Size(134, 48)
        '
        'SupprimerToolStripMenuItem
        '
        Me.SupprimerToolStripMenuItem.Image = CType(resources.GetObject("SupprimerToolStripMenuItem.Image"), System.Drawing.Image)
        Me.SupprimerToolStripMenuItem.Name = "SupprimerToolStripMenuItem"
        Me.SupprimerToolStripMenuItem.Size = New System.Drawing.Size(133, 22)
        Me.SupprimerToolStripMenuItem.Text = "Désinfecter"
        '
        'InfosToolStripMenuItem
        '
        Me.InfosToolStripMenuItem.Image = CType(resources.GetObject("InfosToolStripMenuItem.Image"), System.Drawing.Image)
        Me.InfosToolStripMenuItem.Name = "InfosToolStripMenuItem"
        Me.InfosToolStripMenuItem.Size = New System.Drawing.Size(133, 22)
        Me.InfosToolStripMenuItem.Text = "Infos"
        '
        'SlcTheme1
        '
        Me.SlcTheme1.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(57, Byte), Integer), CType(CType(72, Byte), Integer))
        Me.SlcTheme1.BorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.SlcTheme1.Controls.Add(Me.SlCbtn1)
        Me.SlcTheme1.Controls.Add(Me.TxtBPath)
        Me.SlcTheme1.Controls.Add(Me.BtParcourir)
        Me.SlcTheme1.Controls.Add(Me.SlcLabel1)
        Me.SlcTheme1.Controls.Add(Me.LinkLabel1)
        Me.SlcTheme1.Controls.Add(Me.SlcClose1)
        Me.SlcTheme1.Controls.Add(Me.BtScan)
        Me.SlcTheme1.Controls.Add(Me.listView1)
        Me.SlcTheme1.Customization = "JRIV/zYjIP82IyD/JRIV/w=="
        Me.SlcTheme1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SlcTheme1.Font = New System.Drawing.Font("Verdana", 8.0!)
        Me.SlcTheme1.Image = Nothing
        Me.SlcTheme1.Location = New System.Drawing.Point(0, 0)
        Me.SlcTheme1.Movable = True
        Me.SlcTheme1.Name = "SlcTheme1"
        Me.SlcTheme1.NoRounding = False
        Me.SlcTheme1.Sizable = False
        Me.SlcTheme1.Size = New System.Drawing.Size(1036, 488)
        Me.SlcTheme1.SmartBounds = True
        Me.SlcTheme1.StartPosition = System.Windows.Forms.FormStartPosition.WindowsDefaultLocation
        Me.SlcTheme1.TabIndex = 0
        Me.SlcTheme1.Text = "Project VS Checker"
        Me.SlcTheme1.TransparencyKey = System.Drawing.Color.Fuchsia
        Me.SlcTheme1.Transparent = False
        '
        'TxtBPath
        '
        Me.TxtBPath.Location = New System.Drawing.Point(23, 431)
        Me.TxtBPath.MaxLength = 32767
        Me.TxtBPath.Multiline = False
        Me.TxtBPath.Name = "TxtBPath"
        Me.TxtBPath.ReadOnly = False
        Me.TxtBPath.Size = New System.Drawing.Size(320, 24)
        Me.TxtBPath.TabIndex = 80
        Me.TxtBPath.Text = "..."
        Me.TxtBPath.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.TxtBPath.UseSystemPasswordChar = False
        '
        'BtParcourir
        '
        Me.BtParcourir.Colors = New Project_VS_Cleaner.Bloom(-1) {}
        Me.BtParcourir.Customization = ""
        Me.BtParcourir.Font = New System.Drawing.Font("Verdana", 8.0!)
        Me.BtParcourir.Image = Nothing
        Me.BtParcourir.Location = New System.Drawing.Point(349, 431)
        Me.BtParcourir.Name = "BtParcourir"
        Me.BtParcourir.NoRounding = False
        Me.BtParcourir.Size = New System.Drawing.Size(79, 24)
        Me.BtParcourir.TabIndex = 79
        Me.BtParcourir.Text = "Parcourir"
        Me.BtParcourir.Transparent = False
        '
        'SlcLabel1
        '
        Me.SlcLabel1.BackColor = System.Drawing.Color.WhiteSmoke
        Me.SlcLabel1.Font = New System.Drawing.Font("Verdana", 8.0!)
        Me.SlcLabel1.Location = New System.Drawing.Point(940, 463)
        Me.SlcLabel1.Name = "SlcLabel1"
        Me.SlcLabel1.Size = New System.Drawing.Size(91, 13)
        Me.SlcLabel1.TabIndex = 78
        Me.SlcLabel1.Text = "Version : 1.1"
        '
        'LinkLabel1
        '
        Me.LinkLabel1.AutoSize = True
        Me.LinkLabel1.BackColor = System.Drawing.Color.WhiteSmoke
        Me.LinkLabel1.Location = New System.Drawing.Point(468, 22)
        Me.LinkLabel1.Name = "LinkLabel1"
        Me.LinkLabel1.Size = New System.Drawing.Size(109, 13)
        Me.LinkLabel1.TabIndex = 77
        Me.LinkLabel1.TabStop = True
        Me.LinkLabel1.Text = "HackAndModz.Net"
        '
        'SlcClose1
        '
        Me.SlcClose1.Colors = New Project_VS_Cleaner.Bloom(-1) {}
        Me.SlcClose1.Customization = ""
        Me.SlcClose1.Font = New System.Drawing.Font("Verdana", 8.0!)
        Me.SlcClose1.Image = Nothing
        Me.SlcClose1.Location = New System.Drawing.Point(971, 3)
        Me.SlcClose1.Name = "SlcClose1"
        Me.SlcClose1.NoRounding = False
        Me.SlcClose1.Size = New System.Drawing.Size(60, 20)
        Me.SlcClose1.TabIndex = 76
        Me.SlcClose1.Text = "SlcClose1"
        Me.SlcClose1.Transparent = False
        '
        'BtScan
        '
        Me.BtScan.Colors = New Project_VS_Cleaner.Bloom(-1) {}
        Me.BtScan.Customization = ""
        Me.BtScan.Font = New System.Drawing.Font("Verdana", 8.0!)
        Me.BtScan.Image = Nothing
        Me.BtScan.Location = New System.Drawing.Point(668, 427)
        Me.BtScan.Name = "BtScan"
        Me.BtScan.NoRounding = False
        Me.BtScan.Size = New System.Drawing.Size(177, 37)
        Me.BtScan.TabIndex = 75
        Me.BtScan.Text = "Commencer le scan !"
        Me.BtScan.Transparent = False
        '
        'listView1
        '
        Me.listView1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.listView1.BackColor = System.Drawing.Color.White
        Me.listView1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.listView1.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.columnHeader1, Me.columnHeader2, Me.columnHeader4, Me.columnHeader5, Me.ColumnHeader3})
        Me.listView1.ContextMenuStrip = Me.ContextMenuStrip3
        Me.listView1.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.listView1.ForeColor = System.Drawing.Color.Black
        Me.listView1.FullRowSelect = True
        ListViewGroup1.Header = "Clean"
        ListViewGroup1.Name = "ListViewGroup1"
        ListViewGroup2.Header = "Infecté"
        ListViewGroup2.Name = "ListViewGroup2"
        Me.listView1.Groups.AddRange(New System.Windows.Forms.ListViewGroup() {ListViewGroup1, ListViewGroup2})
        Me.listView1.Location = New System.Drawing.Point(23, 63)
        Me.listView1.MultiSelect = False
        Me.listView1.Name = "listView1"
        Me.listView1.Size = New System.Drawing.Size(985, 358)
        Me.listView1.TabIndex = 74
        Me.listView1.UseCompatibleStateImageBehavior = False
        Me.listView1.View = System.Windows.Forms.View.Details
        '
        'columnHeader1
        '
        Me.columnHeader1.Text = "File Name"
        Me.columnHeader1.Width = 532
        '
        'columnHeader2
        '
        Me.columnHeader2.Text = "Status"
        Me.columnHeader2.Width = 55
        '
        'columnHeader4
        '
        Me.columnHeader4.Text = "Taille"
        Me.columnHeader4.Width = 42
        '
        'columnHeader5
        '
        Me.columnHeader5.Text = "MD5"
        Me.columnHeader5.Width = 198
        '
        'ColumnHeader3
        '
        Me.ColumnHeader3.Text = "Lien ( si infecté )"
        Me.ColumnHeader3.Width = 150
        '
        'Main
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1036, 488)
        Me.Controls.Add(Me.SlcTheme1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Main"
        Me.Text = "Main"
        Me.TransparencyKey = System.Drawing.Color.Fuchsia
        Me.ContextMenuStrip3.ResumeLayout(False)
        Me.SlcTheme1.ResumeLayout(False)
        Me.SlcTheme1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents SlcTheme1 As Project_VS_Cleaner.SLCTheme
    Public WithEvents listView1 As System.Windows.Forms.ListView
    Private WithEvents columnHeader1 As System.Windows.Forms.ColumnHeader
    Private WithEvents columnHeader2 As System.Windows.Forms.ColumnHeader
    Private WithEvents columnHeader4 As System.Windows.Forms.ColumnHeader
    Private WithEvents columnHeader5 As System.Windows.Forms.ColumnHeader
    Friend WithEvents BtScan As Project_VS_Cleaner.SLCbtn
    Friend WithEvents SlcClose1 As Project_VS_Cleaner.SLCClose
    Friend WithEvents ContextMenuStrip3 As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents SupprimerToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents InfosToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents LinkLabel1 As System.Windows.Forms.LinkLabel
    Friend WithEvents SlcLabel1 As Project_VS_Cleaner.SLCLabel
    Friend WithEvents TxtBPath As Project_VS_Cleaner.SLCTextBox
    Friend WithEvents BtParcourir As Project_VS_Cleaner.SLCbtn
    Friend WithEvents ColumnHeader3 As System.Windows.Forms.ColumnHeader
End Class
