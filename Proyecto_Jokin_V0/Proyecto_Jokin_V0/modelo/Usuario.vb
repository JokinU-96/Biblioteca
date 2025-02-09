Public Class Usuario
    Property nombre As String
    Property apellido_1 As String
    Property apellido_2 As String
    Property telefono As Integer
    Property ID As Integer

    Public Sub New(nombre As String, apellido_1 As String, apellido_2 As String, telefono As Integer, ID As Integer)
        Me.nombre = nombre
        Me.apellido_1 = apellido_1
        Me.apellido_2 = apellido_2
        Me.telefono = telefono
        Me.ID = ID
    End Sub
End Class
