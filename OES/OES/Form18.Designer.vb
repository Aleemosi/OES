<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form18
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
        Dim VisitorIDLabel As System.Windows.Forms.Label
        Dim DateIDLabel As System.Windows.Forms.Label
        Dim VisitorNameLabel As System.Windows.Forms.Label
        Dim ChapterLabel As System.Windows.Forms.Label
        Dim MasonicLodgeLabel As System.Windows.Forms.Label
        Dim NoteLabel As System.Windows.Forms.Label
        Dim DateIDLabel1 As System.Windows.Forms.Label
        Dim DateOfMeetingLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form18))
        Me.OESDataSet = New OES.OESDataSet()
        Me.TblVisitorBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TblVisitorTableAdapter = New OES.OESDataSetTableAdapters.tblVisitorTableAdapter()
        Me.TableAdapterManager = New OES.OESDataSetTableAdapters.TableAdapterManager()
        Me.TblDateTableAdapter = New OES.OESDataSetTableAdapters.tblDateTableAdapter()
        Me.VisitorIDTextBox = New System.Windows.Forms.TextBox()
        Me.DateIDTextBox = New System.Windows.Forms.TextBox()
        Me.VisitorNameTextBox = New System.Windows.Forms.TextBox()
        Me.ChapterTextBox = New System.Windows.Forms.TextBox()
        Me.MasonicLodgeTextBox = New System.Windows.Forms.TextBox()
        Me.NoteTextBox = New System.Windows.Forms.TextBox()
        Me.TblDateBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DateIDTextBox1 = New System.Windows.Forms.TextBox()
        Me.DateOfMeetingTextBox = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        VisitorIDLabel = New System.Windows.Forms.Label()
        DateIDLabel = New System.Windows.Forms.Label()
        VisitorNameLabel = New System.Windows.Forms.Label()
        ChapterLabel = New System.Windows.Forms.Label()
        MasonicLodgeLabel = New System.Windows.Forms.Label()
        NoteLabel = New System.Windows.Forms.Label()
        DateIDLabel1 = New System.Windows.Forms.Label()
        DateOfMeetingLabel = New System.Windows.Forms.Label()
        CType(Me.OESDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TblVisitorBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TblDateBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'VisitorIDLabel
        '
        VisitorIDLabel.AutoSize = True
        VisitorIDLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        VisitorIDLabel.Location = New System.Drawing.Point(12, 9)
        VisitorIDLabel.Name = "VisitorIDLabel"
        VisitorIDLabel.Size = New System.Drawing.Size(69, 15)
        VisitorIDLabel.TabIndex = 1
        VisitorIDLabel.Text = "Visitor ID:"
        '
        'DateIDLabel
        '
        DateIDLabel.AutoSize = True
        DateIDLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DateIDLabel.Location = New System.Drawing.Point(163, 9)
        DateIDLabel.Name = "DateIDLabel"
        DateIDLabel.Size = New System.Drawing.Size(59, 15)
        DateIDLabel.TabIndex = 3
        DateIDLabel.Text = "Date ID:"
        '
        'VisitorNameLabel
        '
        VisitorNameLabel.AutoSize = True
        VisitorNameLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        VisitorNameLabel.Location = New System.Drawing.Point(18, 86)
        VisitorNameLabel.Name = "VisitorNameLabel"
        VisitorNameLabel.Size = New System.Drawing.Size(93, 15)
        VisitorNameLabel.TabIndex = 5
        VisitorNameLabel.Text = "Visitor Name:"
        '
        'ChapterLabel
        '
        ChapterLabel.AutoSize = True
        ChapterLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        ChapterLabel.Location = New System.Drawing.Point(50, 115)
        ChapterLabel.Name = "ChapterLabel"
        ChapterLabel.Size = New System.Drawing.Size(61, 15)
        ChapterLabel.TabIndex = 7
        ChapterLabel.Text = "Chapter:"
        '
        'MasonicLodgeLabel
        '
        MasonicLodgeLabel.AutoSize = True
        MasonicLodgeLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        MasonicLodgeLabel.Location = New System.Drawing.Point(2, 145)
        MasonicLodgeLabel.Name = "MasonicLodgeLabel"
        MasonicLodgeLabel.Size = New System.Drawing.Size(109, 15)
        MasonicLodgeLabel.TabIndex = 9
        MasonicLodgeLabel.Text = "Masonic Lodge:"
        '
        'NoteLabel
        '
        NoteLabel.AutoSize = True
        NoteLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        NoteLabel.Location = New System.Drawing.Point(70, 173)
        NoteLabel.Name = "NoteLabel"
        NoteLabel.Size = New System.Drawing.Size(41, 15)
        NoteLabel.TabIndex = 11
        NoteLabel.Text = "Note:"
        '
        'DateIDLabel1
        '
        DateIDLabel1.AutoSize = True
        DateIDLabel1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DateIDLabel1.Location = New System.Drawing.Point(306, 9)
        DateIDLabel1.Name = "DateIDLabel1"
        DateIDLabel1.Size = New System.Drawing.Size(59, 15)
        DateIDLabel1.TabIndex = 12
        DateIDLabel1.Text = "Date ID:"
        '
        'DateOfMeetingLabel
        '
        DateOfMeetingLabel.AutoSize = True
        DateOfMeetingLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DateOfMeetingLabel.Location = New System.Drawing.Point(195, 41)
        DateOfMeetingLabel.Name = "DateOfMeetingLabel"
        DateOfMeetingLabel.Size = New System.Drawing.Size(111, 15)
        DateOfMeetingLabel.TabIndex = 14
        DateOfMeetingLabel.Text = "Date Of Meeting"
        '
        'OESDataSet
        '
        Me.OESDataSet.DataSetName = "OESDataSet"
        Me.OESDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'TblVisitorBindingSource
        '
        Me.TblVisitorBindingSource.DataMember = "tblVisitor"
        Me.TblVisitorBindingSource.DataSource = Me.OESDataSet
        '
        'TblVisitorTableAdapter
        '
        Me.TblVisitorTableAdapter.ClearBeforeFill = True
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
        'TblDateTableAdapter
        '
        Me.TblDateTableAdapter.ClearBeforeFill = True
        '
        'VisitorIDTextBox
        '
        Me.VisitorIDTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblVisitorBindingSource, "VisitorID", True))
        Me.VisitorIDTextBox.Location = New System.Drawing.Point(87, 8)
        Me.VisitorIDTextBox.Name = "VisitorIDTextBox"
        Me.VisitorIDTextBox.ReadOnly = True
        Me.VisitorIDTextBox.Size = New System.Drawing.Size(53, 20)
        Me.VisitorIDTextBox.TabIndex = 2
        '
        'DateIDTextBox
        '
        Me.DateIDTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblVisitorBindingSource, "DateID", True))
        Me.DateIDTextBox.Location = New System.Drawing.Point(228, 8)
        Me.DateIDTextBox.Name = "DateIDTextBox"
        Me.DateIDTextBox.ReadOnly = True
        Me.DateIDTextBox.Size = New System.Drawing.Size(53, 20)
        Me.DateIDTextBox.TabIndex = 4
        '
        'VisitorNameTextBox
        '
        Me.VisitorNameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblVisitorBindingSource, "VisitorName", True))
        Me.VisitorNameTextBox.Location = New System.Drawing.Point(117, 85)
        Me.VisitorNameTextBox.Name = "VisitorNameTextBox"
        Me.VisitorNameTextBox.Size = New System.Drawing.Size(207, 20)
        Me.VisitorNameTextBox.TabIndex = 6
        '
        'ChapterTextBox
        '
        Me.ChapterTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblVisitorBindingSource, "Chapter", True))
        Me.ChapterTextBox.Location = New System.Drawing.Point(117, 114)
        Me.ChapterTextBox.Name = "ChapterTextBox"
        Me.ChapterTextBox.Size = New System.Drawing.Size(238, 20)
        Me.ChapterTextBox.TabIndex = 8
        '
        'MasonicLodgeTextBox
        '
        Me.MasonicLodgeTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblVisitorBindingSource, "MasonicLodge", True))
        Me.MasonicLodgeTextBox.Location = New System.Drawing.Point(117, 144)
        Me.MasonicLodgeTextBox.Name = "MasonicLodgeTextBox"
        Me.MasonicLodgeTextBox.Size = New System.Drawing.Size(238, 20)
        Me.MasonicLodgeTextBox.TabIndex = 10
        '
        'NoteTextBox
        '
        Me.NoteTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblVisitorBindingSource, "Note", True))
        Me.NoteTextBox.Location = New System.Drawing.Point(117, 172)
        Me.NoteTextBox.Multiline = True
        Me.NoteTextBox.Name = "NoteTextBox"
        Me.NoteTextBox.Size = New System.Drawing.Size(294, 43)
        Me.NoteTextBox.TabIndex = 12
        '
        'TblDateBindingSource
        '
        Me.TblDateBindingSource.DataMember = "tblDate"
        Me.TblDateBindingSource.DataSource = Me.OESDataSet
        '
        'DateIDTextBox1
        '
        Me.DateIDTextBox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblDateBindingSource, "DateID", True))
        Me.DateIDTextBox1.Location = New System.Drawing.Point(368, 8)
        Me.DateIDTextBox1.Name = "DateIDTextBox1"
        Me.DateIDTextBox1.ReadOnly = True
        Me.DateIDTextBox1.Size = New System.Drawing.Size(53, 20)
        Me.DateIDTextBox1.TabIndex = 13
        '
        'DateOfMeetingTextBox
        '
        Me.DateOfMeetingTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblDateBindingSource, "DateOfMeeting", True))
        Me.DateOfMeetingTextBox.Location = New System.Drawing.Point(181, 59)
        Me.DateOfMeetingTextBox.Name = "DateOfMeetingTextBox"
        Me.DateOfMeetingTextBox.ReadOnly = True
        Me.DateOfMeetingTextBox.Size = New System.Drawing.Size(143, 20)
        Me.DateOfMeetingTextBox.TabIndex = 15
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(117, 221)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 16
        Me.Button1.Text = "ADD"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(198, 221)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 23)
        Me.Button2.TabIndex = 17
        Me.Button2.Text = "SAVE"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(280, 221)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(107, 23)
        Me.Button3.TabIndex = 18
        Me.Button3.Text = "VISITORS FORM"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Form18
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(475, 251)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(DateIDLabel1)
        Me.Controls.Add(Me.DateIDTextBox1)
        Me.Controls.Add(DateOfMeetingLabel)
        Me.Controls.Add(Me.DateOfMeetingTextBox)
        Me.Controls.Add(VisitorIDLabel)
        Me.Controls.Add(Me.VisitorIDTextBox)
        Me.Controls.Add(DateIDLabel)
        Me.Controls.Add(Me.DateIDTextBox)
        Me.Controls.Add(VisitorNameLabel)
        Me.Controls.Add(Me.VisitorNameTextBox)
        Me.Controls.Add(ChapterLabel)
        Me.Controls.Add(Me.ChapterTextBox)
        Me.Controls.Add(MasonicLodgeLabel)
        Me.Controls.Add(Me.MasonicLodgeTextBox)
        Me.Controls.Add(NoteLabel)
        Me.Controls.Add(Me.NoteTextBox)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "Form18"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "ADD VISITORS"
        CType(Me.OESDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TblVisitorBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TblDateBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents OESDataSet As OESDataSet
    Friend WithEvents TblVisitorBindingSource As BindingSource
    Friend WithEvents TblVisitorTableAdapter As OESDataSetTableAdapters.tblVisitorTableAdapter
    Friend WithEvents TableAdapterManager As OESDataSetTableAdapters.TableAdapterManager
    Friend WithEvents VisitorIDTextBox As TextBox
    Friend WithEvents DateIDTextBox As TextBox
    Friend WithEvents VisitorNameTextBox As TextBox
    Friend WithEvents ChapterTextBox As TextBox
    Friend WithEvents MasonicLodgeTextBox As TextBox
    Friend WithEvents NoteTextBox As TextBox
    Friend WithEvents TblDateTableAdapter As OESDataSetTableAdapters.tblDateTableAdapter
    Friend WithEvents TblDateBindingSource As BindingSource
    Friend WithEvents DateIDTextBox1 As TextBox
    Friend WithEvents DateOfMeetingTextBox As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
End Class
