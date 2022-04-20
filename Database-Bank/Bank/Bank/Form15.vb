Public Class Form15

    Private Sub Form15_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'BankDataSet1.Workers' table. You can move, or remove it, as needed.
        Me.WorkersTableAdapter.Fill(Me.BankDataSet1.Workers)
        'TODO: This line of code loads data into the 'BankDataSet.Workers1' table. You can move, or remove it, as needed.
        Me.Workers1TableAdapter.Fill(Me.BankDataSet.Workers1)

        Me.ReportViewer1.RefreshReport()
    End Sub
End Class