Public Class Form3
    Private Sub Form3_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'OESDataSet.tblDues' table. You can move, or remove it, as needed.
        Me.TblDuesTableAdapter.Fill(Me.OESDataSet.tblDues)
        'TODO: This line of code loads data into the 'OESDataSet.tblMember' table. You can move, or remove it, as needed.
        Me.TblMemberTableAdapter.Fill(Me.OESDataSet.tblMember)
        Label1.Text = MemberIDTextBox.Text
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Try
            MessageBox.Show("ADD NEW MEMBER!", "ADD")
            Me.TblMemberBindingSource.AddNew()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Question)
        End Try
    End Sub
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Try
            TitleFirstLastTextBox.Text = TitleComboBox.Text & " " & FirstNameTextBox.Text & " " & LastNameTextBox.Text
            Me.Validate()
            Me.TblMemberBindingSource.EndEdit()
            Me.TableAdapterManager.UpdateAll(Me.OESDataSet)
            MessageBox.Show("MEMBER " & TitleFirstLastTextBox.Text & " SAVED!", "SAVE")
            Splash3.Show()
            Me.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Question)
        End Try
    End Sub
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Try
            Dim dialog As DialogResult
            dialog = MessageBox.Show("Would you like to delete " & TitleFirstLastTextBox.Text & " form the member data?", "DELETE", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            If dialog = DialogResult.No Then
            Else
                MessageBox.Show("MEMBER DELETED FROM THE DATA!", "DELETE")
                TblMemberBindingSource.RemoveCurrent()
                Me.Validate()
                Me.TblMemberBindingSource.EndEdit()
                Me.TableAdapterManager.UpdateAll(Me.OESDataSet)
                MessageBox.Show("MEMBER DATA UPDATED!", "UPDATE")
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Question)
        End Try
    End Sub
    Dim count As Integer = 0
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        count = TblMemberBindingSource.Count
        If count > 1 And 2 Then
            Pre.Visible = True
            Nxt.Visible = True
        End If
        If count <= 1 And 2 Then
            Pre.Visible = False
            Nxt.Visible = False
        End If
        Label2.Text = "OF   " & count
    End Sub
    Private Sub Pre_Click(sender As Object, e As EventArgs) Handles Pre.Click
        TblMemberBindingSource.MovePrevious()
        Label1.Text = MemberIDTextBox.Text
    End Sub
    Private Sub Nxt_Click(sender As Object, e As EventArgs) Handles Nxt.Click
        TblMemberBindingSource.MoveNext()
        Label1.Text = MemberIDTextBox.Text
    End Sub
    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Dim F4 As New Form4
        Try
            F4.MemberID = MemberIDTextBox.Text
            F4.TitleFirstLast = TitleFirstLastTextBox.Text
            F4.Show()
            Me.Close()
        Catch ex As Exception
            MessageBox.Show("PLEASE ADD A NEW MEMBER BEFORE PRECEDING!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        Try
            Me.Validate()
            Me.TblDuesBindingSource.EndEdit()
            Me.TableAdapterManager.UpdateAll(Me.OESDataSet)
            MessageBox.Show("MEMBER'S DUES UPDATED", "UPDATE")
        Catch ex As Exception
            MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Question)
        End Try
    End Sub
    Private Sub Button11_Click(sender As Object, e As EventArgs) Handles Button11.Click
        Try
            Dim dialog As DialogResult
            dialog = MessageBox.Show("Would like to delete " & TitleFirstLastTextBox.Text & "'s dues?", "DELETE", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            If dialog = DialogResult.No Then
            Else
                MessageBox.Show(TitleFirstLastTextBox.Text & "'S DUES DELETED!", "DELETE")
                TblDuesBindingSource.RemoveCurrent()
                Me.Validate()
                Me.TblDuesBindingSource.EndEdit()
                Me.TableAdapterManager.UpdateAll(Me.OESDataSet)
                MessageBox.Show(TitleFirstLastTextBox.Text & "'S DUES UPDATED", "UPDATE")
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Question)
        End Try
    End Sub
    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        TblDuesBindingSource.MovePrevious()
    End Sub
    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        TblDuesBindingSource.MoveNext()
    End Sub
    Private Sub Button10_Click(sender As Object, e As EventArgs) Handles Button10.Click
        Form5.ShowDialog()
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Form6.ShowDialog()
    End Sub
End Class