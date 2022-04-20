<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
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
        Dim Employee_codeLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form2))
        Dim FIOLabel As System.Windows.Forms.Label
        Dim AgeLabel As System.Windows.Forms.Label
        Dim AddressLabel As System.Windows.Forms.Label
        Dim PhoneLabel As System.Windows.Forms.Label
        Dim Passport_dataLabel As System.Windows.Forms.Label
        Dim GenderLabel1 As System.Windows.Forms.Label
        Dim Post_codeLabel As System.Windows.Forms.Label
        Me.BankDataSet = New Bank.BankDataSet()
        Me.Workers1BindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Workers1TableAdapter = New Bank.BankDataSetTableAdapters.Workers1TableAdapter()
        Me.TableAdapterManager = New Bank.BankDataSetTableAdapters.TableAdapterManager()
        Me.Employee_codeTextBox = New System.Windows.Forms.TextBox()
        Me.FIOTextBox = New System.Windows.Forms.TextBox()
        Me.AgeTextBox = New System.Windows.Forms.TextBox()
        Me.AddressTextBox = New System.Windows.Forms.TextBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.Button7 = New System.Windows.Forms.Button()
        Me.Button8 = New System.Windows.Forms.Button()
        Me.Button9 = New System.Windows.Forms.Button()
        Me.MaskedTextBox1 = New System.Windows.Forms.MaskedTextBox()
        Me.GenderComboBox = New System.Windows.Forms.ComboBox()
        Me.PositionsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DepartmentOfCaldasBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.FKContributorsWorkers1BindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ContributorsTableAdapter = New Bank.BankDataSetTableAdapters.ContributorsTableAdapter()
        Me.PositionsTableAdapter = New Bank.BankDataSetTableAdapters.PositionsTableAdapter()
        Me.FKWorkers1Positions1BindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Department_of_CaldasTableAdapter = New Bank.BankDataSetTableAdapters.Department_of_CaldasTableAdapter()
        Me.DepartmentOfCaldasBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.MaskedTextBox2 = New System.Windows.Forms.MaskedTextBox()
        Me.Post_codeComboBox1 = New System.Windows.Forms.ComboBox()
        Me.PositionsBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.DepartmentOfCaldasBindingSource2 = New System.Windows.Forms.BindingSource(Me.components)
        Me.Workers1BindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Employee_codeLabel = New System.Windows.Forms.Label()
        FIOLabel = New System.Windows.Forms.Label()
        AgeLabel = New System.Windows.Forms.Label()
        AddressLabel = New System.Windows.Forms.Label()
        PhoneLabel = New System.Windows.Forms.Label()
        Passport_dataLabel = New System.Windows.Forms.Label()
        GenderLabel1 = New System.Windows.Forms.Label()
        Post_codeLabel = New System.Windows.Forms.Label()
        CType(Me.BankDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Workers1BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PositionsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DepartmentOfCaldasBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FKContributorsWorkers1BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FKWorkers1Positions1BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DepartmentOfCaldasBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PositionsBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DepartmentOfCaldasBindingSource2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Workers1BindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Employee_codeLabel
        '
        Employee_codeLabel.AutoSize = True
        Employee_codeLabel.Image = CType(resources.GetObject("Employee_codeLabel.Image"), System.Drawing.Image)
        Employee_codeLabel.Location = New System.Drawing.Point(386, 186)
        Employee_codeLabel.Name = "Employee_codeLabel"
        Employee_codeLabel.Size = New System.Drawing.Size(83, 13)
        Employee_codeLabel.TabIndex = 1
        Employee_codeLabel.Text = "Employee code:"
        '
        'FIOLabel
        '
        FIOLabel.AutoSize = True
        FIOLabel.Image = CType(resources.GetObject("FIOLabel.Image"), System.Drawing.Image)
        FIOLabel.Location = New System.Drawing.Point(41, 68)
        FIOLabel.Name = "FIOLabel"
        FIOLabel.Size = New System.Drawing.Size(27, 13)
        FIOLabel.TabIndex = 3
        FIOLabel.Text = "FIO:"
        '
        'AgeLabel
        '
        AgeLabel.AutoSize = True
        AgeLabel.Image = CType(resources.GetObject("AgeLabel.Image"), System.Drawing.Image)
        AgeLabel.Location = New System.Drawing.Point(41, 125)
        AgeLabel.Name = "AgeLabel"
        AgeLabel.Size = New System.Drawing.Size(29, 13)
        AgeLabel.TabIndex = 5
        AgeLabel.Text = "Age:"
        '
        'AddressLabel
        '
        AddressLabel.AutoSize = True
        AddressLabel.Image = CType(resources.GetObject("AddressLabel.Image"), System.Drawing.Image)
        AddressLabel.Location = New System.Drawing.Point(41, 244)
        AddressLabel.Name = "AddressLabel"
        AddressLabel.Size = New System.Drawing.Size(48, 13)
        AddressLabel.TabIndex = 9
        AddressLabel.Text = "Address:"
        '
        'PhoneLabel
        '
        PhoneLabel.AutoSize = True
        PhoneLabel.Image = CType(resources.GetObject("PhoneLabel.Image"), System.Drawing.Image)
        PhoneLabel.Location = New System.Drawing.Point(41, 324)
        PhoneLabel.Name = "PhoneLabel"
        PhoneLabel.Size = New System.Drawing.Size(41, 13)
        PhoneLabel.TabIndex = 11
        PhoneLabel.Text = "Phone:"
        '
        'Passport_dataLabel
        '
        Passport_dataLabel.AutoSize = True
        Passport_dataLabel.Image = CType(resources.GetObject("Passport_dataLabel.Image"), System.Drawing.Image)
        Passport_dataLabel.Location = New System.Drawing.Point(41, 384)
        Passport_dataLabel.Name = "Passport_dataLabel"
        Passport_dataLabel.Size = New System.Drawing.Size(75, 13)
        Passport_dataLabel.TabIndex = 13
        Passport_dataLabel.Text = "Passport data:"
        '
        'GenderLabel1
        '
        GenderLabel1.AutoSize = True
        GenderLabel1.Image = CType(resources.GetObject("GenderLabel1.Image"), System.Drawing.Image)
        GenderLabel1.Location = New System.Drawing.Point(41, 181)
        GenderLabel1.Name = "GenderLabel1"
        GenderLabel1.Size = New System.Drawing.Size(45, 13)
        GenderLabel1.TabIndex = 48
        GenderLabel1.Text = "Gender:"
        '
        'Post_codeLabel
        '
        Post_codeLabel.AutoSize = True
        Post_codeLabel.Image = CType(resources.GetObject("Post_codeLabel.Image"), System.Drawing.Image)
        Post_codeLabel.Location = New System.Drawing.Point(41, 445)
        Post_codeLabel.Name = "Post_codeLabel"
        Post_codeLabel.Size = New System.Drawing.Size(58, 13)
        Post_codeLabel.TabIndex = 51
        Post_codeLabel.Text = "Post code:"
        AddHandler Post_codeLabel.Click, AddressOf Me.Post_codeLabel_Click
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
        Me.Employee_codeTextBox.TabIndex = 2
        '
        'FIOTextBox
        '
        Me.FIOTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Workers1BindingSource, "FIO", True))
        Me.FIOTextBox.Location = New System.Drawing.Point(141, 65)
        Me.FIOTextBox.Name = "FIOTextBox"
        Me.FIOTextBox.Size = New System.Drawing.Size(166, 20)
        Me.FIOTextBox.TabIndex = 4
        '
        'AgeTextBox
        '
        Me.AgeTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Workers1BindingSource, "Age", True))
        Me.AgeTextBox.Location = New System.Drawing.Point(141, 122)
        Me.AgeTextBox.Name = "AgeTextBox"
        Me.AgeTextBox.Size = New System.Drawing.Size(166, 20)
        Me.AgeTextBox.TabIndex = 6
        '
        'AddressTextBox
        '
        Me.AddressTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Workers1BindingSource, "Address", True))
        Me.AddressTextBox.Location = New System.Drawing.Point(141, 241)
        Me.AddressTextBox.Multiline = True
        Me.AddressTextBox.Name = "AddressTextBox"
        Me.AddressTextBox.Size = New System.Drawing.Size(166, 44)
        Me.AddressTextBox.TabIndex = 10
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(445, 24)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(154, 147)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.PictureBox1.TabIndex = 17
        Me.PictureBox1.TabStop = False
        '
        'Button5
        '
        Me.Button5.Image = CType(resources.GetObject("Button5.Image"), System.Drawing.Image)
        Me.Button5.Location = New System.Drawing.Point(487, 508)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(36, 41)
        Me.Button5.TabIndex = 44
        Me.Button5.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.Image = CType(resources.GetObject("Button4.Image"), System.Drawing.Image)
        Me.Button4.Location = New System.Drawing.Point(552, 508)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(36, 41)
        Me.Button4.TabIndex = 43
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Image = CType(resources.GetObject("Button3.Image"), System.Drawing.Image)
        Me.Button3.Location = New System.Drawing.Point(445, 508)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(36, 41)
        Me.Button3.TabIndex = 42
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button6
        '
        Me.Button6.Image = CType(resources.GetObject("Button6.Image"), System.Drawing.Image)
        Me.Button6.Location = New System.Drawing.Point(386, 508)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(36, 41)
        Me.Button6.TabIndex = 41
        Me.Button6.UseVisualStyleBackColor = True
        '
        'Button7
        '
        Me.Button7.Location = New System.Drawing.Point(113, 520)
        Me.Button7.Name = "Button7"
        Me.Button7.Size = New System.Drawing.Size(69, 29)
        Me.Button7.TabIndex = 47
        Me.Button7.Text = "Сохранить"
        Me.Button7.UseVisualStyleBackColor = True
        '
        'Button8
        '
        Me.Button8.Location = New System.Drawing.Point(210, 521)
        Me.Button8.Name = "Button8"
        Me.Button8.Size = New System.Drawing.Size(69, 28)
        Me.Button8.TabIndex = 46
        Me.Button8.Text = "Удалить"
        Me.Button8.UseVisualStyleBackColor = True
        '
        'Button9
        '
        Me.Button9.Location = New System.Drawing.Point(20, 521)
        Me.Button9.Name = "Button9"
        Me.Button9.Size = New System.Drawing.Size(69, 28)
        Me.Button9.TabIndex = 45
        Me.Button9.Text = "Добавить"
        Me.Button9.UseVisualStyleBackColor = True
        '
        'MaskedTextBox1
        '
        Me.MaskedTextBox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Workers1BindingSource, "Phone", True))
        Me.MaskedTextBox1.Location = New System.Drawing.Point(141, 321)
        Me.MaskedTextBox1.Mask = "+38(999)000-00-00"
        Me.MaskedTextBox1.Name = "MaskedTextBox1"
        Me.MaskedTextBox1.Size = New System.Drawing.Size(166, 20)
        Me.MaskedTextBox1.TabIndex = 48
        '
        'GenderComboBox
        '
        Me.GenderComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Workers1BindingSource, "Gender", True))
        Me.GenderComboBox.FormattingEnabled = True
        Me.GenderComboBox.Items.AddRange(New Object() {"Мужской", "Женский"})
        Me.GenderComboBox.Location = New System.Drawing.Point(141, 178)
        Me.GenderComboBox.Name = "GenderComboBox"
        Me.GenderComboBox.Size = New System.Drawing.Size(166, 21)
        Me.GenderComboBox.TabIndex = 49
        '
        'PositionsBindingSource
        '
        Me.PositionsBindingSource.DataMember = "Positions"
        Me.PositionsBindingSource.DataSource = Me.BankDataSet
        '
        'DepartmentOfCaldasBindingSource
        '
        Me.DepartmentOfCaldasBindingSource.DataMember = "Department of Caldas"
        Me.DepartmentOfCaldasBindingSource.DataSource = Me.BankDataSet
        '
        'FKContributorsWorkers1BindingSource
        '
        Me.FKContributorsWorkers1BindingSource.DataMember = "FK_Contributors_Workers1"
        Me.FKContributorsWorkers1BindingSource.DataSource = Me.Workers1BindingSource
        '
        'ContributorsTableAdapter
        '
        Me.ContributorsTableAdapter.ClearBeforeFill = True
        '
        'PositionsTableAdapter
        '
        Me.PositionsTableAdapter.ClearBeforeFill = True
        '
        'FKWorkers1Positions1BindingSource
        '
        Me.FKWorkers1Positions1BindingSource.DataMember = "FK_Workers1_Positions1"
        Me.FKWorkers1Positions1BindingSource.DataSource = Me.PositionsBindingSource
        '
        'Department_of_CaldasTableAdapter
        '
        Me.Department_of_CaldasTableAdapter.ClearBeforeFill = True
        '
        'DepartmentOfCaldasBindingSource1
        '
        Me.DepartmentOfCaldasBindingSource1.DataMember = "Department of Caldas"
        Me.DepartmentOfCaldasBindingSource1.DataSource = Me.BankDataSet
        '
        'MaskedTextBox2
        '
        Me.MaskedTextBox2.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Workers1BindingSource, "Passport data", True))
        Me.MaskedTextBox2.Location = New System.Drawing.Point(141, 381)
        Me.MaskedTextBox2.Mask = "ЄД-0000000"
        Me.MaskedTextBox2.Name = "MaskedTextBox2"
        Me.MaskedTextBox2.Size = New System.Drawing.Size(166, 20)
        Me.MaskedTextBox2.TabIndex = 51
        '
        'Post_codeComboBox1
        '
        Me.Post_codeComboBox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Workers1BindingSource, "Post code", True))
        Me.Post_codeComboBox1.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.PositionsBindingSource1, "Post code", True))
        Me.Post_codeComboBox1.DataSource = Me.DepartmentOfCaldasBindingSource2
        Me.Post_codeComboBox1.DisplayMember = "Name of the post"
        Me.Post_codeComboBox1.FormattingEnabled = True
        Me.Post_codeComboBox1.Location = New System.Drawing.Point(141, 442)
        Me.Post_codeComboBox1.Name = "Post_codeComboBox1"
        Me.Post_codeComboBox1.Size = New System.Drawing.Size(166, 21)
        Me.Post_codeComboBox1.TabIndex = 52
        Me.Post_codeComboBox1.ValueMember = "Name of the post"
        '
        'PositionsBindingSource1
        '
        Me.PositionsBindingSource1.DataMember = "Positions"
        Me.PositionsBindingSource1.DataSource = Me.BankDataSet
        '
        'DepartmentOfCaldasBindingSource2
        '
        Me.DepartmentOfCaldasBindingSource2.DataMember = "Department of Caldas"
        Me.DepartmentOfCaldasBindingSource2.DataSource = Me.BankDataSet
        '
        'Workers1BindingSource1
        '
        Me.Workers1BindingSource1.DataMember = "Workers1"
        Me.Workers1BindingSource1.DataSource = Me.BankDataSet
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(20, 487)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(69, 28)
        Me.Button1.TabIndex = 53
        Me.Button1.Text = "Таблица"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(113, 487)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(69, 28)
        Me.Button2.TabIndex = 54
        Me.Button2.Text = "Звіти"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(625, 569)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Post_codeLabel)
        Me.Controls.Add(Me.Post_codeComboBox1)
        Me.Controls.Add(Me.MaskedTextBox2)
        Me.Controls.Add(GenderLabel1)
        Me.Controls.Add(Me.GenderComboBox)
        Me.Controls.Add(Me.MaskedTextBox1)
        Me.Controls.Add(Me.Button7)
        Me.Controls.Add(Me.Button8)
        Me.Controls.Add(Me.Button9)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button6)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Passport_dataLabel)
        Me.Controls.Add(PhoneLabel)
        Me.Controls.Add(AddressLabel)
        Me.Controls.Add(Me.AddressTextBox)
        Me.Controls.Add(AgeLabel)
        Me.Controls.Add(Me.AgeTextBox)
        Me.Controls.Add(FIOLabel)
        Me.Controls.Add(Me.FIOTextBox)
        Me.Controls.Add(Employee_codeLabel)
        Me.Controls.Add(Me.Employee_codeTextBox)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Name = "Form2"
        Me.Text = "Form2"
        CType(Me.BankDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Workers1BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PositionsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DepartmentOfCaldasBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FKContributorsWorkers1BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FKWorkers1Positions1BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DepartmentOfCaldasBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PositionsBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DepartmentOfCaldasBindingSource2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Workers1BindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents BankDataSet As Bank.BankDataSet
    Friend WithEvents Workers1BindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Workers1TableAdapter As Bank.BankDataSetTableAdapters.Workers1TableAdapter
    Friend WithEvents TableAdapterManager As Bank.BankDataSetTableAdapters.TableAdapterManager
    Friend WithEvents Employee_codeTextBox As System.Windows.Forms.TextBox
    Friend WithEvents FIOTextBox As System.Windows.Forms.TextBox
    Friend WithEvents AgeTextBox As System.Windows.Forms.TextBox
    Friend WithEvents AddressTextBox As System.Windows.Forms.TextBox
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Button5 As System.Windows.Forms.Button
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Button6 As System.Windows.Forms.Button
    Friend WithEvents Button7 As System.Windows.Forms.Button
    Friend WithEvents Button8 As System.Windows.Forms.Button
    Friend WithEvents Button9 As System.Windows.Forms.Button
    Friend WithEvents MaskedTextBox1 As System.Windows.Forms.MaskedTextBox
    Friend WithEvents GenderComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents FKContributorsWorkers1BindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ContributorsTableAdapter As Bank.BankDataSetTableAdapters.ContributorsTableAdapter
    Friend WithEvents PositionsBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents PositionsTableAdapter As Bank.BankDataSetTableAdapters.PositionsTableAdapter
    Friend WithEvents FKWorkers1Positions1BindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents DepartmentOfCaldasBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Department_of_CaldasTableAdapter As Bank.BankDataSetTableAdapters.Department_of_CaldasTableAdapter
    Friend WithEvents DepartmentOfCaldasBindingSource1 As System.Windows.Forms.BindingSource
    Friend WithEvents MaskedTextBox2 As System.Windows.Forms.MaskedTextBox
    Friend WithEvents Post_codeComboBox1 As System.Windows.Forms.ComboBox
    Friend WithEvents DepartmentOfCaldasBindingSource2 As System.Windows.Forms.BindingSource
    Friend WithEvents Workers1BindingSource1 As System.Windows.Forms.BindingSource
    Friend WithEvents PositionsBindingSource1 As System.Windows.Forms.BindingSource
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
End Class
