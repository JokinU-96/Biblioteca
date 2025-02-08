Imports System.Data.SqlClient
Imports System.Data.SQLite
Imports BibliotecaDeControles

Public Class Controlador

    Public Shared libros As List(Of Libro) = New List(Of Libro)()
    Public Shared usuarios As List(Of Usuario) = New List(Of Usuario)()

    Dim colorRojo = New Integer() {193, 70, 52}
    Dim colorVerde = New Integer() {67, 114, 94}
    Sub cargarLibros()
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

            If lector.GetInt32(5) = 1 Then
                libro.disponible = True
            ElseIf lector.GetInt32(5) = 0 Then
                libro.disponible = False
            End If

            libros.Add(libro)

        End While

    End Sub

    Sub cargarUsuarios()
        usuarios.Clear()
        Dim Cmd As New SQLiteCommand
        Dim Sql As String = "SELECT * FROM Usuarios"
        Cmd.CommandText = Sql

        Dim lector = SQLLite.GetDataReader(My.Settings.conexion, Cmd)

        While lector.Read()
            Dim nombre As String = lector.GetString(1) 'Recibe el nomrbe de cada usuario.
            Dim apellido_1 As String = lector.GetString(2) 'Recibe el primer apellido de cada usuario.
            Dim apellido_2 As String = lector.GetString(3) 'Recibe el segundo apellido de cada usuario.
            Dim telefono As Integer = lector.GetInt32(4) 'Recibe el telefono de cada usuario.
            Dim id As Integer = lector.GetInt32(0) 'Recibe el ID
            Dim usuario As Usuario = New Usuario(nombre, apellido_1, apellido_2, telefono, id)

            usuarios.Add(usuario)
        End While

    End Sub

    Sub crearLibro(titulo As String, autor As String, edicion As Int32, sinopsis As String)
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

        For Each libro In libros
            If libro.ID >= max + 1 Then
                encontrado = True
                MsgBox(libro.titulo + " añadido")
            End If
        Next

        If Not encontrado Then
            MsgBox("Su libro no se encuentra en la base de datos.")
        End If
    End Sub

    Sub eliminarLibro(libro As Libro)
        Dim respuesta = MsgBox("¿Intentas eliminarme?", vbOKCancel, "Eliminar libro")

        If respuesta = vbOK Then
            'Borro el libro
            Dim Cmd As New SQLiteCommand
            Dim Sql As String = "DELETE FROM Libros WHERE ID = @ID" 'Hago un delete con los datos que me pasa la función.
            MsgBox(libro.ID)
            Cmd.CommandText = Sql
            Cmd.Parameters.Add("@ID", DbType.Int32).Value = libro.ID

            SQLLite.Ejecuta(My.Settings.conexion, Cmd)

            Dim encontrado As Libro 'Borro el libro de la lista de libros

            For Each l In libros
                If l.ID = libro.ID Then
                    encontrado = l
                    MsgBox(l.titulo + " eliminado")
                End If
            Next
            libros.Remove(encontrado)

            Dim controlEncontrado As CardLibro 'Borro el control de usuario de la lista de controles de usuario

            For Each control In Biblioteca.controlesLibro
                If control.Titulo = libro.titulo Then
                    controlEncontrado = control
                End If
            Next

            Biblioteca.controlesLibro.Remove(controlEncontrado)

            Dim e As Control 'Borro el control de usuario de la interfaz de tabla

            For Each control In Vlibros.tlpFondo.Controls
                If control.Name = libro.ID.ToString Then
                    MsgBox(control.Name)
                    e = control
                End If
            Next
            Vlibros.tlpFondo.Controls.Remove(e)

            cargarLibros()
        Else

        End If

    End Sub

    Sub modificarLibro(titulo As String, autor As String, edicion As Int32, sinopsis As String, ID As Integer)
        Dim Cmd As New SQLiteCommand
        Dim Sql As String = "UPDATE Libros
                                SET
                                    Titulo = @titulo,
                                    Escritor = @autor,
                                    Ano_Edicion = @edicion,
                                    Sinopsis = @sinopsis
                                WHERE
                                    ID = @ID" 'Hago un update con los datos que me pasa la función.

        Cmd.CommandText = Sql
        Cmd.Parameters.Add("@ID", DbType.Int32).Value = ID
        Cmd.Parameters.Add("@titulo", DbType.String).Value = titulo
        Cmd.Parameters.Add("@autor", DbType.String).Value = autor
        Cmd.Parameters.Add("@edicion", DbType.Int32).Value = edicion
        Cmd.Parameters.Add("@sinopsis", DbType.String).Value = sinopsis

        SQLLite.Ejecuta(My.Settings.conexion, Cmd)

        cargarLibros()

        MsgBox("El libro ha sido actualizado en la base de datos.")
    End Sub

    Sub prestarLibro(libro As Libro)
        Dim Cmd As New SQLiteCommand
        Dim Sql As String = "UPDATE Libros
                                SET
                                    Disponible = @disponible
                                WHERE
                                    ID = @ID" 'Hago un update con los datos que me pasa la función.

        Cmd.CommandText = Sql

        Dim n As Int32 = 0

        If libro.disponible Then
            n = 0  'Si el libro está disponible lo pongo como No disponible porque el usuario ha pulsado para prestarlo.
            libro.disponible = False
            For Each ctrl In Vlibros.tlpFondo.Controls
                If ctrl.Name = libro.ID Then
                    ctrl.Prestar = "PRESTADO"
                    ctrl.colorPrestar = colorRojo
                    MsgBox("El libro ha sido prestado.")
                End If
            Next
        Else
            n = 1
            libro.disponible = True
            For Each ctrl In Vlibros.tlpFondo.Controls
                If ctrl.Name = libro.ID Then
                    ctrl.Prestar = "PRESTAR"
                    ctrl.colorPrestar = colorVerde
                    MsgBox("El libro ha sido devuelto.")
                End If
            Next
        End If

        Cmd.Parameters.Add("@ID", DbType.Int32).Value = libro.ID
        Cmd.Parameters.Add("@disponible", DbType.Int32).Value = n

        SQLLite.Ejecuta(My.Settings.conexion, Cmd)

    End Sub

    Sub crearUsuario(nombre As String, apellido_1 As String, apellido_2 As String, telefono As Int32)
        Dim Cmd As New SQLiteCommand
        Dim Sql As String = "INSERT INTO Usuarios(Nombre, Apellido_1, Apellido_2, Telefono)
                                    VALUES (
                                            @nombre,
                                            @apellido_1,
                                            @apellido_2,
                                            @telefono)" 'Hago un insert con los datos que me pasa la función.

        'Busco el ID más alto en la lista de usuarios.
        Dim max = 0
        For Each usuario In usuarios
            If usuario.ID > max Then
                max = usuario.ID
            End If
        Next

        Cmd.CommandText = Sql
        'Cmd.Parameters.Add("@ID", DbType.Int32).Value = max + 1
        Cmd.Parameters.Add("@nombre", DbType.String).Value = nombre
        Cmd.Parameters.Add("@apellido_1", DbType.String).Value = apellido_1
        Cmd.Parameters.Add("@apellido_2", DbType.String).Value = apellido_2
        Cmd.Parameters.Add("@telefono", DbType.Int32).Value = telefono

        SQLLite.Ejecuta(My.Settings.conexion, Cmd)

        cargarLibros()
        Dim encontrado As Boolean = False
        MsgBox(max)
        For Each usuario In usuarios
            If usuario.ID >= max + 1 Then
                encontrado = True
                MsgBox(usuario.nombre + " añadido")
            End If
        Next

        If Not encontrado Then
            MsgBox("El usuario no se encuentra en la base de datos.")
        End If
    End Sub

    Sub eliminarUsuario(usuario As Usuario)
        Dim respuesta = MsgBox("¿Intentas eliminarme?", vbOKCancel, "Eliminar usuario")

        If respuesta = vbOK Then
            'Borro el usuario
            Dim Cmd As New SQLiteCommand
            Dim Sql As String = "DELETE FROM Usuario WHERE ID = @ID" 'Hago un delete con los datos que me pasa la función.
            MsgBox(usuario.ID)
            Cmd.CommandText = Sql
            Cmd.Parameters.Add("@ID", DbType.Int32).Value = usuario.ID

            SQLLite.Ejecuta(My.Settings.conexion, Cmd)

            Dim encontrado As Usuario 'Borro el usuario de la lista de usuarios

            For Each u In usuarios
                If u.ID = usuario.ID Then
                    encontrado = u
                    MsgBox(u.nombre + " eliminado")
                End If
            Next
            usuarios.Remove(encontrado)

            Dim controlEncontrado As CardUsuario 'Borro el control de usuario de la lista de controles de usuario

            For Each control In Biblioteca.controlesUsuario
                If control.id = usuario.ID Then
                    controlEncontrado = control
                End If
            Next

            Biblioteca.controlesUsuario.Remove(controlEncontrado)

            Dim e As Control 'Borro el control de usuario de la interfaz de tabla

            For Each control In Vusuarios.tlpFondo.Controls
                If control.Name = usuario.ID.ToString Then
                    MsgBox(control.Name)
                    e = control
                End If
            Next
            Vusuarios.tlpFondo.Controls.Remove(e)

            cargarUsuarios()
        Else

        End If
    End Sub

    Sub modificarUsuario(nombre As String, apellido_1 As String, apellido_2 As String, telefono As Integer, ID As Integer)
        Dim Cmd As New SQLiteCommand
        Dim Sql As String = "UPDATE Usuarios
                                SET
                                    Nombre = @nombre,
                                    Apellido_1 = @apellido_1,
                                    Apellido_2 = @apellido_2,
                                    Telefono = @telefono
                                WHERE
                                    ID = @ID" 'Hago un update con los datos que me pasa la función.

        Cmd.CommandText = Sql
        Cmd.Parameters.Add("@ID", DbType.Int32).Value = ID
        Cmd.Parameters.Add("@titulo", DbType.String).Value = nombre
        Cmd.Parameters.Add("@autor", DbType.String).Value = apellido_1
        Cmd.Parameters.Add("@edicion", DbType.Int32).Value = apellido_2
        Cmd.Parameters.Add("@sinopsis", DbType.String).Value = telefono

        SQLLite.Ejecuta(My.Settings.conexion, Cmd)

        cargarLibros()

        MsgBox("El usuario ha sido actualizado en la base de datos.")
    End Sub

    Function cambiarColor(color)
        Return System.Drawing.Color.FromArgb(CType(CType(color(0), Byte), Integer), CType(CType(color(1), Byte), Integer), CType(CType(color(2), Byte), Integer))
    End Function
End Class