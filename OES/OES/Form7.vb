Public Class Form7
    Private Sub MetroButton5_Click(sender As Object, e As EventArgs) Handles MetroButton5.Click
        Do While Form2.MetroPanel1.Width < 587
            Form2.MetroPanel1.Width = Form2.MetroPanel1.Width + 1
        Loop
        Form2.Text = "OES SYSTEM MAIN MENU"
        Form2.MetroTextBox1.Visible = False
        Form2.MetroTextBox2.Visible = False
        Form2.MetroButton3.Visible = False
        Form2.Show()
        Me.Close()
    End Sub
    Private Sub MetroButton1_Click(sender As Object, e As EventArgs) Handles MetroButton1.Click
        Form8.Show()
        Me.Close()
    End Sub
    Private Sub MetroButton2_Click(sender As Object, e As EventArgs) Handles MetroButton2.Click
        Form11.Show()
        Me.Close()
    End Sub
    Private Sub MetroButton3_Click(sender As Object, e As EventArgs) Handles MetroButton3.Click
        Form14.Show()
        Me.Close()
    End Sub
    Private Sub MetroButton4_Click(sender As Object, e As EventArgs) Handles MetroButton4.Click
        Form17.Show()
        Me.Close()
    End Sub
End Class