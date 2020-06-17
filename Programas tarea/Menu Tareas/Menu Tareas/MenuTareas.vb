Public Class MenuTareas
    Private Sub btnCerrar_Click(sender As Object, e As EventArgs) Handles btnCerrar.Click
        End

    End Sub

    Private Sub btnMin_Click(sender As Object, e As EventArgs) Handles btnMin.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub btnMax_Click(sender As Object, e As EventArgs) Handles btnMax.Click
        btnMax.Visible = False
        btnRest.Visible = True
        Me.WindowState = FormWindowState.Maximized

    End Sub

    Private Sub btnRest_Click(sender As Object, e As EventArgs) Handles btnRest.Click
        btnRest.Visible = False
        btnMax.Visible = True
        Me.WindowState = FormWindowState.Normal
    End Sub

    Private Sub btnMenu_Click(sender As Object, e As EventArgs) Handles btnMenu.Click

        If (slideBar.Width = 232) Then

            'slideBar.Visible = False
            slideBar.Width = 58
            panelOpciones.Width = 80
            lineaSideBar.Width = 40
            'AnimacionSidebar.Show(slideBar)
        Else

            'slideBar.Visible = False
            slideBar.Width = 232
            panelOpciones.Width = 260
            lineaSideBar.Width = 215
            'AnimacionSidebarBack.Show(Sidebar)
        End If

    End Sub

    Private Sub abrirFormulario(ByVal formHijo As Object)

        If panelContenido.Controls.Count > 0 Then

            Me.panelContenido.Controls.RemoveAt(0)
        End If

        Dim frm As Form = TryCast(formHijo, Form)

        frm.TopLevel = False
        frm.Dock = DockStyle.Fill

        Me.panelContenido.Controls.Add(frm)
        Me.panelContenido.Tag = frm

        frm.Show()
    End Sub

    Private Sub btnPrimera_Click(sender As Object, e As EventArgs) Handles btnPrimera.Click
        abrirFormulario(PrimeraTarea)
    End Sub
End Class
