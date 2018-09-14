Imports System.Data.OleDb
Public Class Form1
    Private conn As OleDbConnection
    Private dapt As OleDbDataAdapter
    Private Sub MyConnection()
        conn = New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\OES.accdb")
        conn.Open()
    End Sub
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        MyConnection()
    End Sub
    Private Sub MetroButton1_Click(sender As Object, e As EventArgs) Handles MetroButton1.Click
        Try
            Dim tbl As New DataTable
            MyConnection()
            dapt = New OleDbDataAdapter("Select * From Login Where UserName='" & MetroTextBox1.Text & "' and Password='" & MetroTextBox2.Text & "'", conn)
            dapt.Fill(tbl)
            If tbl.Rows.Count > 0 Then
                MetroFramework.MetroMessageBox.Show(Me, "YOU ARE LOGGED IN!", "LOGIN")
                Form2.Show()
                Do While Form2.MetroPanel1.Width < 587
                    Form2.MetroPanel1.Width = Form2.MetroPanel1.Width + 1
                Loop
                Form2.Text = "OES SYSTEM MAIN MENU"
                Form2.MetroTextBox1.Visible = False
                Form2.MetroTextBox2.Visible = False
                Form2.MetroButton3.Visible = False
                Form2.Show()
                MetroFramework.MetroMessageBox.Show(Form2, "MAKE SURE THAT YOU READ THE OES DATA INSTRUCTIONS BEFORE USING THE SYSTEM!", "INFORMATION", MessageBoxButtons.OK, MessageBoxIcon.Information)
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
        Me.Close()
    End Sub
End Class
