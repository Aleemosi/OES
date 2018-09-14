<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form3
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
        Dim MemberIDLabel As System.Windows.Forms.Label
        Dim TitleLabel As System.Windows.Forms.Label
        Dim FirstNameLabel As System.Windows.Forms.Label
        Dim MiddleNameLabel As System.Windows.Forms.Label
        Dim LastNameLabel As System.Windows.Forms.Label
        Dim AddressLabel As System.Windows.Forms.Label
        Dim AptLabel As System.Windows.Forms.Label
        Dim CityLabel As System.Windows.Forms.Label
        Dim StateLabel As System.Windows.Forms.Label
        Dim ZipLabel As System.Windows.Forms.Label
        Dim PhoneLabel As System.Windows.Forms.Label
        Dim EmailLabel As System.Windows.Forms.Label
        Dim TitleFirstLastLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form3))
        Me.MemberIDTextBox = New System.Windows.Forms.TextBox()
        Me.TblMemberBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.OESDataSet = New OES.OESDataSet()
        Me.TitleComboBox = New System.Windows.Forms.ComboBox()
        Me.FirstNameTextBox = New System.Windows.Forms.TextBox()
        Me.MiddleNameTextBox = New System.Windows.Forms.TextBox()
        Me.LastNameTextBox = New System.Windows.Forms.TextBox()
        Me.AddressTextBox = New System.Windows.Forms.TextBox()
        Me.AptTextBox = New System.Windows.Forms.TextBox()
        Me.CityTextBox = New System.Windows.Forms.TextBox()
        Me.StateComboBox = New System.Windows.Forms.ComboBox()
        Me.ZipMaskedTextBox = New System.Windows.Forms.MaskedTextBox()
        Me.PhoneMaskedTextBox = New System.Windows.Forms.MaskedTextBox()
        Me.EmailTextBox = New System.Windows.Forms.TextBox()
        Me.TitleFirstLastTextBox = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Pre = New System.Windows.Forms.Button()
        Me.Nxt = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TblDuesDataGridView = New System.Windows.Forms.DataGridView()
        Me.Button7 = New System.Windows.Forms.Button()
        Me.Button8 = New System.Windows.Forms.Button()
        Me.Button9 = New System.Windows.Forms.Button()
        Me.Button10 = New System.Windows.Forms.Button()
        Me.Button11 = New System.Windows.Forms.Button()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.TblMemberTableAdapter = New OES.OESDataSetTableAdapters.tblMemberTableAdapter()
        Me.TableAdapterManager = New OES.OESDataSetTableAdapters.TableAdapterManager()
        Me.TblDuesTableAdapter = New OES.OESDataSetTableAdapters.tblDuesTableAdapter()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn9 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn10 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn11 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TblDuesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        MemberIDLabel = New System.Windows.Forms.Label()
        TitleLabel = New System.Windows.Forms.Label()
        FirstNameLabel = New System.Windows.Forms.Label()
        MiddleNameLabel = New System.Windows.Forms.Label()
        LastNameLabel = New System.Windows.Forms.Label()
        AddressLabel = New System.Windows.Forms.Label()
        AptLabel = New System.Windows.Forms.Label()
        CityLabel = New System.Windows.Forms.Label()
        StateLabel = New System.Windows.Forms.Label()
        ZipLabel = New System.Windows.Forms.Label()
        PhoneLabel = New System.Windows.Forms.Label()
        EmailLabel = New System.Windows.Forms.Label()
        TitleFirstLastLabel = New System.Windows.Forms.Label()
        CType(Me.TblMemberBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.OESDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TblDuesDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.TblDuesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MemberIDLabel
        '
        MemberIDLabel.AutoSize = True
        MemberIDLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        MemberIDLabel.Location = New System.Drawing.Point(12, 9)
        MemberIDLabel.Name = "MemberIDLabel"
        MemberIDLabel.Size = New System.Drawing.Size(82, 15)
        MemberIDLabel.TabIndex = 1
        MemberIDLabel.Text = "Member ID:"
        '
        'TitleLabel
        '
        TitleLabel.AutoSize = True
        TitleLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        TitleLabel.Location = New System.Drawing.Point(55, 41)
        TitleLabel.Name = "TitleLabel"
        TitleLabel.Size = New System.Drawing.Size(39, 15)
        TitleLabel.TabIndex = 3
        TitleLabel.Text = "Title:"
        '
        'FirstNameLabel
        '
        FirstNameLabel.AutoSize = True
        FirstNameLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        FirstNameLabel.Location = New System.Drawing.Point(13, 73)
        FirstNameLabel.Name = "FirstNameLabel"
        FirstNameLabel.Size = New System.Drawing.Size(81, 15)
        FirstNameLabel.TabIndex = 5
        FirstNameLabel.Text = "First Name:"
        '
        'MiddleNameLabel
        '
        MiddleNameLabel.AutoSize = True
        MiddleNameLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        MiddleNameLabel.Location = New System.Drawing.Point(254, 73)
        MiddleNameLabel.Name = "MiddleNameLabel"
        MiddleNameLabel.Size = New System.Drawing.Size(97, 15)
        MiddleNameLabel.TabIndex = 7
        MiddleNameLabel.Text = "Middle Name:"
        '
        'LastNameLabel
        '
        LastNameLabel.AutoSize = True
        LastNameLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        LastNameLabel.Location = New System.Drawing.Point(414, 73)
        LastNameLabel.Name = "LastNameLabel"
        LastNameLabel.Size = New System.Drawing.Size(80, 15)
        LastNameLabel.TabIndex = 9
        LastNameLabel.Text = "Last Name:"
        '
        'AddressLabel
        '
        AddressLabel.AutoSize = True
        AddressLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        AddressLabel.Location = New System.Drawing.Point(32, 103)
        AddressLabel.Name = "AddressLabel"
        AddressLabel.Size = New System.Drawing.Size(62, 15)
        AddressLabel.TabIndex = 11
        AddressLabel.Text = "Address:"
        '
        'AptLabel
        '
        AptLabel.AutoSize = True
        AptLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        AptLabel.Location = New System.Drawing.Point(320, 103)
        AptLabel.Name = "AptLabel"
        AptLabel.Size = New System.Drawing.Size(31, 15)
        AptLabel.TabIndex = 13
        AptLabel.Text = "Apt:"
        '
        'CityLabel
        '
        CityLabel.AutoSize = True
        CityLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        CityLabel.Location = New System.Drawing.Point(60, 132)
        CityLabel.Name = "CityLabel"
        CityLabel.Size = New System.Drawing.Size(34, 15)
        CityLabel.TabIndex = 15
        CityLabel.Text = "City:"
        '
        'StateLabel
        '
        StateLabel.AutoSize = True
        StateLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        StateLabel.Location = New System.Drawing.Point(307, 132)
        StateLabel.Name = "StateLabel"
        StateLabel.Size = New System.Drawing.Size(44, 15)
        StateLabel.TabIndex = 17
        StateLabel.Text = "State:"
        '
        'ZipLabel
        '
        ZipLabel.AutoSize = True
        ZipLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        ZipLabel.Location = New System.Drawing.Point(463, 132)
        ZipLabel.Name = "ZipLabel"
        ZipLabel.Size = New System.Drawing.Size(31, 15)
        ZipLabel.TabIndex = 19
        ZipLabel.Text = "Zip:"
        '
        'PhoneLabel
        '
        PhoneLabel.AutoSize = True
        PhoneLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        PhoneLabel.Location = New System.Drawing.Point(42, 162)
        PhoneLabel.Name = "PhoneLabel"
        PhoneLabel.Size = New System.Drawing.Size(52, 15)
        PhoneLabel.TabIndex = 21
        PhoneLabel.Text = "Phone:"
        '
        'EmailLabel
        '
        EmailLabel.AutoSize = True
        EmailLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        EmailLabel.Location = New System.Drawing.Point(217, 161)
        EmailLabel.Name = "EmailLabel"
        EmailLabel.Size = New System.Drawing.Size(48, 15)
        EmailLabel.TabIndex = 23
        EmailLabel.Text = "Email:"
        '
        'TitleFirstLastLabel
        '
        TitleFirstLastLabel.AutoSize = True
        TitleFirstLastLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        TitleFirstLastLabel.Location = New System.Drawing.Point(86, 197)
        TitleFirstLastLabel.Name = "TitleFirstLastLabel"
        TitleFirstLastLabel.Size = New System.Drawing.Size(102, 15)
        TitleFirstLastLabel.TabIndex = 25
        TitleFirstLastLabel.Text = "Title First Last:"
        '
        'MemberIDTextBox
        '
        Me.MemberIDTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblMemberBindingSource, "MemberID", True))
        Me.MemberIDTextBox.Location = New System.Drawing.Point(98, 8)
        Me.MemberIDTextBox.Name = "MemberIDTextBox"
        Me.MemberIDTextBox.ReadOnly = True
        Me.MemberIDTextBox.Size = New System.Drawing.Size(51, 20)
        Me.MemberIDTextBox.TabIndex = 2
        '
        'TblMemberBindingSource
        '
        Me.TblMemberBindingSource.DataMember = "tblMember"
        Me.TblMemberBindingSource.DataSource = Me.OESDataSet
        '
        'OESDataSet
        '
        Me.OESDataSet.DataSetName = "OESDataSet"
        Me.OESDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'TitleComboBox
        '
        Me.TitleComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblMemberBindingSource, "Title", True))
        Me.TitleComboBox.FormattingEnabled = True
        Me.TitleComboBox.Items.AddRange(New Object() {"Worth. Matron", "Worth. Patron", "Asso. Matron", "Asso. Patron", "Conductress", "Asso. Conductress", "Secretary", "Treasure", "Warder", "Sentinel", "Adah", "Ruth", "Esther", "Martha", "Electa", "OES", "USFB", "Christian Flag", "Bro.", "Sis."})
        Me.TitleComboBox.Location = New System.Drawing.Point(98, 40)
        Me.TitleComboBox.Name = "TitleComboBox"
        Me.TitleComboBox.Size = New System.Drawing.Size(138, 21)
        Me.TitleComboBox.TabIndex = 4
        '
        'FirstNameTextBox
        '
        Me.FirstNameTextBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.FirstNameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblMemberBindingSource, "FirstName", True))
        Me.FirstNameTextBox.Location = New System.Drawing.Point(98, 72)
        Me.FirstNameTextBox.Name = "FirstNameTextBox"
        Me.FirstNameTextBox.Size = New System.Drawing.Size(138, 20)
        Me.FirstNameTextBox.TabIndex = 6
        '
        'MiddleNameTextBox
        '
        Me.MiddleNameTextBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.MiddleNameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblMemberBindingSource, "MiddleName", True))
        Me.MiddleNameTextBox.Location = New System.Drawing.Point(357, 72)
        Me.MiddleNameTextBox.Name = "MiddleNameTextBox"
        Me.MiddleNameTextBox.Size = New System.Drawing.Size(48, 20)
        Me.MiddleNameTextBox.TabIndex = 8
        '
        'LastNameTextBox
        '
        Me.LastNameTextBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.LastNameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblMemberBindingSource, "LastName", True))
        Me.LastNameTextBox.Location = New System.Drawing.Point(500, 72)
        Me.LastNameTextBox.Name = "LastNameTextBox"
        Me.LastNameTextBox.Size = New System.Drawing.Size(138, 20)
        Me.LastNameTextBox.TabIndex = 10
        '
        'AddressTextBox
        '
        Me.AddressTextBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.AddressTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblMemberBindingSource, "Address", True))
        Me.AddressTextBox.Location = New System.Drawing.Point(98, 102)
        Me.AddressTextBox.Name = "AddressTextBox"
        Me.AddressTextBox.Size = New System.Drawing.Size(163, 20)
        Me.AddressTextBox.TabIndex = 12
        '
        'AptTextBox
        '
        Me.AptTextBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.AptTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblMemberBindingSource, "Apt", True))
        Me.AptTextBox.Location = New System.Drawing.Point(357, 102)
        Me.AptTextBox.Name = "AptTextBox"
        Me.AptTextBox.Size = New System.Drawing.Size(48, 20)
        Me.AptTextBox.TabIndex = 14
        '
        'CityTextBox
        '
        Me.CityTextBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.CityTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblMemberBindingSource, "City", True))
        Me.CityTextBox.Location = New System.Drawing.Point(98, 131)
        Me.CityTextBox.Name = "CityTextBox"
        Me.CityTextBox.Size = New System.Drawing.Size(163, 20)
        Me.CityTextBox.TabIndex = 16
        '
        'StateComboBox
        '
        Me.StateComboBox.AutoCompleteCustomSource.AddRange(New String() {"AL      ", "AK      ", "AZ      ", "AR      ", "CA", "CO", "CT", "DE", "FL", "GA", "HI", "ID", "IL", "IN", "IA", "KS", "KY", "LA", "ME", "MD", "MA", "MI", "MN", "MS", "MO", "MT", "NE", "NV", "NH", "NJ", "NM", "NY", "NC", "ND", "OH", "OK", "OR", "PA", "RI", "SC", "SD", "TN", "TX", "UT", "VT", "VA", "WA", "WV", "WI", "WY", "DC", "AA", "AP", "AE"})
        Me.StateComboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.StateComboBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.StateComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblMemberBindingSource, "State", True))
        Me.StateComboBox.FormattingEnabled = True
        Me.StateComboBox.Location = New System.Drawing.Point(357, 131)
        Me.StateComboBox.Name = "StateComboBox"
        Me.StateComboBox.Size = New System.Drawing.Size(77, 21)
        Me.StateComboBox.TabIndex = 18
        '
        'ZipMaskedTextBox
        '
        Me.ZipMaskedTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblMemberBindingSource, "Zip", True))
        Me.ZipMaskedTextBox.Location = New System.Drawing.Point(500, 131)
        Me.ZipMaskedTextBox.Mask = "00000-9999"
        Me.ZipMaskedTextBox.Name = "ZipMaskedTextBox"
        Me.ZipMaskedTextBox.Size = New System.Drawing.Size(81, 20)
        Me.ZipMaskedTextBox.TabIndex = 20
        '
        'PhoneMaskedTextBox
        '
        Me.PhoneMaskedTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblMemberBindingSource, "Phone", True))
        Me.PhoneMaskedTextBox.Location = New System.Drawing.Point(98, 161)
        Me.PhoneMaskedTextBox.Mask = "(999) 000-0000"
        Me.PhoneMaskedTextBox.Name = "PhoneMaskedTextBox"
        Me.PhoneMaskedTextBox.Size = New System.Drawing.Size(90, 20)
        Me.PhoneMaskedTextBox.TabIndex = 22
        '
        'EmailTextBox
        '
        Me.EmailTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblMemberBindingSource, "Email", True))
        Me.EmailTextBox.Location = New System.Drawing.Point(271, 160)
        Me.EmailTextBox.Name = "EmailTextBox"
        Me.EmailTextBox.Size = New System.Drawing.Size(223, 20)
        Me.EmailTextBox.TabIndex = 24
        '
        'TitleFirstLastTextBox
        '
        Me.TitleFirstLastTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblMemberBindingSource, "TitleFirstLast", True))
        Me.TitleFirstLastTextBox.Location = New System.Drawing.Point(194, 196)
        Me.TitleFirstLastTextBox.Name = "TitleFirstLastTextBox"
        Me.TitleFirstLastTextBox.ReadOnly = True
        Me.TitleFirstLastTextBox.Size = New System.Drawing.Size(157, 20)
        Me.TitleFirstLastTextBox.TabIndex = 26
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(126, 222)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 27
        Me.Button1.Text = "ADD"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(207, 222)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 23)
        Me.Button2.TabIndex = 28
        Me.Button2.Text = "SAVE"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(288, 222)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(75, 23)
        Me.Button3.TabIndex = 29
        Me.Button3.Text = "DELETE"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(379, 222)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(138, 23)
        Me.Button4.TabIndex = 30
        Me.Button4.Text = "ADD MEMBERS DUES"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Pre
        '
        Me.Pre.Location = New System.Drawing.Point(126, 251)
        Me.Pre.Name = "Pre"
        Me.Pre.Size = New System.Drawing.Size(49, 23)
        Me.Pre.TabIndex = 31
        Me.Pre.Text = "<"
        Me.Pre.UseVisualStyleBackColor = True
        '
        'Nxt
        '
        Me.Nxt.Location = New System.Drawing.Point(314, 251)
        Me.Nxt.Name = "Nxt"
        Me.Nxt.Size = New System.Drawing.Size(49, 23)
        Me.Nxt.TabIndex = 32
        Me.Nxt.Text = ">"
        Me.Nxt.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(209, 255)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(0, 13)
        Me.Label1.TabIndex = 33
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(241, 255)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(0, 13)
        Me.Label2.TabIndex = 34
        '
        'TblDuesDataGridView
        '
        Me.TblDuesDataGridView.AutoGenerateColumns = False
        Me.TblDuesDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.TblDuesDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn6, Me.DataGridViewTextBoxColumn7, Me.DataGridViewTextBoxColumn8, Me.DataGridViewTextBoxColumn9, Me.DataGridViewTextBoxColumn10, Me.DataGridViewTextBoxColumn11})
        Me.TblDuesDataGridView.DataSource = Me.TblDuesBindingSource
        Me.TblDuesDataGridView.Location = New System.Drawing.Point(12, 297)
        Me.TblDuesDataGridView.Name = "TblDuesDataGridView"
        Me.TblDuesDataGridView.Size = New System.Drawing.Size(626, 220)
        Me.TblDuesDataGridView.TabIndex = 34
        '
        'Button7
        '
        Me.Button7.Location = New System.Drawing.Point(644, 339)
        Me.Button7.Name = "Button7"
        Me.Button7.Size = New System.Drawing.Size(46, 23)
        Me.Button7.TabIndex = 35
        Me.Button7.Text = "<"
        Me.Button7.UseVisualStyleBackColor = True
        '
        'Button8
        '
        Me.Button8.Location = New System.Drawing.Point(744, 339)
        Me.Button8.Name = "Button8"
        Me.Button8.Size = New System.Drawing.Size(46, 23)
        Me.Button8.TabIndex = 36
        Me.Button8.Text = ">"
        Me.Button8.UseVisualStyleBackColor = True
        '
        'Button9
        '
        Me.Button9.Location = New System.Drawing.Point(644, 280)
        Me.Button9.Name = "Button9"
        Me.Button9.Size = New System.Drawing.Size(146, 23)
        Me.Button9.TabIndex = 37
        Me.Button9.Text = "SAVE DUES AFTER EDIT"
        Me.Button9.UseVisualStyleBackColor = True
        '
        'Button10
        '
        Me.Button10.Location = New System.Drawing.Point(6, 48)
        Me.Button10.Name = "Button10"
        Me.Button10.Size = New System.Drawing.Size(178, 23)
        Me.Button10.TabIndex = 38
        Me.Button10.Text = "MEMBERS REPORT"
        Me.Button10.UseVisualStyleBackColor = True
        '
        'Button11
        '
        Me.Button11.Location = New System.Drawing.Point(644, 310)
        Me.Button11.Name = "Button11"
        Me.Button11.Size = New System.Drawing.Size(146, 23)
        Me.Button11.TabIndex = 39
        Me.Button11.Text = "DELETE DUES"
        Me.Button11.UseVisualStyleBackColor = True
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        '
        'TblMemberTableAdapter
        '
        Me.TblMemberTableAdapter.ClearBeforeFill = True
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
        'TblDuesTableAdapter
        '
        Me.TblDuesTableAdapter.ClearBeforeFill = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Button6)
        Me.GroupBox1.Controls.Add(Me.Button10)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(601, 184)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(189, 85)
        Me.GroupBox1.TabIndex = 41
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "REPORT MENU"
        '
        'Button6
        '
        Me.Button6.Location = New System.Drawing.Point(6, 19)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(178, 23)
        Me.Button6.TabIndex = 41
        Me.Button6.Text = "MEMBER STATUS REPORT"
        Me.Button6.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(242, 280)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(165, 15)
        Me.Label3.TabIndex = 42
        Me.Label3.Text = "MEMBERS DUES TABLE"
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "DateOfMeeting"
        Me.DataGridViewTextBoxColumn3.HeaderText = "DateOfMeeting"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "PaymentDate"
        Me.DataGridViewTextBoxColumn4.HeaderText = "PaymentDate"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "PaymentType"
        Me.DataGridViewTextBoxColumn5.HeaderText = "PaymentType"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "Dues"
        Me.DataGridViewTextBoxColumn6.HeaderText = "Dues"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.DataPropertyName = "YearlyDues"
        Me.DataGridViewTextBoxColumn7.HeaderText = "YearlyDues"
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        '
        'DataGridViewTextBoxColumn8
        '
        Me.DataGridViewTextBoxColumn8.DataPropertyName = "Total"
        Me.DataGridViewTextBoxColumn8.HeaderText = "Total"
        Me.DataGridViewTextBoxColumn8.Name = "DataGridViewTextBoxColumn8"
        '
        'DataGridViewTextBoxColumn9
        '
        Me.DataGridViewTextBoxColumn9.DataPropertyName = "DuesExpiration"
        Me.DataGridViewTextBoxColumn9.HeaderText = "DuesExpiration"
        Me.DataGridViewTextBoxColumn9.Name = "DataGridViewTextBoxColumn9"
        '
        'DataGridViewTextBoxColumn10
        '
        Me.DataGridViewTextBoxColumn10.DataPropertyName = "Status"
        Me.DataGridViewTextBoxColumn10.HeaderText = "Status"
        Me.DataGridViewTextBoxColumn10.Name = "DataGridViewTextBoxColumn10"
        '
        'DataGridViewTextBoxColumn11
        '
        Me.DataGridViewTextBoxColumn11.DataPropertyName = "Note"
        Me.DataGridViewTextBoxColumn11.HeaderText = "Note"
        Me.DataGridViewTextBoxColumn11.Name = "DataGridViewTextBoxColumn11"
        '
        'TblDuesBindingSource
        '
        Me.TblDuesBindingSource.DataMember = "tblMembertblDues"
        Me.TblDuesBindingSource.DataSource = Me.TblMemberBindingSource
        '
        'ComboBox1
        '
        Me.ComboBox1.DataSource = Me.TblMemberBindingSource
        Me.ComboBox1.DisplayMember = "TitleFirstLast"
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(607, 132)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(238, 21)
        Me.ComboBox1.TabIndex = 43
        Me.ComboBox1.ValueMember = "TitleFirstLast"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(642, 117)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(174, 12)
        Me.Label4.TabIndex = 44
        Me.Label4.Text = "DROP DOWN SEARCH MEMBER"
        '
        'Form3
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(852, 519)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Button11)
        Me.Controls.Add(Me.Button9)
        Me.Controls.Add(Me.Button8)
        Me.Controls.Add(Me.Button7)
        Me.Controls.Add(Me.TblDuesDataGridView)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Nxt)
        Me.Controls.Add(Me.Pre)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(MemberIDLabel)
        Me.Controls.Add(Me.MemberIDTextBox)
        Me.Controls.Add(TitleLabel)
        Me.Controls.Add(Me.TitleComboBox)
        Me.Controls.Add(FirstNameLabel)
        Me.Controls.Add(Me.FirstNameTextBox)
        Me.Controls.Add(MiddleNameLabel)
        Me.Controls.Add(Me.MiddleNameTextBox)
        Me.Controls.Add(LastNameLabel)
        Me.Controls.Add(Me.LastNameTextBox)
        Me.Controls.Add(AddressLabel)
        Me.Controls.Add(Me.AddressTextBox)
        Me.Controls.Add(AptLabel)
        Me.Controls.Add(Me.AptTextBox)
        Me.Controls.Add(CityLabel)
        Me.Controls.Add(Me.CityTextBox)
        Me.Controls.Add(StateLabel)
        Me.Controls.Add(Me.StateComboBox)
        Me.Controls.Add(ZipLabel)
        Me.Controls.Add(Me.ZipMaskedTextBox)
        Me.Controls.Add(PhoneLabel)
        Me.Controls.Add(Me.PhoneMaskedTextBox)
        Me.Controls.Add(EmailLabel)
        Me.Controls.Add(Me.EmailTextBox)
        Me.Controls.Add(TitleFirstLastLabel)
        Me.Controls.Add(Me.TitleFirstLastTextBox)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "Form3"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "MEMBERS AND DUES"
        CType(Me.TblMemberBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.OESDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TblDuesDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.TblDuesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents OESDataSet As OESDataSet
    Friend WithEvents TblMemberBindingSource As BindingSource
    Friend WithEvents TblMemberTableAdapter As OESDataSetTableAdapters.tblMemberTableAdapter
    Friend WithEvents TableAdapterManager As OESDataSetTableAdapters.TableAdapterManager
    Friend WithEvents TblDuesTableAdapter As OESDataSetTableAdapters.tblDuesTableAdapter
    Friend WithEvents MemberIDTextBox As TextBox
    Friend WithEvents TitleComboBox As ComboBox
    Friend WithEvents FirstNameTextBox As TextBox
    Friend WithEvents MiddleNameTextBox As TextBox
    Friend WithEvents LastNameTextBox As TextBox
    Friend WithEvents AddressTextBox As TextBox
    Friend WithEvents AptTextBox As TextBox
    Friend WithEvents CityTextBox As TextBox
    Friend WithEvents StateComboBox As ComboBox
    Friend WithEvents ZipMaskedTextBox As MaskedTextBox
    Friend WithEvents PhoneMaskedTextBox As MaskedTextBox
    Friend WithEvents EmailTextBox As TextBox
    Friend WithEvents TitleFirstLastTextBox As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents Pre As Button
    Friend WithEvents Nxt As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents TblDuesBindingSource As BindingSource
    Friend WithEvents TblDuesDataGridView As DataGridView
    Friend WithEvents Button7 As Button
    Friend WithEvents Button8 As Button
    Friend WithEvents Button9 As Button
    Friend WithEvents Button10 As Button
    Friend WithEvents Button11 As Button
    Friend WithEvents Timer1 As Timer
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Button6 As Button
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn7 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn8 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn9 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn10 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn11 As DataGridViewTextBoxColumn
    Friend WithEvents Label3 As Label
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents Label4 As Label
End Class
