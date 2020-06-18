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
        Dim Animation15 As BunifuAnimatorNS.Animation = New BunifuAnimatorNS.Animation()
        Dim Animation16 As BunifuAnimatorNS.Animation = New BunifuAnimatorNS.Animation()
        Me.panelTop = New System.Windows.Forms.Panel()
        Me.btnRest = New System.Windows.Forms.Button()
        Me.btnMin = New System.Windows.Forms.Button()
        Me.btnMax = New System.Windows.Forms.Button()
        Me.btnCerrar = New System.Windows.Forms.Button()
        Me.btnMenu = New System.Windows.Forms.PictureBox()
        Me.panelOpciones = New System.Windows.Forms.Panel()
        Me.slideBar = New Bunifu.Framework.UI.BunifuGradientPanel()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button8 = New System.Windows.Forms.Button()
        Me.Button7 = New System.Windows.Forms.Button()
        Me.btnArreglos = New System.Windows.Forms.Button()
        Me.BunifuGradientPanel1 = New Bunifu.Framework.UI.BunifuGradientPanel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lineaSideBar = New Bunifu.Framework.UI.BunifuSeparator()
        Me.curvaSlideBar = New Bunifu.Framework.UI.BunifuElipse(Me.components)
        Me.animacionSlideBar = New BunifuAnimatorNS.BunifuTransition(Me.components)
        Me.panelContenido = New System.Windows.Forms.Panel()
        Me.animacionSlidebarBack = New BunifuAnimatorNS.BunifuTransition(Me.components)
        Me.moverForma = New Bunifu.Framework.UI.BunifuDragControl(Me.components)
        Me.btnProgClas = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.panelSubClase = New System.Windows.Forms.Panel()
        Me.btnProgTar = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.panelSubTarea = New System.Windows.Forms.Panel()
        Me.panelTop.SuspendLayout()
        CType(Me.btnMenu, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.panelOpciones.SuspendLayout()
        Me.slideBar.SuspendLayout()
        Me.BunifuGradientPanel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.panelSubClase.SuspendLayout()
        Me.panelSubTarea.SuspendLayout()
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
        Me.slideBar.Controls.Add(Me.panelSubTarea)
        Me.slideBar.Controls.Add(Me.btnProgTar)
        Me.slideBar.Controls.Add(Me.panelSubClase)
        Me.slideBar.Controls.Add(Me.btnProgClas)
        Me.slideBar.Controls.Add(Me.BunifuGradientPanel1)
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
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.Transparent
        Me.animacionSlideBar.SetDecoration(Me.Button1, BunifuAnimatorNS.DecorationType.None)
        Me.animacionSlidebarBack.SetDecoration(Me.Button1, BunifuAnimatorNS.DecorationType.None)
        Me.Button1.FlatAppearance.BorderSize = 0
        Me.Button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Shrikhand", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(251, Byte), Integer), CType(CType(190, Byte), Integer), CType(CType(75, Byte), Integer))
        Me.Button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button1.Location = New System.Drawing.Point(0, 128)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(289, 51)
        Me.Button1.TabIndex = 6
        Me.Button1.Text = "Tercero"
        Me.Button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.Transparent
        Me.animacionSlideBar.SetDecoration(Me.Button2, BunifuAnimatorNS.DecorationType.None)
        Me.animacionSlidebarBack.SetDecoration(Me.Button2, BunifuAnimatorNS.DecorationType.None)
        Me.Button2.FlatAppearance.BorderSize = 0
        Me.Button2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Button2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.Font = New System.Drawing.Font("Shrikhand", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(251, Byte), Integer), CType(CType(190, Byte), Integer), CType(CType(75, Byte), Integer))
        Me.Button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button2.Location = New System.Drawing.Point(0, 71)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(289, 51)
        Me.Button2.TabIndex = 5
        Me.Button2.Text = "Segundo"
        Me.Button2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.Color.Transparent
        Me.animacionSlideBar.SetDecoration(Me.Button3, BunifuAnimatorNS.DecorationType.None)
        Me.animacionSlidebarBack.SetDecoration(Me.Button3, BunifuAnimatorNS.DecorationType.None)
        Me.Button3.FlatAppearance.BorderSize = 0
        Me.Button3.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Button3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button3.Font = New System.Drawing.Font("Shrikhand", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(251, Byte), Integer), CType(CType(190, Byte), Integer), CType(CType(75, Byte), Integer))
        Me.Button3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button3.Location = New System.Drawing.Point(0, 14)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(289, 51)
        Me.Button3.TabIndex = 4
        Me.Button3.Text = "Primera"
        Me.Button3.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Button3.UseVisualStyleBackColor = False
        '
        'Button8
        '
        Me.Button8.BackColor = System.Drawing.Color.Transparent
        Me.animacionSlideBar.SetDecoration(Me.Button8, BunifuAnimatorNS.DecorationType.None)
        Me.animacionSlidebarBack.SetDecoration(Me.Button8, BunifuAnimatorNS.DecorationType.None)
        Me.Button8.FlatAppearance.BorderSize = 0
        Me.Button8.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Button8.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Button8.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button8.Font = New System.Drawing.Font("Shrikhand", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button8.ForeColor = System.Drawing.Color.FromArgb(CType(CType(251, Byte), Integer), CType(CType(190, Byte), Integer), CType(CType(75, Byte), Integer))
        Me.Button8.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button8.Location = New System.Drawing.Point(3, 121)
        Me.Button8.Name = "Button8"
        Me.Button8.Size = New System.Drawing.Size(289, 51)
        Me.Button8.TabIndex = 6
        Me.Button8.Text = "Tercero"
        Me.Button8.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Button8.UseVisualStyleBackColor = False
        '
        'Button7
        '
        Me.Button7.BackColor = System.Drawing.Color.Transparent
        Me.animacionSlideBar.SetDecoration(Me.Button7, BunifuAnimatorNS.DecorationType.None)
        Me.animacionSlidebarBack.SetDecoration(Me.Button7, BunifuAnimatorNS.DecorationType.None)
        Me.Button7.FlatAppearance.BorderSize = 0
        Me.Button7.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Button7.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Button7.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button7.Font = New System.Drawing.Font("Shrikhand", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button7.ForeColor = System.Drawing.Color.FromArgb(CType(CType(251, Byte), Integer), CType(CType(190, Byte), Integer), CType(CType(75, Byte), Integer))
        Me.Button7.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button7.Location = New System.Drawing.Point(3, 64)
        Me.Button7.Name = "Button7"
        Me.Button7.Size = New System.Drawing.Size(289, 51)
        Me.Button7.TabIndex = 5
        Me.Button7.Text = "Segundo"
        Me.Button7.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Button7.UseVisualStyleBackColor = False
        '
        'btnArreglos
        '
        Me.btnArreglos.BackColor = System.Drawing.Color.Transparent
        Me.animacionSlideBar.SetDecoration(Me.btnArreglos, BunifuAnimatorNS.DecorationType.None)
        Me.animacionSlidebarBack.SetDecoration(Me.btnArreglos, BunifuAnimatorNS.DecorationType.None)
        Me.btnArreglos.FlatAppearance.BorderSize = 0
        Me.btnArreglos.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btnArreglos.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnArreglos.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnArreglos.Font = New System.Drawing.Font("Shrikhand", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnArreglos.ForeColor = System.Drawing.Color.FromArgb(CType(CType(251, Byte), Integer), CType(CType(190, Byte), Integer), CType(CType(75, Byte), Integer))
        Me.btnArreglos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnArreglos.Location = New System.Drawing.Point(3, 7)
        Me.btnArreglos.Name = "btnArreglos"
        Me.btnArreglos.Size = New System.Drawing.Size(289, 51)
        Me.btnArreglos.TabIndex = 4
        Me.btnArreglos.Text = "Arreglos"
        Me.btnArreglos.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnArreglos.UseVisualStyleBackColor = False
        '
        'BunifuGradientPanel1
        '
        Me.BunifuGradientPanel1.BackColor = System.Drawing.Color.Transparent
        Me.BunifuGradientPanel1.BackgroundImage = CType(resources.GetObject("BunifuGradientPanel1.BackgroundImage"), System.Drawing.Image)
        Me.BunifuGradientPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BunifuGradientPanel1.Controls.Add(Me.PictureBox1)
        Me.BunifuGradientPanel1.Controls.Add(Me.Label1)
        Me.BunifuGradientPanel1.Controls.Add(Me.lineaSideBar)
        Me.animacionSlidebarBack.SetDecoration(Me.BunifuGradientPanel1, BunifuAnimatorNS.DecorationType.None)
        Me.animacionSlideBar.SetDecoration(Me.BunifuGradientPanel1, BunifuAnimatorNS.DecorationType.None)
        Me.BunifuGradientPanel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.BunifuGradientPanel1.GradientBottomLeft = System.Drawing.Color.FromArgb(CType(CType(117, Byte), Integer), CType(CType(35, Byte), Integer), CType(CType(6, Byte), Integer))
        Me.BunifuGradientPanel1.GradientBottomRight = System.Drawing.Color.FromArgb(CType(CType(117, Byte), Integer), CType(CType(35, Byte), Integer), CType(CType(6, Byte), Integer))
        Me.BunifuGradientPanel1.GradientTopLeft = System.Drawing.Color.Black
        Me.BunifuGradientPanel1.GradientTopRight = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.BunifuGradientPanel1.Location = New System.Drawing.Point(0, 0)
        Me.BunifuGradientPanel1.Name = "BunifuGradientPanel1"
        Me.BunifuGradientPanel1.Quality = 10
        Me.BunifuGradientPanel1.Size = New System.Drawing.Size(310, 86)
        Me.BunifuGradientPanel1.TabIndex = 0
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.animacionSlideBar.SetDecoration(Me.PictureBox1, BunifuAnimatorNS.DecorationType.None)
        Me.animacionSlidebarBack.SetDecoration(Me.PictureBox1, BunifuAnimatorNS.DecorationType.None)
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(14, 4)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(52, 55)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.animacionSlideBar.SetDecoration(Me.Label1, BunifuAnimatorNS.DecorationType.None)
        Me.animacionSlidebarBack.SetDecoration(Me.Label1, BunifuAnimatorNS.DecorationType.None)
        Me.Label1.Font = New System.Drawing.Font("Shrikhand", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(90, 15)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(182, 35)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Menu tareas:"
        '
        'lineaSideBar
        '
        Me.lineaSideBar.BackColor = System.Drawing.Color.Transparent
        Me.animacionSlidebarBack.SetDecoration(Me.lineaSideBar, BunifuAnimatorNS.DecorationType.None)
        Me.animacionSlideBar.SetDecoration(Me.lineaSideBar, BunifuAnimatorNS.DecorationType.None)
        Me.lineaSideBar.LineColor = System.Drawing.Color.FromArgb(CType(CType(105, Byte), Integer), CType(CType(105, Byte), Integer), CType(CType(105, Byte), Integer))
        Me.lineaSideBar.LineThickness = 1
        Me.lineaSideBar.Location = New System.Drawing.Point(14, 66)
        Me.lineaSideBar.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.lineaSideBar.Name = "lineaSideBar"
        Me.lineaSideBar.Size = New System.Drawing.Size(290, 1)
        Me.lineaSideBar.TabIndex = 1
        Me.lineaSideBar.Transparency = 255
        Me.lineaSideBar.Vertical = False
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
        Animation15.AnimateOnlyDifferences = True
        Animation15.BlindCoeff = CType(resources.GetObject("Animation15.BlindCoeff"), System.Drawing.PointF)
        Animation15.LeafCoeff = 0!
        Animation15.MaxTime = 1.0!
        Animation15.MinTime = 0!
        Animation15.MosaicCoeff = CType(resources.GetObject("Animation15.MosaicCoeff"), System.Drawing.PointF)
        Animation15.MosaicShift = CType(resources.GetObject("Animation15.MosaicShift"), System.Drawing.PointF)
        Animation15.MosaicSize = 0
        Animation15.Padding = New System.Windows.Forms.Padding(0)
        Animation15.RotateCoeff = 0!
        Animation15.RotateLimit = 0!
        Animation15.ScaleCoeff = CType(resources.GetObject("Animation15.ScaleCoeff"), System.Drawing.PointF)
        Animation15.SlideCoeff = CType(resources.GetObject("Animation15.SlideCoeff"), System.Drawing.PointF)
        Animation15.TimeCoeff = 0!
        Animation15.TransparencyCoeff = 0!
        Me.animacionSlideBar.DefaultAnimation = Animation15
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
        'animacionSlidebarBack
        '
        Me.animacionSlidebarBack.AnimationType = BunifuAnimatorNS.AnimationType.HorizBlind
        Me.animacionSlidebarBack.Cursor = Nothing
        Animation16.AnimateOnlyDifferences = True
        Animation16.BlindCoeff = CType(resources.GetObject("Animation16.BlindCoeff"), System.Drawing.PointF)
        Animation16.LeafCoeff = 0!
        Animation16.MaxTime = 1.0!
        Animation16.MinTime = 0!
        Animation16.MosaicCoeff = CType(resources.GetObject("Animation16.MosaicCoeff"), System.Drawing.PointF)
        Animation16.MosaicShift = CType(resources.GetObject("Animation16.MosaicShift"), System.Drawing.PointF)
        Animation16.MosaicSize = 0
        Animation16.Padding = New System.Windows.Forms.Padding(0)
        Animation16.RotateCoeff = 0!
        Animation16.RotateLimit = 0!
        Animation16.ScaleCoeff = CType(resources.GetObject("Animation16.ScaleCoeff"), System.Drawing.PointF)
        Animation16.SlideCoeff = CType(resources.GetObject("Animation16.SlideCoeff"), System.Drawing.PointF)
        Animation16.TimeCoeff = 0!
        Animation16.TransparencyCoeff = 0!
        Me.animacionSlidebarBack.DefaultAnimation = Animation16
        '
        'moverForma
        '
        Me.moverForma.Fixed = True
        Me.moverForma.Horizontal = True
        Me.moverForma.TargetControl = Me.panelTop
        Me.moverForma.Vertical = True
        '
        'btnProgClas
        '
        Me.btnProgClas.Activecolor = System.Drawing.Color.Transparent
        Me.btnProgClas.BackColor = System.Drawing.Color.Transparent
        Me.btnProgClas.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnProgClas.BorderRadius = 0
        Me.btnProgClas.ButtonText = "    Programas Clase"
        Me.btnProgClas.Cursor = System.Windows.Forms.Cursors.Hand
        Me.animacionSlideBar.SetDecoration(Me.btnProgClas, BunifuAnimatorNS.DecorationType.None)
        Me.animacionSlidebarBack.SetDecoration(Me.btnProgClas, BunifuAnimatorNS.DecorationType.None)
        Me.btnProgClas.DisabledColor = System.Drawing.Color.Gray
        Me.btnProgClas.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnProgClas.Iconcolor = System.Drawing.Color.Transparent
        Me.btnProgClas.Iconimage = CType(resources.GetObject("btnProgClas.Iconimage"), System.Drawing.Image)
        Me.btnProgClas.Iconimage_right = Nothing
        Me.btnProgClas.Iconimage_right_Selected = Nothing
        Me.btnProgClas.Iconimage_Selected = Nothing
        Me.btnProgClas.IconMarginLeft = 0
        Me.btnProgClas.IconMarginRight = 0
        Me.btnProgClas.IconRightVisible = True
        Me.btnProgClas.IconRightZoom = 0R
        Me.btnProgClas.IconVisible = True
        Me.btnProgClas.IconZoom = 90.0R
        Me.btnProgClas.IsTab = False
        Me.btnProgClas.Location = New System.Drawing.Point(0, 86)
        Me.btnProgClas.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnProgClas.Name = "btnProgClas"
        Me.btnProgClas.Normalcolor = System.Drawing.Color.Transparent
        Me.btnProgClas.OnHovercolor = System.Drawing.Color.Transparent
        Me.btnProgClas.OnHoverTextColor = System.Drawing.Color.White
        Me.btnProgClas.selected = False
        Me.btnProgClas.Size = New System.Drawing.Size(310, 72)
        Me.btnProgClas.TabIndex = 1
        Me.btnProgClas.Text = "    Programas Clase"
        Me.btnProgClas.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnProgClas.Textcolor = System.Drawing.Color.White
        Me.btnProgClas.TextFont = New System.Drawing.Font("Shrikhand", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'panelSubClase
        '
        Me.panelSubClase.BackColor = System.Drawing.Color.Transparent
        Me.panelSubClase.Controls.Add(Me.Button8)
        Me.panelSubClase.Controls.Add(Me.btnArreglos)
        Me.panelSubClase.Controls.Add(Me.Button7)
        Me.animacionSlidebarBack.SetDecoration(Me.panelSubClase, BunifuAnimatorNS.DecorationType.None)
        Me.animacionSlideBar.SetDecoration(Me.panelSubClase, BunifuAnimatorNS.DecorationType.None)
        Me.panelSubClase.Dock = System.Windows.Forms.DockStyle.Top
        Me.panelSubClase.Location = New System.Drawing.Point(0, 158)
        Me.panelSubClase.Name = "panelSubClase"
        Me.panelSubClase.Size = New System.Drawing.Size(310, 256)
        Me.panelSubClase.TabIndex = 2
        Me.panelSubClase.Visible = False
        '
        'btnProgTar
        '
        Me.btnProgTar.Activecolor = System.Drawing.Color.Transparent
        Me.btnProgTar.BackColor = System.Drawing.Color.Transparent
        Me.btnProgTar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnProgTar.BorderRadius = 0
        Me.btnProgTar.ButtonText = "    Programas tarea"
        Me.btnProgTar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.animacionSlideBar.SetDecoration(Me.btnProgTar, BunifuAnimatorNS.DecorationType.None)
        Me.animacionSlidebarBack.SetDecoration(Me.btnProgTar, BunifuAnimatorNS.DecorationType.None)
        Me.btnProgTar.DisabledColor = System.Drawing.Color.Gray
        Me.btnProgTar.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnProgTar.Iconcolor = System.Drawing.Color.Transparent
        Me.btnProgTar.Iconimage = CType(resources.GetObject("btnProgTar.Iconimage"), System.Drawing.Image)
        Me.btnProgTar.Iconimage_right = Nothing
        Me.btnProgTar.Iconimage_right_Selected = Nothing
        Me.btnProgTar.Iconimage_Selected = Nothing
        Me.btnProgTar.IconMarginLeft = 0
        Me.btnProgTar.IconMarginRight = 0
        Me.btnProgTar.IconRightVisible = True
        Me.btnProgTar.IconRightZoom = 0R
        Me.btnProgTar.IconVisible = True
        Me.btnProgTar.IconZoom = 90.0R
        Me.btnProgTar.IsTab = False
        Me.btnProgTar.Location = New System.Drawing.Point(0, 414)
        Me.btnProgTar.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnProgTar.Name = "btnProgTar"
        Me.btnProgTar.Normalcolor = System.Drawing.Color.Transparent
        Me.btnProgTar.OnHovercolor = System.Drawing.Color.Transparent
        Me.btnProgTar.OnHoverTextColor = System.Drawing.Color.White
        Me.btnProgTar.selected = False
        Me.btnProgTar.Size = New System.Drawing.Size(310, 78)
        Me.btnProgTar.TabIndex = 3
        Me.btnProgTar.Text = "    Programas tarea"
        Me.btnProgTar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnProgTar.Textcolor = System.Drawing.Color.White
        Me.btnProgTar.TextFont = New System.Drawing.Font("Shrikhand", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'panelSubTarea
        '
        Me.panelSubTarea.BackColor = System.Drawing.Color.Transparent
        Me.panelSubTarea.Controls.Add(Me.Button1)
        Me.panelSubTarea.Controls.Add(Me.Button3)
        Me.panelSubTarea.Controls.Add(Me.Button2)
        Me.animacionSlidebarBack.SetDecoration(Me.panelSubTarea, BunifuAnimatorNS.DecorationType.None)
        Me.animacionSlideBar.SetDecoration(Me.panelSubTarea, BunifuAnimatorNS.DecorationType.None)
        Me.panelSubTarea.Dock = System.Windows.Forms.DockStyle.Top
        Me.panelSubTarea.Location = New System.Drawing.Point(0, 492)
        Me.panelSubTarea.Name = "panelSubTarea"
        Me.panelSubTarea.Size = New System.Drawing.Size(310, 257)
        Me.panelSubTarea.TabIndex = 4
        Me.panelSubTarea.Visible = False
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
        Me.BunifuGradientPanel1.ResumeLayout(False)
        Me.BunifuGradientPanel1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.panelSubClase.ResumeLayout(False)
        Me.panelSubTarea.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents panelTop As Panel
    Friend WithEvents btnMenu As PictureBox
    Friend WithEvents panelOpciones As Panel
    Friend WithEvents slideBar As Bunifu.Framework.UI.BunifuGradientPanel
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
    Friend WithEvents Button8 As Button
    Friend WithEvents Button7 As Button
    Friend WithEvents btnArreglos As Button
    Friend WithEvents BunifuGradientPanel1 As Bunifu.Framework.UI.BunifuGradientPanel
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents btnProgClas As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents panelSubClase As Panel
    Friend WithEvents btnProgTar As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents panelSubTarea As Panel
End Class
