<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class CardLibro
    Inherits System.Windows.Forms.UserControl

    'UserControl reemplaza a Dispose para limpiar la lista de componentes.
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
        Me.TableLayoutPanel2 = New System.Windows.Forms.TableLayoutPanel()
        Me.lblEdicion = New System.Windows.Forms.Label()
        Me.lblNombre = New System.Windows.Forms.Label()
        Me.lblAutor = New System.Windows.Forms.Label()
        Me.btnFotoPerfil = New System.Windows.Forms.Button()
        Me.btnPrestar = New BibliotecaDeControles.BotonRedondeado()
        Me.btnModificar = New BibliotecaDeControles.BotonRedondeado()
        Me.btnVisualizar = New BibliotecaDeControles.BotonRedondeado()
        Me.btnEliminar = New BibliotecaDeControles.BotonRedondeado()
        Me.tlpFondo.SuspendLayout()
        Me.TableLayoutPanel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'tlpFondo
        '
        Me.tlpFondo.ColumnCount = 5
        Me.tlpFondo.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.tlpFondo.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.tlpFondo.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.tlpFondo.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.tlpFondo.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.tlpFondo.Controls.Add(Me.TableLayoutPanel2, 2, 0)
        Me.tlpFondo.Controls.Add(Me.btnFotoPerfil, 1, 0)
        Me.tlpFondo.Controls.Add(Me.btnPrestar, 1, 1)
        Me.tlpFondo.Controls.Add(Me.btnModificar, 2, 1)
        Me.tlpFondo.Controls.Add(Me.btnVisualizar, 3, 1)
        Me.tlpFondo.Controls.Add(Me.btnEliminar, 4, 1)
        Me.tlpFondo.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tlpFondo.Location = New System.Drawing.Point(0, 0)
        Me.tlpFondo.Name = "tlpFondo"
        Me.tlpFondo.Padding = New System.Windows.Forms.Padding(20)
        Me.tlpFondo.RowCount = 2
        Me.tlpFondo.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tlpFondo.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tlpFondo.Size = New System.Drawing.Size(770, 265)
        Me.tlpFondo.TabIndex = 1
        '
        'TableLayoutPanel2
        '
        Me.TableLayoutPanel2.ColumnCount = 1
        Me.tlpFondo.SetColumnSpan(Me.TableLayoutPanel2, 3)
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel2.Controls.Add(Me.lblEdicion, 0, 3)
        Me.TableLayoutPanel2.Controls.Add(Me.lblNombre, 0, 1)
        Me.TableLayoutPanel2.Controls.Add(Me.lblAutor, 0, 2)
        Me.TableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel2.Location = New System.Drawing.Point(213, 23)
        Me.TableLayoutPanel2.Name = "TableLayoutPanel2"
        Me.TableLayoutPanel2.RowCount = 5
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel2.Size = New System.Drawing.Size(534, 146)
        Me.TableLayoutPanel2.TabIndex = 1
        '
        'lblEdicion
        '
        Me.lblEdicion.AutoSize = True
        Me.lblEdicion.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.lblEdicion.Location = New System.Drawing.Point(3, 96)
        Me.lblEdicion.Name = "lblEdicion"
        Me.lblEdicion.Size = New System.Drawing.Size(76, 25)
        Me.lblEdicion.TabIndex = 0
        Me.lblEdicion.Text = "Edición"
        '
        'lblNombre
        '
        Me.lblNombre.AutoSize = True
        Me.lblNombre.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNombre.Location = New System.Drawing.Point(3, 24)
        Me.lblNombre.Name = "lblNombre"
        Me.lblNombre.Size = New System.Drawing.Size(89, 36)
        Me.lblNombre.TabIndex = 1
        Me.lblNombre.Text = "Titulo"
        '
        'lblAutor
        '
        Me.lblAutor.AutoSize = True
        Me.lblAutor.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAutor.ForeColor = System.Drawing.SystemColors.ControlDark
        Me.lblAutor.Location = New System.Drawing.Point(3, 60)
        Me.lblAutor.Name = "lblAutor"
        Me.lblAutor.Size = New System.Drawing.Size(88, 36)
        Me.lblAutor.TabIndex = 0
        Me.lblAutor.Text = "Autor"
        '
        'btnFotoPerfil
        '
        Me.btnFotoPerfil.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.btnFotoPerfil.BackColor = System.Drawing.Color.FromArgb(CType(CType(180, Byte), Integer), CType(CType(150, Byte), Integer), CType(CType(73, Byte), Integer))
        Me.btnFotoPerfil.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnFotoPerfil.Location = New System.Drawing.Point(43, 30)
        Me.btnFotoPerfil.Name = "btnFotoPerfil"
        Me.btnFotoPerfil.Size = New System.Drawing.Size(146, 131)
        Me.btnFotoPerfil.TabIndex = 2
        Me.btnFotoPerfil.UseVisualStyleBackColor = False
        '
        'btnPrestar
        '
        Me.btnPrestar.BackColor = System.Drawing.Color.FromArgb(CType(CType(67, Byte), Integer), CType(CType(114, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.btnPrestar.borderRadius = 20
        Me.btnPrestar.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btnPrestar.FlatAppearance.BorderSize = 0
        Me.btnPrestar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnPrestar.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPrestar.ForeColor = System.Drawing.Color.White
        Me.btnPrestar.Location = New System.Drawing.Point(50, 182)
        Me.btnPrestar.Margin = New System.Windows.Forms.Padding(10)
        Me.btnPrestar.Name = "btnPrestar"
        Me.btnPrestar.Size = New System.Drawing.Size(150, 53)
        Me.btnPrestar.TabIndex = 3
        Me.btnPrestar.Text = "PRESTAR"
        Me.btnPrestar.UseVisualStyleBackColor = False
        '
        'btnModificar
        '
        Me.btnModificar.BackColor = System.Drawing.Color.FromArgb(CType(CType(67, Byte), Integer), CType(CType(114, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.btnModificar.borderRadius = 20
        Me.btnModificar.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btnModificar.FlatAppearance.BorderSize = 0
        Me.btnModificar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnModificar.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnModificar.ForeColor = System.Drawing.Color.White
        Me.btnModificar.Location = New System.Drawing.Point(220, 182)
        Me.btnModificar.Margin = New System.Windows.Forms.Padding(10)
        Me.btnModificar.Name = "btnModificar"
        Me.btnModificar.Padding = New System.Windows.Forms.Padding(7)
        Me.btnModificar.Size = New System.Drawing.Size(160, 53)
        Me.btnModificar.TabIndex = 4
        Me.btnModificar.Text = "MODIFICAR"
        Me.btnModificar.UseVisualStyleBackColor = False
        '
        'btnVisualizar
        '
        Me.btnVisualizar.BackColor = System.Drawing.Color.FromArgb(CType(CType(67, Byte), Integer), CType(CType(114, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.btnVisualizar.borderRadius = 20
        Me.btnVisualizar.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btnVisualizar.FlatAppearance.BorderSize = 0
        Me.btnVisualizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnVisualizar.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnVisualizar.ForeColor = System.Drawing.Color.White
        Me.btnVisualizar.Location = New System.Drawing.Point(400, 182)
        Me.btnVisualizar.Margin = New System.Windows.Forms.Padding(10)
        Me.btnVisualizar.Name = "btnVisualizar"
        Me.btnVisualizar.Padding = New System.Windows.Forms.Padding(7)
        Me.btnVisualizar.Size = New System.Drawing.Size(160, 53)
        Me.btnVisualizar.TabIndex = 4
        Me.btnVisualizar.Text = "VISUALIZAR"
        Me.btnVisualizar.UseVisualStyleBackColor = False
        '
        'btnEliminar
        '
        Me.btnEliminar.BackColor = System.Drawing.Color.FromArgb(CType(CType(67, Byte), Integer), CType(CType(114, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.btnEliminar.borderRadius = 20
        Me.btnEliminar.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btnEliminar.FlatAppearance.BorderSize = 0
        Me.btnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnEliminar.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEliminar.ForeColor = System.Drawing.Color.White
        Me.btnEliminar.Location = New System.Drawing.Point(580, 182)
        Me.btnEliminar.Margin = New System.Windows.Forms.Padding(10)
        Me.btnEliminar.Name = "btnEliminar"
        Me.btnEliminar.Padding = New System.Windows.Forms.Padding(7)
        Me.btnEliminar.Size = New System.Drawing.Size(160, 53)
        Me.btnEliminar.TabIndex = 4
        Me.btnEliminar.Text = "ELIMINAR"
        Me.btnEliminar.UseVisualStyleBackColor = False
        '
        'CardLibro
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.tlpFondo)
        Me.MinimumSize = New System.Drawing.Size(770, 230)
        Me.Name = "CardLibro"
        Me.Size = New System.Drawing.Size(770, 265)
        Me.tlpFondo.ResumeLayout(False)
        Me.TableLayoutPanel2.ResumeLayout(False)
        Me.TableLayoutPanel2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents tlpFondo As TableLayoutPanel
    Friend WithEvents TableLayoutPanel2 As TableLayoutPanel
    Friend WithEvents lblEdicion As Label
    Friend WithEvents lblNombre As Label
    Friend WithEvents lblAutor As Label
    Friend WithEvents btnFotoPerfil As Button
    Friend WithEvents btnPrestar As BotonRedondeado
    Friend WithEvents btnModificar As BotonRedondeado
    Friend WithEvents btnVisualizar As BotonRedondeado
    Friend WithEvents btnEliminar As BotonRedondeado
End Class
