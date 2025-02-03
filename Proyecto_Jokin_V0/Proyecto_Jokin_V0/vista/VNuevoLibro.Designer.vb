<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class VNuevoLibro
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
        Me.lblEdicion = New System.Windows.Forms.Label()
        Me.lblSinopsis = New System.Windows.Forms.Label()
        Me.tbTitulo = New System.Windows.Forms.TextBox()
        Me.tbAutor = New System.Windows.Forms.TextBox()
        Me.tbSinopsis = New System.Windows.Forms.RichTextBox()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.btnCancelar = New BibliotecaDeControles.BotonRedondeado()
        Me.btnAceptar = New BibliotecaDeControles.BotonRedondeado()
        Me.nudEdicion = New System.Windows.Forms.NumericUpDown()
        Me.tlpFondo.SuspendLayout()
        Me.TableLayoutPanel1.SuspendLayout()
        CType(Me.nudEdicion, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'tlpFondo
        '
        Me.tlpFondo.ColumnCount = 1
        Me.tlpFondo.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tlpFondo.Controls.Add(Me.lblTitulo, 0, 1)
        Me.tlpFondo.Controls.Add(Me.lblAutor, 0, 3)
        Me.tlpFondo.Controls.Add(Me.lblEdicion, 0, 5)
        Me.tlpFondo.Controls.Add(Me.lblSinopsis, 0, 7)
        Me.tlpFondo.Controls.Add(Me.tbTitulo, 0, 2)
        Me.tlpFondo.Controls.Add(Me.tbAutor, 0, 4)
        Me.tlpFondo.Controls.Add(Me.tbSinopsis, 0, 8)
        Me.tlpFondo.Controls.Add(Me.TableLayoutPanel1, 0, 9)
        Me.tlpFondo.Controls.Add(Me.nudEdicion, 0, 6)
        Me.tlpFondo.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tlpFondo.Location = New System.Drawing.Point(0, 0)
        Me.tlpFondo.Name = "tlpFondo"
        Me.tlpFondo.Padding = New System.Windows.Forms.Padding(10)
        Me.tlpFondo.RowCount = 11
        Me.tlpFondo.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.tlpFondo.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tlpFondo.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.tlpFondo.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tlpFondo.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15.0!))
        Me.tlpFondo.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tlpFondo.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15.0!))
        Me.tlpFondo.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tlpFondo.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.tlpFondo.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tlpFondo.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.tlpFondo.Size = New System.Drawing.Size(482, 700)
        Me.tlpFondo.TabIndex = 0
        '
        'lblTitulo
        '
        Me.lblTitulo.AutoSize = True
        Me.lblTitulo.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitulo.Location = New System.Drawing.Point(13, 30)
        Me.lblTitulo.Name = "lblTitulo"
        Me.lblTitulo.Size = New System.Drawing.Size(89, 36)
        Me.lblTitulo.TabIndex = 0
        Me.lblTitulo.Text = "Titulo"
        '
        'lblAutor
        '
        Me.lblAutor.AutoSize = True
        Me.lblAutor.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAutor.Location = New System.Drawing.Point(13, 148)
        Me.lblAutor.Name = "lblAutor"
        Me.lblAutor.Size = New System.Drawing.Size(88, 36)
        Me.lblAutor.TabIndex = 1
        Me.lblAutor.Text = "Autor"
        '
        'lblEdicion
        '
        Me.lblEdicion.AutoSize = True
        Me.lblEdicion.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEdicion.Location = New System.Drawing.Point(13, 245)
        Me.lblEdicion.Name = "lblEdicion"
        Me.lblEdicion.Size = New System.Drawing.Size(76, 25)
        Me.lblEdicion.TabIndex = 2
        Me.lblEdicion.Text = "Edición"
        '
        'lblSinopsis
        '
        Me.lblSinopsis.AutoSize = True
        Me.lblSinopsis.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSinopsis.Location = New System.Drawing.Point(13, 331)
        Me.lblSinopsis.Name = "lblSinopsis"
        Me.lblSinopsis.Size = New System.Drawing.Size(87, 25)
        Me.lblSinopsis.TabIndex = 3
        Me.lblSinopsis.Text = "Sinopsis"
        '
        'tbTitulo
        '
        Me.tbTitulo.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tbTitulo.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbTitulo.Location = New System.Drawing.Point(13, 69)
        Me.tbTitulo.Name = "tbTitulo"
        Me.tbTitulo.Size = New System.Drawing.Size(456, 41)
        Me.tbTitulo.TabIndex = 4
        '
        'tbAutor
        '
        Me.tbAutor.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tbAutor.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbAutor.Location = New System.Drawing.Point(13, 187)
        Me.tbAutor.Name = "tbAutor"
        Me.tbAutor.Size = New System.Drawing.Size(456, 41)
        Me.tbAutor.TabIndex = 4
        '
        'tbSinopsis
        '
        Me.tbSinopsis.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tbSinopsis.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbSinopsis.Location = New System.Drawing.Point(13, 359)
        Me.tbSinopsis.Name = "tbSinopsis"
        Me.tbSinopsis.Size = New System.Drawing.Size(456, 200)
        Me.tbSinopsis.TabIndex = 5
        Me.tbSinopsis.Text = ""
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 2
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.btnCancelar, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.btnAceptar, 1, 0)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(13, 565)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 1
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(456, 100)
        Me.TableLayoutPanel1.TabIndex = 6
        '
        'btnCancelar
        '
        Me.btnCancelar.BackColor = System.Drawing.Color.Crimson
        Me.btnCancelar.borderRadius = 10
        Me.btnCancelar.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btnCancelar.FlatAppearance.BorderSize = 0
        Me.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCancelar.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancelar.ForeColor = System.Drawing.Color.White
        Me.btnCancelar.Location = New System.Drawing.Point(3, 3)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(222, 94)
        Me.btnCancelar.TabIndex = 0
        Me.btnCancelar.Text = "Cancelar"
        Me.btnCancelar.UseVisualStyleBackColor = False
        '
        'btnAceptar
        '
        Me.btnAceptar.BackColor = System.Drawing.Color.FromArgb(CType(CType(67, Byte), Integer), CType(CType(114, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.btnAceptar.borderRadius = 10
        Me.btnAceptar.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btnAceptar.FlatAppearance.BorderSize = 0
        Me.btnAceptar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAceptar.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAceptar.ForeColor = System.Drawing.Color.White
        Me.btnAceptar.Location = New System.Drawing.Point(231, 3)
        Me.btnAceptar.Name = "btnAceptar"
        Me.btnAceptar.Size = New System.Drawing.Size(222, 94)
        Me.btnAceptar.TabIndex = 1
        Me.btnAceptar.Text = "Añadir"
        Me.btnAceptar.UseVisualStyleBackColor = False
        '
        'nudEdicion
        '
        Me.nudEdicion.Dock = System.Windows.Forms.DockStyle.Fill
        Me.nudEdicion.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.nudEdicion.Location = New System.Drawing.Point(13, 273)
        Me.nudEdicion.Maximum = New Decimal(New Integer() {2050, 0, 0, 0})
        Me.nudEdicion.Minimum = New Decimal(New Integer() {1000, 0, 0, 0})
        Me.nudEdicion.Name = "nudEdicion"
        Me.nudEdicion.Size = New System.Drawing.Size(456, 30)
        Me.nudEdicion.TabIndex = 7
        Me.nudEdicion.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.nudEdicion.Value = New Decimal(New Integer() {1999, 0, 0, 0})
        '
        'VNuevoLibro
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(482, 700)
        Me.Controls.Add(Me.tlpFondo)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow
        Me.MinimumSize = New System.Drawing.Size(500, 700)
        Me.Name = "VNuevoLibro"
        Me.Text = "Nuevo Libro"
        Me.tlpFondo.ResumeLayout(False)
        Me.tlpFondo.PerformLayout()
        Me.TableLayoutPanel1.ResumeLayout(False)
        CType(Me.nudEdicion, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents tlpFondo As TableLayoutPanel
    Friend WithEvents lblTitulo As Label
    Friend WithEvents lblAutor As Label
    Friend WithEvents lblEdicion As Label
    Friend WithEvents lblSinopsis As Label
    Friend WithEvents tbTitulo As TextBox
    Friend WithEvents tbAutor As TextBox
    Friend WithEvents tbSinopsis As RichTextBox
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents btnCancelar As BibliotecaDeControles.BotonRedondeado
    Friend WithEvents btnAceptar As BibliotecaDeControles.BotonRedondeado
    Friend WithEvents nudEdicion As NumericUpDown
End Class
