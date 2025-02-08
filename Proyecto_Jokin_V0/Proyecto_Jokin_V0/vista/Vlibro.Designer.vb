<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Vlibro
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
        Me.lblTituloDinamico = New System.Windows.Forms.Label()
        Me.lblAutorDinamico = New System.Windows.Forms.Label()
        Me.lblEdicionDinamico = New System.Windows.Forms.Label()
        Me.lblSinopsisDinamico = New System.Windows.Forms.Label()
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
        Me.tlpFondo.Controls.Add(Me.lblTitulo, 0, 1)
        Me.tlpFondo.Controls.Add(Me.lblAutor, 0, 3)
        Me.tlpFondo.Controls.Add(Me.lblEdicion, 0, 5)
        Me.tlpFondo.Controls.Add(Me.lblSinopsis, 0, 7)
        Me.tlpFondo.Controls.Add(Me.lblTituloDinamico, 0, 2)
        Me.tlpFondo.Controls.Add(Me.lblAutorDinamico, 0, 4)
        Me.tlpFondo.Controls.Add(Me.lblEdicionDinamico, 0, 6)
        Me.tlpFondo.Controls.Add(Me.lblSinopsisDinamico, 0, 8)
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
        Me.tlpFondo.Size = New System.Drawing.Size(710, 700)
        Me.tlpFondo.TabIndex = 1
        '
        'lblTitulo
        '
        Me.lblTitulo.AutoSize = True
        Me.lblTitulo.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitulo.ForeColor = System.Drawing.Color.FromArgb(CType(CType(174, Byte), Integer), CType(CType(174, Byte), Integer), CType(CType(178, Byte), Integer))
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
        Me.lblAutor.ForeColor = System.Drawing.Color.FromArgb(CType(CType(174, Byte), Integer), CType(CType(174, Byte), Integer), CType(CType(178, Byte), Integer))
        Me.lblAutor.Location = New System.Drawing.Point(13, 169)
        Me.lblAutor.Name = "lblAutor"
        Me.lblAutor.Size = New System.Drawing.Size(88, 36)
        Me.lblAutor.TabIndex = 1
        Me.lblAutor.Text = "Autor"
        '
        'lblEdicion
        '
        Me.lblEdicion.AutoSize = True
        Me.lblEdicion.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEdicion.ForeColor = System.Drawing.Color.FromArgb(CType(CType(174, Byte), Integer), CType(CType(174, Byte), Integer), CType(CType(178, Byte), Integer))
        Me.lblEdicion.Location = New System.Drawing.Point(13, 282)
        Me.lblEdicion.Name = "lblEdicion"
        Me.lblEdicion.Size = New System.Drawing.Size(76, 25)
        Me.lblEdicion.TabIndex = 2
        Me.lblEdicion.Text = "Edición"
        '
        'lblSinopsis
        '
        Me.lblSinopsis.AutoSize = True
        Me.lblSinopsis.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSinopsis.ForeColor = System.Drawing.Color.FromArgb(CType(CType(174, Byte), Integer), CType(CType(174, Byte), Integer), CType(CType(178, Byte), Integer))
        Me.lblSinopsis.Location = New System.Drawing.Point(13, 384)
        Me.lblSinopsis.Name = "lblSinopsis"
        Me.lblSinopsis.Size = New System.Drawing.Size(87, 25)
        Me.lblSinopsis.TabIndex = 3
        Me.lblSinopsis.Text = "Sinopsis"
        '
        'lblTituloDinamico
        '
        Me.lblTituloDinamico.AutoSize = True
        Me.lblTituloDinamico.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTituloDinamico.Location = New System.Drawing.Point(13, 66)
        Me.lblTituloDinamico.Name = "lblTituloDinamico"
        Me.lblTituloDinamico.Size = New System.Drawing.Size(403, 36)
        Me.lblTituloDinamico.TabIndex = 7
        Me.lblTituloDinamico.Text = "Algo no va bien, no es broma"
        '
        'lblAutorDinamico
        '
        Me.lblAutorDinamico.AutoSize = True
        Me.lblAutorDinamico.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAutorDinamico.Location = New System.Drawing.Point(13, 205)
        Me.lblAutorDinamico.Name = "lblAutorDinamico"
        Me.lblAutorDinamico.Size = New System.Drawing.Size(403, 36)
        Me.lblAutorDinamico.TabIndex = 7
        Me.lblAutorDinamico.Text = "Algo no va bien, no es broma"
        '
        'lblEdicionDinamico
        '
        Me.lblEdicionDinamico.AutoSize = True
        Me.lblEdicionDinamico.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEdicionDinamico.Location = New System.Drawing.Point(13, 307)
        Me.lblEdicionDinamico.Name = "lblEdicionDinamico"
        Me.lblEdicionDinamico.Size = New System.Drawing.Size(265, 25)
        Me.lblEdicionDinamico.TabIndex = 7
        Me.lblEdicionDinamico.Text = "Algo no va bien, no es broma"
        '
        'lblSinopsisDinamico
        '
        Me.lblSinopsisDinamico.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblSinopsisDinamico.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSinopsisDinamico.Location = New System.Drawing.Point(13, 409)
        Me.lblSinopsisDinamico.Name = "lblSinopsisDinamico"
        Me.lblSinopsisDinamico.Size = New System.Drawing.Size(684, 259)
        Me.lblSinopsisDinamico.TabIndex = 7
        Me.lblSinopsisDinamico.Text = "Algo no va bien, no es broma. Intentaremos arreglar el problema cuanto antes."
        '
        'Vlibro
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.AutoSize = True
        Me.ClientSize = New System.Drawing.Size(1150, 700)
        Me.Controls.Add(Me.tlpFondo)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.MinimumSize = New System.Drawing.Size(1150, 700)
        Me.Name = "Vlibro"
        Me.Padding = New System.Windows.Forms.Padding(400, 0, 40, 0)
        Me.Text = "Vlibro"
        Me.tlpFondo.ResumeLayout(False)
        Me.tlpFondo.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents tlpFondo As TableLayoutPanel
    Friend WithEvents lblTitulo As Label
    Friend WithEvents lblAutor As Label
    Friend WithEvents lblEdicion As Label
    Friend WithEvents lblSinopsis As Label
    Friend WithEvents lblTituloDinamico As Label
    Friend WithEvents lblAutorDinamico As Label
    Friend WithEvents lblEdicionDinamico As Label
    Friend WithEvents lblSinopsisDinamico As Label
End Class
