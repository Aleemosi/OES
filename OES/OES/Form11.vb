Public Class Form11
    Private Sub TotalSum()
        Dim sum As Integer = 0
        For i As Integer = 0 To TblTreasureDataGridView.Rows.Count() - 1 Step +1
            sum = sum + TblTreasureDataGridView.Rows(i).Cells(8).Value
        Next
        Label4.Text = "$" & sum.ToString()
    End Sub

    Private Sub Form11_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'OESDataSet.tblTreasure' table. You can move, or remove it, as needed.
        Me.TblTreasureTableAdapter.Fill(Me.OESDataSet.tblTreasure)
        'TODO: This line of code loads data into the 'OESDataSet.tblDate' table. You can move, or remove it, as needed.
        Me.TblDateTableAdapter.Fill(Me.OESDataSet.tblDate)
        TotalSum()
    End Sub
    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        Form7.Show()
        Me.Close()
    End Sub
    Private Sub Button10_Click(sender As Object, e As EventArgs) Handles Button10.Click
        Form8.Show()
        Me.Close()
    End Sub
    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Dim F12 As New Form12
        Try
            F12.DateID = DateIDTextBox.Text
            F12.DateOfMeeting = DateOfMeetingTextBox.Text
            F12.Show()
            Me.Close()
        Catch ex As Exception
            MessageBox.Show("PLEASE ADD A DATE OF YOUR MEETING FOR YOUR TREASURE REPORT!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Try
            Me.Validate()
            Me.TblTreasureBindingSource.EndEdit()
            Me.TableAdapterManager.UpdateAll(Me.OESDataSet)
            MessageBox.Show("TREASURE REPORT FOR DATE " & DateOfMeetingTextBox.Text & " DAVED", "SAVE")
        Catch ex As Exception
            MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    Private Sub Button11_Click(sender As Object, e As EventArgs) Handles Button11.Click
        Try
            Dim dialog As DialogResult
            dialog = MessageBox.Show("Would you like to delete the treasure report for date " & DateOfMeetingTextBox.Text & "?", "DELETE", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            If dialog = DialogResult.No Then
            Else
                MessageBox.Show("TREASURE REPORT DELETED!", "DELETE")
                Me.TblTreasureBindingSource.RemoveCurrent()
                Me.TblTreasureBindingSource.EndEdit()
                Me.TableAdapterManager.UpdateAll(Me.OESDataSet)
                MessageBox.Show("TREAUSE REPORT UPDATED", "UPDATE")
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        TblTreasureBindingSource.MovePrevious()
    End Sub
    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        TblTreasureBindingSource.MoveNext()
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        TblDateBindingSource.MoveFirst()
        TotalSum()
    End Sub
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        TblDateBindingSource.MovePrevious()
        TotalSum()
    End Sub
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        TblDateBindingSource.MoveNext()
        TotalSum()
    End Sub
    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        TblDateBindingSource.MoveLast()
        TotalSum()
    End Sub
    Private Sub Button12_Click(sender As Object, e As EventArgs) Handles Button12.Click
        Form13.Show()
    End Sub
End Class