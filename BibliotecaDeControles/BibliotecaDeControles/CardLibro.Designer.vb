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
        Me.Button4 = New System.Windows.Forms.Button()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.btnEditar = New System.Windows.Forms.Button()
        Me.btnMail = New System.Windows.Forms.Button()
        Me.btnPerfil = New System.Windows.Forms.Button()
        Me.TableLayoutPanel2 = New System.Windows.Forms.TableLayoutPanel()
        Me.lblEdicion = New System.Windows.Forms.Label()
        Me.lblNombre = New System.Windows.Forms.Label()
        Me.lblAutor = New System.Windows.Forms.Label()
        Me.btnFotoPerfil = New System.Windows.Forms.Button()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.TableLayoutPanel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Button4
        '
        Me.Button4.AutoSize = True
        Me.Button4.Dock = System.Windows.Forms.DockStyle.Top
        Me.Button4.Location = New System.Drawing.Point(665, 219)
        Me.Button4.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(220, 38)
        Me.Button4.TabIndex = 0
        Me.Button4.Text = "Dar de Baja"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 5
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 22.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.TableLayoutPanel1.Controls.Add(Me.btnEditar, 1, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.btnMail, 2, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.btnPerfil, 3, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.Button4, 4, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.TableLayoutPanel2, 2, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.btnFotoPerfil, 1, 0)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.Padding = New System.Windows.Forms.Padding(22, 25, 22, 25)
        Me.TableLayoutPanel1.RowCount = 2
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(910, 295)
        Me.TableLayoutPanel1.TabIndex = 1
        '
        'btnEditar
        '
        Me.btnEditar.AutoSize = True
        Me.btnEditar.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnEditar.Location = New System.Drawing.Point(47, 219)
        Me.btnEditar.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnEditar.Name = "btnEditar"
        Me.btnEditar.Size = New System.Drawing.Size(164, 38)
        Me.btnEditar.TabIndex = 0
        Me.btnEditar.Text = "Editar"
        Me.btnEditar.UseVisualStyleBackColor = True
        '
        'btnMail
        '
        Me.btnMail.AutoSize = True
        Me.btnMail.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnMail.Location = New System.Drawing.Point(217, 219)
        Me.btnMail.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnMail.Name = "btnMail"
        Me.btnMail.Size = New System.Drawing.Size(218, 38)
        Me.btnMail.TabIndex = 0
        Me.btnMail.Text = "Enviar correo"
        Me.btnMail.UseVisualStyleBackColor = True
        '
        'btnPerfil
        '
        Me.btnPerfil.AutoSize = True
        Me.btnPerfil.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnPerfil.Location = New System.Drawing.Point(441, 219)
        Me.btnPerfil.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnPerfil.Name = "btnPerfil"
        Me.btnPerfil.Size = New System.Drawing.Size(218, 38)
        Me.btnPerfil.TabIndex = 0
        Me.btnPerfil.Text = "Ver Perfil"
        Me.btnPerfil.UseVisualStyleBackColor = True
        '
        'TableLayoutPanel2
        '
        Me.TableLayoutPanel2.ColumnCount = 1
        Me.TableLayoutPanel1.SetColumnSpan(Me.TableLayoutPanel2, 3)
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
        Me.TableLayoutPanel2.Size = New System.Drawing.Size(668, 182)
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
        Me.btnFotoPerfil.Location = New System.Drawing.Point(47, 29)
        Me.btnFotoPerfil.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnFotoPerfil.Name = "btnFotoPerfil"
        Me.btnFotoPerfil.Size = New System.Drawing.Size(164, 182)
        Me.btnFotoPerfil.TabIndex = 2
        Me.btnFotoPerfil.UseVisualStyleBackColor = False
        '
        'CardLibro
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "CardLibro"
        Me.Size = New System.Drawing.Size(910, 295)
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel1.PerformLayout()
        Me.TableLayoutPanel2.ResumeLayout(False)
        Me.TableLayoutPanel2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Button4 As Button
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents btnEditar As Button
    Friend WithEvents btnMail As Button
    Friend WithEvents btnPerfil As Button
    Friend WithEvents TableLayoutPanel2 As TableLayoutPanel
    Friend WithEvents lblEdicion As Label
    Friend WithEvents lblNombre As Label
    Friend WithEvents lblAutor As Label
    Friend WithEvents btnFotoPerfil As Button
End Class
