Public Class Form2

    Private Sub Workers1BindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
        Me.Validate()
        Me.Workers1BindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.BankDataSet)

    End Sub


    Private Sub Workers1BindingNavigatorSaveItem_Click_1(sender As Object, e As EventArgs)
        Me.Validate()
        Me.Workers1BindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.BankDataSet)

    End Sub


    Private Sub Workers1BindingNavigatorSaveItem_Click_2(sender As Object, e As EventArgs)
        Me.Validate()
        Me.Workers1BindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.BankDataSet)

    End Sub

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'BankDataSet.Department_of_Caldas' table. You can move, or remove it, as needed.
        Me.Department_of_CaldasTableAdapter.Fill(Me.BankDataSet.Department_of_Caldas)
        'TODO: This line of code loads data into the 'BankDataSet.Positions' table. You can move, or remove it, as needed.
        Me.PositionsTableAdapter.Fill(Me.BankDataSet.Positions)
        'TODO: This line of code loads data into the 'BankDataSet.Contributors' table. You can move, or remove it, as needed.
        Me.ContributorsTableAdapter.Fill(Me.BankDataSet.Contributors)
        'TODO: This line of code loads data into the 'BankDataSet.Workers1' table. You can move, or remove it, as needed.
        Me.Workers1TableAdapter.Fill(Me.BankDataSet.Workers1)

    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Workers1BindingSource.MoveFirst()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Workers1BindingSource.MovePrevious()
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Workers1BindingSource.MoveNext()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Workers1BindingSource.MoveLast()
    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        Workers1BindingSource.AddNew()
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        Me.Validate()
        Me.Workers1BindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.BankDataSet)
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        Workers1BindingSource.RemoveCurrent()
    End Sub

    Private Sub GenderComboBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles GenderComboBox.SelectedIndexChanged

    End Sub

    Private Sub Post_codeLabel_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Form8.Show()
    End Sub

    Private Sub Button2_Click_1(sender As Object, e As EventArgs) Handles Button2.Click
        Form15.Show()
    End Sub
End Class