<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form7
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
        Dim FIO_the_depositorLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form7))
        Dim AddressLabel As System.Windows.Forms.Label
        Dim PhoneLabel As System.Windows.Forms.Label
        Dim Passport_dataLabel As System.Windows.Forms.Label
        Dim Date_of_depositLabel As System.Windows.Forms.Label
        Dim Date_of_returnLabel As System.Windows.Forms.Label
        Dim Deposit_codeLabel As System.Windows.Forms.Label
        Dim The_amount_of_the_depositLabel As System.Windows.Forms.Label
        Dim Amount_of_refundLabel As System.Windows.Forms.Label
        Dim Mark_of_return_of_depositLabel As System.Windows.Forms.Label
        Dim Employee_codeLabel As System.Windows.Forms.Label
        Me.BankDataSet = New Bank.BankDataSet()
        Me.ContributorsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ContributorsTableAdapter = New Bank.BankDataSetTableAdapters.ContributorsTableAdapter()
        Me.TableAdapterManager = New Bank.BankDataSetTableAdapters.TableAdapterManager()
        Me.FIO_the_depositorTextBox = New System.Windows.Forms.TextBox()
        Me.AddressTextBox = New System.Windows.Forms.TextBox()
        Me.Date_of_depositDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.Date_of_returnDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.Deposit_codeTextBox = New System.Windows.Forms.TextBox()
        Me.The_amount_of_the_depositTextBox = New System.Windows.Forms.TextBox()
        Me.Amount_of_refundTextBox = New System.Windows.Forms.TextBox()
        Me.Mark_of_return_of_depositTextBox = New System.Windows.Forms.TextBox()
        Me.Employee_codeTextBox = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.Button7 = New System.Windows.Forms.Button()
        Me.MaskedTextBox1 = New System.Windows.Forms.MaskedTextBox()
        Me.MaskedTextBox2 = New System.Windows.Forms.MaskedTextBox()
        Me.Button8 = New System.Windows.Forms.Button()
        Me.Button9 = New System.Windows.Forms.Button()
        FIO_the_depositorLabel = New System.Windows.Forms.Label()
        AddressLabel = New System.Windows.Forms.Label()
        PhoneLabel = New System.Windows.Forms.Label()
        Passport_dataLabel = New System.Windows.Forms.Label()
        Date_of_depositLabel = New System.Windows.Forms.Label()
        Date_of_returnLabel = New System.Windows.Forms.Label()
        Deposit_codeLabel = New System.Windows.Forms.Label()
        The_amount_of_the_depositLabel = New System.Windows.Forms.Label()
        Amount_of_refundLabel = New System.Windows.Forms.Label()
        Mark_of_return_of_depositLabel = New System.Windows.Forms.Label()
        Employee_codeLabel = New System.Windows.Forms.Label()
        CType(Me.BankDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ContributorsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'FIO_the_depositorLabel
        '
        FIO_the_depositorLabel.AutoSize = True
        FIO_the_depositorLabel.Image = CType(resources.GetObject("FIO_the_depositorLabel.Image"), System.Drawing.Image)
        FIO_the_depositorLabel.Location = New System.Drawing.Point(117, 88)
        FIO_the_depositorLabel.Name = "FIO_the_depositorLabel"
        FIO_the_depositorLabel.Size = New System.Drawing.Size(91, 13)
        FIO_the_depositorLabel.TabIndex = 1
        FIO_the_depositorLabel.Text = "FIO the depositor:"
        '
        'AddressLabel
        '
        AddressLabel.AutoSize = True
        AddressLabel.Image = CType(resources.GetObject("AddressLabel.Image"), System.Drawing.Image)
        AddressLabel.Location = New System.Drawing.Point(160, 134)
        AddressLabel.Name = "AddressLabel"
        AddressLabel.Size = New System.Drawing.Size(48, 13)
        AddressLabel.TabIndex = 3
        AddressLabel.Text = "Address:"
        '
        'PhoneLabel
        '
        PhoneLabel.AutoSize = True
        PhoneLabel.Image = CType(resources.GetObject("PhoneLabel.Image"), System.Drawing.Image)
        PhoneLabel.Location = New System.Drawing.Point(167, 195)
        PhoneLabel.Name = "PhoneLabel"
        PhoneLabel.Size = New System.Drawing.Size(41, 13)
        PhoneLabel.TabIndex = 5
        PhoneLabel.Text = "Phone:"
        '
        'Passport_dataLabel
        '
        Passport_dataLabel.AutoSize = True
        Passport_dataLabel.Image = CType(resources.GetObject("Passport_dataLabel.Image"), System.Drawing.Image)
        Passport_dataLabel.Location = New System.Drawing.Point(133, 245)
        Passport_dataLabel.Name = "Passport_dataLabel"
        Passport_dataLabel.Size = New System.Drawing.Size(75, 13)
        Passport_dataLabel.TabIndex = 7
        Passport_dataLabel.Text = "Passport data:"
        '
        'Date_of_depositLabel
        '
        Date_of_depositLabel.AutoSize = True
        Date_of_depositLabel.Image = CType(resources.GetObject("Date_of_depositLabel.Image"), System.Drawing.Image)
        Date_of_depositLabel.Location = New System.Drawing.Point(126, 287)
        Date_of_depositLabel.Name = "Date_of_depositLabel"
        Date_of_depositLabel.Size = New System.Drawing.Size(82, 13)
        Date_of_depositLabel.TabIndex = 9
        Date_of_depositLabel.Text = "Date of deposit:"
        '
        'Date_of_returnLabel
        '
        Date_of_returnLabel.AutoSize = True
        Date_of_returnLabel.Image = CType(resources.GetObject("Date_of_returnLabel.Image"), System.Drawing.Image)
        Date_of_returnLabel.Location = New System.Drawing.Point(133, 339)
        Date_of_returnLabel.Name = "Date_of_returnLabel"
        Date_of_returnLabel.Size = New System.Drawing.Size(75, 13)
        Date_of_returnLabel.TabIndex = 11
        Date_of_returnLabel.Text = "Date of return:"
        '
        'Deposit_codeLabel
        '
        Deposit_codeLabel.AutoSize = True
        Deposit_codeLabel.Image = CType(resources.GetObject("Deposit_codeLabel.Image"), System.Drawing.Image)
        Deposit_codeLabel.Location = New System.Drawing.Point(135, 378)
        Deposit_codeLabel.Name = "Deposit_codeLabel"
        Deposit_codeLabel.Size = New System.Drawing.Size(73, 13)
        Deposit_codeLabel.TabIndex = 13
        Deposit_codeLabel.Text = "Deposit code:"
        '
        'The_amount_of_the_depositLabel
        '
        The_amount_of_the_depositLabel.AutoSize = True
        The_amount_of_the_depositLabel.Image = CType(resources.GetObject("The_amount_of_the_depositLabel.Image"), System.Drawing.Image)
        The_amount_of_the_depositLabel.Location = New System.Drawing.Point(74, 421)
        The_amount_of_the_depositLabel.Name = "The_amount_of_the_depositLabel"
        The_amount_of_the_depositLabel.Size = New System.Drawing.Size(134, 13)
        The_amount_of_the_depositLabel.TabIndex = 15
        The_amount_of_the_depositLabel.Text = "The amount of the deposit:"
        '
        'Amount_of_refundLabel
        '
        Amount_of_refundLabel.AutoSize = True
        Amount_of_refundLabel.Image = CType(resources.GetObject("Amount_of_refundLabel.Image"), System.Drawing.Image)
        Amount_of_refundLabel.Location = New System.Drawing.Point(117, 464)
        Amount_of_refundLabel.Name = "Amount_of_refundLabel"
        Amount_of_refundLabel.Size = New System.Drawing.Size(91, 13)
        Amount_of_refundLabel.TabIndex = 17
        Amount_of_refundLabel.Text = "Amount of refund:"
        '
        'Mark_of_return_of_depositLabel
        '
        Mark_of_return_of_depositLabel.AutoSize = True
        Mark_of_return_of_depositLabel.Image = CType(resources.GetObject("Mark_of_return_of_depositLabel.Image"), System.Drawing.Image)
        Mark_of_return_of_depositLabel.Location = New System.Drawing.Point(83, 509)
        Mark_of_return_of_depositLabel.Name = "Mark_of_return_of_depositLabel"
        Mark_of_return_of_depositLabel.Size = New System.Drawing.Size(125, 13)
        Mark_of_return_of_depositLabel.TabIndex = 19
        Mark_of_return_of_depositLabel.Text = "Mark of return of deposit:"
        '
        'Employee_codeLabel
        '
        Employee_codeLabel.AutoSize = True
        Employee_codeLabel.Image = CType(resources.GetObject("Employee_codeLabel.Image"), System.Drawing.Image)
        Employee_codeLabel.Location = New System.Drawing.Point(125, 550)
        Employee_codeLabel.Name = "Employee_codeLabel"
        Employee_codeLabel.Size = New System.Drawing.Size(83, 13)
        Employee_codeLabel.TabIndex = 21
        Employee_codeLabel.Text = "Employee code:"
        '
        'BankDataSet
        '
        Me.BankDataSet.DataSetName = "BankDataSet"
        Me.BankDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ContributorsBindingSource
        '
        Me.ContributorsBindingSource.DataMember = "Contributors"
        Me.ContributorsBindingSource.DataSource = Me.BankDataSet
        '
        'ContributorsTableAdapter
        '
        Me.ContributorsTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.ContributionsTableAdapter = Nothing
        Me.TableAdapterManager.ContributorsTableAdapter = Me.ContributorsTableAdapter
        Me.TableAdapterManager.CurrencyTableAdapter = Nothing
        Me.TableAdapterManager.PositionsTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = Bank.BankDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager.Workers1TableAdapter = Nothing
        '
        'FIO_the_depositorTextBox
        '
        Me.FIO_the_depositorTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ContributorsBindingSource, "FIO the depositor", True))
        Me.FIO_the_depositorTextBox.Location = New System.Drawing.Point(214, 85)
        Me.FIO_the_depositorTextBox.Name = "FIO_the_depositorTextBox"
        Me.FIO_the_depositorTextBox.Size = New System.Drawing.Size(200, 20)
        Me.FIO_the_depositorTextBox.TabIndex = 2
        '
        'AddressTextBox
        '
        Me.AddressTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ContributorsBindingSource, "Address", True))
        Me.AddressTextBox.Location = New System.Drawing.Point(214, 131)
        Me.AddressTextBox.Multiline = True
        Me.AddressTextBox.Name = "AddressTextBox"
        Me.AddressTextBox.Size = New System.Drawing.Size(200, 40)
        Me.AddressTextBox.TabIndex = 4
        '
        'Date_of_depositDateTimePicker
        '
        Me.Date_of_depositDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.ContributorsBindingSource, "Date of deposit", True))
        Me.Date_of_depositDateTimePicker.Location = New System.Drawing.Point(214, 283)
        Me.Date_of_depositDateTimePicker.Name = "Date_of_depositDateTimePicker"
        Me.Date_of_depositDateTimePicker.Size = New System.Drawing.Size(200, 20)
        Me.Date_of_depositDateTimePicker.TabIndex = 10
        '
        'Date_of_returnDateTimePicker
        '
        Me.Date_of_returnDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.ContributorsBindingSource, "Date of return", True))
        Me.Date_of_returnDateTimePicker.Location = New System.Drawing.Point(214, 335)
        Me.Date_of_returnDateTimePicker.Name = "Date_of_returnDateTimePicker"
        Me.Date_of_returnDateTimePicker.Size = New System.Drawing.Size(200, 20)
        Me.Date_of_returnDateTimePicker.TabIndex = 12
        '
        'Deposit_codeTextBox
        '
        Me.Deposit_codeTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ContributorsBindingSource, "Deposit code", True))
        Me.Deposit_codeTextBox.Location = New System.Drawing.Point(214, 375)
        Me.Deposit_codeTextBox.Name = "Deposit_codeTextBox"
        Me.Deposit_codeTextBox.Size = New System.Drawing.Size(200, 20)
        Me.Deposit_codeTextBox.TabIndex = 14
        '
        'The_amount_of_the_depositTextBox
        '
        Me.The_amount_of_the_depositTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ContributorsBindingSource, "The amount of the deposit", True))
        Me.The_amount_of_the_depositTextBox.Location = New System.Drawing.Point(214, 418)
        Me.The_amount_of_the_depositTextBox.Name = "The_amount_of_the_depositTextBox"
        Me.The_amount_of_the_depositTextBox.Size = New System.Drawing.Size(200, 20)
        Me.The_amount_of_the_depositTextBox.TabIndex = 16
        '
        'Amount_of_refundTextBox
        '
        Me.Amount_of_refundTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ContributorsBindingSource, "Amount of refund", True))
        Me.Amount_of_refundTextBox.Location = New System.Drawing.Point(214, 461)
        Me.Amount_of_refundTextBox.Name = "Amount_of_refundTextBox"
        Me.Amount_of_refundTextBox.Size = New System.Drawing.Size(200, 20)
        Me.Amount_of_refundTextBox.TabIndex = 18
        '
        'Mark_of_return_of_depositTextBox
        '
        Me.Mark_of_return_of_depositTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ContributorsBindingSource, "Mark of return of deposit", True))
        Me.Mark_of_return_of_depositTextBox.Location = New System.Drawing.Point(214, 506)
        Me.Mark_of_return_of_depositTextBox.Name = "Mark_of_return_of_depositTextBox"
        Me.Mark_of_return_of_depositTextBox.Size = New System.Drawing.Size(200, 20)
        Me.Mark_of_return_of_depositTextBox.TabIndex = 20
        '
        'Employee_codeTextBox
        '
        Me.Employee_codeTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ContributorsBindingSource, "Employee code", True))
        Me.Employee_codeTextBox.Location = New System.Drawing.Point(214, 547)
        Me.Employee_codeTextBox.Name = "Employee_codeTextBox"
        Me.Employee_codeTextBox.Size = New System.Drawing.Size(200, 20)
        Me.Employee_codeTextBox.TabIndex = 22
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.White
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Label1.ImageKey = "(отсутствует)"
        Me.Label1.Location = New System.Drawing.Point(228, 17)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(140, 29)
        Me.Label1.TabIndex = 23
        Me.Label1.Text = "Вкладники"
        '
        'Button1
        '
        Me.Button1.Image = CType(resources.GetObject("Button1.Image"), System.Drawing.Image)
        Me.Button1.Location = New System.Drawing.Point(200, 648)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(36, 41)
        Me.Button1.TabIndex = 24
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Image = CType(resources.GetObject("Button2.Image"), System.Drawing.Image)
        Me.Button2.Location = New System.Drawing.Point(259, 648)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(36, 41)
        Me.Button2.TabIndex = 25
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(511, 19)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(69, 32)
        Me.Button3.TabIndex = 26
        Me.Button3.Text = "Добавить"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.Image = CType(resources.GetObject("Button4.Image"), System.Drawing.Image)
        Me.Button4.Location = New System.Drawing.Point(366, 648)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(36, 41)
        Me.Button4.TabIndex = 27
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Button5
        '
        Me.Button5.Image = CType(resources.GetObject("Button5.Image"), System.Drawing.Image)
        Me.Button5.Location = New System.Drawing.Point(301, 648)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(36, 41)
        Me.Button5.TabIndex = 28
        Me.Button5.UseVisualStyleBackColor = True
        '
        'Button6
        '
        Me.Button6.Location = New System.Drawing.Point(511, 180)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(69, 28)
        Me.Button6.TabIndex = 29
        Me.Button6.Text = "Удалить"
        Me.Button6.UseVisualStyleBackColor = True
        '
        'Button7
        '
        Me.Button7.Location = New System.Drawing.Point(511, 99)
        Me.Button7.Name = "Button7"
        Me.Button7.Size = New System.Drawing.Size(69, 29)
        Me.Button7.TabIndex = 30
        Me.Button7.Text = "Сохранить"
        Me.Button7.UseVisualStyleBackColor = True
        '
        'MaskedTextBox1
        '
        Me.MaskedTextBox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ContributorsBindingSource, "Phone", True))
        Me.MaskedTextBox1.Location = New System.Drawing.Point(214, 195)
        Me.MaskedTextBox1.Mask = "+38(999)000-00-00"
        Me.MaskedTextBox1.Name = "MaskedTextBox1"
        Me.MaskedTextBox1.Size = New System.Drawing.Size(200, 20)
        Me.MaskedTextBox1.TabIndex = 31
        '
        'MaskedTextBox2
        '
        Me.MaskedTextBox2.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ContributorsBindingSource, "Passport data", True))
        Me.MaskedTextBox2.Location = New System.Drawing.Point(214, 242)
        Me.MaskedTextBox2.Mask = "ЄК-0000000"
        Me.MaskedTextBox2.Name = "MaskedTextBox2"
        Me.MaskedTextBox2.Size = New System.Drawing.Size(200, 20)
        Me.MaskedTextBox2.TabIndex = 0
        '
        'Button8
        '
        Me.Button8.Location = New System.Drawing.Point(511, 245)
        Me.Button8.Name = "Button8"
        Me.Button8.Size = New System.Drawing.Size(69, 28)
        Me.Button8.TabIndex = 32
        Me.Button8.Text = "Таблица"
        Me.Button8.UseVisualStyleBackColor = True
        '
        'Button9
        '
        Me.Button9.Location = New System.Drawing.Point(511, 308)
        Me.Button9.Name = "Button9"
        Me.Button9.Size = New System.Drawing.Size(69, 28)
        Me.Button9.TabIndex = 58
        Me.Button9.Text = "Звіти"
        Me.Button9.UseVisualStyleBackColor = True
        '
        'Form7
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(600, 709)
        Me.Controls.Add(Me.Button9)
        Me.Controls.Add(Me.Button8)
        Me.Controls.Add(Me.MaskedTextBox2)
        Me.Controls.Add(Me.MaskedTextBox1)
        Me.Controls.Add(Me.Button7)
        Me.Controls.Add(Me.Button6)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Employee_codeLabel)
        Me.Controls.Add(Me.Employee_codeTextBox)
        Me.Controls.Add(Mark_of_return_of_depositLabel)
        Me.Controls.Add(Me.Mark_of_return_of_depositTextBox)
        Me.Controls.Add(Amount_of_refundLabel)
        Me.Controls.Add(Me.Amount_of_refundTextBox)
        Me.Controls.Add(The_amount_of_the_depositLabel)
        Me.Controls.Add(Me.The_amount_of_the_depositTextBox)
        Me.Controls.Add(Deposit_codeLabel)
        Me.Controls.Add(Me.Deposit_codeTextBox)
        Me.Controls.Add(Date_of_returnLabel)
        Me.Controls.Add(Me.Date_of_returnDateTimePicker)
        Me.Controls.Add(Date_of_depositLabel)
        Me.Controls.Add(Me.Date_of_depositDateTimePicker)
        Me.Controls.Add(Passport_dataLabel)
        Me.Controls.Add(PhoneLabel)
        Me.Controls.Add(AddressLabel)
        Me.Controls.Add(Me.AddressTextBox)
        Me.Controls.Add(FIO_the_depositorLabel)
        Me.Controls.Add(Me.FIO_the_depositorTextBox)
        Me.Name = "Form7"
        Me.Text = "Form7"
        CType(Me.BankDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ContributorsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents BankDataSet As Bank.BankDataSet
    Friend WithEvents ContributorsBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ContributorsTableAdapter As Bank.BankDataSetTableAdapters.ContributorsTableAdapter
    Friend WithEvents TableAdapterManager As Bank.BankDataSetTableAdapters.TableAdapterManager
    Friend WithEvents FIO_the_depositorTextBox As System.Windows.Forms.TextBox
    Friend WithEvents AddressTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Date_of_depositDateTimePicker As System.Windows.Forms.DateTimePicker
    Friend WithEvents Date_of_returnDateTimePicker As System.Windows.Forms.DateTimePicker
    Friend WithEvents Deposit_codeTextBox As System.Windows.Forms.TextBox
    Friend WithEvents The_amount_of_the_depositTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Amount_of_refundTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Mark_of_return_of_depositTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Employee_codeTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents Button5 As System.Windows.Forms.Button
    Friend WithEvents Button6 As System.Windows.Forms.Button
    Friend WithEvents Button7 As System.Windows.Forms.Button
    Friend WithEvents MaskedTextBox1 As System.Windows.Forms.MaskedTextBox
    Friend WithEvents MaskedTextBox2 As System.Windows.Forms.MaskedTextBox
    Friend WithEvents Button8 As System.Windows.Forms.Button
    Friend WithEvents Button9 As System.Windows.Forms.Button
End Class
