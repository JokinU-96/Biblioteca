﻿Imports System.Data.SQLite
Imports System.Security.Cryptography.X509Certificates
Imports BibliotecaDeControles

Public Class Biblioteca
    Dim mostrado As Boolean = False

    Public miControlador As New Controlador

    Dim controlesLibro As List(Of CardLibro) = New List(Of CardLibro)()

    Dim c = 0
    Dim colorVerde = New Integer() {67, 114, 94}
    Dim colorBlanco = New Integer() {255, 255, 255}
    Dim colorNegro = New Integer() {0, 0, 0}
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

    Private Sub btnLibros_Click(sender As Object, e As EventArgs) Handles btnLibros.Click
        cambiarPanel(Vlibros)
        btnLibros.BackColor = cambiarColor(colorBlanco)
        btnLibros.ForeColor = cambiarColor(colorVerde)

        btnUsuarios.BackColor = cambiarColor(colorVerde)
        btnUsuarios.ForeColor = cambiarColor(colorBlanco)

        'Cargo los libros desde la base de datos a la tabla de libros'
        miControlador.cargarLibros()
        nuevaTabla()
    End Sub



    Public Function nuevaTabla()
        Dim tablaCreada As Boolean = False
        Dim fila = 0

        Dim nuevosLibros As List(Of CardLibro) = New List(Of CardLibro)()

        For i As Integer = 0 To Controlador.libros.Count - 1
            Dim encontrado = False
            If controlesLibro.Count > 0 Then
                For j As Integer = 0 To controlesLibro.Count - 1
                    If Controlador.libros(i).titulo = controlesLibro(j).Titulo Then
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

        tlpFondo.RowStyles.Add(New RowStyle(SizeType.Absolute, 120.0!))
        Dim YO As Integer = 132

        For i As Integer = 0 To controlesLibro.Count - 1

            controlesLibro(i).Titulo = Controlador.libros(i).titulo
            controlesLibro(i).Autor = Controlador.libros(i).autor
            controlesLibro(i).AutoSize = True
            controlesLibro(i).Dock = DockStyle.Fill
            controlesLibro(i).Location = New Point(227, YO)
            controlesLibro(i).MinimumSize = New Size(800, 230)
            controlesLibro(i).Name = Controlador.libros(i).ID 'ID del libro
            controlesLibro(i).Padding = New Padding(9, 8, 9, 8)
            controlesLibro(i).Size = New Size(800, 230)
            controlesLibro(i).TabIndex = fila

            AddHandler controlesLibro(i).eliminarLibro, Sub()
                                                            MsgBox("¿Intentas eliminarme tú?")
                                                        End Sub
            AddHandler controlesLibro(i).visualizarLibro, Sub()
                                                              MsgBox("¿Intentas visualizar este libro tú?")
                                                          End Sub
            AddHandler controlesLibro(i).modificarLibro, Sub()
                                                             MsgBox("¿Intentas modificarme tú?")
                                                         End Sub

            fila += 1 'avanzo con las filas
            YO += 237 'avanzo con las coordenadas en vertical
        Next

        Vlibros.tlpFondo.ResumeLayout(False)
        Vlibros.tlpFondo.PerformLayout()

        Return tablaCreada = True
    End Function

    Private Sub btnUsuarios_Click(sender As Object, e As EventArgs) Handles btnUsuarios.Click
        cambiarPanel(Vusuarios)
        btnUsuarios.BackColor = cambiarColor(colorBlanco)
        btnUsuarios.ForeColor = cambiarColor(colorVerde)

        btnLibros.BackColor = cambiarColor(colorVerde)
        btnLibros.ForeColor = cambiarColor(colorBlanco)
    End Sub
    Function cambiarColor(color)
        Return System.Drawing.Color.FromArgb(CType(CType(color(0), Byte), Integer), CType(CType(color(1), Byte), Integer), CType(CType(color(2), Byte), Integer))
    End Function

    Private Sub PanelPrincipal_Resize(sender As Object, e As EventArgs) Handles PanelPrincipal.Resize
        Vlibros.Width = PanelPrincipal.Width
        Vusuarios.Width = PanelPrincipal.Width
    End Sub

    Private Sub btnCrearLibro_Click(sender As Object, e As EventArgs) Handles btnCrearLibro.Click
        VNuevoLibro.Show()
    End Sub

    Private Sub Biblioteca_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        miControlador.cargarLibros()
    End Sub


End Class