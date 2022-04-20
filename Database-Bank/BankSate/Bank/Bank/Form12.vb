﻿Public Class Form12

    Private Sub ContributorsBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
        Me.Validate()
        Me.ContributorsBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.BankDataSet)

    End Sub

    Private Sub Form12_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'BankDataSet.Contributions' table. You can move, or remove it, as needed.
        Me.ContributionsTableAdapter.Fill(Me.BankDataSet.Contributions)
        'TODO: This line of code loads data into the 'BankDataSet.Contributors' table. You can move, or remove it, as needed.
        Me.ContributorsTableAdapter.Fill(Me.BankDataSet.Contributors)

    End Sub
    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click

    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub Workers1DataGridView_CellContentClick(sender As Object, e As DataGridViewCellEventArgs)

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
        End Select
        If RadioButton1.Checked Then
            ContributionsDataGridView.Sort(col, System.ComponentModel.ListSortDirection.Ascending)
        Else
            ContributionsDataGridView.Sort(col, System.ComponentModel.ListSortDirection.Descending)
        End If
    End Sub
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        ContributorsBindingSource.Filter = "[Name of the deposit]='" & ComboBox1.Text & "'"

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        ContributorsBindingSource.Filter = ""
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        For i = 0 To ContributionsDataGridView.ColumnCount - 1
            For j = 0 To ContributionsDataGridView.RowCount - 1
                ContributionsDataGridView.Item(i, j).Style.BackColor = Color.White
                ContributionsDataGridView.Item(i, j).Style.ForeColor = Color.Black
            Next j
        Next i
        For i = 0 To ContributionsDataGridView.ColumnCount - 1
            For j = 0 To ContributionsDataGridView.RowCount - 1
                If InStr(ContributionsDataGridView.Item(i, j).Value, TextBox1.Text) Then
                    ContributionsDataGridView.Item(i, j).Style.BackColor = Color.Aqua
                    ContributionsDataGridView.Item(i, j).Style.ForeColor = Color.Blue
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