<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ArreglosVectores
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
        Me.PanelSuperior = New System.Windows.Forms.Panel()
        Me.btnCerrar = New System.Windows.Forms.Button()
        Me.lbTitulo = New System.Windows.Forms.Label()
        Me.PanelTrabajo = New System.Windows.Forms.Panel()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.btnLimpiarVenta = New System.Windows.Forms.Button()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtVender = New System.Windows.Forms.TextBox()
        Me.btnVender = New System.Windows.Forms.Button()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.cmbSolicitar = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtCant = New System.Windows.Forms.TextBox()
        Me.btnSolicitar = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtModelo = New System.Windows.Forms.TextBox()
        Me.txtCantidad = New System.Windows.Forms.TextBox()
        Me.txtPrecio = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtMarca = New System.Windows.Forms.TextBox()
        Me.btnBuscar = New System.Windows.Forms.Button()
        Me.gbDinamico = New System.Windows.Forms.GroupBox()
        Me.lbComputadoras = New System.Windows.Forms.Label()
        Me.txtCanComputadora = New System.Windows.Forms.TextBox()
        Me.btnRegistrar = New System.Windows.Forms.Button()
        Me.gbUnidimensional = New System.Windows.Forms.GroupBox()
        Me.btnLimpiar = New System.Windows.Forms.Button()
        Me.cmbPrecios = New System.Windows.Forms.ComboBox()
        Me.cmbComputadoras = New System.Windows.Forms.ComboBox()
        Me.btnPrecios = New System.Windows.Forms.Button()
        Me.btnGenerar = New System.Windows.Forms.Button()
        Me.btnLimpiarRegistro = New System.Windows.Forms.Button()
        Me.PanelSuperior.SuspendLayout()
        Me.PanelTrabajo.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.gbDinamico.SuspendLayout()
        Me.gbUnidimensional.SuspendLayout()
        Me.SuspendLayout()
        '
        'PanelSuperior
        '
        Me.PanelSuperior.BackColor = System.Drawing.Color.Fuchsia
        Me.PanelSuperior.Controls.Add(Me.btnCerrar)
        Me.PanelSuperior.Controls.Add(Me.lbTitulo)
        Me.PanelSuperior.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelSuperior.Location = New System.Drawing.Point(0, 0)
        Me.PanelSuperior.Name = "PanelSuperior"
        Me.PanelSuperior.Size = New System.Drawing.Size(800, 40)
        Me.PanelSuperior.TabIndex = 1
        '
        'btnCerrar
        '
        Me.btnCerrar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnCerrar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnCerrar.FlatAppearance.BorderSize = 0
        Me.btnCerrar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver
        Me.btnCerrar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Yellow
        Me.btnCerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCerrar.Image = Global.MiMenuPersonalizado.My.Resources.Resources.Icono_cerrar_FN
        Me.btnCerrar.Location = New System.Drawing.Point(760, 0)
        Me.btnCerrar.Name = "btnCerrar"
        Me.btnCerrar.Size = New System.Drawing.Size(40, 40)
        Me.btnCerrar.TabIndex = 6
        Me.btnCerrar.UseVisualStyleBackColor = True
        '
        'lbTitulo
        '
        Me.lbTitulo.AutoSize = True
        Me.lbTitulo.Font = New System.Drawing.Font("Georgia", 14.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbTitulo.Location = New System.Drawing.Point(285, 9)
        Me.lbTitulo.Name = "lbTitulo"
        Me.lbTitulo.Size = New System.Drawing.Size(206, 23)
        Me.lbTitulo.TabIndex = 0
        Me.lbTitulo.Text = "Arreglos Y Vectores"
        '
        'PanelTrabajo
        '
        Me.PanelTrabajo.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.PanelTrabajo.Controls.Add(Me.GroupBox3)
        Me.PanelTrabajo.Controls.Add(Me.GroupBox2)
        Me.PanelTrabajo.Controls.Add(Me.GroupBox1)
        Me.PanelTrabajo.Controls.Add(Me.gbDinamico)
        Me.PanelTrabajo.Controls.Add(Me.gbUnidimensional)
        Me.PanelTrabajo.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelTrabajo.Location = New System.Drawing.Point(0, 40)
        Me.PanelTrabajo.Name = "PanelTrabajo"
        Me.PanelTrabajo.Size = New System.Drawing.Size(800, 410)
        Me.PanelTrabajo.TabIndex = 2
        '
        'GroupBox3
        '
        Me.GroupBox3.BackgroundImage = Global.MiMenuPersonalizado.My.Resources.Resources.azul
        Me.GroupBox3.Controls.Add(Me.btnLimpiarVenta)
        Me.GroupBox3.Controls.Add(Me.Label6)
        Me.GroupBox3.Controls.Add(Me.txtVender)
        Me.GroupBox3.Controls.Add(Me.btnVender)
        Me.GroupBox3.Font = New System.Drawing.Font("Georgia", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox3.Location = New System.Drawing.Point(408, 301)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(309, 97)
        Me.GroupBox3.TabIndex = 6
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Registro"
        '
        'btnLimpiarVenta
        '
        Me.btnLimpiarVenta.BackColor = System.Drawing.Color.Fuchsia
        Me.btnLimpiarVenta.Location = New System.Drawing.Point(177, 65)
        Me.btnLimpiarVenta.Name = "btnLimpiarVenta"
        Me.btnLimpiarVenta.Size = New System.Drawing.Size(112, 26)
        Me.btnLimpiarVenta.TabIndex = 6
        Me.btnLimpiarVenta.Text = "Limpiar Venta"
        Me.btnLimpiarVenta.UseVisualStyleBackColor = False
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label6.Location = New System.Drawing.Point(20, 29)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(84, 16)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "Can. Vender"
        '
        'txtVender
        '
        Me.txtVender.Location = New System.Drawing.Point(123, 26)
        Me.txtVender.Name = "txtVender"
        Me.txtVender.Size = New System.Drawing.Size(105, 22)
        Me.txtVender.TabIndex = 4
        '
        'btnVender
        '
        Me.btnVender.BackColor = System.Drawing.Color.Fuchsia
        Me.btnVender.Location = New System.Drawing.Point(67, 65)
        Me.btnVender.Name = "btnVender"
        Me.btnVender.Size = New System.Drawing.Size(85, 26)
        Me.btnVender.TabIndex = 2
        Me.btnVender.Text = "Vender"
        Me.btnVender.UseVisualStyleBackColor = False
        '
        'GroupBox2
        '
        Me.GroupBox2.BackgroundImage = Global.MiMenuPersonalizado.My.Resources.Resources.azul
        Me.GroupBox2.Controls.Add(Me.cmbSolicitar)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Controls.Add(Me.txtCant)
        Me.GroupBox2.Controls.Add(Me.btnSolicitar)
        Me.GroupBox2.Font = New System.Drawing.Font("Georgia", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(27, 218)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(309, 166)
        Me.GroupBox2.TabIndex = 6
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Dinamico"
        '
        'cmbSolicitar
        '
        Me.cmbSolicitar.FormattingEnabled = True
        Me.cmbSolicitar.Location = New System.Drawing.Point(62, 124)
        Me.cmbSolicitar.Name = "cmbSolicitar"
        Me.cmbSolicitar.Size = New System.Drawing.Size(159, 24)
        Me.cmbSolicitar.TabIndex = 6
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label5.Location = New System.Drawing.Point(8, 40)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(129, 16)
        Me.Label5.TabIndex = 5
        Me.Label5.Text = "Can. Computadoras"
        '
        'txtCant
        '
        Me.txtCant.Location = New System.Drawing.Point(141, 37)
        Me.txtCant.Name = "txtCant"
        Me.txtCant.Size = New System.Drawing.Size(105, 22)
        Me.txtCant.TabIndex = 4
        '
        'btnSolicitar
        '
        Me.btnSolicitar.BackColor = System.Drawing.Color.Fuchsia
        Me.btnSolicitar.Location = New System.Drawing.Point(93, 83)
        Me.btnSolicitar.Name = "btnSolicitar"
        Me.btnSolicitar.Size = New System.Drawing.Size(98, 35)
        Me.btnSolicitar.TabIndex = 2
        Me.btnSolicitar.Text = "Solicitar"
        Me.btnSolicitar.UseVisualStyleBackColor = False
        '
        'GroupBox1
        '
        Me.GroupBox1.BackgroundImage = Global.MiMenuPersonalizado.My.Resources.Resources.azul
        Me.GroupBox1.Controls.Add(Me.btnLimpiarRegistro)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.txtModelo)
        Me.GroupBox1.Controls.Add(Me.txtCantidad)
        Me.GroupBox1.Controls.Add(Me.txtPrecio)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.txtMarca)
        Me.GroupBox1.Controls.Add(Me.btnBuscar)
        Me.GroupBox1.Font = New System.Drawing.Font("Georgia", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(408, 119)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(309, 172)
        Me.GroupBox1.TabIndex = 6
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Registro"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label4.Location = New System.Drawing.Point(6, 65)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(55, 16)
        Me.Label4.TabIndex = 11
        Me.Label4.Text = "Modelo"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label3.Location = New System.Drawing.Point(6, 99)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(48, 16)
        Me.Label3.TabIndex = 10
        Me.Label3.Text = "Precio"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label2.Location = New System.Drawing.Point(6, 136)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(63, 16)
        Me.Label2.TabIndex = 9
        Me.Label2.Text = "Cantidad"
        '
        'txtModelo
        '
        Me.txtModelo.Location = New System.Drawing.Point(67, 62)
        Me.txtModelo.Name = "txtModelo"
        Me.txtModelo.Size = New System.Drawing.Size(103, 22)
        Me.txtModelo.TabIndex = 8
        '
        'txtCantidad
        '
        Me.txtCantidad.Location = New System.Drawing.Point(67, 133)
        Me.txtCantidad.Name = "txtCantidad"
        Me.txtCantidad.Size = New System.Drawing.Size(103, 22)
        Me.txtCantidad.TabIndex = 7
        '
        'txtPrecio
        '
        Me.txtPrecio.Location = New System.Drawing.Point(67, 96)
        Me.txtPrecio.Name = "txtPrecio"
        Me.txtPrecio.Size = New System.Drawing.Size(103, 22)
        Me.txtPrecio.TabIndex = 6
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label1.Location = New System.Drawing.Point(7, 28)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(47, 16)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Marca"
        '
        'txtMarca
        '
        Me.txtMarca.Location = New System.Drawing.Point(67, 25)
        Me.txtMarca.Name = "txtMarca"
        Me.txtMarca.Size = New System.Drawing.Size(103, 22)
        Me.txtMarca.TabIndex = 4
        '
        'btnBuscar
        '
        Me.btnBuscar.BackColor = System.Drawing.Color.Fuchsia
        Me.btnBuscar.Location = New System.Drawing.Point(198, 34)
        Me.btnBuscar.Name = "btnBuscar"
        Me.btnBuscar.Size = New System.Drawing.Size(78, 50)
        Me.btnBuscar.TabIndex = 2
        Me.btnBuscar.Text = "Buscar"
        Me.btnBuscar.UseVisualStyleBackColor = False
        '
        'gbDinamico
        '
        Me.gbDinamico.BackgroundImage = Global.MiMenuPersonalizado.My.Resources.Resources.azul
        Me.gbDinamico.Controls.Add(Me.lbComputadoras)
        Me.gbDinamico.Controls.Add(Me.txtCanComputadora)
        Me.gbDinamico.Controls.Add(Me.btnRegistrar)
        Me.gbDinamico.Font = New System.Drawing.Font("Georgia", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbDinamico.Location = New System.Drawing.Point(408, 16)
        Me.gbDinamico.Name = "gbDinamico"
        Me.gbDinamico.Size = New System.Drawing.Size(309, 97)
        Me.gbDinamico.TabIndex = 1
        Me.gbDinamico.TabStop = False
        Me.gbDinamico.Text = "Registro"
        '
        'lbComputadoras
        '
        Me.lbComputadoras.AutoSize = True
        Me.lbComputadoras.BackColor = System.Drawing.Color.Transparent
        Me.lbComputadoras.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.lbComputadoras.Location = New System.Drawing.Point(6, 29)
        Me.lbComputadoras.Name = "lbComputadoras"
        Me.lbComputadoras.Size = New System.Drawing.Size(129, 16)
        Me.lbComputadoras.TabIndex = 5
        Me.lbComputadoras.Text = "Can. Computadoras"
        '
        'txtCanComputadora
        '
        Me.txtCanComputadora.Location = New System.Drawing.Point(141, 26)
        Me.txtCanComputadora.Name = "txtCanComputadora"
        Me.txtCanComputadora.Size = New System.Drawing.Size(105, 22)
        Me.txtCanComputadora.TabIndex = 4
        '
        'btnRegistrar
        '
        Me.btnRegistrar.BackColor = System.Drawing.Color.Fuchsia
        Me.btnRegistrar.Location = New System.Drawing.Point(100, 59)
        Me.btnRegistrar.Name = "btnRegistrar"
        Me.btnRegistrar.Size = New System.Drawing.Size(85, 26)
        Me.btnRegistrar.TabIndex = 2
        Me.btnRegistrar.Text = "Registrar"
        Me.btnRegistrar.UseVisualStyleBackColor = False
        '
        'gbUnidimensional
        '
        Me.gbUnidimensional.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.gbUnidimensional.BackgroundImage = Global.MiMenuPersonalizado.My.Resources.Resources.azul
        Me.gbUnidimensional.Controls.Add(Me.btnLimpiar)
        Me.gbUnidimensional.Controls.Add(Me.cmbPrecios)
        Me.gbUnidimensional.Controls.Add(Me.cmbComputadoras)
        Me.gbUnidimensional.Controls.Add(Me.btnPrecios)
        Me.gbUnidimensional.Controls.Add(Me.btnGenerar)
        Me.gbUnidimensional.Font = New System.Drawing.Font("Georgia", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbUnidimensional.Location = New System.Drawing.Point(27, 16)
        Me.gbUnidimensional.Name = "gbUnidimensional"
        Me.gbUnidimensional.Size = New System.Drawing.Size(309, 173)
        Me.gbUnidimensional.TabIndex = 0
        Me.gbUnidimensional.TabStop = False
        Me.gbUnidimensional.Text = "Unidimensionales"
        '
        'btnLimpiar
        '
        Me.btnLimpiar.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnLimpiar.Location = New System.Drawing.Point(93, 124)
        Me.btnLimpiar.Name = "btnLimpiar"
        Me.btnLimpiar.Size = New System.Drawing.Size(98, 30)
        Me.btnLimpiar.TabIndex = 5
        Me.btnLimpiar.Text = "Limpiar"
        Me.btnLimpiar.UseVisualStyleBackColor = False
        '
        'cmbPrecios
        '
        Me.cmbPrecios.FormattingEnabled = True
        Me.cmbPrecios.Location = New System.Drawing.Point(161, 84)
        Me.cmbPrecios.Name = "cmbPrecios"
        Me.cmbPrecios.Size = New System.Drawing.Size(114, 24)
        Me.cmbPrecios.TabIndex = 4
        '
        'cmbComputadoras
        '
        Me.cmbComputadoras.FormattingEnabled = True
        Me.cmbComputadoras.Location = New System.Drawing.Point(23, 84)
        Me.cmbComputadoras.Name = "cmbComputadoras"
        Me.cmbComputadoras.Size = New System.Drawing.Size(114, 24)
        Me.cmbComputadoras.TabIndex = 2
        '
        'btnPrecios
        '
        Me.btnPrecios.BackColor = System.Drawing.Color.Yellow
        Me.btnPrecios.Location = New System.Drawing.Point(171, 29)
        Me.btnPrecios.Name = "btnPrecios"
        Me.btnPrecios.Size = New System.Drawing.Size(92, 49)
        Me.btnPrecios.TabIndex = 1
        Me.btnPrecios.Text = "Generar Precios"
        Me.btnPrecios.UseVisualStyleBackColor = False
        '
        'btnGenerar
        '
        Me.btnGenerar.BackColor = System.Drawing.Color.Yellow
        Me.btnGenerar.Location = New System.Drawing.Point(23, 29)
        Me.btnGenerar.Name = "btnGenerar"
        Me.btnGenerar.Size = New System.Drawing.Size(114, 49)
        Me.btnGenerar.TabIndex = 0
        Me.btnGenerar.Text = "Generar Computadoras"
        Me.btnGenerar.UseVisualStyleBackColor = False
        '
        'btnLimpiarRegistro
        '
        Me.btnLimpiarRegistro.BackColor = System.Drawing.Color.Fuchsia
        Me.btnLimpiarRegistro.Location = New System.Drawing.Point(198, 96)
        Me.btnLimpiarRegistro.Name = "btnLimpiarRegistro"
        Me.btnLimpiarRegistro.Size = New System.Drawing.Size(78, 50)
        Me.btnLimpiarRegistro.TabIndex = 12
        Me.btnLimpiarRegistro.Text = "Limpiar Registro"
        Me.btnLimpiarRegistro.UseVisualStyleBackColor = False
        '
        'ArreglosVectores
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.PanelTrabajo)
        Me.Controls.Add(Me.PanelSuperior)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "ArreglosVectores"
        Me.Text = "ArreglosVectores"
        Me.PanelSuperior.ResumeLayout(False)
        Me.PanelSuperior.PerformLayout()
        Me.PanelTrabajo.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.gbDinamico.ResumeLayout(False)
        Me.gbDinamico.PerformLayout()
        Me.gbUnidimensional.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents PanelSuperior As Panel
    Friend WithEvents PanelTrabajo As Panel
    Friend WithEvents lbTitulo As Label
    Friend WithEvents gbUnidimensional As GroupBox
    Friend WithEvents gbDinamico As GroupBox
    Friend WithEvents lbComputadoras As Label
    Friend WithEvents txtCanComputadora As TextBox
    Friend WithEvents btnRegistrar As Button
    Friend WithEvents btnLimpiar As Button
    Friend WithEvents cmbPrecios As ComboBox
    Friend WithEvents cmbComputadoras As ComboBox
    Friend WithEvents btnPrecios As Button
    Friend WithEvents btnGenerar As Button
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents cmbSolicitar As ComboBox
    Friend WithEvents Label5 As Label
    Friend WithEvents txtCant As TextBox
    Friend WithEvents btnSolicitar As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txtModelo As TextBox
    Friend WithEvents txtCantidad As TextBox
    Friend WithEvents txtPrecio As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents txtMarca As TextBox
    Friend WithEvents btnBuscar As Button
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents Label6 As Label
    Friend WithEvents txtVender As TextBox
    Friend WithEvents btnVender As Button
    Friend WithEvents btnCerrar As Button
    Friend WithEvents btnLimpiarVenta As Button
    Friend WithEvents btnLimpiarRegistro As Button
End Class
