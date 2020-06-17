<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MenuTareas
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MenuTareas))
        Me.panelOpciones = New System.Windows.Forms.Panel()
        Me.panelTareas = New System.Windows.Forms.FlowLayoutPanel()
        Me.panelContenido = New System.Windows.Forms.Panel()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.btnCerrar = New System.Windows.Forms.Button()
        Me.panelOpciones.SuspendLayout()
        Me.panelContenido.SuspendLayout()
        Me.SuspendLayout()
        '
        'panelOpciones
        '
        Me.panelOpciones.BackColor = System.Drawing.Color.DarkGray
        Me.panelOpciones.Controls.Add(Me.Button1)
        Me.panelOpciones.Controls.Add(Me.Button2)
        Me.panelOpciones.Controls.Add(Me.btnCerrar)
        Me.panelOpciones.Dock = System.Windows.Forms.DockStyle.Top
        Me.panelOpciones.Location = New System.Drawing.Point(0, 0)
        Me.panelOpciones.Name = "panelOpciones"
        Me.panelOpciones.Size = New System.Drawing.Size(800, 40)
        Me.panelOpciones.TabIndex = 0
        '
        'panelTareas
        '
        Me.panelTareas.BackColor = System.Drawing.Color.DarkOrange
        Me.panelTareas.Dock = System.Windows.Forms.DockStyle.Left
        Me.panelTareas.Location = New System.Drawing.Point(0, 40)
        Me.panelTareas.Name = "panelTareas"
        Me.panelTareas.Size = New System.Drawing.Size(200, 410)
        Me.panelTareas.TabIndex = 1
        '
        'panelContenido
        '
        Me.panelContenido.Controls.Add(Me.Button3)
        Me.panelContenido.Dock = System.Windows.Forms.DockStyle.Fill
        Me.panelContenido.Location = New System.Drawing.Point(200, 40)
        Me.panelContenido.Name = "panelContenido"
        Me.panelContenido.Size = New System.Drawing.Size(600, 410)
        Me.panelContenido.TabIndex = 2
        '
        'Button3
        '
        Me.Button3.BackgroundImage = Global.Menu_Tareas.My.Resources.Resources.icons8_restore_window_32
        Me.Button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.Button3.FlatAppearance.BorderSize = 0
        Me.Button3.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightGray
        Me.Button3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray
        Me.Button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button3.Location = New System.Drawing.Point(485, 24)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(50, 35)
        Me.Button3.TabIndex = 2
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.BackgroundImage = Global.Menu_Tareas.My.Resources.Resources.icons8_maximize_window_32
        Me.Button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.Button1.FlatAppearance.BorderSize = 0
        Me.Button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightGray
        Me.Button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Location = New System.Drawing.Point(618, 0)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(50, 35)
        Me.Button1.TabIndex = 2
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.BackgroundImage = Global.Menu_Tareas.My.Resources.Resources.icons8_maximize_window_32
        Me.Button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.Button2.FlatAppearance.BorderSize = 0
        Me.Button2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightGray
        Me.Button2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.Location = New System.Drawing.Point(685, 0)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(50, 35)
        Me.Button2.TabIndex = 1
        Me.Button2.UseVisualStyleBackColor = True
        '
        'btnCerrar
        '
        Me.btnCerrar.BackgroundImage = Global.Menu_Tareas.My.Resources.Resources.icons8_close_window_32
        Me.btnCerrar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnCerrar.FlatAppearance.BorderSize = 0
        Me.btnCerrar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray
        Me.btnCerrar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red
        Me.btnCerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCerrar.Location = New System.Drawing.Point(750, 0)
        Me.btnCerrar.Name = "btnCerrar"
        Me.btnCerrar.Size = New System.Drawing.Size(50, 35)
        Me.btnCerrar.TabIndex = 0
        Me.btnCerrar.UseVisualStyleBackColor = True
        '
        'MenuTareas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.panelContenido)
        Me.Controls.Add(Me.panelTareas)
        Me.Controls.Add(Me.panelOpciones)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "MenuTareas"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form1"
        Me.panelOpciones.ResumeLayout(False)
        Me.panelContenido.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents panelOpciones As Panel
    Friend WithEvents btnCerrar As Button
    Friend WithEvents panelTareas As FlowLayoutPanel
    Friend WithEvents panelContenido As Panel
    Friend WithEvents Button2 As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents Button3 As Button
End Class
