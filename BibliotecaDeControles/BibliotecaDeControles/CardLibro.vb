Public Class CardLibro

    Dim eventos As Boolean = False
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

    Property Edicion As String
        Get
            Return lblEdicion.Text
        End Get
        Set(value As String)
            lblEdicion.Text = value
        End Set
    End Property

    Property TieneEventos As Boolean
        Get
            Return eventos
        End Get
        Set(value As Boolean)
            eventos = value
        End Set
    End Property

    Property Prestar As String
        Get
            Return btnPrestar.Text
        End Get
        Set(value As String)
            btnPrestar.Text = value
        End Set
    End Property

    Property colorPrestar As Integer()
        Get
            MsgBox("Sin implementar") 'Debería devolver el valor del color actual.
        End Get
        Set(value As Integer())
            btnPrestar.BackColor = System.Drawing.Color.FromArgb(CType(CType(value(0), Byte), Integer), CType(CType(value(1), Byte), Integer), CType(CType(value(2), Byte), Integer))
        End Set
    End Property


    Private Sub btnFotoPerfil_Click(sender As Object, e As EventArgs) Handles btnFotoPerfil.Click
        RaiseEvent visualizarLibro()
    End Sub

    Private Sub btnModificar_Click_1(sender As Object, e As EventArgs) Handles btnModificar.Click
        RaiseEvent modificarLibro()
    End Sub

    Private Sub btnVisualizar_Click_1(sender As Object, e As EventArgs) Handles btnVisualizar.Click
        RaiseEvent visualizarLibro()
    End Sub

    Private Sub btnEliminar_Click_1(sender As Object, e As EventArgs) Handles btnEliminar.Click
        RaiseEvent eliminarLibro()
    End Sub

    Private Sub btnPrestar_Click(sender As Object, e As EventArgs) Handles btnPrestar.Click
        RaiseEvent prestarLibro()
    End Sub

    Public Event modificarLibro()

    Public Event visualizarLibro()

    Public Event eliminarLibro()

    Public Event prestarLibro()
End Class
