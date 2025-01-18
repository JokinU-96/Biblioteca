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
        Me.btnEliminar = New System.Windows.Forms.Button()
        Me.tlpFondo = New System.Windows.Forms.TableLayoutPanel()
        Me.btnModificar = New System.Windows.Forms.Button()
        Me.btnVisualizar = New System.Windows.Forms.Button()
        Me.TableLayoutPanel2 = New System.Windows.Forms.TableLayoutPanel()
        Me.lblEdicion = New System.Windows.Forms.Label()
        Me.lblNombre = New System.Windows.Forms.Label()
        Me.lblAutor = New System.Windows.Forms.Label()
        Me.btnFotoPerfil = New System.Windows.Forms.Button()
        Me.tlpFondo.SuspendLayout()
        Me.TableLayoutPanel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnEliminar
        '
        Me.btnEliminar.AutoSize = True
        Me.btnEliminar.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnEliminar.Location = New System.Drawing.Point(659, 219)
        Me.btnEliminar.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnEliminar.Name = "btnEliminar"
        Me.btnEliminar.Size = New System.Drawing.Size(216, 38)
        Me.btnEliminar.TabIndex = 0
        Me.btnEliminar.Text = "Eliminar"
        Me.btnEliminar.UseVisualStyleBackColor = True
        '
        'tlpFondo
        '
        Me.tlpFondo.ColumnCount = 5
        Me.tlpFondo.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 22.0!))
        Me.tlpFondo.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.tlpFondo.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.tlpFondo.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.tlpFondo.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.tlpFondo.Controls.Add(Me.btnModificar, 2, 1)
        Me.tlpFondo.Controls.Add(Me.btnVisualizar, 3, 1)
        Me.tlpFondo.Controls.Add(Me.btnEliminar, 4, 1)
        Me.tlpFondo.Controls.Add(Me.TableLayoutPanel2, 2, 0)
        Me.tlpFondo.Controls.Add(Me.btnFotoPerfil, 1, 0)
        Me.tlpFondo.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tlpFondo.Location = New System.Drawing.Point(0, 0)
        Me.tlpFondo.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.tlpFondo.Name = "tlpFondo"
        Me.tlpFondo.Padding = New System.Windows.Forms.Padding(22, 25, 22, 25)
        Me.tlpFondo.RowCount = 2
        Me.tlpFondo.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tlpFondo.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tlpFondo.Size = New System.Drawing.Size(900, 288)
        Me.tlpFondo.TabIndex = 1
        '
        'btnModificar
        '
        Me.btnModificar.AutoSize = True
        Me.btnModificar.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnModificar.Location = New System.Drawing.Point(217, 219)
        Me.btnModificar.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnModificar.Name = "btnModificar"
        Me.btnModificar.Size = New System.Drawing.Size(215, 38)
        Me.btnModificar.TabIndex = 0
        Me.btnModificar.Text = "Modificar"
        Me.btnModificar.UseVisualStyleBackColor = True
        '
        'btnVisualizar
        '
        Me.btnVisualizar.AutoSize = True
        Me.btnVisualizar.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnVisualizar.Location = New System.Drawing.Point(438, 219)
        Me.btnVisualizar.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnVisualizar.Name = "btnVisualizar"
        Me.btnVisualizar.Size = New System.Drawing.Size(215, 38)
        Me.btnVisualizar.TabIndex = 0
        Me.btnVisualizar.Text = "Visualizar"
        Me.btnVisualizar.UseVisualStyleBackColor = True
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
        Me.TableLayoutPanel2.Location = New System.Drawing.Point(217, 29)
        Me.TableLayoutPanel2.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.TableLayoutPanel2.Name = "TableLayoutPanel2"
        Me.TableLayoutPanel2.RowCount = 5
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel2.Size = New System.Drawing.Size(658, 182)
        Me.TableLayoutPanel2.TabIndex = 1
        '
        'lblEdicion
        '
        Me.lblEdicion.AutoSize = True
        Me.lblEdicion.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.lblEdicion.Location = New System.Drawing.Point(3, 116)
        Me.lblEdicion.Name = "lblEdicion"
        Me.lblEdicion.Size = New System.Drawing.Size(94, 29)
        Me.lblEdicion.TabIndex = 0
        Me.lblEdicion.Text = "Edición"
        '
        'lblNombre
        '
        Me.lblNombre.AutoSize = True
        Me.lblNombre.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNombre.Location = New System.Drawing.Point(3, 36)
        Me.lblNombre.Name = "lblNombre"
        Me.lblNombre.Size = New System.Drawing.Size(105, 40)
        Me.lblNombre.TabIndex = 1
        Me.lblNombre.Text = "Titulo"
        '
        'lblAutor
        '
        Me.lblAutor.AutoSize = True
        Me.lblAutor.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAutor.ForeColor = System.Drawing.SystemColors.ControlDark
        Me.lblAutor.Location = New System.Drawing.Point(3, 76)
        Me.lblAutor.Name = "lblAutor"
        Me.lblAutor.Size = New System.Drawing.Size(103, 40)
        Me.lblAutor.TabIndex = 0
        Me.lblAutor.Text = "Autor"
        '
        'btnFotoPerfil
        '
        Me.btnFotoPerfil.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.btnFotoPerfil.BackColor = System.Drawing.Color.FromArgb(CType(CType(180, Byte), Integer), CType(CType(150, Byte), Integer), CType(CType(73, Byte), Integer))
        Me.btnFotoPerfil.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnFotoPerfil.Location = New System.Drawing.Point(47, 38)
        Me.btnFotoPerfil.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnFotoPerfil.Name = "btnFotoPerfil"
        Me.btnFotoPerfil.Size = New System.Drawing.Size(164, 164)
        Me.btnFotoPerfil.TabIndex = 2
        Me.btnFotoPerfil.UseVisualStyleBackColor = False
        '
        'CardLibro
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.tlpFondo)
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.MinimumSize = New System.Drawing.Size(900, 288)
        Me.Name = "CardLibro"
        Me.Size = New System.Drawing.Size(900, 288)
        Me.tlpFondo.ResumeLayout(False)
        Me.tlpFondo.PerformLayout()
        Me.TableLayoutPanel2.ResumeLayout(False)
        Me.TableLayoutPanel2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btnEliminar As Button
    Friend WithEvents tlpFondo As TableLayoutPanel
    Friend WithEvents btnModificar As Button
    Friend WithEvents btnVisualizar As Button
    Friend WithEvents TableLayoutPanel2 As TableLayoutPanel
    Friend WithEvents lblEdicion As Label
    Friend WithEvents lblNombre As Label
    Friend WithEvents lblAutor As Label
    Friend WithEvents btnFotoPerfil As Button
End Class
