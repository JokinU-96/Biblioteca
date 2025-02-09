Public Class Prestamo

    Property IDusuario As Integer
    Property IDlibro As Integer
    Property fechaIni As Date
    Property fechaFin As Date

    Public Sub New(iDusuario As Integer, iDlibro As Integer, fechaIni As Date, fechaFin As Date)
        Me.IDusuario = iDusuario
        Me.IDlibro = iDlibro
        Me.fechaIni = fechaIni
        Me.fechaFin = fechaFin
    End Sub
End Class
