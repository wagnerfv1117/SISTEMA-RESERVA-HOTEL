﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
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
        Dim IdclienteLabel As System.Windows.Forms.Label
        Dim NombresLabel As System.Windows.Forms.Label
        Dim ApellidosLabel As System.Windows.Forms.Label
        Dim Numero_de_documento_o_DNILabel As System.Windows.Forms.Label
        Dim EdadLabel As System.Windows.Forms.Label
        Dim Fecha_de_nacimientoLabel As System.Windows.Forms.Label
        Dim Direccion_de_residenciaLabel As System.Windows.Forms.Label
        Dim Barrio_coloniaLabel As System.Windows.Forms.Label
        Dim CiudadLabel As System.Windows.Forms.Label
        Dim Estado_departamentoLabel As System.Windows.Forms.Label
        Dim PaisLabel As System.Windows.Forms.Label
        Dim Ultimo_lugar_donde_estaba_el_cliente__procedencia_Label As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form2))
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ReservasfestivalDataSet = New u3_sistema_de_reserva.reservasfestivalDataSet()
        Me.ClienteBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ClienteTableAdapter = New u3_sistema_de_reserva.reservasfestivalDataSetTableAdapters.clienteTableAdapter()
        Me.TableAdapterManager = New u3_sistema_de_reserva.reservasfestivalDataSetTableAdapters.TableAdapterManager()
        Me.ClienteBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
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
        Me.ClienteBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.IdclienteTextBox = New System.Windows.Forms.TextBox()
        Me.NombresTextBox = New System.Windows.Forms.TextBox()
        Me.ApellidosTextBox = New System.Windows.Forms.TextBox()
        Me.Numero_de_documento_o_DNITextBox = New System.Windows.Forms.TextBox()
        Me.EdadTextBox = New System.Windows.Forms.TextBox()
        Me.Fecha_de_nacimientoDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.Direccion_de_residenciaTextBox = New System.Windows.Forms.TextBox()
        Me.Barrio_coloniaTextBox = New System.Windows.Forms.TextBox()
        Me.CiudadTextBox = New System.Windows.Forms.TextBox()
        Me.Estado_departamentoTextBox = New System.Windows.Forms.TextBox()
        Me.PaisTextBox = New System.Windows.Forms.TextBox()
        Me.Ultimo_lugar_donde_estaba_el_cliente__procedencia_TextBox = New System.Windows.Forms.TextBox()
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
        Me.Button2 = New System.Windows.Forms.Button()
        IdclienteLabel = New System.Windows.Forms.Label()
        NombresLabel = New System.Windows.Forms.Label()
        ApellidosLabel = New System.Windows.Forms.Label()
        Numero_de_documento_o_DNILabel = New System.Windows.Forms.Label()
        EdadLabel = New System.Windows.Forms.Label()
        Fecha_de_nacimientoLabel = New System.Windows.Forms.Label()
        Direccion_de_residenciaLabel = New System.Windows.Forms.Label()
        Barrio_coloniaLabel = New System.Windows.Forms.Label()
        CiudadLabel = New System.Windows.Forms.Label()
        Estado_departamentoLabel = New System.Windows.Forms.Label()
        PaisLabel = New System.Windows.Forms.Label()
        Ultimo_lugar_donde_estaba_el_cliente__procedencia_Label = New System.Windows.Forms.Label()
        CType(Me.ReservasfestivalDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ClienteBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ClienteBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ClienteBindingNavigator.SuspendLayout()
        CType(Me.ClienteDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'IdclienteLabel
        '
        IdclienteLabel.AutoSize = True
        IdclienteLabel.Location = New System.Drawing.Point(55, 97)
        IdclienteLabel.Name = "IdclienteLabel"
        IdclienteLabel.Size = New System.Drawing.Size(50, 13)
        IdclienteLabel.TabIndex = 3
        IdclienteLabel.Text = "Idcliente:"
        '
        'NombresLabel
        '
        NombresLabel.AutoSize = True
        NombresLabel.Location = New System.Drawing.Point(55, 123)
        NombresLabel.Name = "NombresLabel"
        NombresLabel.Size = New System.Drawing.Size(50, 13)
        NombresLabel.TabIndex = 5
        NombresLabel.Text = "nombres:"
        '
        'ApellidosLabel
        '
        ApellidosLabel.AutoSize = True
        ApellidosLabel.Location = New System.Drawing.Point(55, 149)
        ApellidosLabel.Name = "ApellidosLabel"
        ApellidosLabel.Size = New System.Drawing.Size(51, 13)
        ApellidosLabel.TabIndex = 7
        ApellidosLabel.Text = "apellidos:"
        '
        'Numero_de_documento_o_DNILabel
        '
        Numero_de_documento_o_DNILabel.AutoSize = True
        Numero_de_documento_o_DNILabel.Location = New System.Drawing.Point(55, 175)
        Numero_de_documento_o_DNILabel.Name = "Numero_de_documento_o_DNILabel"
        Numero_de_documento_o_DNILabel.Size = New System.Drawing.Size(147, 13)
        Numero_de_documento_o_DNILabel.TabIndex = 9
        Numero_de_documento_o_DNILabel.Text = "numero de documento o DNI:"
        '
        'EdadLabel
        '
        EdadLabel.AutoSize = True
        EdadLabel.Location = New System.Drawing.Point(55, 201)
        EdadLabel.Name = "EdadLabel"
        EdadLabel.Size = New System.Drawing.Size(34, 13)
        EdadLabel.TabIndex = 11
        EdadLabel.Text = "edad:"
        '
        'Fecha_de_nacimientoLabel
        '
        Fecha_de_nacimientoLabel.AutoSize = True
        Fecha_de_nacimientoLabel.Location = New System.Drawing.Point(55, 228)
        Fecha_de_nacimientoLabel.Name = "Fecha_de_nacimientoLabel"
        Fecha_de_nacimientoLabel.Size = New System.Drawing.Size(106, 13)
        Fecha_de_nacimientoLabel.TabIndex = 13
        Fecha_de_nacimientoLabel.Text = "fecha de nacimiento:"
        '
        'Direccion_de_residenciaLabel
        '
        Direccion_de_residenciaLabel.AutoSize = True
        Direccion_de_residenciaLabel.Location = New System.Drawing.Point(55, 253)
        Direccion_de_residenciaLabel.Name = "Direccion_de_residenciaLabel"
        Direccion_de_residenciaLabel.Size = New System.Drawing.Size(119, 13)
        Direccion_de_residenciaLabel.TabIndex = 15
        Direccion_de_residenciaLabel.Text = "direccion de residencia:"
        '
        'Barrio_coloniaLabel
        '
        Barrio_coloniaLabel.AutoSize = True
        Barrio_coloniaLabel.Location = New System.Drawing.Point(55, 279)
        Barrio_coloniaLabel.Name = "Barrio_coloniaLabel"
        Barrio_coloniaLabel.Size = New System.Drawing.Size(75, 13)
        Barrio_coloniaLabel.TabIndex = 17
        Barrio_coloniaLabel.Text = "barrio/colonia:"
        '
        'CiudadLabel
        '
        CiudadLabel.AutoSize = True
        CiudadLabel.Location = New System.Drawing.Point(55, 305)
        CiudadLabel.Name = "CiudadLabel"
        CiudadLabel.Size = New System.Drawing.Size(42, 13)
        CiudadLabel.TabIndex = 19
        CiudadLabel.Text = "ciudad:"
        '
        'Estado_departamentoLabel
        '
        Estado_departamentoLabel.AutoSize = True
        Estado_departamentoLabel.Location = New System.Drawing.Point(55, 331)
        Estado_departamentoLabel.Name = "Estado_departamentoLabel"
        Estado_departamentoLabel.Size = New System.Drawing.Size(112, 13)
        Estado_departamentoLabel.TabIndex = 21
        Estado_departamentoLabel.Text = "estado/departamento:"
        '
        'PaisLabel
        '
        PaisLabel.AutoSize = True
        PaisLabel.Location = New System.Drawing.Point(55, 357)
        PaisLabel.Name = "PaisLabel"
        PaisLabel.Size = New System.Drawing.Size(29, 13)
        PaisLabel.TabIndex = 23
        PaisLabel.Text = "pais:"
        '
        'Ultimo_lugar_donde_estaba_el_cliente__procedencia_Label
        '
        Ultimo_lugar_donde_estaba_el_cliente__procedencia_Label.AutoSize = True
        Ultimo_lugar_donde_estaba_el_cliente__procedencia_Label.Location = New System.Drawing.Point(55, 383)
        Ultimo_lugar_donde_estaba_el_cliente__procedencia_Label.Name = "Ultimo_lugar_donde_estaba_el_cliente__procedencia_Label"
        Ultimo_lugar_donde_estaba_el_cliente__procedencia_Label.Size = New System.Drawing.Size(244, 13)
        Ultimo_lugar_donde_estaba_el_cliente__procedencia_Label.TabIndex = 25
        Ultimo_lugar_donde_estaba_el_cliente__procedencia_Label.Text = "ultimo lugar donde estaba el cliente (procedencia):"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(305, 428)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "SIGUIENTE"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 48)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(259, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "POR FAVOR, INGRESE LOS DATOS DEL CLIENTE"
        '
        'ReservasfestivalDataSet
        '
        Me.ReservasfestivalDataSet.DataSetName = "reservasfestivalDataSet"
        Me.ReservasfestivalDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ClienteBindingSource
        '
        Me.ClienteBindingSource.DataMember = "cliente"
        Me.ClienteBindingSource.DataSource = Me.ReservasfestivalDataSet
        '
        'ClienteTableAdapter
        '
        Me.ClienteTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.clienteTableAdapter = Me.ClienteTableAdapter
        Me.TableAdapterManager.habitacionTableAdapter = Nothing
        Me.TableAdapterManager.hotelTableAdapter = Nothing
        Me.TableAdapterManager.inforeservaTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = u3_sistema_de_reserva.reservasfestivalDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'ClienteBindingNavigator
        '
        Me.ClienteBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.ClienteBindingNavigator.BindingSource = Me.ClienteBindingSource
        Me.ClienteBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.ClienteBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.ClienteBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.ClienteBindingNavigatorSaveItem})
        Me.ClienteBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.ClienteBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.ClienteBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.ClienteBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.ClienteBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.ClienteBindingNavigator.Name = "ClienteBindingNavigator"
        Me.ClienteBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.ClienteBindingNavigator.Size = New System.Drawing.Size(901, 25)
        Me.ClienteBindingNavigator.TabIndex = 2
        Me.ClienteBindingNavigator.Text = "BindingNavigator1"
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
        'ClienteBindingNavigatorSaveItem
        '
        Me.ClienteBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ClienteBindingNavigatorSaveItem.Image = CType(resources.GetObject("ClienteBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.ClienteBindingNavigatorSaveItem.Name = "ClienteBindingNavigatorSaveItem"
        Me.ClienteBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 22)
        Me.ClienteBindingNavigatorSaveItem.Text = "Guardar datos"
        '
        'IdclienteTextBox
        '
        Me.IdclienteTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ClienteBindingSource, "Idcliente", True))
        Me.IdclienteTextBox.Location = New System.Drawing.Point(305, 94)
        Me.IdclienteTextBox.Name = "IdclienteTextBox"
        Me.IdclienteTextBox.Size = New System.Drawing.Size(52, 20)
        Me.IdclienteTextBox.TabIndex = 4
        '
        'NombresTextBox
        '
        Me.NombresTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ClienteBindingSource, "nombres", True))
        Me.NombresTextBox.Location = New System.Drawing.Point(305, 120)
        Me.NombresTextBox.Name = "NombresTextBox"
        Me.NombresTextBox.Size = New System.Drawing.Size(200, 20)
        Me.NombresTextBox.TabIndex = 6
        '
        'ApellidosTextBox
        '
        Me.ApellidosTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ClienteBindingSource, "apellidos", True))
        Me.ApellidosTextBox.Location = New System.Drawing.Point(305, 146)
        Me.ApellidosTextBox.Name = "ApellidosTextBox"
        Me.ApellidosTextBox.Size = New System.Drawing.Size(200, 20)
        Me.ApellidosTextBox.TabIndex = 8
        '
        'Numero_de_documento_o_DNITextBox
        '
        Me.Numero_de_documento_o_DNITextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ClienteBindingSource, "numero de documento o DNI", True))
        Me.Numero_de_documento_o_DNITextBox.Location = New System.Drawing.Point(305, 172)
        Me.Numero_de_documento_o_DNITextBox.Name = "Numero_de_documento_o_DNITextBox"
        Me.Numero_de_documento_o_DNITextBox.Size = New System.Drawing.Size(200, 20)
        Me.Numero_de_documento_o_DNITextBox.TabIndex = 10
        '
        'EdadTextBox
        '
        Me.EdadTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ClienteBindingSource, "edad", True))
        Me.EdadTextBox.Location = New System.Drawing.Point(305, 198)
        Me.EdadTextBox.Name = "EdadTextBox"
        Me.EdadTextBox.Size = New System.Drawing.Size(52, 20)
        Me.EdadTextBox.TabIndex = 12
        '
        'Fecha_de_nacimientoDateTimePicker
        '
        Me.Fecha_de_nacimientoDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.ClienteBindingSource, "fecha de nacimiento", True))
        Me.Fecha_de_nacimientoDateTimePicker.Location = New System.Drawing.Point(305, 224)
        Me.Fecha_de_nacimientoDateTimePicker.Name = "Fecha_de_nacimientoDateTimePicker"
        Me.Fecha_de_nacimientoDateTimePicker.Size = New System.Drawing.Size(200, 20)
        Me.Fecha_de_nacimientoDateTimePicker.TabIndex = 14
        '
        'Direccion_de_residenciaTextBox
        '
        Me.Direccion_de_residenciaTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ClienteBindingSource, "direccion de residencia", True))
        Me.Direccion_de_residenciaTextBox.Location = New System.Drawing.Point(305, 250)
        Me.Direccion_de_residenciaTextBox.Name = "Direccion_de_residenciaTextBox"
        Me.Direccion_de_residenciaTextBox.Size = New System.Drawing.Size(200, 20)
        Me.Direccion_de_residenciaTextBox.TabIndex = 16
        '
        'Barrio_coloniaTextBox
        '
        Me.Barrio_coloniaTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ClienteBindingSource, "barrio/colonia", True))
        Me.Barrio_coloniaTextBox.Location = New System.Drawing.Point(305, 276)
        Me.Barrio_coloniaTextBox.Name = "Barrio_coloniaTextBox"
        Me.Barrio_coloniaTextBox.Size = New System.Drawing.Size(200, 20)
        Me.Barrio_coloniaTextBox.TabIndex = 18
        '
        'CiudadTextBox
        '
        Me.CiudadTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ClienteBindingSource, "ciudad", True))
        Me.CiudadTextBox.Location = New System.Drawing.Point(305, 302)
        Me.CiudadTextBox.Name = "CiudadTextBox"
        Me.CiudadTextBox.Size = New System.Drawing.Size(200, 20)
        Me.CiudadTextBox.TabIndex = 20
        '
        'Estado_departamentoTextBox
        '
        Me.Estado_departamentoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ClienteBindingSource, "estado/departamento", True))
        Me.Estado_departamentoTextBox.Location = New System.Drawing.Point(305, 328)
        Me.Estado_departamentoTextBox.Name = "Estado_departamentoTextBox"
        Me.Estado_departamentoTextBox.Size = New System.Drawing.Size(200, 20)
        Me.Estado_departamentoTextBox.TabIndex = 22
        '
        'PaisTextBox
        '
        Me.PaisTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ClienteBindingSource, "pais", True))
        Me.PaisTextBox.Location = New System.Drawing.Point(305, 354)
        Me.PaisTextBox.Name = "PaisTextBox"
        Me.PaisTextBox.Size = New System.Drawing.Size(200, 20)
        Me.PaisTextBox.TabIndex = 24
        '
        'Ultimo_lugar_donde_estaba_el_cliente__procedencia_TextBox
        '
        Me.Ultimo_lugar_donde_estaba_el_cliente__procedencia_TextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ClienteBindingSource, "ultimo lugar donde estaba el cliente (procedencia)", True))
        Me.Ultimo_lugar_donde_estaba_el_cliente__procedencia_TextBox.Location = New System.Drawing.Point(305, 380)
        Me.Ultimo_lugar_donde_estaba_el_cliente__procedencia_TextBox.Name = "Ultimo_lugar_donde_estaba_el_cliente__procedencia_TextBox"
        Me.Ultimo_lugar_donde_estaba_el_cliente__procedencia_TextBox.Size = New System.Drawing.Size(200, 20)
        Me.Ultimo_lugar_donde_estaba_el_cliente__procedencia_TextBox.TabIndex = 26
        '
        'ClienteDataGridView
        '
        Me.ClienteDataGridView.AutoGenerateColumns = False
        Me.ClienteDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.ClienteDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn6, Me.DataGridViewTextBoxColumn7, Me.DataGridViewTextBoxColumn8, Me.DataGridViewTextBoxColumn9, Me.DataGridViewTextBoxColumn10, Me.DataGridViewTextBoxColumn11, Me.DataGridViewTextBoxColumn12, Me.DataGridViewTextBoxColumn13})
        Me.ClienteDataGridView.DataSource = Me.ClienteBindingSource
        Me.ClienteDataGridView.Location = New System.Drawing.Point(546, 94)
        Me.ClienteDataGridView.Name = "ClienteDataGridView"
        Me.ClienteDataGridView.Size = New System.Drawing.Size(327, 306)
        Me.ClienteDataGridView.TabIndex = 27
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
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(213, 428)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 23)
        Me.Button2.TabIndex = 28
        Me.Button2.Text = "ATRÁS"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(901, 499)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.ClienteDataGridView)
        Me.Controls.Add(IdclienteLabel)
        Me.Controls.Add(Me.IdclienteTextBox)
        Me.Controls.Add(NombresLabel)
        Me.Controls.Add(Me.NombresTextBox)
        Me.Controls.Add(ApellidosLabel)
        Me.Controls.Add(Me.ApellidosTextBox)
        Me.Controls.Add(Numero_de_documento_o_DNILabel)
        Me.Controls.Add(Me.Numero_de_documento_o_DNITextBox)
        Me.Controls.Add(EdadLabel)
        Me.Controls.Add(Me.EdadTextBox)
        Me.Controls.Add(Fecha_de_nacimientoLabel)
        Me.Controls.Add(Me.Fecha_de_nacimientoDateTimePicker)
        Me.Controls.Add(Direccion_de_residenciaLabel)
        Me.Controls.Add(Me.Direccion_de_residenciaTextBox)
        Me.Controls.Add(Barrio_coloniaLabel)
        Me.Controls.Add(Me.Barrio_coloniaTextBox)
        Me.Controls.Add(CiudadLabel)
        Me.Controls.Add(Me.CiudadTextBox)
        Me.Controls.Add(Estado_departamentoLabel)
        Me.Controls.Add(Me.Estado_departamentoTextBox)
        Me.Controls.Add(PaisLabel)
        Me.Controls.Add(Me.PaisTextBox)
        Me.Controls.Add(Ultimo_lugar_donde_estaba_el_cliente__procedencia_Label)
        Me.Controls.Add(Me.Ultimo_lugar_donde_estaba_el_cliente__procedencia_TextBox)
        Me.Controls.Add(Me.ClienteBindingNavigator)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Button1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Form2"
        Me.Text = "REGISTRAR CLIENTES"
        CType(Me.ReservasfestivalDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ClienteBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ClienteBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ClienteBindingNavigator.ResumeLayout(False)
        Me.ClienteBindingNavigator.PerformLayout()
        CType(Me.ClienteDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents ReservasfestivalDataSet As u3_sistema_de_reserva.reservasfestivalDataSet
    Friend WithEvents ClienteBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ClienteTableAdapter As u3_sistema_de_reserva.reservasfestivalDataSetTableAdapters.clienteTableAdapter
    Friend WithEvents TableAdapterManager As u3_sistema_de_reserva.reservasfestivalDataSetTableAdapters.TableAdapterManager
    Friend WithEvents ClienteBindingNavigator As System.Windows.Forms.BindingNavigator
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
    Friend WithEvents ClienteBindingNavigatorSaveItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents IdclienteTextBox As System.Windows.Forms.TextBox
    Friend WithEvents NombresTextBox As System.Windows.Forms.TextBox
    Friend WithEvents ApellidosTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Numero_de_documento_o_DNITextBox As System.Windows.Forms.TextBox
    Friend WithEvents EdadTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Fecha_de_nacimientoDateTimePicker As System.Windows.Forms.DateTimePicker
    Friend WithEvents Direccion_de_residenciaTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Barrio_coloniaTextBox As System.Windows.Forms.TextBox
    Friend WithEvents CiudadTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Estado_departamentoTextBox As System.Windows.Forms.TextBox
    Friend WithEvents PaisTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Ultimo_lugar_donde_estaba_el_cliente__procedencia_TextBox As System.Windows.Forms.TextBox
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
    Friend WithEvents Button2 As System.Windows.Forms.Button
End Class
