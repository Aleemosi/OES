Imports System.Data.OleDb
Public Class Form16
    Private conn As OleDbConnection
    Private dapt As OleDbDataAdapter
    Private Sub MyConnection()
        conn = New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\OES.accdb")
        conn.Open()
    End Sub
    Private Sub Form16_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        MyConnection()
    End Sub
    Private Sub MetroButton1_Click(sender As Object, e As EventArgs) Handles MetroButton1.Click
        Try
            Dim tbl As New DataTable
            MyConnection()
            dapt = New OleDbDataAdapter("Select * From Login1 Where Username='" & MetroTextBox1.Text & "' and Password='" & MetroTextBox2.Text & "'", conn)
            dapt.Fill(tbl)
            If tbl.Rows.Count > 0 Then
                MetroFramework.MetroMessageBox.Show(Me, "YOU ARE LOGGED IN!", "LOGIN")
                Form20.Show()
                Me.Close()
            Else
                MetroFramework.MetroMessageBox.Show(Me, "SORRY..USER AND OR PASSWORD ARE WRONG!")
                MetroTextBox1.Clear()
                MetroTextBox2.Clear()
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    Private Sub MetroButton2_Click(sender As Object, e As EventArgs) Handles MetroButton2.Click
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
End Class