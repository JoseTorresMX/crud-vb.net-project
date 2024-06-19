<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frm_Empleado
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
        Me.lblID_guna2 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.lblNombre_guna2 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.lblApellidos_guna2 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.Guna2TextBox1 = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Guna2TextBox2 = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Guna2TextBox3 = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Guna2TextBox4 = New Guna.UI2.WinForms.Guna2TextBox()
        Me.lblDireccion_guna2 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.Guna2PictureBox1 = New Guna.UI2.WinForms.Guna2PictureBox()
        Me.pboxReferencia_guna2 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.btngradNuevoReg_guna2 = New Guna.UI2.WinForms.Guna2GradientButton()
        Me.Guna2Button1 = New Guna.UI2.WinForms.Guna2Button()
        Me.btnVerReg_guna2 = New Guna.UI2.WinForms.Guna2Button()
        Me.linklblSeleccionar = New System.Windows.Forms.LinkLabel()
        Me.ofdReferencia = New System.Windows.Forms.OpenFileDialog()
        CType(Me.Guna2PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblID_guna2
        '
        Me.lblID_guna2.BackColor = System.Drawing.Color.Transparent
        Me.lblID_guna2.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblID_guna2.ForeColor = System.Drawing.Color.White
        Me.lblID_guna2.Location = New System.Drawing.Point(74, 18)
        Me.lblID_guna2.Name = "lblID_guna2"
        Me.lblID_guna2.Size = New System.Drawing.Size(24, 23)
        Me.lblID_guna2.TabIndex = 0
        Me.lblID_guna2.Text = "ID:"
        '
        'lblNombre_guna2
        '
        Me.lblNombre_guna2.BackColor = System.Drawing.Color.Transparent
        Me.lblNombre_guna2.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNombre_guna2.ForeColor = System.Drawing.Color.White
        Me.lblNombre_guna2.Location = New System.Drawing.Point(9, 66)
        Me.lblNombre_guna2.Name = "lblNombre_guna2"
        Me.lblNombre_guna2.Size = New System.Drawing.Size(88, 23)
        Me.lblNombre_guna2.TabIndex = 1
        Me.lblNombre_guna2.Text = "Nombre(s):"
        '
        'lblApellidos_guna2
        '
        Me.lblApellidos_guna2.BackColor = System.Drawing.Color.Transparent
        Me.lblApellidos_guna2.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblApellidos_guna2.ForeColor = System.Drawing.Color.White
        Me.lblApellidos_guna2.Location = New System.Drawing.Point(9, 119)
        Me.lblApellidos_guna2.Name = "lblApellidos_guna2"
        Me.lblApellidos_guna2.Size = New System.Drawing.Size(89, 23)
        Me.lblApellidos_guna2.TabIndex = 2
        Me.lblApellidos_guna2.Text = "Apellido(s):"
        '
        'Guna2TextBox1
        '
        Me.Guna2TextBox1.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.Guna2TextBox1.DefaultText = ""
        Me.Guna2TextBox1.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.Guna2TextBox1.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.Guna2TextBox1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.Guna2TextBox1.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.Guna2TextBox1.Enabled = False
        Me.Guna2TextBox1.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Guna2TextBox1.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Guna2TextBox1.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Guna2TextBox1.Location = New System.Drawing.Point(104, 18)
        Me.Guna2TextBox1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Guna2TextBox1.Name = "Guna2TextBox1"
        Me.Guna2TextBox1.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.Guna2TextBox1.PlaceholderText = ""
        Me.Guna2TextBox1.SelectedText = ""
        Me.Guna2TextBox1.Size = New System.Drawing.Size(100, 25)
        Me.Guna2TextBox1.TabIndex = 3
        '
        'Guna2TextBox2
        '
        Me.Guna2TextBox2.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.Guna2TextBox2.DefaultText = ""
        Me.Guna2TextBox2.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.Guna2TextBox2.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.Guna2TextBox2.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.Guna2TextBox2.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.Guna2TextBox2.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Guna2TextBox2.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Guna2TextBox2.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Guna2TextBox2.Location = New System.Drawing.Point(103, 66)
        Me.Guna2TextBox2.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Guna2TextBox2.Name = "Guna2TextBox2"
        Me.Guna2TextBox2.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.Guna2TextBox2.PlaceholderText = ""
        Me.Guna2TextBox2.SelectedText = ""
        Me.Guna2TextBox2.Size = New System.Drawing.Size(150, 25)
        Me.Guna2TextBox2.TabIndex = 4
        '
        'Guna2TextBox3
        '
        Me.Guna2TextBox3.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.Guna2TextBox3.DefaultText = ""
        Me.Guna2TextBox3.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.Guna2TextBox3.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.Guna2TextBox3.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.Guna2TextBox3.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.Guna2TextBox3.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Guna2TextBox3.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Guna2TextBox3.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Guna2TextBox3.Location = New System.Drawing.Point(104, 119)
        Me.Guna2TextBox3.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Guna2TextBox3.Name = "Guna2TextBox3"
        Me.Guna2TextBox3.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.Guna2TextBox3.PlaceholderText = ""
        Me.Guna2TextBox3.SelectedText = ""
        Me.Guna2TextBox3.Size = New System.Drawing.Size(150, 25)
        Me.Guna2TextBox3.TabIndex = 5
        '
        'Guna2TextBox4
        '
        Me.Guna2TextBox4.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.Guna2TextBox4.DefaultText = ""
        Me.Guna2TextBox4.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.Guna2TextBox4.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.Guna2TextBox4.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.Guna2TextBox4.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.Guna2TextBox4.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Guna2TextBox4.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Guna2TextBox4.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Guna2TextBox4.Location = New System.Drawing.Point(104, 168)
        Me.Guna2TextBox4.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Guna2TextBox4.Name = "Guna2TextBox4"
        Me.Guna2TextBox4.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.Guna2TextBox4.PlaceholderText = ""
        Me.Guna2TextBox4.SelectedText = ""
        Me.Guna2TextBox4.Size = New System.Drawing.Size(150, 25)
        Me.Guna2TextBox4.TabIndex = 6
        '
        'lblDireccion_guna2
        '
        Me.lblDireccion_guna2.BackColor = System.Drawing.Color.Transparent
        Me.lblDireccion_guna2.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDireccion_guna2.ForeColor = System.Drawing.Color.White
        Me.lblDireccion_guna2.Location = New System.Drawing.Point(18, 168)
        Me.lblDireccion_guna2.Name = "lblDireccion_guna2"
        Me.lblDireccion_guna2.Size = New System.Drawing.Size(80, 23)
        Me.lblDireccion_guna2.TabIndex = 7
        Me.lblDireccion_guna2.Text = "Dirección:"
        '
        'Guna2PictureBox1
        '
        Me.Guna2PictureBox1.ImageRotate = 0!
        Me.Guna2PictureBox1.Location = New System.Drawing.Point(272, 37)
        Me.Guna2PictureBox1.Name = "Guna2PictureBox1"
        Me.Guna2PictureBox1.Size = New System.Drawing.Size(300, 200)
        Me.Guna2PictureBox1.TabIndex = 8
        Me.Guna2PictureBox1.TabStop = False
        '
        'pboxReferencia_guna2
        '
        Me.pboxReferencia_guna2.BackColor = System.Drawing.Color.Transparent
        Me.pboxReferencia_guna2.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.pboxReferencia_guna2.ForeColor = System.Drawing.Color.White
        Me.pboxReferencia_guna2.Location = New System.Drawing.Point(274, 11)
        Me.pboxReferencia_guna2.Name = "pboxReferencia_guna2"
        Me.pboxReferencia_guna2.Size = New System.Drawing.Size(91, 23)
        Me.pboxReferencia_guna2.TabIndex = 9
        Me.pboxReferencia_guna2.Text = "Referencia:"
        '
        'btngradNuevoReg_guna2
        '
        Me.btngradNuevoReg_guna2.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(18, Byte), Integer), CType(CType(77, Byte), Integer))
        Me.btngradNuevoReg_guna2.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btngradNuevoReg_guna2.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btngradNuevoReg_guna2.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btngradNuevoReg_guna2.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btngradNuevoReg_guna2.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btngradNuevoReg_guna2.FillColor = System.Drawing.Color.FromArgb(CType(CType(112, Byte), Integer), CType(CType(187, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btngradNuevoReg_guna2.FillColor2 = System.Drawing.Color.FromArgb(CType(CType(112, Byte), Integer), CType(CType(187, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btngradNuevoReg_guna2.Font = New System.Drawing.Font("Century Gothic", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btngradNuevoReg_guna2.ForeColor = System.Drawing.Color.Black
        Me.btngradNuevoReg_guna2.Location = New System.Drawing.Point(16, 285)
        Me.btngradNuevoReg_guna2.Name = "btngradNuevoReg_guna2"
        Me.btngradNuevoReg_guna2.Size = New System.Drawing.Size(160, 50)
        Me.btngradNuevoReg_guna2.TabIndex = 10
        Me.btngradNuevoReg_guna2.Text = "Nuevo"
        '
        'Guna2Button1
        '
        Me.Guna2Button1.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.Guna2Button1.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.Guna2Button1.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.Guna2Button1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.Guna2Button1.FillColor = System.Drawing.Color.FromArgb(CType(CType(112, Byte), Integer), CType(CType(187, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Guna2Button1.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2Button1.ForeColor = System.Drawing.Color.Black
        Me.Guna2Button1.Location = New System.Drawing.Point(214, 285)
        Me.Guna2Button1.Name = "Guna2Button1"
        Me.Guna2Button1.Size = New System.Drawing.Size(160, 50)
        Me.Guna2Button1.TabIndex = 11
        Me.Guna2Button1.Text = "Guardar"
        '
        'btnVerReg_guna2
        '
        Me.btnVerReg_guna2.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnVerReg_guna2.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnVerReg_guna2.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnVerReg_guna2.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnVerReg_guna2.FillColor = System.Drawing.Color.FromArgb(CType(CType(254, Byte), Integer), CType(CType(251, Byte), Integer), CType(CType(243, Byte), Integer))
        Me.btnVerReg_guna2.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnVerReg_guna2.ForeColor = System.Drawing.Color.Black
        Me.btnVerReg_guna2.Location = New System.Drawing.Point(400, 285)
        Me.btnVerReg_guna2.Name = "btnVerReg_guna2"
        Me.btnVerReg_guna2.Size = New System.Drawing.Size(160, 50)
        Me.btnVerReg_guna2.TabIndex = 12
        Me.btnVerReg_guna2.Text = "Ver registros"
        '
        'linklblSeleccionar
        '
        Me.linklblSeleccionar.AutoSize = True
        Me.linklblSeleccionar.LinkColor = System.Drawing.Color.Transparent
        Me.linklblSeleccionar.Location = New System.Drawing.Point(270, 241)
        Me.linklblSeleccionar.Name = "linklblSeleccionar"
        Me.linklblSeleccionar.Size = New System.Drawing.Size(100, 21)
        Me.linklblSeleccionar.TabIndex = 13
        Me.linklblSeleccionar.TabStop = True
        Me.linklblSeleccionar.Text = "Seleccionar"
        '
        'ofdReferencia
        '
        Me.ofdReferencia.FileName = "openReferencia"
        '
        'frm_Empleado
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 21.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(113, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(584, 361)
        Me.Controls.Add(Me.linklblSeleccionar)
        Me.Controls.Add(Me.btnVerReg_guna2)
        Me.Controls.Add(Me.Guna2Button1)
        Me.Controls.Add(Me.btngradNuevoReg_guna2)
        Me.Controls.Add(Me.pboxReferencia_guna2)
        Me.Controls.Add(Me.Guna2PictureBox1)
        Me.Controls.Add(Me.lblDireccion_guna2)
        Me.Controls.Add(Me.Guna2TextBox4)
        Me.Controls.Add(Me.Guna2TextBox3)
        Me.Controls.Add(Me.Guna2TextBox2)
        Me.Controls.Add(Me.Guna2TextBox1)
        Me.Controls.Add(Me.lblApellidos_guna2)
        Me.Controls.Add(Me.lblNombre_guna2)
        Me.Controls.Add(Me.lblID_guna2)
        Me.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.SystemColors.ControlLight
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.MaximumSize = New System.Drawing.Size(600, 600)
        Me.MinimumSize = New System.Drawing.Size(400, 400)
        Me.Name = "frm_Empleado"
        Me.Text = "Sistema de Registros VB.NET v1.0.0.0"
        CType(Me.Guna2PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblID_guna2 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents lblNombre_guna2 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents lblApellidos_guna2 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents Guna2TextBox1 As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Guna2TextBox2 As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Guna2TextBox3 As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Guna2TextBox4 As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents lblDireccion_guna2 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents Guna2PictureBox1 As Guna.UI2.WinForms.Guna2PictureBox
    Friend WithEvents pboxReferencia_guna2 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents btngradNuevoReg_guna2 As Guna.UI2.WinForms.Guna2GradientButton
    Friend WithEvents Guna2Button1 As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btnVerReg_guna2 As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents linklblSeleccionar As LinkLabel
    Friend WithEvents ofdReferencia As OpenFileDialog
End Class
