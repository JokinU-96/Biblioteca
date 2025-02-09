Public Class VNuevoLibro

    Dim miControlador As New Controlador
    Private Sub btnAceptar_Click(sender As Object, e As EventArgs) Handles btnAceptar.Click
        If btnAceptar.Text = "Añadir" Then
            miControlador.crearLibro(tbTitulo.Text, tbAutor.Text, nudEdicion.Value, tbSinopsis.Text)
            limpiarFormulario()
        ElseIf btnAceptar.Text = "Modificar" Then
            miControlador.modificarLibro(tbTitulo.Text, tbAutor.Text, nudEdicion.Value, tbSinopsis.Text, Int(lblID.Text))
        End If
    End Sub

    Function limpiarFormulario()
        tbTitulo.Text = ""
        tbAutor.Text = ""
        tbSinopsis.Text = ""
        nudEdicion.Value = 1999
    End Function

    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        limpiarFormulario()
        cerrarVentana()
        Biblioteca.nuevaTablaLibros()
    End Sub

    Function cerrarVentana()
        Me.Close()
    End Function
End Class