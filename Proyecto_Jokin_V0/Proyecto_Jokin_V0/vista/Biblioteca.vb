Imports System.Security.Cryptography.X509Certificates

Public Class Biblioteca
    Dim c = 0
    Dim colorVerde = New Integer() {67, 114, 94}
    Dim colorBlanco = New Integer() {255, 255, 255}
    Dim colorNegro = New Integer() {0, 0, 0}
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
    End Sub

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
End Class