Public Class Form12
    Public DateOfMeeting As Date
    Public DateID As Integer
    Private Sub Form12_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'OESDataSet.tblTreasure' table. You can move, or remove it, as needed.
        Me.TblTreasureTableAdapter.FillBy(Me.OESDataSet.tblTreasure, DateID)
        'TODO: This line of code loads data into the 'OESDataSet.tblDate' table. You can move, or remove it, as needed.
        Me.TblDateTableAdapter.FillBy(Me.OESDataSet.tblDate, DateOfMeeting)
        DateToTreasureDateTimePicker.Text = DateOfMeetingTextBox.Text
    End Sub
    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Try
            MessageBox.Show("ADD NEW TREASURE REPORT FOR DATE " & DateOfMeetingTextBox.Text & "", "ADD")
            Me.TblTreasureBindingSource.AddNew()
            DateIDTextBox1.Text = DateIDTextBox.Text
        Catch ex As Exception
            MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Try
            Me.Validate()
            Me.TblTreasureBindingSource.EndEdit()
            Me.TableAdapterManager.UpdateAll(Me.OESDataSet)
            MessageBox.Show("TREASURE REPORT FOR DATE " & DateOfMeetingTextBox.Text & " SAVED!", "SAVE")
            Form11.Show()
            Me.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    Private Sub TotalPaidTextBox_TextChanged(sender As Object, e As EventArgs) Handles TotalPaidTextBox.TextChanged
        Dim result, result1, total As Integer
        result = Val(PriceOfDonationTextBox.Text)
        result1 = Val(DuesPayedTextBox.Text)
        total = result + result1
        TotalPaidTextBox.Text = "$" & total
    End Sub
    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        Form11.Show()
        Me.Close()
    End Sub
End Class