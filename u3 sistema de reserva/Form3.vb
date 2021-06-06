Public Class Form3

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Me.Hide()
        Form4.Show()
    End Sub

    Private Sub Form3_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'ReservasfestivalDataSet.habitacion' Puede moverla o quitarla según sea necesario.
        Me.HabitacionTableAdapter.Fill(Me.ReservasfestivalDataSet.habitacion)
        'TODO: esta línea de código carga datos en la tabla 'ReservasfestivalDataSet.habitacion' Puede moverla o quitarla según sea necesario.
        Me.HabitacionTableAdapter.Fill(Me.ReservasfestivalDataSet.habitacion)

    End Sub

    Private Sub HabitacionBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Validate()
        Me.HabitacionBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.ReservasfestivalDataSet)

    End Sub

    Private Sub HabitacionBindingNavigatorSaveItem_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles HabitacionBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.HabitacionBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.ReservasfestivalDataSet)

    End Sub

    Private Sub IdreservaLabel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub Label2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label2.Click

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Hide()
        Form2.Show()
    End Sub
End Class