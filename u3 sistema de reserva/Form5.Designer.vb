<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form5
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
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

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim IdreservaLabel As System.Windows.Forms.Label
        Dim Fecha_de_la_reservaLabel As System.Windows.Forms.Label
        Dim Fecha_de_ingreso_al_hotelLabel As System.Windows.Forms.Label
        Dim Fecha_de_salida_del_hotelLabel As System.Windows.Forms.Label
        Dim CostoLabel As System.Windows.Forms.Label
        Dim IdclienteLabel As System.Windows.Forms.Label
        Dim IdhabitacionLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form5))
        Me.Button1 = New System.Windows.Forms.Button()
        Me.ReservasfestivalDataSet = New u3_sistema_de_reserva.reservasfestivalDataSet()
        Me.InforeservaBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.InforeservaTableAdapter = New u3_sistema_de_reserva.reservasfestivalDataSetTableAdapters.inforeservaTableAdapter()
        Me.TableAdapterManager = New u3_sistema_de_reserva.reservasfestivalDataSetTableAdapters.TableAdapterManager()
        Me.ClienteTableAdapter = New u3_sistema_de_reserva.reservasfestivalDataSetTableAdapters.clienteTableAdapter()
        Me.HabitacionTableAdapter = New u3_sistema_de_reserva.reservasfestivalDataSetTableAdapters.habitacionTableAdapter()
        Me.InforeservaBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorAddNewItem = New System.Windows.Forms.ToolStripButton()
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
        Me.InforeservaBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.IdreservaTextBox = New System.Windows.Forms.TextBox()
        Me.Fecha_de_la_reservaDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.Fecha_de_ingreso_al_hotelDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.Fecha_de_salida_del_hotelDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.CostoTextBox = New System.Windows.Forms.TextBox()
        Me.IdclienteTextBox = New System.Windows.Forms.TextBox()
        Me.IdhabitacionTextBox = New System.Windows.Forms.TextBox()
        Me.ClienteBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ClienteDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn9 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn10 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn11 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn12 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn13 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.HabitacionBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.HabitacionDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn14 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn15 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn16 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn17 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn18 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn19 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Button3 = New System.Windows.Forms.Button()
        IdreservaLabel = New System.Windows.Forms.Label()
        Fecha_de_la_reservaLabel = New System.Windows.Forms.Label()
        Fecha_de_ingreso_al_hotelLabel = New System.Windows.Forms.Label()
        Fecha_de_salida_del_hotelLabel = New System.Windows.Forms.Label()
        CostoLabel = New System.Windows.Forms.Label()
        IdclienteLabel = New System.Windows.Forms.Label()
        IdhabitacionLabel = New System.Windows.Forms.Label()
        CType(Me.ReservasfestivalDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.InforeservaBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.InforeservaBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.InforeservaBindingNavigator.SuspendLayout()
        CType(Me.ClienteBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ClienteDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.HabitacionBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.HabitacionDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'IdreservaLabel
        '
        IdreservaLabel.AutoSize = True
        IdreservaLabel.Location = New System.Drawing.Point(17, 85)
        IdreservaLabel.Name = "IdreservaLabel"
        IdreservaLabel.Size = New System.Drawing.Size(54, 13)
        IdreservaLabel.TabIndex = 2
        IdreservaLabel.Text = "Idreserva:"
        '
        'Fecha_de_la_reservaLabel
        '
        Fecha_de_la_reservaLabel.AutoSize = True
        Fecha_de_la_reservaLabel.Location = New System.Drawing.Point(17, 112)
        Fecha_de_la_reservaLabel.Name = "Fecha_de_la_reservaLabel"
        Fecha_de_la_reservaLabel.Size = New System.Drawing.Size(101, 13)
        Fecha_de_la_reservaLabel.TabIndex = 4
        Fecha_de_la_reservaLabel.Text = "fecha de la reserva:"
        '
        'Fecha_de_ingreso_al_hotelLabel
        '
        Fecha_de_ingreso_al_hotelLabel.AutoSize = True
        Fecha_de_ingreso_al_hotelLabel.Location = New System.Drawing.Point(17, 138)
        Fecha_de_ingreso_al_hotelLabel.Name = "Fecha_de_ingreso_al_hotelLabel"
        Fecha_de_ingreso_al_hotelLabel.Size = New System.Drawing.Size(126, 13)
        Fecha_de_ingreso_al_hotelLabel.TabIndex = 6
        Fecha_de_ingreso_al_hotelLabel.Text = "fecha de ingreso al hotel:"
        '
        'Fecha_de_salida_del_hotelLabel
        '
        Fecha_de_salida_del_hotelLabel.AutoSize = True
        Fecha_de_salida_del_hotelLabel.Location = New System.Drawing.Point(17, 164)
        Fecha_de_salida_del_hotelLabel.Name = "Fecha_de_salida_del_hotelLabel"
        Fecha_de_salida_del_hotelLabel.Size = New System.Drawing.Size(125, 13)
        Fecha_de_salida_del_hotelLabel.TabIndex = 8
        Fecha_de_salida_del_hotelLabel.Text = "fecha de salida del hotel:"
        '
        'CostoLabel
        '
        CostoLabel.AutoSize = True
        CostoLabel.Location = New System.Drawing.Point(17, 189)
        CostoLabel.Name = "CostoLabel"
        CostoLabel.Size = New System.Drawing.Size(36, 13)
        CostoLabel.TabIndex = 10
        CostoLabel.Text = "costo:"
        '
        'IdclienteLabel
        '
        IdclienteLabel.AutoSize = True
        IdclienteLabel.Location = New System.Drawing.Point(17, 215)
        IdclienteLabel.Name = "IdclienteLabel"
        IdclienteLabel.Size = New System.Drawing.Size(50, 13)
        IdclienteLabel.TabIndex = 12
        IdclienteLabel.Text = "Idcliente:"
        '
        'IdhabitacionLabel
        '
        IdhabitacionLabel.AutoSize = True
        IdhabitacionLabel.Location = New System.Drawing.Point(17, 241)
        IdhabitacionLabel.Name = "IdhabitacionLabel"
        IdhabitacionLabel.Size = New System.Drawing.Size(68, 13)
        IdhabitacionLabel.TabIndex = 14
        IdhabitacionLabel.Text = "Idhabitacion:"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(455, 220)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "SIGUIENTE"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'ReservasfestivalDataSet
        '
        Me.ReservasfestivalDataSet.DataSetName = "reservasfestivalDataSet"
        Me.ReservasfestivalDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'InforeservaBindingSource
        '
        Me.InforeservaBindingSource.DataMember = "inforeserva"
        Me.InforeservaBindingSource.DataSource = Me.ReservasfestivalDataSet
        '
        'InforeservaTableAdapter
        '
        Me.InforeservaTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.clienteTableAdapter = Me.ClienteTableAdapter
        Me.TableAdapterManager.habitacionTableAdapter = Me.HabitacionTableAdapter
        Me.TableAdapterManager.hotelTableAdapter = Nothing
        Me.TableAdapterManager.inforeservaTableAdapter = Me.InforeservaTableAdapter
        Me.TableAdapterManager.UpdateOrder = u3_sistema_de_reserva.reservasfestivalDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'ClienteTableAdapter
        '
        Me.ClienteTableAdapter.ClearBeforeFill = True
        '
        'HabitacionTableAdapter
        '
        Me.HabitacionTableAdapter.ClearBeforeFill = True
        '
        'InforeservaBindingNavigator
        '
        Me.InforeservaBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.InforeservaBindingNavigator.BindingSource = Me.InforeservaBindingSource
        Me.InforeservaBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.InforeservaBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.InforeservaBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.InforeservaBindingNavigatorSaveItem})
        Me.InforeservaBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.InforeservaBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.InforeservaBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.InforeservaBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.InforeservaBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.InforeservaBindingNavigator.Name = "InforeservaBindingNavigator"
        Me.InforeservaBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.InforeservaBindingNavigator.Size = New System.Drawing.Size(657, 25)
        Me.InforeservaBindingNavigator.TabIndex = 1
        Me.InforeservaBindingNavigator.Text = "BindingNavigator1"
        '
        'BindingNavigatorAddNewItem
        '
        Me.BindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorAddNewItem.Image = CType(resources.GetObject("BindingNavigatorAddNewItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorAddNewItem.Name = "BindingNavigatorAddNewItem"
        Me.BindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorAddNewItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorAddNewItem.Text = "Agregar nuevo"
        '
        'BindingNavigatorCountItem
        '
        Me.BindingNavigatorCountItem.Name = "BindingNavigatorCountItem"
        Me.BindingNavigatorCountItem.Size = New System.Drawing.Size(37, 22)
        Me.BindingNavigatorCountItem.Text = "de {0}"
        Me.BindingNavigatorCountItem.ToolTipText = "Número total de elementos"
        '
        'BindingNavigatorDeleteItem
        '
        Me.BindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorDeleteItem.Image = CType(resources.GetObject("BindingNavigatorDeleteItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorDeleteItem.Name = "BindingNavigatorDeleteItem"
        Me.BindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorDeleteItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorDeleteItem.Text = "Eliminar"
        '
        'BindingNavigatorMoveFirstItem
        '
        Me.BindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveFirstItem.Image = CType(resources.GetObject("BindingNavigatorMoveFirstItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveFirstItem.Name = "BindingNavigatorMoveFirstItem"
        Me.BindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveFirstItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveFirstItem.Text = "Mover primero"
        '
        'BindingNavigatorMovePreviousItem
        '
        Me.BindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMovePreviousItem.Image = CType(resources.GetObject("BindingNavigatorMovePreviousItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMovePreviousItem.Name = "BindingNavigatorMovePreviousItem"
        Me.BindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMovePreviousItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMovePreviousItem.Text = "Mover anterior"
        '
        'BindingNavigatorSeparator
        '
        Me.BindingNavigatorSeparator.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorPositionItem
        '
        Me.BindingNavigatorPositionItem.AccessibleName = "Posición"
        Me.BindingNavigatorPositionItem.AutoSize = False
        Me.BindingNavigatorPositionItem.Name = "BindingNavigatorPositionItem"
        Me.BindingNavigatorPositionItem.Size = New System.Drawing.Size(50, 23)
        Me.BindingNavigatorPositionItem.Text = "0"
        Me.BindingNavigatorPositionItem.ToolTipText = "Posición actual"
        '
        'BindingNavigatorSeparator1
        '
        Me.BindingNavigatorSeparator1.Name = "BindingNavigatorSeparator1"
        Me.BindingNavigatorSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorMoveNextItem
        '
        Me.BindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveNextItem.Image = CType(resources.GetObject("BindingNavigatorMoveNextItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveNextItem.Name = "BindingNavigatorMoveNextItem"
        Me.BindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveNextItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveNextItem.Text = "Mover siguiente"
        '
        'BindingNavigatorMoveLastItem
        '
        Me.BindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveLastItem.Image = CType(resources.GetObject("BindingNavigatorMoveLastItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveLastItem.Name = "BindingNavigatorMoveLastItem"
        Me.BindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveLastItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveLastItem.Text = "Mover último"
        '
        'BindingNavigatorSeparator2
        '
        Me.BindingNavigatorSeparator2.Name = "BindingNavigatorSeparator2"
        Me.BindingNavigatorSeparator2.Size = New System.Drawing.Size(6, 25)
        '
        'InforeservaBindingNavigatorSaveItem
        '
        Me.InforeservaBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.InforeservaBindingNavigatorSaveItem.Image = CType(resources.GetObject("InforeservaBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.InforeservaBindingNavigatorSaveItem.Name = "InforeservaBindingNavigatorSaveItem"
        Me.InforeservaBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 22)
        Me.InforeservaBindingNavigatorSaveItem.Text = "Guardar datos"
        '
        'IdreservaTextBox
        '
        Me.IdreservaTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.InforeservaBindingSource, "Idreserva", True))
        Me.IdreservaTextBox.Location = New System.Drawing.Point(149, 82)
        Me.IdreservaTextBox.Name = "IdreservaTextBox"
        Me.IdreservaTextBox.Size = New System.Drawing.Size(43, 20)
        Me.IdreservaTextBox.TabIndex = 3
        '
        'Fecha_de_la_reservaDateTimePicker
        '
        Me.Fecha_de_la_reservaDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.InforeservaBindingSource, "fecha de la reserva", True))
        Me.Fecha_de_la_reservaDateTimePicker.Location = New System.Drawing.Point(149, 108)
        Me.Fecha_de_la_reservaDateTimePicker.Name = "Fecha_de_la_reservaDateTimePicker"
        Me.Fecha_de_la_reservaDateTimePicker.Size = New System.Drawing.Size(202, 20)
        Me.Fecha_de_la_reservaDateTimePicker.TabIndex = 5
        '
        'Fecha_de_ingreso_al_hotelDateTimePicker
        '
        Me.Fecha_de_ingreso_al_hotelDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.InforeservaBindingSource, "fecha de ingreso al hotel", True))
        Me.Fecha_de_ingreso_al_hotelDateTimePicker.Location = New System.Drawing.Point(149, 134)
        Me.Fecha_de_ingreso_al_hotelDateTimePicker.Name = "Fecha_de_ingreso_al_hotelDateTimePicker"
        Me.Fecha_de_ingreso_al_hotelDateTimePicker.Size = New System.Drawing.Size(202, 20)
        Me.Fecha_de_ingreso_al_hotelDateTimePicker.TabIndex = 7
        '
        'Fecha_de_salida_del_hotelDateTimePicker
        '
        Me.Fecha_de_salida_del_hotelDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.InforeservaBindingSource, "fecha de salida del hotel", True))
        Me.Fecha_de_salida_del_hotelDateTimePicker.Location = New System.Drawing.Point(149, 160)
        Me.Fecha_de_salida_del_hotelDateTimePicker.Name = "Fecha_de_salida_del_hotelDateTimePicker"
        Me.Fecha_de_salida_del_hotelDateTimePicker.Size = New System.Drawing.Size(202, 20)
        Me.Fecha_de_salida_del_hotelDateTimePicker.TabIndex = 9
        '
        'CostoTextBox
        '
        Me.CostoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.InforeservaBindingSource, "costo", True))
        Me.CostoTextBox.Location = New System.Drawing.Point(149, 186)
        Me.CostoTextBox.Name = "CostoTextBox"
        Me.CostoTextBox.Size = New System.Drawing.Size(43, 20)
        Me.CostoTextBox.TabIndex = 11
        '
        'IdclienteTextBox
        '
        Me.IdclienteTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.InforeservaBindingSource, "Idcliente", True))
        Me.IdclienteTextBox.Location = New System.Drawing.Point(149, 212)
        Me.IdclienteTextBox.Name = "IdclienteTextBox"
        Me.IdclienteTextBox.Size = New System.Drawing.Size(43, 20)
        Me.IdclienteTextBox.TabIndex = 13
        '
        'IdhabitacionTextBox
        '
        Me.IdhabitacionTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.InforeservaBindingSource, "Idhabitacion", True))
        Me.IdhabitacionTextBox.Location = New System.Drawing.Point(149, 238)
        Me.IdhabitacionTextBox.Name = "IdhabitacionTextBox"
        Me.IdhabitacionTextBox.Size = New System.Drawing.Size(43, 20)
        Me.IdhabitacionTextBox.TabIndex = 15
        '
        'ClienteBindingSource
        '
        Me.ClienteBindingSource.DataMember = "cliente"
        Me.ClienteBindingSource.DataSource = Me.ReservasfestivalDataSet
        '
        'ClienteDataGridView
        '
        Me.ClienteDataGridView.AutoGenerateColumns = False
        Me.ClienteDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.ClienteDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn6, Me.DataGridViewTextBoxColumn7, Me.DataGridViewTextBoxColumn8, Me.DataGridViewTextBoxColumn9, Me.DataGridViewTextBoxColumn10, Me.DataGridViewTextBoxColumn11, Me.DataGridViewTextBoxColumn12, Me.DataGridViewTextBoxColumn13})
        Me.ClienteDataGridView.DataSource = Me.ClienteBindingSource
        Me.ClienteDataGridView.Location = New System.Drawing.Point(20, 302)
        Me.ClienteDataGridView.Name = "ClienteDataGridView"
        Me.ClienteDataGridView.Size = New System.Drawing.Size(547, 127)
        Me.ClienteDataGridView.TabIndex = 16
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "Idcliente"
        Me.DataGridViewTextBoxColumn1.HeaderText = "Idcliente"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "nombres"
        Me.DataGridViewTextBoxColumn2.HeaderText = "nombres"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "apellidos"
        Me.DataGridViewTextBoxColumn3.HeaderText = "apellidos"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "numero de documento o DNI"
        Me.DataGridViewTextBoxColumn4.HeaderText = "numero de documento o DNI"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "edad"
        Me.DataGridViewTextBoxColumn5.HeaderText = "edad"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "fecha de nacimiento"
        Me.DataGridViewTextBoxColumn6.HeaderText = "fecha de nacimiento"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.DataPropertyName = "direccion de residencia"
        Me.DataGridViewTextBoxColumn7.HeaderText = "direccion de residencia"
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        '
        'DataGridViewTextBoxColumn8
        '
        Me.DataGridViewTextBoxColumn8.DataPropertyName = "barrio/colonia"
        Me.DataGridViewTextBoxColumn8.HeaderText = "barrio/colonia"
        Me.DataGridViewTextBoxColumn8.Name = "DataGridViewTextBoxColumn8"
        '
        'DataGridViewTextBoxColumn9
        '
        Me.DataGridViewTextBoxColumn9.DataPropertyName = "ciudad"
        Me.DataGridViewTextBoxColumn9.HeaderText = "ciudad"
        Me.DataGridViewTextBoxColumn9.Name = "DataGridViewTextBoxColumn9"
        '
        'DataGridViewTextBoxColumn10
        '
        Me.DataGridViewTextBoxColumn10.DataPropertyName = "estado/departamento"
        Me.DataGridViewTextBoxColumn10.HeaderText = "estado/departamento"
        Me.DataGridViewTextBoxColumn10.Name = "DataGridViewTextBoxColumn10"
        '
        'DataGridViewTextBoxColumn11
        '
        Me.DataGridViewTextBoxColumn11.DataPropertyName = "pais"
        Me.DataGridViewTextBoxColumn11.HeaderText = "pais"
        Me.DataGridViewTextBoxColumn11.Name = "DataGridViewTextBoxColumn11"
        '
        'DataGridViewTextBoxColumn12
        '
        Me.DataGridViewTextBoxColumn12.DataPropertyName = "ultimo lugar donde estaba el cliente (procedencia)"
        Me.DataGridViewTextBoxColumn12.HeaderText = "ultimo lugar donde estaba el cliente (procedencia)"
        Me.DataGridViewTextBoxColumn12.Name = "DataGridViewTextBoxColumn12"
        '
        'DataGridViewTextBoxColumn13
        '
        Me.DataGridViewTextBoxColumn13.DataPropertyName = "Idreserva"
        Me.DataGridViewTextBoxColumn13.HeaderText = "Idreserva"
        Me.DataGridViewTextBoxColumn13.Name = "DataGridViewTextBoxColumn13"
        '
        'HabitacionBindingSource
        '
        Me.HabitacionBindingSource.DataMember = "habitacion"
        Me.HabitacionBindingSource.DataSource = Me.ReservasfestivalDataSet
        '
        'HabitacionDataGridView
        '
        Me.HabitacionDataGridView.AutoGenerateColumns = False
        Me.HabitacionDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.HabitacionDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn14, Me.DataGridViewTextBoxColumn15, Me.DataGridViewTextBoxColumn16, Me.DataGridViewTextBoxColumn17, Me.DataGridViewTextBoxColumn18, Me.DataGridViewTextBoxColumn19})
        Me.HabitacionDataGridView.DataSource = Me.HabitacionBindingSource
        Me.HabitacionDataGridView.Location = New System.Drawing.Point(20, 469)
        Me.HabitacionDataGridView.Name = "HabitacionDataGridView"
        Me.HabitacionDataGridView.Size = New System.Drawing.Size(547, 127)
        Me.HabitacionDataGridView.TabIndex = 17
        '
        'DataGridViewTextBoxColumn14
        '
        Me.DataGridViewTextBoxColumn14.DataPropertyName = "Idhabitacion"
        Me.DataGridViewTextBoxColumn14.HeaderText = "Idhabitacion"
        Me.DataGridViewTextBoxColumn14.Name = "DataGridViewTextBoxColumn14"
        '
        'DataGridViewTextBoxColumn15
        '
        Me.DataGridViewTextBoxColumn15.DataPropertyName = "nombre de habitacion"
        Me.DataGridViewTextBoxColumn15.HeaderText = "nombre de habitacion"
        Me.DataGridViewTextBoxColumn15.Name = "DataGridViewTextBoxColumn15"
        '
        'DataGridViewTextBoxColumn16
        '
        Me.DataGridViewTextBoxColumn16.DataPropertyName = "tipo de habitacion"
        Me.DataGridViewTextBoxColumn16.HeaderText = "tipo de habitacion"
        Me.DataGridViewTextBoxColumn16.Name = "DataGridViewTextBoxColumn16"
        '
        'DataGridViewTextBoxColumn17
        '
        Me.DataGridViewTextBoxColumn17.DataPropertyName = "costo"
        Me.DataGridViewTextBoxColumn17.HeaderText = "costo"
        Me.DataGridViewTextBoxColumn17.Name = "DataGridViewTextBoxColumn17"
        '
        'DataGridViewTextBoxColumn18
        '
        Me.DataGridViewTextBoxColumn18.DataPropertyName = "Idhotel"
        Me.DataGridViewTextBoxColumn18.HeaderText = "Idhotel"
        Me.DataGridViewTextBoxColumn18.Name = "DataGridViewTextBoxColumn18"
        '
        'DataGridViewTextBoxColumn19
        '
        Me.DataGridViewTextBoxColumn19.DataPropertyName = "Idreserva"
        Me.DataGridViewTextBoxColumn19.HeaderText = "Idreserva"
        Me.DataGridViewTextBoxColumn19.Name = "DataGridViewTextBoxColumn19"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(17, 47)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(201, 13)
        Me.Label1.TabIndex = 18
        Me.Label1.Text = "POR FAVOR, CONFIRME LA RESERVA"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(17, 286)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(116, 13)
        Me.Label2.TabIndex = 19
        Me.Label2.Text = "DATOS DEL CLIENTE"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(17, 453)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(146, 13)
        Me.Label3.TabIndex = 20
        Me.Label3.Text = "DATOS DE LA HABITACIÓN"
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(426, 249)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(141, 23)
        Me.Button3.TabIndex = 22
        Me.Button3.Text = "CANCELAR RESERVA"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Form5
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.ClientSize = New System.Drawing.Size(657, 624)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.HabitacionDataGridView)
        Me.Controls.Add(Me.ClienteDataGridView)
        Me.Controls.Add(IdreservaLabel)
        Me.Controls.Add(Me.IdreservaTextBox)
        Me.Controls.Add(Fecha_de_la_reservaLabel)
        Me.Controls.Add(Me.Fecha_de_la_reservaDateTimePicker)
        Me.Controls.Add(Fecha_de_ingreso_al_hotelLabel)
        Me.Controls.Add(Me.Fecha_de_ingreso_al_hotelDateTimePicker)
        Me.Controls.Add(Fecha_de_salida_del_hotelLabel)
        Me.Controls.Add(Me.Fecha_de_salida_del_hotelDateTimePicker)
        Me.Controls.Add(CostoLabel)
        Me.Controls.Add(Me.CostoTextBox)
        Me.Controls.Add(IdclienteLabel)
        Me.Controls.Add(Me.IdclienteTextBox)
        Me.Controls.Add(IdhabitacionLabel)
        Me.Controls.Add(Me.IdhabitacionTextBox)
        Me.Controls.Add(Me.InforeservaBindingNavigator)
        Me.Controls.Add(Me.Button1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Form5"
        Me.Text = "CONFIRMAR RESERVA"
        CType(Me.ReservasfestivalDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.InforeservaBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.InforeservaBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.InforeservaBindingNavigator.ResumeLayout(False)
        Me.InforeservaBindingNavigator.PerformLayout()
        CType(Me.ClienteBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ClienteDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.HabitacionBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.HabitacionDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents ReservasfestivalDataSet As u3_sistema_de_reserva.reservasfestivalDataSet
    Friend WithEvents InforeservaBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents InforeservaTableAdapter As u3_sistema_de_reserva.reservasfestivalDataSetTableAdapters.inforeservaTableAdapter
    Friend WithEvents TableAdapterManager As u3_sistema_de_reserva.reservasfestivalDataSetTableAdapters.TableAdapterManager
    Friend WithEvents InforeservaBindingNavigator As System.Windows.Forms.BindingNavigator
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
    Friend WithEvents InforeservaBindingNavigatorSaveItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents ClienteTableAdapter As u3_sistema_de_reserva.reservasfestivalDataSetTableAdapters.clienteTableAdapter
    Friend WithEvents IdreservaTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Fecha_de_la_reservaDateTimePicker As System.Windows.Forms.DateTimePicker
    Friend WithEvents Fecha_de_ingreso_al_hotelDateTimePicker As System.Windows.Forms.DateTimePicker
    Friend WithEvents Fecha_de_salida_del_hotelDateTimePicker As System.Windows.Forms.DateTimePicker
    Friend WithEvents CostoTextBox As System.Windows.Forms.TextBox
    Friend WithEvents IdclienteTextBox As System.Windows.Forms.TextBox
    Friend WithEvents IdhabitacionTextBox As System.Windows.Forms.TextBox
    Friend WithEvents ClienteBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents HabitacionTableAdapter As u3_sistema_de_reserva.reservasfestivalDataSetTableAdapters.habitacionTableAdapter
    Friend WithEvents ClienteDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn7 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn8 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn9 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn10 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn11 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn12 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn13 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents HabitacionBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents HabitacionDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridViewTextBoxColumn14 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn15 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn16 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn17 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn18 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn19 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Button3 As System.Windows.Forms.Button
End Class
