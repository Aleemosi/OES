Imports System.Data.OleDb
Public Class Form2
    Private conn As OleDbConnection
    Private dapt As OleDbDataAdapter
    Private Sub MyConnection()
        conn = New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\OES.accdb")
        conn.Open()
    End Sub
    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        MyConnection()
    End Sub
    Private Sub MetroTile1_Click(sender As Object, e As EventArgs) Handles MetroTile1.Click
        Form3.Show()
    End Sub
    Private Sub MetroTile2_Click(sender As Object, e As EventArgs) Handles MetroTile2.Click
        Form8.Show()
        Me.Close()
    End Sub
    Private Sub MetroTile3_Click(sender As Object, e As EventArgs) Handles MetroTile3.Click
        Form16.Show()
        Me.Close()
    End Sub
    Private Sub MetroButton1_Click(sender As Object, e As EventArgs) Handles MetroButton1.Click
        Dim dialog As DialogResult
        dialog = MetroFramework.MetroMessageBox.Show(Me, "LOGGIN OFF?", "LOG OFF", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If dialog = DialogResult.No Then
        Else
            Do While MetroPanel1.Width > 2
                MetroPanel1.Width = MetroPanel1.Width - 1
            Loop
            Me.Text = "OES SYSTEM MAIN MENU LOGGED OUT"
            MetroTextBox1.Visible = True
            MetroTextBox2.Visible = True
            MetroButton3.Visible = True
            MetroTextBox1.Clear()
            MetroTextBox2.Clear()
        End If
        'Dim dialog As DialogResult
        'dialog = MessageBox.Show("Would you like to Log off?", "LOG OFF", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        'If dialog = DialogResult.No Then
        'Else
        '    MessageBox.Show("LOGGED OFF", "LOG OFF")
        '    Splash2.Show()
        '    Me.Close()
        '    Form3.Close()
        'End If
    End Sub
    Private Sub MetroButton2_Click(sender As Object, e As EventArgs) Handles MetroButton2.Click
        Dim dialog As DialogResult
        dialog = MetroFramework.MetroMessageBox.Show(Me, "Would you like to Log off?", "LOG OFF", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If dialog = DialogResult.No Then
        Else
            MetroFramework.MetroMessageBox.Show(Me, "LOGGED OFF", "LOG OFF")
            Splash2.Show()
            Me.Close()
            Form3.Close()
        End If
    End Sub
    Private Sub MetroTile4_Click(sender As Object, e As EventArgs) Handles MetroTile4.Click
        Form9.Show()
        Me.Close()
    End Sub
    Private Sub MetroTile5_Click(sender As Object, e As EventArgs) Handles MetroTile5.Click
        Form21.Show()
    End Sub

    Private Sub MetroTile6_Click(sender As Object, e As EventArgs) Handles MetroTile6.Click
        Form7.Show()
        Me.Close()
    End Sub

    Private Sub MetroButton3_Click(sender As Object, e As EventArgs) Handles MetroButton3.Click
        Try
            Dim tbl As New DataTable
            MyConnection()
            dapt = New OleDbDataAdapter("Select * From Login Where UserName='" & MetroTextBox1.Text & "' and Password='" & MetroTextBox2.Text & "'", conn)
            dapt.Fill(tbl)
            If tbl.Rows.Count > 0 Then
                MetroFramework.MetroMessageBox.Show(Me, "WECLOME!", "LOGGIN")
                Do While MetroPanel1.Width < 587
                    MetroPanel1.Width = MetroPanel1.Width + 1
                Loop
                MetroTextBox1.Visible = False
                MetroTextBox2.Visible = False
                MetroButton3.Visible = False
                MetroFramework.MetroMessageBox.Show(Me, "MAKE SURE THAT YOU READ THE OES DATA INSTRUCTIONS BEFORE USING THE SYSTEM!", "INFORMATION", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                MetroFramework.MetroMessageBox.Show(Me, "SORRY..USER AND OR PASSWORD ARE WRONG!")
                MetroTextBox1.Clear()
                MetroTextBox2.Clear()
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
End Class