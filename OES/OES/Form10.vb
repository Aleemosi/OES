Imports Microsoft.Reporting.WinForms
Public Class Form10
    Private Sub reports()
        Dim testParam As New ReportParameter("start", Form8.MeetingStartTextBox.Text)
        Dim testParam1 As New ReportParameter("meetcalled", Form8.MeetingCalledByTextBox.Text)
        Dim testParam2 As New ReportParameter("prayercalled", Form8.PrayerPeronTextBox.Text)
        Dim testParam3 As New ReportParameter("rollcall", Form8.RollCallTextBox.Text)
        Dim testParam4 As New ReportParameter("sick", Form8.SicknessAndDistressTextBox.Text)
        Dim testParam5 As New ReportParameter("reading", Form8.ReadingOfMintesTextBox.Text)
        Dim testParam6 As New ReportParameter("treasure", Form8.TreasureReportTextBox.Text)
        Dim testParam7 As New ReportParameter("committe", Form8.CommitteeReportTextBox.Text)
        Dim testParam8 As New ReportParameter("unfinish", Form8.UnfinishedBusinessTextBox.Text)
        Dim testParam9 As New ReportParameter("new", Form8.NewBusinessTextBox.Text)
        Dim testParam10 As New ReportParameter("communications", Form8.CommunicationsTextBox.Text)
        Dim testParam12 As New ReportParameter("end", Form8.TimeEndTextBox.Text)
        Dim testParam13 As New ReportParameter("date", Form8.DateOfMeetingTextBox.Text)

        ReportViewer1.LocalReport.SetParameters(testParam)
        ReportViewer1.LocalReport.SetParameters(testParam1)
        ReportViewer1.LocalReport.SetParameters(testParam2)
        ReportViewer1.LocalReport.SetParameters(testParam3)
        ReportViewer1.LocalReport.SetParameters(testParam4)
        ReportViewer1.LocalReport.SetParameters(testParam5)
        ReportViewer1.LocalReport.SetParameters(testParam6)
        ReportViewer1.LocalReport.SetParameters(testParam7)
        ReportViewer1.LocalReport.SetParameters(testParam8)
        ReportViewer1.LocalReport.SetParameters(testParam9)
        ReportViewer1.LocalReport.SetParameters(testParam10)
        ReportViewer1.LocalReport.SetParameters(testParam12)
        ReportViewer1.LocalReport.SetParameters(testParam13)
        'Me.ReportViewer1.RefreshReport()
    End Sub
    Private Sub Form10_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'OESDataSet.tblDate' table. You can move, or remove it, as needed.
        Me.TblDateTableAdapter.Fill(Me.OESDataSet.tblDate)
        'TODO: This line of code loads data into the 'OESDataSet.DateRoll' table. You can move, or remove it, as needed.
        Me.DateRollTableAdapter.Fill(Me.OESDataSet.DateRoll)
        TextBox1.Text = Form8.DateOfMeetingTextBox.Text
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Try
            'DateOfMeetingComboBox.Refresh()
            reports()
            Dim DATEROLL As New ReportParameter("DATEROLL", Form8.DateOfMeetingTextBox.Text)

            Me.DateRollTableAdapter.Fill(Me.OESDataSet.DateRoll)
            ReportViewer1.LocalReport.SetParameters(New ReportParameter() {DATEROLL})
            Me.ReportViewer1.RefreshReport()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
End Class