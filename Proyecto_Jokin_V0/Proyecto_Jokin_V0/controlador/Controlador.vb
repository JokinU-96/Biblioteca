Imports System.Data.SQLite

Public Class Controlador
    Public libros As New List(Of Libro)
    Function cargarLibros()
        Dim Cmd As New SQLiteCommand
        Dim Sql As String = "SELECT * FROM Libros"
        MsgBox(Sql)
        Cmd.CommandText = Sql

        Dim lector = SQLLite.GetDataReader(My.Settings.conexion, Cmd)

        While lector.Read()
            Dim titulo As String = lector.GetString(1) 'Recibe el titulo de cada libro.
            Dim autor As String = lector.GetString(2) 'Recibe el autor de cada libro.
            Dim edicion As Integer = lector.GetInt32(3) 'Recibe la fecha de edicion de cada libro.
            Dim sinopsis As String = lector.GetString(4) 'Recibe la sinopsis de cada libro.
            Dim libro As Libro = New Libro(titulo, autor, sinopsis, edicion)
            libros.Append(libro)
        End While
    End Function
End Class