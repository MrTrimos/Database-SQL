Public Class Form18

    Private Sub Form18_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'BankDataSet1.Contributors1' table. You can move, or remove it, as needed.
        Me.Contributors1TableAdapter.Fill(Me.BankDataSet1.Contributors1)
        'TODO: This line of code loads data into the 'BankDataSet.Contributors' table. You can move, or remove it, as needed.
        Me.ContributorsTableAdapter.Fill(Me.BankDataSet.Contributors)

        Me.ReportViewer1.RefreshReport()
    End Sub
End Class