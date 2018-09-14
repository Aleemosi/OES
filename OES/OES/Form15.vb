Public Class Form15
    Public DateOfMeeting As Date
    Public DateID As Integer
    Private Sub Form15_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'OESDataSet.tblDate' table. You can move, or remove it, as needed.
        Me.TblDateTableAdapter.FillBy(Me.OESDataSet.tblDate, DateOfMeeting)
        'TODO: This line of code loads data into the 'OESDataSet.tblOfficer' table. You can move, or remove it, as needed.
        Me.TblOfficerTableAdapter.FillBy(Me.OESDataSet.tblOfficer, DateID)
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Try
            MessageBox.Show("ADD NEW ROLL CALL OF OFFICER FOR DATE " & DateOfMeetingTextBox.Text & "", "ADD")
            Me.TblOfficerBindingSource.AddNew()
            DateIDTextBox.Text = DateIDTextBox1.Text
        Catch ex As Exception
            MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Try
            Me.Validate()
            Me.TblOfficerBindingSource.EndEdit()
            Me.TableAdapterManager.UpdateAll(Me.OESDataSet)
            MessageBox.Show("ROLL CALL OF OFICER FOR DATE " & DateOfMeetingTextBox.Text & " SAVED!", "SAVE")
            Form14.Show()
            Me.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Form14.Show()
        Me.Close()
    End Sub
End Class