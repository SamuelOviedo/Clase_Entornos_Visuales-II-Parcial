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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MenuTareas))
        Me.panelTop = New System.Windows.Forms.Panel()
        Me.btnRest = New System.Windows.Forms.PictureBox()
        Me.btnMin = New System.Windows.Forms.PictureBox()
        Me.btnMax = New System.Windows.Forms.PictureBox()
        Me.btnCerrar = New System.Windows.Forms.PictureBox()
        Me.btnMenu = New System.Windows.Forms.PictureBox()
        Me.panelContenido = New System.Windows.Forms.Panel()
        Me.panelOpciones = New System.Windows.Forms.Panel()
        Me.slideBar = New Bunifu.Framework.UI.BunifuGradientPanel()
        Me.btnSegunda = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.btnPrimera = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.lineaSideBar = New Bunifu.Framework.UI.BunifuSeparator()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.curvaSlideBar = New Bunifu.Framework.UI.BunifuElipse(Me.components)
        Me.panelTop.SuspendLayout()
        CType(Me.btnRest, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnMin, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnMax, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnCerrar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnMenu, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.panelOpciones.SuspendLayout()
        Me.slideBar.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'panelTop
        '
        Me.panelTop.BackColor = System.Drawing.Color.FromArgb(CType(CType(117, Byte), Integer), CType(CType(35, Byte), Integer), CType(CType(6, Byte), Integer))
        Me.panelTop.Controls.Add(Me.btnRest)
        Me.panelTop.Controls.Add(Me.btnMin)
        Me.panelTop.Controls.Add(Me.btnMax)
        Me.panelTop.Controls.Add(Me.btnCerrar)
        Me.panelTop.Controls.Add(Me.btnMenu)
        Me.panelTop.Dock = System.Windows.Forms.DockStyle.Top
        Me.panelTop.Location = New System.Drawing.Point(0, 0)
        Me.panelTop.Name = "panelTop"
        Me.panelTop.Size = New System.Drawing.Size(1400, 80)
        Me.panelTop.TabIndex = 0
        '
        'btnRest
        '
        Me.btnRest.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnRest.BackColor = System.Drawing.Color.Transparent
        Me.btnRest.Image = CType(resources.GetObject("btnRest.Image"), System.Drawing.Image)
        Me.btnRest.Location = New System.Drawing.Point(1268, 21)
        Me.btnRest.Name = "btnRest"
        Me.btnRest.Size = New System.Drawing.Size(40, 37)
        Me.btnRest.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.btnRest.TabIndex = 3
        Me.btnRest.TabStop = False
        Me.btnRest.Visible = False
        '
        'btnMin
        '
        Me.btnMin.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnMin.BackColor = System.Drawing.Color.Transparent
        Me.btnMin.Image = CType(resources.GetObject("btnMin.Image"), System.Drawing.Image)
        Me.btnMin.Location = New System.Drawing.Point(1191, 21)
        Me.btnMin.Name = "btnMin"
        Me.btnMin.Size = New System.Drawing.Size(40, 37)
        Me.btnMin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.btnMin.TabIndex = 3
        Me.btnMin.TabStop = False
        '
        'btnMax
        '
        Me.btnMax.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnMax.BackColor = System.Drawing.Color.Transparent
        Me.btnMax.Image = CType(resources.GetObject("btnMax.Image"), System.Drawing.Image)
        Me.btnMax.Location = New System.Drawing.Point(1268, 21)
        Me.btnMax.Name = "btnMax"
        Me.btnMax.Size = New System.Drawing.Size(40, 37)
        Me.btnMax.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.btnMax.TabIndex = 2
        Me.btnMax.TabStop = False
        '
        'btnCerrar
        '
        Me.btnCerrar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnCerrar.BackColor = System.Drawing.Color.Transparent
        Me.btnCerrar.Image = CType(resources.GetObject("btnCerrar.Image"), System.Drawing.Image)
        Me.btnCerrar.Location = New System.Drawing.Point(1343, 21)
        Me.btnCerrar.Name = "btnCerrar"
        Me.btnCerrar.Size = New System.Drawing.Size(40, 37)
        Me.btnCerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.btnCerrar.TabIndex = 1
        Me.btnCerrar.TabStop = False
        '
        'btnMenu
        '
        Me.btnMenu.BackColor = System.Drawing.Color.Transparent
        Me.btnMenu.Image = CType(resources.GetObject("btnMenu.Image"), System.Drawing.Image)
        Me.btnMenu.Location = New System.Drawing.Point(26, 21)
        Me.btnMenu.Name = "btnMenu"
        Me.btnMenu.Size = New System.Drawing.Size(40, 37)
        Me.btnMenu.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.btnMenu.TabIndex = 0
        Me.btnMenu.TabStop = False
        '
        'panelContenido
        '
        Me.panelContenido.BackColor = System.Drawing.Color.Silver
        Me.panelContenido.Dock = System.Windows.Forms.DockStyle.Fill
        Me.panelContenido.Location = New System.Drawing.Point(0, 80)
        Me.panelContenido.Name = "panelContenido"
        Me.panelContenido.Size = New System.Drawing.Size(1400, 820)
        Me.panelContenido.TabIndex = 1
        '
        'panelOpciones
        '
        Me.panelOpciones.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.panelOpciones.Controls.Add(Me.slideBar)
        Me.panelOpciones.Dock = System.Windows.Forms.DockStyle.Left
        Me.panelOpciones.Location = New System.Drawing.Point(0, 80)
        Me.panelOpciones.Name = "panelOpciones"
        Me.panelOpciones.Size = New System.Drawing.Size(350, 820)
        Me.panelOpciones.TabIndex = 2
        '
        'slideBar
        '
        Me.slideBar.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.slideBar.BackgroundImage = CType(resources.GetObject("slideBar.BackgroundImage"), System.Drawing.Image)
        Me.slideBar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.slideBar.Controls.Add(Me.btnSegunda)
        Me.slideBar.Controls.Add(Me.btnPrimera)
        Me.slideBar.Controls.Add(Me.lineaSideBar)
        Me.slideBar.Controls.Add(Me.Label1)
        Me.slideBar.Controls.Add(Me.PictureBox1)
        Me.slideBar.GradientBottomLeft = System.Drawing.Color.FromArgb(CType(CType(117, Byte), Integer), CType(CType(35, Byte), Integer), CType(CType(6, Byte), Integer))
        Me.slideBar.GradientBottomRight = System.Drawing.Color.FromArgb(CType(CType(117, Byte), Integer), CType(CType(35, Byte), Integer), CType(CType(6, Byte), Integer))
        Me.slideBar.GradientTopLeft = System.Drawing.Color.Black
        Me.slideBar.GradientTopRight = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.slideBar.Location = New System.Drawing.Point(12, 21)
        Me.slideBar.Name = "slideBar"
        Me.slideBar.Quality = 10
        Me.slideBar.Size = New System.Drawing.Size(310, 787)
        Me.slideBar.TabIndex = 0
        '
        'btnSegunda
        '
        Me.btnSegunda.Activecolor = System.Drawing.Color.Transparent
        Me.btnSegunda.BackColor = System.Drawing.Color.Transparent
        Me.btnSegunda.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnSegunda.BorderRadius = 0
        Me.btnSegunda.ButtonText = "              Segunda tarea"
        Me.btnSegunda.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnSegunda.DisabledColor = System.Drawing.Color.Gray
        Me.btnSegunda.Iconcolor = System.Drawing.Color.Transparent
        Me.btnSegunda.Iconimage = CType(resources.GetObject("btnSegunda.Iconimage"), System.Drawing.Image)
        Me.btnSegunda.Iconimage_right = Nothing
        Me.btnSegunda.Iconimage_right_Selected = Nothing
        Me.btnSegunda.Iconimage_Selected = Nothing
        Me.btnSegunda.IconMarginLeft = 0
        Me.btnSegunda.IconMarginRight = 0
        Me.btnSegunda.IconRightVisible = True
        Me.btnSegunda.IconRightZoom = 0R
        Me.btnSegunda.IconVisible = True
        Me.btnSegunda.IconZoom = 60.0R
        Me.btnSegunda.IsTab = False
        Me.btnSegunda.Location = New System.Drawing.Point(4, 236)
        Me.btnSegunda.Margin = New System.Windows.Forms.Padding(6)
        Me.btnSegunda.Name = "btnSegunda"
        Me.btnSegunda.Normalcolor = System.Drawing.Color.Transparent
        Me.btnSegunda.OnHovercolor = System.Drawing.Color.Transparent
        Me.btnSegunda.OnHoverTextColor = System.Drawing.Color.White
        Me.btnSegunda.selected = False
        Me.btnSegunda.Size = New System.Drawing.Size(255, 64)
        Me.btnSegunda.TabIndex = 3
        Me.btnSegunda.Text = "              Segunda tarea"
        Me.btnSegunda.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnSegunda.Textcolor = System.Drawing.Color.LightGray
        Me.btnSegunda.TextFont = New System.Drawing.Font("Russo One", 10.8!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'btnPrimera
        '
        Me.btnPrimera.Activecolor = System.Drawing.Color.Transparent
        Me.btnPrimera.BackColor = System.Drawing.Color.Transparent
        Me.btnPrimera.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnPrimera.BorderRadius = 0
        Me.btnPrimera.ButtonText = "              Primera tarea"
        Me.btnPrimera.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnPrimera.DisabledColor = System.Drawing.Color.Gray
        Me.btnPrimera.Iconcolor = System.Drawing.Color.Transparent
        Me.btnPrimera.Iconimage = CType(resources.GetObject("btnPrimera.Iconimage"), System.Drawing.Image)
        Me.btnPrimera.Iconimage_right = Nothing
        Me.btnPrimera.Iconimage_right_Selected = Nothing
        Me.btnPrimera.Iconimage_Selected = Nothing
        Me.btnPrimera.IconMarginLeft = 0
        Me.btnPrimera.IconMarginRight = 0
        Me.btnPrimera.IconRightVisible = True
        Me.btnPrimera.IconRightZoom = 0R
        Me.btnPrimera.IconVisible = True
        Me.btnPrimera.IconZoom = 60.0R
        Me.btnPrimera.IsTab = False
        Me.btnPrimera.Location = New System.Drawing.Point(4, 133)
        Me.btnPrimera.Margin = New System.Windows.Forms.Padding(6)
        Me.btnPrimera.Name = "btnPrimera"
        Me.btnPrimera.Normalcolor = System.Drawing.Color.Transparent
        Me.btnPrimera.OnHovercolor = System.Drawing.Color.Transparent
        Me.btnPrimera.OnHoverTextColor = System.Drawing.Color.White
        Me.btnPrimera.selected = False
        Me.btnPrimera.Size = New System.Drawing.Size(255, 64)
        Me.btnPrimera.TabIndex = 2
        Me.btnPrimera.Text = "              Primera tarea"
        Me.btnPrimera.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnPrimera.Textcolor = System.Drawing.Color.LightGray
        Me.btnPrimera.TextFont = New System.Drawing.Font("Russo One", 10.8!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'lineaSideBar
        '
        Me.lineaSideBar.BackColor = System.Drawing.Color.Transparent
        Me.lineaSideBar.LineColor = System.Drawing.Color.FromArgb(CType(CType(105, Byte), Integer), CType(CType(105, Byte), Integer), CType(CType(105, Byte), Integer))
        Me.lineaSideBar.LineThickness = 1
        Me.lineaSideBar.Location = New System.Drawing.Point(14, 98)
        Me.lineaSideBar.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.lineaSideBar.Name = "lineaSideBar"
        Me.lineaSideBar.Size = New System.Drawing.Size(290, 1)
        Me.lineaSideBar.TabIndex = 1
        Me.lineaSideBar.Transparency = 255
        Me.lineaSideBar.Vertical = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Shrikhand", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(72, 36)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(182, 35)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Menu tareas:"
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(14, 24)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(52, 55)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'curvaSlideBar
        '
        Me.curvaSlideBar.ElipseRadius = 7
        Me.curvaSlideBar.TargetControl = Me.slideBar
        '
        'MenuTareas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1400, 900)
        Me.Controls.Add(Me.panelOpciones)
        Me.Controls.Add(Me.panelContenido)
        Me.Controls.Add(Me.panelTop)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "MenuTareas"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form1"
        Me.panelTop.ResumeLayout(False)
        CType(Me.btnRest, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnMin, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnMax, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnCerrar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnMenu, System.ComponentModel.ISupportInitialize).EndInit()
        Me.panelOpciones.ResumeLayout(False)
        Me.slideBar.ResumeLayout(False)
        Me.slideBar.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents panelTop As Panel
    Friend WithEvents btnMenu As PictureBox
    Friend WithEvents panelContenido As Panel
    Friend WithEvents panelOpciones As Panel
    Friend WithEvents btnMin As PictureBox
    Friend WithEvents btnMax As PictureBox
    Friend WithEvents btnCerrar As PictureBox
    Friend WithEvents btnRest As PictureBox
    Friend WithEvents slideBar As Bunifu.Framework.UI.BunifuGradientPanel
    Friend WithEvents btnSegunda As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents btnPrimera As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents lineaSideBar As Bunifu.Framework.UI.BunifuSeparator
    Friend WithEvents Label1 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents curvaSlideBar As Bunifu.Framework.UI.BunifuElipse
End Class
