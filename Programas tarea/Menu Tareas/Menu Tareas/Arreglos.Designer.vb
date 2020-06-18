<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Arreglos
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Arreglos))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.cmbPrecios = New System.Windows.Forms.ComboBox()
        Me.btnSolicitar = New System.Windows.Forms.Button()
        Me.btnGenerar = New System.Windows.Forms.Button()
        Me.cmbComputadoras = New System.Windows.Forms.ComboBox()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.txtCant = New System.Windows.Forms.TextBox()
        Me.btnSolicitarInput = New System.Windows.Forms.Button()
        Me.cmbCompus = New System.Windows.Forms.ComboBox()
        Me.btnLimpiar = New System.Windows.Forms.Button()
        Me.btnHome = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.DarkGray
        Me.Panel1.Controls.Add(Me.cmbPrecios)
        Me.Panel1.Controls.Add(Me.btnSolicitar)
        Me.Panel1.Controls.Add(Me.btnGenerar)
        Me.Panel1.Controls.Add(Me.cmbComputadoras)
        Me.Panel1.Location = New System.Drawing.Point(22, 17)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(465, 337)
        Me.Panel1.TabIndex = 0
        '
        'cmbPrecios
        '
        Me.cmbPrecios.Font = New System.Drawing.Font("Russo One", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbPrecios.FormattingEnabled = True
        Me.cmbPrecios.Location = New System.Drawing.Point(247, 252)
        Me.cmbPrecios.Name = "cmbPrecios"
        Me.cmbPrecios.Size = New System.Drawing.Size(180, 29)
        Me.cmbPrecios.TabIndex = 3
        '
        'btnSolicitar
        '
        Me.btnSolicitar.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btnSolicitar.Font = New System.Drawing.Font("Shrikhand", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSolicitar.Location = New System.Drawing.Point(284, 160)
        Me.btnSolicitar.Name = "btnSolicitar"
        Me.btnSolicitar.Size = New System.Drawing.Size(115, 71)
        Me.btnSolicitar.TabIndex = 2
        Me.btnSolicitar.Text = "Agregar" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "precios"
        Me.btnSolicitar.UseVisualStyleBackColor = False
        '
        'btnGenerar
        '
        Me.btnGenerar.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btnGenerar.Font = New System.Drawing.Font("Shrikhand", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnGenerar.Location = New System.Drawing.Point(64, 19)
        Me.btnGenerar.Name = "btnGenerar"
        Me.btnGenerar.Size = New System.Drawing.Size(157, 88)
        Me.btnGenerar.TabIndex = 1
        Me.btnGenerar.Text = "  Agregar" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "ordenadores"
        Me.btnGenerar.UseVisualStyleBackColor = False
        '
        'cmbComputadoras
        '
        Me.cmbComputadoras.Font = New System.Drawing.Font("Russo One", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbComputadoras.FormattingEnabled = True
        Me.cmbComputadoras.Location = New System.Drawing.Point(22, 131)
        Me.cmbComputadoras.Name = "cmbComputadoras"
        Me.cmbComputadoras.Size = New System.Drawing.Size(180, 29)
        Me.cmbComputadoras.TabIndex = 0
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.DarkGray
        Me.Panel2.Controls.Add(Me.txtCant)
        Me.Panel2.Controls.Add(Me.btnSolicitarInput)
        Me.Panel2.Controls.Add(Me.cmbCompus)
        Me.Panel2.Location = New System.Drawing.Point(563, 17)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(356, 337)
        Me.Panel2.TabIndex = 1
        '
        'txtCant
        '
        Me.txtCant.Font = New System.Drawing.Font("Rockwell", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCant.Location = New System.Drawing.Point(88, 56)
        Me.txtCant.Name = "txtCant"
        Me.txtCant.Size = New System.Drawing.Size(162, 31)
        Me.txtCant.TabIndex = 3
        '
        'btnSolicitarInput
        '
        Me.btnSolicitarInput.BackColor = System.Drawing.Color.Teal
        Me.btnSolicitarInput.Font = New System.Drawing.Font("Shrikhand", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSolicitarInput.Location = New System.Drawing.Point(167, 93)
        Me.btnSolicitarInput.Name = "btnSolicitarInput"
        Me.btnSolicitarInput.Size = New System.Drawing.Size(169, 74)
        Me.btnSolicitarInput.TabIndex = 2
        Me.btnSolicitarInput.Text = "  Agregar" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "ordenadores"
        Me.btnSolicitarInput.UseVisualStyleBackColor = False
        '
        'cmbCompus
        '
        Me.cmbCompus.Font = New System.Drawing.Font("Russo One", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbCompus.FormattingEnabled = True
        Me.cmbCompus.Location = New System.Drawing.Point(88, 230)
        Me.cmbCompus.Name = "cmbCompus"
        Me.cmbCompus.Size = New System.Drawing.Size(180, 29)
        Me.cmbCompus.TabIndex = 1
        '
        'btnLimpiar
        '
        Me.btnLimpiar.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnLimpiar.Font = New System.Drawing.Font("Shrikhand", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLimpiar.Location = New System.Drawing.Point(416, 360)
        Me.btnLimpiar.Name = "btnLimpiar"
        Me.btnLimpiar.Size = New System.Drawing.Size(205, 40)
        Me.btnLimpiar.TabIndex = 2
        Me.btnLimpiar.Text = "Limpiar"
        Me.btnLimpiar.UseVisualStyleBackColor = False
        '
        'btnHome
        '
        Me.btnHome.BackgroundImage = CType(resources.GetObject("btnHome.BackgroundImage"), System.Drawing.Image)
        Me.btnHome.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnHome.FlatAppearance.BorderSize = 0
        Me.btnHome.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver
        Me.btnHome.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray
        Me.btnHome.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnHome.Location = New System.Drawing.Point(503, 148)
        Me.btnHome.Name = "btnHome"
        Me.btnHome.Size = New System.Drawing.Size(44, 47)
        Me.btnHome.TabIndex = 4
        Me.btnHome.UseVisualStyleBackColor = True
        '
        'Arreglos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.AutoSize = True
        Me.BackColor = System.Drawing.Color.LightGray
        Me.ClientSize = New System.Drawing.Size(949, 408)
        Me.Controls.Add(Me.btnHome)
        Me.Controls.Add(Me.btnLimpiar)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Arreglos"
        Me.Text = "Primera tarea"
        Me.Panel1.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents btnGenerar As Button
    Friend WithEvents cmbComputadoras As ComboBox
    Friend WithEvents Panel2 As Panel
    Friend WithEvents cmbCompus As ComboBox
    Friend WithEvents cmbPrecios As ComboBox
    Friend WithEvents btnSolicitar As Button
    Friend WithEvents txtCant As TextBox
    Friend WithEvents btnSolicitarInput As Button
    Friend WithEvents btnLimpiar As Button
    Friend WithEvents btnHome As Button
End Class
