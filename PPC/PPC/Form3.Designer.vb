﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PA
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
        Dim Job_Card_NoLabel As System.Windows.Forms.Label
        Dim Schedule_DateLabel As System.Windows.Forms.Label
        Dim Schedule_QuantityLabel As System.Windows.Forms.Label
        Dim Weight_Per_PeiceLabel As System.Windows.Forms.Label
        Dim Part_NumberLabel As System.Windows.Forms.Label
        Dim CustomerLabel As System.Windows.Forms.Label
        Dim Grade_1Label As System.Windows.Forms.Label
        Dim DiscriptionLabel As System.Windows.Forms.Label
        Dim BalenceLabel As System.Windows.Forms.Label
        Dim Die_NumberLabel As System.Windows.Forms.Label
        Dim RateLabel As System.Windows.Forms.Label
        Dim Year_JCLabel As System.Windows.Forms.Label
        Dim Month_JCLabel As System.Windows.Forms.Label
        Dim Current_StockLabel As System.Windows.Forms.Label
        Dim TonnageLabel As System.Windows.Forms.Label
        Dim Balance_tonnageLabel As System.Windows.Forms.Label
        Dim SectionLabel As System.Windows.Forms.Label
        Dim Balance_To_PlanLabel As System.Windows.Forms.Label
        Dim HammerLabel As System.Windows.Forms.Label
        Dim Left_To_ProduceLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(PA))
        Me.PPC_JOBCARDBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorAddNewItem = New System.Windows.Forms.ToolStripButton()
        Me.PPC_JOBCARDBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.OMMI_2007DataSet1 = New PPC.OMMI_2007DataSet1()
        Me.BindingNavigatorCountItem = New System.Windows.Forms.ToolStripLabel()
        Me.BindingNavigatorDeleteItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveFirstItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMovePreviousItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorPositionItem = New System.Windows.Forms.ToolStripTextBox()
        Me.BindingNavigatorSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorMoveNextItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveLastItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.PPC_JOBCARDBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.Job_Card_NoTextBox = New System.Windows.Forms.TextBox()
        Me.DateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.Schedule_QuantityTextBox = New System.Windows.Forms.TextBox()
        Me.Weight_Per_PeiceTextBox = New System.Windows.Forms.TextBox()
        Me.Part_NumberTextBox = New System.Windows.Forms.TextBox()
        Me.CustomerTextBox = New System.Windows.Forms.TextBox()
        Me.Grade_1TextBox = New System.Windows.Forms.TextBox()
        Me.DiscriptionTextBox = New System.Windows.Forms.TextBox()
        Me.BalenceTextBox = New System.Windows.Forms.TextBox()
        Me.Die_NumberTextBox = New System.Windows.Forms.TextBox()
        Me.RateTextBox = New System.Windows.Forms.TextBox()
        Me.Year_JCTextBox = New System.Windows.Forms.TextBox()
        Me.Month_JCTextBox = New System.Windows.Forms.TextBox()
        Me.Current_StockTextBox = New System.Windows.Forms.TextBox()
        Me.TonnageTextBox = New System.Windows.Forms.TextBox()
        Me.Balance_tonnageTextBox = New System.Windows.Forms.TextBox()
        Me.SectionTextBox = New System.Windows.Forms.TextBox()
        Me.Balance_To_PlanTextBox = New System.Windows.Forms.TextBox()
        Me.H5 = New System.Windows.Forms.RadioButton()
        Me.H4 = New System.Windows.Forms.RadioButton()
        Me.H3 = New System.Windows.Forms.RadioButton()
        Me.H2 = New System.Windows.Forms.RadioButton()
        Me.H1 = New System.Windows.Forms.RadioButton()
        Me.PPC_JOBCARDTableAdapter = New PPC.OMMI_2007DataSet1TableAdapters.PPC_JOBCARDTableAdapter()
        Me.TableAdapterManager = New PPC.OMMI_2007DataSet1TableAdapters.TableAdapterManager()
        Me.Plan = New System.Windows.Forms.Button()
        Me.HammerTextBox = New System.Windows.Forms.TextBox()
        Me.Left_To_ProduceTextBox = New System.Windows.Forms.TextBox()
        Job_Card_NoLabel = New System.Windows.Forms.Label()
        Schedule_DateLabel = New System.Windows.Forms.Label()
        Schedule_QuantityLabel = New System.Windows.Forms.Label()
        Weight_Per_PeiceLabel = New System.Windows.Forms.Label()
        Part_NumberLabel = New System.Windows.Forms.Label()
        CustomerLabel = New System.Windows.Forms.Label()
        Grade_1Label = New System.Windows.Forms.Label()
        DiscriptionLabel = New System.Windows.Forms.Label()
        BalenceLabel = New System.Windows.Forms.Label()
        Die_NumberLabel = New System.Windows.Forms.Label()
        RateLabel = New System.Windows.Forms.Label()
        Year_JCLabel = New System.Windows.Forms.Label()
        Month_JCLabel = New System.Windows.Forms.Label()
        Current_StockLabel = New System.Windows.Forms.Label()
        TonnageLabel = New System.Windows.Forms.Label()
        Balance_tonnageLabel = New System.Windows.Forms.Label()
        SectionLabel = New System.Windows.Forms.Label()
        Balance_To_PlanLabel = New System.Windows.Forms.Label()
        HammerLabel = New System.Windows.Forms.Label()
        Left_To_ProduceLabel = New System.Windows.Forms.Label()
        CType(Me.PPC_JOBCARDBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PPC_JOBCARDBindingNavigator.SuspendLayout()
        CType(Me.PPC_JOBCARDBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.OMMI_2007DataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Job_Card_NoLabel
        '
        Job_Card_NoLabel.AutoSize = True
        Job_Card_NoLabel.Location = New System.Drawing.Point(153, 117)
        Job_Card_NoLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Job_Card_NoLabel.Name = "Job_Card_NoLabel"
        Job_Card_NoLabel.Size = New System.Drawing.Size(91, 17)
        Job_Card_NoLabel.TabIndex = 1
        Job_Card_NoLabel.Text = "Job Card No:"
        '
        'Schedule_DateLabel
        '
        Schedule_DateLabel.AutoSize = True
        Schedule_DateLabel.Location = New System.Drawing.Point(153, 150)
        Schedule_DateLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Schedule_DateLabel.Name = "Schedule_DateLabel"
        Schedule_DateLabel.Size = New System.Drawing.Size(105, 17)
        Schedule_DateLabel.TabIndex = 3
        Schedule_DateLabel.Text = "Schedule Date:"
        '
        'Schedule_QuantityLabel
        '
        Schedule_QuantityLabel.AutoSize = True
        Schedule_QuantityLabel.Location = New System.Drawing.Point(153, 181)
        Schedule_QuantityLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Schedule_QuantityLabel.Name = "Schedule_QuantityLabel"
        Schedule_QuantityLabel.Size = New System.Drawing.Size(128, 17)
        Schedule_QuantityLabel.TabIndex = 5
        Schedule_QuantityLabel.Text = "Schedule Quantity:"
        '
        'Weight_Per_PeiceLabel
        '
        Weight_Per_PeiceLabel.AutoSize = True
        Weight_Per_PeiceLabel.Location = New System.Drawing.Point(669, 288)
        Weight_Per_PeiceLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Weight_Per_PeiceLabel.Name = "Weight_Per_PeiceLabel"
        Weight_Per_PeiceLabel.Size = New System.Drawing.Size(121, 17)
        Weight_Per_PeiceLabel.TabIndex = 7
        Weight_Per_PeiceLabel.Text = "Weight Per Peice:"
        '
        'Part_NumberLabel
        '
        Part_NumberLabel.AutoSize = True
        Part_NumberLabel.Location = New System.Drawing.Point(153, 224)
        Part_NumberLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Part_NumberLabel.Name = "Part_NumberLabel"
        Part_NumberLabel.Size = New System.Drawing.Size(92, 17)
        Part_NumberLabel.TabIndex = 9
        Part_NumberLabel.Text = "Part Number:"
        '
        'CustomerLabel
        '
        CustomerLabel.AutoSize = True
        CustomerLabel.Location = New System.Drawing.Point(153, 256)
        CustomerLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        CustomerLabel.Name = "CustomerLabel"
        CustomerLabel.Size = New System.Drawing.Size(72, 17)
        CustomerLabel.TabIndex = 11
        CustomerLabel.Text = "Customer:"
        '
        'Grade_1Label
        '
        Grade_1Label.AutoSize = True
        Grade_1Label.Location = New System.Drawing.Point(153, 288)
        Grade_1Label.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Grade_1Label.Name = "Grade_1Label"
        Grade_1Label.Size = New System.Drawing.Size(64, 17)
        Grade_1Label.TabIndex = 13
        Grade_1Label.Text = "Grade 1:"
        '
        'DiscriptionLabel
        '
        DiscriptionLabel.AutoSize = True
        DiscriptionLabel.Location = New System.Drawing.Point(153, 320)
        DiscriptionLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        DiscriptionLabel.Name = "DiscriptionLabel"
        DiscriptionLabel.Size = New System.Drawing.Size(78, 17)
        DiscriptionLabel.TabIndex = 15
        DiscriptionLabel.Text = "Discription:"
        '
        'BalenceLabel
        '
        BalenceLabel.AutoSize = True
        BalenceLabel.Location = New System.Drawing.Point(669, 318)
        BalenceLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        BalenceLabel.Name = "BalenceLabel"
        BalenceLabel.Size = New System.Drawing.Size(63, 17)
        BalenceLabel.TabIndex = 17
        BalenceLabel.Text = "Balence:"
        '
        'Die_NumberLabel
        '
        Die_NumberLabel.AutoSize = True
        Die_NumberLabel.Location = New System.Drawing.Point(153, 350)
        Die_NumberLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Die_NumberLabel.Name = "Die_NumberLabel"
        Die_NumberLabel.Size = New System.Drawing.Size(87, 17)
        Die_NumberLabel.TabIndex = 19
        Die_NumberLabel.Text = "Die Number:"
        '
        'RateLabel
        '
        RateLabel.AutoSize = True
        RateLabel.Location = New System.Drawing.Point(153, 382)
        RateLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        RateLabel.Name = "RateLabel"
        RateLabel.Size = New System.Drawing.Size(42, 17)
        RateLabel.TabIndex = 21
        RateLabel.Text = "Rate:"
        '
        'Year_JCLabel
        '
        Year_JCLabel.AutoSize = True
        Year_JCLabel.Location = New System.Drawing.Point(158, 412)
        Year_JCLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Year_JCLabel.Name = "Year_JCLabel"
        Year_JCLabel.Size = New System.Drawing.Size(62, 17)
        Year_JCLabel.TabIndex = 23
        Year_JCLabel.Text = "Year JC:"
        AddHandler Year_JCLabel.Click, AddressOf Me.Year_JCLabel_Click
        '
        'Month_JCLabel
        '
        Month_JCLabel.AutoSize = True
        Month_JCLabel.Location = New System.Drawing.Point(676, 120)
        Month_JCLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Month_JCLabel.Name = "Month_JCLabel"
        Month_JCLabel.Size = New System.Drawing.Size(71, 17)
        Month_JCLabel.TabIndex = 25
        Month_JCLabel.Text = "Month JC:"
        '
        'Current_StockLabel
        '
        Current_StockLabel.AutoSize = True
        Current_StockLabel.Location = New System.Drawing.Point(673, 151)
        Current_StockLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Current_StockLabel.Name = "Current_StockLabel"
        Current_StockLabel.Size = New System.Drawing.Size(98, 17)
        Current_StockLabel.TabIndex = 27
        Current_StockLabel.Text = "Current Stock:"
        '
        'TonnageLabel
        '
        TonnageLabel.AutoSize = True
        TonnageLabel.Location = New System.Drawing.Point(669, 348)
        TonnageLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        TonnageLabel.Name = "TonnageLabel"
        TonnageLabel.Size = New System.Drawing.Size(69, 17)
        TonnageLabel.TabIndex = 29
        TonnageLabel.Text = "Tonnage:"
        '
        'Balance_tonnageLabel
        '
        Balance_tonnageLabel.AutoSize = True
        Balance_tonnageLabel.Location = New System.Drawing.Point(669, 413)
        Balance_tonnageLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Balance_tonnageLabel.Name = "Balance_tonnageLabel"
        Balance_tonnageLabel.Size = New System.Drawing.Size(119, 17)
        Balance_tonnageLabel.TabIndex = 31
        Balance_tonnageLabel.Text = "Balance tonnage:"
        '
        'SectionLabel
        '
        SectionLabel.AutoSize = True
        SectionLabel.Location = New System.Drawing.Point(673, 181)
        SectionLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        SectionLabel.Name = "SectionLabel"
        SectionLabel.Size = New System.Drawing.Size(59, 17)
        SectionLabel.TabIndex = 33
        SectionLabel.Text = "Section:"
        '
        'Balance_To_PlanLabel
        '
        Balance_To_PlanLabel.AutoSize = True
        Balance_To_PlanLabel.Location = New System.Drawing.Point(669, 378)
        Balance_To_PlanLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Balance_To_PlanLabel.Name = "Balance_To_PlanLabel"
        Balance_To_PlanLabel.Size = New System.Drawing.Size(116, 17)
        Balance_To_PlanLabel.TabIndex = 35
        Balance_To_PlanLabel.Text = "Balance To Plan:"
        '
        'HammerLabel
        '
        HammerLabel.AutoSize = True
        HammerLabel.Location = New System.Drawing.Point(673, 249)
        HammerLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        HammerLabel.Name = "HammerLabel"
        HammerLabel.Size = New System.Drawing.Size(65, 17)
        HammerLabel.TabIndex = 39
        HammerLabel.Text = "Hammer:"
        HammerLabel.Visible = False
        AddHandler HammerLabel.Click, AddressOf Me.HammerLabel_Click
        '
        'Left_To_ProduceLabel
        '
        Left_To_ProduceLabel.AutoSize = True
        Left_To_ProduceLabel.Location = New System.Drawing.Point(673, 217)
        Left_To_ProduceLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Left_To_ProduceLabel.Name = "Left_To_ProduceLabel"
        Left_To_ProduceLabel.Size = New System.Drawing.Size(114, 17)
        Left_To_ProduceLabel.TabIndex = 37
        Left_To_ProduceLabel.Text = "Left To Produce:"
        '
        'PPC_JOBCARDBindingNavigator
        '
        Me.PPC_JOBCARDBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.PPC_JOBCARDBindingNavigator.BindingSource = Me.PPC_JOBCARDBindingSource
        Me.PPC_JOBCARDBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.PPC_JOBCARDBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.PPC_JOBCARDBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.PPC_JOBCARDBindingNavigatorSaveItem})
        Me.PPC_JOBCARDBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.PPC_JOBCARDBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.PPC_JOBCARDBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.PPC_JOBCARDBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.PPC_JOBCARDBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.PPC_JOBCARDBindingNavigator.Name = "PPC_JOBCARDBindingNavigator"
        Me.PPC_JOBCARDBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.PPC_JOBCARDBindingNavigator.Size = New System.Drawing.Size(1365, 27)
        Me.PPC_JOBCARDBindingNavigator.TabIndex = 0
        Me.PPC_JOBCARDBindingNavigator.Text = "BindingNavigator1"
        '
        'BindingNavigatorAddNewItem
        '
        Me.BindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorAddNewItem.Image = CType(resources.GetObject("BindingNavigatorAddNewItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorAddNewItem.Name = "BindingNavigatorAddNewItem"
        Me.BindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorAddNewItem.Size = New System.Drawing.Size(23, 24)
        Me.BindingNavigatorAddNewItem.Text = "Add new"
        '
        'PPC_JOBCARDBindingSource
        '
        Me.PPC_JOBCARDBindingSource.DataMember = "PPC_JOBCARD"
        Me.PPC_JOBCARDBindingSource.DataSource = Me.OMMI_2007DataSet1
        '
        'OMMI_2007DataSet1
        '
        Me.OMMI_2007DataSet1.DataSetName = "OMMI_2007DataSet1"
        Me.OMMI_2007DataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'BindingNavigatorCountItem
        '
        Me.BindingNavigatorCountItem.Name = "BindingNavigatorCountItem"
        Me.BindingNavigatorCountItem.Size = New System.Drawing.Size(45, 24)
        Me.BindingNavigatorCountItem.Text = "of {0}"
        Me.BindingNavigatorCountItem.ToolTipText = "Total number of items"
        '
        'BindingNavigatorDeleteItem
        '
        Me.BindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorDeleteItem.Image = CType(resources.GetObject("BindingNavigatorDeleteItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorDeleteItem.Name = "BindingNavigatorDeleteItem"
        Me.BindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorDeleteItem.Size = New System.Drawing.Size(23, 24)
        Me.BindingNavigatorDeleteItem.Text = "Delete"
        '
        'BindingNavigatorMoveFirstItem
        '
        Me.BindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveFirstItem.Image = CType(resources.GetObject("BindingNavigatorMoveFirstItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveFirstItem.Name = "BindingNavigatorMoveFirstItem"
        Me.BindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveFirstItem.Size = New System.Drawing.Size(23, 24)
        Me.BindingNavigatorMoveFirstItem.Text = "Move first"
        '
        'BindingNavigatorMovePreviousItem
        '
        Me.BindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMovePreviousItem.Image = CType(resources.GetObject("BindingNavigatorMovePreviousItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMovePreviousItem.Name = "BindingNavigatorMovePreviousItem"
        Me.BindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMovePreviousItem.Size = New System.Drawing.Size(23, 24)
        Me.BindingNavigatorMovePreviousItem.Text = "Move previous"
        '
        'BindingNavigatorSeparator
        '
        Me.BindingNavigatorSeparator.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator.Size = New System.Drawing.Size(6, 27)
        '
        'BindingNavigatorPositionItem
        '
        Me.BindingNavigatorPositionItem.AccessibleName = "Position"
        Me.BindingNavigatorPositionItem.AutoSize = False
        Me.BindingNavigatorPositionItem.Name = "BindingNavigatorPositionItem"
        Me.BindingNavigatorPositionItem.Size = New System.Drawing.Size(65, 27)
        Me.BindingNavigatorPositionItem.Text = "0"
        Me.BindingNavigatorPositionItem.ToolTipText = "Current position"
        '
        'BindingNavigatorSeparator1
        '
        Me.BindingNavigatorSeparator1.Name = "BindingNavigatorSeparator1"
        Me.BindingNavigatorSeparator1.Size = New System.Drawing.Size(6, 27)
        '
        'BindingNavigatorMoveNextItem
        '
        Me.BindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveNextItem.Image = CType(resources.GetObject("BindingNavigatorMoveNextItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveNextItem.Name = "BindingNavigatorMoveNextItem"
        Me.BindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveNextItem.Size = New System.Drawing.Size(23, 24)
        Me.BindingNavigatorMoveNextItem.Text = "Move next"
        '
        'BindingNavigatorMoveLastItem
        '
        Me.BindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveLastItem.Image = CType(resources.GetObject("BindingNavigatorMoveLastItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveLastItem.Name = "BindingNavigatorMoveLastItem"
        Me.BindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveLastItem.Size = New System.Drawing.Size(23, 24)
        Me.BindingNavigatorMoveLastItem.Text = "Move last"
        '
        'BindingNavigatorSeparator2
        '
        Me.BindingNavigatorSeparator2.Name = "BindingNavigatorSeparator2"
        Me.BindingNavigatorSeparator2.Size = New System.Drawing.Size(6, 27)
        '
        'PPC_JOBCARDBindingNavigatorSaveItem
        '
        Me.PPC_JOBCARDBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.PPC_JOBCARDBindingNavigatorSaveItem.Image = CType(resources.GetObject("PPC_JOBCARDBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.PPC_JOBCARDBindingNavigatorSaveItem.Name = "PPC_JOBCARDBindingNavigatorSaveItem"
        Me.PPC_JOBCARDBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 24)
        Me.PPC_JOBCARDBindingNavigatorSaveItem.Text = "Save Data"
        '
        'Job_Card_NoTextBox
        '
        Me.Job_Card_NoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PPC_JOBCARDBindingSource, "Job Card No", True))
        Me.Job_Card_NoTextBox.Location = New System.Drawing.Point(291, 113)
        Me.Job_Card_NoTextBox.Margin = New System.Windows.Forms.Padding(4)
        Me.Job_Card_NoTextBox.Name = "Job_Card_NoTextBox"
        Me.Job_Card_NoTextBox.Size = New System.Drawing.Size(265, 22)
        Me.Job_Card_NoTextBox.TabIndex = 2
        '
        'DateTimePicker
        '
        Me.DateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.PPC_JOBCARDBindingSource, "Schedule Date", True))
        Me.DateTimePicker.Location = New System.Drawing.Point(291, 145)
        Me.DateTimePicker.Margin = New System.Windows.Forms.Padding(4)
        Me.DateTimePicker.Name = "DateTimePicker"
        Me.DateTimePicker.Size = New System.Drawing.Size(265, 22)
        Me.DateTimePicker.TabIndex = 4
        '
        'Schedule_QuantityTextBox
        '
        Me.Schedule_QuantityTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PPC_JOBCARDBindingSource, "Schedule Quantity", True))
        Me.Schedule_QuantityTextBox.Location = New System.Drawing.Point(291, 177)
        Me.Schedule_QuantityTextBox.Margin = New System.Windows.Forms.Padding(4)
        Me.Schedule_QuantityTextBox.Name = "Schedule_QuantityTextBox"
        Me.Schedule_QuantityTextBox.Size = New System.Drawing.Size(265, 22)
        Me.Schedule_QuantityTextBox.TabIndex = 6
        '
        'Weight_Per_PeiceTextBox
        '
        Me.Weight_Per_PeiceTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PPC_JOBCARDBindingSource, "Weight Per Peice", True))
        Me.Weight_Per_PeiceTextBox.Location = New System.Drawing.Point(807, 284)
        Me.Weight_Per_PeiceTextBox.Margin = New System.Windows.Forms.Padding(4)
        Me.Weight_Per_PeiceTextBox.Name = "Weight_Per_PeiceTextBox"
        Me.Weight_Per_PeiceTextBox.Size = New System.Drawing.Size(265, 22)
        Me.Weight_Per_PeiceTextBox.TabIndex = 8
        '
        'Part_NumberTextBox
        '
        Me.Part_NumberTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PPC_JOBCARDBindingSource, "Part Number", True))
        Me.Part_NumberTextBox.Location = New System.Drawing.Point(291, 220)
        Me.Part_NumberTextBox.Margin = New System.Windows.Forms.Padding(4)
        Me.Part_NumberTextBox.Name = "Part_NumberTextBox"
        Me.Part_NumberTextBox.Size = New System.Drawing.Size(265, 22)
        Me.Part_NumberTextBox.TabIndex = 10
        '
        'CustomerTextBox
        '
        Me.CustomerTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PPC_JOBCARDBindingSource, "Customer", True))
        Me.CustomerTextBox.Location = New System.Drawing.Point(291, 252)
        Me.CustomerTextBox.Margin = New System.Windows.Forms.Padding(4)
        Me.CustomerTextBox.Name = "CustomerTextBox"
        Me.CustomerTextBox.Size = New System.Drawing.Size(265, 22)
        Me.CustomerTextBox.TabIndex = 12
        '
        'Grade_1TextBox
        '
        Me.Grade_1TextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PPC_JOBCARDBindingSource, "Grade 1", True))
        Me.Grade_1TextBox.Location = New System.Drawing.Point(291, 284)
        Me.Grade_1TextBox.Margin = New System.Windows.Forms.Padding(4)
        Me.Grade_1TextBox.Name = "Grade_1TextBox"
        Me.Grade_1TextBox.Size = New System.Drawing.Size(265, 22)
        Me.Grade_1TextBox.TabIndex = 14
        '
        'DiscriptionTextBox
        '
        Me.DiscriptionTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PPC_JOBCARDBindingSource, "Discription", True))
        Me.DiscriptionTextBox.Location = New System.Drawing.Point(291, 316)
        Me.DiscriptionTextBox.Margin = New System.Windows.Forms.Padding(4)
        Me.DiscriptionTextBox.Name = "DiscriptionTextBox"
        Me.DiscriptionTextBox.Size = New System.Drawing.Size(265, 22)
        Me.DiscriptionTextBox.TabIndex = 16
        '
        'BalenceTextBox
        '
        Me.BalenceTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PPC_JOBCARDBindingSource, "Balence", True))
        Me.BalenceTextBox.Location = New System.Drawing.Point(807, 314)
        Me.BalenceTextBox.Margin = New System.Windows.Forms.Padding(4)
        Me.BalenceTextBox.Name = "BalenceTextBox"
        Me.BalenceTextBox.Size = New System.Drawing.Size(265, 22)
        Me.BalenceTextBox.TabIndex = 18
        '
        'Die_NumberTextBox
        '
        Me.Die_NumberTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PPC_JOBCARDBindingSource, "Die Number", True))
        Me.Die_NumberTextBox.Location = New System.Drawing.Point(291, 346)
        Me.Die_NumberTextBox.Margin = New System.Windows.Forms.Padding(4)
        Me.Die_NumberTextBox.Name = "Die_NumberTextBox"
        Me.Die_NumberTextBox.Size = New System.Drawing.Size(265, 22)
        Me.Die_NumberTextBox.TabIndex = 20
        '
        'RateTextBox
        '
        Me.RateTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PPC_JOBCARDBindingSource, "Rate", True))
        Me.RateTextBox.Location = New System.Drawing.Point(291, 378)
        Me.RateTextBox.Margin = New System.Windows.Forms.Padding(4)
        Me.RateTextBox.Name = "RateTextBox"
        Me.RateTextBox.Size = New System.Drawing.Size(265, 22)
        Me.RateTextBox.TabIndex = 22
        '
        'Year_JCTextBox
        '
        Me.Year_JCTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PPC_JOBCARDBindingSource, "Year_JC", True))
        Me.Year_JCTextBox.Location = New System.Drawing.Point(291, 408)
        Me.Year_JCTextBox.Margin = New System.Windows.Forms.Padding(4)
        Me.Year_JCTextBox.Name = "Year_JCTextBox"
        Me.Year_JCTextBox.Size = New System.Drawing.Size(265, 22)
        Me.Year_JCTextBox.TabIndex = 24
        '
        'Month_JCTextBox
        '
        Me.Month_JCTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PPC_JOBCARDBindingSource, "Month_JC", True))
        Me.Month_JCTextBox.Location = New System.Drawing.Point(809, 116)
        Me.Month_JCTextBox.Margin = New System.Windows.Forms.Padding(4)
        Me.Month_JCTextBox.Name = "Month_JCTextBox"
        Me.Month_JCTextBox.Size = New System.Drawing.Size(265, 22)
        Me.Month_JCTextBox.TabIndex = 26
        '
        'Current_StockTextBox
        '
        Me.Current_StockTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PPC_JOBCARDBindingSource, "Current Stock", True))
        Me.Current_StockTextBox.Location = New System.Drawing.Point(807, 146)
        Me.Current_StockTextBox.Margin = New System.Windows.Forms.Padding(4)
        Me.Current_StockTextBox.Name = "Current_StockTextBox"
        Me.Current_StockTextBox.Size = New System.Drawing.Size(265, 22)
        Me.Current_StockTextBox.TabIndex = 28
        '
        'TonnageTextBox
        '
        Me.TonnageTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PPC_JOBCARDBindingSource, "Tonnage", True))
        Me.TonnageTextBox.Location = New System.Drawing.Point(807, 344)
        Me.TonnageTextBox.Margin = New System.Windows.Forms.Padding(4)
        Me.TonnageTextBox.Name = "TonnageTextBox"
        Me.TonnageTextBox.Size = New System.Drawing.Size(265, 22)
        Me.TonnageTextBox.TabIndex = 30
        '
        'Balance_tonnageTextBox
        '
        Me.Balance_tonnageTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PPC_JOBCARDBindingSource, "Balance tonnage", True))
        Me.Balance_tonnageTextBox.Location = New System.Drawing.Point(807, 409)
        Me.Balance_tonnageTextBox.Margin = New System.Windows.Forms.Padding(4)
        Me.Balance_tonnageTextBox.Name = "Balance_tonnageTextBox"
        Me.Balance_tonnageTextBox.Size = New System.Drawing.Size(265, 22)
        Me.Balance_tonnageTextBox.TabIndex = 32
        '
        'SectionTextBox
        '
        Me.SectionTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PPC_JOBCARDBindingSource, "Section", True))
        Me.SectionTextBox.Location = New System.Drawing.Point(807, 176)
        Me.SectionTextBox.Margin = New System.Windows.Forms.Padding(4)
        Me.SectionTextBox.Name = "SectionTextBox"
        Me.SectionTextBox.Size = New System.Drawing.Size(265, 22)
        Me.SectionTextBox.TabIndex = 34
        '
        'Balance_To_PlanTextBox
        '
        Me.Balance_To_PlanTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PPC_JOBCARDBindingSource, "Balance To Plan", True))
        Me.Balance_To_PlanTextBox.Location = New System.Drawing.Point(807, 374)
        Me.Balance_To_PlanTextBox.Margin = New System.Windows.Forms.Padding(4)
        Me.Balance_To_PlanTextBox.Name = "Balance_To_PlanTextBox"
        Me.Balance_To_PlanTextBox.Size = New System.Drawing.Size(265, 22)
        Me.Balance_To_PlanTextBox.TabIndex = 36
        '
        'H5
        '
        Me.H5.AutoSize = True
        Me.H5.Location = New System.Drawing.Point(1051, 641)
        Me.H5.Margin = New System.Windows.Forms.Padding(4)
        Me.H5.Name = "H5"
        Me.H5.Size = New System.Drawing.Size(94, 21)
        Me.H5.TabIndex = 45
        Me.H5.TabStop = True
        Me.H5.Text = "Hammer 5"
        Me.H5.UseVisualStyleBackColor = True
        '
        'H4
        '
        Me.H4.AutoSize = True
        Me.H4.Location = New System.Drawing.Point(791, 641)
        Me.H4.Margin = New System.Windows.Forms.Padding(4)
        Me.H4.Name = "H4"
        Me.H4.Size = New System.Drawing.Size(94, 21)
        Me.H4.TabIndex = 44
        Me.H4.TabStop = True
        Me.H4.Text = "Hammer 4"
        Me.H4.UseVisualStyleBackColor = True
        '
        'H3
        '
        Me.H3.AutoSize = True
        Me.H3.Location = New System.Drawing.Point(533, 641)
        Me.H3.Margin = New System.Windows.Forms.Padding(4)
        Me.H3.Name = "H3"
        Me.H3.Size = New System.Drawing.Size(94, 21)
        Me.H3.TabIndex = 43
        Me.H3.TabStop = True
        Me.H3.Text = "Hammer 3"
        Me.H3.UseVisualStyleBackColor = True
        '
        'H2
        '
        Me.H2.AutoSize = True
        Me.H2.Location = New System.Drawing.Point(295, 641)
        Me.H2.Margin = New System.Windows.Forms.Padding(4)
        Me.H2.Name = "H2"
        Me.H2.Size = New System.Drawing.Size(94, 21)
        Me.H2.TabIndex = 42
        Me.H2.TabStop = True
        Me.H2.Text = "Hammer 2"
        Me.H2.UseVisualStyleBackColor = True
        '
        'H1
        '
        Me.H1.AutoSize = True
        Me.H1.Location = New System.Drawing.Point(33, 641)
        Me.H1.Margin = New System.Windows.Forms.Padding(4)
        Me.H1.Name = "H1"
        Me.H1.Size = New System.Drawing.Size(94, 21)
        Me.H1.TabIndex = 41
        Me.H1.TabStop = True
        Me.H1.Text = "Hammer 1"
        Me.H1.UseVisualStyleBackColor = True
        '
        'PPC_JOBCARDTableAdapter
        '
        Me.PPC_JOBCARDTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.PPC_ACTUALSTableAdapter = Nothing
        Me.TableAdapterManager.PPC_JOBCARDTableAdapter = Me.PPC_JOBCARDTableAdapter
        Me.TableAdapterManager.PPC_PLANTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = PPC.OMMI_2007DataSet1TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'Plan
        '
        Me.Plan.Location = New System.Drawing.Point(1036, 741)
        Me.Plan.Name = "Plan"
        Me.Plan.Size = New System.Drawing.Size(155, 56)
        Me.Plan.TabIndex = 47
        Me.Plan.Text = "Plan and Actuals"
        Me.Plan.UseVisualStyleBackColor = True
        '
        'HammerTextBox
        '
        Me.HammerTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PPC_JOBCARDBindingSource, "Hammer", True))
        Me.HammerTextBox.Location = New System.Drawing.Point(807, 242)
        Me.HammerTextBox.Margin = New System.Windows.Forms.Padding(4)
        Me.HammerTextBox.Name = "HammerTextBox"
        Me.HammerTextBox.Size = New System.Drawing.Size(265, 22)
        Me.HammerTextBox.TabIndex = 40
        '
        'Left_To_ProduceTextBox
        '
        Me.Left_To_ProduceTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PPC_JOBCARDBindingSource, "Left To Produce", True))
        Me.Left_To_ProduceTextBox.Location = New System.Drawing.Point(807, 210)
        Me.Left_To_ProduceTextBox.Margin = New System.Windows.Forms.Padding(4)
        Me.Left_To_ProduceTextBox.Name = "Left_To_ProduceTextBox"
        Me.Left_To_ProduceTextBox.Size = New System.Drawing.Size(265, 22)
        Me.Left_To_ProduceTextBox.TabIndex = 38
        '
        'PA
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1365, 838)
        Me.Controls.Add(Me.Plan)
        Me.Controls.Add(Me.H5)
        Me.Controls.Add(Me.H4)
        Me.Controls.Add(Me.H3)
        Me.Controls.Add(Me.H2)
        Me.Controls.Add(Me.H1)
        Me.Controls.Add(Job_Card_NoLabel)
        Me.Controls.Add(Me.Job_Card_NoTextBox)
        Me.Controls.Add(Schedule_DateLabel)
        Me.Controls.Add(Me.DateTimePicker)
        Me.Controls.Add(Schedule_QuantityLabel)
        Me.Controls.Add(Me.Schedule_QuantityTextBox)
        Me.Controls.Add(Weight_Per_PeiceLabel)
        Me.Controls.Add(Me.Weight_Per_PeiceTextBox)
        Me.Controls.Add(Part_NumberLabel)
        Me.Controls.Add(Me.Part_NumberTextBox)
        Me.Controls.Add(CustomerLabel)
        Me.Controls.Add(Me.CustomerTextBox)
        Me.Controls.Add(Grade_1Label)
        Me.Controls.Add(Me.Grade_1TextBox)
        Me.Controls.Add(DiscriptionLabel)
        Me.Controls.Add(Me.DiscriptionTextBox)
        Me.Controls.Add(BalenceLabel)
        Me.Controls.Add(Me.BalenceTextBox)
        Me.Controls.Add(Die_NumberLabel)
        Me.Controls.Add(Me.Die_NumberTextBox)
        Me.Controls.Add(RateLabel)
        Me.Controls.Add(Me.RateTextBox)
        Me.Controls.Add(Year_JCLabel)
        Me.Controls.Add(Me.Year_JCTextBox)
        Me.Controls.Add(Month_JCLabel)
        Me.Controls.Add(Me.Month_JCTextBox)
        Me.Controls.Add(Current_StockLabel)
        Me.Controls.Add(Me.Current_StockTextBox)
        Me.Controls.Add(TonnageLabel)
        Me.Controls.Add(Me.TonnageTextBox)
        Me.Controls.Add(Balance_tonnageLabel)
        Me.Controls.Add(Me.Balance_tonnageTextBox)
        Me.Controls.Add(SectionLabel)
        Me.Controls.Add(Me.SectionTextBox)
        Me.Controls.Add(Balance_To_PlanLabel)
        Me.Controls.Add(Me.Balance_To_PlanTextBox)
        Me.Controls.Add(Left_To_ProduceLabel)
        Me.Controls.Add(Me.Left_To_ProduceTextBox)
        Me.Controls.Add(HammerLabel)
        Me.Controls.Add(Me.HammerTextBox)
        Me.Controls.Add(Me.PPC_JOBCARDBindingNavigator)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "PA"
        Me.Text = "Form3"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.PPC_JOBCARDBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PPC_JOBCARDBindingNavigator.ResumeLayout(False)
        Me.PPC_JOBCARDBindingNavigator.PerformLayout()
        CType(Me.PPC_JOBCARDBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.OMMI_2007DataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents OMMI_2007DataSet1 As PPC.OMMI_2007DataSet1
    Friend WithEvents PPC_JOBCARDBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents PPC_JOBCARDTableAdapter As PPC.OMMI_2007DataSet1TableAdapters.PPC_JOBCARDTableAdapter
    Friend WithEvents TableAdapterManager As PPC.OMMI_2007DataSet1TableAdapters.TableAdapterManager
    Friend WithEvents PPC_JOBCARDBindingNavigator As System.Windows.Forms.BindingNavigator
    Friend WithEvents BindingNavigatorAddNewItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorCountItem As System.Windows.Forms.ToolStripLabel
    Friend WithEvents BindingNavigatorDeleteItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMoveFirstItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMovePreviousItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorSeparator As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BindingNavigatorPositionItem As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents BindingNavigatorSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BindingNavigatorMoveNextItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMoveLastItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents PPC_JOBCARDBindingNavigatorSaveItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents Job_Card_NoTextBox As System.Windows.Forms.TextBox
    Friend WithEvents DateTimePicker As System.Windows.Forms.DateTimePicker
    Friend WithEvents Schedule_QuantityTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Weight_Per_PeiceTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Part_NumberTextBox As System.Windows.Forms.TextBox
    Friend WithEvents CustomerTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Grade_1TextBox As System.Windows.Forms.TextBox
    Friend WithEvents DiscriptionTextBox As System.Windows.Forms.TextBox
    Friend WithEvents BalenceTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Die_NumberTextBox As System.Windows.Forms.TextBox
    Friend WithEvents RateTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Year_JCTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Month_JCTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Current_StockTextBox As System.Windows.Forms.TextBox
    Friend WithEvents TonnageTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Balance_tonnageTextBox As System.Windows.Forms.TextBox
    Friend WithEvents SectionTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Balance_To_PlanTextBox As System.Windows.Forms.TextBox
    Friend WithEvents H5 As System.Windows.Forms.RadioButton
    Friend WithEvents H4 As System.Windows.Forms.RadioButton
    Friend WithEvents H3 As System.Windows.Forms.RadioButton
    Friend WithEvents H2 As System.Windows.Forms.RadioButton
    Friend WithEvents H1 As System.Windows.Forms.RadioButton
    Friend WithEvents Plan As System.Windows.Forms.Button
    Friend WithEvents HammerTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Left_To_ProduceTextBox As System.Windows.Forms.TextBox
End Class
