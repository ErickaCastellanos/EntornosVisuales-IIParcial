<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class LibretaDeBanco
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
        Me.gbIngreso = New System.Windows.Forms.GroupBox()
        Me.txtNombre = New System.Windows.Forms.TextBox()
        Me.txtEdad = New System.Windows.Forms.TextBox()
        Me.txtIntereses = New System.Windows.Forms.TextBox()
        Me.txtMonto = New System.Windows.Forms.TextBox()
        Me.txtPais = New System.Windows.Forms.TextBox()
        Me.txtCiudad = New System.Windows.Forms.TextBox()
        Me.txtIdentidad = New System.Windows.Forms.TextBox()
        Me.lbInteres = New System.Windows.Forms.Label()
        Me.lbSaldo = New System.Windows.Forms.Label()
        Me.lbCiudad = New System.Windows.Forms.Label()
        Me.lbPais = New System.Windows.Forms.Label()
        Me.lbEdad = New System.Windows.Forms.Label()
        Me.lbNombre = New System.Windows.Forms.Label()
        Me.lbIdentidad = New System.Windows.Forms.Label()
        Me.btnAperturar = New System.Windows.Forms.Button()
        Me.gbOperaciones = New System.Windows.Forms.GroupBox()
        Me.btnRetirar = New System.Windows.Forms.Button()
        Me.btnDepositar = New System.Windows.Forms.Button()
        Me.gbHistorial = New System.Windows.Forms.GroupBox()
        Me.lstRetiros = New System.Windows.Forms.ListBox()
        Me.lstDepositos = New System.Windows.Forms.ListBox()
        Me.txtSaldoTotal = New System.Windows.Forms.TextBox()
        Me.lbDepositar = New System.Windows.Forms.Label()
        Me.lbRetirar = New System.Windows.Forms.Label()
        Me.lbSaldoTotal = New System.Windows.Forms.Label()
        Me.btnLimpiar = New System.Windows.Forms.Button()
        Me.gbIngreso.SuspendLayout()
        Me.gbOperaciones.SuspendLayout()
        Me.gbHistorial.SuspendLayout()
        Me.SuspendLayout()
        '
        'gbIngreso
        '
        Me.gbIngreso.Controls.Add(Me.txtNombre)
        Me.gbIngreso.Controls.Add(Me.txtEdad)
        Me.gbIngreso.Controls.Add(Me.txtIntereses)
        Me.gbIngreso.Controls.Add(Me.txtMonto)
        Me.gbIngreso.Controls.Add(Me.txtPais)
        Me.gbIngreso.Controls.Add(Me.txtCiudad)
        Me.gbIngreso.Controls.Add(Me.txtIdentidad)
        Me.gbIngreso.Controls.Add(Me.lbInteres)
        Me.gbIngreso.Controls.Add(Me.lbSaldo)
        Me.gbIngreso.Controls.Add(Me.lbCiudad)
        Me.gbIngreso.Controls.Add(Me.lbPais)
        Me.gbIngreso.Controls.Add(Me.lbEdad)
        Me.gbIngreso.Controls.Add(Me.lbNombre)
        Me.gbIngreso.Controls.Add(Me.lbIdentidad)
        Me.gbIngreso.Controls.Add(Me.btnAperturar)
        Me.gbIngreso.Font = New System.Drawing.Font("Georgia", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbIngreso.Location = New System.Drawing.Point(22, 28)
        Me.gbIngreso.Name = "gbIngreso"
        Me.gbIngreso.Size = New System.Drawing.Size(257, 341)
        Me.gbIngreso.TabIndex = 0
        Me.gbIngreso.TabStop = False
        Me.gbIngreso.Text = "Ingreso De Informacion"
        '
        'txtNombre
        '
        Me.txtNombre.Location = New System.Drawing.Point(94, 70)
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Size = New System.Drawing.Size(95, 22)
        Me.txtNombre.TabIndex = 14
        '
        'txtEdad
        '
        Me.txtEdad.Location = New System.Drawing.Point(94, 103)
        Me.txtEdad.Name = "txtEdad"
        Me.txtEdad.Size = New System.Drawing.Size(95, 22)
        Me.txtEdad.TabIndex = 13
        '
        'txtIntereses
        '
        Me.txtIntereses.Location = New System.Drawing.Point(94, 234)
        Me.txtIntereses.Name = "txtIntereses"
        Me.txtIntereses.Size = New System.Drawing.Size(95, 22)
        Me.txtIntereses.TabIndex = 12
        '
        'txtMonto
        '
        Me.txtMonto.Location = New System.Drawing.Point(94, 202)
        Me.txtMonto.Name = "txtMonto"
        Me.txtMonto.Size = New System.Drawing.Size(95, 22)
        Me.txtMonto.TabIndex = 11
        '
        'txtPais
        '
        Me.txtPais.Location = New System.Drawing.Point(94, 134)
        Me.txtPais.Name = "txtPais"
        Me.txtPais.Size = New System.Drawing.Size(95, 22)
        Me.txtPais.TabIndex = 10
        '
        'txtCiudad
        '
        Me.txtCiudad.Location = New System.Drawing.Point(94, 165)
        Me.txtCiudad.Name = "txtCiudad"
        Me.txtCiudad.Size = New System.Drawing.Size(95, 22)
        Me.txtCiudad.TabIndex = 9
        '
        'txtIdentidad
        '
        Me.txtIdentidad.Location = New System.Drawing.Point(94, 39)
        Me.txtIdentidad.Name = "txtIdentidad"
        Me.txtIdentidad.Size = New System.Drawing.Size(95, 22)
        Me.txtIdentidad.TabIndex = 8
        '
        'lbInteres
        '
        Me.lbInteres.AutoSize = True
        Me.lbInteres.Location = New System.Drawing.Point(6, 240)
        Me.lbInteres.Name = "lbInteres"
        Me.lbInteres.Size = New System.Drawing.Size(66, 16)
        Me.lbInteres.TabIndex = 7
        Me.lbInteres.Text = "Intereses"
        '
        'lbSaldo
        '
        Me.lbSaldo.AutoSize = True
        Me.lbSaldo.Location = New System.Drawing.Point(6, 205)
        Me.lbSaldo.Name = "lbSaldo"
        Me.lbSaldo.Size = New System.Drawing.Size(42, 16)
        Me.lbSaldo.TabIndex = 6
        Me.lbSaldo.Text = "Saldo"
        '
        'lbCiudad
        '
        Me.lbCiudad.AutoSize = True
        Me.lbCiudad.Location = New System.Drawing.Point(6, 168)
        Me.lbCiudad.Name = "lbCiudad"
        Me.lbCiudad.Size = New System.Drawing.Size(51, 16)
        Me.lbCiudad.TabIndex = 5
        Me.lbCiudad.Text = "Ciudad"
        '
        'lbPais
        '
        Me.lbPais.AutoSize = True
        Me.lbPais.Location = New System.Drawing.Point(6, 137)
        Me.lbPais.Name = "lbPais"
        Me.lbPais.Size = New System.Drawing.Size(33, 16)
        Me.lbPais.TabIndex = 4
        Me.lbPais.Text = "Pais"
        '
        'lbEdad
        '
        Me.lbEdad.AutoSize = True
        Me.lbEdad.Location = New System.Drawing.Point(6, 106)
        Me.lbEdad.Name = "lbEdad"
        Me.lbEdad.Size = New System.Drawing.Size(39, 16)
        Me.lbEdad.TabIndex = 3
        Me.lbEdad.Text = "Edad"
        '
        'lbNombre
        '
        Me.lbNombre.AutoSize = True
        Me.lbNombre.Location = New System.Drawing.Point(6, 73)
        Me.lbNombre.Name = "lbNombre"
        Me.lbNombre.Size = New System.Drawing.Size(59, 16)
        Me.lbNombre.TabIndex = 2
        Me.lbNombre.Text = "Nombre"
        '
        'lbIdentidad
        '
        Me.lbIdentidad.AutoSize = True
        Me.lbIdentidad.Location = New System.Drawing.Point(6, 42)
        Me.lbIdentidad.Name = "lbIdentidad"
        Me.lbIdentidad.Size = New System.Drawing.Size(69, 16)
        Me.lbIdentidad.TabIndex = 1
        Me.lbIdentidad.Text = "Identidad"
        '
        'btnAperturar
        '
        Me.btnAperturar.Location = New System.Drawing.Point(150, 282)
        Me.btnAperturar.Name = "btnAperturar"
        Me.btnAperturar.Size = New System.Drawing.Size(90, 42)
        Me.btnAperturar.TabIndex = 0
        Me.btnAperturar.Text = "Aperturar Cuenta"
        Me.btnAperturar.UseVisualStyleBackColor = True
        '
        'gbOperaciones
        '
        Me.gbOperaciones.Controls.Add(Me.btnRetirar)
        Me.gbOperaciones.Controls.Add(Me.btnDepositar)
        Me.gbOperaciones.Font = New System.Drawing.Font("Georgia", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbOperaciones.Location = New System.Drawing.Point(326, 46)
        Me.gbOperaciones.Name = "gbOperaciones"
        Me.gbOperaciones.Size = New System.Drawing.Size(257, 116)
        Me.gbOperaciones.TabIndex = 1
        Me.gbOperaciones.TabStop = False
        Me.gbOperaciones.Text = "Operaciones"
        '
        'btnRetirar
        '
        Me.btnRetirar.Location = New System.Drawing.Point(144, 42)
        Me.btnRetirar.Name = "btnRetirar"
        Me.btnRetirar.Size = New System.Drawing.Size(90, 42)
        Me.btnRetirar.TabIndex = 1
        Me.btnRetirar.Text = "Retirar"
        Me.btnRetirar.UseVisualStyleBackColor = True
        '
        'btnDepositar
        '
        Me.btnDepositar.Location = New System.Drawing.Point(25, 42)
        Me.btnDepositar.Name = "btnDepositar"
        Me.btnDepositar.Size = New System.Drawing.Size(90, 42)
        Me.btnDepositar.TabIndex = 2
        Me.btnDepositar.Text = "Depositar"
        Me.btnDepositar.UseVisualStyleBackColor = True
        '
        'gbHistorial
        '
        Me.gbHistorial.Controls.Add(Me.lstRetiros)
        Me.gbHistorial.Controls.Add(Me.lstDepositos)
        Me.gbHistorial.Controls.Add(Me.txtSaldoTotal)
        Me.gbHistorial.Controls.Add(Me.lbDepositar)
        Me.gbHistorial.Controls.Add(Me.lbRetirar)
        Me.gbHistorial.Controls.Add(Me.lbSaldoTotal)
        Me.gbHistorial.Controls.Add(Me.btnLimpiar)
        Me.gbHistorial.Font = New System.Drawing.Font("Georgia", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbHistorial.Location = New System.Drawing.Point(326, 210)
        Me.gbHistorial.Name = "gbHistorial"
        Me.gbHistorial.Size = New System.Drawing.Size(362, 189)
        Me.gbHistorial.TabIndex = 1
        Me.gbHistorial.TabStop = False
        Me.gbHistorial.Text = "Historial"
        '
        'lstRetiros
        '
        Me.lstRetiros.FormattingEnabled = True
        Me.lstRetiros.ItemHeight = 16
        Me.lstRetiros.Location = New System.Drawing.Point(123, 60)
        Me.lstRetiros.Name = "lstRetiros"
        Me.lstRetiros.Size = New System.Drawing.Size(94, 100)
        Me.lstRetiros.TabIndex = 17
        '
        'lstDepositos
        '
        Me.lstDepositos.FormattingEnabled = True
        Me.lstDepositos.ItemHeight = 16
        Me.lstDepositos.Location = New System.Drawing.Point(6, 60)
        Me.lstDepositos.Name = "lstDepositos"
        Me.lstDepositos.Size = New System.Drawing.Size(94, 100)
        Me.lstDepositos.TabIndex = 16
        '
        'txtSaldoTotal
        '
        Me.txtSaldoTotal.Location = New System.Drawing.Point(261, 105)
        Me.txtSaldoTotal.Name = "txtSaldoTotal"
        Me.txtSaldoTotal.Size = New System.Drawing.Size(95, 22)
        Me.txtSaldoTotal.TabIndex = 15
        '
        'lbDepositar
        '
        Me.lbDepositar.AutoSize = True
        Me.lbDepositar.Location = New System.Drawing.Point(22, 41)
        Me.lbDepositar.Name = "lbDepositar"
        Me.lbDepositar.Size = New System.Drawing.Size(68, 16)
        Me.lbDepositar.TabIndex = 4
        Me.lbDepositar.Text = "Depositar"
        '
        'lbRetirar
        '
        Me.lbRetirar.AutoSize = True
        Me.lbRetirar.Location = New System.Drawing.Point(131, 41)
        Me.lbRetirar.Name = "lbRetirar"
        Me.lbRetirar.Size = New System.Drawing.Size(52, 16)
        Me.lbRetirar.TabIndex = 3
        Me.lbRetirar.Text = "Retirar"
        '
        'lbSaldoTotal
        '
        Me.lbSaldoTotal.AutoSize = True
        Me.lbSaldoTotal.Location = New System.Drawing.Point(265, 86)
        Me.lbSaldoTotal.Name = "lbSaldoTotal"
        Me.lbSaldoTotal.Size = New System.Drawing.Size(77, 16)
        Me.lbSaldoTotal.TabIndex = 2
        Me.lbSaldoTotal.Text = "Saldo Total"
        '
        'btnLimpiar
        '
        Me.btnLimpiar.Location = New System.Drawing.Point(261, 157)
        Me.btnLimpiar.Name = "btnLimpiar"
        Me.btnLimpiar.Size = New System.Drawing.Size(86, 26)
        Me.btnLimpiar.TabIndex = 1
        Me.btnLimpiar.Text = "Limpiar"
        Me.btnLimpiar.UseVisualStyleBackColor = True
        '
        'LibretaDeBanco
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(700, 411)
        Me.Controls.Add(Me.gbHistorial)
        Me.Controls.Add(Me.gbOperaciones)
        Me.Controls.Add(Me.gbIngreso)
        Me.Name = "LibretaDeBanco"
        Me.Text = "frmLibretaAhorro"
        Me.gbIngreso.ResumeLayout(False)
        Me.gbIngreso.PerformLayout()
        Me.gbOperaciones.ResumeLayout(False)
        Me.gbHistorial.ResumeLayout(False)
        Me.gbHistorial.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents gbIngreso As GroupBox
    Friend WithEvents gbOperaciones As GroupBox
    Friend WithEvents gbHistorial As GroupBox
    Friend WithEvents btnAperturar As Button
    Friend WithEvents btnRetirar As Button
    Friend WithEvents btnDepositar As Button
    Friend WithEvents btnLimpiar As Button
    Friend WithEvents lbDepositar As Label
    Friend WithEvents lbRetirar As Label
    Friend WithEvents lbSaldoTotal As Label
    Friend WithEvents lbSaldo As Label
    Friend WithEvents lbCiudad As Label
    Friend WithEvents lbPais As Label
    Friend WithEvents lbEdad As Label
    Friend WithEvents lbNombre As Label
    Friend WithEvents lbIdentidad As Label
    Friend WithEvents txtNombre As TextBox
    Friend WithEvents txtEdad As TextBox
    Friend WithEvents txtIntereses As TextBox
    Friend WithEvents txtMonto As TextBox
    Friend WithEvents txtPais As TextBox
    Friend WithEvents txtCiudad As TextBox
    Friend WithEvents txtIdentidad As TextBox
    Friend WithEvents lbInteres As Label
    Friend WithEvents txtSaldoTotal As TextBox
    Friend WithEvents lstRetiros As ListBox
    Friend WithEvents lstDepositos As ListBox
End Class
