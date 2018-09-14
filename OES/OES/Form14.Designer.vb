<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form14
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
        Dim Label4 As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form14))
        Me.DateIDTextBox = New System.Windows.Forms.TextBox()
        Me.TblDateBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.OESDataSet = New OES.OESDataSet()
        Me.TblOfficerBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TblOfficerDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.Button10 = New System.Windows.Forms.Button()
        Me.Button11 = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.TblDateTableAdapter = New OES.OESDataSetTableAdapters.tblDateTableAdapter()
        Me.TableAdapterManager = New OES.OESDataSetTableAdapters.TableAdapterManager()
        Me.TblOfficerTableAdapter = New OES.OESDataSetTableAdapters.tblOfficerTableAdapter()
        DateIDLabel = New System.Windows.Forms.Label()
        Label4 = New System.Windows.Forms.Label()
        CType(Me.TblDateBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.OESDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TblOfficerBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TblOfficerDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DateIDLabel
        '
        DateIDLabel.AutoSize = True
        DateIDLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DateIDLabel.Location = New System.Drawing.Point(12, 9)
        DateIDLabel.Name = "DateIDLabel"
        DateIDLabel.Size = New System.Drawing.Size(59, 15)
        DateIDLabel.TabIndex = 1
        DateIDLabel.Text = "Date ID:"
        '
        'Label4
        '
        Label4.AutoSize = True
        Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Label4.Location = New System.Drawing.Point(193, 28)
        Label4.Name = "Label4"
        Label4.Size = New System.Drawing.Size(161, 15)
        Label4.TabIndex = 20
        Label4.Text = "Search Date Drop Down"
        '
        'DateIDTextBox
        '
        Me.DateIDTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblDateBindingSource, "DateID", True))
        Me.DateIDTextBox.Location = New System.Drawing.Point(77, 8)
        Me.DateIDTextBox.Name = "DateIDTextBox"
        Me.DateIDTextBox.ReadOnly = True
        Me.DateIDTextBox.Size = New System.Drawing.Size(49, 20)
        Me.DateIDTextBox.TabIndex = 2
        '
        'TblDateBindingSource
        '
        Me.TblDateBindingSource.DataMember = "tblDate"
        Me.TblDateBindingSource.DataSource = Me.OESDataSet
        '
        'OESDataSet
        '
        Me.OESDataSet.DataSetName = "OESDataSet"
        Me.OESDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'TblOfficerBindingSource
        '
        Me.TblOfficerBindingSource.DataMember = "tblDatetblOfficer"
        Me.TblOfficerBindingSource.DataSource = Me.TblDateBindingSource
        '
        'TblOfficerDataGridView
        '
        Me.TblOfficerDataGridView.AutoGenerateColumns = False
        Me.TblOfficerDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.TblOfficerDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5})
        Me.TblOfficerDataGridView.DataSource = Me.TblOfficerBindingSource
        Me.TblOfficerDataGridView.Location = New System.Drawing.Point(12, 91)
        Me.TblOfficerDataGridView.Name = "TblOfficerDataGridView"
        Me.TblOfficerDataGridView.Size = New System.Drawing.Size(624, 220)
        Me.TblOfficerDataGridView.TabIndex = 4
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "Officer"
        Me.DataGridViewTextBoxColumn3.HeaderText = "Officer"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.Width = 190
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "RollCall"
        Me.DataGridViewTextBoxColumn4.HeaderText = "RollCall"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "Notes"
        Me.DataGridViewTextBoxColumn5.HeaderText = "Notes"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        Me.DataGridViewTextBoxColumn5.Width = 290
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(77, 317)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(150, 23)
        Me.Button1.TabIndex = 5
        Me.Button1.Text = "ADD ROLL CALL "
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(233, 317)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(146, 23)
        Me.Button2.TabIndex = 6
        Me.Button2.Text = "EDIT SAVE ROLL CALL"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(385, 317)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(150, 23)
        Me.Button3.TabIndex = 7
        Me.Button3.Text = "DELETE ROLL CALL "
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(236, 367)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(56, 23)
        Me.Button4.TabIndex = 8
        Me.Button4.Text = "<"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(233, 349)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(149, 15)
        Me.Label1.TabIndex = 9
        Me.Label1.Text = "NAVIGATE ROLL CALL"
        '
        'Button5
        '
        Me.Button5.Location = New System.Drawing.Point(322, 368)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(56, 23)
        Me.Button5.TabIndex = 10
        Me.Button5.Text = ">"
        Me.Button5.UseVisualStyleBackColor = True
        '
        'Button10
        '
        Me.Button10.Location = New System.Drawing.Point(524, 22)
        Me.Button10.Name = "Button10"
        Me.Button10.Size = New System.Drawing.Size(112, 23)
        Me.Button10.TabIndex = 15
        Me.Button10.Text = "FORM MENU"
        Me.Button10.UseVisualStyleBackColor = True
        '
        'Button11
        '
        Me.Button11.Location = New System.Drawing.Point(524, 66)
        Me.Button11.Name = "Button11"
        Me.Button11.Size = New System.Drawing.Size(112, 23)
        Me.Button11.TabIndex = 16
        Me.Button11.Text = "MINUTES"
        Me.Button11.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(570, 48)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(27, 15)
        Me.Label2.TabIndex = 17
        Me.Label2.Text = "OR"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(12, 74)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(111, 15)
        Me.Label3.TabIndex = 18
        Me.Label3.Text = "OFFICER TABLE"
        '
        'ComboBox1
        '
        Me.ComboBox1.DataSource = Me.TblDateBindingSource
        Me.ComboBox1.DisplayMember = "DateOfMeeting"
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(217, 48)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(121, 21)
        Me.ComboBox1.TabIndex = 19
        Me.ComboBox1.ValueMember = "DateOfMeeting"
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
        Me.TableAdapterManager.tblOfficerTableAdapter = Me.TblOfficerTableAdapter
        Me.TableAdapterManager.tblTreasureTableAdapter = Nothing
        Me.TableAdapterManager.tblVisitorTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = OES.OESDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'TblOfficerTableAdapter
        '
        Me.TblOfficerTableAdapter.ClearBeforeFill = True
        '
        'Form14
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(639, 393)
        Me.Controls.Add(Label4)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Button11)
        Me.Controls.Add(Me.Button10)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.TblOfficerDataGridView)
        Me.Controls.Add(DateIDLabel)
        Me.Controls.Add(Me.DateIDTextBox)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "Form14"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "OFFICERS ROLL CALL "
        CType(Me.TblDateBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.OESDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TblOfficerBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TblOfficerDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents OESDataSet As OESDataSet
    Friend WithEvents TblDateBindingSource As BindingSource
    Friend WithEvents TblDateTableAdapter As OESDataSetTableAdapters.tblDateTableAdapter
    Friend WithEvents TableAdapterManager As OESDataSetTableAdapters.TableAdapterManager
    Friend WithEvents TblOfficerTableAdapter As OESDataSetTableAdapters.tblOfficerTableAdapter
    Friend WithEvents DateIDTextBox As TextBox
    Friend WithEvents TblOfficerBindingSource As BindingSource
    Friend WithEvents TblOfficerDataGridView As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As DataGridViewTextBoxColumn
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Button5 As Button
    Friend WithEvents Button10 As Button
    Friend WithEvents Button11 As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents ComboBox1 As ComboBox
End Class
