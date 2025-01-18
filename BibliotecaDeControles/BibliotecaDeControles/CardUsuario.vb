Public Class CardUsuario
    Property NombreApellidos As String
        Get
            Return lblNombre.Text
        End Get
        Set(value As String)
            lblNombre.Text = value
        End Set
    End Property
    Property id As Integer
        Get
            Try
                Dim numeroID As Integer = lblID.Text
                Return numeroID
            Catch ex As Exception
                Return MsgBox("El ID no tiene un formato adecuado. Debe ser un número.")
            End Try
        End Get
        Set(value As Integer)
            lblID.Text = value
        End Set
    End Property

    Property telefono As String
        Get
            Return lblTlfno.Text
        End Get
        Set(value As String)
            lblTlfno.Text = value
        End Set
    End Property

    Private Sub btnModificar_Click(sender As Object, e As EventArgs) Handles btnModificar.Click
        RaiseEvent modificarUsuario()
    End Sub

    Public Event modificarUsuario()

    Private Sub btnVisualizar_Click(sender As Object, e As EventArgs) Handles btnVisualizar.Click
        RaiseEvent visualizarUsuario()
    End Sub

    Public Event visualizarUsuario()

    Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click
        RaiseEvent eliminarUsuario()
    End Sub

    Public Event eliminarUsuario()
End Class
