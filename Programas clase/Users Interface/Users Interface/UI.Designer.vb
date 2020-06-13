<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UI
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(UI))
        Me.PanelSuperior = New System.Windows.Forms.Panel()
        Me.btnRestaurar = New System.Windows.Forms.Button()
        Me.btnCerrar = New System.Windows.Forms.Button()
        Me.btnMaximizar = New System.Windows.Forms.Button()
        Me.btnMinimizar = New System.Windows.Forms.Button()
        Me.PanelMenu = New System.Windows.Forms.Panel()
        Me.PanelContenido = New System.Windows.Forms.Panel()
        Me.btnMenu = New System.Windows.Forms.Button()
        Me.timerOcultarMenu = New System.Windows.Forms.Timer(Me.components)
        Me.timerMostrarMenu = New System.Windows.Forms.Timer(Me.components)
        Me.PanelSuperior.SuspendLayout()
        Me.PanelMenu.SuspendLayout()
        Me.SuspendLayout()
        '
        'PanelSuperior
        '
        Me.PanelSuperior.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.PanelSuperior.Controls.Add(Me.btnRestaurar)
        Me.PanelSuperior.Controls.Add(Me.btnCerrar)
        Me.PanelSuperior.Controls.Add(Me.btnMaximizar)
        Me.PanelSuperior.Controls.Add(Me.btnMinimizar)
        Me.PanelSuperior.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelSuperior.Location = New System.Drawing.Point(0, 0)
        Me.PanelSuperior.Name = "PanelSuperior"
        Me.PanelSuperior.Size = New System.Drawing.Size(973, 50)
        Me.PanelSuperior.TabIndex = 0
        '
        'btnRestaurar
        '
        Me.btnRestaurar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnRestaurar.BackgroundImage = CType(resources.GetObject("btnRestaurar.BackgroundImage"), System.Drawing.Image)
        Me.btnRestaurar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnRestaurar.FlatAppearance.BorderSize = 0
        Me.btnRestaurar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnRestaurar.Location = New System.Drawing.Point(864, 3)
        Me.btnRestaurar.Name = "btnRestaurar"
        Me.btnRestaurar.Size = New System.Drawing.Size(40, 40)
        Me.btnRestaurar.TabIndex = 2
        Me.btnRestaurar.UseVisualStyleBackColor = True
        Me.btnRestaurar.Visible = False
        '
        'btnCerrar
        '
        Me.btnCerrar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnCerrar.BackgroundImage = CType(resources.GetObject("btnCerrar.BackgroundImage"), System.Drawing.Image)
        Me.btnCerrar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnCerrar.FlatAppearance.BorderSize = 0
        Me.btnCerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCerrar.Location = New System.Drawing.Point(921, 3)
        Me.btnCerrar.Name = "btnCerrar"
        Me.btnCerrar.Size = New System.Drawing.Size(40, 40)
        Me.btnCerrar.TabIndex = 0
        Me.btnCerrar.UseVisualStyleBackColor = True
        '
        'btnMaximizar
        '
        Me.btnMaximizar.BackgroundImage = CType(resources.GetObject("btnMaximizar.BackgroundImage"), System.Drawing.Image)
        Me.btnMaximizar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnMaximizar.FlatAppearance.BorderSize = 0
        Me.btnMaximizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnMaximizar.Location = New System.Drawing.Point(864, 3)
        Me.btnMaximizar.Name = "btnMaximizar"
        Me.btnMaximizar.Size = New System.Drawing.Size(40, 40)
        Me.btnMaximizar.TabIndex = 1
        Me.btnMaximizar.UseVisualStyleBackColor = True
        '
        'btnMinimizar
        '
        Me.btnMinimizar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnMinimizar.BackgroundImage = CType(resources.GetObject("btnMinimizar.BackgroundImage"), System.Drawing.Image)
        Me.btnMinimizar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnMinimizar.FlatAppearance.BorderSize = 0
        Me.btnMinimizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnMinimizar.Location = New System.Drawing.Point(798, 4)
        Me.btnMinimizar.Name = "btnMinimizar"
        Me.btnMinimizar.Size = New System.Drawing.Size(40, 40)
        Me.btnMinimizar.TabIndex = 2
        Me.btnMinimizar.UseVisualStyleBackColor = True
        '
        'PanelMenu
        '
        Me.PanelMenu.BackColor = System.Drawing.Color.Silver
        Me.PanelMenu.Controls.Add(Me.btnMenu)
        Me.PanelMenu.Dock = System.Windows.Forms.DockStyle.Left
        Me.PanelMenu.Location = New System.Drawing.Point(0, 50)
        Me.PanelMenu.Name = "PanelMenu"
        Me.PanelMenu.Size = New System.Drawing.Size(232, 554)
        Me.PanelMenu.TabIndex = 1
        '
        'PanelContenido
        '
        Me.PanelContenido.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelContenido.Location = New System.Drawing.Point(232, 50)
        Me.PanelContenido.Name = "PanelContenido"
        Me.PanelContenido.Size = New System.Drawing.Size(741, 554)
        Me.PanelContenido.TabIndex = 2
        '
        'btnMenu
        '
        Me.btnMenu.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.btnMenu.BackgroundImage = CType(resources.GetObject("btnMenu.BackgroundImage"), System.Drawing.Image)
        Me.btnMenu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnMenu.FlatAppearance.BorderSize = 0
        Me.btnMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnMenu.Location = New System.Drawing.Point(167, 15)
        Me.btnMenu.Name = "btnMenu"
        Me.btnMenu.Size = New System.Drawing.Size(50, 50)
        Me.btnMenu.TabIndex = 3
        Me.btnMenu.UseVisualStyleBackColor = True
        '
        'timerOcultarMenu
        '
        '
        'timerMostrarMenu
        '
        '
        'UI
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(973, 604)
        Me.Controls.Add(Me.PanelContenido)
        Me.Controls.Add(Me.PanelMenu)
        Me.Controls.Add(Me.PanelSuperior)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "UI"
        Me.Text = "Form1"
        Me.PanelSuperior.ResumeLayout(False)
        Me.PanelMenu.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents PanelSuperior As Panel
    Friend WithEvents btnRestaurar As Button
    Friend WithEvents btnCerrar As Button
    Friend WithEvents btnMaximizar As Button
    Friend WithEvents btnMinimizar As Button
    Friend WithEvents PanelMenu As Panel
    Friend WithEvents PanelContenido As Panel
    Friend WithEvents btnMenu As Button
    Friend WithEvents timerOcultarMenu As Timer
    Friend WithEvents timerMostrarMenu As Timer
End Class
