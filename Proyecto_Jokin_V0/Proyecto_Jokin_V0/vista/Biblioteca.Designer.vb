<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Biblioteca
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
        Dim btnCrearUsuario As BibliotecaDeControles.BotonRedondeado
        Me.tlpFondo = New System.Windows.Forms.TableLayoutPanel()
        Me.PanelPrincipal = New System.Windows.Forms.Panel()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.btnUsuarios = New System.Windows.Forms.Label()
        Me.btnLibros = New System.Windows.Forms.Label()
        Me.TableLayoutPanel2 = New System.Windows.Forms.TableLayoutPanel()
        Me.btnCrearLibro = New BibliotecaDeControles.BotonRedondeado()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.SqLiteCommand1 = New System.Data.SQLite.SQLiteCommand()
        btnCrearUsuario = New BibliotecaDeControles.BotonRedondeado()
        Me.tlpFondo.SuspendLayout()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.TableLayoutPanel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnCrearUsuario
        '
        btnCrearUsuario.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        btnCrearUsuario.AutoSize = True
        btnCrearUsuario.BackColor = System.Drawing.Color.FromArgb(CType(CType(67, Byte), Integer), CType(CType(114, Byte), Integer), CType(CType(94, Byte), Integer))
        btnCrearUsuario.borderRadius = 20
        btnCrearUsuario.FlatAppearance.BorderSize = 0
        btnCrearUsuario.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        btnCrearUsuario.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!)
        btnCrearUsuario.ForeColor = System.Drawing.Color.White
        btnCrearUsuario.Location = New System.Drawing.Point(989, 14)
        btnCrearUsuario.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        btnCrearUsuario.MinimumSize = New System.Drawing.Size(0, 26)
        btnCrearUsuario.Name = "btnCrearUsuario"
        btnCrearUsuario.Padding = New System.Windows.Forms.Padding(6)
        btnCrearUsuario.Size = New System.Drawing.Size(200, 58)
        btnCrearUsuario.TabIndex = 2
        btnCrearUsuario.Text = "Nuevo Usuario"
        btnCrearUsuario.UseVisualStyleBackColor = False
        '
        'tlpFondo
        '
        Me.tlpFondo.AutoSize = True
        Me.tlpFondo.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.tlpFondo.BackColor = System.Drawing.SystemColors.Window
        Me.tlpFondo.ColumnCount = 1
        Me.tlpFondo.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tlpFondo.Controls.Add(Me.PanelPrincipal, 0, 2)
        Me.tlpFondo.Controls.Add(Me.TableLayoutPanel1, 0, 1)
        Me.tlpFondo.Controls.Add(Me.TableLayoutPanel2, 0, 0)
        Me.tlpFondo.Controls.Add(Me.Panel1, 0, 3)
        Me.tlpFondo.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tlpFondo.Location = New System.Drawing.Point(0, 0)
        Me.tlpFondo.Margin = New System.Windows.Forms.Padding(22, 20, 22, 20)
        Me.tlpFondo.Name = "tlpFondo"
        Me.tlpFondo.RowCount = 4
        Me.tlpFondo.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tlpFondo.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tlpFondo.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 700.0!))
        Me.tlpFondo.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 100.0!))
        Me.tlpFondo.Size = New System.Drawing.Size(1282, 1003)
        Me.tlpFondo.TabIndex = 0
        '
        'PanelPrincipal
        '
        Me.PanelPrincipal.AutoSize = True
        Me.PanelPrincipal.BackColor = System.Drawing.SystemColors.Info
        Me.PanelPrincipal.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelPrincipal.Location = New System.Drawing.Point(3, 152)
        Me.PanelPrincipal.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.PanelPrincipal.MinimumSize = New System.Drawing.Size(0, 100)
        Me.PanelPrincipal.Name = "PanelPrincipal"
        Me.PanelPrincipal.Size = New System.Drawing.Size(1276, 696)
        Me.PanelPrincipal.TabIndex = 0
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.AutoSize = True
        Me.TableLayoutPanel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(67, Byte), Integer), CType(CType(114, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.TableLayoutPanel1.ColumnCount = 4
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.btnUsuarios, 3, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.btnLibros, 2, 0)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(3, 92)
        Me.TableLayoutPanel1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.TableLayoutPanel1.MinimumSize = New System.Drawing.Size(0, 56)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.Padding = New System.Windows.Forms.Padding(36, 0, 36, 0)
        Me.TableLayoutPanel1.RowCount = 1
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 56.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 56.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 56.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(1276, 56)
        Me.TableLayoutPanel1.TabIndex = 1
        '
        'btnUsuarios
        '
        Me.btnUsuarios.AutoSize = True
        Me.btnUsuarios.BackColor = System.Drawing.Color.FromArgb(CType(CType(67, Byte), Integer), CType(CType(114, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.btnUsuarios.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btnUsuarios.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!)
        Me.btnUsuarios.ForeColor = System.Drawing.SystemColors.Window
        Me.btnUsuarios.Location = New System.Drawing.Point(942, 0)
        Me.btnUsuarios.Name = "btnUsuarios"
        Me.btnUsuarios.Size = New System.Drawing.Size(295, 56)
        Me.btnUsuarios.TabIndex = 3
        Me.btnUsuarios.Text = "Usuarios"
        Me.btnUsuarios.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnLibros
        '
        Me.btnLibros.AutoSize = True
        Me.btnLibros.BackColor = System.Drawing.Color.FromArgb(CType(CType(67, Byte), Integer), CType(CType(114, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.btnLibros.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btnLibros.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!)
        Me.btnLibros.ForeColor = System.Drawing.SystemColors.Window
        Me.btnLibros.Location = New System.Drawing.Point(641, 0)
        Me.btnLibros.Name = "btnLibros"
        Me.btnLibros.Size = New System.Drawing.Size(295, 56)
        Me.btnLibros.TabIndex = 2
        Me.btnLibros.Text = "Libros"
        Me.btnLibros.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'TableLayoutPanel2
        '
        Me.TableLayoutPanel2.AutoSize = True
        Me.TableLayoutPanel2.BackColor = System.Drawing.SystemColors.Window
        Me.TableLayoutPanel2.ColumnCount = 4
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.TableLayoutPanel2.Controls.Add(Me.btnCrearLibro, 2, 0)
        Me.TableLayoutPanel2.Controls.Add(btnCrearUsuario, 3, 0)
        Me.TableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel2.Location = New System.Drawing.Point(3, 2)
        Me.TableLayoutPanel2.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.TableLayoutPanel2.MinimumSize = New System.Drawing.Size(0, 62)
        Me.TableLayoutPanel2.Name = "TableLayoutPanel2"
        Me.TableLayoutPanel2.Padding = New System.Windows.Forms.Padding(36, 12, 36, 12)
        Me.TableLayoutPanel2.RowCount = 1
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel2.Size = New System.Drawing.Size(1276, 86)
        Me.TableLayoutPanel2.TabIndex = 2
        '
        'btnCrearLibro
        '
        Me.btnCrearLibro.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.btnCrearLibro.AutoSize = True
        Me.btnCrearLibro.BackColor = System.Drawing.Color.FromArgb(CType(CType(67, Byte), Integer), CType(CType(114, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.btnCrearLibro.borderRadius = 20
        Me.btnCrearLibro.FlatAppearance.BorderSize = 0
        Me.btnCrearLibro.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCrearLibro.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!)
        Me.btnCrearLibro.ForeColor = System.Drawing.Color.White
        Me.btnCrearLibro.Location = New System.Drawing.Point(703, 14)
        Me.btnCrearLibro.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnCrearLibro.MinimumSize = New System.Drawing.Size(0, 26)
        Me.btnCrearLibro.Name = "btnCrearLibro"
        Me.btnCrearLibro.Padding = New System.Windows.Forms.Padding(6)
        Me.btnCrearLibro.Size = New System.Drawing.Size(170, 58)
        Me.btnCrearLibro.TabIndex = 3
        Me.btnCrearLibro.Text = "Nuevo Libro"
        Me.btnCrearLibro.UseVisualStyleBackColor = False
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.MenuText
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(3, 852)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1276, 149)
        Me.Panel1.TabIndex = 3
        '
        'SqLiteCommand1
        '
        Me.SqLiteCommand1.CommandText = Nothing
        '
        'Biblioteca
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.PapayaWhip
        Me.ClientSize = New System.Drawing.Size(1282, 1003)
        Me.Controls.Add(Me.tlpFondo)
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.MinimumSize = New System.Drawing.Size(1300, 47)
        Me.Name = "Biblioteca"
        Me.Text = "Biblioteca"
        Me.tlpFondo.ResumeLayout(False)
        Me.tlpFondo.PerformLayout()
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel1.PerformLayout()
        Me.TableLayoutPanel2.ResumeLayout(False)
        Me.TableLayoutPanel2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents tlpFondo As TableLayoutPanel
    Friend WithEvents PanelPrincipal As Panel
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents TableLayoutPanel2 As TableLayoutPanel
    Friend WithEvents SqLiteCommand1 As SQLite.SQLiteCommand
    Friend WithEvents Panel1 As Panel
    Friend WithEvents btnLibros As Label
    Friend WithEvents btnUsuarios As Label
    Friend WithEvents btnCrearLibro As BibliotecaDeControles.BotonRedondeado
End Class
