<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Vusuarios
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.tlpFondo = New System.Windows.Forms.TableLayoutPanel()
        Me.CardUsuario1 = New BibliotecaDeControles.CardUsuario()
        Me.tlpFondo.SuspendLayout()
        Me.SuspendLayout()
        '
        'tlpFondo
        '
        Me.tlpFondo.BackColor = System.Drawing.Color.Transparent
        Me.tlpFondo.ColumnCount = 2
        Me.tlpFondo.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 300.0!))
        Me.tlpFondo.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.tlpFondo.Controls.Add(Me.CardUsuario1, 1, 0)
        Me.tlpFondo.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tlpFondo.Location = New System.Drawing.Point(0, 0)
        Me.tlpFondo.Name = "tlpFondo"
        Me.tlpFondo.RowCount = 1
        Me.tlpFondo.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tlpFondo.Size = New System.Drawing.Size(1242, 284)
        Me.tlpFondo.TabIndex = 0
        '
        'CardUsuario1
        '
        Me.CardUsuario1.AutoSize = True
        Me.CardUsuario1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.CardUsuario1.id = 10
        Me.CardUsuario1.Location = New System.Drawing.Point(303, 4)
        Me.CardUsuario1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.CardUsuario1.MinimumSize = New System.Drawing.Size(900, 288)
        Me.CardUsuario1.Name = "CardUsuario1"
        Me.CardUsuario1.NombreApellidos = "Jokin Urteaga Bikuña"
        Me.CardUsuario1.Size = New System.Drawing.Size(936, 288)
        Me.CardUsuario1.TabIndex = 0
        Me.CardUsuario1.telefono = "688696557"
        '
        'Vusuarios
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Window
        Me.ClientSize = New System.Drawing.Size(1242, 284)
        Me.Controls.Add(Me.tlpFondo)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Vusuarios"
        Me.Text = "Vusuarios"
        Me.tlpFondo.ResumeLayout(False)
        Me.tlpFondo.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents tlpFondo As TableLayoutPanel
    Friend WithEvents CardUsuario1 As BibliotecaDeControles.CardUsuario
End Class
