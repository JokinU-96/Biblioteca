Public Class CardLibro
    Property Titulo As String
        Get
            Return lblNombre.Text
        End Get
        Set(value As String)
            lblNombre.Text = value
        End Set
    End Property

    Property Autor As String
        Get
            Return lblAutor.Text
        End Get
        Set(value As String)
            lblAutor.Text = value
        End Set
    End Property

    Private Sub btnModificar_Click(sender As Object, e As EventArgs) Handles btnModificar.Click
        RaiseEvent modificarLibro()
    End Sub

    Public Event modificarLibro()

    Private Sub btnVisualizar_Click(sender As Object, e As EventArgs) Handles btnVisualizar.Click
        RaiseEvent visualizarLibro()
    End Sub

    Public Event visualizarLibro()

    Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click
        RaiseEvent eliminarLibro()
    End Sub

    Public Event eliminarLibro()
End Class
