'Esta libreria nos servira para mover el formulario de un lado a otro
Imports System.Runtime.InteropServices

Public Class Menu_Clase

    <DllImport("user32.DLL", EntryPoint:="ReleaseCapture")>
    Private Shared Sub ReleaseCapture()
    End Sub

    <DllImport("user32.DLL", EntryPoint:="SendMessage")>
    Private Shared Sub SendMessage(ByVal hWnd As System.IntPtr, ByVal wMsg As Integer, ByVal wParam As Integer, ByVal lParam As Integer)
    End Sub

    Private Sub btnCerrar_Click(sender As Object, e As EventArgs) Handles btnCerrar.Click
        Me.Close()
    End Sub

    Private Sub btnMaximizar_Click(sender As Object, e As EventArgs) Handles btnMaximizar.Click
        'Ocultar el boton de maximizar para que aparesca el boton de restaurar
        btnMaximizar.Visible = False
        btnRestaurar.Visible = True

        'Maximizar el formulario
        Me.WindowState = FormWindowState.Maximized

    End Sub

    Private Sub btnRestaurar_Click(sender As Object, e As EventArgs) Handles btnRestaurar.Click
        'Ocultar el boton de restaurar para qeu aparesca el boton de maximizar
        btnRestaurar.Visible = False
        btnMaximizar.Visible = True

        'Restaurar la pantalla
        Me.WindowState = FormWindowState.Normal
    End Sub

    Private Sub btnMinimizar_Click(sender As Object, e As EventArgs) Handles btnMinimizar.Click
        Me.WindowState = FormWindowState.Minimized
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

    'Esta funcion permite agregar un formularios en la 
    'pantalla del menu
    Private Sub abrirFomEnElPanel(ByVal FormHijo As Object)
        If Me.PanelCentral.Controls.Count > 0 Then
            Me.PanelCentral.Controls.RemoveAt(0)
            'Definir una variable de tipo formulario
            Dim fomHijo As Form = TryCast(FormHijo, Form)
            fomHijo.TopLevel = False
            fomHijo.FormBorderStyle = Windows.Forms.FormBorderStyle.None
            fomHijo.Dock = DockStyle.Fill
            Me.PanelCentral.Controls.Add(fomHijo)
            Me.PanelCentral.Tag = fomHijo
            fomHijo.Show()
        End If
    End Sub
End Class