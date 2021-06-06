<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form6
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form6))
        Me.Button2 = New System.Windows.Forms.Button()
        Me.ReservasfestivalDataSet = New u3_sistema_de_reserva.reservasfestivalDataSet()
        Me.InforeservaBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.InforeservaTableAdapter = New u3_sistema_de_reserva.reservasfestivalDataSetTableAdapters.inforeservaTableAdapter()
        Me.TableAdapterManager = New u3_sistema_de_reserva.reservasfestivalDataSetTableAdapters.TableAdapterManager()
        Me.InforeservaDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Label1 = New System.Windows.Forms.Label()
        CType(Me.ReservasfestivalDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.InforeservaBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.InforeservaDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(224, 353)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(191, 23)
        Me.Button2.TabIndex = 1
        Me.Button2.Text = "IR A MENÚ PRINCIPAL"
        Me.Button2.UseVisualStyleBackColor = True
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
        Me.TableAdapterManager.clienteTableAdapter = Nothing
        Me.TableAdapterManager.habitacionTableAdapter = Nothing
        Me.TableAdapterManager.hotelTableAdapter = Nothing
        Me.TableAdapterManager.inforeservaTableAdapter = Me.InforeservaTableAdapter
        Me.TableAdapterManager.UpdateOrder = u3_sistema_de_reserva.reservasfestivalDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'InforeservaDataGridView
        '
        Me.InforeservaDataGridView.AutoGenerateColumns = False
        Me.InforeservaDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.InforeservaDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn6, Me.DataGridViewTextBoxColumn7})
        Me.InforeservaDataGridView.DataSource = Me.InforeservaBindingSource
        Me.InforeservaDataGridView.Location = New System.Drawing.Point(12, 98)
        Me.InforeservaDataGridView.Name = "InforeservaDataGridView"
        Me.InforeservaDataGridView.Size = New System.Drawing.Size(568, 220)
        Me.InforeservaDataGridView.TabIndex = 3
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "Idreserva"
        Me.DataGridViewTextBoxColumn1.HeaderText = "Idreserva"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "fecha de la reserva"
        Me.DataGridViewTextBoxColumn2.HeaderText = "fecha de la reserva"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "fecha de ingreso al hotel"
        Me.DataGridViewTextBoxColumn3.HeaderText = "fecha de ingreso al hotel"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "fecha de salida del hotel"
        Me.DataGridViewTextBoxColumn4.HeaderText = "fecha de salida del hotel"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "costo"
        Me.DataGridViewTextBoxColumn5.HeaderText = "costo"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "Idcliente"
        Me.DataGridViewTextBoxColumn6.HeaderText = "Idcliente"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.DataPropertyName = "Idhabitacion"
        Me.DataGridViewTextBoxColumn7.HeaderText = "Idhabitacion"
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(221, 68)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(188, 13)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "¡RESERVA REALIZADA CON ÉXTIO!"
        '
        'Form6
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(592, 400)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.InforeservaDataGridView)
        Me.Controls.Add(Me.Button2)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Form6"
        Me.Text = "DETALLES DE LA RESERVA"
        CType(Me.ReservasfestivalDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.InforeservaBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.InforeservaDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents ReservasfestivalDataSet As u3_sistema_de_reserva.reservasfestivalDataSet
    Friend WithEvents InforeservaBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents InforeservaTableAdapter As u3_sistema_de_reserva.reservasfestivalDataSetTableAdapters.inforeservaTableAdapter
    Friend WithEvents TableAdapterManager As u3_sistema_de_reserva.reservasfestivalDataSetTableAdapters.TableAdapterManager
    Friend WithEvents InforeservaDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn7 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Label1 As System.Windows.Forms.Label
End Class
