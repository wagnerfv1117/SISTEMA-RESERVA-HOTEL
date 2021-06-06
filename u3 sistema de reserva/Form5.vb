Public Class Form5

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Me.Hide()
        Form6.Show()
    End Sub

    Private Sub InforeservaBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles InforeservaBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.InforeservaBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.ReservasfestivalDataSet)

    End Sub

    Private Sub Form5_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'ReservasfestivalDataSet.habitacion' Puede moverla o quitarla según sea necesario.
        Me.HabitacionTableAdapter.Fill(Me.ReservasfestivalDataSet.habitacion)
        'TODO: esta línea de código carga datos en la tabla 'ReservasfestivalDataSet.cliente' Puede moverla o quitarla según sea necesario.
        Me.ClienteTableAdapter.Fill(Me.ReservasfestivalDataSet.cliente)
        'TODO: esta línea de código carga datos en la tabla 'ReservasfestivalDataSet.inforeserva' Puede moverla o quitarla según sea necesario.
        Me.InforeservaTableAdapter.Fill(Me.ReservasfestivalDataSet.inforeserva)

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Hide()
        Form4.Show()
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Me.Hide()
        Form1.Show()
    End Sub
End Class