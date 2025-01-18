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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(CardLibro))
        Me.Button4 = New System.Windows.Forms.Button()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.btnEditar = New System.Windows.Forms.Button()
        Me.btnMail = New System.Windows.Forms.Button()
        Me.btnPerfil = New System.Windows.Forms.Button()
        Me.TableLayoutPanel2 = New System.Windows.Forms.TableLayoutPanel()
        Me.lblTlfno = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblNombre = New System.Windows.Forms.Label()
        Me.btnFotoPerfil = New System.Windows.Forms.Button()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.TableLayoutPanel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Button4
        '
        Me.Button4.AutoSize = True
        Me.Button4.Dock = System.Windows.Forms.DockStyle.Top
        Me.Button4.Location = New System.Drawing.Point(593, 175)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(193, 26)
        Me.Button4.TabIndex = 0
        Me.Button4.Text = "Dar de Baja"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 5
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
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
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.Padding = New System.Windows.Forms.Padding(20)
        Me.TableLayoutPanel1.RowCount = 2
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(809, 236)
        Me.TableLayoutPanel1.TabIndex = 1
        '
        'btnEditar
        '
        Me.btnEditar.AutoSize = True
        Me.btnEditar.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnEditar.Location = New System.Drawing.Point(43, 175)
        Me.btnEditar.Name = "btnEditar"
        Me.btnEditar.Size = New System.Drawing.Size(146, 26)
        Me.btnEditar.TabIndex = 0
        Me.btnEditar.Text = "Editar"
        Me.btnEditar.UseVisualStyleBackColor = True
        '
        'btnMail
        '
        Me.btnMail.AutoSize = True
        Me.btnMail.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnMail.Location = New System.Drawing.Point(195, 175)
        Me.btnMail.Name = "btnMail"
        Me.btnMail.Size = New System.Drawing.Size(193, 26)
        Me.btnMail.TabIndex = 0
        Me.btnMail.Text = "Enviar correo"
        Me.btnMail.UseVisualStyleBackColor = True
        '
        'btnPerfil
        '
        Me.btnPerfil.AutoSize = True
        Me.btnPerfil.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnPerfil.Location = New System.Drawing.Point(394, 175)
        Me.btnPerfil.Name = "btnPerfil"
        Me.btnPerfil.Size = New System.Drawing.Size(193, 26)
        Me.btnPerfil.TabIndex = 0
        Me.btnPerfil.Text = "Ver Perfil"
        Me.btnPerfil.UseVisualStyleBackColor = True
        '
        'TableLayoutPanel2
        '
        Me.TableLayoutPanel2.ColumnCount = 1
        Me.TableLayoutPanel1.SetColumnSpan(Me.TableLayoutPanel2, 3)
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel2.Controls.Add(Me.lblTlfno, 0, 3)
        Me.TableLayoutPanel2.Controls.Add(Me.lblNombre, 0, 1)
        Me.TableLayoutPanel2.Controls.Add(Me.Label1, 0, 2)
        Me.TableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel2.Location = New System.Drawing.Point(195, 23)
        Me.TableLayoutPanel2.Name = "TableLayoutPanel2"
        Me.TableLayoutPanel2.RowCount = 5
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel2.Size = New System.Drawing.Size(591, 146)
        Me.TableLayoutPanel2.TabIndex = 1
        '
        'lblTlfno
        '
        Me.lblTlfno.AutoSize = True
        Me.lblTlfno.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.lblTlfno.Location = New System.Drawing.Point(3, 96)
        Me.lblTlfno.Name = "lblTlfno"
        Me.lblTlfno.Size = New System.Drawing.Size(89, 25)
        Me.lblTlfno.TabIndex = 0
        Me.lblTlfno.Text = "Teléfono"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ControlDark
        Me.Label1.Location = New System.Drawing.Point(3, 60)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(115, 36)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Edición"
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
        'btnFotoPerfil
        '
        Me.btnFotoPerfil.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.btnFotoPerfil.BackgroundImage = CType(resources.GetObject("btnFotoPerfil.BackgroundImage"), System.Drawing.Image)
        Me.btnFotoPerfil.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnFotoPerfil.Location = New System.Drawing.Point(43, 23)
        Me.btnFotoPerfil.Name = "btnFotoPerfil"
        Me.btnFotoPerfil.Size = New System.Drawing.Size(146, 146)
        Me.btnFotoPerfil.TabIndex = 2
        Me.btnFotoPerfil.UseVisualStyleBackColor = True
        '
        'CardLibro
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Name = "CardLibro"
        Me.Size = New System.Drawing.Size(809, 236)
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
    Friend WithEvents lblTlfno As Label
    Friend WithEvents lblNombre As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents btnFotoPerfil As Button
End Class
