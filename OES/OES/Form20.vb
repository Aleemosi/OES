Public Class Form20
    Private Sub Form20_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'OESDataSet.Login' table. You can move, or remove it, as needed.
        Me.LoginTableAdapter.Fill(Me.OESDataSet.Login)
        'TODO: This line of code loads data into the 'OESDataSet.Login1' table. You can move, or remove it, as needed.
        Me.Login1TableAdapter.Fill(Me.OESDataSet.Login1)

    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Try
            MessageBox.Show("ADD A NEW ADMINISTRATOR", "ADD")
            Login1BindingSource.AddNew()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Try
            Me.Validate()
            Me.Login1BindingSource.EndEdit()
            Me.TableAdapterManager.UpdateAll(Me.OESDataSet)
            MessageBox.Show("ADMINISTRATOR " & UsernameTextBox.Text & " SAVED", "SAVE")
        Catch ex As Exception
            MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Try
            Dim dialog As DialogResult
            dialog = MessageBox.Show("Would you like to delete administrator " & UsernameTextBox.Text & " from administration?", "DELETE")
            If dialog = DialogResult.No Then
            Else
                MessageBox.Show("ADMINISTRATOR DELETED", "DELETE")
                Me.Login1BindingSource.RemoveCurrent()
                Me.Validate()
                Me.Login1BindingSource.EndEdit()
                Me.TableAdapterManager.UpdateAll(Me.OESDataSet)
                MessageBox.Show("ADMINISTRATOR UPDATED", "UPDATE")
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Login1BindingSource.MovePrevious()
    End Sub
    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Login1BindingSource.MoveNext()
    End Sub
    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Try
            MessageBox.Show("ADD A NEW LOGIN PERSONNEL", "ADD")
            LoginBindingSource.AddNew()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        Try
            Me.LoginBindingSource.EndEdit()
            Me.LoginTableAdapter.Update(Me.OESDataSet.Login)
            MessageBox.Show("LOGIN PERSONNEL " & UserNameTextBox1.Text & " SAVED", "SAVE")
        Catch ex As Exception
            MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        Try
            Dim dialog As DialogResult
            dialog = MessageBox.Show("Would you like to delete login personel " & UserNameTextBox1.Text & " from login?", "DELETE")
            If dialog = DialogResult.No Then
            Else
                MessageBox.Show("LOGIN PERSONNEL DELETED", "DELETE")
                Me.LoginBindingSource.RemoveCurrent()
                Me.LoginBindingSource.EndEdit()
                Me.LoginTableAdapter.Update(Me.OESDataSet.Login)
                MessageBox.Show("LOGIN PERSONNEL UPDATED", "UPDATE")
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        LoginBindingSource.MovePrevious()
    End Sub
    Private Sub Button10_Click(sender As Object, e As EventArgs) Handles Button10.Click
        LoginBindingSource.MoveNext()
    End Sub
    Private Sub Button11_Click(sender As Object, e As EventArgs) Handles Button11.Click
        Form16.Show()
        Me.Close()
    End Sub
End Class