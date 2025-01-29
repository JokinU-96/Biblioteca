<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Vusuarios
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.tlpFondo = New System.Windows.Forms.TableLayoutPanel()
        Me.lblCatalogo = New System.Windows.Forms.Label()
        Me.CardUsuario1 = New BibliotecaDeControles.CardUsuario()
        Me.CardUsuario2 = New BibliotecaDeControles.CardUsuario()
        Me.CardUsuario3 = New BibliotecaDeControles.CardUsuario()
        Me.CardUsuario4 = New BibliotecaDeControles.CardUsuario()
        Me.CardUsuario5 = New BibliotecaDeControles.CardUsuario()
        Me.tlpFondo.SuspendLayout()
        Me.SuspendLayout()
        '
        'tlpFondo
        '
        Me.tlpFondo.AutoScroll = True
        Me.tlpFondo.AutoSize = True
        Me.tlpFondo.BackColor = System.Drawing.SystemColors.Window
        Me.tlpFondo.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.[Single]
        Me.tlpFondo.ColumnCount = 3
        Me.tlpFondo.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.tlpFondo.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 80.0!))
        Me.tlpFondo.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 42.0!))
        Me.tlpFondo.Controls.Add(Me.lblCatalogo, 1, 1)
        Me.tlpFondo.Controls.Add(Me.CardUsuario1, 1, 2)
        Me.tlpFondo.Controls.Add(Me.CardUsuario2, 1, 3)
        Me.tlpFondo.Controls.Add(Me.CardUsuario3, 1, 4)
        Me.tlpFondo.Controls.Add(Me.CardUsuario4, 1, 5)
        Me.tlpFondo.Controls.Add(Me.CardUsuario5, 1, 6)
        Me.tlpFondo.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tlpFondo.Location = New System.Drawing.Point(0, 0)
        Me.tlpFondo.Margin = New System.Windows.Forms.Padding(0)
        Me.tlpFondo.Name = "tlpFondo"
        Me.tlpFondo.Padding = New System.Windows.Forms.Padding(10)

        Me.tlpFondo.RowCount = 8

        Me.tlpFondo.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40.0!))
        Me.tlpFondo.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tlpFondo.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tlpFondo.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tlpFondo.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tlpFondo.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tlpFondo.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tlpFondo.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 120.0!))
        Me.tlpFondo.Size = New System.Drawing.Size(1150, 700)
        Me.tlpFondo.TabIndex = 2
        '
        'lblCatalogo
        '
        Me.lblCatalogo.AutoSize = True
        Me.lblCatalogo.Font = New System.Drawing.Font("Microsoft Sans Serif", 40.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCatalogo.Location = New System.Drawing.Point(227, 52)
        Me.lblCatalogo.Name = "lblCatalogo"
        Me.lblCatalogo.Size = New System.Drawing.Size(295, 76)
        Me.lblCatalogo.TabIndex = 5
        Me.lblCatalogo.Text = "Usuarios"
        '
        'CardUsuario1
        '
        Me.CardUsuario1.id = 10
        Me.CardUsuario1.Location = New System.Drawing.Point(227, 132)
        Me.CardUsuario1.MinimumSize = New System.Drawing.Size(800, 230)
        Me.CardUsuario1.Name = "CardUsuario1"
        Me.CardUsuario1.NombreApellidos = "Nombre Apellidos"
        Me.CardUsuario1.Size = New System.Drawing.Size(800, 230)
        Me.CardUsuario1.TabIndex = 6
        Me.CardUsuario1.telefono = "Teléfono"
        '
        'CardUsuario2
        '
        Me.CardUsuario2.id = 10
        Me.CardUsuario2.Location = New System.Drawing.Point(227, 369)
        Me.CardUsuario2.MinimumSize = New System.Drawing.Size(800, 230)
        Me.CardUsuario2.Name = "CardUsuario2"
        Me.CardUsuario2.NombreApellidos = "Nombre Apellidos"
        Me.CardUsuario2.Size = New System.Drawing.Size(800, 230)
        Me.CardUsuario2.TabIndex = 7
        Me.CardUsuario2.telefono = "Teléfono"
        '
        'CardUsuario3
        '
        Me.CardUsuario3.id = 10
        Me.CardUsuario3.Location = New System.Drawing.Point(227, 606)
        Me.CardUsuario3.MinimumSize = New System.Drawing.Size(800, 230)
        Me.CardUsuario3.Name = "CardUsuario3"
        Me.CardUsuario3.NombreApellidos = "Nombre Apellidos"
        Me.CardUsuario3.Size = New System.Drawing.Size(800, 230)
        Me.CardUsuario3.TabIndex = 7
        Me.CardUsuario3.telefono = "Teléfono"
        '
        'CardUsuario4
        '
        Me.CardUsuario4.id = 10
        Me.CardUsuario4.Location = New System.Drawing.Point(227, 843)
        Me.CardUsuario4.MinimumSize = New System.Drawing.Size(800, 230)
        Me.CardUsuario4.Name = "CardUsuario4"
        Me.CardUsuario4.NombreApellidos = "Nombre Apellidos"
        Me.CardUsuario4.Size = New System.Drawing.Size(800, 230)
        Me.CardUsuario4.TabIndex = 7
        Me.CardUsuario4.telefono = "Teléfono"
        '
        'CardUsuario5
        '
        Me.CardUsuario5.id = 10
        Me.CardUsuario5.Location = New System.Drawing.Point(227, 1080)
        Me.CardUsuario5.MinimumSize = New System.Drawing.Size(800, 230)
        Me.CardUsuario5.Name = "CardUsuario5"
        Me.CardUsuario5.NombreApellidos = "Nombre Apellidos"
        Me.CardUsuario5.Size = New System.Drawing.Size(800, 230)
        Me.CardUsuario5.TabIndex = 7
        Me.CardUsuario5.telefono = "Teléfono"
        '
        'Vusuarios
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Window
        Me.ClientSize = New System.Drawing.Size(1150, 700)
        Me.Controls.Add(Me.tlpFondo)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.MinimumSize = New System.Drawing.Size(1150, 700)
        Me.Name = "Vusuarios"
        Me.Text = "Vusuarios"
        Me.tlpFondo.ResumeLayout(False)
        Me.tlpFondo.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents tlpFondo As TableLayoutPanel
    Friend WithEvents lblCatalogo As Label
    Friend WithEvents CardUsuario1 As BibliotecaDeControles.CardUsuario
    Friend WithEvents CardUsuario2 As BibliotecaDeControles.CardUsuario
    Friend WithEvents CardUsuario3 As BibliotecaDeControles.CardUsuario
    Friend WithEvents CardUsuario4 As BibliotecaDeControles.CardUsuario
    Friend WithEvents CardUsuario5 As BibliotecaDeControles.CardUsuario
End Class
