Public Class Form13

    Private Sub Form13_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: данная строка кода позволяет загрузить данные в таблицу "BankDataSet.Contributions1". При необходимости она может быть перемещена или удалена.
        Me.Contributions1TableAdapter.Fill(Me.BankDataSet.Contributions1)

        Me.ReportViewer1.RefreshReport()
    End Sub
End Class