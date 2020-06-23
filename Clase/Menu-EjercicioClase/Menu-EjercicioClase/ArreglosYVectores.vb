'Esta libreria nos servira para mover el formulario de un lado a otro
Imports System.ComponentModel
Imports System.Runtime.InteropServices
Public Class ArreglosYVectores
    'Definir variables globales
    Private mComputadoras(,) As String
    Private cantComputadoras As Integer
    Private index As Byte
    Private encuentra As Boolean = False

    'Sirven para manipular el Panel, moverlo en toda el area de trabajo
    <DllImport("user32.DLL", EntryPoint:="ReleaseCapture")>
    Private Shared Sub ReleaseCapture()
    End Sub

    <DllImport("user32.DLL", EntryPoint:="SendMessage")>
    Private Shared Sub SendMessage(ByVal hWnd As System.IntPtr, ByVal wMsg As Integer, ByVal wParam As Integer, ByVal lParam As Integer)
    End Sub


    Private Sub btnMaximizar_Click(sender As Object, e As EventArgs) Handles btnMaximizar.Click
        'Maximizar la pantalla y habilitar el boton de restaurar
        btnMaximizar.Visible = False
        btnRestaurar.Visible = True
        Me.WindowState = FormWindowState.Maximized
    End Sub

    Private Sub btnMinimizar_Click(sender As Object, e As EventArgs) Handles btnMinimizar.Click
        'Minimizar la pantala del formulario
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub btnRestaurar_Click(sender As Object, e As EventArgs) Handles btnRestaurar.Click
        'Deshabilitar el boton restaurar
        btnRestaurar.Visible = False
        btnMaximizar.Visible = True
        Me.WindowState = FormWindowState.Normal
    End Sub

    Private Sub PanelSuperior_MouseMove(sender As Object, e As MouseEventArgs) Handles PanelSuperior.MouseMove
        ReleaseCapture()
        SendMessage(Me.Handle, &H112&, &HF012&, 0)
    End Sub

    Private Sub btnGenerar_Click(sender As Object, e As EventArgs) Handles btnGenerar.Click
        'Definicion de variables
        Dim computadoras(3) As String

        'valores que van dentro del ComboBox
        computadoras(0) = "Toshiba"
        computadoras(1) = "Dell"
        computadoras(2) = "Asus"
        computadoras(3) = "MAC"

        'Recorrer el arreglo para mostrar las computadoras
        'en el comoboBox
        For i = 0 To (computadoras.Length - 1) Step 1
            cmbComputadoras.Items.Add(computadoras(i))
        Next
    End Sub

    Private Sub btnCerrar_Click(sender As Object, e As EventArgs) Handles btnCerrar.Click
        Me.Close()
    End Sub

    Private Sub btnPrecios_Click(sender As Object, e As EventArgs) Handles btnPrecios.Click
        'Definicion de las Variables
        Dim precio(3) As Integer

        'Definir precio cada uno de los componentes del comboBox
        precio(0) = 22500
        precio(1) = 21000
        precio(2) = 29000
        precio(3) = 42000

        'Recorrer el arreglo para asignar el precio a cada producto
        For i = 0 To (precio.Length - 1) Step 1
            cmbPrecios.Items.Add(precio(i))
        Next
    End Sub

    Private Sub btnSolicitar_Click(sender As Object, e As EventArgs) Handles btnSolicitar.Click

        Try

            'Definicion de las variables
            Dim cant As Integer
            Dim comp() As String

            'Asignar tamaño
            cant = Val(txtCant.Text)
            ReDim comp(cant)
            If Me.ValidateChildren And txtCant.Text <> "" Then

                'Solicitar la informacion
                For i = 1 To (comp.Length - 1) Step 1
                    comp(i) = InputBox("Ingrese la marca de la PC", "Ingreso")
                Next

                'Mostrar la informacion
                For j = 1 To (comp.Length - 1) Step 1
                    cmbComputadoras.Items.Add(comp(j))
                Next
            Else
                MessageBox.Show("Revise que el Campo este lleno", "Error en Solicitar", MessageBoxButtons.OK, MessageBoxIcon.Error)

            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub btnLimpiar_Click(sender As Object, e As EventArgs) Handles btnLimpiar.Click
        'Limpiar los comboBox
        cmbComputadoras.Items.Clear()
        cmbPrecios.Items.Clear()
        cmbComputadoras.Text = ""
        cmbPrecios.Text = ""
    End Sub

    Private Sub frmArreglosVectores_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtModelo.Enabled = False
        txtPrecio.Enabled = False
        txtCantidad.Enabled = False
    End Sub

    Private Sub btnRegistrar_Click(sender As Object, e As EventArgs) Handles btnRegistrar.Click
        cantComputadoras = Val(txtCanComputadora.Text)
        ReDim mComputadoras(cantComputadoras, 3)
        Try
            If Me.ValidateChildren And txtCanComputadora.Text <> "" Then

                '3x3= comienza a contar desde 0
                For i = 0 To (cantComputadoras - 1) Step 1
                    mComputadoras(i, 0) = InputBox("Ingrese la marca N." & (i + 1), "Registro")
                    mComputadoras(i, 1) = InputBox("Ingrese el modelo N." & (i + 1), "Registro")
                    mComputadoras(i, 2) = InputBox("Ingrese el precio N." & (i + 1), "Registro")
                    mComputadoras(i, 3) = InputBox("Ingrese la cantidad N." & (i + 1), "Registro")
                    index = i
                Next
            Else
                MessageBox.Show("Revise que el Campo este lleno", "Error en Solicitar", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    Private Sub btnBuscar_Click(sender As Object, e As EventArgs) Handles btnBuscar.Click
        'Definicion de las Variables
        Dim marca As String

        'Asignacion de la variable
        marca = txtMarca.Text
        Try
            If Me.ValidateChildren And txtMarca.Text <> "" Then
                'Este ciclo es para buscar dentro del arreglo segun la marca
                'toda la informacion de la computadora
                For i = 0 To (cantComputadoras - 1) Step 1
                    If (mComputadoras(i, 0) = marca) Then
                        txtModelo.Text = mComputadoras(i, 1)
                        txtPrecio.Text = mComputadoras(i, 2)
                        txtCantidad.Text = mComputadoras(i, 3)
                        encuentra = True
                        btnVender.Enabled = True
                        btnBuscar.Enabled = True
                    End If
                Next
                If (encuentra = False) Then
                    MessageBox.Show("No existe", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                End If
            Else
                MessageBox.Show("Revise que el Campo este lleno", "Error en Solicitar", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    Private Sub btnVender_Click(sender As Object, e As EventArgs) Handles btnVender.Click
        'Definicion de las variables
        Dim cantVender, stock As Integer

        'Asignar valor a las variables
        cantVender = Val(txtVender.Text)
        stock = Val(txtCantidad.Text)
        Try
            If Me.ValidateChildren And txtVender.Text <> "" Then
                'Comenzar la evaluacion
                If (cantVender > stock) Then
                    MessageBox.Show("Sin Stock", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Else
                    MessageBox.Show("Venta Realizada", "Venta", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    txtCantidad.Text = txtCantidad.Text - cantVender
                End If
            Else
                MessageBox.Show("Revise que el Campo este lleno", "Error en Solicitar", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub



    Private Sub btnLimpiarRegistro_Click(sender As Object, e As EventArgs) Handles btnLimpiarRegistro.Click
        txtMarca.Clear()
        txtModelo.Clear()
        txtPrecio.Clear()
        txtCantidad.Clear()
    End Sub

    Private Sub cmbComputadoras_MouseHover(sender As Object, e As EventArgs) Handles cmbComputadoras.MouseHover
        Informacion.SetToolTip(cmbComputadoras, "Muestra las Compuatdoras Disponibles")
        Informacion.ToolTipTitle = "Computadoras"
        Informacion.ToolTipIcon = ToolTipIcon.Info
    End Sub

    Private Sub btnGenerar_MouseHover(sender As Object, e As EventArgs) Handles btnGenerar.MouseHover
        Informacion.SetToolTip(btnGenerar, "Generar varios Tipos de Computadoras")
        Informacion.ToolTipTitle = "Generar Computadoras"
        Informacion.ToolTipIcon = ToolTipIcon.Info
    End Sub

    Private Sub btnPrecios_MouseHover(sender As Object, e As EventArgs) Handles btnPrecios.MouseHover
        Informacion.SetToolTip(btnPrecios, "Genera los Precios para las Computadoras")
        Informacion.ToolTipTitle = "Generar precio"
        Informacion.ToolTipIcon = ToolTipIcon.Info
    End Sub

    Private Sub cmbPrecios_MouseHover(sender As Object, e As EventArgs) Handles cmbPrecios.MouseHover
        Informacion.SetToolTip(cmbPrecios, "Muestra los Precios para las Computadoras")
        Informacion.ToolTipTitle = "Precios"
        Informacion.ToolTipIcon = ToolTipIcon.Info
    End Sub

    Private Sub btnLimpiar_MouseHover(sender As Object, e As EventArgs) Handles btnLimpiar.MouseHover
        Informacion.SetToolTip(btnLimpiar, "Limpia los Combo Box")
        Informacion.ToolTipTitle = "Limpiar"
        Informacion.ToolTipIcon = ToolTipIcon.Info
    End Sub

    Private Sub txtCant_MouseHover(sender As Object, e As EventArgs) Handles txtCant.MouseHover
        Informacion.SetToolTip(txtCant, "Escribir solo Numeros Enteros")
        Informacion.ToolTipTitle = "Cantidad de Compuatdoras"
        Informacion.ToolTipIcon = ToolTipIcon.Info
    End Sub

    Private Sub btnSolicitar_MouseHover(sender As Object, e As EventArgs) Handles btnSolicitar.MouseHover
        Informacion.SetToolTip(btnSolicitar, "Solicita el Tipo de Computadora")
        Informacion.ToolTipTitle = "Solicitar"
        Informacion.ToolTipIcon = ToolTipIcon.Info
    End Sub

    Private Sub cmbSolicitar_MouseHover(sender As Object, e As EventArgs) Handles cmbComputadoras.MouseHover
        Informacion.SetToolTip(cmbComputadoras, "Muestra las Computadoras Ingresadas")
        Informacion.ToolTipTitle = "Computadoras"
        Informacion.ToolTipIcon = ToolTipIcon.Info
    End Sub

    Private Sub txtCanComputadora_MouseHover(sender As Object, e As EventArgs) Handles txtCanComputadora.MouseHover
        Informacion.SetToolTip(txtCanComputadora, "Escribir la Cantidad de Computadoras que desea Ingresar")
        Informacion.ToolTipTitle = "Cant. Computadoras"
        Informacion.ToolTipIcon = ToolTipIcon.Info
    End Sub

    Private Sub btnRegistrar_MouseHover(sender As Object, e As EventArgs) Handles btnRegistrar.MouseHover
        Informacion.SetToolTip(btnRegistrar, "Guarda los Elementos Registrados")
        Informacion.ToolTipTitle = "Registrar"
        Informacion.ToolTipIcon = ToolTipIcon.Info
    End Sub

    Private Sub txtMarca_MouseHover(sender As Object, e As EventArgs) Handles txtMarca.MouseHover
        Informacion.SetToolTip(txtMarca, "Escribir la Marca de la Computadora que Busca")
        Informacion.ToolTipTitle = "Marca"
        Informacion.ToolTipIcon = ToolTipIcon.Info
    End Sub

    Private Sub txtModelo_MouseHover(sender As Object, e As EventArgs) Handles txtModelo.MouseHover
        Informacion.SetToolTip(txtModelo, "Muestra el Modelo de Cada Computadora")
        Informacion.ToolTipTitle = "Modelo"
        Informacion.ToolTipIcon = ToolTipIcon.Info
    End Sub

    Private Sub txtPrecio_MouseHover(sender As Object, e As EventArgs) Handles txtPrecio.MouseHover
        Informacion.SetToolTip(txtPrecio, "Muestra el Precio de Cada Computadora")
        Informacion.ToolTipTitle = "Precio"
        Informacion.ToolTipIcon = ToolTipIcon.Info
    End Sub

    Private Sub txtCantidad_MouseHover(sender As Object, e As EventArgs) Handles txtCantidad.MouseHover
        Informacion.SetToolTip(txtPrecio, "Muestra la Cantidad Disponible de Computadoras")
        Informacion.ToolTipTitle = "Cantidad"
        Informacion.ToolTipIcon = ToolTipIcon.Info
    End Sub

    Private Sub btnBuscar_MouseHover(sender As Object, e As EventArgs) Handles btnBuscar.MouseHover
        Informacion.SetToolTip(btnBuscar, "Busca los datos de cada Computadora")
        Informacion.ToolTipTitle = "Buscar"
        Informacion.ToolTipIcon = ToolTipIcon.Info
    End Sub

    Private Sub btnLimpiarRegistro_MouseHover(sender As Object, e As EventArgs) Handles btnLimpiarRegistro.MouseHover
        Informacion.SetToolTip(btnLimpiar, "Limpia el Registro")
        Informacion.ToolTipTitle = "Limpiar"
        Informacion.ToolTipIcon = ToolTipIcon.Info
    End Sub

    Private Sub txtVender_MouseHover(sender As Object, e As EventArgs) Handles txtVender.MouseHover
        Informacion.SetToolTip(txtVender, "Escribir la Cantidad de Computadoras que desea Comprar")
        Informacion.ToolTipTitle = "Compra"
        Informacion.ToolTipIcon = ToolTipIcon.Info
    End Sub

    Private Sub btnVender_MouseHover(sender As Object, e As EventArgs) Handles btnVender.MouseHover
        Informacion.SetToolTip(btnVender, "Realiza Compra y Vende el Articulo")
        Informacion.ToolTipTitle = "Vender"
        Informacion.ToolTipIcon = ToolTipIcon.Info
    End Sub

    Private Sub txtCanComputadora_Validating(sender As Object, e As CancelEventArgs) Handles txtCanComputadora.Validating
        If Val(txtCantidad.Text) - Int(Val(txtCantidad.Text)) = 0 Then
            Me.ErrorProvider.SetError(sender, "")
        Else
            Me.ErrorProvider.SetError(sender, "Ingrese un numero entero")
        End If
    End Sub

    Private Sub txtMarca_Validating(sender As Object, e As CancelEventArgs) Handles txtMarca.Validating
        If DirectCast(sender, TextBox).Text.Length > 0 Then
            Me.ErrorProvider.SetError(sender, "")
        Else
            Me.ErrorProvider.SetError(sender, "Es un campo Obligatorio")
        End If
    End Sub

    Private Sub txtVender_Validating(sender As Object, e As CancelEventArgs) Handles txtVender.Validating
        If DirectCast(sender, TextBox).Text.Length > 0 Then
            Me.ErrorProvider.SetError(sender, "")
        Else
            Me.ErrorProvider.SetError(sender, "Es un campo obligatorio")
        End If
    End Sub

    Private Sub btnLimpiarVender_Click(sender As Object, e As EventArgs) Handles btnLimpiarVender.Click
        txtVender.Clear()
    End Sub

    Private Sub btnLimpiarVender_MouseHover(sender As Object, e As EventArgs) Handles btnLimpiarVender.MouseHover
        Informacion.SetToolTip(btnLimpiar, "Limpia la Venta")
        Informacion.ToolTipTitle = "Limpiar Venta"
        Informacion.ToolTipIcon = ToolTipIcon.Info
    End Sub

    Private Sub txtCant_Validating(sender As Object, e As CancelEventArgs) Handles txtCant.Validating
        If Val(txtCantidad.Text) - Int(Val(txtCantidad.Text)) = 0 Then
            Me.ErrorProvider.SetError(sender, "")
        Else
            Me.ErrorProvider.SetError(sender, "Ingrese un numero entero")
        End If
    End Sub
End Class