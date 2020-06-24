<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class BolsaSolidaria
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
        Me.components = New System.ComponentModel.Container()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.mtbIntegrantes = New System.Windows.Forms.MaskedTextBox()
        Me.txtNumId = New System.Windows.Forms.TextBox()
        Me.txtNomComp = New System.Windows.Forms.TextBox()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.txtMuni = New System.Windows.Forms.TextBox()
        Me.txtDepart = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.BackgroundWorker1 = New System.ComponentModel.BackgroundWorker()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.chkPobreza = New System.Windows.Forms.CheckBox()
        Me.chkPobrezaExt = New System.Windows.Forms.CheckBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.GroupBox6 = New System.Windows.Forms.GroupBox()
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.btnIngresar = New System.Windows.Forms.Button()
        Me.ErrorValidacion = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.chkBasic = New System.Windows.Forms.CheckBox()
        Me.chkRegul = New System.Windows.Forms.CheckBox()
        Me.btnLimpiar = New System.Windows.Forms.Button()
        Me.btnLimpiarlb = New System.Windows.Forms.Button()
        Me.dgvReporte = New System.Windows.Forms.DataGridView()
        Me.columnaId = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.columnaNombre = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.columnaIntegrantes = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.columnaDepartamento = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.columnaMunicipio = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.columnaEstado = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.columnaTipo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.txtBolsaBas = New System.Windows.Forms.TextBox()
        Me.txtBolsaReg = New System.Windows.Forms.TextBox()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox6.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        CType(Me.ErrorValidacion, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvReporte, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.DarkKhaki
        Me.GroupBox1.Controls.Add(Me.mtbIntegrantes)
        Me.GroupBox1.Controls.Add(Me.txtNumId)
        Me.GroupBox1.Controls.Add(Me.txtNomComp)
        Me.GroupBox1.Controls.Add(Me.GroupBox4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Font = New System.Drawing.Font("Russo One", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(392, 467)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Ingreso de datos"
        '
        'mtbIntegrantes
        '
        Me.mtbIntegrantes.Font = New System.Drawing.Font("Rockwell", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mtbIntegrantes.Location = New System.Drawing.Point(270, 204)
        Me.mtbIntegrantes.Mask = "99"
        Me.mtbIntegrantes.Name = "mtbIntegrantes"
        Me.mtbIntegrantes.Size = New System.Drawing.Size(46, 31)
        Me.mtbIntegrantes.TabIndex = 7
        '
        'txtNumId
        '
        Me.txtNumId.Font = New System.Drawing.Font("Rockwell", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNumId.Location = New System.Drawing.Point(21, 74)
        Me.txtNumId.Name = "txtNumId"
        Me.txtNumId.Size = New System.Drawing.Size(322, 29)
        Me.txtNumId.TabIndex = 6
        '
        'txtNomComp
        '
        Me.txtNomComp.Font = New System.Drawing.Font("Rockwell", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNomComp.Location = New System.Drawing.Point(21, 155)
        Me.txtNomComp.Name = "txtNomComp"
        Me.txtNomComp.Size = New System.Drawing.Size(322, 29)
        Me.txtNomComp.TabIndex = 5
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.txtMuni)
        Me.GroupBox4.Controls.Add(Me.txtDepart)
        Me.GroupBox4.Controls.Add(Me.Label7)
        Me.GroupBox4.Controls.Add(Me.Label6)
        Me.GroupBox4.Location = New System.Drawing.Point(20, 243)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(352, 206)
        Me.GroupBox4.TabIndex = 3
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Dirección"
        '
        'txtMuni
        '
        Me.txtMuni.Font = New System.Drawing.Font("Rockwell", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMuni.Location = New System.Drawing.Point(30, 151)
        Me.txtMuni.Name = "txtMuni"
        Me.txtMuni.Size = New System.Drawing.Size(293, 29)
        Me.txtMuni.TabIndex = 8
        '
        'txtDepart
        '
        Me.txtDepart.Font = New System.Drawing.Font("Rockwell", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDepart.Location = New System.Drawing.Point(30, 61)
        Me.txtDepart.Name = "txtDepart"
        Me.txtDepart.Size = New System.Drawing.Size(293, 29)
        Me.txtDepart.TabIndex = 7
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Shrikhand", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(26, 124)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(108, 24)
        Me.Label7.TabIndex = 3
        Me.Label7.Text = "Municipio:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Shrikhand", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(26, 34)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(148, 24)
        Me.Label6.TabIndex = 2
        Me.Label6.Text = "Departamento:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Shrikhand", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(16, 208)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(234, 24)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Integrantes de la familia:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Shrikhand", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(16, 121)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(176, 24)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Nombre completo:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Shrikhand", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(16, 45)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(123, 24)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "N°  Identidad:"
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.DarkKhaki
        Me.GroupBox2.Controls.Add(Me.dgvReporte)
        Me.GroupBox2.Controls.Add(Me.btnLimpiarlb)
        Me.GroupBox2.Font = New System.Drawing.Font("Russo One", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(12, 485)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(1015, 279)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Reporte"
        '
        'chkPobreza
        '
        Me.chkPobreza.AutoSize = True
        Me.chkPobreza.Font = New System.Drawing.Font("Shrikhand", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkPobreza.Location = New System.Drawing.Point(49, 39)
        Me.chkPobreza.Name = "chkPobreza"
        Me.chkPobreza.Size = New System.Drawing.Size(109, 28)
        Me.chkPobreza.TabIndex = 4
        Me.chkPobreza.Text = "Pobreza"
        Me.chkPobreza.UseVisualStyleBackColor = True
        '
        'chkPobrezaExt
        '
        Me.chkPobrezaExt.AutoSize = True
        Me.chkPobrezaExt.Font = New System.Drawing.Font("Shrikhand", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkPobrezaExt.Location = New System.Drawing.Point(142, 73)
        Me.chkPobrezaExt.Name = "chkPobrezaExt"
        Me.chkPobrezaExt.Size = New System.Drawing.Size(189, 28)
        Me.chkPobrezaExt.TabIndex = 5
        Me.chkPobrezaExt.Text = "Pobreza extrema"
        Me.chkPobrezaExt.UseVisualStyleBackColor = True
        '
        'GroupBox3
        '
        Me.GroupBox3.BackColor = System.Drawing.Color.DarkKhaki
        Me.GroupBox3.Controls.Add(Me.btnLimpiar)
        Me.GroupBox3.Controls.Add(Me.btnIngresar)
        Me.GroupBox3.Controls.Add(Me.GroupBox6)
        Me.GroupBox3.Controls.Add(Me.GroupBox5)
        Me.GroupBox3.Font = New System.Drawing.Font("Russo One", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox3.Location = New System.Drawing.Point(427, 12)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(600, 404)
        Me.GroupBox3.TabIndex = 2
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Información"
        '
        'GroupBox6
        '
        Me.GroupBox6.Controls.Add(Me.txtBolsaReg)
        Me.GroupBox6.Controls.Add(Me.txtBolsaBas)
        Me.GroupBox6.Controls.Add(Me.chkRegul)
        Me.GroupBox6.Controls.Add(Me.chkBasic)
        Me.GroupBox6.Location = New System.Drawing.Point(29, 33)
        Me.GroupBox6.Name = "GroupBox6"
        Me.GroupBox6.Size = New System.Drawing.Size(556, 188)
        Me.GroupBox6.TabIndex = 10
        Me.GroupBox6.TabStop = False
        Me.GroupBox6.Text = "Tipos bolsa"
        '
        'GroupBox5
        '
        Me.GroupBox5.Controls.Add(Me.chkPobrezaExt)
        Me.GroupBox5.Controls.Add(Me.chkPobreza)
        Me.GroupBox5.Location = New System.Drawing.Point(139, 220)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(355, 123)
        Me.GroupBox5.TabIndex = 7
        Me.GroupBox5.TabStop = False
        Me.GroupBox5.Text = "Estado"
        '
        'btnIngresar
        '
        Me.btnIngresar.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnIngresar.Font = New System.Drawing.Font("Shrikhand", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnIngresar.Location = New System.Drawing.Point(109, 349)
        Me.btnIngresar.Name = "btnIngresar"
        Me.btnIngresar.Size = New System.Drawing.Size(157, 49)
        Me.btnIngresar.TabIndex = 3
        Me.btnIngresar.Text = "Ingresar"
        Me.btnIngresar.UseVisualStyleBackColor = False
        '
        'ErrorValidacion
        '
        Me.ErrorValidacion.ContainerControl = Me
        '
        'chkBasic
        '
        Me.chkBasic.AutoSize = True
        Me.chkBasic.Enabled = False
        Me.chkBasic.Font = New System.Drawing.Font("Shrikhand", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkBasic.Location = New System.Drawing.Point(32, 28)
        Me.chkBasic.Name = "chkBasic"
        Me.chkBasic.Size = New System.Drawing.Size(92, 28)
        Me.chkBasic.TabIndex = 10
        Me.chkBasic.Text = "Básica"
        Me.chkBasic.UseVisualStyleBackColor = True
        '
        'chkRegul
        '
        Me.chkRegul.AutoSize = True
        Me.chkRegul.Enabled = False
        Me.chkRegul.Font = New System.Drawing.Font("Shrikhand", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkRegul.Location = New System.Drawing.Point(32, 104)
        Me.chkRegul.Name = "chkRegul"
        Me.chkRegul.Size = New System.Drawing.Size(105, 28)
        Me.chkRegul.TabIndex = 11
        Me.chkRegul.Text = "Regular"
        Me.chkRegul.UseVisualStyleBackColor = True
        '
        'btnLimpiar
        '
        Me.btnLimpiar.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnLimpiar.Font = New System.Drawing.Font("Shrikhand", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLimpiar.Location = New System.Drawing.Point(338, 352)
        Me.btnLimpiar.Name = "btnLimpiar"
        Me.btnLimpiar.Size = New System.Drawing.Size(185, 42)
        Me.btnLimpiar.TabIndex = 5
        Me.btnLimpiar.Text = "Limpiar"
        Me.btnLimpiar.UseVisualStyleBackColor = False
        '
        'btnLimpiarlb
        '
        Me.btnLimpiarlb.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnLimpiarlb.Font = New System.Drawing.Font("Shrikhand", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLimpiarlb.Location = New System.Drawing.Point(836, 244)
        Me.btnLimpiarlb.Name = "btnLimpiarlb"
        Me.btnLimpiarlb.Size = New System.Drawing.Size(164, 29)
        Me.btnLimpiarlb.TabIndex = 6
        Me.btnLimpiarlb.Text = "Limpiar"
        Me.btnLimpiarlb.UseVisualStyleBackColor = False
        '
        'dgvReporte
        '
        Me.dgvReporte.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvReporte.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.columnaId, Me.columnaNombre, Me.columnaIntegrantes, Me.columnaDepartamento, Me.columnaMunicipio, Me.columnaEstado, Me.columnaTipo})
        Me.dgvReporte.Location = New System.Drawing.Point(21, 34)
        Me.dgvReporte.Name = "dgvReporte"
        Me.dgvReporte.RowHeadersWidth = 51
        Me.dgvReporte.RowTemplate.Height = 24
        Me.dgvReporte.Size = New System.Drawing.Size(979, 204)
        Me.dgvReporte.TabIndex = 7
        '
        'columnaId
        '
        Me.columnaId.HeaderText = "N° Identidad"
        Me.columnaId.MinimumWidth = 6
        Me.columnaId.Name = "columnaId"
        Me.columnaId.ReadOnly = True
        Me.columnaId.Width = 125
        '
        'columnaNombre
        '
        Me.columnaNombre.HeaderText = "Nombre completo"
        Me.columnaNombre.MinimumWidth = 6
        Me.columnaNombre.Name = "columnaNombre"
        Me.columnaNombre.ReadOnly = True
        Me.columnaNombre.Width = 125
        '
        'columnaIntegrantes
        '
        Me.columnaIntegrantes.HeaderText = "Integrantes"
        Me.columnaIntegrantes.MinimumWidth = 6
        Me.columnaIntegrantes.Name = "columnaIntegrantes"
        Me.columnaIntegrantes.ReadOnly = True
        Me.columnaIntegrantes.Width = 125
        '
        'columnaDepartamento
        '
        Me.columnaDepartamento.HeaderText = "Departamento"
        Me.columnaDepartamento.MinimumWidth = 6
        Me.columnaDepartamento.Name = "columnaDepartamento"
        Me.columnaDepartamento.ReadOnly = True
        Me.columnaDepartamento.Width = 125
        '
        'columnaMunicipio
        '
        Me.columnaMunicipio.HeaderText = "Municipio"
        Me.columnaMunicipio.MinimumWidth = 6
        Me.columnaMunicipio.Name = "columnaMunicipio"
        Me.columnaMunicipio.ReadOnly = True
        Me.columnaMunicipio.Width = 125
        '
        'columnaEstado
        '
        Me.columnaEstado.HeaderText = "Estado"
        Me.columnaEstado.MinimumWidth = 6
        Me.columnaEstado.Name = "columnaEstado"
        Me.columnaEstado.ReadOnly = True
        Me.columnaEstado.Width = 125
        '
        'columnaTipo
        '
        Me.columnaTipo.HeaderText = "Tipo bolsa"
        Me.columnaTipo.MinimumWidth = 6
        Me.columnaTipo.Name = "columnaTipo"
        Me.columnaTipo.ReadOnly = True
        Me.columnaTipo.Width = 125
        '
        'txtBolsaBas
        '
        Me.txtBolsaBas.Enabled = False
        Me.txtBolsaBas.Font = New System.Drawing.Font("Rockwell", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBolsaBas.Location = New System.Drawing.Point(143, 27)
        Me.txtBolsaBas.Multiline = True
        Me.txtBolsaBas.Name = "txtBolsaBas"
        Me.txtBolsaBas.Size = New System.Drawing.Size(382, 62)
        Me.txtBolsaBas.TabIndex = 12
        '
        'txtBolsaReg
        '
        Me.txtBolsaReg.Enabled = False
        Me.txtBolsaReg.Font = New System.Drawing.Font("Rockwell", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBolsaReg.Location = New System.Drawing.Point(143, 104)
        Me.txtBolsaReg.Multiline = True
        Me.txtBolsaReg.Name = "txtBolsaReg"
        Me.txtBolsaReg.Size = New System.Drawing.Size(382, 62)
        Me.txtBolsaReg.TabIndex = 13
        '
        'BolsaSolidaria
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.ClientSize = New System.Drawing.Size(1051, 776)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "BolsaSolidaria"
        Me.Text = "BolsaSolidaria"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox6.ResumeLayout(False)
        Me.GroupBox6.PerformLayout()
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox5.PerformLayout()
        CType(Me.ErrorValidacion, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvReporte, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents txtNumId As TextBox
    Friend WithEvents txtNomComp As TextBox
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents txtMuni As TextBox
    Friend WithEvents txtDepart As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents BackgroundWorker1 As System.ComponentModel.BackgroundWorker
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents chkPobreza As CheckBox
    Friend WithEvents chkPobrezaExt As CheckBox
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents GroupBox6 As GroupBox
    Friend WithEvents GroupBox5 As GroupBox
    Friend WithEvents btnIngresar As Button
    Friend WithEvents mtbIntegrantes As MaskedTextBox
    Friend WithEvents ErrorValidacion As ErrorProvider
    Friend WithEvents chkRegul As CheckBox
    Friend WithEvents chkBasic As CheckBox
    Friend WithEvents btnLimpiar As Button
    Friend WithEvents btnLimpiarlb As Button
    Friend WithEvents dgvReporte As DataGridView
    Friend WithEvents columnaId As DataGridViewTextBoxColumn
    Friend WithEvents columnaNombre As DataGridViewTextBoxColumn
    Friend WithEvents columnaIntegrantes As DataGridViewTextBoxColumn
    Friend WithEvents columnaDepartamento As DataGridViewTextBoxColumn
    Friend WithEvents columnaMunicipio As DataGridViewTextBoxColumn
    Friend WithEvents columnaEstado As DataGridViewTextBoxColumn
    Friend WithEvents columnaTipo As DataGridViewTextBoxColumn
    Friend WithEvents txtBolsaReg As TextBox
    Friend WithEvents txtBolsaBas As TextBox
End Class
