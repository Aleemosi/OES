<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form10
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
        Dim DateOfMeetingLabel As System.Windows.Forms.Label
        Dim ReportDataSource1 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form10))
        Me.DateRollBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.OESDataSet = New OES.OESDataSet()
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.DateRollTableAdapter = New OES.OESDataSetTableAdapters.DateRollTableAdapter()
        Me.TableAdapterManager = New OES.OESDataSetTableAdapters.TableAdapterManager()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.TblDateBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TblDateTableAdapter = New OES.OESDataSetTableAdapters.tblDateTableAdapter()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        DateOfMeetingLabel = New System.Windows.Forms.Label()
        CType(Me.DateRollBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.OESDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TblDateBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DateOfMeetingLabel
        '
        DateOfMeetingLabel.AutoSize = True
        DateOfMeetingLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DateOfMeetingLabel.Location = New System.Drawing.Point(197, 6)
        DateOfMeetingLabel.Name = "DateOfMeetingLabel"
        DateOfMeetingLabel.Size = New System.Drawing.Size(111, 15)
        DateOfMeetingLabel.TabIndex = 1
        DateOfMeetingLabel.Text = "Date Of Meeting"
        '
        'DateRollBindingSource
        '
        Me.DateRollBindingSource.DataMember = "DateRoll"
        Me.DateRollBindingSource.DataSource = Me.OESDataSet
        '
        'OESDataSet
        '
        Me.OESDataSet.DataSetName = "OESDataSet"
        Me.OESDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ReportViewer1
        '
        Me.ReportViewer1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        ReportDataSource1.Name = "DataSet1"
        ReportDataSource1.Value = Me.DateRollBindingSource
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource1)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "OES.Report4.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(0, 49)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.Size = New System.Drawing.Size(616, 472)
        Me.ReportViewer1.TabIndex = 0
        '
        'DateRollTableAdapter
        '
        Me.DateRollTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.Connection = Nothing
        Me.TableAdapterManager.Login1TableAdapter = Nothing
        Me.TableAdapterManager.LoginTableAdapter = Nothing
        Me.TableAdapterManager.tblDateTableAdapter = Nothing
        Me.TableAdapterManager.tblDuesTableAdapter = Nothing
        Me.TableAdapterManager.tblMemberTableAdapter = Nothing
        Me.TableAdapterManager.tblMinutesTableAdapter = Nothing
        Me.TableAdapterManager.tblOfficerTableAdapter = Nothing
        Me.TableAdapterManager.tblTreasureTableAdapter = Nothing
        Me.TableAdapterManager.tblVisitorTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = OES.OESDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(310, 20)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 3
        Me.Button1.Text = "DISPLAY"
        Me.Button1.UseVisualStyleBackColor = True
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
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(204, 22)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(100, 20)
        Me.TextBox1.TabIndex = 5
        '
        'Form10
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(614, 520)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(DateOfMeetingLabel)
        Me.Controls.Add(Me.ReportViewer1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Form10"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "MINUTES REPORT"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.DateRollBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.OESDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TblDateBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents DateRollBindingSource As BindingSource
    Friend WithEvents OESDataSet As OESDataSet
    Friend WithEvents DateRollTableAdapter As OESDataSetTableAdapters.DateRollTableAdapter
    Friend WithEvents TableAdapterManager As OESDataSetTableAdapters.TableAdapterManager
    Friend WithEvents Button1 As Button
    Friend WithEvents TblDateBindingSource As BindingSource
    Friend WithEvents TblDateTableAdapter As OESDataSetTableAdapters.tblDateTableAdapter
    Friend WithEvents TextBox1 As TextBox
    Private WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
End Class
