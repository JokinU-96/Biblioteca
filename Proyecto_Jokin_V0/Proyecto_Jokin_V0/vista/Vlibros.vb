Public Class Vlibros
    Dim miControlador As New Controlador
    Dim mostrado As Boolean = False
    Private Sub Vlibros_Activated(sender As Object, e As EventArgs) Handles MyBase.Activated
        mostrado = True
    End Sub

    Private Sub Vlibros_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dgvUsuarios.DataSource = miControlador.cargarDatosUsuarios()

        dgvUsuarios.Columns(1).MinimumWidth = 65
    End Sub

    Function obtenerUsuarioDGV()
        Dim usuario As Usuario
        If dgvUsuarios.SelectedRows.Count > 0 Then
            Dim filaSeleccionada As DataGridViewRow = dgvUsuarios.SelectedRows(0)
            Dim ID As Integer = Convert.ToInt32(filaSeleccionada.Cells("ID").Value)
            For Each u In Controlador.usuarios
                If u.ID = ID Then
                    usuario = u
                End If
            Next
        End If
        Return usuario
    End Function
End Class