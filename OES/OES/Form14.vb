Public Class Form14
    Private Sub Form14_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'OESDataSet.tblOfficer' table. You can move, or remove it, as needed.
        Me.TblOfficerTableAdapter.Fill(Me.OESDataSet.tblOfficer)
        'TODO: This line of code loads data into the 'OESDataSet.tblDate' table. You can move, or remove it, as needed.
        Me.TblDateTableAdapter.Fill(Me.OESDataSet.tblDate)
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim F15 As New Form15
        Try
            F15.DateOfMeeting = ComboBox1.Text
            F15.DateID = DateIDTextBox.Text
            F15.Show()
            Me.Close()
        Catch ex As Exception
            MessageBox.Show("PLEASE ADD A DATE FOR TODAYS MEETING!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Try
            Me.Validate()
            Me.TblOfficerBindingSource.EndEdit()
            Me.TableAdapterManager.UpdateAll(Me.OESDataSet)
            MessageBox.Show("ROLL CALL SAVED AND EDITED", "SAVE")
        Catch ex As Exception
            MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Try
            Dim dialog As DialogResult
            dialog = MessageBox.Show("Would you like to delete the roll call?", "DELETE", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            If dialog = DialogResult.No Then
            Else
                MessageBox.Show("ROLL CALL DELETED", "DELETE")
                Me.TblOfficerBindingSource.RemoveCurrent()
                Me.Validate()
                Me.TblOfficerBindingSource.EndEdit()
                Me.TableAdapterManager.UpdateAll(Me.OESDataSet)
                MessageBox.Show("ROLL CALL UPDATED", "UPDATE")
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        TblOfficerBindingSource.MovePrevious()
    End Sub
    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        TblOfficerBindingSource.MoveNext()
    End Sub
    Private Sub Button10_Click(sender As Object, e As EventArgs) Handles Button10.Click
        Form7.Show()
        Me.Close()
    End Sub
    Private Sub Button11_Click(sender As Object, e As EventArgs) Handles Button11.Click
        Form8.Show()
        Me.Close()
    End Sub
End Class