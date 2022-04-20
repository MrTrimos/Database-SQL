Public Class Form16

    Private Sub Form16_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'BankDataSet1.Positions1' table. You can move, or remove it, as needed.
        Me.Positions1TableAdapter.Fill(Me.BankDataSet1.Positions1)
        'TODO: This line of code loads data into the 'BankDataSet.Positions' table. You can move, or remove it, as needed.
        Me.PositionsTableAdapter.Fill(Me.BankDataSet.Positions)

        Me.ReportViewer1.RefreshReport()
    End Sub
End Class