Imports Microsoft.Reporting.WinForms
Public Class Form6
    Private Sub Form6_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'OESDataSet.tblDate' table. You can move, or remove it, as needed.
        Me.TblDateTableAdapter.Fill(Me.OESDataSet.tblDate)
        'TODO: This line of code loads data into the 'OESDataSet.recMemberStatus' table. You can move, or remove it, as needed.
        'Me.recMemberStatusTableAdapter.Fill(Me.OESDataSet.recMemberStatus)
        'Me.ReportViewer1.RefreshReport()
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Try
            DateOfMeetingComboBox.Refresh()
            Dim MEET As New ReportParameter("MEET", DateOfMeetingComboBox.Text)
            Me.recMemberStatusTableAdapter.Fill(Me.OESDataSet.recMemberStatus)
            ReportViewer1.LocalReport.SetParameters(New ReportParameter() {MEET})
            Me.ReportViewer1.RefreshReport()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
End Class