Public Class Form6

    Private Sub ContributionsBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
        Me.Validate()
        Me.ContributionsBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.BankDataSet)

    End Sub

    Private Sub Form6_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'BankDataSet.Cintribution' table. You can move, or remove it, as needed.
        Me.CintributionTableAdapter.Fill(Me.BankDataSet.Cintribution)
        'TODO: This line of code loads data into the 'BankDataSet.Contributions' table. You can move, or remove it, as needed.
        Me.ContributionsTableAdapter.Fill(Me.BankDataSet.Contributions)

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        ContributionsBindingSource.MoveFirst()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        ContributionsBindingSource.MovePrevious()
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        ContributionsBindingSource.MoveNext()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        ContributionsBindingSource.MoveLast()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        ContributionsBindingSource.AddNew()
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        Me.Validate()
        Me.ContributionsBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.BankDataSet)
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        ContributionsBindingSource.RemoveCurrent()
    End Sub

    Private Sub Additional_conditionsTextBox_TextChanged(sender As Object, e As EventArgs) Handles Additional_conditionsTextBox.TextChanged

    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        Form12.Show()
    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        Form14.Show()
    End Sub
End Class