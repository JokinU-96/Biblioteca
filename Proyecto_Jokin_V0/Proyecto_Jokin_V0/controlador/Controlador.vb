Imports System.Data.SQLite

Public Class Controlador

    Public Shared libros As List(Of Libro) = New List(Of Libro)()
    Function cargarLibros()
        libros.Clear()
        Dim Cmd As New SQLiteCommand
        Dim Sql As String = "SELECT * FROM Libros"
        Cmd.CommandText = Sql

        Dim lector = SQLLite.GetDataReader(My.Settings.conexion, Cmd)

        While lector.Read()
            Dim titulo As String = lector.GetString(1) 'Recibe el titulo de cada libro.
            Dim autor As String = lector.GetString(2) 'Recibe el autor de cada libro.
            Dim edicion As Integer = lector.GetInt32(3) 'Recibe la fecha de edicion de cada libro.
            Dim sinopsis As String = lector.GetString(4) 'Recibe la sinopsis de cada libro.
            Dim id As Integer = lector.GetInt32(0) 'Recibe el ID
            Dim libro As Libro = New Libro(titulo, autor, sinopsis, edicion, id)
            libros.Add(libro)
        End While

        MsgBox(libros.Count)
    End Function

    Function crearLibro(titulo As String, autor As String, edicion As Int32, sinopsis As String)
        Dim Cmd As New SQLiteCommand
        Dim Sql As String = "INSERT INTO Libros(Titulo, Escritor, Ano_Edicion, Sinopsis)
                                    VALUES (
                                            @titulo,
                                            @autor,
                                            @edicion,
                                            @sinopsis)" 'Hago un insert con los datos que me pasa la función.

        'Busco el ID más alto en la lista de libros.
        Dim max = 0
        For Each libro In libros
            If libro.ID > max Then
                max = libro.ID
            End If
        Next

        Cmd.CommandText = Sql
        'Cmd.Parameters.Add("@ID", DbType.Int32).Value = max + 1
        Cmd.Parameters.Add("@titulo", DbType.String).Value = titulo
        Cmd.Parameters.Add("@autor", DbType.String).Value = autor
        Cmd.Parameters.Add("@edicion", DbType.Int32).Value = edicion
        Cmd.Parameters.Add("@sinopsis", DbType.String).Value = sinopsis

        SQLLite.Ejecuta(My.Settings.conexion, Cmd)

        cargarLibros()
        Dim encontrado As Boolean = False
        MsgBox(max)
        For Each libro In libros
            If libro.ID >= max + 1 Then
                encontrado = True
                MsgBox(libro.titulo)
            End If
        Next

        If encontrado Then
            MsgBox("Su libro se ha añadido a la base de datos satisfactoriamente.")
        Else
            MsgBox("Su libro no se encuentra en la base de datos.")
        End If
    End Function
End Class