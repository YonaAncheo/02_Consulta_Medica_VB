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
        Me.dgvAtenciones = New System.Windows.Forms.DataGridView()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.idPacienteTxt = New System.Windows.Forms.TextBox()
        Me.nomCteTxt = New System.Windows.Forms.TextBox()
        Me.dirCteTxt = New System.Windows.Forms.TextBox()
        Me.telCteTxt = New System.Windows.Forms.TextBox()
        Me.txtIdEsp = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.cmbEspecialidad = New System.Windows.Forms.ComboBox()
        Me.idLabel = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.cmbMedico = New System.Windows.Forms.ComboBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtIdMed = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txtIdAct = New System.Windows.Forms.TextBox()
        Me.cmbActividad = New System.Windows.Forms.ComboBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.cmbDia = New System.Windows.Forms.ComboBox()
        Me.cmbMes = New System.Windows.Forms.ComboBox()
        Me.cmbAnio = New System.Windows.Forms.ComboBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.ingresarBtn = New System.Windows.Forms.Button()
        Me.listarAtencionesBtn = New System.Windows.Forms.Button()
        Me.atePorFechaBtn = New System.Windows.Forms.Button()
        Me.datosPacBtn = New System.Windows.Forms.Button()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.edadCteTxt = New System.Windows.Forms.TextBox()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.txtIdAte = New System.Windows.Forms.TextBox()
        CType(Me.dgvAtenciones, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgvAtenciones
        '
        Me.dgvAtenciones.AllowUserToAddRows = False
        Me.dgvAtenciones.AllowUserToDeleteRows = False
        Me.dgvAtenciones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvAtenciones.Location = New System.Drawing.Point(48, 368)
        Me.dgvAtenciones.Name = "dgvAtenciones"
        Me.dgvAtenciones.Size = New System.Drawing.Size(671, 216)
        Me.dgvAtenciones.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(39, 40)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(99, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Datos del paciente."
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(158, 40)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(18, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "ID"
        '
        'idPacienteTxt
        '
        Me.idPacienteTxt.Location = New System.Drawing.Point(173, 37)
        Me.idPacienteTxt.Name = "idPacienteTxt"
        Me.idPacienteTxt.Size = New System.Drawing.Size(100, 20)
        Me.idPacienteTxt.TabIndex = 4
        '
        'nomCteTxt
        '
        Me.nomCteTxt.Enabled = False
        Me.nomCteTxt.Location = New System.Drawing.Point(158, 76)
        Me.nomCteTxt.Name = "nomCteTxt"
        Me.nomCteTxt.Size = New System.Drawing.Size(117, 20)
        Me.nomCteTxt.TabIndex = 5
        '
        'dirCteTxt
        '
        Me.dirCteTxt.Enabled = False
        Me.dirCteTxt.Location = New System.Drawing.Point(347, 76)
        Me.dirCteTxt.Name = "dirCteTxt"
        Me.dirCteTxt.Size = New System.Drawing.Size(117, 20)
        Me.dirCteTxt.TabIndex = 6
        '
        'telCteTxt
        '
        Me.telCteTxt.Enabled = False
        Me.telCteTxt.Location = New System.Drawing.Point(527, 76)
        Me.telCteTxt.Name = "telCteTxt"
        Me.telCteTxt.Size = New System.Drawing.Size(117, 20)
        Me.telCteTxt.TabIndex = 7
        '
        'txtIdEsp
        '
        Me.txtIdEsp.Enabled = False
        Me.txtIdEsp.Location = New System.Drawing.Point(303, 154)
        Me.txtIdEsp.Name = "txtIdEsp"
        Me.txtIdEsp.Size = New System.Drawing.Size(100, 20)
        Me.txtIdEsp.TabIndex = 8
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(105, 79)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(47, 13)
        Me.Label3.TabIndex = 9
        Me.Label3.Text = "Nombre:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(290, 79)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(55, 13)
        Me.Label4.TabIndex = 10
        Me.Label4.Text = "Direccion:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(470, 79)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(51, 17)
        Me.Label5.TabIndex = 11
        Me.Label5.Text = "Telefono:"
        Me.Label5.UseCompatibleTextRendering = True
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(39, 120)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(108, 13)
        Me.Label6.TabIndex = 12
        Me.Label6.Text = "Datos de la atención:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(46, 156)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(70, 13)
        Me.Label7.TabIndex = 13
        Me.Label7.Text = "Área Medica:"
        '
        'cmbEspecialidad
        '
        Me.cmbEspecialidad.FormattingEnabled = True
        Me.cmbEspecialidad.Location = New System.Drawing.Point(122, 153)
        Me.cmbEspecialidad.Name = "cmbEspecialidad"
        Me.cmbEspecialidad.Size = New System.Drawing.Size(121, 21)
        Me.cmbEspecialidad.TabIndex = 14
        '
        'idLabel
        '
        Me.idLabel.AutoSize = True
        Me.idLabel.Location = New System.Drawing.Point(270, 157)
        Me.idLabel.Name = "idLabel"
        Me.idLabel.Size = New System.Drawing.Size(18, 13)
        Me.idLabel.TabIndex = 15
        Me.idLabel.Text = "ID"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(46, 200)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(45, 13)
        Me.Label8.TabIndex = 16
        Me.Label8.Text = "Médico:"
        '
        'cmbMedico
        '
        Me.cmbMedico.FormattingEnabled = True
        Me.cmbMedico.Location = New System.Drawing.Point(122, 197)
        Me.cmbMedico.Name = "cmbMedico"
        Me.cmbMedico.Size = New System.Drawing.Size(121, 21)
        Me.cmbMedico.TabIndex = 17
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(270, 200)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(18, 13)
        Me.Label9.TabIndex = 19
        Me.Label9.Text = "ID"
        '
        'txtIdMed
        '
        Me.txtIdMed.Enabled = False
        Me.txtIdMed.Location = New System.Drawing.Point(303, 197)
        Me.txtIdMed.Name = "txtIdMed"
        Me.txtIdMed.Size = New System.Drawing.Size(100, 20)
        Me.txtIdMed.TabIndex = 18
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(440, 241)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(18, 13)
        Me.Label10.TabIndex = 23
        Me.Label10.Text = "ID"
        '
        'txtIdAct
        '
        Me.txtIdAct.Enabled = False
        Me.txtIdAct.Location = New System.Drawing.Point(473, 238)
        Me.txtIdAct.Name = "txtIdAct"
        Me.txtIdAct.Size = New System.Drawing.Size(100, 20)
        Me.txtIdAct.TabIndex = 22
        '
        'cmbActividad
        '
        Me.cmbActividad.FormattingEnabled = True
        Me.cmbActividad.Location = New System.Drawing.Point(122, 238)
        Me.cmbActividad.Name = "cmbActividad"
        Me.cmbActividad.Size = New System.Drawing.Size(304, 21)
        Me.cmbActividad.TabIndex = 21
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(46, 241)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(54, 13)
        Me.Label11.TabIndex = 20
        Me.Label11.Text = "Actividad:"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(45, 290)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(40, 13)
        Me.Label12.TabIndex = 24
        Me.Label12.Text = "Fecha:"
        '
        'cmbDia
        '
        Me.cmbDia.FormattingEnabled = True
        Me.cmbDia.Location = New System.Drawing.Point(139, 287)
        Me.cmbDia.Name = "cmbDia"
        Me.cmbDia.Size = New System.Drawing.Size(36, 21)
        Me.cmbDia.TabIndex = 25
        Me.cmbDia.Text = "23"
        '
        'cmbMes
        '
        Me.cmbMes.FormattingEnabled = True
        Me.cmbMes.Location = New System.Drawing.Point(223, 287)
        Me.cmbMes.Name = "cmbMes"
        Me.cmbMes.Size = New System.Drawing.Size(36, 21)
        Me.cmbMes.TabIndex = 26
        Me.cmbMes.Text = "06"
        '
        'cmbAnio
        '
        Me.cmbAnio.FormattingEnabled = True
        Me.cmbAnio.Location = New System.Drawing.Point(299, 287)
        Me.cmbAnio.Name = "cmbAnio"
        Me.cmbAnio.Size = New System.Drawing.Size(46, 21)
        Me.cmbAnio.TabIndex = 27
        Me.cmbAnio.Text = "2024"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(107, 290)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(26, 13)
        Me.Label13.TabIndex = 28
        Me.Label13.Text = "Dia:"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(187, 290)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(30, 13)
        Me.Label14.TabIndex = 29
        Me.Label14.Text = "Mes:"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(266, 290)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(29, 13)
        Me.Label15.TabIndex = 30
        Me.Label15.Text = "Año:"
        '
        'ingresarBtn
        '
        Me.ingresarBtn.Location = New System.Drawing.Point(446, 323)
        Me.ingresarBtn.Name = "ingresarBtn"
        Me.ingresarBtn.Size = New System.Drawing.Size(127, 29)
        Me.ingresarBtn.TabIndex = 31
        Me.ingresarBtn.Text = "Ingresar Atención"
        Me.ingresarBtn.UseVisualStyleBackColor = True
        '
        'listarAtencionesBtn
        '
        Me.listarAtencionesBtn.Location = New System.Drawing.Point(592, 323)
        Me.listarAtencionesBtn.Name = "listarAtencionesBtn"
        Me.listarAtencionesBtn.Size = New System.Drawing.Size(127, 29)
        Me.listarAtencionesBtn.TabIndex = 33
        Me.listarAtencionesBtn.Text = "Listar Atenciones"
        Me.listarAtencionesBtn.UseVisualStyleBackColor = True
        '
        'atePorFechaBtn
        '
        Me.atePorFechaBtn.Location = New System.Drawing.Point(48, 323)
        Me.atePorFechaBtn.Name = "atePorFechaBtn"
        Me.atePorFechaBtn.Size = New System.Drawing.Size(127, 29)
        Me.atePorFechaBtn.TabIndex = 34
        Me.atePorFechaBtn.Text = "Atenciones de la fecha"
        Me.atePorFechaBtn.UseVisualStyleBackColor = True
        '
        'datosPacBtn
        '
        Me.datosPacBtn.Location = New System.Drawing.Point(299, 32)
        Me.datosPacBtn.Name = "datosPacBtn"
        Me.datosPacBtn.Size = New System.Drawing.Size(127, 29)
        Me.datosPacBtn.TabIndex = 35
        Me.datosPacBtn.Text = "Cargar datos"
        Me.datosPacBtn.UseVisualStyleBackColor = True
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(483, 40)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(38, 13)
        Me.Label16.TabIndex = 36
        Me.Label16.Text = "Edad: "
        '
        'edadCteTxt
        '
        Me.edadCteTxt.Enabled = False
        Me.edadCteTxt.Location = New System.Drawing.Point(527, 37)
        Me.edadCteTxt.Name = "edadCteTxt"
        Me.edadCteTxt.Size = New System.Drawing.Size(117, 20)
        Me.edadCteTxt.TabIndex = 37
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(42, 13)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(63, 13)
        Me.Label17.TabIndex = 38
        Me.Label17.Text = "Atención N:"
        '
        'txtIdAte
        '
        Me.txtIdAte.Location = New System.Drawing.Point(111, 10)
        Me.txtIdAte.Name = "txtIdAte"
        Me.txtIdAte.Size = New System.Drawing.Size(100, 20)
        Me.txtIdAte.TabIndex = 39
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(773, 615)
        Me.Controls.Add(Me.txtIdAte)
        Me.Controls.Add(Me.Label17)
        Me.Controls.Add(Me.edadCteTxt)
        Me.Controls.Add(Me.Label16)
        Me.Controls.Add(Me.datosPacBtn)
        Me.Controls.Add(Me.atePorFechaBtn)
        Me.Controls.Add(Me.listarAtencionesBtn)
        Me.Controls.Add(Me.ingresarBtn)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.cmbAnio)
        Me.Controls.Add(Me.cmbMes)
        Me.Controls.Add(Me.cmbDia)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.txtIdAct)
        Me.Controls.Add(Me.cmbActividad)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.txtIdMed)
        Me.Controls.Add(Me.cmbMedico)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.idLabel)
        Me.Controls.Add(Me.cmbEspecialidad)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtIdEsp)
        Me.Controls.Add(Me.telCteTxt)
        Me.Controls.Add(Me.dirCteTxt)
        Me.Controls.Add(Me.nomCteTxt)
        Me.Controls.Add(Me.idPacienteTxt)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.dgvAtenciones)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.dgvAtenciones, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents dgvAtenciones As DataGridView
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents idPacienteTxt As TextBox
    Friend WithEvents nomCteTxt As TextBox
    Friend WithEvents dirCteTxt As TextBox
    Friend WithEvents telCteTxt As TextBox
    Friend WithEvents txtIdEsp As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents cmbEspecialidad As ComboBox
    Friend WithEvents idLabel As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents cmbMedico As ComboBox
    Friend WithEvents Label9 As Label
    Friend WithEvents txtIdMed As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents txtIdAct As TextBox
    Friend WithEvents cmbActividad As ComboBox
    Friend WithEvents Label11 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents cmbDia As ComboBox
    Friend WithEvents cmbMes As ComboBox
    Friend WithEvents cmbAnio As ComboBox
    Friend WithEvents Label13 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents ingresarBtn As Button
    Friend WithEvents listarAtencionesBtn As Button
    Friend WithEvents atePorFechaBtn As Button
    Friend WithEvents datosPacBtn As Button
    Friend WithEvents Label16 As Label
    Friend WithEvents edadCteTxt As TextBox
    Friend WithEvents Label17 As Label
    Friend WithEvents txtIdAte As TextBox
End Class
