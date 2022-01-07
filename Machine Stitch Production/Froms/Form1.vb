Public Class Form1
    Private Sub Tbl_Inspection_TypeBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
        Me.Validate()
        Me.Tbl_Inspection_TypeBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.MSDS)

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'MSDS.tbl_Inspection_Wise_Defects' table. You can move, or remove it, as needed.
        Me.Tbl_Inspection_Wise_DefectsTableAdapter.Fill(Me.MSDS.tbl_Inspection_Wise_Defects)
        'TODO: This line of code loads data into the 'MSDS.tbl_Inspection_Process' table. You can move, or remove it, as needed.
        Me.Tbl_Inspection_ProcessTableAdapter.Fill(Me.MSDS.tbl_Inspection_Process)
        'TODO: This line of code loads data into the 'MSDS.tbl_Inspection_Type' table. You can move, or remove it, as needed.
        Me.Tbl_Inspection_TypeTableAdapter.Fill(Me.MSDS.tbl_Inspection_Type)
        loadPO()
    End Sub

    Private Sub loadPO()
        Try
            Me.View_MS_PONOTableAdapter.Fill(Me.MSDS.view_MS_PONO, DateTimePicker1.Text, DateTimePicker2.Text)
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub DateTimePicker1_ValueChanged(sender As Object, e As EventArgs) Handles DateTimePicker1.ValueChanged
        loadPO()
    End Sub

    Private Sub DateTimePicker2_ValueChanged(sender As Object, e As EventArgs) Handles DateTimePicker2.ValueChanged
        loadPO()
    End Sub
End Class
