'Esta libreria nos servira para mover el formulario de un lado a otro
Imports System.Runtime.InteropServices
Public Class MenuPrincipal
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

    Private Sub PanelSuperior_MouseMove(sender As Object, e As MouseEventArgs) Handles PanelSuperior.MouseMove
        ReleaseCapture()
        SendMessage(Me.Handle, &H112&, &HF012&, 0)
    End Sub

    Private Sub timerOcultarMenu_Tick(sender As Object, e As EventArgs) Handles timerOcultarMenu.Tick
        'Esta condicion srive para ocultar el menu del formulario
        If PanelMenu.Width <= 60 Then
            Me.timerOcultarMenu.Enabled = False

        Else
            Me.PanelMenu.Width = PanelMenu.Width - 20
        End If
    End Sub

    Private Sub timerMostrarMenu_Tick(sender As Object, e As EventArgs) Handles timerMostrarMenu.Tick
        'Esta condicion es para mostrar el menu de nuevo
        If PanelMenu.Width >= 220 Then
            Me.timerMostrarMenu.Enabled = False
        Else
            Me.PanelMenu.Width = PanelMenu.Width + 20
        End If
    End Sub

    Private Sub btnMenu_Click(sender As Object, e As EventArgs) Handles btnMenu.Click
        If PanelMenu.Width = 220 Then
            timerOcultarMenu.Enabled = True
        ElseIf PanelMenu.Width = 60 Then
            timerMostrarMenu.Enabled = True
        End If
    End Sub

    'Funcion para abrir los otros formularios
    Private Sub abrirFormulario(ByVal formHijo As Object)
        If PanelCentral.Controls.Count > 0 Then
            Me.PanelCentral.Controls.RemoveAt(0)
        End If
        Dim frm As Form = TryCast(formHijo, Form)
        frm.TopLevel = False
        frm.Dock = DockStyle.Fill
        Me.PanelCentral.Controls.Add(frm)
        Me.PanelCentral.Tag = frm
        frm.Show()
    End Sub

    Private Sub btnMenuClase_Click(sender As Object, e As EventArgs) Handles btnMenuClase.Click
        abrirFormulario(New MenuClase)
    End Sub

    Private Sub btnArreglos_Click(sender As Object, e As EventArgs) Handles btnArreglos.Click
        abrirFormulario(New ArreglosYVectores)
    End Sub
End Class