<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.panelOpciones = New System.Windows.Forms.Panel()
        Me.panelTareas = New System.Windows.Forms.FlowLayoutPanel()
        Me.panelContenido = New System.Windows.Forms.Panel()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.panelTareas.SuspendLayout()
        Me.SuspendLayout()
        '
        'panelOpciones
        '
        Me.panelOpciones.BackColor = System.Drawing.Color.OrangeRed
        Me.panelOpciones.Dock = System.Windows.Forms.DockStyle.Top
        Me.panelOpciones.Location = New System.Drawing.Point(0, 0)
        Me.panelOpciones.Name = "panelOpciones"
        Me.panelOpciones.Size = New System.Drawing.Size(900, 40)
        Me.panelOpciones.TabIndex = 0
        '
        'panelTareas
        '
        Me.panelTareas.BackColor = System.Drawing.Color.DimGray
        Me.panelTareas.Controls.Add(Me.Panel1)
        Me.panelTareas.Dock = System.Windows.Forms.DockStyle.Left
        Me.panelTareas.Location = New System.Drawing.Point(0, 40)
        Me.panelTareas.Name = "panelTareas"
        Me.panelTareas.Size = New System.Drawing.Size(220, 560)
        Me.panelTareas.TabIndex = 1
        '
        'panelContenido
        '
        Me.panelContenido.BackColor = System.Drawing.Color.DarkGray
        Me.panelContenido.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.panelContenido.Dock = System.Windows.Forms.DockStyle.Fill
        Me.panelContenido.Location = New System.Drawing.Point(220, 40)
        Me.panelContenido.Name = "panelContenido"
        Me.panelContenido.Size = New System.Drawing.Size(680, 560)
        Me.panelContenido.TabIndex = 2
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Panel1.Location = New System.Drawing.Point(3, 3)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(15, 49)
        Me.Panel1.TabIndex = 0
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Window
        Me.ClientSize = New System.Drawing.Size(900, 600)
        Me.Controls.Add(Me.panelContenido)
        Me.Controls.Add(Me.panelTareas)
        Me.Controls.Add(Me.panelOpciones)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form1"
        Me.panelTareas.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents panelOpciones As Panel
    Friend WithEvents panelTareas As FlowLayoutPanel
    Friend WithEvents Panel1 As Panel
    Friend WithEvents panelContenido As Panel
End Class
