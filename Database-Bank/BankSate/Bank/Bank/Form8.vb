Public Class Form8

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

    Private Sub Workers1BindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
        Me.Validate()
        Me.Workers1BindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.BankDataSet)

    End Sub

    Private Sub Form8_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'BankDataSet.Workers1' table. You can move, or remove it, as needed.
        Me.Workers1TableAdapter.Fill(Me.BankDataSet.Workers1)

    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click

    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub Workers1DataGridView_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles Workers1DataGridView.CellContentClick

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
            Case 2
                col = DataGridViewTextBoxColumn4
            Case 3
                col = DataGridViewTextBoxColumn5
            Case 4
                col = DataGridViewTextBoxColumn6
            Case 5
                col = DataGridViewTextBoxColumn7
            Case 6
                col = DataGridViewTextBoxColumn8
        End Select
        If RadioButton1.Checked Then
            Workers1DataGridView.Sort(col, System.ComponentModel.ListSortDirection.Ascending)
        Else
            Workers1DataGridView.Sort(col, System.ComponentModel.ListSortDirection.Descending)
        End If
    End Sub
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Workers1BindingSource.Filter = "FIO='" & ComboBox1.Text & "'"

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Workers1BindingSource.Filter = ""
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        For i = 0 To Workers1DataGridView.ColumnCount - 1
            For j = 0 To Workers1DataGridView.RowCount - 1
                Workers1DataGridView.Item(i, j).Style.BackColor = Color.White
                Workers1DataGridView.Item(i, j).Style.ForeColor = Color.Black
            Next j
        Next i
        For i = 0 To Workers1DataGridView.ColumnCount - 1
            For j = 0 To Workers1DataGridView.RowCount - 1
                If InStr(Workers1DataGridView.Item(i, j).Value, TextBox1.Text) Then
                    Workers1DataGridView.Item(i, j).Style.BackColor = Color.Aqua
                    Workers1DataGridView.Item(i, j).Style.ForeColor = Color.Blue
                End If
            Next j
        Next i
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Me.Close()
    End Sub

    Private Sub RadioButton1_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton1.CheckedChanged

    End Sub
End Class