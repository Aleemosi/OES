<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form17
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
        Dim DateIDLabel As System.Windows.Forms.Label
        Dim VisitorIDLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form17))
        Me.OESDataSet = New OES.OESDataSet()
        Me.TblDateBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TblDateTableAdapter = New OES.OESDataSetTableAdapters.tblDateTableAdapter()
        Me.TableAdapterManager = New OES.OESDataSetTableAdapters.TableAdapterManager()
        Me.TblVisitorTableAdapter = New OES.OESDataSetTableAdapters.tblVisitorTableAdapter()
        Me.DateIDTextBox = New System.Windows.Forms.TextBox()
        Me.TblVisitorDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TblVisitorBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.VisitorIDTextBox = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.Button11 = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Button12 = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        DateIDLabel = New System.Windows.Forms.Label()
        VisitorIDLabel = New System.Windows.Forms.Label()
        CType(Me.OESDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TblDateBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TblVisitorDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TblVisitorBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DateIDLabel
        '
        DateIDLabel.AutoSize = True
        DateIDLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DateIDLabel.Location = New System.Drawing.Point(3, 9)
        DateIDLabel.Name = "DateIDLabel"
        DateIDLabel.Size = New System.Drawing.Size(59, 15)
        DateIDLabel.TabIndex = 1
        DateIDLabel.Text = "Date ID:"
        '
        'VisitorIDLabel
        '
        VisitorIDLabel.AutoSize = True
        VisitorIDLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        VisitorIDLabel.Location = New System.Drawing.Point(141, 9)
        VisitorIDLabel.Name = "VisitorIDLabel"
        VisitorIDLabel.Size = New System.Drawing.Size(69, 15)
        VisitorIDLabel.TabIndex = 5
        VisitorIDLabel.Text = "Visitor ID:"
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
        Me.TableAdapterManager.tblTreasureTableAdapter = Nothing
        Me.TableAdapterManager.tblVisitorTableAdapter = Me.TblVisitorTableAdapter
        Me.TableAdapterManager.UpdateOrder = OES.OESDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'TblVisitorTableAdapter
        '
        Me.TblVisitorTableAdapter.ClearBeforeFill = True
        '
        'DateIDTextBox
        '
        Me.DateIDTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblDateBindingSource, "DateID", True))
        Me.DateIDTextBox.Location = New System.Drawing.Point(66, 8)
        Me.DateIDTextBox.Name = "DateIDTextBox"
        Me.DateIDTextBox.ReadOnly = True
        Me.DateIDTextBox.Size = New System.Drawing.Size(42, 20)
        Me.DateIDTextBox.TabIndex = 2
        '
        'TblVisitorDataGridView
        '
        Me.TblVisitorDataGridView.AutoGenerateColumns = False
        Me.TblVisitorDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.TblVisitorDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn6})
        Me.TblVisitorDataGridView.DataSource = Me.TblVisitorBindingSource
        Me.TblVisitorDataGridView.Location = New System.Drawing.Point(6, 86)
        Me.TblVisitorDataGridView.Name = "TblVisitorDataGridView"
        Me.TblVisitorDataGridView.Size = New System.Drawing.Size(816, 220)
        Me.TblVisitorDataGridView.TabIndex = 4
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "VisitorName"
        Me.DataGridViewTextBoxColumn3.HeaderText = "VisitorName"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.Width = 190
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "Chapter"
        Me.DataGridViewTextBoxColumn4.HeaderText = "Chapter"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.Width = 190
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "MasonicLodge"
        Me.DataGridViewTextBoxColumn5.HeaderText = "MasonicLodge"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        Me.DataGridViewTextBoxColumn5.Width = 190
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "Note"
        Me.DataGridViewTextBoxColumn6.HeaderText = "Note"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        Me.DataGridViewTextBoxColumn6.Width = 200
        '
        'TblVisitorBindingSource
        '
        Me.TblVisitorBindingSource.DataMember = "tblDatetblVisitor"
        Me.TblVisitorBindingSource.DataSource = Me.TblDateBindingSource
        '
        'VisitorIDTextBox
        '
        Me.VisitorIDTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblVisitorBindingSource, "VisitorID", True))
        Me.VisitorIDTextBox.Location = New System.Drawing.Point(216, 8)
        Me.VisitorIDTextBox.Name = "VisitorIDTextBox"
        Me.VisitorIDTextBox.ReadOnly = True
        Me.VisitorIDTextBox.Size = New System.Drawing.Size(42, 20)
        Me.VisitorIDTextBox.TabIndex = 6
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(6, 313)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(111, 23)
        Me.Button1.TabIndex = 7
        Me.Button1.Text = "ADD VISITORS"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(123, 313)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(111, 23)
        Me.Button2.TabIndex = 8
        Me.Button2.Text = "EDIT AND SAVE"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(240, 313)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(111, 23)
        Me.Button3.TabIndex = 9
        Me.Button3.Text = "DELETE VISITOR"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(370, 316)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(138, 15)
        Me.Label1.TabIndex = 10
        Me.Label1.Text = "NAVIGATE VISITORS"
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(373, 335)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(52, 23)
        Me.Button4.TabIndex = 11
        Me.Button4.Text = "<"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Button5
        '
        Me.Button5.Location = New System.Drawing.Point(456, 335)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(52, 23)
        Me.Button5.TabIndex = 12
        Me.Button5.Text = ">"
        Me.Button5.UseVisualStyleBackColor = True
        '
        'Button6
        '
        Me.Button6.Location = New System.Drawing.Point(667, 313)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(155, 23)
        Me.Button6.TabIndex = 13
        Me.Button6.Text = "PRINT VISITOR REPORT"
        Me.Button6.UseVisualStyleBackColor = True
        '
        'Button11
        '
        Me.Button11.Location = New System.Drawing.Point(718, 12)
        Me.Button11.Name = "Button11"
        Me.Button11.Size = New System.Drawing.Size(104, 23)
        Me.Button11.TabIndex = 18
        Me.Button11.Text = "FORMS MENU"
        Me.Button11.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(762, 38)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(27, 15)
        Me.Label2.TabIndex = 19
        Me.Label2.Text = "OR"
        '
        'Button12
        '
        Me.Button12.Location = New System.Drawing.Point(718, 60)
        Me.Button12.Name = "Button12"
        Me.Button12.Size = New System.Drawing.Size(104, 23)
        Me.Button12.TabIndex = 20
        Me.Button12.Text = "MINUTES"
        Me.Button12.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(6, 69)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(115, 15)
        Me.Label3.TabIndex = 21
        Me.Label3.Text = "VISITORS TABLE"
        '
        'ComboBox1
        '
        Me.ComboBox1.DataSource = Me.TblDateBindingSource
        Me.ComboBox1.DisplayMember = "DateOfMeeting"
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(304, 59)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(121, 21)
        Me.ComboBox1.TabIndex = 22
        Me.ComboBox1.ValueMember = "DateOfMeeting"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(282, 43)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(167, 13)
        Me.Label4.TabIndex = 23
        Me.Label4.Text = "Date Of Meeting Drop Down"
        '
        'Form17
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(824, 359)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Button12)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Button11)
        Me.Controls.Add(Me.Button6)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(VisitorIDLabel)
        Me.Controls.Add(Me.VisitorIDTextBox)
        Me.Controls.Add(Me.TblVisitorDataGridView)
        Me.Controls.Add(DateIDLabel)
        Me.Controls.Add(Me.DateIDTextBox)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "Form17"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "VISITORS"
        CType(Me.OESDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TblDateBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TblVisitorDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TblVisitorBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents OESDataSet As OESDataSet
    Friend WithEvents TblDateBindingSource As BindingSource
    Friend WithEvents TblDateTableAdapter As OESDataSetTableAdapters.tblDateTableAdapter
    Friend WithEvents TableAdapterManager As OESDataSetTableAdapters.TableAdapterManager
    Friend WithEvents DateIDTextBox As TextBox
    Friend WithEvents TblVisitorTableAdapter As OESDataSetTableAdapters.tblVisitorTableAdapter
    Friend WithEvents TblVisitorBindingSource As BindingSource
    Friend WithEvents TblVisitorDataGridView As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As DataGridViewTextBoxColumn
    Friend WithEvents VisitorIDTextBox As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Button4 As Button
    Friend WithEvents Button5 As Button
    Friend WithEvents Button6 As Button
    Friend WithEvents Button11 As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents Button12 As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents Label4 As Label
End Class
