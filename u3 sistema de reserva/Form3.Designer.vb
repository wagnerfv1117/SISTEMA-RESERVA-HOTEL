<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form3
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
        Dim IdhabitacionLabel As System.Windows.Forms.Label
        Dim Nombre_de_habitacionLabel As System.Windows.Forms.Label
        Dim Tipo_de_habitacionLabel As System.Windows.Forms.Label
        Dim CostoLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form3))
        Me.Button1 = New System.Windows.Forms.Button()
        Me.ReservasfestivalDataSet = New u3_sistema_de_reserva.reservasfestivalDataSet()
        Me.HabitacionBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.HabitacionTableAdapter = New u3_sistema_de_reserva.reservasfestivalDataSetTableAdapters.habitacionTableAdapter()
        Me.TableAdapterManager = New u3_sistema_de_reserva.reservasfestivalDataSetTableAdapters.TableAdapterManager()
        Me.HabitacionBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
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
        Me.HabitacionBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.IdhabitacionTextBox = New System.Windows.Forms.TextBox()
        Me.Nombre_de_habitacionTextBox = New System.Windows.Forms.TextBox()
        Me.Tipo_de_habitacionTextBox = New System.Windows.Forms.TextBox()
        Me.CostoTextBox = New System.Windows.Forms.TextBox()
        Me.HabitacionDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        IdhabitacionLabel = New System.Windows.Forms.Label()
        Nombre_de_habitacionLabel = New System.Windows.Forms.Label()
        Tipo_de_habitacionLabel = New System.Windows.Forms.Label()
        CostoLabel = New System.Windows.Forms.Label()
        CType(Me.ReservasfestivalDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.HabitacionBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.HabitacionBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.HabitacionBindingNavigator.SuspendLayout()
        CType(Me.HabitacionDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'IdhabitacionLabel
        '
        IdhabitacionLabel.AutoSize = True
        IdhabitacionLabel.Location = New System.Drawing.Point(72, 73)
        IdhabitacionLabel.Name = "IdhabitacionLabel"
        IdhabitacionLabel.Size = New System.Drawing.Size(110, 13)
        IdhabitacionLabel.TabIndex = 2
        IdhabitacionLabel.Text = "consecutivo de pago:"
        '
        'Nombre_de_habitacionLabel
        '
        Nombre_de_habitacionLabel.AutoSize = True
        Nombre_de_habitacionLabel.Location = New System.Drawing.Point(72, 99)
        Nombre_de_habitacionLabel.Name = "Nombre_de_habitacionLabel"
        Nombre_de_habitacionLabel.Size = New System.Drawing.Size(112, 13)
        Nombre_de_habitacionLabel.TabIndex = 4
        Nombre_de_habitacionLabel.Text = "nombre de habitacion:"
        '
        'Tipo_de_habitacionLabel
        '
        Tipo_de_habitacionLabel.AutoSize = True
        Tipo_de_habitacionLabel.Location = New System.Drawing.Point(72, 125)
        Tipo_de_habitacionLabel.Name = "Tipo_de_habitacionLabel"
        Tipo_de_habitacionLabel.Size = New System.Drawing.Size(94, 13)
        Tipo_de_habitacionLabel.TabIndex = 6
        Tipo_de_habitacionLabel.Text = "tipo de habitacion:"
        '
        'CostoLabel
        '
        CostoLabel.AutoSize = True
        CostoLabel.Location = New System.Drawing.Point(72, 151)
        CostoLabel.Name = "CostoLabel"
        CostoLabel.Size = New System.Drawing.Size(36, 13)
        CostoLabel.TabIndex = 8
        CostoLabel.Text = "costo:"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(281, 448)
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
        'HabitacionBindingSource
        '
        Me.HabitacionBindingSource.DataMember = "habitacion"
        Me.HabitacionBindingSource.DataSource = Me.ReservasfestivalDataSet
        '
        'HabitacionTableAdapter
        '
        Me.HabitacionTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.clienteTableAdapter = Nothing
        Me.TableAdapterManager.habitacionTableAdapter = Me.HabitacionTableAdapter
        Me.TableAdapterManager.hotelTableAdapter = Nothing
        Me.TableAdapterManager.inforeservaTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = u3_sistema_de_reserva.reservasfestivalDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'HabitacionBindingNavigator
        '
        Me.HabitacionBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.HabitacionBindingNavigator.BindingSource = Me.HabitacionBindingSource
        Me.HabitacionBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.HabitacionBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.HabitacionBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.HabitacionBindingNavigatorSaveItem})
        Me.HabitacionBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.HabitacionBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.HabitacionBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.HabitacionBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.HabitacionBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.HabitacionBindingNavigator.Name = "HabitacionBindingNavigator"
        Me.HabitacionBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.HabitacionBindingNavigator.Size = New System.Drawing.Size(633, 25)
        Me.HabitacionBindingNavigator.TabIndex = 1
        Me.HabitacionBindingNavigator.Text = "BindingNavigator1"
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
        'HabitacionBindingNavigatorSaveItem
        '
        Me.HabitacionBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.HabitacionBindingNavigatorSaveItem.Image = CType(resources.GetObject("HabitacionBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.HabitacionBindingNavigatorSaveItem.Name = "HabitacionBindingNavigatorSaveItem"
        Me.HabitacionBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 22)
        Me.HabitacionBindingNavigatorSaveItem.Text = "Guardar datos"
        '
        'IdhabitacionTextBox
        '
        Me.IdhabitacionTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.HabitacionBindingSource, "Idhabitacion", True))
        Me.IdhabitacionTextBox.Location = New System.Drawing.Point(190, 70)
        Me.IdhabitacionTextBox.Name = "IdhabitacionTextBox"
        Me.IdhabitacionTextBox.Size = New System.Drawing.Size(36, 20)
        Me.IdhabitacionTextBox.TabIndex = 3
        '
        'Nombre_de_habitacionTextBox
        '
        Me.Nombre_de_habitacionTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.HabitacionBindingSource, "nombre de habitacion", True))
        Me.Nombre_de_habitacionTextBox.Location = New System.Drawing.Point(190, 96)
        Me.Nombre_de_habitacionTextBox.Name = "Nombre_de_habitacionTextBox"
        Me.Nombre_de_habitacionTextBox.Size = New System.Drawing.Size(100, 20)
        Me.Nombre_de_habitacionTextBox.TabIndex = 5
        '
        'Tipo_de_habitacionTextBox
        '
        Me.Tipo_de_habitacionTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.HabitacionBindingSource, "tipo de habitacion", True))
        Me.Tipo_de_habitacionTextBox.Location = New System.Drawing.Point(190, 122)
        Me.Tipo_de_habitacionTextBox.Name = "Tipo_de_habitacionTextBox"
        Me.Tipo_de_habitacionTextBox.Size = New System.Drawing.Size(100, 20)
        Me.Tipo_de_habitacionTextBox.TabIndex = 7
        '
        'CostoTextBox
        '
        Me.CostoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.HabitacionBindingSource, "costo", True))
        Me.CostoTextBox.Location = New System.Drawing.Point(190, 148)
        Me.CostoTextBox.Name = "CostoTextBox"
        Me.CostoTextBox.Size = New System.Drawing.Size(100, 20)
        Me.CostoTextBox.TabIndex = 9
        '
        'HabitacionDataGridView
        '
        Me.HabitacionDataGridView.AutoGenerateColumns = False
        Me.HabitacionDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.HabitacionDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn6})
        Me.HabitacionDataGridView.DataSource = Me.HabitacionBindingSource
        Me.HabitacionDataGridView.Location = New System.Drawing.Point(101, 201)
        Me.HabitacionDataGridView.Name = "HabitacionDataGridView"
        Me.HabitacionDataGridView.Size = New System.Drawing.Size(443, 220)
        Me.HabitacionDataGridView.TabIndex = 10
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "Idhabitacion"
        Me.DataGridViewTextBoxColumn1.HeaderText = "Idhabitacion"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "nombre de habitacion"
        Me.DataGridViewTextBoxColumn2.HeaderText = "nombre de habitacion"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "tipo de habitacion"
        Me.DataGridViewTextBoxColumn3.HeaderText = "tipo de habitacion"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "costo"
        Me.DataGridViewTextBoxColumn4.HeaderText = "costo"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "Idhotel"
        Me.DataGridViewTextBoxColumn5.HeaderText = "Idhotel"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "Idreserva"
        Me.DataGridViewTextBoxColumn6.HeaderText = "Idreserva"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 39)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(228, 13)
        Me.Label1.TabIndex = 11
        Me.Label1.Text = "REGISTRE LOS DATOS DE LA HABITACIÓN"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(466, 50)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(88, 13)
        Me.Label2.TabIndex = 12
        Me.Label2.Text = "¡INFORMACIÓN!"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(369, 77)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(252, 13)
        Me.Label3.TabIndex = 13
        Me.Label3.Text = "NOMBRE DE LA HABITACIÓN : ""VALLENATERA"""
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(369, 96)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(133, 13)
        Me.Label4.TabIndex = 14
        Me.Label4.Text = "COSTO DE HABITACIÓN:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(369, 122)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(113, 13)
        Me.Label5.TabIndex = 15
        Me.Label5.Text = "*SENCILLA = 100.000"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(369, 148)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(98, 13)
        Me.Label6.TabIndex = 16
        Me.Label6.Text = "*DOBLE = 200.000"
        '
        'Form3
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(633, 508)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.HabitacionDataGridView)
        Me.Controls.Add(IdhabitacionLabel)
        Me.Controls.Add(Me.IdhabitacionTextBox)
        Me.Controls.Add(Nombre_de_habitacionLabel)
        Me.Controls.Add(Me.Nombre_de_habitacionTextBox)
        Me.Controls.Add(Tipo_de_habitacionLabel)
        Me.Controls.Add(Me.Tipo_de_habitacionTextBox)
        Me.Controls.Add(CostoLabel)
        Me.Controls.Add(Me.CostoTextBox)
        Me.Controls.Add(Me.HabitacionBindingNavigator)
        Me.Controls.Add(Me.Button1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Form3"
        Me.Text = "REGISTRAR HABITACIÓN"
        CType(Me.ReservasfestivalDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.HabitacionBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.HabitacionBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.HabitacionBindingNavigator.ResumeLayout(False)
        Me.HabitacionBindingNavigator.PerformLayout()
        CType(Me.HabitacionDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents ReservasfestivalDataSet As u3_sistema_de_reserva.reservasfestivalDataSet
    Friend WithEvents HabitacionBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents HabitacionTableAdapter As u3_sistema_de_reserva.reservasfestivalDataSetTableAdapters.habitacionTableAdapter
    Friend WithEvents TableAdapterManager As u3_sistema_de_reserva.reservasfestivalDataSetTableAdapters.TableAdapterManager
    Friend WithEvents HabitacionBindingNavigator As System.Windows.Forms.BindingNavigator
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
    Friend WithEvents HabitacionBindingNavigatorSaveItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents IdhabitacionTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Nombre_de_habitacionTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Tipo_de_habitacionTextBox As System.Windows.Forms.TextBox
    Friend WithEvents CostoTextBox As System.Windows.Forms.TextBox
    Friend WithEvents HabitacionDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
End Class
