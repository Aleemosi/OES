Public Class Form5
    Private Sub Form5_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'OESDataSet.tblMember' table. You can move, or remove it, as needed.
        Me.tblMemberTableAdapter.Fill(Me.OESDataSet.tblMember)
        Me.ReportViewer1.RefreshReport()
    End Sub
End Class