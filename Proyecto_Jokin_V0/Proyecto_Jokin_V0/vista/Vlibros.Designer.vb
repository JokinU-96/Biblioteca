<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Vlibros
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
        Me.lblCatalogo = New System.Windows.Forms.Label()
        Me.CardLibro1 = New BibliotecaDeControles.CardLibro()
        Me.CardLibro5 = New BibliotecaDeControles.CardLibro()
        Me.CardLibro4 = New BibliotecaDeControles.CardLibro()
        Me.CardLibro3 = New BibliotecaDeControles.CardLibro()
        Me.CardLibro2 = New BibliotecaDeControles.CardLibro()
        Me.tlpFondo.SuspendLayout()
        Me.SuspendLayout()
        '
        'tlpFondo
        '
        Me.tlpFondo.AutoSize = True
        Me.tlpFondo.BackColor = System.Drawing.SystemColors.Window
        Me.tlpFondo.ColumnCount = 2
        Me.tlpFondo.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 300.0!))
        Me.tlpFondo.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.tlpFondo.Controls.Add(Me.CardLibro1, 1, 2)
        Me.tlpFondo.Controls.Add(Me.CardLibro5, 1, 6)
        Me.tlpFondo.Controls.Add(Me.CardLibro4, 1, 5)
        Me.tlpFondo.Controls.Add(Me.CardLibro3, 1, 4)
        Me.tlpFondo.Controls.Add(Me.CardLibro2, 1, 3)
        Me.tlpFondo.Controls.Add(Me.lblCatalogo, 1, 1)
        Me.tlpFondo.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tlpFondo.Location = New System.Drawing.Point(10, 10)
        Me.tlpFondo.Name = "tlpFondo"
        Me.tlpFondo.RowCount = 8
        Me.tlpFondo.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50.0!))
        Me.tlpFondo.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tlpFondo.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.tlpFondo.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.tlpFondo.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.tlpFondo.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.tlpFondo.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.tlpFondo.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 150.0!))
        Me.tlpFondo.Size = New System.Drawing.Size(1420, 2095)
        Me.tlpFondo.TabIndex = 1
        '
        'lblCatalogo
        '
        Me.lblCatalogo.AutoSize = True
        Me.lblCatalogo.Font = New System.Drawing.Font("Microsoft Sans Serif", 40.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCatalogo.Location = New System.Drawing.Point(303, 50)
        Me.lblCatalogo.Name = "lblCatalogo"
        Me.lblCatalogo.Size = New System.Drawing.Size(356, 91)
        Me.lblCatalogo.TabIndex = 5
        Me.lblCatalogo.Text = "Catálogo"
        '
        'CardLibro1
        '
        Me.CardLibro1.Autor = "Autor"
        Me.CardLibro1.AutoSize = True
        Me.CardLibro1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.CardLibro1.Location = New System.Drawing.Point(303, 145)
        Me.CardLibro1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.CardLibro1.MinimumSize = New System.Drawing.Size(900, 288)
        Me.CardLibro1.Name = "CardLibro1"
        Me.CardLibro1.Padding = New System.Windows.Forms.Padding(10)
        Me.CardLibro1.Size = New System.Drawing.Size(1114, 352)
        Me.CardLibro1.TabIndex = 0
        Me.CardLibro1.Titulo = "Titulo"
        '
        'CardLibro5
        '
        Me.CardLibro5.Autor = "Autor"
        Me.CardLibro5.AutoSize = True
        Me.CardLibro5.Dock = System.Windows.Forms.DockStyle.Fill
        Me.CardLibro5.Location = New System.Drawing.Point(303, 1585)
        Me.CardLibro5.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.CardLibro5.MinimumSize = New System.Drawing.Size(900, 288)
        Me.CardLibro5.Name = "CardLibro5"
        Me.CardLibro5.Size = New System.Drawing.Size(1114, 352)
        Me.CardLibro5.TabIndex = 4
        Me.CardLibro5.Titulo = "Titulo"
        '
        'CardLibro4
        '
        Me.CardLibro4.Autor = "Autor"
        Me.CardLibro4.AutoSize = True
        Me.CardLibro4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.CardLibro4.Location = New System.Drawing.Point(303, 1225)
        Me.CardLibro4.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.CardLibro4.MinimumSize = New System.Drawing.Size(900, 288)
        Me.CardLibro4.Name = "CardLibro4"
        Me.CardLibro4.Size = New System.Drawing.Size(1114, 352)
        Me.CardLibro4.TabIndex = 3
        Me.CardLibro4.Titulo = "Titulo"
        '
        'CardLibro3
        '
        Me.CardLibro3.Autor = "Autor"
        Me.CardLibro3.AutoSize = True
        Me.CardLibro3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.CardLibro3.Location = New System.Drawing.Point(303, 865)
        Me.CardLibro3.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.CardLibro3.MinimumSize = New System.Drawing.Size(900, 288)
        Me.CardLibro3.Name = "CardLibro3"
        Me.CardLibro3.Size = New System.Drawing.Size(1114, 352)
        Me.CardLibro3.TabIndex = 2
        Me.CardLibro3.Titulo = "Titulo"
        '
        'CardLibro2
        '
        Me.CardLibro2.Autor = "Autor"
        Me.CardLibro2.AutoSize = True
        Me.CardLibro2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.CardLibro2.Location = New System.Drawing.Point(303, 505)
        Me.CardLibro2.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.CardLibro2.MinimumSize = New System.Drawing.Size(900, 288)
        Me.CardLibro2.Name = "CardLibro2"
        Me.CardLibro2.Size = New System.Drawing.Size(1114, 352)
        Me.CardLibro2.TabIndex = 1
        Me.CardLibro2.Titulo = "Titulo"
        '
        'Vlibros
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.BackColor = System.Drawing.SystemColors.Window
        Me.ClientSize = New System.Drawing.Size(1440, 2115)
        Me.Controls.Add(Me.tlpFondo)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.MinimumSize = New System.Drawing.Size(1440, 0)
        Me.Name = "Vlibros"
        Me.Padding = New System.Windows.Forms.Padding(10)
        Me.Text = "Vlibros"
        Me.tlpFondo.ResumeLayout(False)
        Me.tlpFondo.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents tlpFondo As TableLayoutPanel
    Friend WithEvents CardLibro1 As BibliotecaDeControles.CardLibro
    Friend WithEvents CardLibro5 As BibliotecaDeControles.CardLibro
    Friend WithEvents CardLibro4 As BibliotecaDeControles.CardLibro
    Friend WithEvents CardLibro3 As BibliotecaDeControles.CardLibro
    Friend WithEvents CardLibro2 As BibliotecaDeControles.CardLibro
    Friend WithEvents lblCatalogo As Label
End Class
