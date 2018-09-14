Public Class Form18
    Public DateOfMeeting As Date
    Public DateID As Integer
    Private Sub Form18_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'OESDataSet.tblDate' table. You can move, or remove it, as needed.
        Me.TblDateTableAdapter.FillBy(Me.OESDataSet.tblDate, DateOfMeeting)
        'TODO: This line of code loads data into the 'OESDataSet.tblVisitor' table. You can move, or remove it, as needed.
        Me.TblVisitorTableAdapter.FillBy(Me.OESDataSet.tblVisitor, DateID)
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Try
            MessageBox.Show("ADD NEW VISITOR FOR DATE " & DateOfMeetingTextBox.Text & "", "ADD")
            TblVisitorBindingSource.AddNew()
            DateIDTextBox.Text = DateIDTextBox1.Text
        Catch ex As Exception
            MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Try
            Me.Validate()
            Me.TblVisitorBindingSource.EndEdit()
            Me.TableAdapterManager.UpdateAll(Me.OESDataSet)
            MessageBox.Show("VISITORS FOR DATE " & DateOfMeetingTextBox.Text & " SAVED!", "SAVE")
            Form17.Show()
            Me.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Form17.Show()
        Me.Close()
    End Sub
End Class