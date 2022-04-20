<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form5
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
        Dim Post_codeLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form5))
        Dim Name_of_the_postLabel As System.Windows.Forms.Label
        Dim SalaryLabel As System.Windows.Forms.Label
        Dim DutiesLabel As System.Windows.Forms.Label
        Dim RequirementsLabel As System.Windows.Forms.Label
        Me.BankDataSet = New Bank.BankDataSet()
        Me.PositionsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.PositionsTableAdapter = New Bank.BankDataSetTableAdapters.PositionsTableAdapter()
        Me.TableAdapterManager = New Bank.BankDataSetTableAdapters.TableAdapterManager()
        Me.Post_codeTextBox = New System.Windows.Forms.TextBox()
        Me.Name_of_the_postTextBox = New System.Windows.Forms.TextBox()
        Me.SalaryTextBox = New System.Windows.Forms.TextBox()
        Me.DutiesTextBox = New System.Windows.Forms.TextBox()
        Me.RequirementsTextBox = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button7 = New System.Windows.Forms.Button()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button8 = New System.Windows.Forms.Button()
        Post_codeLabel = New System.Windows.Forms.Label()
        Name_of_the_postLabel = New System.Windows.Forms.Label()
        SalaryLabel = New System.Windows.Forms.Label()
        DutiesLabel = New System.Windows.Forms.Label()
        RequirementsLabel = New System.Windows.Forms.Label()
        CType(Me.BankDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PositionsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Post_codeLabel
        '
        Post_codeLabel.AutoSize = True
        Post_codeLabel.Image = CType(resources.GetObject("Post_codeLabel.Image"), System.Drawing.Image)
        Post_codeLabel.Location = New System.Drawing.Point(107, 76)
        Post_codeLabel.Name = "Post_codeLabel"
        Post_codeLabel.Size = New System.Drawing.Size(58, 13)
        Post_codeLabel.TabIndex = 1
        Post_codeLabel.Text = "Post code:"
        '
        'Name_of_the_postLabel
        '
        Name_of_the_postLabel.AutoSize = True
        Name_of_the_postLabel.Image = CType(resources.GetObject("Name_of_the_postLabel.Image"), System.Drawing.Image)
        Name_of_the_postLabel.Location = New System.Drawing.Point(74, 119)
        Name_of_the_postLabel.Name = "Name_of_the_postLabel"
        Name_of_the_postLabel.Size = New System.Drawing.Size(91, 13)
        Name_of_the_postLabel.TabIndex = 3
        Name_of_the_postLabel.Text = "Name of the post:"
        '
        'SalaryLabel
        '
        SalaryLabel.AutoSize = True
        SalaryLabel.Image = CType(resources.GetObject("SalaryLabel.Image"), System.Drawing.Image)
        SalaryLabel.Location = New System.Drawing.Point(126, 167)
        SalaryLabel.Name = "SalaryLabel"
        SalaryLabel.Size = New System.Drawing.Size(39, 13)
        SalaryLabel.TabIndex = 5
        SalaryLabel.Text = "Salary:"
        '
        'DutiesLabel
        '
        DutiesLabel.AutoSize = True
        DutiesLabel.Image = CType(resources.GetObject("DutiesLabel.Image"), System.Drawing.Image)
        DutiesLabel.Location = New System.Drawing.Point(125, 213)
        DutiesLabel.Name = "DutiesLabel"
        DutiesLabel.Size = New System.Drawing.Size(40, 13)
        DutiesLabel.TabIndex = 7
        DutiesLabel.Text = "Duties:"
        '
        'RequirementsLabel
        '
        RequirementsLabel.AutoSize = True
        RequirementsLabel.Image = CType(resources.GetObject("RequirementsLabel.Image"), System.Drawing.Image)
        RequirementsLabel.Location = New System.Drawing.Point(90, 288)
        RequirementsLabel.Name = "RequirementsLabel"
        RequirementsLabel.Size = New System.Drawing.Size(75, 13)
        RequirementsLabel.TabIndex = 9
        RequirementsLabel.Text = "Requirements:"
        '
        'BankDataSet
        '
        Me.BankDataSet.DataSetName = "BankDataSet"
        Me.BankDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'PositionsBindingSource
        '
        Me.PositionsBindingSource.DataMember = "Positions"
        Me.PositionsBindingSource.DataSource = Me.BankDataSet
        '
        'PositionsTableAdapter
        '
        Me.PositionsTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.ContributionsTableAdapter = Nothing
        Me.TableAdapterManager.ContributorsTableAdapter = Nothing
        Me.TableAdapterManager.CurrencyTableAdapter = Nothing
        Me.TableAdapterManager.PositionsTableAdapter = Me.PositionsTableAdapter
        Me.TableAdapterManager.UpdateOrder = Bank.BankDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager.Workers1TableAdapter = Nothing
        '
        'Post_codeTextBox
        '
        Me.Post_codeTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PositionsBindingSource, "Post code", True))
        Me.Post_codeTextBox.Location = New System.Drawing.Point(171, 73)
        Me.Post_codeTextBox.Name = "Post_codeTextBox"
        Me.Post_codeTextBox.Size = New System.Drawing.Size(246, 20)
        Me.Post_codeTextBox.TabIndex = 2
        '
        'Name_of_the_postTextBox
        '
        Me.Name_of_the_postTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PositionsBindingSource, "Name of the post", True))
        Me.Name_of_the_postTextBox.Location = New System.Drawing.Point(171, 116)
        Me.Name_of_the_postTextBox.Name = "Name_of_the_postTextBox"
        Me.Name_of_the_postTextBox.Size = New System.Drawing.Size(246, 20)
        Me.Name_of_the_postTextBox.TabIndex = 4
        '
        'SalaryTextBox
        '
        Me.SalaryTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PositionsBindingSource, "Salary", True))
        Me.SalaryTextBox.Location = New System.Drawing.Point(171, 164)
        Me.SalaryTextBox.Name = "SalaryTextBox"
        Me.SalaryTextBox.Size = New System.Drawing.Size(246, 20)
        Me.SalaryTextBox.TabIndex = 6
        '
        'DutiesTextBox
        '
        Me.DutiesTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PositionsBindingSource, "Duties", True))
        Me.DutiesTextBox.Location = New System.Drawing.Point(171, 210)
        Me.DutiesTextBox.Multiline = True
        Me.DutiesTextBox.Name = "DutiesTextBox"
        Me.DutiesTextBox.Size = New System.Drawing.Size(246, 53)
        Me.DutiesTextBox.TabIndex = 8
        '
        'RequirementsTextBox
        '
        Me.RequirementsTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PositionsBindingSource, "Requirements", True))
        Me.RequirementsTextBox.Location = New System.Drawing.Point(171, 285)
        Me.RequirementsTextBox.Multiline = True
        Me.RequirementsTextBox.Name = "RequirementsTextBox"
        Me.RequirementsTextBox.Size = New System.Drawing.Size(246, 53)
        Me.RequirementsTextBox.TabIndex = 10
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Label1.Image = CType(resources.GetObject("Label1.Image"), System.Drawing.Image)
        Me.Label1.Location = New System.Drawing.Point(223, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(98, 29)
        Me.Label1.TabIndex = 11
        Me.Label1.Text = "Посади"
        '
        'Button5
        '
        Me.Button5.Image = CType(resources.GetObject("Button5.Image"), System.Drawing.Image)
        Me.Button5.Location = New System.Drawing.Point(286, 425)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(36, 41)
        Me.Button5.TabIndex = 36
        Me.Button5.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.Image = CType(resources.GetObject("Button4.Image"), System.Drawing.Image)
        Me.Button4.Location = New System.Drawing.Point(351, 425)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(36, 41)
        Me.Button4.TabIndex = 35
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Image = CType(resources.GetObject("Button2.Image"), System.Drawing.Image)
        Me.Button2.Location = New System.Drawing.Point(244, 425)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(36, 41)
        Me.Button2.TabIndex = 34
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Image = CType(resources.GetObject("Button1.Image"), System.Drawing.Image)
        Me.Button1.Location = New System.Drawing.Point(185, 425)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(36, 41)
        Me.Button1.TabIndex = 33
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button7
        '
        Me.Button7.Location = New System.Drawing.Point(496, 96)
        Me.Button7.Name = "Button7"
        Me.Button7.Size = New System.Drawing.Size(69, 29)
        Me.Button7.TabIndex = 39
        Me.Button7.Text = "Сохранить"
        Me.Button7.UseVisualStyleBackColor = True
        '
        'Button6
        '
        Me.Button6.Location = New System.Drawing.Point(496, 177)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(69, 28)
        Me.Button6.TabIndex = 38
        Me.Button6.Text = "Удалить"
        Me.Button6.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(496, 16)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(69, 32)
        Me.Button3.TabIndex = 37
        Me.Button3.Text = "Добавить"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button8
        '
        Me.Button8.Location = New System.Drawing.Point(496, 250)
        Me.Button8.Name = "Button8"
        Me.Button8.Size = New System.Drawing.Size(69, 28)
        Me.Button8.TabIndex = 45
        Me.Button8.Text = "Таблица"
        Me.Button8.UseVisualStyleBackColor = True
        '
        'Form5
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(577, 478)
        Me.Controls.Add(Me.Button8)
        Me.Controls.Add(Me.Button7)
        Me.Controls.Add(Me.Button6)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(RequirementsLabel)
        Me.Controls.Add(Me.RequirementsTextBox)
        Me.Controls.Add(DutiesLabel)
        Me.Controls.Add(Me.DutiesTextBox)
        Me.Controls.Add(SalaryLabel)
        Me.Controls.Add(Me.SalaryTextBox)
        Me.Controls.Add(Name_of_the_postLabel)
        Me.Controls.Add(Me.Name_of_the_postTextBox)
        Me.Controls.Add(Post_codeLabel)
        Me.Controls.Add(Me.Post_codeTextBox)
        Me.Name = "Form5"
        Me.Text = "Form5"
        CType(Me.BankDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PositionsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents BankDataSet As Bank.BankDataSet
    Friend WithEvents PositionsBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents PositionsTableAdapter As Bank.BankDataSetTableAdapters.PositionsTableAdapter
    Friend WithEvents TableAdapterManager As Bank.BankDataSetTableAdapters.TableAdapterManager
    Friend WithEvents Post_codeTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Name_of_the_postTextBox As System.Windows.Forms.TextBox
    Friend WithEvents SalaryTextBox As System.Windows.Forms.TextBox
    Friend WithEvents DutiesTextBox As System.Windows.Forms.TextBox
    Friend WithEvents RequirementsTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Button5 As System.Windows.Forms.Button
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button7 As System.Windows.Forms.Button
    Friend WithEvents Button6 As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Button8 As System.Windows.Forms.Button
End Class
