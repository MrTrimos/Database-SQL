<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form16
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
        Me.PositionsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.BankDataSet = New Bank.BankDataSet()
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.PositionsTableAdapter = New Bank.BankDataSetTableAdapters.PositionsTableAdapter()
        Me.BankDataSet1 = New Bank.BankDataSet1()
        Me.Positions1BindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Positions1TableAdapter = New Bank.BankDataSet1TableAdapters.Positions1TableAdapter()
        CType(Me.PositionsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BankDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BankDataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Positions1BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PositionsBindingSource
        '
        Me.PositionsBindingSource.DataMember = "Positions"
        Me.PositionsBindingSource.DataSource = Me.BankDataSet
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
        ReportDataSource1.Value = Me.Positions1BindingSource
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource1)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "Bank.Report3.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(0, 0)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.Size = New System.Drawing.Size(649, 393)
        Me.ReportViewer1.TabIndex = 0
        '
        'PositionsTableAdapter
        '
        Me.PositionsTableAdapter.ClearBeforeFill = True
        '
        'BankDataSet1
        '
        Me.BankDataSet1.DataSetName = "BankDataSet1"
        Me.BankDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Positions1BindingSource
        '
        Me.Positions1BindingSource.DataMember = "Positions1"
        Me.Positions1BindingSource.DataSource = Me.BankDataSet1
        '
        'Positions1TableAdapter
        '
        Me.Positions1TableAdapter.ClearBeforeFill = True
        '
        'Form16
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(649, 393)
        Me.Controls.Add(Me.ReportViewer1)
        Me.Name = "Form16"
        Me.Text = "Отчёт тоблицы ""Вакансии"""
        CType(Me.PositionsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BankDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BankDataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Positions1BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents PositionsBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents BankDataSet As Bank.BankDataSet
    Friend WithEvents PositionsTableAdapter As Bank.BankDataSetTableAdapters.PositionsTableAdapter
    Friend WithEvents Positions1BindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents BankDataSet1 As Bank.BankDataSet1
    Friend WithEvents Positions1TableAdapter As Bank.BankDataSet1TableAdapters.Positions1TableAdapter
End Class
