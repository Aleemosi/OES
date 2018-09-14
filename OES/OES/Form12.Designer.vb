<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form12
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
        Dim DateIDLabel As System.Windows.Forms.Label
        Dim DateOfMeetingLabel As System.Windows.Forms.Label
        Dim TreasureIDLabel As System.Windows.Forms.Label
        Dim DateIDLabel1 As System.Windows.Forms.Label
        Dim SisterOrBrotherLabel As System.Windows.Forms.Label
        Dim OtherContributorLabel As System.Windows.Forms.Label
        Dim ContributionDescriptionLabel As System.Windows.Forms.Label
        Dim QuantityLabel As System.Windows.Forms.Label
        Dim RecurrenceDuesLabel As System.Windows.Forms.Label
        Dim PriceOfDonationLabel As System.Windows.Forms.Label
        Dim DuesPayedLabel As System.Windows.Forms.Label
        Dim TypeOfPaymentLabel As System.Windows.Forms.Label
        Dim TotalPaidLabel As System.Windows.Forms.Label
        Dim DateToTreasureLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form12))
        Me.OESDataSet = New OES.OESDataSet()
        Me.TblDateBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TblDateTableAdapter = New OES.OESDataSetTableAdapters.tblDateTableAdapter()
        Me.TableAdapterManager = New OES.OESDataSetTableAdapters.TableAdapterManager()
        Me.TblTreasureTableAdapter = New OES.OESDataSetTableAdapters.tblTreasureTableAdapter()
        Me.DateIDTextBox = New System.Windows.Forms.TextBox()
        Me.DateOfMeetingTextBox = New System.Windows.Forms.TextBox()
        Me.TblTreasureBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TreasureIDTextBox = New System.Windows.Forms.TextBox()
        Me.DateIDTextBox1 = New System.Windows.Forms.TextBox()
        Me.SisterOrBrotherTextBox = New System.Windows.Forms.TextBox()
        Me.OtherContributorTextBox = New System.Windows.Forms.TextBox()
        Me.ContributionDescriptionComboBox = New System.Windows.Forms.ComboBox()
        Me.QuantityTextBox = New System.Windows.Forms.TextBox()
        Me.RecurrenceDuesComboBox = New System.Windows.Forms.ComboBox()
        Me.PriceOfDonationTextBox = New System.Windows.Forms.TextBox()
        Me.DuesPayedTextBox = New System.Windows.Forms.TextBox()
        Me.TypeOfPaymentComboBox = New System.Windows.Forms.ComboBox()
        Me.TotalPaidTextBox = New System.Windows.Forms.TextBox()
        Me.DateToTreasureDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.Button7 = New System.Windows.Forms.Button()
        DateIDLabel = New System.Windows.Forms.Label()
        DateOfMeetingLabel = New System.Windows.Forms.Label()
        TreasureIDLabel = New System.Windows.Forms.Label()
        DateIDLabel1 = New System.Windows.Forms.Label()
        SisterOrBrotherLabel = New System.Windows.Forms.Label()
        OtherContributorLabel = New System.Windows.Forms.Label()
        ContributionDescriptionLabel = New System.Windows.Forms.Label()
        QuantityLabel = New System.Windows.Forms.Label()
        RecurrenceDuesLabel = New System.Windows.Forms.Label()
        PriceOfDonationLabel = New System.Windows.Forms.Label()
        DuesPayedLabel = New System.Windows.Forms.Label()
        TypeOfPaymentLabel = New System.Windows.Forms.Label()
        TotalPaidLabel = New System.Windows.Forms.Label()
        DateToTreasureLabel = New System.Windows.Forms.Label()
        CType(Me.OESDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TblDateBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TblTreasureBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DateIDLabel
        '
        DateIDLabel.AutoSize = True
        DateIDLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DateIDLabel.Location = New System.Drawing.Point(165, 10)
        DateIDLabel.Name = "DateIDLabel"
        DateIDLabel.Size = New System.Drawing.Size(59, 15)
        DateIDLabel.TabIndex = 1
        DateIDLabel.Text = "Date ID:"
        '
        'DateOfMeetingLabel
        '
        DateOfMeetingLabel.AutoSize = True
        DateOfMeetingLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DateOfMeetingLabel.Location = New System.Drawing.Point(249, 46)
        DateOfMeetingLabel.Name = "DateOfMeetingLabel"
        DateOfMeetingLabel.Size = New System.Drawing.Size(111, 15)
        DateOfMeetingLabel.TabIndex = 3
        DateOfMeetingLabel.Text = "Date Of Meeting"
        '
        'TreasureIDLabel
        '
        TreasureIDLabel.AutoSize = True
        TreasureIDLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        TreasureIDLabel.Location = New System.Drawing.Point(9, 10)
        TreasureIDLabel.Name = "TreasureIDLabel"
        TreasureIDLabel.Size = New System.Drawing.Size(86, 15)
        TreasureIDLabel.TabIndex = 4
        TreasureIDLabel.Text = "Treasure ID:"
        '
        'DateIDLabel1
        '
        DateIDLabel1.AutoSize = True
        DateIDLabel1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DateIDLabel1.Location = New System.Drawing.Point(298, 10)
        DateIDLabel1.Name = "DateIDLabel1"
        DateIDLabel1.Size = New System.Drawing.Size(59, 15)
        DateIDLabel1.TabIndex = 6
        DateIDLabel1.Text = "Date ID:"
        '
        'SisterOrBrotherLabel
        '
        SisterOrBrotherLabel.AutoSize = True
        SisterOrBrotherLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        SisterOrBrotherLabel.Location = New System.Drawing.Point(12, 94)
        SisterOrBrotherLabel.Name = "SisterOrBrotherLabel"
        SisterOrBrotherLabel.Size = New System.Drawing.Size(118, 15)
        SisterOrBrotherLabel.TabIndex = 8
        SisterOrBrotherLabel.Text = "Sister Or Brother:"
        '
        'OtherContributorLabel
        '
        OtherContributorLabel.AutoSize = True
        OtherContributorLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        OtherContributorLabel.Location = New System.Drawing.Point(12, 126)
        OtherContributorLabel.Name = "OtherContributorLabel"
        OtherContributorLabel.Size = New System.Drawing.Size(121, 15)
        OtherContributorLabel.TabIndex = 10
        OtherContributorLabel.Text = "Other Contributor:"
        '
        'ContributionDescriptionLabel
        '
        ContributionDescriptionLabel.AutoSize = True
        ContributionDescriptionLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        ContributionDescriptionLabel.Location = New System.Drawing.Point(12, 157)
        ContributionDescriptionLabel.Name = "ContributionDescriptionLabel"
        ContributionDescriptionLabel.Size = New System.Drawing.Size(166, 15)
        ContributionDescriptionLabel.TabIndex = 12
        ContributionDescriptionLabel.Text = "Contribution Description:"
        '
        'QuantityLabel
        '
        QuantityLabel.AutoSize = True
        QuantityLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        QuantityLabel.Location = New System.Drawing.Point(12, 186)
        QuantityLabel.Name = "QuantityLabel"
        QuantityLabel.Size = New System.Drawing.Size(63, 15)
        QuantityLabel.TabIndex = 14
        QuantityLabel.Text = "Quantity:"
        '
        'RecurrenceDuesLabel
        '
        RecurrenceDuesLabel.AutoSize = True
        RecurrenceDuesLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        RecurrenceDuesLabel.Location = New System.Drawing.Point(362, 94)
        RecurrenceDuesLabel.Name = "RecurrenceDuesLabel"
        RecurrenceDuesLabel.Size = New System.Drawing.Size(122, 15)
        RecurrenceDuesLabel.TabIndex = 16
        RecurrenceDuesLabel.Text = "Recurrence Dues:"
        '
        'PriceOfDonationLabel
        '
        PriceOfDonationLabel.AutoSize = True
        PriceOfDonationLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        PriceOfDonationLabel.Location = New System.Drawing.Point(360, 130)
        PriceOfDonationLabel.Name = "PriceOfDonationLabel"
        PriceOfDonationLabel.Size = New System.Drawing.Size(124, 15)
        PriceOfDonationLabel.TabIndex = 18
        PriceOfDonationLabel.Text = "Price Of Donation:"
        '
        'DuesPayedLabel
        '
        DuesPayedLabel.AutoSize = True
        DuesPayedLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DuesPayedLabel.Location = New System.Drawing.Point(397, 157)
        DuesPayedLabel.Name = "DuesPayedLabel"
        DuesPayedLabel.Size = New System.Drawing.Size(87, 15)
        DuesPayedLabel.TabIndex = 20
        DuesPayedLabel.Text = "Dues Payed:"
        '
        'TypeOfPaymentLabel
        '
        TypeOfPaymentLabel.AutoSize = True
        TypeOfPaymentLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        TypeOfPaymentLabel.Location = New System.Drawing.Point(366, 186)
        TypeOfPaymentLabel.Name = "TypeOfPaymentLabel"
        TypeOfPaymentLabel.Size = New System.Drawing.Size(118, 15)
        TypeOfPaymentLabel.TabIndex = 22
        TypeOfPaymentLabel.Text = "Type Of Payment:"
        '
        'TotalPaidLabel
        '
        TotalPaidLabel.AutoSize = True
        TotalPaidLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        TotalPaidLabel.Location = New System.Drawing.Point(408, 219)
        TotalPaidLabel.Name = "TotalPaidLabel"
        TotalPaidLabel.Size = New System.Drawing.Size(76, 15)
        TotalPaidLabel.TabIndex = 24
        TotalPaidLabel.Text = "Total Paid:"
        '
        'DateToTreasureLabel
        '
        DateToTreasureLabel.AutoSize = True
        DateToTreasureLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DateToTreasureLabel.Location = New System.Drawing.Point(362, 249)
        DateToTreasureLabel.Name = "DateToTreasureLabel"
        DateToTreasureLabel.Size = New System.Drawing.Size(122, 15)
        DateToTreasureLabel.TabIndex = 26
        DateToTreasureLabel.Text = "Date To Treasure:"
        '
        'OESDataSet
        '
        Me.OESDataSet.DataSetName = "OESDataSet"
        Me.OESDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'TblDateBindingSource
        '
        Me.TblDateBindingSource.DataMember = "tblDate"
        Me.TblDateBindingSource.DataSource = Me.OESDataSet
        '
        'TblDateTableAdapter
        '
        Me.TblDateTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.Login1TableAdapter = Nothing
        Me.TableAdapterManager.LoginTableAdapter = Nothing
        Me.TableAdapterManager.tblDateTableAdapter = Me.TblDateTableAdapter
        Me.TableAdapterManager.tblDuesTableAdapter = Nothing
        Me.TableAdapterManager.tblMemberTableAdapter = Nothing
        Me.TableAdapterManager.tblMinutesTableAdapter = Nothing
        Me.TableAdapterManager.tblOfficerTableAdapter = Nothing
        Me.TableAdapterManager.tblTreasureTableAdapter = Me.TblTreasureTableAdapter
        Me.TableAdapterManager.tblVisitorTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = OES.OESDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'TblTreasureTableAdapter
        '
        Me.TblTreasureTableAdapter.ClearBeforeFill = True
        '
        'DateIDTextBox
        '
        Me.DateIDTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblDateBindingSource, "DateID", True))
        Me.DateIDTextBox.Location = New System.Drawing.Point(230, 9)
        Me.DateIDTextBox.Name = "DateIDTextBox"
        Me.DateIDTextBox.ReadOnly = True
        Me.DateIDTextBox.Size = New System.Drawing.Size(43, 20)
        Me.DateIDTextBox.TabIndex = 2
        '
        'DateOfMeetingTextBox
        '
        Me.DateOfMeetingTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblDateBindingSource, "DateOfMeeting", True))
        Me.DateOfMeetingTextBox.Location = New System.Drawing.Point(246, 64)
        Me.DateOfMeetingTextBox.Name = "DateOfMeetingTextBox"
        Me.DateOfMeetingTextBox.ReadOnly = True
        Me.DateOfMeetingTextBox.Size = New System.Drawing.Size(114, 20)
        Me.DateOfMeetingTextBox.TabIndex = 4
        '
        'TblTreasureBindingSource
        '
        Me.TblTreasureBindingSource.DataMember = "tblDatetblTreasure"
        Me.TblTreasureBindingSource.DataSource = Me.TblDateBindingSource
        '
        'TreasureIDTextBox
        '
        Me.TreasureIDTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblTreasureBindingSource, "TreasureID", True))
        Me.TreasureIDTextBox.Location = New System.Drawing.Point(100, 9)
        Me.TreasureIDTextBox.Name = "TreasureIDTextBox"
        Me.TreasureIDTextBox.ReadOnly = True
        Me.TreasureIDTextBox.Size = New System.Drawing.Size(43, 20)
        Me.TreasureIDTextBox.TabIndex = 5
        '
        'DateIDTextBox1
        '
        Me.DateIDTextBox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblTreasureBindingSource, "DateID", True))
        Me.DateIDTextBox1.Location = New System.Drawing.Point(363, 9)
        Me.DateIDTextBox1.Name = "DateIDTextBox1"
        Me.DateIDTextBox1.ReadOnly = True
        Me.DateIDTextBox1.Size = New System.Drawing.Size(45, 20)
        Me.DateIDTextBox1.TabIndex = 7
        '
        'SisterOrBrotherTextBox
        '
        Me.SisterOrBrotherTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblTreasureBindingSource, "SisterOrBrother", True))
        Me.SisterOrBrotherTextBox.Location = New System.Drawing.Point(136, 93)
        Me.SisterOrBrotherTextBox.Name = "SisterOrBrotherTextBox"
        Me.SisterOrBrotherTextBox.Size = New System.Drawing.Size(200, 20)
        Me.SisterOrBrotherTextBox.TabIndex = 9
        '
        'OtherContributorTextBox
        '
        Me.OtherContributorTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblTreasureBindingSource, "OtherContributor", True))
        Me.OtherContributorTextBox.Location = New System.Drawing.Point(136, 125)
        Me.OtherContributorTextBox.Name = "OtherContributorTextBox"
        Me.OtherContributorTextBox.Size = New System.Drawing.Size(200, 20)
        Me.OtherContributorTextBox.TabIndex = 11
        '
        'ContributionDescriptionComboBox
        '
        Me.ContributionDescriptionComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblTreasureBindingSource, "ContributionDescription", True))
        Me.ContributionDescriptionComboBox.FormattingEnabled = True
        Me.ContributionDescriptionComboBox.Items.AddRange(New Object() {"Charity", "Dues", "Donation", "Fund Raiser"})
        Me.ContributionDescriptionComboBox.Location = New System.Drawing.Point(184, 156)
        Me.ContributionDescriptionComboBox.Name = "ContributionDescriptionComboBox"
        Me.ContributionDescriptionComboBox.Size = New System.Drawing.Size(152, 21)
        Me.ContributionDescriptionComboBox.TabIndex = 13
        '
        'QuantityTextBox
        '
        Me.QuantityTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblTreasureBindingSource, "Quantity", True))
        Me.QuantityTextBox.Location = New System.Drawing.Point(77, 185)
        Me.QuantityTextBox.Name = "QuantityTextBox"
        Me.QuantityTextBox.Size = New System.Drawing.Size(43, 20)
        Me.QuantityTextBox.TabIndex = 15
        '
        'RecurrenceDuesComboBox
        '
        Me.RecurrenceDuesComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblTreasureBindingSource, "RecurrenceDues", True))
        Me.RecurrenceDuesComboBox.FormattingEnabled = True
        Me.RecurrenceDuesComboBox.Items.AddRange(New Object() {"One", "Weekly", "Yearly", "Quaterly"})
        Me.RecurrenceDuesComboBox.Location = New System.Drawing.Point(490, 93)
        Me.RecurrenceDuesComboBox.Name = "RecurrenceDuesComboBox"
        Me.RecurrenceDuesComboBox.Size = New System.Drawing.Size(152, 21)
        Me.RecurrenceDuesComboBox.TabIndex = 17
        '
        'PriceOfDonationTextBox
        '
        Me.PriceOfDonationTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblTreasureBindingSource, "PriceOfDonation", True))
        Me.PriceOfDonationTextBox.Location = New System.Drawing.Point(490, 129)
        Me.PriceOfDonationTextBox.Name = "PriceOfDonationTextBox"
        Me.PriceOfDonationTextBox.Size = New System.Drawing.Size(72, 20)
        Me.PriceOfDonationTextBox.TabIndex = 19
        '
        'DuesPayedTextBox
        '
        Me.DuesPayedTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblTreasureBindingSource, "DuesPayed", True))
        Me.DuesPayedTextBox.Location = New System.Drawing.Point(490, 156)
        Me.DuesPayedTextBox.Name = "DuesPayedTextBox"
        Me.DuesPayedTextBox.Size = New System.Drawing.Size(72, 20)
        Me.DuesPayedTextBox.TabIndex = 21
        '
        'TypeOfPaymentComboBox
        '
        Me.TypeOfPaymentComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblTreasureBindingSource, "TypeOfPayment", True))
        Me.TypeOfPaymentComboBox.FormattingEnabled = True
        Me.TypeOfPaymentComboBox.Items.AddRange(New Object() {"Cash", "Check", "Money Order"})
        Me.TypeOfPaymentComboBox.Location = New System.Drawing.Point(490, 185)
        Me.TypeOfPaymentComboBox.Name = "TypeOfPaymentComboBox"
        Me.TypeOfPaymentComboBox.Size = New System.Drawing.Size(152, 21)
        Me.TypeOfPaymentComboBox.TabIndex = 23
        '
        'TotalPaidTextBox
        '
        Me.TotalPaidTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblTreasureBindingSource, "TotalPaid", True))
        Me.TotalPaidTextBox.Location = New System.Drawing.Point(490, 218)
        Me.TotalPaidTextBox.Name = "TotalPaidTextBox"
        Me.TotalPaidTextBox.Size = New System.Drawing.Size(72, 20)
        Me.TotalPaidTextBox.TabIndex = 25
        '
        'DateToTreasureDateTimePicker
        '
        Me.DateToTreasureDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.TblTreasureBindingSource, "DateToTreasure", True))
        Me.DateToTreasureDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DateToTreasureDateTimePicker.Location = New System.Drawing.Point(490, 245)
        Me.DateToTreasureDateTimePicker.Name = "DateToTreasureDateTimePicker"
        Me.DateToTreasureDateTimePicker.Size = New System.Drawing.Size(110, 20)
        Me.DateToTreasureDateTimePicker.TabIndex = 27
        Me.DateToTreasureDateTimePicker.Value = New Date(2017, 4, 22, 0, 0, 0, 0)
        '
        'Button5
        '
        Me.Button5.Location = New System.Drawing.Point(172, 277)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(75, 23)
        Me.Button5.TabIndex = 32
        Me.Button5.Text = "ADD"
        Me.Button5.UseVisualStyleBackColor = True
        '
        'Button6
        '
        Me.Button6.Location = New System.Drawing.Point(255, 277)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(75, 23)
        Me.Button6.TabIndex = 33
        Me.Button6.Text = "SAVE"
        Me.Button6.UseVisualStyleBackColor = True
        '
        'Button7
        '
        Me.Button7.Location = New System.Drawing.Point(336, 277)
        Me.Button7.Name = "Button7"
        Me.Button7.Size = New System.Drawing.Size(114, 23)
        Me.Button7.TabIndex = 34
        Me.Button7.Text = "TREASURE FORM"
        Me.Button7.UseVisualStyleBackColor = True
        '
        'Form12
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(652, 303)
        Me.Controls.Add(Me.Button7)
        Me.Controls.Add(Me.Button6)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(TreasureIDLabel)
        Me.Controls.Add(Me.TreasureIDTextBox)
        Me.Controls.Add(DateIDLabel1)
        Me.Controls.Add(Me.DateIDTextBox1)
        Me.Controls.Add(SisterOrBrotherLabel)
        Me.Controls.Add(Me.SisterOrBrotherTextBox)
        Me.Controls.Add(OtherContributorLabel)
        Me.Controls.Add(Me.OtherContributorTextBox)
        Me.Controls.Add(ContributionDescriptionLabel)
        Me.Controls.Add(Me.ContributionDescriptionComboBox)
        Me.Controls.Add(QuantityLabel)
        Me.Controls.Add(Me.QuantityTextBox)
        Me.Controls.Add(RecurrenceDuesLabel)
        Me.Controls.Add(Me.RecurrenceDuesComboBox)
        Me.Controls.Add(PriceOfDonationLabel)
        Me.Controls.Add(Me.PriceOfDonationTextBox)
        Me.Controls.Add(DuesPayedLabel)
        Me.Controls.Add(Me.DuesPayedTextBox)
        Me.Controls.Add(TypeOfPaymentLabel)
        Me.Controls.Add(Me.TypeOfPaymentComboBox)
        Me.Controls.Add(TotalPaidLabel)
        Me.Controls.Add(Me.TotalPaidTextBox)
        Me.Controls.Add(DateToTreasureLabel)
        Me.Controls.Add(Me.DateToTreasureDateTimePicker)
        Me.Controls.Add(DateIDLabel)
        Me.Controls.Add(Me.DateIDTextBox)
        Me.Controls.Add(DateOfMeetingLabel)
        Me.Controls.Add(Me.DateOfMeetingTextBox)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "Form12"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "ADD TREASURE"
        CType(Me.OESDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TblDateBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TblTreasureBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents OESDataSet As OESDataSet
    Friend WithEvents TblDateBindingSource As BindingSource
    Friend WithEvents TblDateTableAdapter As OESDataSetTableAdapters.tblDateTableAdapter
    Friend WithEvents TableAdapterManager As OESDataSetTableAdapters.TableAdapterManager
    Friend WithEvents TblTreasureTableAdapter As OESDataSetTableAdapters.tblTreasureTableAdapter
    Friend WithEvents DateIDTextBox As TextBox
    Friend WithEvents DateOfMeetingTextBox As TextBox
    Friend WithEvents TblTreasureBindingSource As BindingSource
    Friend WithEvents TreasureIDTextBox As TextBox
    Friend WithEvents DateIDTextBox1 As TextBox
    Friend WithEvents SisterOrBrotherTextBox As TextBox
    Friend WithEvents OtherContributorTextBox As TextBox
    Friend WithEvents ContributionDescriptionComboBox As ComboBox
    Friend WithEvents QuantityTextBox As TextBox
    Friend WithEvents RecurrenceDuesComboBox As ComboBox
    Friend WithEvents PriceOfDonationTextBox As TextBox
    Friend WithEvents DuesPayedTextBox As TextBox
    Friend WithEvents TypeOfPaymentComboBox As ComboBox
    Friend WithEvents TotalPaidTextBox As TextBox
    Friend WithEvents DateToTreasureDateTimePicker As DateTimePicker
    Friend WithEvents Button5 As Button
    Friend WithEvents Button6 As Button
    Friend WithEvents Button7 As Button
End Class
