Imports System.Data.SQLite
Imports System.Security.Cryptography.X509Certificates
Imports BibliotecaDeControles

Public Class Biblioteca
    Dim mostrado As Boolean = False

    Dim miControlador As New Controlador

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



    Function nuevaTabla()
        Dim fila = 0
        'Añado una fila.
        Vlibros.tlpFondo.RowCount = miControlador.libros.Count + 2

        'Voy creando las filas y los libros uno a uno.
        For Each libro In miControlador.libros

            fila += 1 'cambio a la primera fila (0: encabezado)

            'Añado una fila en el array de filas pero reemplazando antes las que ya están creadas.
            If fila < Vlibros.tlpFondo.RowStyles.Count Then
                Vlibros.tlpFondo.RowStyles(fila) = New RowStyle() 'reemplazo el viejo contenido de la fila por el nuevo.
            Else
                Vlibros.tlpFondo.RowStyles.Add(New RowStyle()) 'cuando no haya RowStyles creadas, añado una.
            End If

            '
            'CardLibro1
            'Creo el cardLibro para asignarlo a la fila anterior
            Dim CardLibro = New CardLibro()
            Vlibros.tlpFondo.Controls.Add(CardLibro, fila, 2) 'Le asigno su fila.
            CardLibro.Titulo = libro.titulo
            CardLibro.Autor = libro.autor
            CardLibro.AutoSize = True
            CardLibro.Dock = DockStyle.Fill
            CardLibro.Location = New Point(223, 132)
            CardLibro.MinimumSize = New Size(800, 230)
            CardLibro.Name = fila 'ID del libro (PENDIENTE)
            CardLibro.Padding = New Padding(9, 8, 9, 8)
            CardLibro.Size = New Size(826, 230)
            CardLibro.TabIndex = fila
        Next

        'El pie de página y el panel final de color negro
        Vlibros.tlpFondo.Controls.Add(Panel1, 0, fila + 1)
        Vlibros.tlpFondo.RowStyles.Add(New RowStyle(SizeType.Absolute, 100.0!)) 'n: Pie de página
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
End Class