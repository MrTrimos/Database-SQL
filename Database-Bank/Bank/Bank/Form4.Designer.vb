<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form4
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
        Dim Currency_codeLabel As System.Windows.Forms.Label
        Dim NameLabel As System.Windows.Forms.Label
        Dim Fussy_courseLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form4))
        Me.BankDataSet = New Bank.BankDataSet()
        Me.CurrencyBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.CurrencyTableAdapter = New Bank.BankDataSetTableAdapters.CurrencyTableAdapter()
        Me.TableAdapterManager = New Bank.BankDataSetTableAdapters.TableAdapterManager()
        Me.Currency_codeTextBox = New System.Windows.Forms.TextBox()
        Me.NameTextBox = New System.Windows.Forms.TextBox()
        Me.Fussy_courseTextBox = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button7 = New System.Windows.Forms.Button()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button8 = New System.Windows.Forms.Button()
        Me.Button9 = New System.Windows.Forms.Button()
        Currency_codeLabel = New System.Windows.Forms.Label()
        NameLabel = New System.Windows.Forms.Label()
        Fussy_courseLabel = New System.Windows.Forms.Label()
        CType(Me.BankDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CurrencyBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Currency_codeLabel
        '
        Currency_codeLabel.AutoSize = True
        Currency_codeLabel.Location = New System.Drawing.Point(95, 97)
        Currency_codeLabel.Name = "Currency_codeLabel"
        Currency_codeLabel.Size = New System.Drawing.Size(79, 13)
        Currency_codeLabel.TabIndex = 1
        Currency_codeLabel.Text = "Currency code:"
        '
        'NameLabel
        '
        NameLabel.AutoSize = True
        NameLabel.Location = New System.Drawing.Point(136, 144)
        NameLabel.Name = "NameLabel"
        NameLabel.Size = New System.Drawing.Size(38, 13)
        NameLabel.TabIndex = 3
        NameLabel.Text = "Name:"
        '
        'Fussy_courseLabel
        '
        Fussy_courseLabel.AutoSize = True
        Fussy_courseLabel.Location = New System.Drawing.Point(102, 195)
        Fussy_courseLabel.Name = "Fussy_courseLabel"
        Fussy_courseLabel.Size = New System.Drawing.Size(72, 13)
        Fussy_courseLabel.TabIndex = 5
        Fussy_courseLabel.Text = "Fussy course:"
        '
        'BankDataSet
        '
        Me.BankDataSet.DataSetName = "BankDataSet"
        Me.BankDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'CurrencyBindingSource
        '
        Me.CurrencyBindingSource.DataMember = "Currency"
        Me.CurrencyBindingSource.DataSource = Me.BankDataSet
        '
        'CurrencyTableAdapter
        '
        Me.CurrencyTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.ContributionsTableAdapter = Nothing
        Me.TableAdapterManager.ContributorsTableAdapter = Nothing
        Me.TableAdapterManager.CurrencyTableAdapter = Me.CurrencyTableAdapter
        Me.TableAdapterManager.PositionsTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = Bank.BankDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager.Workers1TableAdapter = Nothing
        '
        'Currency_codeTextBox
        '
        Me.Currency_codeTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CurrencyBindingSource, "Currency code", True))
        Me.Currency_codeTextBox.Location = New System.Drawing.Point(180, 94)
        Me.Currency_codeTextBox.Name = "Currency_codeTextBox"
        Me.Currency_codeTextBox.Size = New System.Drawing.Size(197, 20)
        Me.Currency_codeTextBox.TabIndex = 2
        '
        'NameTextBox
        '
        Me.NameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CurrencyBindingSource, "Name", True))
        Me.NameTextBox.Location = New System.Drawing.Point(180, 141)
        Me.NameTextBox.Name = "NameTextBox"
        Me.NameTextBox.Size = New System.Drawing.Size(197, 20)
        Me.NameTextBox.TabIndex = 4
        '
        'Fussy_courseTextBox
        '
        Me.Fussy_courseTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CurrencyBindingSource, "Fussy course", True))
        Me.Fussy_courseTextBox.Location = New System.Drawing.Point(180, 192)
        Me.Fussy_courseTextBox.Name = "Fussy_courseTextBox"
        Me.Fussy_courseTextBox.Size = New System.Drawing.Size(197, 20)
        Me.Fussy_courseTextBox.TabIndex = 6
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Label1.Location = New System.Drawing.Point(222, 24)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(100, 29)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "Валюта"
        '
        'Button5
        '
        Me.Button5.Image = CType(resources.GetObject("Button5.Image"), System.Drawing.Image)
        Me.Button5.Location = New System.Drawing.Point(269, 298)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(36, 41)
        Me.Button5.TabIndex = 40
        Me.Button5.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.Image = CType(resources.GetObject("Button4.Image"), System.Drawing.Image)
        Me.Button4.Location = New System.Drawing.Point(334, 298)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(36, 41)
        Me.Button4.TabIndex = 39
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Image = CType(resources.GetObject("Button2.Image"), System.Drawing.Image)
        Me.Button2.Location = New System.Drawing.Point(227, 298)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(36, 41)
        Me.Button2.TabIndex = 38
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Image = CType(resources.GetObject("Button1.Image"), System.Drawing.Image)
        Me.Button1.Location = New System.Drawing.Point(168, 298)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(36, 41)
        Me.Button1.TabIndex = 37
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button7
        '
        Me.Button7.Location = New System.Drawing.Point(451, 92)
        Me.Button7.Name = "Button7"
        Me.Button7.Size = New System.Drawing.Size(69, 29)
        Me.Button7.TabIndex = 43
        Me.Button7.Text = "Сохранить"
        Me.Button7.UseVisualStyleBackColor = True
        '
        'Button6
        '
        Me.Button6.Location = New System.Drawing.Point(451, 173)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(69, 28)
        Me.Button6.TabIndex = 42
        Me.Button6.Text = "Удалить"
        Me.Button6.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(451, 12)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(69, 32)
        Me.Button3.TabIndex = 41
        Me.Button3.Text = "Добавить"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button8
        '
        Me.Button8.Location = New System.Drawing.Point(451, 237)
        Me.Button8.Name = "Button8"
        Me.Button8.Size = New System.Drawing.Size(69, 28)
        Me.Button8.TabIndex = 44
        Me.Button8.Text = "Таблица"
        Me.Button8.UseVisualStyleBackColor = True
        '
        'Button9
        '
        Me.Button9.Location = New System.Drawing.Point(451, 298)
        Me.Button9.Name = "Button9"
        Me.Button9.Size = New System.Drawing.Size(69, 28)
        Me.Button9.TabIndex = 55
        Me.Button9.Text = "Звіти"
        Me.Button9.UseVisualStyleBackColor = True
        '
        'Form4
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(532, 362)
        Me.Controls.Add(Me.Button9)
        Me.Controls.Add(Me.Button8)
        Me.Controls.Add(Me.Button7)
        Me.Controls.Add(Me.Button6)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Fussy_courseLabel)
        Me.Controls.Add(Me.Fussy_courseTextBox)
        Me.Controls.Add(NameLabel)
        Me.Controls.Add(Me.NameTextBox)
        Me.Controls.Add(Currency_codeLabel)
        Me.Controls.Add(Me.Currency_codeTextBox)
        Me.Name = "Form4"
        Me.Text = "Form4"
        CType(Me.BankDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CurrencyBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents BankDataSet As Bank.BankDataSet
    Friend WithEvents CurrencyBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents CurrencyTableAdapter As Bank.BankDataSetTableAdapters.CurrencyTableAdapter
    Friend WithEvents TableAdapterManager As Bank.BankDataSetTableAdapters.TableAdapterManager
    Friend WithEvents Currency_codeTextBox As System.Windows.Forms.TextBox
    Friend WithEvents NameTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Fussy_courseTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Button5 As System.Windows.Forms.Button
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button7 As System.Windows.Forms.Button
    Friend WithEvents Button6 As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Button8 As System.Windows.Forms.Button
    Friend WithEvents Button9 As System.Windows.Forms.Button
End Class
