<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form14
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
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.Contributions1BindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.BankDataSet = New Bank.BankDataSet()
        Me.ContributionsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ContributionsTableAdapter = New Bank.BankDataSetTableAdapters.ContributionsTableAdapter()
        Me.Contributions1TableAdapter = New Bank.BankDataSetTableAdapters.Contributions1TableAdapter()
        CType(Me.Contributions1BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BankDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ContributionsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ReportViewer1
        '
        Me.ReportViewer1.Dock = System.Windows.Forms.DockStyle.Fill
        ReportDataSource1.Name = "DataSet1"
        ReportDataSource1.Value = Me.Contributions1BindingSource
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource1)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "Bank.Report6.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(0, 0)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.Size = New System.Drawing.Size(672, 469)
        Me.ReportViewer1.TabIndex = 0
        '
        'Contributions1BindingSource
        '
        Me.Contributions1BindingSource.DataMember = "Contributions1"
        Me.Contributions1BindingSource.DataSource = Me.BankDataSet
        '
        'BankDataSet
        '
        Me.BankDataSet.DataSetName = "BankDataSet"
        Me.BankDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ContributionsBindingSource
        '
        Me.ContributionsBindingSource.DataMember = "Contributions"
        Me.ContributionsBindingSource.DataSource = Me.BankDataSet
        '
        'ContributionsTableAdapter
        '
        Me.ContributionsTableAdapter.ClearBeforeFill = True
        '
        'Contributions1TableAdapter
        '
        Me.Contributions1TableAdapter.ClearBeforeFill = True
        '
        'Form14
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(672, 469)
        Me.Controls.Add(Me.ReportViewer1)
        Me.Name = "Form14"
        Me.Text = "Отчёт тоблицы ""Вклади"""
        CType(Me.Contributions1BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BankDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ContributionsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents ContributionsBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents BankDataSet As Bank.BankDataSet
    Friend WithEvents ContributionsTableAdapter As Bank.BankDataSetTableAdapters.ContributionsTableAdapter
    Friend WithEvents Contributions1BindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Contributions1TableAdapter As Bank.BankDataSetTableAdapters.Contributions1TableAdapter
End Class
