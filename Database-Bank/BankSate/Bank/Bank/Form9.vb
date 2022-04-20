Public Class Form9

    Private Sub CurrencyBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
        Me.Validate()
        Me.CurrencyBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.BankDataSet)

    End Sub

    Private Sub Form9_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'BankDataSet.Currency' table. You can move, or remove it, as needed.
        Me.CurrencyTableAdapter.Fill(Me.BankDataSet.Currency)

    End Sub
Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click

End Sub

Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click

End Sub

Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

End Sub

    Private Sub Workers1DataGridView_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles CurrencyDataGridView.CellContentClick

    End Sub

Private Sub ListBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListBox1.SelectedIndexChanged
    Button1.Enabled = True
End Sub

Private Sub RadioButton2_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton2.CheckedChanged

End Sub

Private Sub GroupBox1_Enter(sender As Object, e As EventArgs) Handles GroupBox1.Enter

End Sub

Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
    Dim col As System.Windows.Forms.DataGridViewColumn
    Select Case ListBox1.SelectedIndex
        Case 0
            col = DataGridViewTextBoxColumn2
        Case 1
            col = DataGridViewTextBoxColumn3
    End Select
    If RadioButton1.Checked Then
            CurrencyDataGridView.Sort(col, System.ComponentModel.ListSortDirection.Ascending)
    Else
            CurrencyDataGridView.Sort(col, System.ComponentModel.ListSortDirection.Descending)
    End If
End Sub
Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        CurrencyBindingSource.Filter = "Name='" & ComboBox1.Text & "'"

End Sub

Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        CurrencyBindingSource.Filter = ""
End Sub

Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        For i = 0 To CurrencyDataGridView.ColumnCount - 1
            For j = 0 To CurrencyDataGridView.RowCount - 1
                CurrencyDataGridView.Item(i, j).Style.BackColor = Color.White
                CurrencyDataGridView.Item(i, j).Style.ForeColor = Color.Black
            Next j
        Next i
        For i = 0 To CurrencyDataGridView.ColumnCount - 1
            For j = 0 To CurrencyDataGridView.RowCount - 1
                If InStr(CurrencyDataGridView.Item(i, j).Value, TextBox1.Text) Then
                    CurrencyDataGridView.Item(i, j).Style.BackColor = Color.Aqua
                    CurrencyDataGridView.Item(i, j).Style.ForeColor = Color.Blue
                End If
            Next j
        Next i
End Sub

Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
    Me.Close()
End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged

    End Sub

    Private Sub RadioButton1_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton1.CheckedChanged

    End Sub
End Class