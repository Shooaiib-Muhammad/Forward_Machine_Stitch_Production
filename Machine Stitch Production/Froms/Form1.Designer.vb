<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim InspectionNameLabel As System.Windows.Forms.Label
        Dim Label1 As System.Windows.Forms.Label
        Dim Label2 As System.Windows.Forms.Label
        Dim POCodeLabel As System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label()
        Me.MSDS = New Machine_Stitch_Production.MSDS()
        Me.Tbl_Inspection_TypeBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Tbl_Inspection_TypeTableAdapter = New Machine_Stitch_Production.MSDSTableAdapters.tbl_Inspection_TypeTableAdapter()
        Me.TableAdapterManager = New Machine_Stitch_Production.MSDSTableAdapters.TableAdapterManager()
        Me.InspectionNameComboBox = New System.Windows.Forms.ComboBox()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.ComboBox2 = New System.Windows.Forms.ComboBox()
        Me.Tbl_Inspection_ProcessBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Tbl_Inspection_ProcessTableAdapter = New Machine_Stitch_Production.MSDSTableAdapters.tbl_Inspection_ProcessTableAdapter()
        Me.Tbl_Inspection_Wise_DefectsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Tbl_Inspection_Wise_DefectsTableAdapter = New Machine_Stitch_Production.MSDSTableAdapters.tbl_Inspection_Wise_DefectsTableAdapter()
        Me.View_MS_PONOBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.View_MS_PONOTableAdapter = New Machine_Stitch_Production.MSDSTableAdapters.view_MS_PONOTableAdapter()
        Me.POCodeComboBox = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.DateTimePicker2 = New System.Windows.Forms.DateTimePicker()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        InspectionNameLabel = New System.Windows.Forms.Label()
        Label1 = New System.Windows.Forms.Label()
        Label2 = New System.Windows.Forms.Label()
        POCodeLabel = New System.Windows.Forms.Label()
        CType(Me.MSDS, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Tbl_Inspection_TypeBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Tbl_Inspection_ProcessBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Tbl_Inspection_Wise_DefectsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.View_MS_PONOBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label5
        '
        Me.Label5.BackColor = System.Drawing.Color.Teal
        Me.Label5.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label5.Font = New System.Drawing.Font("Georgia", 20.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(0, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(1775, 40)
        Me.Label5.TabIndex = 84
        Me.Label5.Text = "Machine Stitch Ball Production "
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'MSDS
        '
        Me.MSDS.DataSetName = "MSDS"
        Me.MSDS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Tbl_Inspection_TypeBindingSource
        '
        Me.Tbl_Inspection_TypeBindingSource.DataMember = "tbl_Inspection_Type"
        Me.Tbl_Inspection_TypeBindingSource.DataSource = Me.MSDS
        '
        'Tbl_Inspection_TypeTableAdapter
        '
        Me.Tbl_Inspection_TypeTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.tbl_Inspection_DTableAdapter = Nothing
        Me.TableAdapterManager.tbl_Inspection_HTableAdapter = Nothing
        Me.TableAdapterManager.tbl_Inspection_ProcessTableAdapter = Me.Tbl_Inspection_ProcessTableAdapter
        Me.TableAdapterManager.tbl_Inspection_TypeTableAdapter = Me.Tbl_Inspection_TypeTableAdapter
        Me.TableAdapterManager.tbl_Inspection_Wise_DefectsTableAdapter = Me.Tbl_Inspection_Wise_DefectsTableAdapter
        Me.TableAdapterManager.UpdateOrder = Machine_Stitch_Production.MSDSTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'InspectionNameLabel
        '
        InspectionNameLabel.AutoSize = True
        InspectionNameLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        InspectionNameLabel.Location = New System.Drawing.Point(12, 263)
        InspectionNameLabel.Name = "InspectionNameLabel"
        InspectionNameLabel.Size = New System.Drawing.Size(179, 31)
        InspectionNameLabel.TabIndex = 85
        InspectionNameLabel.Text = "Report Type :"
        '
        'InspectionNameComboBox
        '
        Me.InspectionNameComboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.InspectionNameComboBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.InspectionNameComboBox.DataSource = Me.Tbl_Inspection_TypeBindingSource
        Me.InspectionNameComboBox.DisplayMember = "inspectionName"
        Me.InspectionNameComboBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.InspectionNameComboBox.FormattingEnabled = True
        Me.InspectionNameComboBox.Location = New System.Drawing.Point(197, 263)
        Me.InspectionNameComboBox.Name = "InspectionNameComboBox"
        Me.InspectionNameComboBox.Size = New System.Drawing.Size(326, 39)
        Me.InspectionNameComboBox.TabIndex = 86
        Me.InspectionNameComboBox.ValueMember = "InspectionID"
        '
        'Label1
        '
        Label1.AutoSize = True
        Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Label1.Location = New System.Drawing.Point(152, 386)
        Label1.Name = "Label1"
        Label1.Size = New System.Drawing.Size(128, 31)
        Label1.TabIndex = 87
        Label1.Text = "Process :"
        '
        'ComboBox1
        '
        Me.ComboBox1.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.ComboBox1.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.ComboBox1.DataSource = Me.Tbl_Inspection_ProcessBindingSource
        Me.ComboBox1.DisplayMember = "ProcessName"
        Me.ComboBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(286, 386)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(377, 39)
        Me.ComboBox1.TabIndex = 88
        Me.ComboBox1.ValueMember = "ProcessID"
        '
        'Label2
        '
        Label2.AutoSize = True
        Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Label2.Location = New System.Drawing.Point(669, 389)
        Label2.Name = "Label2"
        Label2.Size = New System.Drawing.Size(123, 31)
        Label2.TabIndex = 89
        Label2.Text = "Defects :"
        '
        'ComboBox2
        '
        Me.ComboBox2.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.ComboBox2.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.ComboBox2.DataSource = Me.Tbl_Inspection_Wise_DefectsBindingSource
        Me.ComboBox2.DisplayMember = "DefectName"
        Me.ComboBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComboBox2.FormattingEnabled = True
        Me.ComboBox2.Location = New System.Drawing.Point(798, 386)
        Me.ComboBox2.Name = "ComboBox2"
        Me.ComboBox2.Size = New System.Drawing.Size(326, 39)
        Me.ComboBox2.TabIndex = 90
        Me.ComboBox2.ValueMember = "DefectID"
        '
        'Tbl_Inspection_ProcessBindingSource
        '
        Me.Tbl_Inspection_ProcessBindingSource.DataMember = "tbl_Inspection_Type_tbl_Inspection_Process"
        Me.Tbl_Inspection_ProcessBindingSource.DataSource = Me.Tbl_Inspection_TypeBindingSource
        '
        'Tbl_Inspection_ProcessTableAdapter
        '
        Me.Tbl_Inspection_ProcessTableAdapter.ClearBeforeFill = True
        '
        'Tbl_Inspection_Wise_DefectsBindingSource
        '
        Me.Tbl_Inspection_Wise_DefectsBindingSource.DataMember = "tbl_Inspection_Process_tbl_Inspection_Wise_Defects"
        Me.Tbl_Inspection_Wise_DefectsBindingSource.DataSource = Me.Tbl_Inspection_ProcessBindingSource
        '
        'Tbl_Inspection_Wise_DefectsTableAdapter
        '
        Me.Tbl_Inspection_Wise_DefectsTableAdapter.ClearBeforeFill = True
        '
        'View_MS_PONOBindingSource
        '
        Me.View_MS_PONOBindingSource.DataMember = "view_MS_PONO"
        Me.View_MS_PONOBindingSource.DataSource = Me.MSDS
        '
        'View_MS_PONOTableAdapter
        '
        Me.View_MS_PONOTableAdapter.ClearBeforeFill = True
        '
        'POCodeLabel
        '
        POCodeLabel.AutoSize = True
        POCodeLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        POCodeLabel.Location = New System.Drawing.Point(192, 631)
        POCodeLabel.Name = "POCodeLabel"
        POCodeLabel.Size = New System.Drawing.Size(254, 31)
        POCodeLabel.TabIndex = 91
        POCodeLabel.Text = "Select PO Number :"
        '
        'POCodeComboBox
        '
        Me.POCodeComboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.POCodeComboBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.POCodeComboBox.DataSource = Me.View_MS_PONOBindingSource
        Me.POCodeComboBox.DisplayMember = "POCode"
        Me.POCodeComboBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.POCodeComboBox.FormattingEnabled = True
        Me.POCodeComboBox.Location = New System.Drawing.Point(452, 628)
        Me.POCodeComboBox.Name = "POCodeComboBox"
        Me.POCodeComboBox.Size = New System.Drawing.Size(350, 39)
        Me.POCodeComboBox.TabIndex = 92
        Me.POCodeComboBox.ValueMember = "PO"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(949, 221)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(119, 31)
        Me.Label3.TabIndex = 93
        Me.Label3.Text = "To Date:"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.Location = New System.Drawing.Point(484, 214)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(150, 31)
        Me.Label4.TabIndex = 94
        Me.Label4.Text = "From Date:"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'DateTimePicker2
        '
        Me.DateTimePicker2.CustomFormat = "dd/MM/yyyy"
        Me.DateTimePicker2.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DateTimePicker2.Location = New System.Drawing.Point(1074, 214)
        Me.DateTimePicker2.Name = "DateTimePicker2"
        Me.DateTimePicker2.Size = New System.Drawing.Size(100, 38)
        Me.DateTimePicker2.TabIndex = 96
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.CustomFormat = "dd/MM/yyyy"
        Me.DateTimePicker1.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DateTimePicker1.Location = New System.Drawing.Point(708, 215)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(219, 38)
        Me.DateTimePicker1.TabIndex = 95
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1775, 841)
        Me.ControlBox = False
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.DateTimePicker2)
        Me.Controls.Add(Me.DateTimePicker1)
        Me.Controls.Add(POCodeLabel)
        Me.Controls.Add(Me.POCodeComboBox)
        Me.Controls.Add(Label2)
        Me.Controls.Add(Me.ComboBox2)
        Me.Controls.Add(Label1)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(InspectionNameLabel)
        Me.Controls.Add(Me.InspectionNameComboBox)
        Me.Controls.Add(Me.Label5)
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        CType(Me.MSDS, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Tbl_Inspection_TypeBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Tbl_Inspection_ProcessBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Tbl_Inspection_Wise_DefectsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.View_MS_PONOBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label5 As Label
    Friend WithEvents MSDS As MSDS
    Friend WithEvents Tbl_Inspection_TypeBindingSource As BindingSource
    Friend WithEvents Tbl_Inspection_TypeTableAdapter As MSDSTableAdapters.tbl_Inspection_TypeTableAdapter
    Friend WithEvents TableAdapterManager As MSDSTableAdapters.TableAdapterManager
    Friend WithEvents InspectionNameComboBox As ComboBox
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents ComboBox2 As ComboBox
    Friend WithEvents Tbl_Inspection_ProcessTableAdapter As MSDSTableAdapters.tbl_Inspection_ProcessTableAdapter
    Friend WithEvents Tbl_Inspection_ProcessBindingSource As BindingSource
    Friend WithEvents Tbl_Inspection_Wise_DefectsTableAdapter As MSDSTableAdapters.tbl_Inspection_Wise_DefectsTableAdapter
    Friend WithEvents Tbl_Inspection_Wise_DefectsBindingSource As BindingSource
    Friend WithEvents View_MS_PONOBindingSource As BindingSource
    Friend WithEvents View_MS_PONOTableAdapter As MSDSTableAdapters.view_MS_PONOTableAdapter
    Friend WithEvents POCodeComboBox As ComboBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents DateTimePicker2 As DateTimePicker
    Friend WithEvents DateTimePicker1 As DateTimePicker
End Class
