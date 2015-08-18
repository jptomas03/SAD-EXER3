Public Class FlashCard
    Dim temp As String
    Private Sub cmdNext_Click(sender As Object, e As EventArgs) Handles cmdNext.Click
            If txtAnswer.Text = lblNum1.Text + +lblNum2.Text Then
                lblMessage.Text = "Keep up the good Job :)"
                lblMessage.BackColor = Color.Green
                lblScore.Text = 1 + +lblScore.Text
            Else
                lblMessage.Text = "Better Luck Next Time"
                lblMessage.BackColor = Color.Red
            End If
        lblNum1.Text = Int(Rnd() * 101)
        lblNum2.Text = Int(Rnd() * 101)

    End Sub

    Private Sub FlashCard_Load(sender As Object, e As EventArgs) Handles Me.Load
        lblNum1.Text = Int(Rnd() * 51)
        lblNum2.Text = Int(Rnd() * 51)
        temp = txtAnswer.Text
    End Sub

    Private Sub cmdExit_Click(sender As Object, e As EventArgs) Handles cmdExit.Click
        Me.Close()
    End Sub

    Private Sub txtAnswer_TextChanged(sender As Object, e As EventArgs) Handles txtAnswer.TextChanged
        If txtAnswer.Text = "" Then
            temp = txtAnswer.Text
        ElseIf Not Char.IsDigit(txtAnswer.Text.Chars(txtAnswer.TextLength - 1)) Then
            lblMessage.Text = "Please Input Integer only"
            lblMessage.BackColor = Color.Yellow
            txtAnswer.Text = temp
        Else
            temp = txtAnswer.Text
        End If
    End Sub
End Class
