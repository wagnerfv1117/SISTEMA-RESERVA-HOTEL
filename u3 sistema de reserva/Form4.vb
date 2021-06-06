Public Class Form4

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Me.Hide()
        Form5.Show()
    End Sub

    Private Sub HotelBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Validate()
        Me.HotelBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.ReservasfestivalDataSet)

    End Sub

    Private Sub Form4_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'ReservasfestivalDataSet.hotel' Puede moverla o quitarla según sea necesario.
        Me.HotelTableAdapter.Fill(Me.ReservasfestivalDataSet.hotel)

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Hide()
        Form3.Show()
    End Sub
End Class