<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form20
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim LoginIDLabel As System.Windows.Forms.Label
        Dim UsernameLabel As System.Windows.Forms.Label
        Dim PasswordLabel As System.Windows.Forms.Label
        Dim LoginIDLabel1 As System.Windows.Forms.Label
        Dim UserNameLabel1 As System.Windows.Forms.Label
        Dim PasswordLabel1 As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form20))
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.OESDataSet = New OES.OESDataSet()
        Me.Login1BindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Login1TableAdapter = New OES.OESDataSetTableAdapters.Login1TableAdapter()
        Me.TableAdapterManager = New OES.OESDataSetTableAdapters.TableAdapterManager()
        Me.LoginBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.LoginTableAdapter = New OES.OESDataSetTableAdapters.LoginTableAdapter()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.LoginIDTextBox = New System.Windows.Forms.TextBox()
        Me.UsernameTextBox = New System.Windows.Forms.TextBox()
        Me.PasswordTextBox = New System.Windows.Forms.TextBox()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.Button10 = New System.Windows.Forms.Button()
        Me.Button9 = New System.Windows.Forms.Button()
        Me.Button8 = New System.Windows.Forms.Button()
        Me.Button7 = New System.Windows.Forms.Button()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.LoginIDTextBox1 = New System.Windows.Forms.TextBox()
        Me.UserNameTextBox1 = New System.Windows.Forms.TextBox()
        Me.PasswordTextBox1 = New System.Windows.Forms.TextBox()
        Me.Button11 = New System.Windows.Forms.Button()
        LoginIDLabel = New System.Windows.Forms.Label()
        UsernameLabel = New System.Windows.Forms.Label()
        PasswordLabel = New System.Windows.Forms.Label()
        LoginIDLabel1 = New System.Windows.Forms.Label()
        UserNameLabel1 = New System.Windows.Forms.Label()
        PasswordLabel1 = New System.Windows.Forms.Label()
        Me.TabControl1.SuspendLayout()
        CType(Me.OESDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Login1BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LoginBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage1.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        Me.SuspendLayout()
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TabControl1.Location = New System.Drawing.Point(-1, 27)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(371, 188)
        Me.TabControl1.TabIndex = 0
        '
        'OESDataSet
        '
        Me.OESDataSet.DataSetName = "OESDataSet"
        Me.OESDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Login1BindingSource
        '
        Me.Login1BindingSource.DataMember = "Login1"
        Me.Login1BindingSource.DataSource = Me.OESDataSet
        '
        'Login1TableAdapter
        '
        Me.Login1TableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.Login1TableAdapter = Me.Login1TableAdapter
        Me.TableAdapterManager.LoginTableAdapter = Me.LoginTableAdapter
        Me.TableAdapterManager.tblDateTableAdapter = Nothing
        Me.TableAdapterManager.tblDuesTableAdapter = Nothing
        Me.TableAdapterManager.tblMemberTableAdapter = Nothing
        Me.TableAdapterManager.tblMinutesTableAdapter = Nothing
        Me.TableAdapterManager.tblOfficerTableAdapter = Nothing
        Me.TableAdapterManager.tblTreasureTableAdapter = Nothing
        Me.TableAdapterManager.tblVisitorTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = OES.OESDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'LoginBindingSource
        '
        Me.LoginBindingSource.DataMember = "Login"
        Me.LoginBindingSource.DataSource = Me.OESDataSet
        '
        'LoginTableAdapter
        '
        Me.LoginTableAdapter.ClearBeforeFill = True
        '
        'TabPage1
        '
        Me.TabPage1.BackColor = System.Drawing.Color.LightBlue
        Me.TabPage1.BackgroundImage = Global.OES.My.Resources.Resources.Mason
        Me.TabPage1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.TabPage1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.TabPage1.Controls.Add(Me.Button5)
        Me.TabPage1.Controls.Add(Me.Button4)
        Me.TabPage1.Controls.Add(Me.Button3)
        Me.TabPage1.Controls.Add(Me.Button2)
        Me.TabPage1.Controls.Add(Me.Button1)
        Me.TabPage1.Controls.Add(LoginIDLabel)
        Me.TabPage1.Controls.Add(Me.LoginIDTextBox)
        Me.TabPage1.Controls.Add(UsernameLabel)
        Me.TabPage1.Controls.Add(Me.UsernameTextBox)
        Me.TabPage1.Controls.Add(PasswordLabel)
        Me.TabPage1.Controls.Add(Me.PasswordTextBox)
        Me.TabPage1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TabPage1.ForeColor = System.Drawing.Color.White
        Me.TabPage1.Location = New System.Drawing.Point(4, 24)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(363, 160)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "ADMINISTRATOR ADD/DELETE"
        '
        'Button5
        '
        Me.Button5.ForeColor = System.Drawing.Color.Black
        Me.Button5.Location = New System.Drawing.Point(193, 129)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(35, 23)
        Me.Button5.TabIndex = 10
        Me.Button5.Text = ">"
        Me.Button5.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.ForeColor = System.Drawing.Color.Black
        Me.Button4.Location = New System.Drawing.Point(153, 129)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(34, 23)
        Me.Button4.TabIndex = 9
        Me.Button4.Text = "<"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.ForeColor = System.Drawing.Color.Black
        Me.Button3.Location = New System.Drawing.Point(234, 100)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(75, 23)
        Me.Button3.TabIndex = 8
        Me.Button3.Text = "DELETE"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.ForeColor = System.Drawing.Color.Black
        Me.Button2.Location = New System.Drawing.Point(153, 100)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 23)
        Me.Button2.TabIndex = 7
        Me.Button2.Text = "SAVE"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.ForeColor = System.Drawing.Color.Black
        Me.Button1.Location = New System.Drawing.Point(72, 100)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 6
        Me.Button1.Text = "ADD"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'LoginIDLabel
        '
        LoginIDLabel.AutoSize = True
        LoginIDLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        LoginIDLabel.ForeColor = System.Drawing.Color.Black
        LoginIDLabel.Location = New System.Drawing.Point(1, 3)
        LoginIDLabel.Name = "LoginIDLabel"
        LoginIDLabel.Size = New System.Drawing.Size(65, 15)
        LoginIDLabel.TabIndex = 0
        LoginIDLabel.Text = "Login ID:"
        '
        'LoginIDTextBox
        '
        Me.LoginIDTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Login1BindingSource, "LoginID", True))
        Me.LoginIDTextBox.Location = New System.Drawing.Point(72, 2)
        Me.LoginIDTextBox.Name = "LoginIDTextBox"
        Me.LoginIDTextBox.Size = New System.Drawing.Size(47, 20)
        Me.LoginIDTextBox.TabIndex = 1
        '
        'UsernameLabel
        '
        UsernameLabel.AutoSize = True
        UsernameLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        UsernameLabel.ForeColor = System.Drawing.Color.Black
        UsernameLabel.Location = New System.Drawing.Point(7, 38)
        UsernameLabel.Name = "UsernameLabel"
        UsernameLabel.Size = New System.Drawing.Size(77, 15)
        UsernameLabel.TabIndex = 2
        UsernameLabel.Text = "Username:"
        '
        'UsernameTextBox
        '
        Me.UsernameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Login1BindingSource, "Username", True))
        Me.UsernameTextBox.Location = New System.Drawing.Point(90, 37)
        Me.UsernameTextBox.Name = "UsernameTextBox"
        Me.UsernameTextBox.Size = New System.Drawing.Size(188, 20)
        Me.UsernameTextBox.TabIndex = 3
        '
        'PasswordLabel
        '
        PasswordLabel.AutoSize = True
        PasswordLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        PasswordLabel.ForeColor = System.Drawing.Color.Black
        PasswordLabel.Location = New System.Drawing.Point(11, 75)
        PasswordLabel.Name = "PasswordLabel"
        PasswordLabel.Size = New System.Drawing.Size(73, 15)
        PasswordLabel.TabIndex = 4
        PasswordLabel.Text = "Password:"
        '
        'PasswordTextBox
        '
        Me.PasswordTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Login1BindingSource, "Password", True))
        Me.PasswordTextBox.Location = New System.Drawing.Point(90, 74)
        Me.PasswordTextBox.Name = "PasswordTextBox"
        Me.PasswordTextBox.Size = New System.Drawing.Size(188, 20)
        Me.PasswordTextBox.TabIndex = 5
        '
        'TabPage2
        '
        Me.TabPage2.BackColor = System.Drawing.Color.LightBlue
        Me.TabPage2.BackgroundImage = Global.OES.My.Resources.Resources.OES_PIC_1
        Me.TabPage2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.TabPage2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.TabPage2.Controls.Add(Me.Button10)
        Me.TabPage2.Controls.Add(Me.Button9)
        Me.TabPage2.Controls.Add(Me.Button8)
        Me.TabPage2.Controls.Add(Me.Button7)
        Me.TabPage2.Controls.Add(Me.Button6)
        Me.TabPage2.Controls.Add(LoginIDLabel1)
        Me.TabPage2.Controls.Add(Me.LoginIDTextBox1)
        Me.TabPage2.Controls.Add(UserNameLabel1)
        Me.TabPage2.Controls.Add(Me.UserNameTextBox1)
        Me.TabPage2.Controls.Add(PasswordLabel1)
        Me.TabPage2.Controls.Add(Me.PasswordTextBox1)
        Me.TabPage2.Location = New System.Drawing.Point(4, 24)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(363, 160)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "LOGIN ADD/DELETE"
        '
        'Button10
        '
        Me.Button10.Location = New System.Drawing.Point(198, 123)
        Me.Button10.Name = "Button10"
        Me.Button10.Size = New System.Drawing.Size(35, 23)
        Me.Button10.TabIndex = 10
        Me.Button10.Text = ">"
        Me.Button10.UseVisualStyleBackColor = True
        '
        'Button9
        '
        Me.Button9.Location = New System.Drawing.Point(158, 123)
        Me.Button9.Name = "Button9"
        Me.Button9.Size = New System.Drawing.Size(34, 23)
        Me.Button9.TabIndex = 9
        Me.Button9.Text = "<"
        Me.Button9.UseVisualStyleBackColor = True
        '
        'Button8
        '
        Me.Button8.Location = New System.Drawing.Point(239, 94)
        Me.Button8.Name = "Button8"
        Me.Button8.Size = New System.Drawing.Size(75, 23)
        Me.Button8.TabIndex = 8
        Me.Button8.Text = "DELETE"
        Me.Button8.UseVisualStyleBackColor = True
        '
        'Button7
        '
        Me.Button7.Location = New System.Drawing.Point(158, 94)
        Me.Button7.Name = "Button7"
        Me.Button7.Size = New System.Drawing.Size(75, 23)
        Me.Button7.TabIndex = 7
        Me.Button7.Text = "SAVE"
        Me.Button7.UseVisualStyleBackColor = True
        '
        'Button6
        '
        Me.Button6.Location = New System.Drawing.Point(77, 94)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(75, 23)
        Me.Button6.TabIndex = 6
        Me.Button6.Text = "ADD"
        Me.Button6.UseVisualStyleBackColor = True
        '
        'LoginIDLabel1
        '
        LoginIDLabel1.AutoSize = True
        LoginIDLabel1.Location = New System.Drawing.Point(6, 3)
        LoginIDLabel1.Name = "LoginIDLabel1"
        LoginIDLabel1.Size = New System.Drawing.Size(65, 15)
        LoginIDLabel1.TabIndex = 0
        LoginIDLabel1.Text = "Login ID:"
        '
        'LoginIDTextBox1
        '
        Me.LoginIDTextBox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.LoginBindingSource, "LoginID", True))
        Me.LoginIDTextBox1.Location = New System.Drawing.Point(77, 2)
        Me.LoginIDTextBox1.Name = "LoginIDTextBox1"
        Me.LoginIDTextBox1.Size = New System.Drawing.Size(43, 21)
        Me.LoginIDTextBox1.TabIndex = 1
        '
        'UserNameLabel1
        '
        UserNameLabel1.AutoSize = True
        UserNameLabel1.Location = New System.Drawing.Point(7, 42)
        UserNameLabel1.Name = "UserNameLabel1"
        UserNameLabel1.Size = New System.Drawing.Size(83, 15)
        UserNameLabel1.TabIndex = 2
        UserNameLabel1.Text = "User Name:"
        '
        'UserNameTextBox1
        '
        Me.UserNameTextBox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.LoginBindingSource, "UserName", True))
        Me.UserNameTextBox1.Location = New System.Drawing.Point(96, 39)
        Me.UserNameTextBox1.Name = "UserNameTextBox1"
        Me.UserNameTextBox1.Size = New System.Drawing.Size(188, 21)
        Me.UserNameTextBox1.TabIndex = 3
        '
        'PasswordLabel1
        '
        PasswordLabel1.AutoSize = True
        PasswordLabel1.Location = New System.Drawing.Point(17, 69)
        PasswordLabel1.Name = "PasswordLabel1"
        PasswordLabel1.Size = New System.Drawing.Size(73, 15)
        PasswordLabel1.TabIndex = 4
        PasswordLabel1.Text = "Password:"
        '
        'PasswordTextBox1
        '
        Me.PasswordTextBox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.LoginBindingSource, "Password", True))
        Me.PasswordTextBox1.Location = New System.Drawing.Point(96, 66)
        Me.PasswordTextBox1.Name = "PasswordTextBox1"
        Me.PasswordTextBox1.Size = New System.Drawing.Size(188, 21)
        Me.PasswordTextBox1.TabIndex = 5
        '
        'Button11
        '
        Me.Button11.Location = New System.Drawing.Point(149, 2)
        Me.Button11.Name = "Button11"
        Me.Button11.Size = New System.Drawing.Size(75, 23)
        Me.Button11.TabIndex = 1
        Me.Button11.Text = "EXIT"
        Me.Button11.UseVisualStyleBackColor = True
        '
        'Form20
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(368, 213)
        Me.Controls.Add(Me.Button11)
        Me.Controls.Add(Me.TabControl1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Form20"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "ADMINISTRATION"
        Me.TabControl1.ResumeLayout(False)
        CType(Me.OESDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Login1BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LoginBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents OESDataSet As OESDataSet
    Friend WithEvents Login1BindingSource As BindingSource
    Friend WithEvents Login1TableAdapter As OESDataSetTableAdapters.Login1TableAdapter
    Friend WithEvents TableAdapterManager As OESDataSetTableAdapters.TableAdapterManager
    Friend WithEvents Button5 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents LoginIDTextBox As TextBox
    Friend WithEvents UsernameTextBox As TextBox
    Friend WithEvents PasswordTextBox As TextBox
    Friend WithEvents LoginTableAdapter As OESDataSetTableAdapters.LoginTableAdapter
    Friend WithEvents LoginBindingSource As BindingSource
    Friend WithEvents Button10 As Button
    Friend WithEvents Button9 As Button
    Friend WithEvents Button8 As Button
    Friend WithEvents Button7 As Button
    Friend WithEvents Button6 As Button
    Friend WithEvents LoginIDTextBox1 As TextBox
    Friend WithEvents UserNameTextBox1 As TextBox
    Friend WithEvents PasswordTextBox1 As TextBox
    Friend WithEvents Button11 As Button
End Class
