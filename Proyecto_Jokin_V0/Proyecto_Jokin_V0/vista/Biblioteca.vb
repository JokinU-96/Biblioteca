Imports System.Data.SQLite
Imports System.Security.Cryptography.X509Certificates
Imports BibliotecaDeControles

Public Class Biblioteca
    Dim mostrado As Boolean = False

    Dim contadorHandler As Integer = 0

    Public miControlador As New Controlador

    Public Shared controlesLibro As List(Of CardLibro) = New List(Of CardLibro)()
    Public Shared controlesUsuario As List(Of CardUsuario) = New List(Of CardUsuario)()

    Dim c = 0
    Dim colorVerde = New Integer() {67, 114, 94}
    Dim colorBlanco = New Integer() {255, 255, 255}
    Dim colorNegro = New Integer() {0, 0, 0}
    Dim colorRojo = New Integer() {193, 70, 52}
    Private Sub Biblioteca_Activated(sender As Object, e As EventArgs) Handles MyBase.Activated
        mostrado = True
        If mostrado Then
            Vlibro.Width = PanelPrincipal.Width
            Vusuario.Width = PanelPrincipal.Width
        End If
    End Sub
    Sub cambiarPanel(panel As Form)
        PanelPrincipal.Controls.Clear()
        panel.TopLevel = False
        PanelPrincipal.Controls.Add(panel)
        panel.Show()
    End Sub

    Private Sub btnUsuarios_Click(sender As Object, e As EventArgs) Handles btnUsuarios.Click
        cambiarPanel(Vusuarios)
        btnUsuarios.BackColor = miControlador.cambiarColor(colorBlanco)
        btnUsuarios.ForeColor = miControlador.cambiarColor(colorVerde)

        btnLibros.BackColor = miControlador.cambiarColor(colorVerde)
        btnLibros.ForeColor = miControlador.cambiarColor(colorBlanco)

        'Cargo los usaurios desde la base de datos a la tabla de usuarios'
        miControlador.cargarUsuarios()
        nuevaTablaUsuarios()
    End Sub

    Public Function nuevaTablaUsuarios()
        Dim tablaCreada As Boolean = False
        Dim fila = 0

        Dim nuevosUsuarios As List(Of CardUsuario) = New List(Of CardUsuario)()

        For i As Integer = 0 To Controlador.usuarios.Count - 1
            Dim encontrado = False
            If controlesUsuario.Count > 0 Then
                For j As Integer = 0 To controlesUsuario.Count - 1
                    If Controlador.usuarios(i).ID = controlesUsuario(j).Name Then
                        encontrado = True
                    End If
                Next
            End If

            If Not encontrado Then
                nuevosUsuarios.Add(New CardUsuario())
            End If
        Next

        controlesUsuario.AddRange(nuevosUsuarios)

        Vusuarios.tlpFondo.SuspendLayout()

        For i As Integer = 0 To controlesUsuario.Count - 1
            Vusuarios.tlpFondo.Controls.Add(controlesUsuario(i), 0, fila) 'Le asigno su fila
        Next

        Vusuarios.tlpFondo.RowCount = controlesUsuario.Count + 3

        fila += 1 'cambio a la primera fila (0: margen)
        fila += 1 'cambio a la segunda fila (1: encabezado)

        For i As Integer = 0 To controlesUsuario.Count - 1
            Vusuario.tlpFondo.RowStyles.Add(New RowStyle(SizeType.AutoSize))
        Next

        Dim YO As Integer = 132

        For i As Integer = 0 To controlesUsuario.Count - 1

            controlesUsuario(i).NombreApellidos = Controlador.usuarios(i).nombre + " " + Controlador.usuarios(i).apellido_1 + " " + Controlador.usuarios(i).apellido_2
            controlesUsuario(i).telefono = Controlador.usuarios(i).telefono
            controlesUsuario(i).id = Controlador.usuarios(i).ID
            controlesUsuario(i).AutoSize = True
            controlesUsuario(i).Dock = DockStyle.Fill
            controlesUsuario(i).Location = New Point(227, YO)
            controlesUsuario(i).MinimumSize = New Size(700, 230)
            controlesUsuario(i).Size = New Size(Vusuarios.tlpFondo.Width, 230)
            controlesUsuario(i).Name = Controlador.usuarios(i).ID 'ID del usuario
            controlesUsuario(i).Padding = New Padding(9, 8, 9, 8)
            controlesUsuario(i).Size = New Size(800, 230)
            controlesUsuario(i).TabIndex = fila

            If Not controlesUsuario(i).TieneEventos Then

                Dim usuario As Usuario = Controlador.usuarios(i)

                AddHandler controlesUsuario(i).eliminarUsuario, Sub()
                                                                    miControlador.eliminarUsuario(usuario)
                                                                End Sub

                AddHandler controlesUsuario(i).visualizarUsuario, Sub()
                                                                      visualizarUsuario(usuario)
                                                                  End Sub

                AddHandler controlesUsuario(i).modificarUsuario, Sub()
                                                                     VNuevoUsuario.tbNombre.Text = usuario.nombre
                                                                     VNuevoUsuario.tbApellido_1.Text = usuario.apellido_1
                                                                     VNuevoUsuario.tbApellido_2.Text = usuario.apellido_2
                                                                     VNuevoUsuario.tbTelefono.Text = usuario.telefono
                                                                     VNuevoUsuario.btnAceptar.Text = "Modificar"
                                                                     VNuevoUsuario.lblID.Text = usuario.ID
                                                                     VNuevoUsuario.Show()
                                                                 End Sub
            End If

            controlesUsuario(i).TieneEventos = True


            fila += 1 'avanzo con las filas
            YO += 237 'avanzo con las coordenadas en vertical
        Next

        Vusuarios.tlpFondo.ResumeLayout(False)
        Vusuarios.tlpFondo.PerformLayout()

        Return tablaCreada = True
    End Function

    Sub visualizarUsuario(usuario As Usuario)
        Vusuario.lblNombreDinamico.Text = usuario.nombre
        Vusuario.lblApellidoDinamico_1.Text = usuario.apellido_1
        Vusuario.lblApellidoDinamico_2.Text = usuario.apellido_2
        Vusuario.lblTelefonoDinamico.Text = usuario.telefono
        Vusuario.lblID.Text = usuario.ID
        Vusuario.dgvPrestamosXUsuario.DataSource = Nothing
        Vusuario.dgvPrestamosXUsuario.Rows.Clear()

        For Each usuario In Controlador.usuarios
            If usuario.ID.ToString = Vusuario.lblID.Text Then
                Vusuario.dgvPrestamosXUsuario.DataSource = miControlador.cargarDatosPrestamosXUsuario(usuario)
            End If
        Next
        cambiarPanel(Vusuario)
    End Sub


    Private Sub btnLibros_Click(sender As Object, e As EventArgs) Handles btnLibros.Click
        cambiarPanel(Vlibros)
        btnLibros.BackColor = miControlador.cambiarColor(colorBlanco)
        btnLibros.ForeColor = miControlador.cambiarColor(colorVerde)

        btnUsuarios.BackColor = miControlador.cambiarColor(colorVerde)
        btnUsuarios.ForeColor = miControlador.cambiarColor(colorBlanco)

        'Cargo los libros desde la base de datos a la tabla de libros'
        miControlador.cargarLibros()
        nuevaTablaLibros()
    End Sub

    Private Sub btnCrearUsuario_Click(sender As Object, e As EventArgs)
        VNuevoUsuario.Show()
    End Sub


    Public Function nuevaTablaLibros()
        Dim tablaCreada As Boolean = False
        Dim fila = 0

        Dim nuevosLibros As List(Of CardLibro) = New List(Of CardLibro)()

        For i As Integer = 0 To Controlador.libros.Count - 1
            Dim encontrado = False
            If controlesLibro.Count > 0 Then
                For j As Integer = 0 To controlesLibro.Count - 1
                    If Controlador.libros(i).ID = controlesLibro(j).Name Then
                        encontrado = True
                    End If
                Next
            End If

            If Not encontrado Then
                nuevosLibros.Add(New CardLibro())
            End If
        Next

        controlesLibro.AddRange(nuevosLibros)

        Vlibros.tlpFondo.SuspendLayout()

        For i As Integer = 0 To controlesLibro.Count - 1
            Vlibros.tlpFondo.Controls.Add(controlesLibro(i), 0, fila) 'Le asigno su fila
        Next

        Vlibros.tlpFondo.RowCount = controlesLibro.Count + 3

        fila += 1 'cambio a la primera fila (0: margen)
        fila += 1 'cambio a la segunda fila (1: encabezado)

        For i As Integer = 0 To controlesLibro.Count - 1
            Vlibros.tlpFondo.RowStyles.Add(New RowStyle(SizeType.AutoSize))
        Next


        Dim YO As Integer = 132

        For i As Integer = 0 To controlesLibro.Count - 1

            controlesLibro(i).Titulo = Controlador.libros(i).titulo
            controlesLibro(i).Autor = Controlador.libros(i).autor
            controlesLibro(i).Edicion = Controlador.libros(i).edicion
            controlesLibro(i).AutoSize = True
            controlesLibro(i).Dock = DockStyle.Fill
            controlesLibro(i).Location = New Point(227, YO)
            controlesLibro(i).MinimumSize = New Size(700, 230)
            controlesLibro(i).Size = New Size(Vlibros.tlpFondo.Width, 230)
            controlesLibro(i).Name = Controlador.libros(i).ID 'ID del libro
            controlesLibro(i).Padding = New Padding(9, 8, 9, 8)
            controlesLibro(i).Size = New Size(800, 230)
            controlesLibro(i).TabIndex = fila

            If Controlador.libros(i).disponible Then
                controlesLibro(i).Prestar = "PRESTAR"
                controlesLibro(i).colorPrestar = colorVerde
            ElseIf Not Controlador.libros(i).disponible Then
                controlesLibro(i).Prestar = "PRESTADO"
                controlesLibro(i).colorPrestar = colorRojo
            End If

            If Not controlesLibro(i).TieneEventos Then

                Dim libro As Libro = Controlador.libros(i)

                AddHandler controlesLibro(i).prestarLibro, Sub()
                                                               If Vlibros.obtenerUsuarioDGV Is Nothing And libro.disponible Then
                                                                   MsgBox("Selecciona una fila.")
                                                               ElseIf libro.disponible Then
                                                                   miControlador.prestarLibro(libro, Vlibros.obtenerUsuarioDGV())
                                                               ElseIf Not libro.disponible Then
                                                                   miControlador.cargarPrestamos()
                                                                   Dim idUsuario As Integer
                                                                   For Each e In Controlador.prestamos
                                                                       If e.IDlibro = libro.ID Then
                                                                           idUsuario = e.IDusuario
                                                                       End If
                                                                   Next

                                                                   For Each u In Controlador.usuarios
                                                                       If u.ID = idUsuario Then
                                                                           miControlador.prestarLibro(libro, u)
                                                                       End If
                                                                   Next
                                                               End If 'tengo que recoger el usuario seleccionado en el datagridview
                                                           End Sub

                AddHandler controlesLibro(i).eliminarLibro, Sub()
                                                                miControlador.eliminarLibro(libro)
                                                            End Sub

                AddHandler controlesLibro(i).visualizarLibro, Sub()
                                                                  visualizarLibro(libro)
                                                              End Sub

                AddHandler controlesLibro(i).modificarLibro, Sub()
                                                                 VNuevoLibro.tbTitulo.Text = libro.titulo
                                                                 VNuevoLibro.tbAutor.Text = libro.autor
                                                                 VNuevoLibro.nudEdicion.Value = libro.edicion
                                                                 VNuevoLibro.tbSinopsis.Text = libro.sinopsis
                                                                 VNuevoLibro.btnAceptar.Text = "Modificar"
                                                                 VNuevoLibro.lblID.Text = libro.ID
                                                                 VNuevoLibro.Show()
                                                             End Sub
            End If

            controlesLibro(i).TieneEventos = True


            fila += 1 'avanzo con las filas
            YO += 237 'avanzo con las coordenadas en vertical
        Next

        Vlibros.tlpFondo.ResumeLayout(False)
        Vlibros.tlpFondo.PerformLayout()

        Return tablaCreada = True
    End Function

    Function visualizarLibro(libro As Libro)
        cambiarPanel(Vlibro)
        Vlibro.lblTituloDinamico.Text = libro.titulo
        Vlibro.lblAutorDinamico.Text = libro.autor
        Vlibro.lblEdicionDinamico.Text = libro.edicion
        Vlibro.lblSinopsisDinamico.Text = libro.sinopsis
    End Function

    Private Sub btnCrearLibro_Click(sender As Object, e As EventArgs) Handles btnCrearLibro.Click
        VNuevoLibro.Show()
    End Sub

    Private Sub Biblioteca_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        miControlador.cargarLibros()
        miControlador.cargarUsuarios()
    End Sub

    Private Sub PanelPrincipal_Resize(sender As Object, e As EventArgs) Handles PanelPrincipal.Resize
        Vlibros.Width = PanelPrincipal.Width
        Vlibros.Height = PanelPrincipal.Height
        Vusuarios.Width = PanelPrincipal.Width
        Vusuarios.Height = PanelPrincipal.Height
        Vlibro.Width = PanelPrincipal.Width
        Vlibro.Height = PanelPrincipal.Height
        Vusuario.Width = PanelPrincipal.Width
        Vusuario.Height = PanelPrincipal.Height
    End Sub
End Class