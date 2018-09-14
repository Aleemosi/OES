Imports Microsoft.Reporting.WinForms
Public Class Form13
    Private Sub Form13_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'OESDataSet.tblDate' table. You can move, or remove it, as needed.
        Me.TblDateTableAdapter.Fill(Me.OESDataSet.tblDate)
        'TODO: This line of code loads data into the 'OESDataSet.tblTreasure' table. You can move, or remove it, as needed.
        'Me.tblTreasureTableAdapter.Fill(Me.OESDataSet.tblTreasure)
        'Me.ReportViewer1.RefreshReport()
        dateText.Text = Form11.DateOfMeetingTextBox.Text
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Try
            'DateOfMeetingComboBox.Refresh()
            Dim MEETING As New ReportParameter("MEETING", Form11.DateOfMeetingTextBox.Text) 'DateOfMeetingComboBox.Text)
            Me.tblTreasureTableAdapter.Fill(Me.OESDataSet.tblTreasure)
            ReportViewer1.LocalReport.SetParameters(New ReportParameter() {MEETING})
            Me.ReportViewer1.RefreshReport()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
End Class