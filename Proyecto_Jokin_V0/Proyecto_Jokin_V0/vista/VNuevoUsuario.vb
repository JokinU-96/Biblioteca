﻿Public Class VNuevoUsuario
    Dim miControlador As New Controlador
    Private Sub btnAceptar_Click(sender As Object, e As EventArgs) Handles btnAceptar.Click
        If btnAceptar.Text = "Añadir" Then
            miControlador.crearUsuario(tbNombre.Text, tbApellido_1.Text, tbApellido_2.Text, Int(tbTelefono.Text))
            limpiarFormulario()
        ElseIf btnAceptar.Text = "Modificar" Then
            miControlador.modificarUsuario(tbNombre.Text, tbApellido_1.Text, tbApellido_2.Text, tbTelefono.Text, Int(lblID.Text))
        End If
    End Sub

    Sub limpiarFormulario()
        tbNombre.Text = ""
        tbApellido_1.Text = ""
        tbApellido_2.Text = ""
        tbTelefono.Text = ""
    End Sub

    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        limpiarFormulario()
        cerrarVentana()
        Biblioteca.nuevaTablaUsuarios()
    End Sub

    Sub cerrarVentana()
        Me.Close()
    End Sub
End Class