Public Class Form21
    Private Sub Form21_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        OpenFileDialog1.Filter = "PDF Files |OES DATA SYSTEM INSTRUCTIONS.pdf"
        'AxAcroPDF1.src = OpenFileDialog1.FileName
        If OpenFileDialog1.ShowDialog = DialogResult.OK Then
            AxAcroPDF1.src = OpenFileDialog1.FileName
        End If
    End Sub
End Class