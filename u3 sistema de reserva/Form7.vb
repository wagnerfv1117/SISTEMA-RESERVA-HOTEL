﻿Public Class Form7

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Me.Hide()
        Form1.Show()
    End Sub

    Private Sub InforeservaBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles InforeservaBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.InforeservaBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.ReservasfestivalDataSet)

    End Sub

    Private Sub Form7_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'ReservasfestivalDataSet.inforeserva' Puede moverla o quitarla según sea necesario.
        Me.InforeservaTableAdapter.Fill(Me.ReservasfestivalDataSet.inforeserva)

    End Sub
End Class