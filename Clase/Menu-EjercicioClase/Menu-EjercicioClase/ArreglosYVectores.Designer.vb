<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ArreglosYVectores
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
        Me.PanelSuperior = New System.Windows.Forms.Panel()
        Me.btnMaximizar = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnMinimizar = New System.Windows.Forms.Button()
        Me.btnRestaurar = New System.Windows.Forms.Button()
        Me.btnCerrar = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.cmbPrecios = New System.Windows.Forms.ComboBox()
        Me.cmbGenerar = New System.Windows.Forms.ComboBox()
        Me.btnLimpiar = New System.Windows.Forms.Button()
        Me.btnPrecios = New System.Windows.Forms.Button()
        Me.btnGenerar = New System.Windows.Forms.Button()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.lbVender = New System.Windows.Forms.Label()
        Me.txtVender = New System.Windows.Forms.TextBox()
        Me.btnVender = New System.Windows.Forms.Button()
        Me.btnLimpiarVender = New System.Windows.Forms.Button()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.lbCantidad = New System.Windows.Forms.Label()
        Me.lbPrecio = New System.Windows.Forms.Label()
        Me.lbModelo = New System.Windows.Forms.Label()
        Me.lbMarca = New System.Windows.Forms.Label()
        Me.txtCantidad = New System.Windows.Forms.TextBox()
        Me.txtModelo = New System.Windows.Forms.TextBox()
        Me.txtPrecio = New System.Windows.Forms.TextBox()
        Me.txtMarca = New System.Windows.Forms.TextBox()
        Me.btnBuscar = New System.Windows.Forms.Button()
        Me.btnLimpiarRegistro = New System.Windows.Forms.Button()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.lbCantidadComputadoras = New System.Windows.Forms.Label()
        Me.txtCant = New System.Windows.Forms.TextBox()
        Me.cmbComputadoras = New System.Windows.Forms.ComboBox()
        Me.btnSolicitar = New System.Windows.Forms.Button()
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.lbCantComputadora = New System.Windows.Forms.Label()
        Me.txtCanComputadora = New System.Windows.Forms.TextBox()
        Me.btnRegistrar = New System.Windows.Forms.Button()
        Me.ErrorProvider = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.Informacion = New System.Windows.Forms.ToolTip(Me.components)
        Me.PanelSuperior.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        CType(Me.ErrorProvider, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PanelSuperior
        '
        Me.PanelSuperior.BackColor = System.Drawing.Color.Gold
        Me.PanelSuperior.Controls.Add(Me.btnMaximizar)
        Me.PanelSuperior.Controls.Add(Me.Label1)
        Me.PanelSuperior.Controls.Add(Me.btnMinimizar)
        Me.PanelSuperior.Controls.Add(Me.btnRestaurar)
        Me.PanelSuperior.Controls.Add(Me.btnCerrar)
        Me.PanelSuperior.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelSuperior.Location = New System.Drawing.Point(0, 0)
        Me.PanelSuperior.Name = "PanelSuperior"
        Me.PanelSuperior.Size = New System.Drawing.Size(902, 40)
        Me.PanelSuperior.TabIndex = 1
        '
        'btnMaximizar
        '
        Me.btnMaximizar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnMaximizar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnMaximizar.FlatAppearance.BorderSize = 0
        Me.btnMaximizar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray
        Me.btnMaximizar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black
        Me.btnMaximizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnMaximizar.Image = Global.Menu_EjercicioClase.My.Resources.Resources.Icono_Maximizar
        Me.btnMaximizar.Location = New System.Drawing.Point(815, 0)
        Me.btnMaximizar.Name = "btnMaximizar"
        Me.btnMaximizar.Size = New System.Drawing.Size(41, 40)
        Me.btnMaximizar.TabIndex = 3
        Me.btnMaximizar.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Georgia", 15.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(295, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(227, 25)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Arreglos Y Vectores"
        '
        'btnMinimizar
        '
        Me.btnMinimizar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnMinimizar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnMinimizar.FlatAppearance.BorderSize = 0
        Me.btnMinimizar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray
        Me.btnMinimizar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black
        Me.btnMinimizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnMinimizar.Image = Global.Menu_EjercicioClase.My.Resources.Resources.Icono_Minimizar
        Me.btnMinimizar.Location = New System.Drawing.Point(770, 0)
        Me.btnMinimizar.Name = "btnMinimizar"
        Me.btnMinimizar.Size = New System.Drawing.Size(40, 40)
        Me.btnMinimizar.TabIndex = 2
        Me.btnMinimizar.UseVisualStyleBackColor = True
        '
        'btnRestaurar
        '
        Me.btnRestaurar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnRestaurar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnRestaurar.FlatAppearance.BorderSize = 0
        Me.btnRestaurar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray
        Me.btnRestaurar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black
        Me.btnRestaurar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnRestaurar.Image = Global.Menu_EjercicioClase.My.Resources.Resources.Icono_Restaurar
        Me.btnRestaurar.Location = New System.Drawing.Point(816, 0)
        Me.btnRestaurar.Name = "btnRestaurar"
        Me.btnRestaurar.Size = New System.Drawing.Size(40, 40)
        Me.btnRestaurar.TabIndex = 1
        Me.btnRestaurar.UseVisualStyleBackColor = True
        Me.btnRestaurar.Visible = False
        '
        'btnCerrar
        '
        Me.btnCerrar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnCerrar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnCerrar.FlatAppearance.BorderSize = 0
        Me.btnCerrar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray
        Me.btnCerrar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red
        Me.btnCerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCerrar.Image = Global.Menu_EjercicioClase.My.Resources.Resources.Icono_cerrar_FN
        Me.btnCerrar.Location = New System.Drawing.Point(862, 0)
        Me.btnCerrar.Name = "btnCerrar"
        Me.btnCerrar.Size = New System.Drawing.Size(40, 40)
        Me.btnCerrar.TabIndex = 0
        Me.btnCerrar.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.cmbPrecios)
        Me.GroupBox1.Controls.Add(Me.cmbGenerar)
        Me.GroupBox1.Controls.Add(Me.btnLimpiar)
        Me.GroupBox1.Controls.Add(Me.btnPrecios)
        Me.GroupBox1.Controls.Add(Me.btnGenerar)
        Me.GroupBox1.Font = New System.Drawing.Font("Georgia", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(32, 57)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(346, 205)
        Me.GroupBox1.TabIndex = 3
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Unidimensionales"
        '
        'cmbPrecios
        '
        Me.cmbPrecios.FormattingEnabled = True
        Me.cmbPrecios.Location = New System.Drawing.Point(175, 103)
        Me.cmbPrecios.Name = "cmbPrecios"
        Me.cmbPrecios.Size = New System.Drawing.Size(128, 22)
        Me.cmbPrecios.TabIndex = 7
        '
        'cmbGenerar
        '
        Me.cmbGenerar.FormattingEnabled = True
        Me.cmbGenerar.Location = New System.Drawing.Point(15, 103)
        Me.cmbGenerar.Name = "cmbGenerar"
        Me.cmbGenerar.Size = New System.Drawing.Size(128, 22)
        Me.cmbGenerar.TabIndex = 6
        '
        'btnLimpiar
        '
        Me.btnLimpiar.BackColor = System.Drawing.Color.SteelBlue
        Me.btnLimpiar.Location = New System.Drawing.Point(117, 154)
        Me.btnLimpiar.Name = "btnLimpiar"
        Me.btnLimpiar.Size = New System.Drawing.Size(100, 27)
        Me.btnLimpiar.TabIndex = 5
        Me.btnLimpiar.Text = "Limpiar"
        Me.btnLimpiar.UseVisualStyleBackColor = False
        '
        'btnPrecios
        '
        Me.btnPrecios.BackColor = System.Drawing.Color.Fuchsia
        Me.btnPrecios.Location = New System.Drawing.Point(190, 31)
        Me.btnPrecios.Name = "btnPrecios"
        Me.btnPrecios.Size = New System.Drawing.Size(99, 51)
        Me.btnPrecios.TabIndex = 1
        Me.btnPrecios.Text = "Generar Precios"
        Me.btnPrecios.UseVisualStyleBackColor = False
        '
        'btnGenerar
        '
        Me.btnGenerar.BackColor = System.Drawing.Color.Fuchsia
        Me.btnGenerar.Location = New System.Drawing.Point(28, 31)
        Me.btnGenerar.Name = "btnGenerar"
        Me.btnGenerar.Size = New System.Drawing.Size(108, 51)
        Me.btnGenerar.TabIndex = 0
        Me.btnGenerar.Text = "Generar Computadoras"
        Me.btnGenerar.UseVisualStyleBackColor = False
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox2.Controls.Add(Me.lbVender)
        Me.GroupBox2.Controls.Add(Me.txtVender)
        Me.GroupBox2.Controls.Add(Me.btnVender)
        Me.GroupBox2.Controls.Add(Me.btnLimpiarVender)
        Me.GroupBox2.Font = New System.Drawing.Font("Georgia", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(465, 415)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(289, 95)
        Me.GroupBox2.TabIndex = 4
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Registro"
        '
        'lbVender
        '
        Me.lbVender.AutoSize = True
        Me.lbVender.Location = New System.Drawing.Point(18, 37)
        Me.lbVender.Name = "lbVender"
        Me.lbVender.Size = New System.Drawing.Size(84, 14)
        Me.lbVender.TabIndex = 22
        Me.lbVender.Text = "Cant. Vender"
        '
        'txtVender
        '
        Me.txtVender.Location = New System.Drawing.Point(108, 34)
        Me.txtVender.Name = "txtVender"
        Me.txtVender.Size = New System.Drawing.Size(105, 20)
        Me.txtVender.TabIndex = 16
        '
        'btnVender
        '
        Me.btnVender.BackColor = System.Drawing.Color.DeepPink
        Me.btnVender.Location = New System.Drawing.Point(44, 64)
        Me.btnVender.Name = "btnVender"
        Me.btnVender.Size = New System.Drawing.Size(100, 25)
        Me.btnVender.TabIndex = 3
        Me.btnVender.Text = "Vender"
        Me.btnVender.UseVisualStyleBackColor = False
        '
        'btnLimpiarVender
        '
        Me.btnLimpiarVender.BackColor = System.Drawing.Color.DeepPink
        Me.btnLimpiarVender.Location = New System.Drawing.Point(153, 64)
        Me.btnLimpiarVender.Name = "btnLimpiarVender"
        Me.btnLimpiarVender.Size = New System.Drawing.Size(96, 25)
        Me.btnLimpiarVender.TabIndex = 2
        Me.btnLimpiarVender.Text = "Limpiar"
        Me.btnLimpiarVender.UseVisualStyleBackColor = False
        '
        'GroupBox3
        '
        Me.GroupBox3.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox3.Controls.Add(Me.lbCantidad)
        Me.GroupBox3.Controls.Add(Me.lbPrecio)
        Me.GroupBox3.Controls.Add(Me.lbModelo)
        Me.GroupBox3.Controls.Add(Me.lbMarca)
        Me.GroupBox3.Controls.Add(Me.txtCantidad)
        Me.GroupBox3.Controls.Add(Me.txtModelo)
        Me.GroupBox3.Controls.Add(Me.txtPrecio)
        Me.GroupBox3.Controls.Add(Me.txtMarca)
        Me.GroupBox3.Controls.Add(Me.btnBuscar)
        Me.GroupBox3.Controls.Add(Me.btnLimpiarRegistro)
        Me.GroupBox3.Font = New System.Drawing.Font("Georgia", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox3.Location = New System.Drawing.Point(465, 171)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(289, 232)
        Me.GroupBox3.TabIndex = 4
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Registro"
        '
        'lbCantidad
        '
        Me.lbCantidad.AutoSize = True
        Me.lbCantidad.Location = New System.Drawing.Point(6, 181)
        Me.lbCantidad.Name = "lbCantidad"
        Me.lbCantidad.Size = New System.Drawing.Size(60, 14)
        Me.lbCantidad.TabIndex = 21
        Me.lbCantidad.Text = "Cantidad"
        '
        'lbPrecio
        '
        Me.lbPrecio.AutoSize = True
        Me.lbPrecio.Location = New System.Drawing.Point(6, 134)
        Me.lbPrecio.Name = "lbPrecio"
        Me.lbPrecio.Size = New System.Drawing.Size(42, 14)
        Me.lbPrecio.TabIndex = 20
        Me.lbPrecio.Text = "Precio"
        '
        'lbModelo
        '
        Me.lbModelo.AutoSize = True
        Me.lbModelo.Location = New System.Drawing.Point(6, 91)
        Me.lbModelo.Name = "lbModelo"
        Me.lbModelo.Size = New System.Drawing.Size(46, 14)
        Me.lbModelo.TabIndex = 19
        Me.lbModelo.Text = "Modelo"
        '
        'lbMarca
        '
        Me.lbMarca.AutoSize = True
        Me.lbMarca.Location = New System.Drawing.Point(6, 43)
        Me.lbMarca.Name = "lbMarca"
        Me.lbMarca.Size = New System.Drawing.Size(43, 14)
        Me.lbMarca.TabIndex = 11
        Me.lbMarca.Text = "Marca"
        '
        'txtCantidad
        '
        Me.txtCantidad.Location = New System.Drawing.Point(75, 175)
        Me.txtCantidad.Name = "txtCantidad"
        Me.txtCantidad.Size = New System.Drawing.Size(105, 20)
        Me.txtCantidad.TabIndex = 18
        '
        'txtModelo
        '
        Me.txtModelo.Location = New System.Drawing.Point(75, 88)
        Me.txtModelo.Name = "txtModelo"
        Me.txtModelo.Size = New System.Drawing.Size(105, 20)
        Me.txtModelo.TabIndex = 17
        '
        'txtPrecio
        '
        Me.txtPrecio.Location = New System.Drawing.Point(75, 131)
        Me.txtPrecio.Name = "txtPrecio"
        Me.txtPrecio.Size = New System.Drawing.Size(105, 20)
        Me.txtPrecio.TabIndex = 16
        '
        'txtMarca
        '
        Me.txtMarca.Location = New System.Drawing.Point(75, 40)
        Me.txtMarca.Name = "txtMarca"
        Me.txtMarca.Size = New System.Drawing.Size(105, 20)
        Me.txtMarca.TabIndex = 15
        '
        'btnBuscar
        '
        Me.btnBuscar.BackColor = System.Drawing.Color.Gold
        Me.btnBuscar.Location = New System.Drawing.Point(206, 57)
        Me.btnBuscar.Name = "btnBuscar"
        Me.btnBuscar.Size = New System.Drawing.Size(68, 51)
        Me.btnBuscar.TabIndex = 6
        Me.btnBuscar.Text = "Buscar"
        Me.btnBuscar.UseVisualStyleBackColor = False
        '
        'btnLimpiarRegistro
        '
        Me.btnLimpiarRegistro.BackColor = System.Drawing.Color.Gold
        Me.btnLimpiarRegistro.Location = New System.Drawing.Point(206, 134)
        Me.btnLimpiarRegistro.Name = "btnLimpiarRegistro"
        Me.btnLimpiarRegistro.Size = New System.Drawing.Size(68, 51)
        Me.btnLimpiarRegistro.TabIndex = 4
        Me.btnLimpiarRegistro.Text = "Limpiar Registro"
        Me.btnLimpiarRegistro.UseVisualStyleBackColor = False
        '
        'GroupBox4
        '
        Me.GroupBox4.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox4.Controls.Add(Me.lbCantidadComputadoras)
        Me.GroupBox4.Controls.Add(Me.txtCant)
        Me.GroupBox4.Controls.Add(Me.cmbComputadoras)
        Me.GroupBox4.Controls.Add(Me.btnSolicitar)
        Me.GroupBox4.Font = New System.Drawing.Font("Georgia", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox4.Location = New System.Drawing.Point(32, 299)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(346, 200)
        Me.GroupBox4.TabIndex = 4
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Dinamico"
        '
        'lbCantidadComputadoras
        '
        Me.lbCantidadComputadoras.AutoSize = True
        Me.lbCantidadComputadoras.Location = New System.Drawing.Point(6, 61)
        Me.lbCantidadComputadoras.Name = "lbCantidadComputadoras"
        Me.lbCantidadComputadoras.Size = New System.Drawing.Size(126, 14)
        Me.lbCantidadComputadoras.TabIndex = 10
        Me.lbCantidadComputadoras.Text = "Cant. Computadoras"
        '
        'txtCant
        '
        Me.txtCant.Location = New System.Drawing.Point(138, 58)
        Me.txtCant.Name = "txtCant"
        Me.txtCant.Size = New System.Drawing.Size(138, 20)
        Me.txtCant.TabIndex = 9
        '
        'cmbComputadoras
        '
        Me.cmbComputadoras.FormattingEnabled = True
        Me.cmbComputadoras.Location = New System.Drawing.Point(90, 150)
        Me.cmbComputadoras.Name = "cmbComputadoras"
        Me.cmbComputadoras.Size = New System.Drawing.Size(151, 22)
        Me.cmbComputadoras.TabIndex = 8
        '
        'btnSolicitar
        '
        Me.btnSolicitar.BackColor = System.Drawing.Color.LimeGreen
        Me.btnSolicitar.Location = New System.Drawing.Point(108, 116)
        Me.btnSolicitar.Name = "btnSolicitar"
        Me.btnSolicitar.Size = New System.Drawing.Size(119, 28)
        Me.btnSolicitar.TabIndex = 7
        Me.btnSolicitar.Text = "Solicitar"
        Me.btnSolicitar.UseVisualStyleBackColor = False
        '
        'GroupBox5
        '
        Me.GroupBox5.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox5.Controls.Add(Me.lbCantComputadora)
        Me.GroupBox5.Controls.Add(Me.txtCanComputadora)
        Me.GroupBox5.Controls.Add(Me.btnRegistrar)
        Me.GroupBox5.Font = New System.Drawing.Font("Georgia", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox5.Location = New System.Drawing.Point(465, 57)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(289, 99)
        Me.GroupBox5.TabIndex = 4
        Me.GroupBox5.TabStop = False
        Me.GroupBox5.Text = "Registro"
        '
        'lbCantComputadora
        '
        Me.lbCantComputadora.AutoSize = True
        Me.lbCantComputadora.Location = New System.Drawing.Point(6, 34)
        Me.lbCantComputadora.Name = "lbCantComputadora"
        Me.lbCantComputadora.Size = New System.Drawing.Size(126, 14)
        Me.lbCantComputadora.TabIndex = 23
        Me.lbCantComputadora.Text = "Cant. Computadoras"
        '
        'txtCanComputadora
        '
        Me.txtCanComputadora.Location = New System.Drawing.Point(138, 31)
        Me.txtCanComputadora.Name = "txtCanComputadora"
        Me.txtCanComputadora.Size = New System.Drawing.Size(113, 20)
        Me.txtCanComputadora.TabIndex = 10
        '
        'btnRegistrar
        '
        Me.btnRegistrar.BackColor = System.Drawing.Color.Violet
        Me.btnRegistrar.Location = New System.Drawing.Point(100, 65)
        Me.btnRegistrar.Name = "btnRegistrar"
        Me.btnRegistrar.Size = New System.Drawing.Size(107, 25)
        Me.btnRegistrar.TabIndex = 8
        Me.btnRegistrar.Text = "Registrar"
        Me.btnRegistrar.UseVisualStyleBackColor = False
        '
        'ErrorProvider
        '
        Me.ErrorProvider.ContainerControl = Me
        '
        'ArreglosYVectores
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Menu_EjercicioClase.My.Resources.Resources.Fondo
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(902, 540)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.GroupBox5)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.PanelSuperior)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "ArreglosYVectores"
        Me.Text = "ArreglosYVectores"
        Me.PanelSuperior.ResumeLayout(False)
        Me.PanelSuperior.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox5.PerformLayout()
        CType(Me.ErrorProvider, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents PanelSuperior As Panel
    Friend WithEvents btnMaximizar As Button
    Friend WithEvents btnMinimizar As Button
    Friend WithEvents btnRestaurar As Button
    Friend WithEvents btnCerrar As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents GroupBox5 As GroupBox
    Friend WithEvents btnPrecios As Button
    Friend WithEvents btnGenerar As Button
    Friend WithEvents btnLimpiar As Button
    Friend WithEvents btnVender As Button
    Friend WithEvents btnLimpiarVender As Button
    Friend WithEvents btnBuscar As Button
    Friend WithEvents btnLimpiarRegistro As Button
    Friend WithEvents btnSolicitar As Button
    Friend WithEvents btnRegistrar As Button
    Friend WithEvents cmbPrecios As ComboBox
    Friend WithEvents cmbGenerar As ComboBox
    Friend WithEvents cmbComputadoras As ComboBox
    Friend WithEvents txtCantidad As TextBox
    Friend WithEvents txtModelo As TextBox
    Friend WithEvents txtPrecio As TextBox
    Friend WithEvents txtMarca As TextBox
    Friend WithEvents txtCant As TextBox
    Friend WithEvents txtCanComputadora As TextBox
    Friend WithEvents txtVender As TextBox
    Friend WithEvents lbCantidadComputadoras As Label
    Friend WithEvents lbCantidad As Label
    Friend WithEvents lbPrecio As Label
    Friend WithEvents lbModelo As Label
    Friend WithEvents lbMarca As Label
    Friend WithEvents lbVender As Label
    Friend WithEvents lbCantComputadora As Label
    Friend WithEvents ErrorProvider As ErrorProvider
    Friend WithEvents Informacion As ToolTip
End Class
