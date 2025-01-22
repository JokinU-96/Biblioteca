<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class CardUsuario
    Inherits System.Windows.Forms.UserControl

    'UserControl1 reemplaza a Dispose para limpiar la lista de componentes.
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(CardUsuario))
        Me.tlpFondo = New System.Windows.Forms.TableLayoutPanel()
        Me.btnModificar = New System.Windows.Forms.Button()
        Me.btnVisualizar = New System.Windows.Forms.Button()
        Me.btnEliminar = New System.Windows.Forms.Button()
        Me.TableLayoutPanel2 = New System.Windows.Forms.TableLayoutPanel()
        Me.lblTlfno = New System.Windows.Forms.Label()
        Me.lblNombre = New System.Windows.Forms.Label()
        Me.lblID = New System.Windows.Forms.Label()
        Me.btnFotoPerfil = New System.Windows.Forms.Button()
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
        Me.tlpFondo.Controls.Add(Me.btnModificar, 2, 1)
        Me.tlpFondo.Controls.Add(Me.btnVisualizar, 3, 1)
        Me.tlpFondo.Controls.Add(Me.btnEliminar, 4, 1)
        Me.tlpFondo.Controls.Add(Me.TableLayoutPanel2, 2, 0)
        Me.tlpFondo.Controls.Add(Me.btnFotoPerfil, 1, 0)
        Me.tlpFondo.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tlpFondo.Location = New System.Drawing.Point(0, 0)
        Me.tlpFondo.Name = "tlpFondo"
        Me.tlpFondo.Padding = New System.Windows.Forms.Padding(20, 20, 20, 20)
        Me.tlpFondo.RowCount = 2
        Me.tlpFondo.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tlpFondo.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tlpFondo.Size = New System.Drawing.Size(800, 230)
        Me.tlpFondo.TabIndex = 0
        '
        'btnModificar
        '
        Me.btnModificar.AutoSize = True
        Me.btnModificar.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnModificar.Location = New System.Drawing.Point(195, 175)
        Me.btnModificar.Name = "btnModificar"
        Me.btnModificar.Size = New System.Drawing.Size(189, 30)
        Me.btnModificar.TabIndex = 0
        Me.btnModificar.Text = "Modificar"
        Me.btnModificar.UseVisualStyleBackColor = True
        '
        'btnVisualizar
        '
        Me.btnVisualizar.AutoSize = True
        Me.btnVisualizar.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnVisualizar.Location = New System.Drawing.Point(390, 175)
        Me.btnVisualizar.Name = "btnVisualizar"
        Me.btnVisualizar.Size = New System.Drawing.Size(189, 30)
        Me.btnVisualizar.TabIndex = 0
        Me.btnVisualizar.Text = "Visualizar"
        Me.btnVisualizar.UseVisualStyleBackColor = True
        '
        'btnEliminar
        '
        Me.btnEliminar.AutoSize = True
        Me.btnEliminar.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnEliminar.Location = New System.Drawing.Point(585, 175)
        Me.btnEliminar.Name = "btnEliminar"
        Me.btnEliminar.Size = New System.Drawing.Size(192, 30)
        Me.btnEliminar.TabIndex = 0
        Me.btnEliminar.Text = "Eliminar"
        Me.btnEliminar.UseVisualStyleBackColor = True
        '
        'TableLayoutPanel2
        '
        Me.TableLayoutPanel2.ColumnCount = 1
        Me.tlpFondo.SetColumnSpan(Me.TableLayoutPanel2, 3)
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel2.Controls.Add(Me.lblTlfno, 0, 3)
        Me.TableLayoutPanel2.Controls.Add(Me.lblNombre, 0, 2)
        Me.TableLayoutPanel2.Controls.Add(Me.lblID, 0, 1)
        Me.TableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel2.Location = New System.Drawing.Point(195, 23)
        Me.TableLayoutPanel2.Name = "TableLayoutPanel2"
        Me.TableLayoutPanel2.RowCount = 5
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel2.Size = New System.Drawing.Size(582, 146)
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
        'lblNombre
        '
        Me.lblNombre.AutoSize = True
        Me.lblNombre.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNombre.Location = New System.Drawing.Point(3, 60)
        Me.lblNombre.Name = "lblNombre"
        Me.lblNombre.Size = New System.Drawing.Size(252, 36)
        Me.lblNombre.TabIndex = 1
        Me.lblNombre.Text = "Nombre Apellidos"
        '
        'lblID
        '
        Me.lblID.AutoSize = True
        Me.lblID.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblID.ForeColor = System.Drawing.SystemColors.ControlDark
        Me.lblID.Location = New System.Drawing.Point(3, 24)
        Me.lblID.Name = "lblID"
        Me.lblID.Size = New System.Drawing.Size(49, 36)
        Me.lblID.TabIndex = 0
        Me.lblID.Text = "10"
        '
        'btnFotoPerfil
        '
        Me.btnFotoPerfil.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.btnFotoPerfil.BackgroundImage = CType(resources.GetObject("btnFotoPerfil.BackgroundImage"), System.Drawing.Image)
        Me.btnFotoPerfil.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnFotoPerfil.Location = New System.Drawing.Point(43, 30)
        Me.btnFotoPerfil.Name = "btnFotoPerfil"
        Me.btnFotoPerfil.Size = New System.Drawing.Size(146, 131)
        Me.btnFotoPerfil.TabIndex = 2
        Me.btnFotoPerfil.UseVisualStyleBackColor = True
        '
        'CardUsuario
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.tlpFondo)
        Me.MinimumSize = New System.Drawing.Size(800, 230)
        Me.Name = "CardUsuario"
        Me.Size = New System.Drawing.Size(800, 230)
        Me.tlpFondo.ResumeLayout(False)
        Me.tlpFondo.PerformLayout()
        Me.TableLayoutPanel2.ResumeLayout(False)
        Me.TableLayoutPanel2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents tlpFondo As TableLayoutPanel
    Friend WithEvents btnModificar As Button
    Friend WithEvents btnVisualizar As Button
    Friend WithEvents btnEliminar As Button
    Friend WithEvents TableLayoutPanel2 As TableLayoutPanel
    Friend WithEvents lblNombre As Label
    Friend WithEvents lblID As Label
    Friend WithEvents lblTlfno As Label
    Friend WithEvents btnFotoPerfil As Button
End Class
