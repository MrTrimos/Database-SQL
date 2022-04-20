<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form6
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
        Dim Deposit_codeLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form6))
        Dim Name_of_the_depositLabel As System.Windows.Forms.Label
        Dim Minimum_deposit_termLabel As System.Windows.Forms.Label
        Dim Minimum_deposit_amountLabel As System.Windows.Forms.Label
        Dim Interest_rateLabel As System.Windows.Forms.Label
        Dim Additional_conditionsLabel As System.Windows.Forms.Label
        Dim Currency_codeLabel1 As System.Windows.Forms.Label
        Me.BankDataSet = New Bank.BankDataSet()
        Me.ContributionsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ContributionsTableAdapter = New Bank.BankDataSetTableAdapters.ContributionsTableAdapter()
        Me.TableAdapterManager = New Bank.BankDataSetTableAdapters.TableAdapterManager()
        Me.Deposit_codeTextBox = New System.Windows.Forms.TextBox()
        Me.Name_of_the_depositTextBox = New System.Windows.Forms.TextBox()
        Me.Minimum_deposit_termTextBox = New System.Windows.Forms.TextBox()
        Me.Minimum_deposit_amountTextBox = New System.Windows.Forms.TextBox()
        Me.Interest_rateTextBox = New System.Windows.Forms.TextBox()
        Me.Additional_conditionsTextBox = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button7 = New System.Windows.Forms.Button()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Currency_codeComboBox = New System.Windows.Forms.ComboBox()
        Me.CintributionBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.CintributionTableAdapter = New Bank.BankDataSetTableAdapters.CintributionTableAdapter()
        Me.Button8 = New System.Windows.Forms.Button()
        Me.Button9 = New System.Windows.Forms.Button()
        Deposit_codeLabel = New System.Windows.Forms.Label()
        Name_of_the_depositLabel = New System.Windows.Forms.Label()
        Minimum_deposit_termLabel = New System.Windows.Forms.Label()
        Minimum_deposit_amountLabel = New System.Windows.Forms.Label()
        Interest_rateLabel = New System.Windows.Forms.Label()
        Additional_conditionsLabel = New System.Windows.Forms.Label()
        Currency_codeLabel1 = New System.Windows.Forms.Label()
        CType(Me.BankDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ContributionsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CintributionBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Deposit_codeLabel
        '
        Deposit_codeLabel.AutoSize = True
        Deposit_codeLabel.Image = CType(resources.GetObject("Deposit_codeLabel.Image"), System.Drawing.Image)
        Deposit_codeLabel.Location = New System.Drawing.Point(119, 92)
        Deposit_codeLabel.Name = "Deposit_codeLabel"
        Deposit_codeLabel.Size = New System.Drawing.Size(73, 13)
        Deposit_codeLabel.TabIndex = 1
        Deposit_codeLabel.Text = "Deposit code:"
        '
        'Name_of_the_depositLabel
        '
        Name_of_the_depositLabel.AutoSize = True
        Name_of_the_depositLabel.Image = CType(resources.GetObject("Name_of_the_depositLabel.Image"), System.Drawing.Image)
        Name_of_the_depositLabel.Location = New System.Drawing.Point(87, 136)
        Name_of_the_depositLabel.Name = "Name_of_the_depositLabel"
        Name_of_the_depositLabel.Size = New System.Drawing.Size(105, 13)
        Name_of_the_depositLabel.TabIndex = 3
        Name_of_the_depositLabel.Text = "Name of the deposit:"
        '
        'Minimum_deposit_termLabel
        '
        Minimum_deposit_termLabel.AutoSize = True
        Minimum_deposit_termLabel.Image = CType(resources.GetObject("Minimum_deposit_termLabel.Image"), System.Drawing.Image)
        Minimum_deposit_termLabel.Location = New System.Drawing.Point(81, 185)
        Minimum_deposit_termLabel.Name = "Minimum_deposit_termLabel"
        Minimum_deposit_termLabel.Size = New System.Drawing.Size(111, 13)
        Minimum_deposit_termLabel.TabIndex = 5
        Minimum_deposit_termLabel.Text = "Minimum deposit term:"
        '
        'Minimum_deposit_amountLabel
        '
        Minimum_deposit_amountLabel.AutoSize = True
        Minimum_deposit_amountLabel.Image = CType(resources.GetObject("Minimum_deposit_amountLabel.Image"), System.Drawing.Image)
        Minimum_deposit_amountLabel.Location = New System.Drawing.Point(66, 233)
        Minimum_deposit_amountLabel.Name = "Minimum_deposit_amountLabel"
        Minimum_deposit_amountLabel.Size = New System.Drawing.Size(126, 13)
        Minimum_deposit_amountLabel.TabIndex = 7
        Minimum_deposit_amountLabel.Text = "Minimum deposit amount:"
        '
        'Interest_rateLabel
        '
        Interest_rateLabel.AutoSize = True
        Interest_rateLabel.Image = CType(resources.GetObject("Interest_rateLabel.Image"), System.Drawing.Image)
        Interest_rateLabel.Location = New System.Drawing.Point(126, 328)
        Interest_rateLabel.Name = "Interest_rateLabel"
        Interest_rateLabel.Size = New System.Drawing.Size(66, 13)
        Interest_rateLabel.TabIndex = 11
        Interest_rateLabel.Text = "Interest rate:"
        '
        'Additional_conditionsLabel
        '
        Additional_conditionsLabel.AutoSize = True
        Additional_conditionsLabel.Image = CType(resources.GetObject("Additional_conditionsLabel.Image"), System.Drawing.Image)
        Additional_conditionsLabel.Location = New System.Drawing.Point(85, 379)
        Additional_conditionsLabel.Name = "Additional_conditionsLabel"
        Additional_conditionsLabel.Size = New System.Drawing.Size(107, 13)
        Additional_conditionsLabel.TabIndex = 13
        Additional_conditionsLabel.Text = "Additional conditions:"
        '
        'Currency_codeLabel1
        '
        Currency_codeLabel1.AutoSize = True
        Currency_codeLabel1.Image = CType(resources.GetObject("Currency_codeLabel1.Image"), System.Drawing.Image)
        Currency_codeLabel1.Location = New System.Drawing.Point(113, 279)
        Currency_codeLabel1.Name = "Currency_codeLabel1"
        Currency_codeLabel1.Size = New System.Drawing.Size(79, 13)
        Currency_codeLabel1.TabIndex = 35
        Currency_codeLabel1.Text = "Currency code:"
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
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.ContributionsTableAdapter = Me.ContributionsTableAdapter
        Me.TableAdapterManager.ContributorsTableAdapter = Nothing
        Me.TableAdapterManager.CurrencyTableAdapter = Nothing
        Me.TableAdapterManager.PositionsTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = Bank.BankDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager.Workers1TableAdapter = Nothing
        '
        'Deposit_codeTextBox
        '
        Me.Deposit_codeTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ContributionsBindingSource, "Deposit code", True))
        Me.Deposit_codeTextBox.Location = New System.Drawing.Point(198, 89)
        Me.Deposit_codeTextBox.Name = "Deposit_codeTextBox"
        Me.Deposit_codeTextBox.Size = New System.Drawing.Size(225, 20)
        Me.Deposit_codeTextBox.TabIndex = 2
        '
        'Name_of_the_depositTextBox
        '
        Me.Name_of_the_depositTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ContributionsBindingSource, "Name of the deposit", True))
        Me.Name_of_the_depositTextBox.Location = New System.Drawing.Point(198, 133)
        Me.Name_of_the_depositTextBox.Name = "Name_of_the_depositTextBox"
        Me.Name_of_the_depositTextBox.Size = New System.Drawing.Size(225, 20)
        Me.Name_of_the_depositTextBox.TabIndex = 4
        '
        'Minimum_deposit_termTextBox
        '
        Me.Minimum_deposit_termTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ContributionsBindingSource, "Minimum deposit term", True))
        Me.Minimum_deposit_termTextBox.Location = New System.Drawing.Point(198, 182)
        Me.Minimum_deposit_termTextBox.Name = "Minimum_deposit_termTextBox"
        Me.Minimum_deposit_termTextBox.Size = New System.Drawing.Size(225, 20)
        Me.Minimum_deposit_termTextBox.TabIndex = 6
        '
        'Minimum_deposit_amountTextBox
        '
        Me.Minimum_deposit_amountTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ContributionsBindingSource, "Minimum deposit amount", True))
        Me.Minimum_deposit_amountTextBox.Location = New System.Drawing.Point(198, 230)
        Me.Minimum_deposit_amountTextBox.Name = "Minimum_deposit_amountTextBox"
        Me.Minimum_deposit_amountTextBox.Size = New System.Drawing.Size(225, 20)
        Me.Minimum_deposit_amountTextBox.TabIndex = 8
        '
        'Interest_rateTextBox
        '
        Me.Interest_rateTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ContributionsBindingSource, "Interest rate", True))
        Me.Interest_rateTextBox.Location = New System.Drawing.Point(198, 325)
        Me.Interest_rateTextBox.Name = "Interest_rateTextBox"
        Me.Interest_rateTextBox.Size = New System.Drawing.Size(225, 20)
        Me.Interest_rateTextBox.TabIndex = 12
        '
        'Additional_conditionsTextBox
        '
        Me.Additional_conditionsTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ContributionsBindingSource, "Additional conditions", True))
        Me.Additional_conditionsTextBox.Location = New System.Drawing.Point(198, 376)
        Me.Additional_conditionsTextBox.Name = "Additional_conditionsTextBox"
        Me.Additional_conditionsTextBox.Size = New System.Drawing.Size(225, 20)
        Me.Additional_conditionsTextBox.TabIndex = 14
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Label1.Image = CType(resources.GetObject("Label1.Image"), System.Drawing.Image)
        Me.Label1.Location = New System.Drawing.Point(261, 20)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(98, 29)
        Me.Label1.TabIndex = 15
        Me.Label1.Text = "Вклади"
        '
        'Button5
        '
        Me.Button5.Image = CType(resources.GetObject("Button5.Image"), System.Drawing.Image)
        Me.Button5.Location = New System.Drawing.Point(299, 474)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(36, 41)
        Me.Button5.TabIndex = 32
        Me.Button5.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.Image = CType(resources.GetObject("Button4.Image"), System.Drawing.Image)
        Me.Button4.Location = New System.Drawing.Point(364, 474)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(36, 41)
        Me.Button4.TabIndex = 31
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Image = CType(resources.GetObject("Button2.Image"), System.Drawing.Image)
        Me.Button2.Location = New System.Drawing.Point(257, 474)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(36, 41)
        Me.Button2.TabIndex = 30
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Image = CType(resources.GetObject("Button1.Image"), System.Drawing.Image)
        Me.Button1.Location = New System.Drawing.Point(198, 474)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(36, 41)
        Me.Button1.TabIndex = 29
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button7
        '
        Me.Button7.Location = New System.Drawing.Point(534, 101)
        Me.Button7.Name = "Button7"
        Me.Button7.Size = New System.Drawing.Size(69, 29)
        Me.Button7.TabIndex = 35
        Me.Button7.Text = "Сохранить"
        Me.Button7.UseVisualStyleBackColor = True
        '
        'Button6
        '
        Me.Button6.Location = New System.Drawing.Point(534, 182)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(69, 28)
        Me.Button6.TabIndex = 34
        Me.Button6.Text = "Удалить"
        Me.Button6.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(534, 21)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(69, 32)
        Me.Button3.TabIndex = 33
        Me.Button3.Text = "Добавить"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Currency_codeComboBox
        '
        Me.Currency_codeComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ContributionsBindingSource, "Currency code", True))
        Me.Currency_codeComboBox.DataSource = Me.CintributionBindingSource
        Me.Currency_codeComboBox.DisplayMember = "Name"
        Me.Currency_codeComboBox.FormattingEnabled = True
        Me.Currency_codeComboBox.Location = New System.Drawing.Point(198, 276)
        Me.Currency_codeComboBox.Name = "Currency_codeComboBox"
        Me.Currency_codeComboBox.Size = New System.Drawing.Size(225, 21)
        Me.Currency_codeComboBox.TabIndex = 36
        '
        'CintributionBindingSource
        '
        Me.CintributionBindingSource.DataMember = "Cintribution"
        Me.CintributionBindingSource.DataSource = Me.BankDataSet
        '
        'CintributionTableAdapter
        '
        Me.CintributionTableAdapter.ClearBeforeFill = True
        '
        'Button8
        '
        Me.Button8.Location = New System.Drawing.Point(534, 246)
        Me.Button8.Name = "Button8"
        Me.Button8.Size = New System.Drawing.Size(69, 28)
        Me.Button8.TabIndex = 37
        Me.Button8.Text = "Таблица"
        Me.Button8.UseVisualStyleBackColor = True
        '
        'Button9
        '
        Me.Button9.Location = New System.Drawing.Point(534, 303)
        Me.Button9.Name = "Button9"
        Me.Button9.Size = New System.Drawing.Size(69, 28)
        Me.Button9.TabIndex = 57
        Me.Button9.Text = "Звіти"
        Me.Button9.UseVisualStyleBackColor = True
        '
        'Form6
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(628, 540)
        Me.Controls.Add(Me.Button9)
        Me.Controls.Add(Me.Button8)
        Me.Controls.Add(Currency_codeLabel1)
        Me.Controls.Add(Me.Currency_codeComboBox)
        Me.Controls.Add(Me.Button7)
        Me.Controls.Add(Me.Button6)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Additional_conditionsLabel)
        Me.Controls.Add(Me.Additional_conditionsTextBox)
        Me.Controls.Add(Interest_rateLabel)
        Me.Controls.Add(Me.Interest_rateTextBox)
        Me.Controls.Add(Minimum_deposit_amountLabel)
        Me.Controls.Add(Me.Minimum_deposit_amountTextBox)
        Me.Controls.Add(Minimum_deposit_termLabel)
        Me.Controls.Add(Me.Minimum_deposit_termTextBox)
        Me.Controls.Add(Name_of_the_depositLabel)
        Me.Controls.Add(Me.Name_of_the_depositTextBox)
        Me.Controls.Add(Deposit_codeLabel)
        Me.Controls.Add(Me.Deposit_codeTextBox)
        Me.Name = "Form6"
        Me.Text = "Form6"
        CType(Me.BankDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ContributionsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CintributionBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents BankDataSet As Bank.BankDataSet
    Friend WithEvents ContributionsBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ContributionsTableAdapter As Bank.BankDataSetTableAdapters.ContributionsTableAdapter
    Friend WithEvents TableAdapterManager As Bank.BankDataSetTableAdapters.TableAdapterManager
    Friend WithEvents Deposit_codeTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Name_of_the_depositTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Minimum_deposit_termTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Minimum_deposit_amountTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Interest_rateTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Additional_conditionsTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Button5 As System.Windows.Forms.Button
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button7 As System.Windows.Forms.Button
    Friend WithEvents Button6 As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Currency_codeComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents CintributionBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents CintributionTableAdapter As Bank.BankDataSetTableAdapters.CintributionTableAdapter
    Friend WithEvents Button8 As System.Windows.Forms.Button
    Friend WithEvents Button9 As System.Windows.Forms.Button
End Class
