Imports System.Runtime.InteropServices
Public Class Menu
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

    Private Sub btnCerrar_Click(sender As Object, e As EventArgs) Handles btnCerrar.Click
        End
    End Sub

    Private Sub btnMenu_Click(sender As Object, e As EventArgs)
        'Ocultar Menu
        timerOcultarMenu.Enabled = True
    End Sub

    Private Sub PanelSuperior_MouseMove(sender As Object, e As MouseEventArgs) Handles PanelSuperior.MouseMove
        ReleaseCapture()
        SendMessage(Me.Handle, &H112&, &HF012&, 0)
    End Sub

    Private Sub timerOcultarMenu_Tick(sender As Object, e As EventArgs) Handles timerOcultarMenu.Tick
        'Sirve para ocultar el menu en el instante que no se utiliza
        'y el otro es para mostrarlo y usarlo
        If PanelMenu.Width <= 45 Then
            Me.timerOcultarMenu.Enabled = False
        Else
            Me.PanelMenu.Width = PanelMenu.Width - 20
        End If
    End Sub

    Private Sub timerMostrarMenu_Tick(sender As Object, e As EventArgs) Handles timerMostrarMenu.Tick
        'Sirve para ocultar el menu en el instante que no se utiliza
        'y el otro es para mostrarlo y usarlo
        If PanelMenu.Width >= 165 Then
            Me.timerMostrarMenu.Enabled = False
        Else
            Me.PanelMenu.Width = PanelMenu.Width + 20
        End If
    End Sub

    'Funcion para abrir los otros formularios
    Private Sub abrirFormulario(ByVal formHijo As Object)
        If PanelFormularios.Controls.Count > 0 Then
            Me.PanelFormularios.Controls.RemoveAt(0)
        End If
        Dim frm As Form = TryCast(formHijo, Form)
        frm.TopLevel = False
        frm.Dock = DockStyle.Fill
        Me.PanelFormularios.Controls.Add(frm)
        Me.PanelFormularios.Tag = frm
        frm.Show()
    End Sub

    Private Sub btnProductos_Click(sender As Object, e As EventArgs) Handles btnProductos.Click
        abrirFormulario(frmProductos)
    End Sub

    Private Sub btnClientes_Click(sender As Object, e As EventArgs) Handles btnClientes.Click
        abrirFormulario(frmClientes)
    End Sub

    Private Sub btnMenu_Click_1(sender As Object, e As EventArgs) Handles btnMenu.Click
        If PanelMenu.Width = 165 Then
            timerOcultarMenu.Enabled = True
        ElseIf PanelSuperior.Width = 45 Then
            timerMostrarMenu.Enabled = True
        End If
    End Sub
End Class
