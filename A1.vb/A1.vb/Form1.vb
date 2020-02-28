Public Class Form1
    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Read.Click


        Dim tempL As String
        Dim tempS As String

        Dim filenum As Integer = FreeFile()
        FileOpen(filenum, "H:\score.txt", OpenMode.Input)
        Do Until EOF(filenum)

            tempL = LineInput(filenum)
            tempS += tempL + vbCrLf

        Loop

        FileClose(filenum)
        TextBox1.Text = tempS

    End Sub

    Private Sub Right_Click(sender As Object, e As EventArgs) Handles Right.Click
        Dim filenum As Integer = FreeFile()
        FileOpen(filenum, "H:\score.txt", OpenMode.Output)
        PrintLine(filenum, TextBox1.Text)
        FileClose(filenum)


    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        TextBox1.Clear()

    End Sub

    Private Sub SmbSave_FileOk(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles SmdWriter.FileOk
        If SfdWriter.filenum <> "" Then
            SW * New streamwriter(SfdWriter.filenum, False)
                For Each line As String In Split(txtWrite.Text, Chr(13))
                SW.written.line(line)
            Next
            SW.close()
        End If

    End Sub
End Class
