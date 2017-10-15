Imports System.Security.Cryptography
Imports System.IO

Public Class MD5
    Private Const BUF_SIZE As Integer = 65536

    Public Shared Function IntegrityCheck(ByVal filePath As String) As String
        Dim dataBuffer(BUF_SIZE - 1) As Byte
        Dim dataBufferDummy(BUF_SIZE - 1) As Byte
        Dim dataBytesRead As Integer = 0
        Dim hashResult As String = String.Empty
        Dim hashAlg As HashAlgorithm = Nothing
        Dim fs As FileStream = Nothing

        Try
            hashAlg = New MD5CryptoServiceProvider ' or New SHA1CryptoServiceProvider
            fs = New FileStream(filePath, FileMode.Open, FileAccess.Read, FileShare.None, BUF_SIZE)
            Do
                dataBytesRead = fs.Read(dataBuffer, 0, BUF_SIZE)
                hashAlg.TransformBlock(dataBuffer, 0, dataBytesRead, dataBufferDummy, 0)
            Loop Until dataBytesRead = 0
            hashAlg.TransformFinalBlock(dataBuffer, 0, 0)
            hashResult = BitConverter.ToString(hashAlg.Hash).Replace("-", "").ToLower
        Catch ex As IOException
            MsgBox(ex.Message, MsgBoxStyle.Critical, "IntegrityCheck")
        Catch ex As UnauthorizedAccessException
            MsgBox(ex.Message, MsgBoxStyle.Critical, "IntegrityCheck")
        Finally
            If Not fs Is Nothing Then
                fs.Close()
                fs.Dispose()
                fs = Nothing
            End If
            If Not hashAlg Is Nothing Then
                hashAlg.Clear() 'Dispose()
                hashAlg = Nothing
            End If
        End Try
        Return hashResult
    End Function

End Class
