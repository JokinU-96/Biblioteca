Public Class VNuevoLibro

    Dim miControlador As New Controlador
    Private Sub btnAceptar_Click(sender As Object, e As EventArgs) Handles btnAceptar.Click
        miControlador.crearLibro(tbTitulo.Text, tbAutor.Text, nudEdicion.Value, tbSinopsis.Text)
    End Sub
End Class