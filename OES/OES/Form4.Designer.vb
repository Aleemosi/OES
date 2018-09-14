<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form4
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim DuesIDLabel As System.Windows.Forms.Label
        Dim MemberIDLabel As System.Windows.Forms.Label
        Dim DateOfMeetingLabel As System.Windows.Forms.Label
        Dim PaymentDateLabel As System.Windows.Forms.Label
        Dim PaymentTypeLabel As System.Windows.Forms.Label
        Dim DuesLabel As System.Windows.Forms.Label
        Dim YearlyDuesLabel As System.Windows.Forms.Label
        Dim TotalLabel As System.Windows.Forms.Label
        Dim DuesExpirationLabel As System.Windows.Forms.Label
        Dim StatusLabel As System.Windows.Forms.Label
        Dim NoteLabel As System.Windows.Forms.Label
        Dim MemberIDLabel1 As System.Windows.Forms.Label
        Dim TitleFirstLastLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form4))
        Me.OESDataSet = New OES.OESDataSet()
        Me.TblDuesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TblDuesTableAdapter = New OES.OESDataSetTableAdapters.tblDuesTableAdapter()
        Me.TableAdapterManager = New OES.OESDataSetTableAdapters.TableAdapterManager()
        Me.TblMemberTableAdapter = New OES.OESDataSetTableAdapters.tblMemberTableAdapter()
        Me.DuesIDTextBox = New System.Windows.Forms.TextBox()
        Me.MemberIDTextBox = New System.Windows.Forms.TextBox()
        Me.DateOfMeetingDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.PaymentDateDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.PaymentTypeComboBox = New System.Windows.Forms.ComboBox()
        Me.DuesTextBox = New System.Windows.Forms.TextBox()
        Me.YearlyDuesTextBox = New System.Windows.Forms.TextBox()
        Me.TotalTextBox = New System.Windows.Forms.TextBox()
        Me.DuesExpirationTextBox = New System.Windows.Forms.TextBox()
        Me.StatusComboBox = New System.Windows.Forms.ComboBox()
        Me.NoteTextBox = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.TblMemberBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.MemberIDTextBox1 = New System.Windows.Forms.TextBox()
        Me.TitleFirstLastTextBox = New System.Windows.Forms.TextBox()
        DuesIDLabel = New System.Windows.Forms.Label()
        MemberIDLabel = New System.Windows.Forms.Label()
        DateOfMeetingLabel = New System.Windows.Forms.Label()
        PaymentDateLabel = New System.Windows.Forms.Label()
        PaymentTypeLabel = New System.Windows.Forms.Label()
        DuesLabel = New System.Windows.Forms.Label()
        YearlyDuesLabel = New System.Windows.Forms.Label()
        TotalLabel = New System.Windows.Forms.Label()
        DuesExpirationLabel = New System.Windows.Forms.Label()
        StatusLabel = New System.Windows.Forms.Label()
        NoteLabel = New System.Windows.Forms.Label()
        MemberIDLabel1 = New System.Windows.Forms.Label()
        TitleFirstLastLabel = New System.Windows.Forms.Label()
        CType(Me.OESDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TblDuesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TblMemberBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DuesIDLabel
        '
        DuesIDLabel.AutoSize = True
        DuesIDLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DuesIDLabel.Location = New System.Drawing.Point(12, 9)
        DuesIDLabel.Name = "DuesIDLabel"
        DuesIDLabel.Size = New System.Drawing.Size(62, 15)
        DuesIDLabel.TabIndex = 1
        DuesIDLabel.Text = "Dues ID:"
        '
        'MemberIDLabel
        '
        MemberIDLabel.AutoSize = True
        MemberIDLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        MemberIDLabel.Location = New System.Drawing.Point(156, 9)
        MemberIDLabel.Name = "MemberIDLabel"
        MemberIDLabel.Size = New System.Drawing.Size(82, 15)
        MemberIDLabel.TabIndex = 3
        MemberIDLabel.Text = "Member ID:"
        '
        'DateOfMeetingLabel
        '
        DateOfMeetingLabel.AutoSize = True
        DateOfMeetingLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DateOfMeetingLabel.Location = New System.Drawing.Point(22, 103)
        DateOfMeetingLabel.Name = "DateOfMeetingLabel"
        DateOfMeetingLabel.Size = New System.Drawing.Size(115, 15)
        DateOfMeetingLabel.TabIndex = 5
        DateOfMeetingLabel.Text = "Date Of Meeting:"
        '
        'PaymentDateLabel
        '
        PaymentDateLabel.AutoSize = True
        PaymentDateLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        PaymentDateLabel.Location = New System.Drawing.Point(34, 135)
        PaymentDateLabel.Name = "PaymentDateLabel"
        PaymentDateLabel.Size = New System.Drawing.Size(100, 15)
        PaymentDateLabel.TabIndex = 7
        PaymentDateLabel.Text = "Payment Date:"
        '
        'PaymentTypeLabel
        '
        PaymentTypeLabel.AutoSize = True
        PaymentTypeLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        PaymentTypeLabel.Location = New System.Drawing.Point(37, 169)
        PaymentTypeLabel.Name = "PaymentTypeLabel"
        PaymentTypeLabel.Size = New System.Drawing.Size(100, 15)
        PaymentTypeLabel.TabIndex = 9
        PaymentTypeLabel.Text = "Payment Type:"
        '
        'DuesLabel
        '
        DuesLabel.AutoSize = True
        DuesLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DuesLabel.Location = New System.Drawing.Point(403, 107)
        DuesLabel.Name = "DuesLabel"
        DuesLabel.Size = New System.Drawing.Size(44, 15)
        DuesLabel.TabIndex = 11
        DuesLabel.Text = "Dues:"
        '
        'YearlyDuesLabel
        '
        YearlyDuesLabel.AutoSize = True
        YearlyDuesLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        YearlyDuesLabel.Location = New System.Drawing.Point(360, 133)
        YearlyDuesLabel.Name = "YearlyDuesLabel"
        YearlyDuesLabel.Size = New System.Drawing.Size(87, 15)
        YearlyDuesLabel.TabIndex = 13
        YearlyDuesLabel.Text = "Yearly Dues:"
        '
        'TotalLabel
        '
        TotalLabel.AutoSize = True
        TotalLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        TotalLabel.Location = New System.Drawing.Point(404, 158)
        TotalLabel.Name = "TotalLabel"
        TotalLabel.Size = New System.Drawing.Size(43, 15)
        TotalLabel.TabIndex = 15
        TotalLabel.Text = "Total:"
        '
        'DuesExpirationLabel
        '
        DuesExpirationLabel.AutoSize = True
        DuesExpirationLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DuesExpirationLabel.Location = New System.Drawing.Point(334, 185)
        DuesExpirationLabel.Name = "DuesExpirationLabel"
        DuesExpirationLabel.Size = New System.Drawing.Size(113, 15)
        DuesExpirationLabel.TabIndex = 17
        DuesExpirationLabel.Text = "Dues Expiration:"
        '
        'StatusLabel
        '
        StatusLabel.AutoSize = True
        StatusLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        StatusLabel.Location = New System.Drawing.Point(396, 210)
        StatusLabel.Name = "StatusLabel"
        StatusLabel.Size = New System.Drawing.Size(51, 15)
        StatusLabel.TabIndex = 19
        StatusLabel.Text = "Status:"
        '
        'NoteLabel
        '
        NoteLabel.AutoSize = True
        NoteLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        NoteLabel.Location = New System.Drawing.Point(62, 239)
        NoteLabel.Name = "NoteLabel"
        NoteLabel.Size = New System.Drawing.Size(41, 15)
        NoteLabel.TabIndex = 21
        NoteLabel.Text = "Note:"
        '
        'MemberIDLabel1
        '
        MemberIDLabel1.AutoSize = True
        MemberIDLabel1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        MemberIDLabel1.Location = New System.Drawing.Point(320, 11)
        MemberIDLabel1.Name = "MemberIDLabel1"
        MemberIDLabel1.Size = New System.Drawing.Size(82, 15)
        MemberIDLabel1.TabIndex = 25
        MemberIDLabel1.Text = "Member ID:"
        '
        'TitleFirstLastLabel
        '
        TitleFirstLastLabel.AutoSize = True
        TitleFirstLastLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        TitleFirstLastLabel.Location = New System.Drawing.Point(229, 39)
        TitleFirstLastLabel.Name = "TitleFirstLastLabel"
        TitleFirstLastLabel.Size = New System.Drawing.Size(127, 15)
        TitleFirstLastLabel.TabIndex = 27
        TitleFirstLastLabel.Text = "SEARCH MEMBER"
        '
        'OESDataSet
        '
        Me.OESDataSet.DataSetName = "OESDataSet"
        Me.OESDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'TblDuesBindingSource
        '
        Me.TblDuesBindingSource.DataMember = "tblDues"
        Me.TblDuesBindingSource.DataSource = Me.OESDataSet
        '
        'TblDuesTableAdapter
        '
        Me.TblDuesTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.Login1TableAdapter = Nothing
        Me.TableAdapterManager.LoginTableAdapter = Nothing
        Me.TableAdapterManager.tblDateTableAdapter = Nothing
        Me.TableAdapterManager.tblDuesTableAdapter = Me.TblDuesTableAdapter
        Me.TableAdapterManager.tblMemberTableAdapter = Me.TblMemberTableAdapter
        Me.TableAdapterManager.tblMinutesTableAdapter = Nothing
        Me.TableAdapterManager.tblOfficerTableAdapter = Nothing
        Me.TableAdapterManager.tblTreasureTableAdapter = Nothing
        Me.TableAdapterManager.tblVisitorTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = OES.OESDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'TblMemberTableAdapter
        '
        Me.TblMemberTableAdapter.ClearBeforeFill = True
        '
        'DuesIDTextBox
        '
        Me.DuesIDTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblDuesBindingSource, "DuesID", True))
        Me.DuesIDTextBox.Location = New System.Drawing.Point(80, 8)
        Me.DuesIDTextBox.Name = "DuesIDTextBox"
        Me.DuesIDTextBox.ReadOnly = True
        Me.DuesIDTextBox.Size = New System.Drawing.Size(54, 20)
        Me.DuesIDTextBox.TabIndex = 2
        '
        'MemberIDTextBox
        '
        Me.MemberIDTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblDuesBindingSource, "MemberID", True))
        Me.MemberIDTextBox.Location = New System.Drawing.Point(244, 8)
        Me.MemberIDTextBox.Name = "MemberIDTextBox"
        Me.MemberIDTextBox.ReadOnly = True
        Me.MemberIDTextBox.Size = New System.Drawing.Size(54, 20)
        Me.MemberIDTextBox.TabIndex = 4
        '
        'DateOfMeetingDateTimePicker
        '
        Me.DateOfMeetingDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.TblDuesBindingSource, "DateOfMeeting", True))
        Me.DateOfMeetingDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DateOfMeetingDateTimePicker.Location = New System.Drawing.Point(143, 103)
        Me.DateOfMeetingDateTimePicker.Name = "DateOfMeetingDateTimePicker"
        Me.DateOfMeetingDateTimePicker.Size = New System.Drawing.Size(113, 20)
        Me.DateOfMeetingDateTimePicker.TabIndex = 6
        Me.DateOfMeetingDateTimePicker.Value = New Date(2017, 4, 6, 0, 0, 0, 0)
        '
        'PaymentDateDateTimePicker
        '
        Me.PaymentDateDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.TblDuesBindingSource, "PaymentDate", True))
        Me.PaymentDateDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.PaymentDateDateTimePicker.Location = New System.Drawing.Point(143, 135)
        Me.PaymentDateDateTimePicker.Name = "PaymentDateDateTimePicker"
        Me.PaymentDateDateTimePicker.Size = New System.Drawing.Size(113, 20)
        Me.PaymentDateDateTimePicker.TabIndex = 8
        Me.PaymentDateDateTimePicker.Value = New Date(2017, 4, 6, 0, 0, 0, 0)
        '
        'PaymentTypeComboBox
        '
        Me.PaymentTypeComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblDuesBindingSource, "PaymentType", True))
        Me.PaymentTypeComboBox.FormattingEnabled = True
        Me.PaymentTypeComboBox.Items.AddRange(New Object() {"CASH", "CHECK", "MONEY ORDER"})
        Me.PaymentTypeComboBox.Location = New System.Drawing.Point(143, 168)
        Me.PaymentTypeComboBox.Name = "PaymentTypeComboBox"
        Me.PaymentTypeComboBox.Size = New System.Drawing.Size(113, 21)
        Me.PaymentTypeComboBox.TabIndex = 10
        '
        'DuesTextBox
        '
        Me.DuesTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblDuesBindingSource, "Dues", True))
        Me.DuesTextBox.Location = New System.Drawing.Point(453, 106)
        Me.DuesTextBox.Name = "DuesTextBox"
        Me.DuesTextBox.Size = New System.Drawing.Size(63, 20)
        Me.DuesTextBox.TabIndex = 12
        '
        'YearlyDuesTextBox
        '
        Me.YearlyDuesTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblDuesBindingSource, "YearlyDues", True))
        Me.YearlyDuesTextBox.Location = New System.Drawing.Point(453, 132)
        Me.YearlyDuesTextBox.Name = "YearlyDuesTextBox"
        Me.YearlyDuesTextBox.Size = New System.Drawing.Size(63, 20)
        Me.YearlyDuesTextBox.TabIndex = 14
        '
        'TotalTextBox
        '
        Me.TotalTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblDuesBindingSource, "Total", True))
        Me.TotalTextBox.Location = New System.Drawing.Point(453, 157)
        Me.TotalTextBox.Name = "TotalTextBox"
        Me.TotalTextBox.Size = New System.Drawing.Size(63, 20)
        Me.TotalTextBox.TabIndex = 16
        '
        'DuesExpirationTextBox
        '
        Me.DuesExpirationTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblDuesBindingSource, "DuesExpiration", True))
        Me.DuesExpirationTextBox.Location = New System.Drawing.Point(453, 184)
        Me.DuesExpirationTextBox.Name = "DuesExpirationTextBox"
        Me.DuesExpirationTextBox.Size = New System.Drawing.Size(108, 20)
        Me.DuesExpirationTextBox.TabIndex = 18
        '
        'StatusComboBox
        '
        Me.StatusComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblDuesBindingSource, "Status", True))
        Me.StatusComboBox.FormattingEnabled = True
        Me.StatusComboBox.Items.AddRange(New Object() {"Active", "Not Current", "Dropped", "Demmit"})
        Me.StatusComboBox.Location = New System.Drawing.Point(453, 209)
        Me.StatusComboBox.Name = "StatusComboBox"
        Me.StatusComboBox.Size = New System.Drawing.Size(113, 21)
        Me.StatusComboBox.TabIndex = 20
        '
        'NoteTextBox
        '
        Me.NoteTextBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.NoteTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblDuesBindingSource, "Note", True))
        Me.NoteTextBox.Location = New System.Drawing.Point(109, 238)
        Me.NoteTextBox.Multiline = True
        Me.NoteTextBox.Name = "NoteTextBox"
        Me.NoteTextBox.Size = New System.Drawing.Size(457, 115)
        Me.NoteTextBox.TabIndex = 22
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(139, 359)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 23
        Me.Button1.Text = "ADD"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(219, 359)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 23)
        Me.Button2.TabIndex = 24
        Me.Button2.Text = "SAVE"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(300, 359)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(105, 23)
        Me.Button3.TabIndex = 25
        Me.Button3.Text = "MEMBERS FORM"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'TblMemberBindingSource
        '
        Me.TblMemberBindingSource.DataMember = "tblMember"
        Me.TblMemberBindingSource.DataSource = Me.OESDataSet
        '
        'MemberIDTextBox1
        '
        Me.MemberIDTextBox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblMemberBindingSource, "MemberID", True))
        Me.MemberIDTextBox1.Location = New System.Drawing.Point(406, 10)
        Me.MemberIDTextBox1.Name = "MemberIDTextBox1"
        Me.MemberIDTextBox1.ReadOnly = True
        Me.MemberIDTextBox1.Size = New System.Drawing.Size(54, 20)
        Me.MemberIDTextBox1.TabIndex = 26
        '
        'TitleFirstLastTextBox
        '
        Me.TitleFirstLastTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblMemberBindingSource, "TitleFirstLast", True))
        Me.TitleFirstLastTextBox.Location = New System.Drawing.Point(219, 57)
        Me.TitleFirstLastTextBox.Name = "TitleFirstLastTextBox"
        Me.TitleFirstLastTextBox.ReadOnly = True
        Me.TitleFirstLastTextBox.Size = New System.Drawing.Size(148, 20)
        Me.TitleFirstLastTextBox.TabIndex = 28
        '
        'Form4
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(594, 402)
        Me.Controls.Add(TitleFirstLastLabel)
        Me.Controls.Add(Me.TitleFirstLastTextBox)
        Me.Controls.Add(MemberIDLabel1)
        Me.Controls.Add(Me.MemberIDTextBox1)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(DuesIDLabel)
        Me.Controls.Add(Me.DuesIDTextBox)
        Me.Controls.Add(MemberIDLabel)
        Me.Controls.Add(Me.MemberIDTextBox)
        Me.Controls.Add(DateOfMeetingLabel)
        Me.Controls.Add(Me.DateOfMeetingDateTimePicker)
        Me.Controls.Add(PaymentDateLabel)
        Me.Controls.Add(Me.PaymentDateDateTimePicker)
        Me.Controls.Add(PaymentTypeLabel)
        Me.Controls.Add(Me.PaymentTypeComboBox)
        Me.Controls.Add(DuesLabel)
        Me.Controls.Add(Me.DuesTextBox)
        Me.Controls.Add(YearlyDuesLabel)
        Me.Controls.Add(Me.YearlyDuesTextBox)
        Me.Controls.Add(TotalLabel)
        Me.Controls.Add(Me.TotalTextBox)
        Me.Controls.Add(DuesExpirationLabel)
        Me.Controls.Add(Me.DuesExpirationTextBox)
        Me.Controls.Add(StatusLabel)
        Me.Controls.Add(Me.StatusComboBox)
        Me.Controls.Add(NoteLabel)
        Me.Controls.Add(Me.NoteTextBox)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "Form4"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "ADD DUES"
        CType(Me.OESDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TblDuesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TblMemberBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents OESDataSet As OESDataSet
    Friend WithEvents TblDuesBindingSource As BindingSource
    Friend WithEvents TblDuesTableAdapter As OESDataSetTableAdapters.tblDuesTableAdapter
    Friend WithEvents TableAdapterManager As OESDataSetTableAdapters.TableAdapterManager
    Friend WithEvents TblMemberTableAdapter As OESDataSetTableAdapters.tblMemberTableAdapter
    Friend WithEvents DuesIDTextBox As TextBox
    Friend WithEvents MemberIDTextBox As TextBox
    Friend WithEvents DateOfMeetingDateTimePicker As DateTimePicker
    Friend WithEvents PaymentDateDateTimePicker As DateTimePicker
    Friend WithEvents PaymentTypeComboBox As ComboBox
    Friend WithEvents DuesTextBox As TextBox
    Friend WithEvents YearlyDuesTextBox As TextBox
    Friend WithEvents TotalTextBox As TextBox
    Friend WithEvents DuesExpirationTextBox As TextBox
    Friend WithEvents StatusComboBox As ComboBox
    Friend WithEvents NoteTextBox As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents TblMemberBindingSource As BindingSource
    Friend WithEvents MemberIDTextBox1 As TextBox
    Friend WithEvents TitleFirstLastTextBox As TextBox
End Class
