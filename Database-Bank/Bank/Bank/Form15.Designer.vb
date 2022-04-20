<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form15
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
        Dim ReportDataSource1 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Me.Workers1BindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.BankDataSet = New Bank.BankDataSet()
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.Workers1TableAdapter = New Bank.BankDataSetTableAdapters.Workers1TableAdapter()
        Me.BankDataSet1 = New Bank.BankDataSet1()
        Me.WorkersBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.WorkersTableAdapter = New Bank.BankDataSet1TableAdapters.WorkersTableAdapter()
        CType(Me.Workers1BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BankDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BankDataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.WorkersBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Workers1BindingSource
        '
        Me.Workers1BindingSource.DataMember = "Workers1"
        Me.Workers1BindingSource.DataSource = Me.BankDataSet
        '
        'BankDataSet
        '
        Me.BankDataSet.DataSetName = "BankDataSet"
        Me.BankDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ReportViewer1
        '
        Me.ReportViewer1.Dock = System.Windows.Forms.DockStyle.Fill
        ReportDataSource1.Name = "DataSet1"
        ReportDataSource1.Value = Me.WorkersBindingSource
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource1)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "Bank.Report2.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(0, 0)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.Size = New System.Drawing.Size(857, 460)
        Me.ReportViewer1.TabIndex = 0
        '
        'Workers1TableAdapter
        '
        Me.Workers1TableAdapter.ClearBeforeFill = True
        '
        'BankDataSet1
        '
        Me.BankDataSet1.DataSetName = "BankDataSet1"
        Me.BankDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'WorkersBindingSource
        '
        Me.WorkersBindingSource.DataMember = "Workers"
        Me.WorkersBindingSource.DataSource = Me.BankDataSet1
        '
        'WorkersTableAdapter
        '
        Me.WorkersTableAdapter.ClearBeforeFill = True
        '
        'Form15
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(857, 460)
        Me.Controls.Add(Me.ReportViewer1)
        Me.Name = "Form15"
        Me.Text = "Отчёт тоблицы ""Роботники"""
        CType(Me.Workers1BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BankDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BankDataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.WorkersBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents Workers1BindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents BankDataSet As Bank.BankDataSet
    Friend WithEvents Workers1TableAdapter As Bank.BankDataSetTableAdapters.Workers1TableAdapter
    Friend WithEvents WorkersBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents BankDataSet1 As Bank.BankDataSet1
    Friend WithEvents WorkersTableAdapter As Bank.BankDataSet1TableAdapters.WorkersTableAdapter
End Class
