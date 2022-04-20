<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
    Inherits System.Windows.Forms.Form

    'Форма переопределяет dispose для очистки списка компонентов.
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

    'Является обязательной для конструктора форм Windows Forms
    Private components As System.ComponentModel.IContainer

    'Примечание: следующая процедура является обязательной для конструктора форм Windows Forms
    'Для ее изменения используйте конструктор форм Windows Form.  
    'Не изменяйте ее в редакторе исходного кода.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim Employee_codeLabel As System.Windows.Forms.Label
        Dim FIOLabel As System.Windows.Forms.Label
        Dim AgeLabel As System.Windows.Forms.Label
        Dim AddressLabel As System.Windows.Forms.Label
        Dim Post_codeLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form2))
        Dim PhoneLabel2 As System.Windows.Forms.Label
        Dim Passport_dataLabel1 As System.Windows.Forms.Label
        Dim GenderLabel1 As System.Windows.Forms.Label
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button7 = New System.Windows.Forms.Button()
        Me.Button8 = New System.Windows.Forms.Button()
        Me.Button9 = New System.Windows.Forms.Button()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.BankDataSet = New Bank.BankDataSet()
        Me.Workers1BindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Workers1TableAdapter = New Bank.BankDataSetTableAdapters.Workers1TableAdapter()
        Me.TableAdapterManager = New Bank.BankDataSetTableAdapters.TableAdapterManager()
        Me.Employee_codeTextBox = New System.Windows.Forms.TextBox()
        Me.FIOTextBox = New System.Windows.Forms.TextBox()
        Me.AgeTextBox = New System.Windows.Forms.TextBox()
        Me.AddressTextBox = New System.Windows.Forms.TextBox()
        Me.Post_codeTextBox = New System.Windows.Forms.TextBox()
        Me.BankDataSetBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Workers1BindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.Workers1BindingSource2 = New System.Windows.Forms.BindingSource(Me.components)
        Me.Workers1BindingSource3 = New System.Windows.Forms.BindingSource(Me.components)
        Me.PhoneMaskedTextBox = New System.Windows.Forms.MaskedTextBox()
        Me.Passport_dataMaskedTextBox = New System.Windows.Forms.MaskedTextBox()
        Me.GenderComboBox = New System.Windows.Forms.ComboBox()
        Employee_codeLabel = New System.Windows.Forms.Label()
        FIOLabel = New System.Windows.Forms.Label()
        AgeLabel = New System.Windows.Forms.Label()
        AddressLabel = New System.Windows.Forms.Label()
        Post_codeLabel = New System.Windows.Forms.Label()
        PhoneLabel2 = New System.Windows.Forms.Label()
        Passport_dataLabel1 = New System.Windows.Forms.Label()
        GenderLabel1 = New System.Windows.Forms.Label()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BankDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Workers1BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BankDataSetBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Workers1BindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Workers1BindingSource2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Workers1BindingSource3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Employee_codeLabel
        '
        Employee_codeLabel.AutoSize = True
        Employee_codeLabel.Location = New System.Drawing.Point(386, 186)
        Employee_codeLabel.Name = "Employee_codeLabel"
        Employee_codeLabel.Size = New System.Drawing.Size(83, 13)
        Employee_codeLabel.TabIndex = 79
        Employee_codeLabel.Text = "Employee code:"
        '
        'FIOLabel
        '
        FIOLabel.AutoSize = True
        FIOLabel.Location = New System.Drawing.Point(41, 68)
        FIOLabel.Name = "FIOLabel"
        FIOLabel.Size = New System.Drawing.Size(27, 13)
        FIOLabel.TabIndex = 80
        FIOLabel.Text = "FIO:"
        '
        'AgeLabel
        '
        AgeLabel.AutoSize = True
        AgeLabel.Location = New System.Drawing.Point(41, 125)
        AgeLabel.Name = "AgeLabel"
        AgeLabel.Size = New System.Drawing.Size(29, 13)
        AgeLabel.TabIndex = 81
        AgeLabel.Text = "Age:"
        '
        'AddressLabel
        '
        AddressLabel.AutoSize = True
        AddressLabel.Location = New System.Drawing.Point(41, 244)
        AddressLabel.Name = "AddressLabel"
        AddressLabel.Size = New System.Drawing.Size(48, 13)
        AddressLabel.TabIndex = 83
        AddressLabel.Text = "Address:"
        '
        'Post_codeLabel
        '
        Post_codeLabel.AutoSize = True
        Post_codeLabel.Location = New System.Drawing.Point(41, 445)
        Post_codeLabel.Name = "Post_codeLabel"
        Post_codeLabel.Size = New System.Drawing.Size(58, 13)
        Post_codeLabel.TabIndex = 86
        Post_codeLabel.Text = "Post code:"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(20, 487)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(69, 28)
        Me.Button1.TabIndex = 78
        Me.Button1.Text = "Таблица"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button7
        '
        Me.Button7.Location = New System.Drawing.Point(113, 520)
        Me.Button7.Name = "Button7"
        Me.Button7.Size = New System.Drawing.Size(69, 29)
        Me.Button7.TabIndex = 71
        Me.Button7.Text = "Сохранить"
        Me.Button7.UseVisualStyleBackColor = True
        '
        'Button8
        '
        Me.Button8.Location = New System.Drawing.Point(210, 521)
        Me.Button8.Name = "Button8"
        Me.Button8.Size = New System.Drawing.Size(69, 28)
        Me.Button8.TabIndex = 70
        Me.Button8.Text = "Удалить"
        Me.Button8.UseVisualStyleBackColor = True
        '
        'Button9
        '
        Me.Button9.Location = New System.Drawing.Point(20, 521)
        Me.Button9.Name = "Button9"
        Me.Button9.Size = New System.Drawing.Size(69, 28)
        Me.Button9.TabIndex = 69
        Me.Button9.Text = "Добавить"
        Me.Button9.UseVisualStyleBackColor = True
        '
        'Button5
        '
        Me.Button5.Image = CType(resources.GetObject("Button5.Image"), System.Drawing.Image)
        Me.Button5.Location = New System.Drawing.Point(492, 508)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(36, 41)
        Me.Button5.TabIndex = 68
        Me.Button5.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.Image = CType(resources.GetObject("Button4.Image"), System.Drawing.Image)
        Me.Button4.Location = New System.Drawing.Point(557, 508)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(36, 41)
        Me.Button4.TabIndex = 67
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Image = CType(resources.GetObject("Button3.Image"), System.Drawing.Image)
        Me.Button3.Location = New System.Drawing.Point(450, 508)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(36, 41)
        Me.Button3.TabIndex = 66
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button6
        '
        Me.Button6.Image = CType(resources.GetObject("Button6.Image"), System.Drawing.Image)
        Me.Button6.Location = New System.Drawing.Point(386, 508)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(36, 41)
        Me.Button6.TabIndex = 65
        Me.Button6.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(450, 24)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(154, 147)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.PictureBox1.TabIndex = 64
        Me.PictureBox1.TabStop = False
        '
        'BankDataSet
        '
        Me.BankDataSet.DataSetName = "BankDataSet"
        Me.BankDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Workers1BindingSource
        '
        Me.Workers1BindingSource.DataMember = "Workers1"
        Me.Workers1BindingSource.DataSource = Me.BankDataSet
        '
        'Workers1TableAdapter
        '
        Me.Workers1TableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.ContributionsTableAdapter = Nothing
        Me.TableAdapterManager.ContributorsTableAdapter = Nothing
        Me.TableAdapterManager.CurrencyTableAdapter = Nothing
        Me.TableAdapterManager.PositionsTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = Bank.BankDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager.Workers1TableAdapter = Me.Workers1TableAdapter
        '
        'Employee_codeTextBox
        '
        Me.Employee_codeTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Workers1BindingSource, "Employee code", True))
        Me.Employee_codeTextBox.Location = New System.Drawing.Point(475, 183)
        Me.Employee_codeTextBox.Name = "Employee_codeTextBox"
        Me.Employee_codeTextBox.Size = New System.Drawing.Size(100, 20)
        Me.Employee_codeTextBox.TabIndex = 80
        '
        'FIOTextBox
        '
        Me.FIOTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Workers1BindingSource, "FIO", True))
        Me.FIOTextBox.Location = New System.Drawing.Point(141, 65)
        Me.FIOTextBox.Name = "FIOTextBox"
        Me.FIOTextBox.Size = New System.Drawing.Size(166, 20)
        Me.FIOTextBox.TabIndex = 81
        '
        'AgeTextBox
        '
        Me.AgeTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Workers1BindingSource, "Age", True))
        Me.AgeTextBox.Location = New System.Drawing.Point(141, 122)
        Me.AgeTextBox.Name = "AgeTextBox"
        Me.AgeTextBox.Size = New System.Drawing.Size(166, 20)
        Me.AgeTextBox.TabIndex = 82
        '
        'AddressTextBox
        '
        Me.AddressTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Workers1BindingSource, "Address", True))
        Me.AddressTextBox.Location = New System.Drawing.Point(141, 241)
        Me.AddressTextBox.Multiline = True
        Me.AddressTextBox.Name = "AddressTextBox"
        Me.AddressTextBox.Size = New System.Drawing.Size(166, 44)
        Me.AddressTextBox.TabIndex = 84
        '
        'Post_codeTextBox
        '
        Me.Post_codeTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Workers1BindingSource, "Post code", True))
        Me.Post_codeTextBox.Location = New System.Drawing.Point(141, 442)
        Me.Post_codeTextBox.Name = "Post_codeTextBox"
        Me.Post_codeTextBox.Size = New System.Drawing.Size(166, 20)
        Me.Post_codeTextBox.TabIndex = 87
        '
        'BankDataSetBindingSource
        '
        Me.BankDataSetBindingSource.DataSource = Me.BankDataSet
        Me.BankDataSetBindingSource.Position = 0
        '
        'Workers1BindingSource1
        '
        Me.Workers1BindingSource1.DataMember = "Workers1"
        Me.Workers1BindingSource1.DataSource = Me.BankDataSetBindingSource
        '
        'Workers1BindingSource2
        '
        Me.Workers1BindingSource2.DataMember = "Workers1"
        Me.Workers1BindingSource2.DataSource = Me.BankDataSetBindingSource
        '
        'Workers1BindingSource3
        '
        Me.Workers1BindingSource3.DataMember = "Workers1"
        Me.Workers1BindingSource3.DataSource = Me.BankDataSetBindingSource
        '
        'PhoneLabel2
        '
        PhoneLabel2.AutoSize = True
        PhoneLabel2.Location = New System.Drawing.Point(41, 324)
        PhoneLabel2.Name = "PhoneLabel2"
        PhoneLabel2.Size = New System.Drawing.Size(41, 13)
        PhoneLabel2.TabIndex = 91
        PhoneLabel2.Text = "Phone:"
        '
        'PhoneMaskedTextBox
        '
        Me.PhoneMaskedTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Workers1BindingSource, "Phone", True))
        Me.PhoneMaskedTextBox.Location = New System.Drawing.Point(141, 321)
        Me.PhoneMaskedTextBox.Mask = "+38(999)000-00-00"
        Me.PhoneMaskedTextBox.Name = "PhoneMaskedTextBox"
        Me.PhoneMaskedTextBox.Size = New System.Drawing.Size(166, 20)
        Me.PhoneMaskedTextBox.TabIndex = 92
        '
        'Passport_dataLabel1
        '
        Passport_dataLabel1.AutoSize = True
        Passport_dataLabel1.Location = New System.Drawing.Point(41, 384)
        Passport_dataLabel1.Name = "Passport_dataLabel1"
        Passport_dataLabel1.Size = New System.Drawing.Size(75, 13)
        Passport_dataLabel1.TabIndex = 92
        Passport_dataLabel1.Text = "Passport data:"
        '
        'Passport_dataMaskedTextBox
        '
        Me.Passport_dataMaskedTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Workers1BindingSource, "Passport data", True))
        Me.Passport_dataMaskedTextBox.Location = New System.Drawing.Point(141, 381)
        Me.Passport_dataMaskedTextBox.Mask = "ЄД-0000000"
        Me.Passport_dataMaskedTextBox.Name = "Passport_dataMaskedTextBox"
        Me.Passport_dataMaskedTextBox.Size = New System.Drawing.Size(166, 20)
        Me.Passport_dataMaskedTextBox.TabIndex = 93
        '
        'GenderLabel1
        '
        GenderLabel1.AutoSize = True
        GenderLabel1.Location = New System.Drawing.Point(41, 181)
        GenderLabel1.Name = "GenderLabel1"
        GenderLabel1.Size = New System.Drawing.Size(45, 13)
        GenderLabel1.TabIndex = 93
        GenderLabel1.Text = "Gender:"
        '
        'GenderComboBox
        '
        Me.GenderComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Workers1BindingSource, "Gender", True))
        Me.GenderComboBox.FormattingEnabled = True
        Me.GenderComboBox.Items.AddRange(New Object() {"Мужской", "Женский"})
        Me.GenderComboBox.Location = New System.Drawing.Point(141, 178)
        Me.GenderComboBox.Name = "GenderComboBox"
        Me.GenderComboBox.Size = New System.Drawing.Size(166, 21)
        Me.GenderComboBox.TabIndex = 94
        '
        'Form14
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(630, 573)
        Me.Controls.Add(GenderLabel1)
        Me.Controls.Add(Me.GenderComboBox)
        Me.Controls.Add(Passport_dataLabel1)
        Me.Controls.Add(Me.Passport_dataMaskedTextBox)
        Me.Controls.Add(PhoneLabel2)
        Me.Controls.Add(Me.PhoneMaskedTextBox)
        Me.Controls.Add(Post_codeLabel)
        Me.Controls.Add(Me.Post_codeTextBox)
        Me.Controls.Add(AddressLabel)
        Me.Controls.Add(Me.AddressTextBox)
        Me.Controls.Add(AgeLabel)
        Me.Controls.Add(Me.AgeTextBox)
        Me.Controls.Add(FIOLabel)
        Me.Controls.Add(Me.FIOTextBox)
        Me.Controls.Add(Employee_codeLabel)
        Me.Controls.Add(Me.Employee_codeTextBox)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Button7)
        Me.Controls.Add(Me.Button8)
        Me.Controls.Add(Me.Button9)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button6)
        Me.Controls.Add(Me.PictureBox1)
        Me.Name = "Form14"
        Me.Text = "Form14"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BankDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Workers1BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BankDataSetBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Workers1BindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Workers1BindingSource2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Workers1BindingSource3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Button1 As Button
    Friend WithEvents Button7 As Button
    Friend WithEvents Button8 As Button
    Friend WithEvents Button9 As Button
    Friend WithEvents Button5 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Button6 As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents BankDataSet As BankDataSet
    Friend WithEvents Workers1BindingSource As BindingSource
    Friend WithEvents Workers1TableAdapter As BankDataSetTableAdapters.Workers1TableAdapter
    Friend WithEvents TableAdapterManager As BankDataSetTableAdapters.TableAdapterManager
    Friend WithEvents Employee_codeTextBox As TextBox
    Friend WithEvents FIOTextBox As TextBox
    Friend WithEvents AgeTextBox As TextBox
    Friend WithEvents AddressTextBox As TextBox
    Friend WithEvents Post_codeTextBox As TextBox
    Friend WithEvents BankDataSetBindingSource As BindingSource
    Friend WithEvents Workers1BindingSource1 As BindingSource
    Friend WithEvents Workers1BindingSource2 As BindingSource
    Friend WithEvents Workers1BindingSource3 As BindingSource
    Friend WithEvents PhoneMaskedTextBox As MaskedTextBox
    Friend WithEvents Passport_dataMaskedTextBox As MaskedTextBox
    Friend WithEvents GenderComboBox As ComboBox
End Class
