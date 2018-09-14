Public Class Form9
    Private Sub Form9_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'OESDataSet.tblDate' table. You can move, or remove it, as needed.
        Me.TblDateTableAdapter.Fill(Me.OESDataSet.tblDate)
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Try
            Dim dialog As DialogResult
            dialog = MessageBox.Show(" WOULD LIKE TO ADD A NEW DATE?", "ADD", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            If dialog = DialogResult.No Then
            Else
                Me.TblDateBindingSource.AddNew()
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim F8 As New Form8
        MessageBox.Show("SAVING THE DATE WILL BE SAVED TO THE MINUTES AND THE REST OF YOUR DATA!", "INFORMATION", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Try
            Dim dialog As DialogResult
            dialog = MessageBox.Show("WOULD YOU LIKE TO SAVE THE DATE?", "SAVE", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            If dialog = DialogResult.No Then
            Else
                Me.Validate()
                Me.TblDateBindingSource.EndEdit()
                Me.TableAdapterManager.UpdateAll(Me.OESDataSet)
                MessageBox.Show("DATE SAVED AND ADDED TO THE MINUTES AND THE REST OF YOUR DATA!", "SAVE")
                Do While Form2.MetroPanel1.Width < 587
                    Form2.MetroPanel1.Width = Form2.MetroPanel1.Width + 1
                Loop
                Form2.Text = "OES SYSTEM MAIN MENU"
                Form2.MetroTextBox1.Visible = False
                Form2.MetroTextBox2.Visible = False
                Form2.MetroButton3.Visible = False
                Form2.Show()
                Me.Close()
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
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
End Class