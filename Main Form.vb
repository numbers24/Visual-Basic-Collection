Public Class MainForm
    Private Sub exitButton_Click(sender As Object, e As EventArgs) Handles exitButton.Click
        Me.Close()
    End Sub

    Private Sub everythingPictureBox_Click(sender As Object, e As EventArgs) Handles everythingPictureBox.Click
        My.Computer.Audio.Play("Everything-Begins-by-danosongs.com.wav")
    End Sub

    Private Sub invisiblePictureBox_Click(sender As Object, e As EventArgs) Handles invisiblePictureBox.Click
        My.Computer.Audio.Play("Invisible-Love-by-danosongs.com.wav")
    End Sub

    Private Sub magicPictureBox_Click(sender As Object, e As EventArgs) Handles magicPictureBox.Click
        My.Computer.Audio.Play("Magic-Ghost-by-danosongs.com.wav")
    End Sub

    Private Sub threePictureBox_Click(sender As Object, e As EventArgs) Handles threePictureBox.Click
        My.Computer.Audio.Play("Three-Drops-by-danosongs.com.wav")
    End Sub

    Private Sub unclaimedPictureBox_Click(sender As Object, e As EventArgs) Handles unclaimedPictureBox.Click
        My.Computer.Audio.Play("Unclaimed-Territory-by-danosongs.com.wav")
    End Sub
End Class
