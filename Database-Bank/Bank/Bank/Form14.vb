Public Class Form14

    Private Sub Form14_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'BankDataSet.Contributions1' table. You can move, or remove it, as needed.
        Me.Contributions1TableAdapter.Fill(Me.BankDataSet.Contributions1)
        'TODO: This line of code loads data into the 'BankDataSet.Contributions' table. You can move, or remove it, as needed.
        Me.ContributionsTableAdapter.Fill(Me.BankDataSet.Contributions)

        Me.ReportViewer1.RefreshReport()
    End Sub
End Class