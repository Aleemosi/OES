Imports Microsoft.Reporting.WinForms
Public Class Form19
    Private Sub Form19_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'OESDataSet.tblDate' table. You can move, or remove it, as needed.
        Me.TblDateTableAdapter.Fill(Me.OESDataSet.tblDate)
        dateBoxes.Text = Form17.ComboBox1.Text
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Try
            'DateOfMeetingComboBox.Refresh()
            Dim DATVISI As New ReportParameter("DATVISI", Form17.ComboBox1.Text) 'DateOfMeetingComboBox.Text)
            Me.DateVisitorTableAdapter.Fill(Me.OESDataSet.DateVisitor)
            ReportViewer1.LocalReport.SetParameters(New ReportParameter() {DATVISI})
            Me.ReportViewer1.RefreshReport()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
End Class