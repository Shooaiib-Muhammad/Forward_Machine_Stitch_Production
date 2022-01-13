Public Class Form1
    Private Sub Tbl_Inspection_TypeBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
        Me.Validate()
        Me.Tbl_Inspection_TypeBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.MSDS)

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'MSDS.maxTID' table. You can move, or remove it, as needed.

        'TODO: This line of code loads data into the 'MSDS.tbl_Inspection_D' table. You can move, or remove it, as needed.
        Me.Tbl_Inspection_DTableAdapter.Fill(Me.MSDS.tbl_Inspection_D)
        'TODO: This line of code loads data into the 'MSDS.view_MS_batched_Quantity' table. You can move, or remove it, as needed.

        'TODO: This line of code loads data into the 'MSDS.tbl_PC_AMB_Line' table. You can move, or remove it, as needed.
        Me.Tbl_PC_AMB_LineTableAdapter.Fill(Me.MSDS.tbl_PC_AMB_Line)
        'TODO: This line of code loads data into the 'MSDS.tbl_Inspection_H' table. You can move, or remove it, as needed.
        Try
            Me.Tbl_Inspection_HTableAdapter.Fill(Me.MSDS.tbl_Inspection_H)
        Catch ex As Exception

        End Try
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

    Private Sub Panel2_Paint(sender As Object, e As PaintEventArgs) Handles Panel2.Paint

    End Sub

    Private Sub Label13_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Label7_Click(sender As Object, e As EventArgs) Handles Label7.Click

    End Sub

    Private Sub Label22_Click(sender As Object, e As EventArgs)

    End Sub
    Private Sub balance()
        Label23.Text = Val(Label7.Text) - Val(Label11.Text)
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim Shift As String
        If RadioButton1.Checked = True Then
            Shift = "Morning"
        ElseIf RadioButton2.Checked = True Then
            Shift = "After Noon"
        ElseIf RadioButton3.Checked = True Then
            Shift = "Night"
        End If
        If TextBox1.Text = "" Then
            MsgBox("Enter Batch Quantity")
        Else
            If Val(TextBox1.Text) > Val(Label23.Text) Then
                MsgBox("Batch Quantity  must be less then Order")
            Else
                Try
                    Tbl_Inspection_HTableAdapter.Insert(InspectionNameComboBox.SelectedValue, CType(Shift, String), Label7.Text, TextBox1.Text, CType(LineNameComboBox.SelectedValue, Int64), CType(Label14.Text, Int64), CType(Label21.Text, Int64), CType(Label20.Text, Int64), CType(Label19.Text, Int64), CType(Label18.Text, Int64), CType(Label17.Text, Int64), CType(Label12.Text, String), CType(Label16.Text, String), Nothing, Nothing, CType(Label9.Text, String))
                    MsgBox("Head Data Saved")
                    balance()
                    loadData()
                    Try
                        Me.MaxTIDTableAdapter.Fill(Me.MSDS.maxTID)
                    Catch ex As Exception

                    End Try
                Catch ex As Exception
                    MsgBox(ex.Message)
                End Try
            End If
        End If


    End Sub

    Private Sub loadData()
        Try
            Me.View_MS_batched_QuantityTableAdapter.Fill(Me.MSDS.view_MS_batched_Quantity, InspectionNameComboBox.SelectedValue, CType(Label14.Text, Int64), CType(Label21.Text, Int64), CType(Label20.Text, Int64))
            balance()
        Catch ex As Exception

        End Try
        Try
            Me.View_inspection_QuantityTableAdapter.Fill(Me.MSDS.view_inspection_Quantity, CType(Label14.Text, Int64), CType(Label21.Text, Int64), CType(Label20.Text, Int64))
        Catch ex As System.Exception

        End Try
    End Sub


    Private Sub View_MS_PONOBindingSource_PositionChanged(sender As Object, e As EventArgs) Handles View_MS_PONOBindingSource.PositionChanged
        loadData()
        loadQuantity()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Try
            Dim Parameters_Setting As String
            Dim Sealing_Sample As String
            Dim Metal_Detection As String
            If CheckBox1.CheckState = True Then
                Parameters_Setting = 1
            Else
                Parameters_Setting = 0
            End If
            If CheckBox2.CheckState = True Then
                Sealing_Sample = 1
            Else

                Sealing_Sample = 0
            End If
            If CheckBox3.CheckState = True Then
                Metal_Detection = 1
            Else
                Metal_Detection = 0
            End If
            If Label25.Text = "" Then
                MsgBox("please Enter Head Information")
            Else
                If RadioButton6.Checked = True Then
                    Tbl_Inspection_DTableAdapter.Insert(Val(Label25.Text), Val(ComboBox1.SelectedValue), Val(ListBox1.SelectedValue), 1, Parameters_Setting, Sealing_Sample, Metal_Detection, Nothing, Nothing, Label9.Text)
                    'MsgBox("Data Saved")
                    loadQuantity()
                ElseIf RadioButton5.Checked = True Then
                    If TextBox2.Text = "" Then
                        MsgBox("Enter Defects Quantity")
                    Else
                        Tbl_Inspection_DTableAdapter.Insert(Val(Label25.Text), Val(ComboBox1.SelectedValue), Val(ListBox1.SelectedValue), Val(TextBox2.Text), Parameters_Setting, Sealing_Sample, Metal_Detection, Nothing, Nothing, Label9.Text)
                        'MsgBox("Data Saved")
                        loadQuantity()
                    End If
                End If

            End If

        Catch ex As Exception



        End Try



    End Sub
    Private Sub loadQuantity()
        Try
            Me.View_inspection_QuantityTableAdapter.Fill(Me.MSDS.view_inspection_Quantity, CType(Label14.Text, Int64), CType(Label21.Text, Int64), CType(Label20.Text, Int64))
        Catch ex As System.Exception

        End Try
    End Sub
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Tbl_Inspection_HBindingSource.AddNew()
        TextBox1.Text = ""
        Label25.Text = ""
        TextBox2.Text = ""
    End Sub

    Private Sub RadioButton5_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton5.CheckedChanged
        If RadioButton5.Checked = True Then
            Label26.Visible = True
            TextBox2.Visible = True

        Else
            Label26.Visible = False
            TextBox2.Visible = False
        End If
    End Sub

    Private Sub RadioButton6_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton6.CheckedChanged
        If RadioButton6.Checked = True Then
            Label26.Visible = False
            TextBox2.Visible = False


        End If

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Me.Close()
    End Sub


End Class
