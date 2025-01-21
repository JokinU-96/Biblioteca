Imports System.Windows.Forms
Imports System.Drawing
Imports System.Drawing.Drawing2D
Imports System.IO
Public Class BotonRedondeado
    Inherits Button REM: heredo las propiedades de la claes boton de WF

    REM: Campos
    Private Property borderSize As Integer = 0
    Property borderRadius As Integer = 40
    Private Property borderColor As Color = Color.AliceBlue

    REM: Contructor
    Public Sub New()
        Me.FlatStyle = FlatStyle.Flat
        Me.FlatAppearance.BorderSize = 0
        Me.Size = New Size(150, 40)
        Me.BackColor = Color.MediumSlateBlue
        Me.ForeColor = Color.White
    End Sub

    REM: Metodos
    Private Function GetFigurePath(rectangulo As RectangleF, radio As Integer) As GraphicsPath
        Dim trazado As GraphicsPath = New GraphicsPath
        trazado.StartFigure()
        trazado.AddArc(rectangulo.X, rectangulo.Y, radio, radio, 180, 90)
        trazado.AddArc(rectangulo.Width - radio, rectangulo.Y, radio, radio, 270, 90)
        trazado.AddArc(rectangulo.Width - radio, rectangulo.Height - radio, radio, radio, 0, 90)
        trazado.AddArc(rectangulo.X, rectangulo.Height - radio, radio, radio, 90, 90)
        trazado.CloseFigure()

        Return trazado
    End Function

    Protected Overrides Sub OnPaint(pevent As PaintEventArgs)
        MyBase.OnPaint(pevent)
        pevent.Graphics.SmoothingMode = SmoothingMode.AntiAlias

        Dim rectSurface As RectangleF = New RectangleF(0, 0, Me.Width, Me.Height)
        Dim rectBorder As RectangleF = New RectangleF(1, 1, Me.Width - 0.8, Me.Height - 1)

        If borderRadius > 2 Then
            REM: Boton redondeado.
            Dim pathSurface As GraphicsPath = GetFigurePath(rectSurface, borderRadius)
            Dim pathBorder As GraphicsPath = GetFigurePath(rectBorder, borderRadius - 1.0)
            Dim penSurface As Pen = New Pen(Me.Parent.BackColor, 2)
            Dim penBorder As Pen = New Pen(borderColor, borderSize)
            Try
                penBorder.Alignment = PenAlignment.Inset

                REM: para la superficie del boton.
                Me.Region = New Region(pathSurface)
                pevent.Graphics.DrawPath(penSurface, pathSurface)

                REM: para el borde del boton
                If borderSize >= 1 Then
                    pevent.Graphics.DrawPath(penBorder, pathBorder)
                End If
            Finally
                pathSurface.Dispose()
                pathBorder.Dispose()
                penSurface.Dispose()
                penBorder.Dispose()
            End Try
        Else
            REM: Boton normal.
            REM: Superficie del boton
            Me.Region = New Region(rectSurface)

            REM: Borde del boton
            If borderSize >= 1 Then
                Using penBorder As Pen = New Pen(borderColor, borderSize)
                    penBorder.Alignment = PenAlignment.Inset
                    pevent.Graphics.DrawRectangle(penBorder, 0, 0, Me.Width - 1, Me.Height - 1)
                End Using
            End If
        End If
    End Sub

    Protected Overrides Sub OnHandleCreated(e As EventArgs)
        MyBase.OnHandleCreated(e)
        AddHandler Me.Parent.BackColorChanged, AddressOf Container_BackColorChanged
    End Sub

    Private Sub Container_BackColorChanged(sender As Object, a As EventArgs)
        If Me.DesignMode Then
            Me.Invalidate()
        End If
    End Sub

End Class
