<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
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
        Dim LineNameLabel As System.Windows.Forms.Label
        Dim Label15 As System.Windows.Forms.Label
        Dim Label24 As System.Windows.Forms.Label
        Dim Label28 As System.Windows.Forms.Label
        Dim Label30 As System.Windows.Forms.Label
        Dim Label32 As System.Windows.Forms.Label
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
        Me.Label23 = New System.Windows.Forms.Label()
        Me.View_MS_batched_QuantityBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Label11 = New System.Windows.Forms.Label()
        Me.LineNameComboBox = New System.Windows.Forms.ComboBox()
        Me.Tbl_PC_AMB_LineBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Button1 = New System.Windows.Forms.Button()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.RadioButton2 = New System.Windows.Forms.RadioButton()
        Me.RadioButton3 = New System.Windows.Forms.RadioButton()
        Me.RadioButton1 = New System.Windows.Forms.RadioButton()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.Tbl_Inspection_HBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Tbl_Inspection_HTableAdapter = New Machine_Stitch_Production.MSDSTableAdapters.tbl_Inspection_HTableAdapter()
        Me.Tbl_PC_AMB_LineTableAdapter = New Machine_Stitch_Production.MSDSTableAdapters.tbl_PC_AMB_LineTableAdapter()
        Me.View_MS_batched_QuantityTableAdapter = New Machine_Stitch_Production.MSDSTableAdapters.view_MS_batched_QuantityTableAdapter()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Label26 = New System.Windows.Forms.Label()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.RadioButton5 = New System.Windows.Forms.RadioButton()
        Me.RadioButton6 = New System.Windows.Forms.RadioButton()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.CheckBox3 = New System.Windows.Forms.CheckBox()
        Me.CheckBox2 = New System.Windows.Forms.CheckBox()
        Me.CheckBox1 = New System.Windows.Forms.CheckBox()
        Me.Tbl_Inspection_DBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Tbl_Inspection_DTableAdapter = New Machine_Stitch_Production.MSDSTableAdapters.tbl_Inspection_DTableAdapter()
        Me.Label25 = New System.Windows.Forms.Label()
        Me.MaxTIDBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.MaxTIDTableAdapter = New Machine_Stitch_Production.MSDSTableAdapters.maxTIDTableAdapter()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.Label31 = New System.Windows.Forms.Label()
        Me.View_inspection_QuantityBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Label29 = New System.Windows.Forms.Label()
        Me.Label27 = New System.Windows.Forms.Label()
        Me.View_inspection_QuantityTableAdapter = New Machine_Stitch_Production.MSDSTableAdapters.view_inspection_QuantityTableAdapter()
        Me.ListBox1 = New System.Windows.Forms.ListBox()
        InspectionNameLabel = New System.Windows.Forms.Label()
        Label1 = New System.Windows.Forms.Label()
        Label2 = New System.Windows.Forms.Label()
        POCodeLabel = New System.Windows.Forms.Label()
        Label6 = New System.Windows.Forms.Label()
        Label8 = New System.Windows.Forms.Label()
        Label10 = New System.Windows.Forms.Label()
        Label13 = New System.Windows.Forms.Label()
        Label22 = New System.Windows.Forms.Label()
        LineNameLabel = New System.Windows.Forms.Label()
        Label15 = New System.Windows.Forms.Label()
        Label24 = New System.Windows.Forms.Label()
        Label28 = New System.Windows.Forms.Label()
        Label30 = New System.Windows.Forms.Label()
        Label32 = New System.Windows.Forms.Label()
        CType(Me.MSDS, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Tbl_Inspection_TypeBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Tbl_Inspection_ProcessBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Tbl_Inspection_Wise_DefectsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.View_MS_PONOBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.View_MS_batched_QuantityBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Tbl_PC_AMB_LineBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.Tbl_Inspection_HBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel3.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.Tbl_Inspection_DBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MaxTIDBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel4.SuspendLayout()
        CType(Me.View_inspection_QuantityBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'InspectionNameLabel
        '
        InspectionNameLabel.AutoSize = True
        InspectionNameLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        InspectionNameLabel.Location = New System.Drawing.Point(1, 63)
        InspectionNameLabel.Name = "InspectionNameLabel"
        InspectionNameLabel.Size = New System.Drawing.Size(179, 31)
        InspectionNameLabel.TabIndex = 85
        InspectionNameLabel.Text = "Report Type :"
        '
        'Label1
        '
        Label1.AutoSize = True
        Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Label1.Location = New System.Drawing.Point(7, 19)
        Label1.Name = "Label1"
        Label1.Size = New System.Drawing.Size(211, 31)
        Label1.TabIndex = 87
        Label1.Text = "Select Process :"
        '
        'Label2
        '
        Label2.AutoSize = True
        Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Label2.Location = New System.Drawing.Point(642, 22)
        Label2.Name = "Label2"
        Label2.Size = New System.Drawing.Size(123, 31)
        Label2.TabIndex = 89
        Label2.Text = "Defects :"
        '
        'POCodeLabel
        '
        POCodeLabel.AutoSize = True
        POCodeLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        POCodeLabel.Location = New System.Drawing.Point(1, 12)
        POCodeLabel.Name = "POCodeLabel"
        POCodeLabel.Size = New System.Drawing.Size(254, 31)
        POCodeLabel.TabIndex = 91
        POCodeLabel.Text = "Select PO Number :"
        '
        'Label6
        '
        Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Label6.Location = New System.Drawing.Point(980, 12)
        Label6.Name = "Label6"
        Label6.Size = New System.Drawing.Size(177, 31)
        Label6.TabIndex = 93
        Label6.Text = "Article Code :"
        '
        'Label8
        '
        Label8.AutoSize = True
        Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Label8.Location = New System.Drawing.Point(980, 63)
        Label8.Name = "Label8"
        Label8.Size = New System.Drawing.Size(82, 31)
        Label8.TabIndex = 95
        Label8.Text = "Size :"
        '
        'Label10
        '
        Label10.AutoSize = True
        Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Label10.Location = New System.Drawing.Point(585, 12)
        Label10.Name = "Label10"
        Label10.Size = New System.Drawing.Size(193, 31)
        Label10.TabIndex = 97
        Label10.Text = "Factory Code :"
        '
        'Label13
        '
        Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Label13.Location = New System.Drawing.Point(1, 109)
        Label13.Name = "Label13"
        Label13.Size = New System.Drawing.Size(207, 31)
        Label13.TabIndex = 99
        Label13.Text = "Order Quantity :"
        AddHandler Label13.Click, AddressOf Me.Label13_Click
        '
        'Label22
        '
        Label22.AutoSize = True
        Label22.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Label22.Location = New System.Drawing.Point(447, 109)
        Label22.Name = "Label22"
        Label22.Size = New System.Drawing.Size(208, 31)
        Label22.TabIndex = 108
        Label22.Text = "Batch Quantity :"
        AddHandler Label22.Click, AddressOf Me.Label22_Click
        '
        'LineNameLabel
        '
        LineNameLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        LineNameLabel.Location = New System.Drawing.Point(585, 61)
        LineNameLabel.Name = "LineNameLabel"
        LineNameLabel.Size = New System.Drawing.Size(166, 35)
        LineNameLabel.TabIndex = 110
        LineNameLabel.Text = "Line Name:"
        '
        'Label15
        '
        Label15.AutoSize = True
        Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Label15.Location = New System.Drawing.Point(1, 155)
        Label15.Name = "Label15"
        Label15.Size = New System.Drawing.Size(228, 31)
        Label15.TabIndex = 118
        Label15.Text = "Already Batched :"
        '
        'Label24
        '
        Label24.AutoSize = True
        Label24.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Label24.Location = New System.Drawing.Point(447, 155)
        Label24.Name = "Label24"
        Label24.Size = New System.Drawing.Size(127, 31)
        Label24.TabIndex = 121
        Label24.Text = "Balance :"
        '
        'Label28
        '
        Label28.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Label28.Location = New System.Drawing.Point(-1, 23)
        Label28.Name = "Label28"
        Label28.Size = New System.Drawing.Size(151, 31)
        Label28.TabIndex = 122
        Label28.Text = "Total Checked :"
        '
        'Label30
        '
        Label30.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Label30.Location = New System.Drawing.Point(-1, 66)
        Label30.Name = "Label30"
        Label30.Size = New System.Drawing.Size(151, 31)
        Label30.TabIndex = 124
        Label30.Text = "Total Pass :"
        '
        'Label32
        '
        Label32.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Label32.Location = New System.Drawing.Point(5, 114)
        Label32.Name = "Label32"
        Label32.Size = New System.Drawing.Size(151, 31)
        Label32.TabIndex = 126
        Label32.Text = "Total Fail :"
        '
        'Label5
        '
        Me.Label5.BackColor = System.Drawing.Color.Teal
        Me.Label5.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label5.Font = New System.Drawing.Font("Georgia", 20.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(0, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(1696, 40)
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
        Me.TableAdapterManager.tbl_PC_AMB_LineTableAdapter = Nothing
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
        Me.InspectionNameComboBox.Location = New System.Drawing.Point(256, 59)
        Me.InspectionNameComboBox.Name = "InspectionNameComboBox"
        Me.InspectionNameComboBox.Size = New System.Drawing.Size(320, 39)
        Me.InspectionNameComboBox.TabIndex = 1
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
        Me.ComboBox1.Location = New System.Drawing.Point(256, 19)
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
        Me.POCodeComboBox.Location = New System.Drawing.Point(256, 8)
        Me.POCodeComboBox.Name = "POCodeComboBox"
        Me.POCodeComboBox.Size = New System.Drawing.Size(320, 39)
        Me.POCodeComboBox.TabIndex = 0
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
        Me.Panel1.Location = New System.Drawing.Point(12, 43)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(761, 50)
        Me.Panel1.TabIndex = 97
        '
        'Panel2
        '
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel2.Controls.Add(Label24)
        Me.Panel2.Controls.Add(Me.Label23)
        Me.Panel2.Controls.Add(Me.Label11)
        Me.Panel2.Controls.Add(Label15)
        Me.Panel2.Controls.Add(LineNameLabel)
        Me.Panel2.Controls.Add(Me.LineNameComboBox)
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
        Me.Panel2.Location = New System.Drawing.Point(12, 132)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1339, 202)
        Me.Panel2.TabIndex = 98
        '
        'Label23
        '
        Me.Label23.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label23.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.View_MS_batched_QuantityBindingSource, "BatchQty", True))
        Me.Label23.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label23.ForeColor = System.Drawing.Color.Red
        Me.Label23.Location = New System.Drawing.Point(654, 154)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(124, 33)
        Me.Label23.TabIndex = 120
        Me.Label23.Text = "Label23"
        Me.Label23.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'View_MS_batched_QuantityBindingSource
        '
        Me.View_MS_batched_QuantityBindingSource.DataMember = "view_MS_batched_Quantity"
        Me.View_MS_batched_QuantityBindingSource.DataSource = Me.MSDS
        '
        'Label11
        '
        Me.Label11.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label11.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.View_MS_batched_QuantityBindingSource, "BatchQty", True))
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(256, 154)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(186, 33)
        Me.Label11.TabIndex = 119
        Me.Label11.Text = "Label11"
        Me.Label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'LineNameComboBox
        '
        Me.LineNameComboBox.DataSource = Me.Tbl_PC_AMB_LineBindingSource
        Me.LineNameComboBox.DisplayMember = "LineName"
        Me.LineNameComboBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LineNameComboBox.FormattingEnabled = True
        Me.LineNameComboBox.Location = New System.Drawing.Point(793, 59)
        Me.LineNameComboBox.Name = "LineNameComboBox"
        Me.LineNameComboBox.Size = New System.Drawing.Size(181, 39)
        Me.LineNameComboBox.TabIndex = 111
        Me.LineNameComboBox.ValueMember = "LineID"
        '
        'Tbl_PC_AMB_LineBindingSource
        '
        Me.Tbl_PC_AMB_LineBindingSource.DataMember = "tbl_PC_AMB_Line"
        Me.Tbl_PC_AMB_LineBindingSource.DataSource = Me.MSDS
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.White
        Me.Button1.Location = New System.Drawing.Point(793, 104)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(508, 83)
        Me.Button1.TabIndex = 3
        Me.Button1.Text = "SAVE"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'TextBox1
        '
        Me.TextBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox1.Location = New System.Drawing.Point(654, 105)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(124, 38)
        Me.TextBox1.TabIndex = 2
        '
        'Label12
        '
        Me.Label12.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label12.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.View_MS_PONOBindingSource, "ArtSize", True))
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(1159, 62)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(142, 33)
        Me.Label12.TabIndex = 107
        Me.Label12.Text = "Label12"
        '
        'Label9
        '
        Me.Label9.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label9.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.View_MS_PONOBindingSource, "ArtCode", True))
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(1159, 11)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(142, 33)
        Me.Label9.TabIndex = 105
        Me.Label9.Text = "Label9"
        '
        'Label7
        '
        Me.Label7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label7.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.View_MS_PONOBindingSource, "OrderQty", True))
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(256, 108)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(186, 33)
        Me.Label7.TabIndex = 104
        Me.Label7.Text = "Label7"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label16
        '
        Me.Label16.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label16.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.View_MS_PONOBindingSource, "FactoryCode", True))
        Me.Label16.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.Location = New System.Drawing.Point(793, 8)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(181, 39)
        Me.Label16.TabIndex = 103
        Me.Label16.Text = "Label16"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.RadioButton2)
        Me.GroupBox1.Controls.Add(Me.RadioButton3)
        Me.GroupBox1.Controls.Add(Me.RadioButton1)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(784, 47)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(344, 79)
        Me.GroupBox1.TabIndex = 117
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Shift :"
        '
        'RadioButton2
        '
        Me.RadioButton2.AutoSize = True
        Me.RadioButton2.Location = New System.Drawing.Point(120, 29)
        Me.RadioButton2.Name = "RadioButton2"
        Me.RadioButton2.Size = New System.Drawing.Size(123, 29)
        Me.RadioButton2.TabIndex = 115
        Me.RadioButton2.Text = "After Noon"
        Me.RadioButton2.UseVisualStyleBackColor = True
        '
        'RadioButton3
        '
        Me.RadioButton3.AutoSize = True
        Me.RadioButton3.Location = New System.Drawing.Point(249, 29)
        Me.RadioButton3.Name = "RadioButton3"
        Me.RadioButton3.Size = New System.Drawing.Size(75, 29)
        Me.RadioButton3.TabIndex = 116
        Me.RadioButton3.Text = "Night"
        Me.RadioButton3.UseVisualStyleBackColor = True
        '
        'RadioButton1
        '
        Me.RadioButton1.AutoSize = True
        Me.RadioButton1.Checked = True
        Me.RadioButton1.Location = New System.Drawing.Point(13, 29)
        Me.RadioButton1.Name = "RadioButton1"
        Me.RadioButton1.Size = New System.Drawing.Size(101, 29)
        Me.RadioButton1.TabIndex = 114
        Me.RadioButton1.TabStop = True
        Me.RadioButton1.Text = "Morning"
        Me.RadioButton1.UseVisualStyleBackColor = True
        '
        'Label14
        '
        Me.Label14.BackColor = System.Drawing.Color.White
        Me.Label14.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.View_MS_PONOBindingSource, "PO", True))
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.ForeColor = System.Drawing.Color.White
        Me.Label14.Location = New System.Drawing.Point(1564, 470)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(181, 33)
        Me.Label14.TabIndex = 108
        Me.Label14.Text = "Label14"
        '
        'Label17
        '
        Me.Label17.BackColor = System.Drawing.Color.White
        Me.Label17.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.View_MS_PONOBindingSource, "ArtID", True))
        Me.Label17.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.ForeColor = System.Drawing.Color.White
        Me.Label17.Location = New System.Drawing.Point(1436, 648)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(181, 33)
        Me.Label17.TabIndex = 109
        Me.Label17.Text = "Label17"
        '
        'Label18
        '
        Me.Label18.BackColor = System.Drawing.Color.White
        Me.Label18.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.View_MS_PONOBindingSource, "ModelID", True))
        Me.Label18.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.ForeColor = System.Drawing.Color.White
        Me.Label18.Location = New System.Drawing.Point(1564, 615)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(181, 33)
        Me.Label18.TabIndex = 110
        Me.Label18.Text = "Label18"
        '
        'Label19
        '
        Me.Label19.BackColor = System.Drawing.Color.White
        Me.Label19.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.View_MS_PONOBindingSource, "ClientID", True))
        Me.Label19.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.ForeColor = System.Drawing.Color.White
        Me.Label19.Location = New System.Drawing.Point(1564, 579)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(181, 33)
        Me.Label19.TabIndex = 111
        Me.Label19.Text = "Label19"
        '
        'Label20
        '
        Me.Label20.BackColor = System.Drawing.Color.White
        Me.Label20.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.View_MS_PONOBindingSource, "POD", True))
        Me.Label20.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label20.ForeColor = System.Drawing.Color.White
        Me.Label20.Location = New System.Drawing.Point(1564, 546)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(181, 33)
        Me.Label20.TabIndex = 112
        Me.Label20.Text = "Label20"
        '
        'Label21
        '
        Me.Label21.BackColor = System.Drawing.Color.White
        Me.Label21.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.View_MS_PONOBindingSource, "POM", True))
        Me.Label21.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label21.ForeColor = System.Drawing.Color.White
        Me.Label21.Location = New System.Drawing.Point(1564, 503)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(181, 33)
        Me.Label21.TabIndex = 113
        Me.Label21.Text = "Label21"
        '
        'Tbl_Inspection_HBindingSource
        '
        Me.Tbl_Inspection_HBindingSource.DataMember = "tbl_Inspection_H"
        Me.Tbl_Inspection_HBindingSource.DataSource = Me.MSDS
        '
        'Tbl_Inspection_HTableAdapter
        '
        Me.Tbl_Inspection_HTableAdapter.ClearBeforeFill = True
        '
        'Tbl_PC_AMB_LineTableAdapter
        '
        Me.Tbl_PC_AMB_LineTableAdapter.ClearBeforeFill = True
        '
        'View_MS_batched_QuantityTableAdapter
        '
        Me.View_MS_batched_QuantityTableAdapter.ClearBeforeFill = True
        '
        'Panel3
        '
        Me.Panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel3.Controls.Add(Me.ListBox1)
        Me.Panel3.Controls.Add(Me.Label26)
        Me.Panel3.Controls.Add(Me.TextBox2)
        Me.Panel3.Controls.Add(Me.GroupBox3)
        Me.Panel3.Controls.Add(Me.Button2)
        Me.Panel3.Controls.Add(Me.GroupBox2)
        Me.Panel3.Controls.Add(Me.ComboBox1)
        Me.Panel3.Controls.Add(Label1)
        Me.Panel3.Controls.Add(Label2)
        Me.Panel3.Location = New System.Drawing.Point(12, 340)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(1604, 474)
        Me.Panel3.TabIndex = 118
        '
        'Label26
        '
        Me.Label26.AutoSize = True
        Me.Label26.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label26.Location = New System.Drawing.Point(37, 158)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(218, 31)
        Me.Label26.TabIndex = 123
        Me.Label26.Text = "Defets Quantity :"
        '
        'TextBox2
        '
        Me.TextBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox2.Location = New System.Drawing.Point(261, 151)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(142, 38)
        Me.TextBox2.TabIndex = 122
        Me.TextBox2.Visible = False
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.RadioButton5)
        Me.GroupBox3.Controls.Add(Me.RadioButton6)
        Me.GroupBox3.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox3.Location = New System.Drawing.Point(256, 64)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(227, 79)
        Me.GroupBox3.TabIndex = 118
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Defect Quantity :"
        '
        'RadioButton5
        '
        Me.RadioButton5.AutoSize = True
        Me.RadioButton5.Location = New System.Drawing.Point(120, 29)
        Me.RadioButton5.Name = "RadioButton5"
        Me.RadioButton5.Size = New System.Drawing.Size(95, 29)
        Me.RadioButton5.TabIndex = 116
        Me.RadioButton5.Text = "Manual"
        Me.RadioButton5.UseVisualStyleBackColor = True
        '
        'RadioButton6
        '
        Me.RadioButton6.AutoSize = True
        Me.RadioButton6.Checked = True
        Me.RadioButton6.Location = New System.Drawing.Point(13, 29)
        Me.RadioButton6.Name = "RadioButton6"
        Me.RadioButton6.Size = New System.Drawing.Size(85, 29)
        Me.RadioButton6.TabIndex = 114
        Me.RadioButton6.TabStop = True
        Me.RadioButton6.Text = "Single"
        Me.RadioButton6.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.ForeColor = System.Drawing.Color.White
        Me.Button2.Location = New System.Drawing.Point(453, 247)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(297, 60)
        Me.Button2.TabIndex = 122
        Me.Button2.Text = "ADD"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.CheckBox3)
        Me.GroupBox2.Controls.Add(Me.CheckBox2)
        Me.GroupBox2.Controls.Add(Me.CheckBox1)
        Me.GroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(489, 74)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(271, 137)
        Me.GroupBox2.TabIndex = 118
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Validations and Checklists :"
        '
        'CheckBox3
        '
        Me.CheckBox3.AutoSize = True
        Me.CheckBox3.Checked = True
        Me.CheckBox3.CheckState = System.Windows.Forms.CheckState.Checked
        Me.CheckBox3.Location = New System.Drawing.Point(29, 99)
        Me.CheckBox3.Name = "CheckBox3"
        Me.CheckBox3.Size = New System.Drawing.Size(166, 29)
        Me.CheckBox3.TabIndex = 2
        Me.CheckBox3.Text = "Metal Detection"
        Me.CheckBox3.UseVisualStyleBackColor = True
        '
        'CheckBox2
        '
        Me.CheckBox2.AutoSize = True
        Me.CheckBox2.Checked = True
        Me.CheckBox2.CheckState = System.Windows.Forms.CheckState.Checked
        Me.CheckBox2.Location = New System.Drawing.Point(29, 64)
        Me.CheckBox2.Name = "CheckBox2"
        Me.CheckBox2.Size = New System.Drawing.Size(169, 29)
        Me.CheckBox2.TabIndex = 1
        Me.CheckBox2.Text = "Sealing Sample"
        Me.CheckBox2.UseVisualStyleBackColor = True
        '
        'CheckBox1
        '
        Me.CheckBox1.AutoSize = True
        Me.CheckBox1.Checked = True
        Me.CheckBox1.CheckState = System.Windows.Forms.CheckState.Checked
        Me.CheckBox1.Location = New System.Drawing.Point(29, 29)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(208, 29)
        Me.CheckBox1.TabIndex = 0
        Me.CheckBox1.Text = "Parameters / Setting"
        Me.CheckBox1.UseVisualStyleBackColor = True
        '
        'Tbl_Inspection_DBindingSource
        '
        Me.Tbl_Inspection_DBindingSource.DataMember = "tbl_Inspection_H_tbl_Inspection_D"
        Me.Tbl_Inspection_DBindingSource.DataSource = Me.Tbl_Inspection_HBindingSource
        '
        'Tbl_Inspection_DTableAdapter
        '
        Me.Tbl_Inspection_DTableAdapter.ClearBeforeFill = True
        '
        'Label25
        '
        Me.Label25.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MaxTIDBindingSource, "TID", True))
        Me.Label25.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label25.ForeColor = System.Drawing.Color.White
        Me.Label25.Location = New System.Drawing.Point(1411, 192)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(142, 33)
        Me.Label25.TabIndex = 122
        Me.Label25.Text = "Label25"
        Me.Label25.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'MaxTIDBindingSource
        '
        Me.MaxTIDBindingSource.DataMember = "maxTID"
        Me.MaxTIDBindingSource.DataSource = Me.MSDS
        '
        'MaxTIDTableAdapter
        '
        Me.MaxTIDTableAdapter.ClearBeforeFill = True
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.Color.DarkGreen
        Me.Button3.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.ForeColor = System.Drawing.Color.White
        Me.Button3.Location = New System.Drawing.Point(1134, 43)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(482, 73)
        Me.Button3.TabIndex = 123
        Me.Button3.Text = "Add New Inspection"
        Me.Button3.UseVisualStyleBackColor = False
        '
        'Button4
        '
        Me.Button4.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Button4.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button4.ForeColor = System.Drawing.Color.White
        Me.Button4.Location = New System.Drawing.Point(1357, 288)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(259, 46)
        Me.Button4.TabIndex = 124
        Me.Button4.Text = "Exit"
        Me.Button4.UseVisualStyleBackColor = False
        '
        'Panel4
        '
        Me.Panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel4.Controls.Add(Me.Label31)
        Me.Panel4.Controls.Add(Label32)
        Me.Panel4.Controls.Add(Me.Label29)
        Me.Panel4.Controls.Add(Label30)
        Me.Panel4.Controls.Add(Me.Label27)
        Me.Panel4.Controls.Add(Label28)
        Me.Panel4.Location = New System.Drawing.Point(1357, 125)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(259, 163)
        Me.Panel4.TabIndex = 125
        '
        'Label31
        '
        Me.Label31.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label31.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.View_inspection_QuantityBindingSource, "Quantity", True))
        Me.Label31.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label31.Location = New System.Drawing.Point(148, 114)
        Me.Label31.Name = "Label31"
        Me.Label31.Size = New System.Drawing.Size(104, 33)
        Me.Label31.TabIndex = 127
        Me.Label31.Text = "Label31"
        Me.Label31.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'View_inspection_QuantityBindingSource
        '
        Me.View_inspection_QuantityBindingSource.DataMember = "view_inspection_Quantity"
        Me.View_inspection_QuantityBindingSource.DataSource = Me.MSDS
        '
        'Label29
        '
        Me.Label29.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label29.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.View_inspection_QuantityBindingSource, "Pass", True))
        Me.Label29.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label29.Location = New System.Drawing.Point(148, 66)
        Me.Label29.Name = "Label29"
        Me.Label29.Size = New System.Drawing.Size(104, 33)
        Me.Label29.TabIndex = 125
        Me.Label29.Text = "Label29"
        Me.Label29.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label27
        '
        Me.Label27.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label27.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.View_inspection_QuantityBindingSource, "BatchQty", True))
        Me.Label27.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label27.Location = New System.Drawing.Point(148, 23)
        Me.Label27.Name = "Label27"
        Me.Label27.Size = New System.Drawing.Size(104, 33)
        Me.Label27.TabIndex = 123
        Me.Label27.Text = "Label27"
        Me.Label27.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'View_inspection_QuantityTableAdapter
        '
        Me.View_inspection_QuantityTableAdapter.ClearBeforeFill = True
        '
        'ListBox1
        '
        Me.ListBox1.DataSource = Me.Tbl_Inspection_Wise_DefectsBindingSource
        Me.ListBox1.DisplayMember = "DefectName"
        Me.ListBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ListBox1.FormattingEnabled = True
        Me.ListBox1.ItemHeight = 31
        Me.ListBox1.Location = New System.Drawing.Point(771, 19)
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.Size = New System.Drawing.Size(813, 438)
        Me.ListBox1.TabIndex = 125
        Me.ListBox1.ValueMember = "DefectID"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1696, 818)
        Me.ControlBox = False
        Me.Controls.Add(Me.Panel4)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Label25)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Label21)
        Me.Controls.Add(Me.Label20)
        Me.Controls.Add(Me.Label19)
        Me.Controls.Add(Me.Label18)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label17)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
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
        CType(Me.View_MS_batched_QuantityBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Tbl_PC_AMB_LineBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.Tbl_Inspection_HBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.Tbl_Inspection_DBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MaxTIDBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel4.ResumeLayout(False)
        CType(Me.View_inspection_QuantityBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Label5 As Label
    Friend WithEvents MSDS As MSDS
    Friend WithEvents Tbl_Inspection_TypeBindingSource As BindingSource
    Friend WithEvents Tbl_Inspection_TypeTableAdapter As MSDSTableAdapters.tbl_Inspection_TypeTableAdapter
    Friend WithEvents TableAdapterManager As MSDSTableAdapters.TableAdapterManager
    Friend WithEvents InspectionNameComboBox As ComboBox
    Friend WithEvents ComboBox1 As ComboBox
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
    Friend WithEvents Tbl_Inspection_HBindingSource As BindingSource
    Friend WithEvents Tbl_Inspection_HTableAdapter As MSDSTableAdapters.tbl_Inspection_HTableAdapter
    Friend WithEvents Tbl_PC_AMB_LineBindingSource As BindingSource
    Friend WithEvents Tbl_PC_AMB_LineTableAdapter As MSDSTableAdapters.tbl_PC_AMB_LineTableAdapter
    Friend WithEvents LineNameComboBox As ComboBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents RadioButton2 As RadioButton
    Friend WithEvents RadioButton3 As RadioButton
    Friend WithEvents RadioButton1 As RadioButton
    Friend WithEvents Label11 As Label
    Friend WithEvents View_MS_batched_QuantityBindingSource As BindingSource
    Friend WithEvents View_MS_batched_QuantityTableAdapter As MSDSTableAdapters.view_MS_batched_QuantityTableAdapter
    Friend WithEvents Label23 As Label
    Friend WithEvents Panel3 As Panel
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents CheckBox3 As CheckBox
    Friend WithEvents CheckBox2 As CheckBox
    Friend WithEvents CheckBox1 As CheckBox
    Friend WithEvents Button2 As Button
    Friend WithEvents Tbl_Inspection_DBindingSource As BindingSource
    Friend WithEvents Tbl_Inspection_DTableAdapter As MSDSTableAdapters.tbl_Inspection_DTableAdapter
    Friend WithEvents Label25 As Label
    Friend WithEvents MaxTIDBindingSource As BindingSource
    Friend WithEvents MaxTIDTableAdapter As MSDSTableAdapters.maxTIDTableAdapter
    Friend WithEvents Button3 As Button
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents RadioButton5 As RadioButton
    Friend WithEvents RadioButton6 As RadioButton
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents Label26 As Label
    Friend WithEvents Button4 As Button
    Friend WithEvents Panel4 As Panel
    Friend WithEvents Label27 As Label
    Friend WithEvents Label31 As Label
    Friend WithEvents Label29 As Label
    Friend WithEvents View_inspection_QuantityBindingSource As BindingSource
    Friend WithEvents View_inspection_QuantityTableAdapter As MSDSTableAdapters.view_inspection_QuantityTableAdapter
    Friend WithEvents ListBox1 As ListBox
End Class
