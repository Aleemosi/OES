<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form15
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
        Dim OfficerIDLabel As System.Windows.Forms.Label
        Dim DateIDLabel As System.Windows.Forms.Label
        Dim OfficerLabel As System.Windows.Forms.Label
        Dim RollCallLabel As System.Windows.Forms.Label
        Dim NotesLabel As System.Windows.Forms.Label
        Dim DateIDLabel1 As System.Windows.Forms.Label
        Dim DateOfMeetingLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form15))
        Me.OESDataSet = New OES.OESDataSet()
        Me.TblOfficerBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TblOfficerTableAdapter = New OES.OESDataSetTableAdapters.tblOfficerTableAdapter()
        Me.TableAdapterManager = New OES.OESDataSetTableAdapters.TableAdapterManager()
        Me.TblDateTableAdapter = New OES.OESDataSetTableAdapters.tblDateTableAdapter()
        Me.OfficerIDTextBox = New System.Windows.Forms.TextBox()
        Me.DateIDTextBox = New System.Windows.Forms.TextBox()
        Me.OfficerTextBox = New System.Windows.Forms.TextBox()
        Me.RollCallComboBox = New System.Windows.Forms.ComboBox()
        Me.NotesTextBox = New System.Windows.Forms.TextBox()
        Me.TblDateBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DateIDTextBox1 = New System.Windows.Forms.TextBox()
        Me.DateOfMeetingTextBox = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        OfficerIDLabel = New System.Windows.Forms.Label()
        DateIDLabel = New System.Windows.Forms.Label()
        OfficerLabel = New System.Windows.Forms.Label()
        RollCallLabel = New System.Windows.Forms.Label()
        NotesLabel = New System.Windows.Forms.Label()
        DateIDLabel1 = New System.Windows.Forms.Label()
        DateOfMeetingLabel = New System.Windows.Forms.Label()
        CType(Me.OESDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TblOfficerBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TblDateBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'OfficerIDLabel
        '
        OfficerIDLabel.AutoSize = True
        OfficerIDLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        OfficerIDLabel.Location = New System.Drawing.Point(12, 9)
        OfficerIDLabel.Name = "OfficerIDLabel"
        OfficerIDLabel.Size = New System.Drawing.Size(71, 15)
        OfficerIDLabel.TabIndex = 1
        OfficerIDLabel.Text = "Officer ID:"
        '
        'DateIDLabel
        '
        DateIDLabel.AutoSize = True
        DateIDLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DateIDLabel.Location = New System.Drawing.Point(157, 9)
        DateIDLabel.Name = "DateIDLabel"
        DateIDLabel.Size = New System.Drawing.Size(59, 15)
        DateIDLabel.TabIndex = 3
        DateIDLabel.Text = "Date ID:"
        '
        'OfficerLabel
        '
        OfficerLabel.AutoSize = True
        OfficerLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        OfficerLabel.Location = New System.Drawing.Point(25, 90)
        OfficerLabel.Name = "OfficerLabel"
        OfficerLabel.Size = New System.Drawing.Size(53, 15)
        OfficerLabel.TabIndex = 5
        OfficerLabel.Text = "Officer:"
        '
        'RollCallLabel
        '
        RollCallLabel.AutoSize = True
        RollCallLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        RollCallLabel.Location = New System.Drawing.Point(12, 117)
        RollCallLabel.Name = "RollCallLabel"
        RollCallLabel.Size = New System.Drawing.Size(66, 15)
        RollCallLabel.TabIndex = 7
        RollCallLabel.Text = "Roll Call:"
        '
        'NotesLabel
        '
        NotesLabel.AutoSize = True
        NotesLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        NotesLabel.Location = New System.Drawing.Point(30, 145)
        NotesLabel.Name = "NotesLabel"
        NotesLabel.Size = New System.Drawing.Size(48, 15)
        NotesLabel.TabIndex = 9
        NotesLabel.Text = "Notes:"
        '
        'DateIDLabel1
        '
        DateIDLabel1.AutoSize = True
        DateIDLabel1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DateIDLabel1.Location = New System.Drawing.Point(290, 9)
        DateIDLabel1.Name = "DateIDLabel1"
        DateIDLabel1.Size = New System.Drawing.Size(59, 15)
        DateIDLabel1.TabIndex = 10
        DateIDLabel1.Text = "Date ID:"
        '
        'DateOfMeetingLabel
        '
        DateOfMeetingLabel.AutoSize = True
        DateOfMeetingLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DateOfMeetingLabel.Location = New System.Drawing.Point(165, 45)
        DateOfMeetingLabel.Name = "DateOfMeetingLabel"
        DateOfMeetingLabel.Size = New System.Drawing.Size(111, 15)
        DateOfMeetingLabel.TabIndex = 12
        DateOfMeetingLabel.Text = "Date Of Meeting"
        '
        'OESDataSet
        '
        Me.OESDataSet.DataSetName = "OESDataSet"
        Me.OESDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'TblOfficerBindingSource
        '
        Me.TblOfficerBindingSource.DataMember = "tblOfficer"
        Me.TblOfficerBindingSource.DataSource = Me.OESDataSet
        '
        'TblOfficerTableAdapter
        '
        Me.TblOfficerTableAdapter.ClearBeforeFill = True
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
        'TblDateTableAdapter
        '
        Me.TblDateTableAdapter.ClearBeforeFill = True
        '
        'OfficerIDTextBox
        '
        Me.OfficerIDTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblOfficerBindingSource, "OfficerID", True))
        Me.OfficerIDTextBox.Location = New System.Drawing.Point(89, 8)
        Me.OfficerIDTextBox.Name = "OfficerIDTextBox"
        Me.OfficerIDTextBox.ReadOnly = True
        Me.OfficerIDTextBox.Size = New System.Drawing.Size(45, 20)
        Me.OfficerIDTextBox.TabIndex = 2
        '
        'DateIDTextBox
        '
        Me.DateIDTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblOfficerBindingSource, "DateID", True))
        Me.DateIDTextBox.Location = New System.Drawing.Point(222, 8)
        Me.DateIDTextBox.Name = "DateIDTextBox"
        Me.DateIDTextBox.ReadOnly = True
        Me.DateIDTextBox.Size = New System.Drawing.Size(45, 20)
        Me.DateIDTextBox.TabIndex = 4
        '
        'OfficerTextBox
        '
        Me.OfficerTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblOfficerBindingSource, "Officer", True))
        Me.OfficerTextBox.Location = New System.Drawing.Point(84, 89)
        Me.OfficerTextBox.Name = "OfficerTextBox"
        Me.OfficerTextBox.Size = New System.Drawing.Size(183, 20)
        Me.OfficerTextBox.TabIndex = 6
        '
        'RollCallComboBox
        '
        Me.RollCallComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblOfficerBindingSource, "RollCall", True))
        Me.RollCallComboBox.FormattingEnabled = True
        Me.RollCallComboBox.Items.AddRange(New Object() {"Present", "Excuse", "Abcent"})
        Me.RollCallComboBox.Location = New System.Drawing.Point(84, 116)
        Me.RollCallComboBox.Name = "RollCallComboBox"
        Me.RollCallComboBox.Size = New System.Drawing.Size(121, 21)
        Me.RollCallComboBox.TabIndex = 8
        '
        'NotesTextBox
        '
        Me.NotesTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblOfficerBindingSource, "Notes", True))
        Me.NotesTextBox.Location = New System.Drawing.Point(84, 144)
        Me.NotesTextBox.Name = "NotesTextBox"
        Me.NotesTextBox.Size = New System.Drawing.Size(413, 20)
        Me.NotesTextBox.TabIndex = 10
        '
        'TblDateBindingSource
        '
        Me.TblDateBindingSource.DataMember = "tblDate"
        Me.TblDateBindingSource.DataSource = Me.OESDataSet
        '
        'DateIDTextBox1
        '
        Me.DateIDTextBox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblDateBindingSource, "DateID", True))
        Me.DateIDTextBox1.Location = New System.Drawing.Point(355, 8)
        Me.DateIDTextBox1.Name = "DateIDTextBox1"
        Me.DateIDTextBox1.ReadOnly = True
        Me.DateIDTextBox1.Size = New System.Drawing.Size(45, 20)
        Me.DateIDTextBox1.TabIndex = 11
        '
        'DateOfMeetingTextBox
        '
        Me.DateOfMeetingTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblDateBindingSource, "DateOfMeeting", True))
        Me.DateOfMeetingTextBox.Location = New System.Drawing.Point(150, 63)
        Me.DateOfMeetingTextBox.Name = "DateOfMeetingTextBox"
        Me.DateOfMeetingTextBox.ReadOnly = True
        Me.DateOfMeetingTextBox.Size = New System.Drawing.Size(132, 20)
        Me.DateOfMeetingTextBox.TabIndex = 13
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(120, 170)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 14
        Me.Button1.Text = "ADD"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(201, 170)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 23)
        Me.Button2.TabIndex = 15
        Me.Button2.Text = "SAVE"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(282, 170)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(118, 23)
        Me.Button3.TabIndex = 16
        Me.Button3.Text = "ROLL CALL FORM"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Form15
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(501, 197)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(DateIDLabel1)
        Me.Controls.Add(Me.DateIDTextBox1)
        Me.Controls.Add(DateOfMeetingLabel)
        Me.Controls.Add(Me.DateOfMeetingTextBox)
        Me.Controls.Add(OfficerIDLabel)
        Me.Controls.Add(Me.OfficerIDTextBox)
        Me.Controls.Add(DateIDLabel)
        Me.Controls.Add(Me.DateIDTextBox)
        Me.Controls.Add(OfficerLabel)
        Me.Controls.Add(Me.OfficerTextBox)
        Me.Controls.Add(RollCallLabel)
        Me.Controls.Add(Me.RollCallComboBox)
        Me.Controls.Add(NotesLabel)
        Me.Controls.Add(Me.NotesTextBox)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "Form15"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "ADD ROLL CALL OF OFFICERS"
        CType(Me.OESDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TblOfficerBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TblDateBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents OESDataSet As OESDataSet
    Friend WithEvents TblOfficerBindingSource As BindingSource
    Friend WithEvents TblOfficerTableAdapter As OESDataSetTableAdapters.tblOfficerTableAdapter
    Friend WithEvents TableAdapterManager As OESDataSetTableAdapters.TableAdapterManager
    Friend WithEvents TblDateTableAdapter As OESDataSetTableAdapters.tblDateTableAdapter
    Friend WithEvents OfficerIDTextBox As TextBox
    Friend WithEvents DateIDTextBox As TextBox
    Friend WithEvents OfficerTextBox As TextBox
    Friend WithEvents RollCallComboBox As ComboBox
    Friend WithEvents NotesTextBox As TextBox
    Friend WithEvents TblDateBindingSource As BindingSource
    Friend WithEvents DateIDTextBox1 As TextBox
    Friend WithEvents DateOfMeetingTextBox As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
End Class
