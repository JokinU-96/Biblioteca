<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Vusuario
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
        Me.lblNombre = New System.Windows.Forms.Label()
        Me.lblApellido_1 = New System.Windows.Forms.Label()
        Me.lblApellido_2 = New System.Windows.Forms.Label()
        Me.lblTelefono = New System.Windows.Forms.Label()
        Me.lblNombreDinamico = New System.Windows.Forms.Label()
        Me.lblApellidoDinamico_1 = New System.Windows.Forms.Label()
        Me.lblApellidoDinamico_2 = New System.Windows.Forms.Label()
        Me.lblTelefonoDinamico = New System.Windows.Forms.Label()
        Me.tlpFondo.SuspendLayout()
        Me.SuspendLayout()
        '
        'tlpFondo
        '
        Me.tlpFondo.AutoScroll = True
        Me.tlpFondo.AutoSize = True
        Me.tlpFondo.BackColor = System.Drawing.SystemColors.Window
        Me.tlpFondo.ColumnCount = 1
        Me.tlpFondo.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tlpFondo.Controls.Add(Me.lblNombre, 0, 1)
        Me.tlpFondo.Controls.Add(Me.lblApellido_1, 0, 3)
        Me.tlpFondo.Controls.Add(Me.lblApellido_2, 0, 5)
        Me.tlpFondo.Controls.Add(Me.lblTelefono, 0, 7)
        Me.tlpFondo.Controls.Add(Me.lblNombreDinamico, 0, 2)
        Me.tlpFondo.Controls.Add(Me.lblApellidoDinamico_1, 0, 4)
        Me.tlpFondo.Controls.Add(Me.lblApellidoDinamico_2, 0, 6)
        Me.tlpFondo.Controls.Add(Me.lblTelefonoDinamico, 0, 8)
        Me.tlpFondo.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tlpFondo.Location = New System.Drawing.Point(400, 0)
        Me.tlpFondo.Margin = New System.Windows.Forms.Padding(40, 3, 40, 3)
        Me.tlpFondo.Name = "tlpFondo"
        Me.tlpFondo.Padding = New System.Windows.Forms.Padding(10)
        Me.tlpFondo.RowCount = 10
        Me.tlpFondo.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.tlpFondo.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tlpFondo.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.tlpFondo.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tlpFondo.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15.0!))
        Me.tlpFondo.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tlpFondo.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15.0!))
        Me.tlpFondo.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tlpFondo.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.tlpFondo.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.tlpFondo.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.tlpFondo.Size = New System.Drawing.Size(577, 687)
        Me.tlpFondo.TabIndex = 2
        '
        'lblNombre
        '
        Me.lblNombre.AutoSize = True
        Me.lblNombre.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNombre.ForeColor = System.Drawing.Color.FromArgb(CType(CType(174, Byte), Integer), CType(CType(174, Byte), Integer), CType(CType(178, Byte), Integer))
        Me.lblNombre.Location = New System.Drawing.Point(13, 30)
        Me.lblNombre.Name = "lblNombre"
        Me.lblNombre.Size = New System.Drawing.Size(120, 36)
        Me.lblNombre.TabIndex = 0
        Me.lblNombre.Text = "Nombre"
        '
        'lblApellido_1
        '
        Me.lblApellido_1.AutoSize = True
        Me.lblApellido_1.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblApellido_1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(174, Byte), Integer), CType(CType(174, Byte), Integer), CType(CType(178, Byte), Integer))
        Me.lblApellido_1.Location = New System.Drawing.Point(13, 167)
        Me.lblApellido_1.Name = "lblApellido_1"
        Me.lblApellido_1.Size = New System.Drawing.Size(213, 36)
        Me.lblApellido_1.TabIndex = 1
        Me.lblApellido_1.Text = "Primer apellido"
        '
        'lblApellido_2
        '
        Me.lblApellido_2.AutoSize = True
        Me.lblApellido_2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblApellido_2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(174, Byte), Integer), CType(CType(174, Byte), Integer), CType(CType(178, Byte), Integer))
        Me.lblApellido_2.Location = New System.Drawing.Point(13, 278)
        Me.lblApellido_2.Name = "lblApellido_2"
        Me.lblApellido_2.Size = New System.Drawing.Size(164, 25)
        Me.lblApellido_2.TabIndex = 2
        Me.lblApellido_2.Text = "Segundo apellido"
        '
        'lblTelefono
        '
        Me.lblTelefono.AutoSize = True
        Me.lblTelefono.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTelefono.ForeColor = System.Drawing.Color.FromArgb(CType(CType(174, Byte), Integer), CType(CType(174, Byte), Integer), CType(CType(178, Byte), Integer))
        Me.lblTelefono.Location = New System.Drawing.Point(13, 378)
        Me.lblTelefono.Name = "lblTelefono"
        Me.lblTelefono.Size = New System.Drawing.Size(89, 25)
        Me.lblTelefono.TabIndex = 3
        Me.lblTelefono.Text = "Telefono"
        '
        'lblNombreDinamico
        '
        Me.lblNombreDinamico.AutoSize = True
        Me.lblNombreDinamico.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNombreDinamico.Location = New System.Drawing.Point(13, 66)
        Me.lblNombreDinamico.Name = "lblNombreDinamico"
        Me.lblNombreDinamico.Size = New System.Drawing.Size(403, 36)
        Me.lblNombreDinamico.TabIndex = 7
        Me.lblNombreDinamico.Text = "Algo no va bien, no es broma"
        '
        'lblApellidoDinamico_1
        '
        Me.lblApellidoDinamico_1.AutoSize = True
        Me.lblApellidoDinamico_1.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblApellidoDinamico_1.Location = New System.Drawing.Point(13, 203)
        Me.lblApellidoDinamico_1.Name = "lblApellidoDinamico_1"
        Me.lblApellidoDinamico_1.Size = New System.Drawing.Size(403, 36)
        Me.lblApellidoDinamico_1.TabIndex = 7
        Me.lblApellidoDinamico_1.Text = "Algo no va bien, no es broma"
        '
        'lblApellidoDinamico_2
        '
        Me.lblApellidoDinamico_2.AutoSize = True
        Me.lblApellidoDinamico_2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblApellidoDinamico_2.Location = New System.Drawing.Point(13, 303)
        Me.lblApellidoDinamico_2.Name = "lblApellidoDinamico_2"
        Me.lblApellidoDinamico_2.Size = New System.Drawing.Size(265, 25)
        Me.lblApellidoDinamico_2.TabIndex = 7
        Me.lblApellidoDinamico_2.Text = "Algo no va bien, no es broma"
        '
        'lblTelefonoDinamico
        '
        Me.lblTelefonoDinamico.AutoSize = True
        Me.lblTelefonoDinamico.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTelefonoDinamico.Location = New System.Drawing.Point(13, 403)
        Me.lblTelefonoDinamico.Name = "lblTelefonoDinamico"
        Me.lblTelefonoDinamico.Size = New System.Drawing.Size(265, 25)
        Me.lblTelefonoDinamico.TabIndex = 7
        Me.lblTelefonoDinamico.Text = "Algo no va bien, no es broma"
        '
        'Vusuario
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1017, 687)
        Me.Controls.Add(Me.tlpFondo)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Name = "Vusuario"
        Me.Padding = New System.Windows.Forms.Padding(400, 0, 40, 0)
        Me.Text = "Vusuario"
        Me.tlpFondo.ResumeLayout(False)
        Me.tlpFondo.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents tlpFondo As TableLayoutPanel
    Friend WithEvents lblNombre As Label
    Friend WithEvents lblApellido_1 As Label
    Friend WithEvents lblApellido_2 As Label
    Friend WithEvents lblTelefono As Label
    Friend WithEvents lblNombreDinamico As Label
    Friend WithEvents lblApellidoDinamico_1 As Label
    Friend WithEvents lblApellidoDinamico_2 As Label
    Friend WithEvents lblTelefonoDinamico As Label
End Class
