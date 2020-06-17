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
        Dim Animation1 As BunifuAnimatorNS.Animation = New BunifuAnimatorNS.Animation()
        Dim Animation2 As BunifuAnimatorNS.Animation = New BunifuAnimatorNS.Animation()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MenuTareas))
        Me.panelTop = New System.Windows.Forms.Panel()
        Me.btnMenu = New System.Windows.Forms.PictureBox()
        Me.panelOpciones = New System.Windows.Forms.Panel()
        Me.slideBar = New Bunifu.Framework.UI.BunifuGradientPanel()
        Me.btnSegunda = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.btnPrimera = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.lineaSideBar = New Bunifu.Framework.UI.BunifuSeparator()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.curvaSlideBar = New Bunifu.Framework.UI.BunifuElipse(Me.components)
        Me.animacionSlideBar = New BunifuAnimatorNS.BunifuTransition(Me.components)
        Me.animacionSlidebarBack = New BunifuAnimatorNS.BunifuTransition(Me.components)
        Me.moverForma = New Bunifu.Framework.UI.BunifuDragControl(Me.components)
        Me.panelContenido = New System.Windows.Forms.Panel()
        Me.btnCerrar = New System.Windows.Forms.Button()
        Me.btnMax = New System.Windows.Forms.Button()
        Me.btnMin = New System.Windows.Forms.Button()
        Me.btnRest = New System.Windows.Forms.Button()
        Me.panelTop.SuspendLayout()
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
        Me.animacionSlidebarBack.SetDecoration(Me.panelTop, BunifuAnimatorNS.DecorationType.None)
        Me.animacionSlideBar.SetDecoration(Me.panelTop, BunifuAnimatorNS.DecorationType.None)
        Me.panelTop.Dock = System.Windows.Forms.DockStyle.Top
        Me.panelTop.Location = New System.Drawing.Point(0, 0)
        Me.panelTop.Name = "panelTop"
        Me.panelTop.Size = New System.Drawing.Size(1400, 80)
        Me.panelTop.TabIndex = 0
        '
        'btnMenu
        '
        Me.btnMenu.BackColor = System.Drawing.Color.Transparent
        Me.animacionSlideBar.SetDecoration(Me.btnMenu, BunifuAnimatorNS.DecorationType.None)
        Me.animacionSlidebarBack.SetDecoration(Me.btnMenu, BunifuAnimatorNS.DecorationType.None)
        Me.btnMenu.Image = CType(resources.GetObject("btnMenu.Image"), System.Drawing.Image)
        Me.btnMenu.Location = New System.Drawing.Point(26, 21)
        Me.btnMenu.Name = "btnMenu"
        Me.btnMenu.Size = New System.Drawing.Size(40, 37)
        Me.btnMenu.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.btnMenu.TabIndex = 0
        Me.btnMenu.TabStop = False
        '
        'panelOpciones
        '
        Me.panelOpciones.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.panelOpciones.Controls.Add(Me.slideBar)
        Me.animacionSlidebarBack.SetDecoration(Me.panelOpciones, BunifuAnimatorNS.DecorationType.None)
        Me.animacionSlideBar.SetDecoration(Me.panelOpciones, BunifuAnimatorNS.DecorationType.None)
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
        Me.animacionSlidebarBack.SetDecoration(Me.slideBar, BunifuAnimatorNS.DecorationType.None)
        Me.animacionSlideBar.SetDecoration(Me.slideBar, BunifuAnimatorNS.DecorationType.None)
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
        Me.animacionSlideBar.SetDecoration(Me.btnSegunda, BunifuAnimatorNS.DecorationType.None)
        Me.animacionSlidebarBack.SetDecoration(Me.btnSegunda, BunifuAnimatorNS.DecorationType.None)
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
        Me.animacionSlideBar.SetDecoration(Me.btnPrimera, BunifuAnimatorNS.DecorationType.None)
        Me.animacionSlidebarBack.SetDecoration(Me.btnPrimera, BunifuAnimatorNS.DecorationType.None)
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
        Me.animacionSlidebarBack.SetDecoration(Me.lineaSideBar, BunifuAnimatorNS.DecorationType.None)
        Me.animacionSlideBar.SetDecoration(Me.lineaSideBar, BunifuAnimatorNS.DecorationType.None)
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
        Me.animacionSlideBar.SetDecoration(Me.Label1, BunifuAnimatorNS.DecorationType.None)
        Me.animacionSlidebarBack.SetDecoration(Me.Label1, BunifuAnimatorNS.DecorationType.None)
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
        Me.animacionSlideBar.SetDecoration(Me.PictureBox1, BunifuAnimatorNS.DecorationType.None)
        Me.animacionSlidebarBack.SetDecoration(Me.PictureBox1, BunifuAnimatorNS.DecorationType.None)
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
        'animacionSlideBar
        '
        Me.animacionSlideBar.AnimationType = BunifuAnimatorNS.AnimationType.Scale
        Me.animacionSlideBar.Cursor = Nothing
        Animation1.AnimateOnlyDifferences = True
        Animation1.BlindCoeff = CType(resources.GetObject("Animation1.BlindCoeff"), System.Drawing.PointF)
        Animation1.LeafCoeff = 0!
        Animation1.MaxTime = 1.0!
        Animation1.MinTime = 0!
        Animation1.MosaicCoeff = CType(resources.GetObject("Animation1.MosaicCoeff"), System.Drawing.PointF)
        Animation1.MosaicShift = CType(resources.GetObject("Animation1.MosaicShift"), System.Drawing.PointF)
        Animation1.MosaicSize = 0
        Animation1.Padding = New System.Windows.Forms.Padding(0, 0, 0, 0)
        Animation1.RotateCoeff = 0!
        Animation1.RotateLimit = 0!
        Animation1.ScaleCoeff = CType(resources.GetObject("Animation1.ScaleCoeff"), System.Drawing.PointF)
        Animation1.SlideCoeff = CType(resources.GetObject("Animation1.SlideCoeff"), System.Drawing.PointF)
        Animation1.TimeCoeff = 0!
        Animation1.TransparencyCoeff = 0!
        Me.animacionSlideBar.DefaultAnimation = Animation1
        '
        'animacionSlidebarBack
        '
        Me.animacionSlidebarBack.AnimationType = BunifuAnimatorNS.AnimationType.HorizBlind
        Me.animacionSlidebarBack.Cursor = Nothing
        Animation2.AnimateOnlyDifferences = True
        Animation2.BlindCoeff = CType(resources.GetObject("Animation2.BlindCoeff"), System.Drawing.PointF)
        Animation2.LeafCoeff = 0!
        Animation2.MaxTime = 1.0!
        Animation2.MinTime = 0!
        Animation2.MosaicCoeff = CType(resources.GetObject("Animation2.MosaicCoeff"), System.Drawing.PointF)
        Animation2.MosaicShift = CType(resources.GetObject("Animation2.MosaicShift"), System.Drawing.PointF)
        Animation2.MosaicSize = 0
        Animation2.Padding = New System.Windows.Forms.Padding(0)
        Animation2.RotateCoeff = 0!
        Animation2.RotateLimit = 0!
        Animation2.ScaleCoeff = CType(resources.GetObject("Animation2.ScaleCoeff"), System.Drawing.PointF)
        Animation2.SlideCoeff = CType(resources.GetObject("Animation2.SlideCoeff"), System.Drawing.PointF)
        Animation2.TimeCoeff = 0!
        Animation2.TransparencyCoeff = 0!
        Me.animacionSlidebarBack.DefaultAnimation = Animation2
        '
        'moverForma
        '
        Me.moverForma.Fixed = True
        Me.moverForma.Horizontal = True
        Me.moverForma.TargetControl = Me.panelTop
        Me.moverForma.Vertical = True
        '
        'panelContenido
        '
        Me.panelContenido.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.animacionSlidebarBack.SetDecoration(Me.panelContenido, BunifuAnimatorNS.DecorationType.None)
        Me.animacionSlideBar.SetDecoration(Me.panelContenido, BunifuAnimatorNS.DecorationType.None)
        Me.panelContenido.Dock = System.Windows.Forms.DockStyle.Fill
        Me.panelContenido.Location = New System.Drawing.Point(350, 80)
        Me.panelContenido.Name = "panelContenido"
        Me.panelContenido.Size = New System.Drawing.Size(1050, 820)
        Me.panelContenido.TabIndex = 3
        '
        'btnCerrar
        '
        Me.btnCerrar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnCerrar.BackColor = System.Drawing.Color.Transparent
        Me.btnCerrar.BackgroundImage = CType(resources.GetObject("btnCerrar.BackgroundImage"), System.Drawing.Image)
        Me.btnCerrar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.animacionSlideBar.SetDecoration(Me.btnCerrar, BunifuAnimatorNS.DecorationType.None)
        Me.animacionSlidebarBack.SetDecoration(Me.btnCerrar, BunifuAnimatorNS.DecorationType.None)
        Me.btnCerrar.FlatAppearance.BorderSize = 0
        Me.btnCerrar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver
        Me.btnCerrar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Firebrick
        Me.btnCerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCerrar.Location = New System.Drawing.Point(1337, 16)
        Me.btnCerrar.Name = "btnCerrar"
        Me.btnCerrar.Size = New System.Drawing.Size(45, 42)
        Me.btnCerrar.TabIndex = 1
        Me.btnCerrar.UseVisualStyleBackColor = False
        '
        'btnMax
        '
        Me.btnMax.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnMax.BackColor = System.Drawing.Color.Transparent
        Me.btnMax.BackgroundImage = CType(resources.GetObject("btnMax.BackgroundImage"), System.Drawing.Image)
        Me.btnMax.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.animacionSlideBar.SetDecoration(Me.btnMax, BunifuAnimatorNS.DecorationType.None)
        Me.animacionSlidebarBack.SetDecoration(Me.btnMax, BunifuAnimatorNS.DecorationType.None)
        Me.btnMax.FlatAppearance.BorderSize = 0
        Me.btnMax.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver
        Me.btnMax.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DimGray
        Me.btnMax.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnMax.Location = New System.Drawing.Point(1268, 16)
        Me.btnMax.Name = "btnMax"
        Me.btnMax.Size = New System.Drawing.Size(45, 42)
        Me.btnMax.TabIndex = 2
        Me.btnMax.UseVisualStyleBackColor = False
        '
        'btnMin
        '
        Me.btnMin.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnMin.BackColor = System.Drawing.Color.Transparent
        Me.btnMin.BackgroundImage = CType(resources.GetObject("btnMin.BackgroundImage"), System.Drawing.Image)
        Me.btnMin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.animacionSlideBar.SetDecoration(Me.btnMin, BunifuAnimatorNS.DecorationType.None)
        Me.animacionSlidebarBack.SetDecoration(Me.btnMin, BunifuAnimatorNS.DecorationType.None)
        Me.btnMin.FlatAppearance.BorderSize = 0
        Me.btnMin.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver
        Me.btnMin.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DimGray
        Me.btnMin.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnMin.Location = New System.Drawing.Point(1193, 16)
        Me.btnMin.Name = "btnMin"
        Me.btnMin.Size = New System.Drawing.Size(45, 42)
        Me.btnMin.TabIndex = 3
        Me.btnMin.UseVisualStyleBackColor = False
        '
        'btnRest
        '
        Me.btnRest.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnRest.BackColor = System.Drawing.Color.Transparent
        Me.btnRest.BackgroundImage = CType(resources.GetObject("btnRest.BackgroundImage"), System.Drawing.Image)
        Me.btnRest.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.animacionSlideBar.SetDecoration(Me.btnRest, BunifuAnimatorNS.DecorationType.None)
        Me.animacionSlidebarBack.SetDecoration(Me.btnRest, BunifuAnimatorNS.DecorationType.None)
        Me.btnRest.FlatAppearance.BorderSize = 0
        Me.btnRest.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver
        Me.btnRest.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DimGray
        Me.btnRest.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnRest.Location = New System.Drawing.Point(1268, 16)
        Me.btnRest.Name = "btnRest"
        Me.btnRest.Size = New System.Drawing.Size(45, 42)
        Me.btnRest.TabIndex = 4
        Me.btnRest.UseVisualStyleBackColor = False
        Me.btnRest.Visible = False
        '
        'MenuTareas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1400, 900)
        Me.Controls.Add(Me.panelContenido)
        Me.Controls.Add(Me.panelOpciones)
        Me.Controls.Add(Me.panelTop)
        Me.animacionSlidebarBack.SetDecoration(Me, BunifuAnimatorNS.DecorationType.None)
        Me.animacionSlideBar.SetDecoration(Me, BunifuAnimatorNS.DecorationType.None)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "MenuTareas"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form1"
        Me.panelTop.ResumeLayout(False)
        CType(Me.btnMenu, System.ComponentModel.ISupportInitialize).EndInit()
        Me.panelOpciones.ResumeLayout(False)
        Me.slideBar.ResumeLayout(False)
        Me.slideBar.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents panelTop As Panel
    Friend WithEvents btnMenu As PictureBox
    Friend WithEvents panelOpciones As Panel
    Friend WithEvents slideBar As Bunifu.Framework.UI.BunifuGradientPanel
    Friend WithEvents btnSegunda As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents btnPrimera As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents lineaSideBar As Bunifu.Framework.UI.BunifuSeparator
    Friend WithEvents Label1 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents curvaSlideBar As Bunifu.Framework.UI.BunifuElipse
    Friend WithEvents animacionSlideBar As BunifuAnimatorNS.BunifuTransition
    Friend WithEvents animacionSlidebarBack As BunifuAnimatorNS.BunifuTransition
    Friend WithEvents moverForma As Bunifu.Framework.UI.BunifuDragControl
    Friend WithEvents panelContenido As Panel
    Friend WithEvents btnRest As Button
    Friend WithEvents btnMin As Button
    Friend WithEvents btnMax As Button
    Friend WithEvents btnCerrar As Button
End Class
