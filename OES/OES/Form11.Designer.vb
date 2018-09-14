<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form11
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form11))
        Me.OESDataSet = New OES.OESDataSet()
        Me.TblDateBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TblDateTableAdapter = New OES.OESDataSetTableAdapters.tblDateTableAdapter()
        Me.TableAdapterManager = New OES.OESDataSetTableAdapters.TableAdapterManager()
        Me.TblTreasureTableAdapter = New OES.OESDataSetTableAdapters.tblTreasureTableAdapter()
        Me.DateIDTextBox = New System.Windows.Forms.TextBox()
        Me.TblTreasureDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn9 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn10 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn11 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn12 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TblTreasureBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DateOfMeetingTextBox = New System.Windows.Forms.TextBox()
        Me.TreasureIDTextBox = New System.Windows.Forms.TextBox()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.Button7 = New System.Windows.Forms.Button()
        Me.Button8 = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Button9 = New System.Windows.Forms.Button()
        Me.Button10 = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Button11 = New System.Windows.Forms.Button()
        Me.Button12 = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        DateIDLabel = New System.Windows.Forms.Label()
        DateOfMeetingLabel = New System.Windows.Forms.Label()
        TreasureIDLabel = New System.Windows.Forms.Label()
        CType(Me.OESDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TblDateBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TblTreasureDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TblTreasureBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DateIDLabel
        '
        DateIDLabel.AutoSize = True
        DateIDLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DateIDLabel.Location = New System.Drawing.Point(12, 9)
        DateIDLabel.Name = "DateIDLabel"
        DateIDLabel.Size = New System.Drawing.Size(59, 15)
        DateIDLabel.TabIndex = 0
        DateIDLabel.Text = "Date ID:"
        '
        'DateOfMeetingLabel
        '
        DateOfMeetingLabel.AutoSize = True
        DateOfMeetingLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DateOfMeetingLabel.Location = New System.Drawing.Point(316, 44)
        DateOfMeetingLabel.Name = "DateOfMeetingLabel"
        DateOfMeetingLabel.Size = New System.Drawing.Size(160, 15)
        DateOfMeetingLabel.TabIndex = 2
        DateOfMeetingLabel.Text = "Search Date Of Meeting"
        '
        'TreasureIDLabel
        '
        TreasureIDLabel.AutoSize = True
        TreasureIDLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        TreasureIDLabel.Location = New System.Drawing.Point(127, 11)
        TreasureIDLabel.Name = "TreasureIDLabel"
        TreasureIDLabel.Size = New System.Drawing.Size(86, 15)
        TreasureIDLabel.TabIndex = 5
        TreasureIDLabel.Text = "Treasure ID:"
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
        Me.DateIDTextBox.Location = New System.Drawing.Point(77, 8)
        Me.DateIDTextBox.Name = "DateIDTextBox"
        Me.DateIDTextBox.ReadOnly = True
        Me.DateIDTextBox.Size = New System.Drawing.Size(38, 20)
        Me.DateIDTextBox.TabIndex = 1
        '
        'TblTreasureDataGridView
        '
        Me.TblTreasureDataGridView.AutoGenerateColumns = False
        Me.TblTreasureDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.TblTreasureDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn6, Me.DataGridViewTextBoxColumn7, Me.DataGridViewTextBoxColumn8, Me.DataGridViewTextBoxColumn9, Me.DataGridViewTextBoxColumn10, Me.DataGridViewTextBoxColumn11, Me.DataGridViewTextBoxColumn12})
        Me.TblTreasureDataGridView.DataSource = Me.TblTreasureBindingSource
        Me.TblTreasureDataGridView.Location = New System.Drawing.Point(1, 88)
        Me.TblTreasureDataGridView.Name = "TblTreasureDataGridView"
        Me.TblTreasureDataGridView.Size = New System.Drawing.Size(823, 220)
        Me.TblTreasureDataGridView.TabIndex = 4
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "SisterOrBrother"
        Me.DataGridViewTextBoxColumn3.HeaderText = "SisterOrBrother"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.Width = 190
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "OtherContributor"
        Me.DataGridViewTextBoxColumn4.HeaderText = "OtherContributor"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.Width = 190
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "ContributionDescription"
        Me.DataGridViewTextBoxColumn5.HeaderText = "ContributionDescription"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        Me.DataGridViewTextBoxColumn5.Width = 120
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "Quantity"
        Me.DataGridViewTextBoxColumn6.HeaderText = "Quantity"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        Me.DataGridViewTextBoxColumn6.Width = 80
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.DataPropertyName = "RecurrenceDues"
        Me.DataGridViewTextBoxColumn7.HeaderText = "RecurrenceDues"
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        '
        'DataGridViewTextBoxColumn8
        '
        Me.DataGridViewTextBoxColumn8.DataPropertyName = "PriceOfDonation"
        Me.DataGridViewTextBoxColumn8.HeaderText = "PriceOfDonation"
        Me.DataGridViewTextBoxColumn8.Name = "DataGridViewTextBoxColumn8"
        '
        'DataGridViewTextBoxColumn9
        '
        Me.DataGridViewTextBoxColumn9.DataPropertyName = "DuesPayed"
        Me.DataGridViewTextBoxColumn9.HeaderText = "DuesPayed"
        Me.DataGridViewTextBoxColumn9.Name = "DataGridViewTextBoxColumn9"
        Me.DataGridViewTextBoxColumn9.Width = 90
        '
        'DataGridViewTextBoxColumn10
        '
        Me.DataGridViewTextBoxColumn10.DataPropertyName = "TypeOfPayment"
        Me.DataGridViewTextBoxColumn10.HeaderText = "TypeOfPayment"
        Me.DataGridViewTextBoxColumn10.Name = "DataGridViewTextBoxColumn10"
        '
        'DataGridViewTextBoxColumn11
        '
        Me.DataGridViewTextBoxColumn11.DataPropertyName = "TotalPaid"
        Me.DataGridViewTextBoxColumn11.HeaderText = "TotalPaid"
        Me.DataGridViewTextBoxColumn11.Name = "DataGridViewTextBoxColumn11"
        Me.DataGridViewTextBoxColumn11.Width = 90
        '
        'DataGridViewTextBoxColumn12
        '
        Me.DataGridViewTextBoxColumn12.DataPropertyName = "DateToTreasure"
        Me.DataGridViewTextBoxColumn12.HeaderText = "DateToTreasure"
        Me.DataGridViewTextBoxColumn12.Name = "DataGridViewTextBoxColumn12"
        Me.DataGridViewTextBoxColumn12.Width = 120
        '
        'TblTreasureBindingSource
        '
        Me.TblTreasureBindingSource.DataMember = "tblDatetblTreasure"
        Me.TblTreasureBindingSource.DataSource = Me.TblDateBindingSource
        '
        'DateOfMeetingTextBox
        '
        Me.DateOfMeetingTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblDateBindingSource, "DateOfMeeting", True))
        Me.DateOfMeetingTextBox.Location = New System.Drawing.Point(332, 62)
        Me.DateOfMeetingTextBox.Name = "DateOfMeetingTextBox"
        Me.DateOfMeetingTextBox.ReadOnly = True
        Me.DateOfMeetingTextBox.Size = New System.Drawing.Size(125, 20)
        Me.DateOfMeetingTextBox.TabIndex = 5
        '
        'TreasureIDTextBox
        '
        Me.TreasureIDTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblTreasureBindingSource, "TreasureID", True))
        Me.TreasureIDTextBox.Location = New System.Drawing.Point(219, 8)
        Me.TreasureIDTextBox.Name = "TreasureIDTextBox"
        Me.TreasureIDTextBox.ReadOnly = True
        Me.TreasureIDTextBox.Size = New System.Drawing.Size(38, 20)
        Me.TreasureIDTextBox.TabIndex = 6
        '
        'Button5
        '
        Me.Button5.Location = New System.Drawing.Point(1, 314)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(126, 23)
        Me.Button5.TabIndex = 13
        Me.Button5.Text = "ADD TREASURE"
        Me.Button5.UseVisualStyleBackColor = True
        '
        'Button6
        '
        Me.Button6.Location = New System.Drawing.Point(131, 314)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(126, 23)
        Me.Button6.TabIndex = 14
        Me.Button6.Text = "EDIT AND SAVE"
        Me.Button6.UseVisualStyleBackColor = True
        '
        'Button7
        '
        Me.Button7.Location = New System.Drawing.Point(410, 334)
        Me.Button7.Name = "Button7"
        Me.Button7.Size = New System.Drawing.Size(66, 23)
        Me.Button7.TabIndex = 15
        Me.Button7.Text = "<"
        Me.Button7.UseVisualStyleBackColor = True
        '
        'Button8
        '
        Me.Button8.Location = New System.Drawing.Point(505, 334)
        Me.Button8.Name = "Button8"
        Me.Button8.Size = New System.Drawing.Size(66, 23)
        Me.Button8.TabIndex = 16
        Me.Button8.Text = ">"
        Me.Button8.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(407, 316)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(164, 15)
        Me.Label1.TabIndex = 17
        Me.Label1.Text = "TREASURE NAVIGATION"
        '
        'Button9
        '
        Me.Button9.Location = New System.Drawing.Point(698, 17)
        Me.Button9.Name = "Button9"
        Me.Button9.Size = New System.Drawing.Size(126, 23)
        Me.Button9.TabIndex = 18
        Me.Button9.Text = "FORMS MENU"
        Me.Button9.UseVisualStyleBackColor = True
        '
        'Button10
        '
        Me.Button10.Location = New System.Drawing.Point(698, 61)
        Me.Button10.Name = "Button10"
        Me.Button10.Size = New System.Drawing.Size(126, 23)
        Me.Button10.TabIndex = 19
        Me.Button10.Text = "MINUTES"
        Me.Button10.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(752, 43)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(27, 15)
        Me.Label2.TabIndex = 20
        Me.Label2.Text = "OR"
        '
        'Button11
        '
        Me.Button11.Location = New System.Drawing.Point(263, 314)
        Me.Button11.Name = "Button11"
        Me.Button11.Size = New System.Drawing.Size(125, 23)
        Me.Button11.TabIndex = 21
        Me.Button11.Text = "DELETE TREASURE"
        Me.Button11.UseVisualStyleBackColor = True
        '
        'Button12
        '
        Me.Button12.Location = New System.Drawing.Point(646, 334)
        Me.Button12.Name = "Button12"
        Me.Button12.Size = New System.Drawing.Size(178, 23)
        Me.Button12.TabIndex = 22
        Me.Button12.Text = "PRINT TREASURE REPORT"
        Me.Button12.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(673, 314)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(88, 15)
        Me.Label3.TabIndex = 23
        Me.Label3.Text = "TOTAL PAID:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(763, 316)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(0, 13)
        Me.Label4.TabIndex = 24
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(1, 70)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(126, 15)
        Me.Label5.TabIndex = 25
        Me.Label5.Text = "TREASURE TABLE"
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(458, 61)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(30, 22)
        Me.Button3.TabIndex = 11
        Me.Button3.Text = ">"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(488, 61)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(30, 22)
        Me.Button4.TabIndex = 12
        Me.Button4.Text = ">>"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(271, 61)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(30, 21)
        Me.Button1.TabIndex = 9
        Me.Button1.Text = "<<"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(301, 61)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(30, 21)
        Me.Button2.TabIndex = 10
        Me.Button2.Text = "<"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Form11
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(825, 360)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Button12)
        Me.Controls.Add(Me.Button11)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Button10)
        Me.Controls.Add(Me.Button9)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Button8)
        Me.Controls.Add(Me.Button7)
        Me.Controls.Add(Me.Button6)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(TreasureIDLabel)
        Me.Controls.Add(Me.TreasureIDTextBox)
        Me.Controls.Add(Me.DateOfMeetingTextBox)
        Me.Controls.Add(Me.TblTreasureDataGridView)
        Me.Controls.Add(DateIDLabel)
        Me.Controls.Add(Me.DateIDTextBox)
        Me.Controls.Add(DateOfMeetingLabel)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "Form11"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "TREASURE"
        CType(Me.OESDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TblDateBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TblTreasureDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents TblTreasureBindingSource As BindingSource
    Friend WithEvents TblTreasureDataGridView As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn7 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn8 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn9 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn10 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn11 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn12 As DataGridViewTextBoxColumn
    Friend WithEvents DateOfMeetingTextBox As TextBox
    Friend WithEvents TreasureIDTextBox As TextBox
    Friend WithEvents Button5 As Button
    Friend WithEvents Button6 As Button
    Friend WithEvents Button7 As Button
    Friend WithEvents Button8 As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Button9 As Button
    Friend WithEvents Button10 As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents Button11 As Button
    Friend WithEvents Button12 As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Button3 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
End Class
