Public Class Libro
    Property titulo As String
    Property autor As String
    Property sinopsis As String
    Property edicion As Integer
    Property disponible As Boolean
    Property ID As Integer

    Public Sub New(titulo As String, autor As String, sinopsis As String, edicion As Integer, iD As Integer)
        Me.titulo = titulo
        Me.autor = autor
        Me.sinopsis = sinopsis
        Me.edicion = edicion
        Me.ID = iD
    End Sub
End Class
