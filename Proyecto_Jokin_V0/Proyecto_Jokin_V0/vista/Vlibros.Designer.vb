﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
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
        Me.CardLibro1 = New BibliotecaDeControles.CardLibro()
        Me.CardLibro4 = New BibliotecaDeControles.CardLibro()
        Me.CardLibro3 = New BibliotecaDeControles.CardLibro()
        Me.CardLibro2 = New BibliotecaDeControles.CardLibro()
        Me.lblCatalogo = New System.Windows.Forms.Label()
        Me.CardLibro5 = New BibliotecaDeControles.CardLibro()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.tlpFondo.SuspendLayout()
        Me.SuspendLayout()
        '
        'tlpFondo
        '
        Me.tlpFondo.AutoScroll = True
        Me.tlpFondo.AutoSize = True
        Me.tlpFondo.BackColor = System.Drawing.SystemColors.Window
        Me.tlpFondo.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.[Single]
        Me.tlpFondo.ColumnCount = 3
        Me.tlpFondo.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.tlpFondo.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 80.0!))
        Me.tlpFondo.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 46.0!))
        Me.tlpFondo.Controls.Add(Me.CardLibro1, 1, 2)
        Me.tlpFondo.Controls.Add(Me.CardLibro4, 1, 5)
        Me.tlpFondo.Controls.Add(Me.CardLibro3, 1, 4)
        Me.tlpFondo.Controls.Add(Me.CardLibro2, 1, 3)
        Me.tlpFondo.Controls.Add(Me.lblCatalogo, 1, 1)
        Me.tlpFondo.Controls.Add(Me.CardLibro5, 1, 6)
        Me.tlpFondo.Controls.Add(Me.Panel1, 0, 7)
        Me.tlpFondo.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tlpFondo.Location = New System.Drawing.Point(9, 8)
        Me.tlpFondo.Margin = New System.Windows.Forms.Padding(0)
        Me.tlpFondo.Name = "tlpFondo"
        Me.tlpFondo.Padding = New System.Windows.Forms.Padding(10)
        Me.tlpFondo.RowCount = 8
        Me.tlpFondo.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40.0!))
        Me.tlpFondo.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tlpFondo.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tlpFondo.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tlpFondo.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tlpFondo.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tlpFondo.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tlpFondo.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 100.0!))
        Me.tlpFondo.Size = New System.Drawing.Size(1132, 684)
        Me.tlpFondo.TabIndex = 1
        '
        'CardLibro1
        '
        Me.CardLibro1.Autor = "Autor"
        Me.CardLibro1.AutoSize = True
        Me.CardLibro1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.CardLibro1.Location = New System.Drawing.Point(223, 132)
        Me.CardLibro1.MinimumSize = New System.Drawing.Size(800, 230)
        Me.CardLibro1.Name = "CardLibro1"
        Me.CardLibro1.Padding = New System.Windows.Forms.Padding(9, 8, 9, 8)
        Me.CardLibro1.Size = New System.Drawing.Size(826, 230)
        Me.CardLibro1.TabIndex = 0
        Me.CardLibro1.Titulo = "Titulo"
        '
        'CardLibro4
        '
        Me.CardLibro4.Autor = "Autor"
        Me.CardLibro4.AutoSize = True
        Me.CardLibro4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.CardLibro4.Location = New System.Drawing.Point(223, 843)
        Me.CardLibro4.MinimumSize = New System.Drawing.Size(800, 230)
        Me.CardLibro4.Name = "CardLibro4"
        Me.CardLibro4.Size = New System.Drawing.Size(826, 230)
        Me.CardLibro4.TabIndex = 3
        Me.CardLibro4.Titulo = "Titulo"
        '
        'CardLibro3
        '
        Me.CardLibro3.Autor = "Autor"
        Me.CardLibro3.AutoSize = True
        Me.CardLibro3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.CardLibro3.Location = New System.Drawing.Point(223, 606)
        Me.CardLibro3.MinimumSize = New System.Drawing.Size(800, 230)
        Me.CardLibro3.Name = "CardLibro3"
        Me.CardLibro3.Size = New System.Drawing.Size(826, 230)
        Me.CardLibro3.TabIndex = 2
        Me.CardLibro3.Titulo = "Titulo"
        '
        'CardLibro2
        '
        Me.CardLibro2.Autor = "Autor"
        Me.CardLibro2.AutoSize = True
        Me.CardLibro2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.CardLibro2.Location = New System.Drawing.Point(223, 369)
        Me.CardLibro2.MinimumSize = New System.Drawing.Size(800, 230)
        Me.CardLibro2.Name = "CardLibro2"
        Me.CardLibro2.Size = New System.Drawing.Size(826, 230)
        Me.CardLibro2.TabIndex = 1
        Me.CardLibro2.Titulo = "Titulo"
        '
        'lblCatalogo
        '
        Me.lblCatalogo.AutoSize = True
        Me.lblCatalogo.Font = New System.Drawing.Font("Microsoft Sans Serif", 40.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCatalogo.Location = New System.Drawing.Point(223, 52)
        Me.lblCatalogo.Name = "lblCatalogo"
        Me.lblCatalogo.Size = New System.Drawing.Size(298, 76)
        Me.lblCatalogo.TabIndex = 5
        Me.lblCatalogo.Text = "Catálogo"
        '
        'CardLibro5
        '
        Me.CardLibro5.Autor = "Autor"
        Me.CardLibro5.AutoSize = True
        Me.CardLibro5.Dock = System.Windows.Forms.DockStyle.Fill
        Me.CardLibro5.Location = New System.Drawing.Point(223, 1080)
        Me.CardLibro5.MinimumSize = New System.Drawing.Size(800, 230)
        Me.CardLibro5.Name = "CardLibro5"
        Me.CardLibro5.Size = New System.Drawing.Size(826, 230)
        Me.CardLibro5.TabIndex = 4
        Me.CardLibro5.Titulo = "Titulo"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.InfoText
        Me.tlpFondo.SetColumnSpan(Me.Panel1, 3)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(14, 1317)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1083, 94)
        Me.Panel1.TabIndex = 6
        '
        'Vlibros
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Window
        Me.ClientSize = New System.Drawing.Size(1150, 700)
        Me.Controls.Add(Me.tlpFondo)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.MinimumSize = New System.Drawing.Size(1150, 700)
        Me.Name = "Vlibros"
        Me.Padding = New System.Windows.Forms.Padding(9, 8, 9, 8)
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
    Friend WithEvents Panel1 As Panel
End Class
