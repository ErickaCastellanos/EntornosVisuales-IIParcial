Public Class LibretaDeBanco
    Dim rangoIdentidad As String = 13
    Dim id As String = "0501199807359"

    'Definir Arreglo
    Private Campos() As String = {"Ericka", "22", "Honduras", "Las Vegas", "20000", "700"}

    'Definir variable global
    Dim monto As Integer

    'Procedimientos no retornan un valor pero si realiza una operacion
    'Activar los controles
    Private Sub activarControles()
        txtIdentidad.Enabled = False
        txtMonto.Enabled = False
        btnAperturar.Enabled = False
        btnRetirar.Enabled = True
        btnDepositar.Enabled = True
    End Sub

    'Desactivar Controles
    Private Sub desactivarControles()
        txtIdentidad.Enabled = True
        txtCiudad.Enabled = False
        txtNombre.Enabled = False
        txtPais.Enabled = False
        txtMonto.Enabled = False
        txtEdad.Enabled = False
        txtSaldoTotal.Enabled = False
        txtIntereses.Enabled = False
        btnAperturar.Enabled = True
        btnRetirar.Enabled = False
        btnDepositar.Enabled = False
    End Sub

    'Limpiar
    Private Sub limpiar()
        desactivarControles()
        txtIdentidad.Clear()
        txtIntereses.Clear()
        txtSaldoTotal.Clear()
        txtCiudad.Clear()
        txtNombre.Clear()
        txtPais.Clear()
        txtMonto.Clear()
        txtEdad.Clear()
        lstDepositos.Items.Clear()
        lstRetiros.Items.Clear()
    End Sub

    'Mostrar Saldo al Usuario
    Private Sub mostrarSaldo()
        txtSaldoTotal.Text = monto
    End Sub

    'Al iniciar el programa de inmediato se desactivaran los controles
    Private Sub LibretaDeAhorro_Funciones_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        desactivarControles()
    End Sub

    Private Sub btnAperturar_Click(sender As Object, e As EventArgs) Handles btnAperturar.Click
        'Definicion de las variables
        Dim cliente As String
        Dim aTextbox() As TextBox = {txtNombre, txtEdad, txtPais, txtCiudad, txtMonto, txtIntereses}

        'Asignar valor a la variable
        cliente = txtIdentidad.Text
        monto = Val(txtMonto.Text)

        'Evaluar si el monto es mayor a 0 para realizar el deposito o si no
        'mostrar un mensaje
        If cliente = id Then
            activarControles()

            'Cargar los campos con sus datos correspondientes
            For i As Integer = 0 To 5
                aTextbox(i).Text = Campos(i).ToString
            Next
        Else
            MessageBox.Show("Esta Identidad no existe en el Sistema de Cuentas", "Identidad", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If

    End Sub

    'Crear una funcion para la funcionalidad de los botones 
    Private Function leer(mensaje As String)
        'Definir las variables
        Dim cantidad As Double

        'Mostrar mensaje solicitando los datos
        cantidad = InputBox("Digite el Monto a " & mensaje, "Operacion")
        mostrarSaldo()

        'Retornar la respuesta
        Return cantidad
    End Function

    Private Sub btnDepositar_Click(sender As Object, e As EventArgs) Handles btnDepositar.Click
        'Definicion de variables
        Dim deposito As Double

        'Asignar un valor a la variable
        deposito = leer("Depositar")

        'Realizar el procedimiento
        monto += deposito
        lstDepositos.Items.Add(deposito)
        mostrarSaldo()
    End Sub

    Private Sub btnRetirar_Click(sender As Object, e As EventArgs) Handles btnRetirar.Click
        'Definicion de variables
        Dim retirar As Double

        'Asignar un valor a la variable
        retirar = leer("Retirar")

        'Realizar el procedimiento
        If retirar > monto Then
            MessageBox.Show("No cuenta con la cantidad que desea Retirar", "Retiros", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            monto -= retirar
            lstRetiros.Items.Add(retirar)
            mostrarSaldo()
        End If

    End Sub

    Private Sub btnLimpiar_Click(sender As Object, e As EventArgs) Handles btnLimpiar.Click
        limpiar()
    End Sub
End Class