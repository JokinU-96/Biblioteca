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
        nuevaTabla(miControlador.cargarLibros())
    End Sub



    Function nuevaTabla()
        tlpFondo = New TableLayoutPanel()

        '
        'tlpFondo
        '

        'Añado el nombre de la tabla.
        'tlpFondo.Name = "tlpFondo"

        'Añado la cantidad de filas (cantidad de libros + encabezado + pie de pagina).
        tlpFondo.RowCount = miControlador.libros.Count

        'Añado la cantidad de columnnas.
        'tlpFondo.ColumnCount = 3

        'Instancio un control de usuario para libros.
        Dim CardLibro = New CardLibro()

        'Añado elementos en las celdas de la tabla.
        tlpFondo.Controls.Add(CardLibro, 1, 2)

        '
        'CardLibro1
        '
        CardLibro.Titulo = "Titulo"
        CardLibro.Autor = "Autor"
        CardLibro.AutoSize = True
        CardLibro.Dock = DockStyle.Fill
        CardLibro.Location = New Point(223, 132)
        CardLibro.MinimumSize = New Size(800, 230)
        CardLibro.Name = 'ID del libro
        CardLibro.Padding = New Padding(9, 8, 9, 8)
        CardLibro.Size = New Size(826, 230)
        CardLibro.TabIndex = 0 'El iterador del For

        'Tengo que crear uno cada vez
        '   tlpFondo.Controls.Add(CardLibro4, 1, 5)
        '   tlpFondo.Controls.Add(Me.CardLibro3, 1, 4)
        '   tlpFondo.Controls.Add(Me.CardLibro2, 1, 3)
        '   tlpFondo.Controls.Add(Me.CardLibro5, 1, 6)

        '   El encabezado.
        'tlpFondo.Controls.Add(lblCatalogo, 1, 1)

        '   El panel final de color negro
        'tlpFondo.Controls.Add(Me.Panel1, 0, 7)

        'Estilo de las filas.
        tlpFondo.RowStyles.Add(New RowStyle(SizeType.Absolute, 40.0!)) '0: Margen superior
        tlpFondo.RowStyles.Add(New RowStyle()) '1
        tlpFondo.RowStyles.Add(New RowStyle()) '2
        tlpFondo.RowStyles.Add(New RowStyle()) '3
        tlpFondo.RowStyles.Add(New RowStyle()) '3
        tlpFondo.RowStyles.Add(New RowStyle()) '4
        tlpFondo.RowStyles.Add(New RowStyle()) '5
        tlpFondo.RowStyles.Add(New RowStyle(SizeType.Absolute, 100.0!)) 'n: Pie de página

        'HEREDADO

        'Estilo de las columnas
        'tlpFondo.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 20.0!))
        'tlpFondo.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 80.0!))
        'tlpFondo.ColumnStyles.Add(New ColumnStyle(SizeType.Absolute, 44.0!))

        'Dimensiones iniciales.
        'tlpFondo.Size = New System.Drawing.Size(1132, 684)

        'Resto de propiedades.
        'tlpFondo.AutoScroll = True
        'tlpFondo.AutoSize = True
        'tlpFondo.BackColor = SystemColors.Window
        'tlpFondo.CellBorderStyle = TableLayoutPanelCellBorderStyle.[Single]
        'tlpFondo.Dock = System.Windows.Forms.DockStyle.Fill
        'tlpFondo.Location = New System.Drawing.Point(9, 8)
        'tlpFondo.Margin = New System.Windows.Forms.Padding(0)
        'tlpFondo.Padding = New System.Windows.Forms.Padding(10)
        'tlpFondo.TabIndex = 1
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