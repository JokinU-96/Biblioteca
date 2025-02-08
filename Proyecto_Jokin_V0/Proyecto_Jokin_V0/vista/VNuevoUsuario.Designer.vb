<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class VNuevoUsuario
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
        Me.lblTitulo = New System.Windows.Forms.Label()
        Me.lblAutor = New System.Windows.Forms.Label()
        Me.lblSinopsis = New System.Windows.Forms.Label()
        Me.tbNombre = New System.Windows.Forms.TextBox()
        Me.tbApellido_1 = New System.Windows.Forms.TextBox()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.btnCancelar = New BibliotecaDeControles.BotonRedondeado()
        Me.btnAceptar = New BibliotecaDeControles.BotonRedondeado()
        Me.lblID = New System.Windows.Forms.Label()
        Me.tbApellido_2 = New System.Windows.Forms.TextBox()
        Me.lblEdicion = New System.Windows.Forms.Label()
        Me.tbTelefono = New System.Windows.Forms.TextBox()
        Me.tlpFondo.SuspendLayout()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'tlpFondo
        '
        Me.tlpFondo.BackColor = System.Drawing.SystemColors.Window
        Me.tlpFondo.ColumnCount = 1
        Me.tlpFondo.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tlpFondo.Controls.Add(Me.tbTelefono, 0, 8)
        Me.tlpFondo.Controls.Add(Me.lblTitulo, 0, 1)
        Me.tlpFondo.Controls.Add(Me.lblAutor, 0, 3)
        Me.tlpFondo.Controls.Add(Me.lblEdicion, 0, 5)
        Me.tlpFondo.Controls.Add(Me.lblSinopsis, 0, 7)
        Me.tlpFondo.Controls.Add(Me.tbNombre, 0, 2)
        Me.tlpFondo.Controls.Add(Me.tbApellido_1, 0, 4)
        Me.tlpFondo.Controls.Add(Me.TableLayoutPanel1, 0, 9)
        Me.tlpFondo.Controls.Add(Me.lblID, 0, 0)
        Me.tlpFondo.Controls.Add(Me.tbApellido_2, 0, 6)
        Me.tlpFondo.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tlpFondo.Location = New System.Drawing.Point(0, 0)
        Me.tlpFondo.Name = "tlpFondo"
        Me.tlpFondo.Padding = New System.Windows.Forms.Padding(10)
        Me.tlpFondo.RowCount = 11
        Me.tlpFondo.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.tlpFondo.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tlpFondo.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tlpFondo.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tlpFondo.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tlpFondo.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tlpFondo.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tlpFondo.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tlpFondo.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tlpFondo.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tlpFondo.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.tlpFondo.Size = New System.Drawing.Size(482, 483)
        Me.tlpFondo.TabIndex = 1
        '
        'lblTitulo
        '
        Me.lblTitulo.AutoSize = True
        Me.lblTitulo.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitulo.Location = New System.Drawing.Point(13, 40)
        Me.lblTitulo.Margin = New System.Windows.Forms.Padding(3, 10, 3, 0)
        Me.lblTitulo.Name = "lblTitulo"
        Me.lblTitulo.Size = New System.Drawing.Size(120, 36)
        Me.lblTitulo.TabIndex = 0
        Me.lblTitulo.Text = "Nombre"
        '
        'lblAutor
        '
        Me.lblAutor.AutoSize = True
        Me.lblAutor.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAutor.Location = New System.Drawing.Point(13, 133)
        Me.lblAutor.Margin = New System.Windows.Forms.Padding(3, 10, 3, 0)
        Me.lblAutor.Name = "lblAutor"
        Me.lblAutor.Size = New System.Drawing.Size(218, 36)
        Me.lblAutor.TabIndex = 1
        Me.lblAutor.Text = "Primer Apellido"
        '
        'lblSinopsis
        '
        Me.lblSinopsis.AutoSize = True
        Me.lblSinopsis.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSinopsis.Location = New System.Drawing.Point(13, 319)
        Me.lblSinopsis.Margin = New System.Windows.Forms.Padding(3, 10, 3, 0)
        Me.lblSinopsis.Name = "lblSinopsis"
        Me.lblSinopsis.Size = New System.Drawing.Size(89, 25)
        Me.lblSinopsis.TabIndex = 3
        Me.lblSinopsis.Text = "Teléfono"
        '
        'tbNombre
        '
        Me.tbNombre.BackColor = System.Drawing.Color.White
        Me.tbNombre.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tbNombre.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbNombre.ForeColor = System.Drawing.SystemColors.MenuText
        Me.tbNombre.Location = New System.Drawing.Point(13, 79)
        Me.tbNombre.Name = "tbNombre"
        Me.tbNombre.Size = New System.Drawing.Size(456, 41)
        Me.tbNombre.TabIndex = 4
        '
        'tbApellido_1
        '
        Me.tbApellido_1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tbApellido_1.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbApellido_1.Location = New System.Drawing.Point(13, 172)
        Me.tbApellido_1.Name = "tbApellido_1"
        Me.tbApellido_1.Size = New System.Drawing.Size(456, 41)
        Me.tbApellido_1.TabIndex = 4
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 2
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.btnCancelar, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.btnAceptar, 1, 0)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(13, 394)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 1
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(456, 62)
        Me.TableLayoutPanel1.TabIndex = 6
        '
        'btnCancelar
        '
        Me.btnCancelar.AutoSize = True
        Me.btnCancelar.BackColor = System.Drawing.Color.FromArgb(CType(CType(193, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(52, Byte), Integer))
        Me.btnCancelar.borderRadius = 15
        Me.btnCancelar.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btnCancelar.FlatAppearance.BorderSize = 0
        Me.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCancelar.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancelar.ForeColor = System.Drawing.Color.White
        Me.btnCancelar.Location = New System.Drawing.Point(3, 3)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(222, 56)
        Me.btnCancelar.TabIndex = 0
        Me.btnCancelar.Text = "Cancelar"
        Me.btnCancelar.UseVisualStyleBackColor = False
        '
        'btnAceptar
        '
        Me.btnAceptar.AutoSize = True
        Me.btnAceptar.BackColor = System.Drawing.Color.FromArgb(CType(CType(67, Byte), Integer), CType(CType(114, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.btnAceptar.borderRadius = 15
        Me.btnAceptar.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btnAceptar.FlatAppearance.BorderSize = 0
        Me.btnAceptar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAceptar.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAceptar.ForeColor = System.Drawing.Color.White
        Me.btnAceptar.Location = New System.Drawing.Point(231, 3)
        Me.btnAceptar.Name = "btnAceptar"
        Me.btnAceptar.Size = New System.Drawing.Size(222, 56)
        Me.btnAceptar.TabIndex = 1
        Me.btnAceptar.Text = "Añadir"
        Me.btnAceptar.UseVisualStyleBackColor = False
        '
        'lblID
        '
        Me.lblID.AutoSize = True
        Me.lblID.ForeColor = System.Drawing.Color.Snow
        Me.lblID.Location = New System.Drawing.Point(13, 10)
        Me.lblID.Name = "lblID"
        Me.lblID.Size = New System.Drawing.Size(20, 16)
        Me.lblID.TabIndex = 8
        Me.lblID.Text = "ID"
        '
        'tbApellido_2
        '
        Me.tbApellido_2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tbApellido_2.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbApellido_2.Location = New System.Drawing.Point(13, 265)
        Me.tbApellido_2.Name = "tbApellido_2"
        Me.tbApellido_2.Size = New System.Drawing.Size(456, 41)
        Me.tbApellido_2.TabIndex = 4
        '
        'lblEdicion
        '
        Me.lblEdicion.AutoSize = True
        Me.lblEdicion.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEdicion.Location = New System.Drawing.Point(13, 226)
        Me.lblEdicion.Margin = New System.Windows.Forms.Padding(3, 10, 3, 0)
        Me.lblEdicion.Name = "lblEdicion"
        Me.lblEdicion.Size = New System.Drawing.Size(253, 36)
        Me.lblEdicion.TabIndex = 2
        Me.lblEdicion.Text = "Segundo Apellido"
        '
        'tbTelefono
        '
        Me.tbTelefono.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tbTelefono.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbTelefono.Location = New System.Drawing.Point(13, 347)
        Me.tbTelefono.Name = "tbTelefono"
        Me.tbTelefono.Size = New System.Drawing.Size(456, 41)
        Me.tbTelefono.TabIndex = 9
        '
        'VNuevoUsuario
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(482, 483)
        Me.Controls.Add(Me.tlpFondo)
        Me.MinimumSize = New System.Drawing.Size(500, 530)
        Me.Name = "VNuevoUsuario"
        Me.Text = "Usuario Nuevo"
        Me.tlpFondo.ResumeLayout(False)
        Me.tlpFondo.PerformLayout()
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents tlpFondo As TableLayoutPanel
    Friend WithEvents lblTitulo As Label
    Friend WithEvents lblAutor As Label
    Friend WithEvents lblSinopsis As Label
    Friend WithEvents tbNombre As TextBox
    Friend WithEvents tbApellido_1 As TextBox
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents btnCancelar As BibliotecaDeControles.BotonRedondeado
    Friend WithEvents btnAceptar As BibliotecaDeControles.BotonRedondeado
    Friend WithEvents lblID As Label
    Friend WithEvents tbApellido_2 As TextBox
    Friend WithEvents lblEdicion As Label
    Friend WithEvents tbTelefono As TextBox
End Class
