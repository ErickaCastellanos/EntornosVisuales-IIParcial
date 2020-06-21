<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MenuPrincipal
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
        Me.btnRestaurar = New System.Windows.Forms.Button()
        Me.btnMaximizar = New System.Windows.Forms.Button()
        Me.btnMinimizar = New System.Windows.Forms.Button()
        Me.btnCerrar = New System.Windows.Forms.Button()
        Me.PanelEjercicios = New System.Windows.Forms.Panel()
        Me.PanelLateral = New System.Windows.Forms.Panel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.btnEjercicio4 = New System.Windows.Forms.Button()
        Me.btnEjercicio3 = New System.Windows.Forms.Button()
        Me.btnMatrices = New System.Windows.Forms.Button()
        Me.btnMenuClase = New System.Windows.Forms.Button()
        Me.btnMenu = New System.Windows.Forms.PictureBox()
        Me.timerOcultarMenu = New System.Windows.Forms.Timer(Me.components)
        Me.timerMostrarMenu = New System.Windows.Forms.Timer(Me.components)
        Me.PanelSuperior.SuspendLayout()
        Me.PanelLateral.SuspendLayout()
        CType(Me.btnMenu, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PanelSuperior
        '
        Me.PanelSuperior.BackColor = System.Drawing.Color.Black
        Me.PanelSuperior.Controls.Add(Me.btnRestaurar)
        Me.PanelSuperior.Controls.Add(Me.btnMaximizar)
        Me.PanelSuperior.Controls.Add(Me.btnMinimizar)
        Me.PanelSuperior.Controls.Add(Me.btnCerrar)
        Me.PanelSuperior.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelSuperior.Location = New System.Drawing.Point(0, 0)
        Me.PanelSuperior.Name = "PanelSuperior"
        Me.PanelSuperior.Size = New System.Drawing.Size(886, 36)
        Me.PanelSuperior.TabIndex = 0
        '
        'btnRestaurar
        '
        Me.btnRestaurar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnRestaurar.BackColor = System.Drawing.Color.Transparent
        Me.btnRestaurar.BackgroundImage = Global.MiMenuPersonalizado.My.Resources.Resources.Icono_Restaurar
        Me.btnRestaurar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnRestaurar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnRestaurar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red
        Me.btnRestaurar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red
        Me.btnRestaurar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnRestaurar.Location = New System.Drawing.Point(810, 0)
        Me.btnRestaurar.Name = "btnRestaurar"
        Me.btnRestaurar.Size = New System.Drawing.Size(40, 40)
        Me.btnRestaurar.TabIndex = 3
        Me.btnRestaurar.UseVisualStyleBackColor = False
        Me.btnRestaurar.Visible = False
        '
        'btnMaximizar
        '
        Me.btnMaximizar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnMaximizar.BackColor = System.Drawing.Color.Transparent
        Me.btnMaximizar.BackgroundImage = Global.MiMenuPersonalizado.My.Resources.Resources.Icono_Maximizar
        Me.btnMaximizar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btnMaximizar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnMaximizar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red
        Me.btnMaximizar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red
        Me.btnMaximizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnMaximizar.Location = New System.Drawing.Point(810, -2)
        Me.btnMaximizar.Name = "btnMaximizar"
        Me.btnMaximizar.Size = New System.Drawing.Size(40, 40)
        Me.btnMaximizar.TabIndex = 4
        Me.btnMaximizar.UseVisualStyleBackColor = False
        '
        'btnMinimizar
        '
        Me.btnMinimizar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnMinimizar.BackColor = System.Drawing.Color.Transparent
        Me.btnMinimizar.BackgroundImage = Global.MiMenuPersonalizado.My.Resources.Resources.Icono_Minimizar
        Me.btnMinimizar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnMinimizar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnMinimizar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red
        Me.btnMinimizar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red
        Me.btnMinimizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnMinimizar.Location = New System.Drawing.Point(775, -2)
        Me.btnMinimizar.Name = "btnMinimizar"
        Me.btnMinimizar.Size = New System.Drawing.Size(40, 40)
        Me.btnMinimizar.TabIndex = 2
        Me.btnMinimizar.UseVisualStyleBackColor = False
        '
        'btnCerrar
        '
        Me.btnCerrar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnCerrar.BackColor = System.Drawing.Color.Transparent
        Me.btnCerrar.BackgroundImage = Global.MiMenuPersonalizado.My.Resources.Resources.Icono_cerrar_FN
        Me.btnCerrar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnCerrar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnCerrar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red
        Me.btnCerrar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red
        Me.btnCerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCerrar.Location = New System.Drawing.Point(846, -1)
        Me.btnCerrar.Name = "btnCerrar"
        Me.btnCerrar.Size = New System.Drawing.Size(40, 40)
        Me.btnCerrar.TabIndex = 1
        Me.btnCerrar.UseVisualStyleBackColor = False
        '
        'PanelEjercicios
        '
        Me.PanelEjercicios.BackgroundImage = Global.MiMenuPersonalizado.My.Resources.Resources.talvez
        Me.PanelEjercicios.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PanelEjercicios.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelEjercicios.Location = New System.Drawing.Point(173, 36)
        Me.PanelEjercicios.Name = "PanelEjercicios"
        Me.PanelEjercicios.Size = New System.Drawing.Size(713, 456)
        Me.PanelEjercicios.TabIndex = 2
        '
        'PanelLateral
        '
        Me.PanelLateral.BackColor = System.Drawing.Color.LightCyan
        Me.PanelLateral.BackgroundImage = Global.MiMenuPersonalizado.My.Resources.Resources.azul
        Me.PanelLateral.Controls.Add(Me.Panel3)
        Me.PanelLateral.Controls.Add(Me.Panel4)
        Me.PanelLateral.Controls.Add(Me.Panel5)
        Me.PanelLateral.Controls.Add(Me.Panel2)
        Me.PanelLateral.Controls.Add(Me.Button4)
        Me.PanelLateral.Controls.Add(Me.btnEjercicio4)
        Me.PanelLateral.Controls.Add(Me.btnEjercicio3)
        Me.PanelLateral.Controls.Add(Me.btnMatrices)
        Me.PanelLateral.Controls.Add(Me.btnMenuClase)
        Me.PanelLateral.Controls.Add(Me.btnMenu)
        Me.PanelLateral.Dock = System.Windows.Forms.DockStyle.Left
        Me.PanelLateral.Location = New System.Drawing.Point(0, 36)
        Me.PanelLateral.Name = "PanelLateral"
        Me.PanelLateral.Size = New System.Drawing.Size(173, 456)
        Me.PanelLateral.TabIndex = 1
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.Black
        Me.Panel3.Location = New System.Drawing.Point(3, 191)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(5, 50)
        Me.Panel3.TabIndex = 6
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.Color.Black
        Me.Panel4.Location = New System.Drawing.Point(3, 135)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(5, 50)
        Me.Panel4.TabIndex = 6
        '
        'Panel5
        '
        Me.Panel5.BackColor = System.Drawing.Color.Black
        Me.Panel5.Location = New System.Drawing.Point(3, 303)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(5, 50)
        Me.Panel5.TabIndex = 6
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.Black
        Me.Panel2.Location = New System.Drawing.Point(3, 247)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(5, 50)
        Me.Panel2.TabIndex = 9
        '
        'Button4
        '
        Me.Button4.BackColor = System.Drawing.Color.Transparent
        Me.Button4.BackgroundImage = Global.MiMenuPersonalizado.My.Resources.Resources.codificacion
        Me.Button4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.Button4.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button4.FlatAppearance.BorderSize = 0
        Me.Button4.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gold
        Me.Button4.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(44, Byte), Integer), CType(CType(55, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.Button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button4.Font = New System.Drawing.Font("Gadugi", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button4.ForeColor = System.Drawing.Color.White
        Me.Button4.ImageAlign = System.Drawing.ContentAlignment.BottomLeft
        Me.Button4.Location = New System.Drawing.Point(3, 43)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(45, 74)
        Me.Button4.TabIndex = 8
        Me.Button4.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button4.UseVisualStyleBackColor = False
        '
        'btnEjercicio4
        '
        Me.btnEjercicio4.BackColor = System.Drawing.Color.Transparent
        Me.btnEjercicio4.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnEjercicio4.FlatAppearance.BorderSize = 0
        Me.btnEjercicio4.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gold
        Me.btnEjercicio4.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(44, Byte), Integer), CType(CType(55, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.btnEjercicio4.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnEjercicio4.Font = New System.Drawing.Font("Gadugi", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEjercicio4.ForeColor = System.Drawing.Color.White
        Me.btnEjercicio4.Image = Global.MiMenuPersonalizado.My.Resources.Resources.producto
        Me.btnEjercicio4.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnEjercicio4.Location = New System.Drawing.Point(-3, 303)
        Me.btnEjercicio4.Name = "btnEjercicio4"
        Me.btnEjercicio4.Size = New System.Drawing.Size(195, 50)
        Me.btnEjercicio4.TabIndex = 6
        Me.btnEjercicio4.Text = "Ejercicio 4"
        Me.btnEjercicio4.UseVisualStyleBackColor = False
        '
        'btnEjercicio3
        '
        Me.btnEjercicio3.BackColor = System.Drawing.Color.Transparent
        Me.btnEjercicio3.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnEjercicio3.FlatAppearance.BorderSize = 0
        Me.btnEjercicio3.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gold
        Me.btnEjercicio3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(44, Byte), Integer), CType(CType(55, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.btnEjercicio3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnEjercicio3.Font = New System.Drawing.Font("Gadugi", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEjercicio3.ForeColor = System.Drawing.Color.White
        Me.btnEjercicio3.Image = Global.MiMenuPersonalizado.My.Resources.Resources.producto
        Me.btnEjercicio3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnEjercicio3.Location = New System.Drawing.Point(0, 247)
        Me.btnEjercicio3.Name = "btnEjercicio3"
        Me.btnEjercicio3.Size = New System.Drawing.Size(192, 50)
        Me.btnEjercicio3.TabIndex = 5
        Me.btnEjercicio3.Text = "Ejercicio 3"
        Me.btnEjercicio3.UseVisualStyleBackColor = False
        '
        'btnMatrices
        '
        Me.btnMatrices.BackColor = System.Drawing.Color.Transparent
        Me.btnMatrices.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnMatrices.FlatAppearance.BorderSize = 0
        Me.btnMatrices.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gold
        Me.btnMatrices.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(44, Byte), Integer), CType(CType(55, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.btnMatrices.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnMatrices.Font = New System.Drawing.Font("Gadugi", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnMatrices.ForeColor = System.Drawing.Color.White
        Me.btnMatrices.Image = Global.MiMenuPersonalizado.My.Resources.Resources.producto
        Me.btnMatrices.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnMatrices.Location = New System.Drawing.Point(0, 191)
        Me.btnMatrices.Name = "btnMatrices"
        Me.btnMatrices.Size = New System.Drawing.Size(192, 50)
        Me.btnMatrices.TabIndex = 4
        Me.btnMatrices.Text = "Arreglos"
        Me.btnMatrices.UseVisualStyleBackColor = False
        '
        'btnMenuClase
        '
        Me.btnMenuClase.BackColor = System.Drawing.Color.Transparent
        Me.btnMenuClase.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnMenuClase.FlatAppearance.BorderSize = 0
        Me.btnMenuClase.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gold
        Me.btnMenuClase.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(44, Byte), Integer), CType(CType(55, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.btnMenuClase.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnMenuClase.Font = New System.Drawing.Font("Gadugi", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnMenuClase.ForeColor = System.Drawing.Color.White
        Me.btnMenuClase.Image = Global.MiMenuPersonalizado.My.Resources.Resources.producto
        Me.btnMenuClase.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnMenuClase.Location = New System.Drawing.Point(-3, 135)
        Me.btnMenuClase.Name = "btnMenuClase"
        Me.btnMenuClase.Size = New System.Drawing.Size(195, 50)
        Me.btnMenuClase.TabIndex = 3
        Me.btnMenuClase.Text = "Menu-Clase"
        Me.btnMenuClase.UseVisualStyleBackColor = False
        '
        'btnMenu
        '
        Me.btnMenu.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnMenu.BackColor = System.Drawing.Color.Transparent
        Me.btnMenu.BackgroundImage = Global.MiMenuPersonalizado.My.Resources.Resources.Mobile_Menu_Icon
        Me.btnMenu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnMenu.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnMenu.Location = New System.Drawing.Point(128, 0)
        Me.btnMenu.Name = "btnMenu"
        Me.btnMenu.Size = New System.Drawing.Size(44, 36)
        Me.btnMenu.TabIndex = 0
        Me.btnMenu.TabStop = False
        '
        'timerOcultarMenu
        '
        '
        'timerMostrarMenu
        '
        '
        'MenuPrincipal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(886, 492)
        Me.Controls.Add(Me.PanelEjercicios)
        Me.Controls.Add(Me.PanelLateral)
        Me.Controls.Add(Me.PanelSuperior)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "MenuPrincipal"
        Me.Text = "MenuPersonalizado"
        Me.PanelSuperior.ResumeLayout(False)
        Me.PanelLateral.ResumeLayout(False)
        CType(Me.btnMenu, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents PanelSuperior As Panel
    Friend WithEvents PanelLateral As Panel
    Friend WithEvents PanelEjercicios As Panel
    Friend WithEvents btnMenu As PictureBox
    Friend WithEvents btnMaximizar As Button
    Friend WithEvents btnRestaurar As Button
    Friend WithEvents btnMinimizar As Button
    Friend WithEvents btnCerrar As Button
    Friend WithEvents btnMenuClase As Button
    Friend WithEvents btnEjercicio4 As Button
    Friend WithEvents btnEjercicio3 As Button
    Friend WithEvents btnMatrices As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Panel4 As Panel
    Friend WithEvents Panel5 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents timerOcultarMenu As Timer
    Friend WithEvents timerMostrarMenu As Timer
End Class
