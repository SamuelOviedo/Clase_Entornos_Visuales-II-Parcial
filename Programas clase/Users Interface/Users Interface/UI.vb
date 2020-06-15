Imports System.Runtime.InteropServices
Public Class UI

    <DllImport("user32.DLL", EntryPoint:="ReleaseCapture")>
    Private Shared Sub ReleaseCapture()
    End Sub

    <DllImport("user32.DLL", EntryPoint:="SendMessage")>
    Private Shared Sub SendMessage(ByVal hWnd As System.IntPtr, ByVal wMsg As Integer, ByVal wParam As Integer, ByVal lParam As Integer)
    End Sub

    Private Sub btnCerrar_Click(sender As Object, e As EventArgs) Handles btnCerrar.Click
        End

    End Sub

    Private Sub PanelSuperior_Paint(sender As Object, e As PaintEventArgs) Handles panelSuperior.Paint

    End Sub

    Private Sub PanelSuperior_MouseMove(sender As Object, e As MouseEventArgs) Handles panelSuperior.MouseMove
        ReleaseCapture()
        SendMessage(Me.Handle, &H112&, &HF012&, 0)
    End Sub

    Private Sub btnMaximizar_Click(sender As Object, e As EventArgs) Handles btnMaximizar.Click
        btnMaximizar.Visible = False
        btnRestaurar.Visible = True
        Me.WindowState = FormWindowState.Maximized
    End Sub

    Private Sub btnMinimizar_Click(sender As Object, e As EventArgs) Handles btnMinimizar.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub btnRestaurar_Click(sender As Object, e As EventArgs) Handles btnRestaurar.Click
        btnRestaurar.Visible = False
        btnMaximizar.Visible = True
        Me.WindowState = FormWindowState.Normal
    End Sub

    Private Sub TimerOcultarMenu_Tick(sender As Object, e As EventArgs) Handles timerOcultarMenu.Tick
        If panelLateral.Width <= 45 Then
            Me.timerOcultarMenu.Enabled = False
        Else
            Me.PanelLateral.Width = PanelLateral.Width - 20
        End If
    End Sub

    Private Sub TimerMostrar_Tick(sender As Object, e As EventArgs) Handles timerMostrarMenu.Tick
        If panelLateral.Width >= 165 Then
            Me.timerMostrarMenu.Enabled = False
        Else
            Me.panelLateral.Width = panelLateral.Width + 20
        End If
    End Sub

    Private Sub btnMenu_Click(sender As Object, e As EventArgs) Handles btnMenu.Click
        If panelLateral.Width = 165 Then
            timerOcultarMenu.Enabled = True
        ElseIf panelLateral.Width = 45 Then
            timerMostrarMenu.Enabled = True
        End If
    End Sub

    Private Sub abrirFormulario(ByVal formHijo As Object)
        If panelForms.Controls.Count > 0 Then
            Me.panelForms.Controls.RemoveAt(0)
        End If
        Dim frm As Form = TryCast(formHijo, Form)
        frm.TopLevel = False
        frm.Dock = DockStyle.Fill
        Me.panelForms.Controls.Add(frm)
        Me.panelForms.Tag = frm
        frm.Show()
    End Sub

    Private Sub btnProductos_Click(sender As Object, e As EventArgs) Handles btnProductos.Click
        abrirFormulario(frmProductos)
    End Sub

    Private Sub btnEmpleados_Click(sender As Object, e As EventArgs) Handles btnEmpleados.Click
        abrirFormulario(frmEmpleados)
    End Sub

End Class
