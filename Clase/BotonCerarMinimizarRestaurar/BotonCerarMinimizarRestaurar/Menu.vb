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

    Private Sub btnMenu_Click(sender As Object, e As EventArgs) Handles btnMenu.Click
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
        If PanelMenu.Width >= 210 Then
            Me.timerOcultarMenu.Enabled = False

        Else
            Me.PanelMenu.Width = PanelMenu.Width - 20
        End If
    End Sub

    Private Sub timerMostrarMenu_Tick(sender As Object, e As EventArgs) Handles timerMostrarMenu.Tick
        'Sirve para ocultar el menu en el instante que no se utiliza
        'y el otro es para mostrarlo y usarlo
        If PanelMenu.Width >= 210 Then
            Me.timerOcultarMenu.Enabled = False

        Else
            Me.PanelMenu.Width = PanelMenu.Width + 20
        End If
    End Sub

    Private Sub btnMenu_MouseMove(sender As Object, e As MouseEventArgs) Handles btnMenu.MouseMove
        'Ocultar Menu
        timerOcultarMenu.Enabled = True
    End Sub
End Class
