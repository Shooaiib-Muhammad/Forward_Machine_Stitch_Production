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

    End Sub

    Private Sub FillToolStripButton_Click(sender As Object, e As EventArgs)
        Try
            Me.View_MS_PONOTableAdapter.Fill(Me.MSDS.view_MS_PONO, New System.Nullable(Of Date)(CType(SecondConfDateToolStripTextBox.Text, Date)), New System.Nullable(Of Date)(CType(SecondConfDate1ToolStripTextBox.Text, Date)))
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try

    End Sub
End Class
