Public Class ArreglosVectores

    'Definir variables globales
    Private mComputadoras(,) As String
    Private cantComputadoras As Integer
    Private index As Byte
    Private encuentra As Boolean = False

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
        'Definicion de las variables
        Dim cant As Integer
        Dim comp() As String

        'Asignar tamaño
        cant = Val(txtCant.Text)
        ReDim comp(cant)

        'Solicitar la informacion
        For i = 1 To (comp.Length - 1) Step 1
            comp(i) = InputBox("Ingrese la marca de la PC", "Ingreso")
        Next

        'Mostrar la informacion
        For j = 1 To (comp.Length - 1) Step 1
            cmbSolicitar.Items.Add(comp(j))
        Next
    End Sub

    Private Sub btnLimpiar_Click(sender As Object, e As EventArgs) Handles btnLimpiar.Click
        'Limpiar los comboBox
        cmbComputadoras.Items.Clear()
        cmbPrecios.Items.Clear()
        cmbComputadoras.Text = 0
        cmbComputadoras.Text = 0
    End Sub

    Private Sub frmArreglosVectores_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtModelo.Enabled = False
        txtPrecio.Enabled = False
        txtCantidad.Enabled = False
    End Sub

    Private Sub btnRegistrar_Click(sender As Object, e As EventArgs) Handles btnRegistrar.Click
        cantComputadoras = Val(txtCanComputadora.Text)
        ReDim mComputadoras(cantComputadoras, 3)

        '3x3= comienza a contar desde 0
        For i = 0 To (cantComputadoras - 1) Step 1
            mComputadoras(i, 0) = InputBox("Ingrese la marca N." & (i + 1), "Registro")
            mComputadoras(i, 1) = InputBox("Ingrese el modelo N." & (i + 1), "Registro")
            mComputadoras(i, 2) = InputBox("Ingrese el precio N." & (i + 1), "Registro")
            mComputadoras(i, 3) = InputBox("Ingrese la cantidad N." & (i + 1), "Registro")
            index = i
        Next
    End Sub

    Private Sub btnBuscar_Click(sender As Object, e As EventArgs) Handles btnBuscar.Click
        'Definicion de las Variables
        Dim marca As String

        'Asignacion de la variable
        marca = txtMarca.Text

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
    End Sub

    Private Sub btnVender_Click(sender As Object, e As EventArgs) Handles btnVender.Click
        'Definicion de las variables
        Dim cantVender, stock As Integer

        'Asignar valor a las variables
        cantVender = Val(txtVender.Text)

        'Comenzar la evaluacion
        If (cantVender >= stock) Then
            MessageBox.Show("Sin Stock", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        Else
            MessageBox.Show("Venta Realizada", "Venta", MessageBoxButtons.OK, MessageBoxIcon.Information)
            txtCantidad.Text = txtCantidad.Text - cantVender
        End If
    End Sub

    Private Sub btnLimpiarVenta_Click(sender As Object, e As EventArgs) Handles btnLimpiarVenta.Click
        txtVender.Clear()
    End Sub

    Private Sub btnLimpiarRegistro_Click(sender As Object, e As EventArgs) Handles btnLimpiarRegistro.Click
        txtMarca.Clear()
        txtModelo.Clear()
        txtPrecio.Clear()
        txtCantidad.Clear()
    End Sub
End Class