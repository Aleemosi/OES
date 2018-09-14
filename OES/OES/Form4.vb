Public Class Form4
    Public TitleFirstLast As String
    Public MemberID As Integer
    Private Sub Form4_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'OESDataSet.tblMember' table. You can move, or remove it, as needed.
        Me.TblMemberTableAdapter.FillBy(Me.OESDataSet.tblMember, TitleFirstLast)
        'TODO: This line of code loads data into the 'OESDataSet.tblDues' table. You can move, or remove it, as needed.
        Me.TblDuesTableAdapter.FillBy(Me.OESDataSet.tblDues, MemberID)
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Try
            MessageBox.Show("ADD DUES FOR " & TitleFirstLastTextBox.Text, "ADD")
            TblDuesBindingSource.AddNew()
            MemberIDTextBox.Text = MemberIDTextBox1.Text
        Catch ex As Exception
            MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Question)
        End Try
    End Sub
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Try
            Me.Validate()
            Me.TblDuesBindingSource.EndEdit()
            Me.TableAdapterManager.UpdateAll(Me.OESDataSet)
            MessageBox.Show("DUES FOR " & TitleFirstLastTextBox.Text & " SAVED!", "SAVE")
            Form3.Show()
            Me.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Question)
        End Try
    End Sub
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Form3.Show()
        Me.Close()
    End Sub
    Private Sub YearlyDuesTextBox_TextChanged(sender As Object, e As EventArgs) Handles YearlyDuesTextBox.TextChanged
        Dim result, result1 As Integer
        result = Val(DuesTextBox.Text) / 45
        YearlyDuesTextBox.Text = result
        result1 = Val(DuesTextBox.Text) * 1
        TotalTextBox.Text = "$" & result1

        Dim dateEntered As String = PaymentDateDateTimePicker.Value.ToShortDateString
        Dim monthsEntered As String = YearlyDuesTextBox.Text

        Dim dateValue As Date = Date.Parse(dateEntered)
        Dim monthsValue As Integer = Integer.Parse(monthsEntered)

        Dim newDate As Date = DateAdd(DateInterval.Year, monthsValue, dateValue)

        DuesExpirationTextBox.Text = newDate.ToShortDateString

        If PaymentDateDateTimePicker.Value > DuesExpirationTextBox.Text Then
            StatusComboBox.Text = "Active"
        End If

        If CDate(PaymentDateDateTimePicker.Value) < CDate(DuesExpirationTextBox.Text) Then
            StatusComboBox.Text = "Not Current"
        End If
    End Sub
End Class