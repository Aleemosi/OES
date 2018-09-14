<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form8
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
        Dim MinutesIDLabel As System.Windows.Forms.Label
        Dim DateIDLabel As System.Windows.Forms.Label
        Dim MeetingStartLabel As System.Windows.Forms.Label
        Dim MeetingCalledByLabel As System.Windows.Forms.Label
        Dim PrayerPeronLabel As System.Windows.Forms.Label
        Dim RollCallLabel As System.Windows.Forms.Label
        Dim SicknessAndDistressLabel As System.Windows.Forms.Label
        Dim ReadingOfMintesLabel As System.Windows.Forms.Label
        Dim TreasureReportLabel As System.Windows.Forms.Label
        Dim CommitteeReportLabel As System.Windows.Forms.Label
        Dim UnfinishedBusinessLabel As System.Windows.Forms.Label
        Dim NewBusinessLabel As System.Windows.Forms.Label
        Dim CommunicationsLabel As System.Windows.Forms.Label
        Dim TimeEndLabel As System.Windows.Forms.Label
        Dim DateIDLabel1 As System.Windows.Forms.Label
        Dim DateOfMeetingLabel As System.Windows.Forms.Label
        Dim MeetingStartLabel1 As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form8))
        Me.OESDataSet = New OES.OESDataSet()
        Me.TblMinutesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TblMinutesTableAdapter = New OES.OESDataSetTableAdapters.tblMinutesTableAdapter()
        Me.TableAdapterManager = New OES.OESDataSetTableAdapters.TableAdapterManager()
        Me.TblDateTableAdapter = New OES.OESDataSetTableAdapters.tblDateTableAdapter()
        Me.MinutesIDTextBox = New System.Windows.Forms.TextBox()
        Me.DateIDTextBox = New System.Windows.Forms.TextBox()
        Me.MeetingCalledByTextBox = New System.Windows.Forms.TextBox()
        Me.PrayerPeronTextBox = New System.Windows.Forms.TextBox()
        Me.RollCallTextBox = New System.Windows.Forms.TextBox()
        Me.SicknessAndDistressTextBox = New System.Windows.Forms.TextBox()
        Me.ReadingOfMintesTextBox = New System.Windows.Forms.TextBox()
        Me.TreasureReportTextBox = New System.Windows.Forms.TextBox()
        Me.CommitteeReportTextBox = New System.Windows.Forms.TextBox()
        Me.UnfinishedBusinessTextBox = New System.Windows.Forms.TextBox()
        Me.NewBusinessTextBox = New System.Windows.Forms.TextBox()
        Me.CommunicationsTextBox = New System.Windows.Forms.TextBox()
        Me.TblDateBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DateIDTextBox1 = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button8 = New System.Windows.Forms.Button()
        Me.Button10 = New System.Windows.Forms.Button()
        Me.Button11 = New System.Windows.Forms.Button()
        Me.Button12 = New System.Windows.Forms.Button()
        Me.Button13 = New System.Windows.Forms.Button()
        Me.DateOfMeetingTextBox = New System.Windows.Forms.TextBox()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.Button7 = New System.Windows.Forms.Button()
        Me.MeetingStartTextBox = New System.Windows.Forms.MaskedTextBox()
        Me.TimeEndTextBox = New System.Windows.Forms.MaskedTextBox()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        MinutesIDLabel = New System.Windows.Forms.Label()
        DateIDLabel = New System.Windows.Forms.Label()
        MeetingStartLabel = New System.Windows.Forms.Label()
        MeetingCalledByLabel = New System.Windows.Forms.Label()
        PrayerPeronLabel = New System.Windows.Forms.Label()
        RollCallLabel = New System.Windows.Forms.Label()
        SicknessAndDistressLabel = New System.Windows.Forms.Label()
        ReadingOfMintesLabel = New System.Windows.Forms.Label()
        TreasureReportLabel = New System.Windows.Forms.Label()
        CommitteeReportLabel = New System.Windows.Forms.Label()
        UnfinishedBusinessLabel = New System.Windows.Forms.Label()
        NewBusinessLabel = New System.Windows.Forms.Label()
        CommunicationsLabel = New System.Windows.Forms.Label()
        TimeEndLabel = New System.Windows.Forms.Label()
        DateIDLabel1 = New System.Windows.Forms.Label()
        DateOfMeetingLabel = New System.Windows.Forms.Label()
        MeetingStartLabel1 = New System.Windows.Forms.Label()
        CType(Me.OESDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TblMinutesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TblDateBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MinutesIDLabel
        '
        MinutesIDLabel.AutoSize = True
        MinutesIDLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        MinutesIDLabel.Location = New System.Drawing.Point(12, 9)
        MinutesIDLabel.Name = "MinutesIDLabel"
        MinutesIDLabel.Size = New System.Drawing.Size(72, 13)
        MinutesIDLabel.TabIndex = 1
        MinutesIDLabel.Text = "Minutes ID:"
        '
        'DateIDLabel
        '
        DateIDLabel.AutoSize = True
        DateIDLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DateIDLabel.Location = New System.Drawing.Point(146, 9)
        DateIDLabel.Name = "DateIDLabel"
        DateIDLabel.Size = New System.Drawing.Size(55, 13)
        DateIDLabel.TabIndex = 3
        DateIDLabel.Text = "Date ID:"
        '
        'MeetingStartLabel
        '
        MeetingStartLabel.AutoSize = True
        MeetingStartLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        MeetingStartLabel.Location = New System.Drawing.Point(12, 57)
        MeetingStartLabel.Name = "MeetingStartLabel"
        MeetingStartLabel.Size = New System.Drawing.Size(87, 13)
        MeetingStartLabel.TabIndex = 5
        MeetingStartLabel.Text = "Meeting Start:"
        '
        'MeetingCalledByLabel
        '
        MeetingCalledByLabel.AutoSize = True
        MeetingCalledByLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        MeetingCalledByLabel.Location = New System.Drawing.Point(12, 83)
        MeetingCalledByLabel.Name = "MeetingCalledByLabel"
        MeetingCalledByLabel.Size = New System.Drawing.Size(113, 13)
        MeetingCalledByLabel.TabIndex = 7
        MeetingCalledByLabel.Text = "Meeting Called By:"
        '
        'PrayerPeronLabel
        '
        PrayerPeronLabel.AutoSize = True
        PrayerPeronLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        PrayerPeronLabel.Location = New System.Drawing.Point(431, 82)
        PrayerPeronLabel.Name = "PrayerPeronLabel"
        PrayerPeronLabel.Size = New System.Drawing.Size(90, 13)
        PrayerPeronLabel.TabIndex = 9
        PrayerPeronLabel.Text = "Prayer Led By:"
        '
        'RollCallLabel
        '
        RollCallLabel.AutoSize = True
        RollCallLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        RollCallLabel.Location = New System.Drawing.Point(15, 107)
        RollCallLabel.Name = "RollCallLabel"
        RollCallLabel.Size = New System.Drawing.Size(54, 13)
        RollCallLabel.TabIndex = 11
        RollCallLabel.Text = "Roll Call"
        '
        'SicknessAndDistressLabel
        '
        SicknessAndDistressLabel.AutoSize = True
        SicknessAndDistressLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        SicknessAndDistressLabel.Location = New System.Drawing.Point(660, 107)
        SicknessAndDistressLabel.Name = "SicknessAndDistressLabel"
        SicknessAndDistressLabel.Size = New System.Drawing.Size(133, 13)
        SicknessAndDistressLabel.TabIndex = 13
        SicknessAndDistressLabel.Text = "Sickness And Distress"
        '
        'ReadingOfMintesLabel
        '
        ReadingOfMintesLabel.AutoSize = True
        ReadingOfMintesLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        ReadingOfMintesLabel.Location = New System.Drawing.Point(15, 223)
        ReadingOfMintesLabel.Name = "ReadingOfMintesLabel"
        ReadingOfMintesLabel.Size = New System.Drawing.Size(112, 13)
        ReadingOfMintesLabel.TabIndex = 15
        ReadingOfMintesLabel.Text = "Reading Of Mintes"
        '
        'TreasureReportLabel
        '
        TreasureReportLabel.AutoSize = True
        TreasureReportLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        TreasureReportLabel.Location = New System.Drawing.Point(660, 223)
        TreasureReportLabel.Name = "TreasureReportLabel"
        TreasureReportLabel.Size = New System.Drawing.Size(99, 13)
        TreasureReportLabel.TabIndex = 17
        TreasureReportLabel.Text = "Treasure Report"
        '
        'CommitteeReportLabel
        '
        CommitteeReportLabel.AutoSize = True
        CommitteeReportLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        CommitteeReportLabel.Location = New System.Drawing.Point(12, 339)
        CommitteeReportLabel.Name = "CommitteeReportLabel"
        CommitteeReportLabel.Size = New System.Drawing.Size(107, 13)
        CommitteeReportLabel.TabIndex = 19
        CommitteeReportLabel.Text = "Committee Report"
        '
        'UnfinishedBusinessLabel
        '
        UnfinishedBusinessLabel.AutoSize = True
        UnfinishedBusinessLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        UnfinishedBusinessLabel.Location = New System.Drawing.Point(660, 339)
        UnfinishedBusinessLabel.Name = "UnfinishedBusinessLabel"
        UnfinishedBusinessLabel.Size = New System.Drawing.Size(121, 13)
        UnfinishedBusinessLabel.TabIndex = 21
        UnfinishedBusinessLabel.Text = "Unfinished Business"
        '
        'NewBusinessLabel
        '
        NewBusinessLabel.AutoSize = True
        NewBusinessLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        NewBusinessLabel.Location = New System.Drawing.Point(15, 455)
        NewBusinessLabel.Name = "NewBusinessLabel"
        NewBusinessLabel.Size = New System.Drawing.Size(86, 13)
        NewBusinessLabel.TabIndex = 23
        NewBusinessLabel.Text = "New Business"
        '
        'CommunicationsLabel
        '
        CommunicationsLabel.AutoSize = True
        CommunicationsLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        CommunicationsLabel.Location = New System.Drawing.Point(661, 455)
        CommunicationsLabel.Name = "CommunicationsLabel"
        CommunicationsLabel.Size = New System.Drawing.Size(98, 13)
        CommunicationsLabel.TabIndex = 25
        CommunicationsLabel.Text = "Communications"
        '
        'TimeEndLabel
        '
        TimeEndLabel.AutoSize = True
        TimeEndLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        TimeEndLabel.Location = New System.Drawing.Point(15, 574)
        TimeEndLabel.Name = "TimeEndLabel"
        TimeEndLabel.Size = New System.Drawing.Size(64, 13)
        TimeEndLabel.TabIndex = 29
        TimeEndLabel.Text = "Time End:"
        '
        'DateIDLabel1
        '
        DateIDLabel1.AutoSize = True
        DateIDLabel1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DateIDLabel1.Location = New System.Drawing.Point(261, 9)
        DateIDLabel1.Name = "DateIDLabel1"
        DateIDLabel1.Size = New System.Drawing.Size(55, 13)
        DateIDLabel1.TabIndex = 30
        DateIDLabel1.Text = "Date ID:"
        '
        'DateOfMeetingLabel
        '
        DateOfMeetingLabel.AutoSize = True
        DateOfMeetingLabel.Location = New System.Drawing.Point(431, 33)
        DateOfMeetingLabel.Name = "DateOfMeetingLabel"
        DateOfMeetingLabel.Size = New System.Drawing.Size(88, 13)
        DateOfMeetingLabel.TabIndex = 48
        DateOfMeetingLabel.Text = "Date Of Meeting:"
        '
        'MeetingStartLabel1
        '
        MeetingStartLabel1.AutoSize = True
        MeetingStartLabel1.Location = New System.Drawing.Point(880, 90)
        MeetingStartLabel1.Name = "MeetingStartLabel1"
        MeetingStartLabel1.Size = New System.Drawing.Size(73, 13)
        MeetingStartLabel1.TabIndex = 55
        MeetingStartLabel1.Text = "Meeting Start:"
        '
        'OESDataSet
        '
        Me.OESDataSet.DataSetName = "OESDataSet"
        Me.OESDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'TblMinutesBindingSource
        '
        Me.TblMinutesBindingSource.DataMember = "tblMinutes"
        Me.TblMinutesBindingSource.DataSource = Me.OESDataSet
        '
        'TblMinutesTableAdapter
        '
        Me.TblMinutesTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.Login1TableAdapter = Nothing
        Me.TableAdapterManager.LoginTableAdapter = Nothing
        Me.TableAdapterManager.tblDateTableAdapter = Me.TblDateTableAdapter
        Me.TableAdapterManager.tblDuesTableAdapter = Nothing
        Me.TableAdapterManager.tblMemberTableAdapter = Nothing
        Me.TableAdapterManager.tblMinutesTableAdapter = Me.TblMinutesTableAdapter
        Me.TableAdapterManager.tblOfficerTableAdapter = Nothing
        Me.TableAdapterManager.tblTreasureTableAdapter = Nothing
        Me.TableAdapterManager.tblVisitorTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = OES.OESDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'TblDateTableAdapter
        '
        Me.TblDateTableAdapter.ClearBeforeFill = True
        '
        'MinutesIDTextBox
        '
        Me.MinutesIDTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblMinutesBindingSource, "MinutesID", True))
        Me.MinutesIDTextBox.Location = New System.Drawing.Point(89, 6)
        Me.MinutesIDTextBox.Name = "MinutesIDTextBox"
        Me.MinutesIDTextBox.ReadOnly = True
        Me.MinutesIDTextBox.Size = New System.Drawing.Size(39, 20)
        Me.MinutesIDTextBox.TabIndex = 2
        '
        'DateIDTextBox
        '
        Me.DateIDTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblMinutesBindingSource, "DateID", True))
        Me.DateIDTextBox.Location = New System.Drawing.Point(207, 6)
        Me.DateIDTextBox.Name = "DateIDTextBox"
        Me.DateIDTextBox.ReadOnly = True
        Me.DateIDTextBox.Size = New System.Drawing.Size(39, 20)
        Me.DateIDTextBox.TabIndex = 4
        '
        'MeetingCalledByTextBox
        '
        Me.MeetingCalledByTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblMinutesBindingSource, "MeetingCalledBy", True))
        Me.MeetingCalledByTextBox.Font = New System.Drawing.Font("Lucida Console", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MeetingCalledByTextBox.Location = New System.Drawing.Point(131, 80)
        Me.MeetingCalledByTextBox.Name = "MeetingCalledByTextBox"
        Me.MeetingCalledByTextBox.Size = New System.Drawing.Size(248, 22)
        Me.MeetingCalledByTextBox.TabIndex = 8
        '
        'PrayerPeronTextBox
        '
        Me.PrayerPeronTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblMinutesBindingSource, "PrayerPeron", True))
        Me.PrayerPeronTextBox.Font = New System.Drawing.Font("Lucida Console", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PrayerPeronTextBox.Location = New System.Drawing.Point(527, 79)
        Me.PrayerPeronTextBox.Name = "PrayerPeronTextBox"
        Me.PrayerPeronTextBox.Size = New System.Drawing.Size(254, 22)
        Me.PrayerPeronTextBox.TabIndex = 10
        '
        'RollCallTextBox
        '
        Me.RollCallTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblMinutesBindingSource, "RollCall", True))
        Me.RollCallTextBox.Font = New System.Drawing.Font("Lucida Console", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RollCallTextBox.Location = New System.Drawing.Point(18, 123)
        Me.RollCallTextBox.Multiline = True
        Me.RollCallTextBox.Name = "RollCallTextBox"
        Me.RollCallTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.RollCallTextBox.Size = New System.Drawing.Size(620, 97)
        Me.RollCallTextBox.TabIndex = 12
        '
        'SicknessAndDistressTextBox
        '
        Me.SicknessAndDistressTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblMinutesBindingSource, "SicknessAndDistress", True))
        Me.SicknessAndDistressTextBox.Font = New System.Drawing.Font("Lucida Console", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SicknessAndDistressTextBox.Location = New System.Drawing.Point(663, 123)
        Me.SicknessAndDistressTextBox.Multiline = True
        Me.SicknessAndDistressTextBox.Name = "SicknessAndDistressTextBox"
        Me.SicknessAndDistressTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.SicknessAndDistressTextBox.Size = New System.Drawing.Size(593, 97)
        Me.SicknessAndDistressTextBox.TabIndex = 14
        '
        'ReadingOfMintesTextBox
        '
        Me.ReadingOfMintesTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblMinutesBindingSource, "ReadingOfMintes", True))
        Me.ReadingOfMintesTextBox.Font = New System.Drawing.Font("Lucida Console", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ReadingOfMintesTextBox.Location = New System.Drawing.Point(18, 239)
        Me.ReadingOfMintesTextBox.Multiline = True
        Me.ReadingOfMintesTextBox.Name = "ReadingOfMintesTextBox"
        Me.ReadingOfMintesTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.ReadingOfMintesTextBox.Size = New System.Drawing.Size(620, 97)
        Me.ReadingOfMintesTextBox.TabIndex = 16
        '
        'TreasureReportTextBox
        '
        Me.TreasureReportTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblMinutesBindingSource, "TreasureReport", True))
        Me.TreasureReportTextBox.Font = New System.Drawing.Font("Lucida Console", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TreasureReportTextBox.Location = New System.Drawing.Point(663, 239)
        Me.TreasureReportTextBox.Multiline = True
        Me.TreasureReportTextBox.Name = "TreasureReportTextBox"
        Me.TreasureReportTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.TreasureReportTextBox.Size = New System.Drawing.Size(584, 97)
        Me.TreasureReportTextBox.TabIndex = 18
        '
        'CommitteeReportTextBox
        '
        Me.CommitteeReportTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblMinutesBindingSource, "CommitteeReport", True))
        Me.CommitteeReportTextBox.Font = New System.Drawing.Font("Lucida Console", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CommitteeReportTextBox.Location = New System.Drawing.Point(18, 355)
        Me.CommitteeReportTextBox.Multiline = True
        Me.CommitteeReportTextBox.Name = "CommitteeReportTextBox"
        Me.CommitteeReportTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.CommitteeReportTextBox.Size = New System.Drawing.Size(620, 97)
        Me.CommitteeReportTextBox.TabIndex = 20
        '
        'UnfinishedBusinessTextBox
        '
        Me.UnfinishedBusinessTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblMinutesBindingSource, "UnfinishedBusiness", True))
        Me.UnfinishedBusinessTextBox.Font = New System.Drawing.Font("Lucida Console", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UnfinishedBusinessTextBox.Location = New System.Drawing.Point(663, 355)
        Me.UnfinishedBusinessTextBox.Multiline = True
        Me.UnfinishedBusinessTextBox.Name = "UnfinishedBusinessTextBox"
        Me.UnfinishedBusinessTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.UnfinishedBusinessTextBox.Size = New System.Drawing.Size(584, 97)
        Me.UnfinishedBusinessTextBox.TabIndex = 22
        '
        'NewBusinessTextBox
        '
        Me.NewBusinessTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblMinutesBindingSource, "NewBusiness", True))
        Me.NewBusinessTextBox.Font = New System.Drawing.Font("Lucida Console", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NewBusinessTextBox.Location = New System.Drawing.Point(18, 471)
        Me.NewBusinessTextBox.Multiline = True
        Me.NewBusinessTextBox.Name = "NewBusinessTextBox"
        Me.NewBusinessTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.NewBusinessTextBox.Size = New System.Drawing.Size(620, 97)
        Me.NewBusinessTextBox.TabIndex = 24
        '
        'CommunicationsTextBox
        '
        Me.CommunicationsTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblMinutesBindingSource, "Communications", True))
        Me.CommunicationsTextBox.Font = New System.Drawing.Font("Lucida Console", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CommunicationsTextBox.Location = New System.Drawing.Point(663, 471)
        Me.CommunicationsTextBox.Multiline = True
        Me.CommunicationsTextBox.Name = "CommunicationsTextBox"
        Me.CommunicationsTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.CommunicationsTextBox.Size = New System.Drawing.Size(584, 97)
        Me.CommunicationsTextBox.TabIndex = 26
        '
        'TblDateBindingSource
        '
        Me.TblDateBindingSource.DataMember = "tblDate"
        Me.TblDateBindingSource.DataSource = Me.OESDataSet
        '
        'DateIDTextBox1
        '
        Me.DateIDTextBox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblDateBindingSource, "DateID", True))
        Me.DateIDTextBox1.Location = New System.Drawing.Point(318, 6)
        Me.DateIDTextBox1.Name = "DateIDTextBox1"
        Me.DateIDTextBox1.ReadOnly = True
        Me.DateIDTextBox1.Size = New System.Drawing.Size(39, 20)
        Me.DateIDTextBox1.TabIndex = 31
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(731, 4)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(100, 23)
        Me.Button1.TabIndex = 34
        Me.Button1.Text = "ADD MINUTES"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(943, 4)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(121, 23)
        Me.Button2.TabIndex = 35
        Me.Button2.Text = "DELETE MINUTES"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(837, 4)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(100, 23)
        Me.Button3.TabIndex = 36
        Me.Button3.Text = "SAVE MINUTES"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button8
        '
        Me.Button8.Location = New System.Drawing.Point(731, 34)
        Me.Button8.Name = "Button8"
        Me.Button8.Size = New System.Drawing.Size(100, 23)
        Me.Button8.TabIndex = 41
        Me.Button8.Text = "SPELL CHECK"
        Me.Button8.UseVisualStyleBackColor = True
        '
        'Button10
        '
        Me.Button10.Location = New System.Drawing.Point(1106, 4)
        Me.Button10.Name = "Button10"
        Me.Button10.Size = New System.Drawing.Size(103, 23)
        Me.Button10.TabIndex = 43
        Me.Button10.Text = "MAIN MENU"
        Me.Button10.UseVisualStyleBackColor = True
        '
        'Button11
        '
        Me.Button11.Location = New System.Drawing.Point(943, 33)
        Me.Button11.Name = "Button11"
        Me.Button11.Size = New System.Drawing.Size(121, 23)
        Me.Button11.TabIndex = 44
        Me.Button11.Text = "DELETE DATE"
        Me.Button11.UseVisualStyleBackColor = True
        '
        'Button12
        '
        Me.Button12.Location = New System.Drawing.Point(1106, 33)
        Me.Button12.Name = "Button12"
        Me.Button12.Size = New System.Drawing.Size(103, 23)
        Me.Button12.TabIndex = 45
        Me.Button12.Text = "PRINT MINUTES"
        Me.Button12.UseVisualStyleBackColor = True
        '
        'Button13
        '
        Me.Button13.Location = New System.Drawing.Point(1018, 72)
        Me.Button13.Name = "Button13"
        Me.Button13.Size = New System.Drawing.Size(238, 23)
        Me.Button13.TabIndex = 46
        Me.Button13.Text = "TREASURE/OFFICER/VISITOR MENUS"
        Me.Button13.UseVisualStyleBackColor = True
        '
        'DateOfMeetingTextBox
        '
        Me.DateOfMeetingTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblDateBindingSource, "DateOfMeeting", True))
        Me.DateOfMeetingTextBox.Location = New System.Drawing.Point(406, 50)
        Me.DateOfMeetingTextBox.Name = "DateOfMeetingTextBox"
        Me.DateOfMeetingTextBox.ReadOnly = True
        Me.DateOfMeetingTextBox.Size = New System.Drawing.Size(148, 20)
        Me.DateOfMeetingTextBox.TabIndex = 49
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(344, 48)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(31, 23)
        Me.Button4.TabIndex = 50
        Me.Button4.Text = "<<"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Button5
        '
        Me.Button5.Location = New System.Drawing.Point(375, 48)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(31, 23)
        Me.Button5.TabIndex = 51
        Me.Button5.Text = "<"
        Me.Button5.UseVisualStyleBackColor = True
        '
        'Button6
        '
        Me.Button6.Location = New System.Drawing.Point(554, 48)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(31, 23)
        Me.Button6.TabIndex = 52
        Me.Button6.Text = ">"
        Me.Button6.UseVisualStyleBackColor = True
        '
        'Button7
        '
        Me.Button7.Location = New System.Drawing.Point(585, 48)
        Me.Button7.Name = "Button7"
        Me.Button7.Size = New System.Drawing.Size(31, 23)
        Me.Button7.TabIndex = 53
        Me.Button7.Text = ">>"
        Me.Button7.UseVisualStyleBackColor = True
        '
        'MeetingStartTextBox
        '
        Me.MeetingStartTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblMinutesBindingSource, "MeetingStart", True))
        Me.MeetingStartTextBox.Location = New System.Drawing.Point(105, 54)
        Me.MeetingStartTextBox.Mask = "90:00"
        Me.MeetingStartTextBox.Name = "MeetingStartTextBox"
        Me.MeetingStartTextBox.Size = New System.Drawing.Size(42, 20)
        Me.MeetingStartTextBox.TabIndex = 7
        Me.MeetingStartTextBox.ValidatingType = GetType(Date)
        '
        'TimeEndTextBox
        '
        Me.TimeEndTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblMinutesBindingSource, "TimeEnd", True))
        Me.TimeEndTextBox.Location = New System.Drawing.Point(85, 571)
        Me.TimeEndTextBox.Mask = "90:00"
        Me.TimeEndTextBox.Name = "TimeEndTextBox"
        Me.TimeEndTextBox.Size = New System.Drawing.Size(43, 20)
        Me.TimeEndTextBox.TabIndex = 27
        Me.TimeEndTextBox.ValidatingType = GetType(Date)
        '
        'ComboBox1
        '
        Me.ComboBox1.DataSource = Me.TblDateBindingSource
        Me.ComboBox1.DisplayMember = "DateOfMeeting"
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(816, 63)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(147, 21)
        Me.ComboBox1.TabIndex = 58
        '
        'Form8
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange
        Me.ClientSize = New System.Drawing.Size(1276, 599)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.TimeEndTextBox)
        Me.Controls.Add(MeetingStartLabel1)
        Me.Controls.Add(Me.MeetingStartTextBox)
        Me.Controls.Add(Me.Button7)
        Me.Controls.Add(Me.Button6)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(DateOfMeetingLabel)
        Me.Controls.Add(Me.DateOfMeetingTextBox)
        Me.Controls.Add(Me.Button13)
        Me.Controls.Add(Me.Button12)
        Me.Controls.Add(Me.Button11)
        Me.Controls.Add(Me.Button10)
        Me.Controls.Add(Me.Button8)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(DateIDLabel1)
        Me.Controls.Add(Me.DateIDTextBox1)
        Me.Controls.Add(MinutesIDLabel)
        Me.Controls.Add(Me.MinutesIDTextBox)
        Me.Controls.Add(DateIDLabel)
        Me.Controls.Add(Me.DateIDTextBox)
        Me.Controls.Add(MeetingStartLabel)
        Me.Controls.Add(MeetingCalledByLabel)
        Me.Controls.Add(Me.MeetingCalledByTextBox)
        Me.Controls.Add(PrayerPeronLabel)
        Me.Controls.Add(Me.PrayerPeronTextBox)
        Me.Controls.Add(RollCallLabel)
        Me.Controls.Add(Me.RollCallTextBox)
        Me.Controls.Add(SicknessAndDistressLabel)
        Me.Controls.Add(Me.SicknessAndDistressTextBox)
        Me.Controls.Add(ReadingOfMintesLabel)
        Me.Controls.Add(Me.ReadingOfMintesTextBox)
        Me.Controls.Add(TreasureReportLabel)
        Me.Controls.Add(Me.TreasureReportTextBox)
        Me.Controls.Add(CommitteeReportLabel)
        Me.Controls.Add(Me.CommitteeReportTextBox)
        Me.Controls.Add(UnfinishedBusinessLabel)
        Me.Controls.Add(Me.UnfinishedBusinessTextBox)
        Me.Controls.Add(NewBusinessLabel)
        Me.Controls.Add(Me.NewBusinessTextBox)
        Me.Controls.Add(CommunicationsLabel)
        Me.Controls.Add(Me.CommunicationsTextBox)
        Me.Controls.Add(TimeEndLabel)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Form8"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "MINUTES"
        CType(Me.OESDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TblMinutesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TblDateBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents OESDataSet As OESDataSet
    Friend WithEvents TblMinutesBindingSource As BindingSource
    Friend WithEvents TblMinutesTableAdapter As OESDataSetTableAdapters.tblMinutesTableAdapter
    Friend WithEvents TableAdapterManager As OESDataSetTableAdapters.TableAdapterManager
    Friend WithEvents MinutesIDTextBox As TextBox
    Friend WithEvents DateIDTextBox As TextBox
    Friend WithEvents MeetingCalledByTextBox As TextBox
    Friend WithEvents PrayerPeronTextBox As TextBox
    Friend WithEvents RollCallTextBox As TextBox
    Friend WithEvents SicknessAndDistressTextBox As TextBox
    Friend WithEvents ReadingOfMintesTextBox As TextBox
    Friend WithEvents TreasureReportTextBox As TextBox
    Friend WithEvents CommitteeReportTextBox As TextBox
    Friend WithEvents UnfinishedBusinessTextBox As TextBox
    Friend WithEvents NewBusinessTextBox As TextBox
    Friend WithEvents CommunicationsTextBox As TextBox
    Friend WithEvents TblDateTableAdapter As OESDataSetTableAdapters.tblDateTableAdapter
    Friend WithEvents TblDateBindingSource As BindingSource
    Friend WithEvents DateIDTextBox1 As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Button8 As Button
    Friend WithEvents Button10 As Button
    Friend WithEvents Button11 As Button
    Friend WithEvents Button12 As Button
    Friend WithEvents Button13 As Button
    Friend WithEvents DateOfMeetingTextBox As TextBox
    Friend WithEvents Button4 As Button
    Friend WithEvents Button5 As Button
    Friend WithEvents Button6 As Button
    Friend WithEvents Button7 As Button
    Friend WithEvents MeetingStartTextBox As MaskedTextBox
    Friend WithEvents TimeEndTextBox As MaskedTextBox
    Friend WithEvents ComboBox1 As ComboBox
End Class
