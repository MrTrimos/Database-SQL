Public Class Form17

    Private Sub Form17_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'BankDataSet1.Currency1' table. You can move, or remove it, as needed.
        Me.Currency1TableAdapter.Fill(Me.BankDataSet1.Currency1)
        'TODO: This line of code loads data into the 'BankDataSet.Currency' table. You can move, or remove it, as needed.
        Me.CurrencyTableAdapter.Fill(Me.BankDataSet.Currency)

        Me.ReportViewer1.RefreshReport()
    End Sub
End Class