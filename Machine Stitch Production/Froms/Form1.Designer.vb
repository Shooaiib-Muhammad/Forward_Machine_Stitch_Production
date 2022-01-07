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
        Dim Label6 As System.Windows.Forms.Label
        Dim Label8 As System.Windows.Forms.Label
        Dim Label10 As System.Windows.Forms.Label
        Dim Label13 As System.Windows.Forms.Label
        Dim Label22 As System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label()
        Me.MSDS = New Machine_Stitch_Production.MSDS()
        Me.Tbl_Inspection_TypeBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Tbl_Inspection_TypeTableAdapter = New Machine_Stitch_Production.MSDSTableAdapters.tbl_Inspection_TypeTableAdapter()
        Me.TableAdapterManager = New Machine_Stitch_Production.MSDSTableAdapters.TableAdapterManager()
        Me.Tbl_Inspection_ProcessTableAdapter = New Machine_Stitch_Production.MSDSTableAdapters.tbl_Inspection_ProcessTableAdapter()
        Me.Tbl_Inspection_Wise_DefectsTableAdapter = New Machine_Stitch_Production.MSDSTableAdapters.tbl_Inspection_Wise_DefectsTableAdapter()
        Me.InspectionNameComboBox = New System.Windows.Forms.ComboBox()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.Tbl_Inspection_ProcessBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ComboBox2 = New System.Windows.Forms.ComboBox()
        Me.Tbl_Inspection_Wise_DefectsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.View_MS_PONOBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.View_MS_PONOTableAdapter = New Machine_Stitch_Production.MSDSTableAdapters.view_MS_PONOTableAdapter()
        Me.POCodeComboBox = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.DateTimePicker2 = New System.Windows.Forms.DateTimePicker()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        InspectionNameLabel = New System.Windows.Forms.Label()
        Label1 = New System.Windows.Forms.Label()
        Label2 = New System.Windows.Forms.Label()
        POCodeLabel = New System.Windows.Forms.Label()
        Label6 = New System.Windows.Forms.Label()
        Label8 = New System.Windows.Forms.Label()
        Label10 = New System.Windows.Forms.Label()
        Label13 = New System.Windows.Forms.Label()
        Label22 = New System.Windows.Forms.Label()
        CType(Me.MSDS, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Tbl_Inspection_TypeBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Tbl_Inspection_ProcessBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Tbl_Inspection_Wise_DefectsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.View_MS_PONOBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'InspectionNameLabel
        '
        InspectionNameLabel.AutoSize = True
        InspectionNameLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        InspectionNameLabel.Location = New System.Drawing.Point(89, 69)
        InspectionNameLabel.Name = "InspectionNameLabel"
        InspectionNameLabel.Size = New System.Drawing.Size(179, 31)
        InspectionNameLabel.TabIndex = 85
        InspectionNameLabel.Text = "Report Type :"
        '
        'Label1
        '
        Label1.AutoSize = True
        Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Label1.Location = New System.Drawing.Point(138, 423)
        Label1.Name = "Label1"
        Label1.Size = New System.Drawing.Size(128, 31)
        Label1.TabIndex = 87
        Label1.Text = "Process :"
        '
        'Label2
        '
        Label2.AutoSize = True
        Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Label2.Location = New System.Drawing.Point(655, 426)
        Label2.Name = "Label2"
        Label2.Size = New System.Drawing.Size(123, 31)
        Label2.TabIndex = 89
        Label2.Text = "Defects :"
        '
        'POCodeLabel
        '
        POCodeLabel.AutoSize = True
        POCodeLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        POCodeLabel.Location = New System.Drawing.Point(14, 16)
        POCodeLabel.Name = "POCodeLabel"
        POCodeLabel.Size = New System.Drawing.Size(254, 31)
        POCodeLabel.TabIndex = 91
        POCodeLabel.Text = "Select PO Number :"
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
        'Tbl_Inspection_ProcessTableAdapter
        '
        Me.Tbl_Inspection_ProcessTableAdapter.ClearBeforeFill = True
        '
        'Tbl_Inspection_Wise_DefectsTableAdapter
        '
        Me.Tbl_Inspection_Wise_DefectsTableAdapter.ClearBeforeFill = True
        '
        'InspectionNameComboBox
        '
        Me.InspectionNameComboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.InspectionNameComboBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.InspectionNameComboBox.DataSource = Me.Tbl_Inspection_TypeBindingSource
        Me.InspectionNameComboBox.DisplayMember = "inspectionName"
        Me.InspectionNameComboBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.InspectionNameComboBox.FormattingEnabled = True
        Me.InspectionNameComboBox.Location = New System.Drawing.Point(274, 65)
        Me.InspectionNameComboBox.Name = "InspectionNameComboBox"
        Me.InspectionNameComboBox.Size = New System.Drawing.Size(350, 39)
        Me.InspectionNameComboBox.TabIndex = 86
        Me.InspectionNameComboBox.ValueMember = "InspectionID"
        '
        'ComboBox1
        '
        Me.ComboBox1.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.ComboBox1.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.ComboBox1.DataSource = Me.Tbl_Inspection_ProcessBindingSource
        Me.ComboBox1.DisplayMember = "ProcessName"
        Me.ComboBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(272, 423)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(377, 39)
        Me.ComboBox1.TabIndex = 88
        Me.ComboBox1.ValueMember = "ProcessID"
        '
        'Tbl_Inspection_ProcessBindingSource
        '
        Me.Tbl_Inspection_ProcessBindingSource.DataMember = "tbl_Inspection_Type_tbl_Inspection_Process"
        Me.Tbl_Inspection_ProcessBindingSource.DataSource = Me.Tbl_Inspection_TypeBindingSource
        '
        'ComboBox2
        '
        Me.ComboBox2.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.ComboBox2.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.ComboBox2.DataSource = Me.Tbl_Inspection_Wise_DefectsBindingSource
        Me.ComboBox2.DisplayMember = "DefectName"
        Me.ComboBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComboBox2.FormattingEnabled = True
        Me.ComboBox2.Location = New System.Drawing.Point(784, 423)
        Me.ComboBox2.Name = "ComboBox2"
        Me.ComboBox2.Size = New System.Drawing.Size(326, 39)
        Me.ComboBox2.TabIndex = 90
        Me.ComboBox2.ValueMember = "DefectID"
        '
        'Tbl_Inspection_Wise_DefectsBindingSource
        '
        Me.Tbl_Inspection_Wise_DefectsBindingSource.DataMember = "tbl_Inspection_Process_tbl_Inspection_Wise_Defects"
        Me.Tbl_Inspection_Wise_DefectsBindingSource.DataSource = Me.Tbl_Inspection_ProcessBindingSource
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
        'POCodeComboBox
        '
        Me.POCodeComboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.POCodeComboBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.POCodeComboBox.DataSource = Me.View_MS_PONOBindingSource
        Me.POCodeComboBox.DisplayMember = "POCode"
        Me.POCodeComboBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.POCodeComboBox.FormattingEnabled = True
        Me.POCodeComboBox.Location = New System.Drawing.Point(274, 12)
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
        Me.Label3.Location = New System.Drawing.Point(408, 7)
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
        Me.Label4.Location = New System.Drawing.Point(7, 7)
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
        Me.DateTimePicker2.Location = New System.Drawing.Point(533, 3)
        Me.DateTimePicker2.Name = "DateTimePicker2"
        Me.DateTimePicker2.Size = New System.Drawing.Size(206, 38)
        Me.DateTimePicker2.TabIndex = 96
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.CustomFormat = "dd/MM/yyyy"
        Me.DateTimePicker1.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DateTimePicker1.Location = New System.Drawing.Point(162, 3)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(219, 38)
        Me.DateTimePicker1.TabIndex = 95
        '
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.DateTimePicker1)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.DateTimePicker2)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Location = New System.Drawing.Point(6, 43)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(767, 50)
        Me.Panel1.TabIndex = 97
        '
        'Panel2
        '
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel2.Controls.Add(Me.Button1)
        Me.Panel2.Controls.Add(Me.TextBox1)
        Me.Panel2.Controls.Add(Label22)
        Me.Panel2.Controls.Add(Me.Label12)
        Me.Panel2.Controls.Add(Me.Label9)
        Me.Panel2.Controls.Add(Me.Label7)
        Me.Panel2.Controls.Add(Me.Label16)
        Me.Panel2.Controls.Add(Label13)
        Me.Panel2.Controls.Add(Label10)
        Me.Panel2.Controls.Add(Label8)
        Me.Panel2.Controls.Add(Label6)
        Me.Panel2.Controls.Add(InspectionNameLabel)
        Me.Panel2.Controls.Add(Me.InspectionNameComboBox)
        Me.Panel2.Controls.Add(POCodeLabel)
        Me.Panel2.Controls.Add(Me.POCodeComboBox)
        Me.Panel2.Location = New System.Drawing.Point(12, 99)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1712, 165)
        Me.Panel2.TabIndex = 98
        '
        'Label6
        '
        Label6.AutoSize = True
        Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Label6.Location = New System.Drawing.Point(1016, 16)
        Label6.Name = "Label6"
        Label6.Size = New System.Drawing.Size(177, 31)
        Label6.TabIndex = 93
        Label6.Text = "Article Code :"
        '
        'Label8
        '
        Label8.AutoSize = True
        Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Label8.Location = New System.Drawing.Point(1386, 16)
        Label8.Name = "Label8"
        Label8.Size = New System.Drawing.Size(82, 31)
        Label8.TabIndex = 95
        Label8.Text = "Size :"
        '
        'Label10
        '
        Label10.AutoSize = True
        Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Label10.Location = New System.Drawing.Point(640, 16)
        Label10.Name = "Label10"
        Label10.Size = New System.Drawing.Size(193, 31)
        Label10.TabIndex = 97
        Label10.Text = "Factory Code :"
        '
        'Label13
        '
        Label13.AutoSize = True
        Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Label13.Location = New System.Drawing.Point(630, 68)
        Label13.Name = "Label13"
        Label13.Size = New System.Drawing.Size(207, 31)
        Label13.TabIndex = 99
        Label13.Text = "Order Quantity :"
        '
        'Label16
        '
        Me.Label16.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label16.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.View_MS_PONOBindingSource, "FactoryCode", True))
        Me.Label16.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.Location = New System.Drawing.Point(830, 15)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(181, 33)
        Me.Label16.TabIndex = 103
        Me.Label16.Text = "Label16"
        '
        'Label7
        '
        Me.Label7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label7.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.View_MS_PONOBindingSource, "OrderQty", True))
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(833, 72)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(181, 33)
        Me.Label7.TabIndex = 104
        Me.Label7.Text = "Label7"
        '
        'Label9
        '
        Me.Label9.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label9.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.View_MS_PONOBindingSource, "ArtCode", True))
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(1199, 15)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(181, 33)
        Me.Label9.TabIndex = 105
        Me.Label9.Text = "Label9"
        '
        'Label12
        '
        Me.Label12.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label12.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.View_MS_PONOBindingSource, "ArtSize", True))
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(1493, 15)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(181, 33)
        Me.Label12.TabIndex = 107
        Me.Label12.Text = "Label12"
        '
        'Label14
        '
        Me.Label14.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label14.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.View_MS_PONOBindingSource, "PO", True))
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(1564, 470)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(181, 33)
        Me.Label14.TabIndex = 108
        Me.Label14.Text = "Label14"
        '
        'Label17
        '
        Me.Label17.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label17.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.View_MS_PONOBindingSource, "ArtID", True))
        Me.Label17.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.Location = New System.Drawing.Point(1564, 659)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(181, 33)
        Me.Label17.TabIndex = 109
        Me.Label17.Text = "Label17"
        '
        'Label18
        '
        Me.Label18.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label18.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.View_MS_PONOBindingSource, "ModelID", True))
        Me.Label18.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.Location = New System.Drawing.Point(1564, 615)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(181, 33)
        Me.Label18.TabIndex = 110
        Me.Label18.Text = "Label18"
        '
        'Label19
        '
        Me.Label19.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label19.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.View_MS_PONOBindingSource, "ClientID", True))
        Me.Label19.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.Location = New System.Drawing.Point(1564, 579)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(181, 33)
        Me.Label19.TabIndex = 111
        Me.Label19.Text = "Label19"
        '
        'Label20
        '
        Me.Label20.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label20.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.View_MS_PONOBindingSource, "POD", True))
        Me.Label20.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label20.Location = New System.Drawing.Point(1564, 546)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(181, 33)
        Me.Label20.TabIndex = 112
        Me.Label20.Text = "Label20"
        '
        'Label21
        '
        Me.Label21.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label21.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.View_MS_PONOBindingSource, "POM", True))
        Me.Label21.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label21.Location = New System.Drawing.Point(1564, 503)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(181, 33)
        Me.Label21.TabIndex = 113
        Me.Label21.Text = "Label21"
        '
        'Label22
        '
        Label22.AutoSize = True
        Label22.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Label22.Location = New System.Drawing.Point(1020, 74)
        Label22.Name = "Label22"
        Label22.Size = New System.Drawing.Size(208, 31)
        Label22.TabIndex = 108
        Label22.Text = "Batch Quantity :"
        '
        'TextBox1
        '
        Me.TextBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox1.Location = New System.Drawing.Point(1234, 70)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(146, 38)
        Me.TextBox1.TabIndex = 109
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.White
        Me.Button1.Location = New System.Drawing.Point(274, 110)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(350, 40)
        Me.Button1.TabIndex = 110
        Me.Button1.Text = "SAVE"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1775, 841)
        Me.ControlBox = False
        Me.Controls.Add(Me.Label21)
        Me.Controls.Add(Me.Label20)
        Me.Controls.Add(Me.Label19)
        Me.Controls.Add(Me.Label18)
        Me.Controls.Add(Me.Label17)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Label2)
        Me.Controls.Add(Me.ComboBox2)
        Me.Controls.Add(Label1)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.Label5)
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        CType(Me.MSDS, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Tbl_Inspection_TypeBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Tbl_Inspection_ProcessBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Tbl_Inspection_Wise_DefectsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.View_MS_PONOBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
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
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label12 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label16 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents Label17 As Label
    Friend WithEvents Label18 As Label
    Friend WithEvents Label19 As Label
    Friend WithEvents Label20 As Label
    Friend WithEvents Label21 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Button1 As Button
End Class
