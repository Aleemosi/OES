Imports Microsoft.Office.Interop
Public Class Form8
    Private Sub Form8_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'OESDataSet.tblDate' table. You can move, or remove it, as needed.
        Me.TblDateTableAdapter.Fill(Me.OESDataSet.tblDate)
        'TODO: This line of code loads data into the 'OESDataSet.tblMinutes' table. You can move, or remove it, as needed.
        Me.TblMinutesTableAdapter.Fill(Me.OESDataSet.tblMinutes)
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        SpellCheck()
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Try
            MessageBox.Show("ADD NEW MINUTES FOR DATE " & DateOfMeetingTextBox.Text & "", "ADD")
            Me.TblMinutesBindingSource.AddNew()
            DateIDTextBox.Text = DateIDTextBox1.Text
        Catch ex As Exception
            MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Try
            Me.Validate()
            Me.TblMinutesBindingSource.EndEdit()
            Me.TableAdapterManager.UpdateAll(Me.OESDataSet)
            MessageBox.Show("MINUTES FOR DATE " & DateOfMeetingTextBox.Text & " SAVED", "SAVE")
        Catch ex As Exception
            MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Try
            Dim dialog As DialogResult
            dialog = MessageBox.Show("Would you like to delete the minutes of date " & DateOfMeetingTextBox.Text & "?", "DELETE", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            If dialog = DialogResult.No Then
            Else
                MessageBox.Show("MINUTES DELETED!", "DELETE")
                Me.TblMinutesBindingSource.RemoveCurrent()
                Me.Validate()
                Me.TblMinutesBindingSource.EndEdit()
                Me.TableAdapterManager.UpdateAll(Me.OESDataSet)
                MessageBox.Show("MINUTES UPDATED!", "UPDATE")
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    Private Sub Button11_Click(sender As Object, e As EventArgs) Handles Button11.Click
        Try
            Dim dialog As DialogResult
            dialog = MessageBox.Show("Before deleting make sure that you delete all associated data that includes with this date." & vbNewLine & "Would you like to delete?", "DELETE", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            If dialog = DialogResult.No Then
            Else
                Me.TblDateBindingSource.RemoveCurrent()
                Me.Validate()
                Me.TblDateBindingSource.EndEdit()
                Me.TblDateTableAdapter.Update(Me.OESDataSet.tblDate)
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        TblDateBindingSource.MoveFirst()
        TblMinutesBindingSource.MoveFirst()
    End Sub
    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        TblDateBindingSource.MovePrevious()
        TblMinutesBindingSource.MovePrevious()
    End Sub
    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        TblDateBindingSource.MoveNext()
        TblMinutesBindingSource.MoveNext()
    End Sub
    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        TblDateBindingSource.MoveLast()
        TblMinutesBindingSource.MoveLast()
    End Sub
    Private Sub Button10_Click(sender As Object, e As EventArgs) Handles Button10.Click
        Do While Form2.MetroPanel1.Width < 587
            Form2.MetroPanel1.Width = Form2.MetroPanel1.Width + 1
        Loop
        Form2.Text = "OES SYSTEM MAIN MENU"
        Form2.MetroTextBox1.Visible = False
        Form2.MetroTextBox2.Visible = False
        Form2.MetroButton3.Visible = False
        Form2.Show()
        Me.Close()
    End Sub
    Private Sub Button12_Click(sender As Object, e As EventArgs) Handles Button12.Click
        Form10.Show()
    End Sub
    Private Sub Button13_Click(sender As Object, e As EventArgs) Handles Button13.Click
        Form7.Show()
        Me.Close()
    End Sub

    Sub SpellCheck()
        If RollCallTextBox.Text.Length > 0 Then
            Dim wordRapp As New Word.Application
            wordRapp.Visible = False
            Dim doc As Word.Document = wordRapp.Documents.Add()
            Dim range As Word.Range
            range = doc.Range()
            range.Text = RollCallTextBox.Text
            doc.Activate()
            doc.CheckSpelling()
            Dim chars() As Char = {CType(vbCr, Char), CType(vbLf, Char)}
            RollCallTextBox.Text = doc.Range().Text.Trim(chars)
            doc.Close(SaveChanges:=False)
            wordRapp.Quit()
        End If

        If SicknessAndDistressTextBox.Text.Length > 0 Then
            Dim wordRapp As New Word.Application
            wordRapp.Visible = False
            Dim doc As Word.Document = wordRapp.Documents.Add()
            Dim range As Word.Range
            range = doc.Range()
            range.Text = SicknessAndDistressTextBox.Text
            doc.Activate()
            doc.CheckSpelling()
            Dim chars() As Char = {CType(vbCr, Char), CType(vbLf, Char)}
            SicknessAndDistressTextBox.Text = doc.Range().Text.Trim(chars)
            doc.Close(SaveChanges:=False)
            wordRapp.Quit()
        End If

        If ReadingOfMintesTextBox.Text.Length > 0 Then
            Dim wordRapp As New Word.Application
            wordRapp.Visible = False
            Dim doc As Word.Document = wordRapp.Documents.Add()
            Dim range As Word.Range
            range = doc.Range()
            range.Text = ReadingOfMintesTextBox.Text
            doc.Activate()
            doc.CheckSpelling()
            Dim chars() As Char = {CType(vbCr, Char), CType(vbLf, Char)}
            ReadingOfMintesTextBox.Text = doc.Range().Text.Trim(chars)
            doc.Close(SaveChanges:=False)
            wordRapp.Quit()
        End If

        If TreasureReportTextBox.Text.Length > 0 Then
            Dim wordRapp As New Word.Application
            wordRapp.Visible = False
            Dim doc As Word.Document = wordRapp.Documents.Add()
            Dim range As Word.Range
            range = doc.Range()
            range.Text = TreasureReportTextBox.Text
            doc.Activate()
            doc.CheckSpelling()
            Dim chars() As Char = {CType(vbCr, Char), CType(vbLf, Char)}
            TreasureReportTextBox.Text = doc.Range().Text.Trim(chars)
            doc.Close(SaveChanges:=False)
            wordRapp.Quit()
        End If

        If CommitteeReportTextBox.Text.Length > 0 Then
            Dim wordRapp As New Word.Application
            wordRapp.Visible = False
            Dim doc As Word.Document = wordRapp.Documents.Add()
            Dim range As Word.Range
            range = doc.Range()
            range.Text = CommitteeReportTextBox.Text
            doc.Activate()
            doc.CheckSpelling()
            Dim chars() As Char = {CType(vbCr, Char), CType(vbLf, Char)}
            CommitteeReportTextBox.Text = doc.Range().Text.Trim(chars)
            doc.Close(SaveChanges:=False)
            wordRapp.Quit()
        End If

        If UnfinishedBusinessTextBox.Text.Length > 0 Then
            Dim wordRapp As New Word.Application
            wordRapp.Visible = False
            Dim doc As Word.Document = wordRapp.Documents.Add()
            Dim range As Word.Range
            range = doc.Range()
            range.Text = UnfinishedBusinessTextBox.Text
            doc.Activate()
            doc.CheckSpelling()
            Dim chars() As Char = {CType(vbCr, Char), CType(vbLf, Char)}
            UnfinishedBusinessTextBox.Text = doc.Range().Text.Trim(chars)
            doc.Close(SaveChanges:=False)
            wordRapp.Quit()
        End If

        If NewBusinessTextBox.Text.Length > 0 Then
            Dim wordRapp As New Word.Application
            wordRapp.Visible = False
            Dim doc As Word.Document = wordRapp.Documents.Add()
            Dim range As Word.Range
            range = doc.Range()
            range.Text = NewBusinessTextBox.Text
            doc.Activate()
            doc.CheckSpelling()
            Dim chars() As Char = {CType(vbCr, Char), CType(vbLf, Char)}
            NewBusinessTextBox.Text = doc.Range().Text.Trim(chars)
            doc.Close(SaveChanges:=False)
            wordRapp.Quit()
        End If

        If CommitteeReportTextBox.Text.Length > 0 Then
            Dim wordRapp As New Word.Application
            wordRapp.Visible = False
            Dim doc As Word.Document = wordRapp.Documents.Add()
            Dim range As Word.Range
            range = doc.Range()
            range.Text = CommunicationsTextBox.Text
            doc.Activate()
            doc.CheckSpelling()
            Dim chars() As Char = {CType(vbCr, Char), CType(vbLf, Char)}
            CommunicationsTextBox.Text = doc.Range().Text.Trim(chars)
            doc.Close(SaveChanges:=False)
            wordRapp.Quit()
        End If
    End Sub
End Class