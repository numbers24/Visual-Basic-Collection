Public Class frmXP
    Private Sub btnCalc_Click(sender As Object, e As EventArgs) Handles btnCalc.Click
        prgXP.Value = prgXP.Value + ((Val(txtLevel.Text) * Val(txtYourLevel.Text)) / 2 * Val(txtYourLevel.Text)) * (2 * ((Val(txtEnemyValue.Text) + Val(txtWeaponValue.Text)) ^ (1 / 2)))
        lblXP.Text = prgXP.Value
        lblXPG.Text = ((Val(txtLevel.Text) * Val(txtYourLevel.Text)) / 2 * Val(txtYourLevel.Text)) * (2 * ((Val(txtEnemyValue.Text) + Val(txtWeaponValue.Text)) ^ (1 / 2)))
        If prgXP.Value > prgXP.Maximum Then
            prgXP.Value = 0
            prgXP.Maximum = prgXP.Maximum * 1.5
        End If

    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles lblXP.Click
        lblXP.Text = prgXP.Value
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        prgXP.Value = 0
    End Sub

    Private Sub frmXP_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub prgXP_Click(sender As Object, e As EventArgs) Handles prgXP.Click

    End Sub
End Class
