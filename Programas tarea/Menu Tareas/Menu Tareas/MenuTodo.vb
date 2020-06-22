Public Class MenuTodo

    Private Sub btnRest_Click(sender As Object, e As EventArgs)
        btnRest.Visible = False
        btnMax.Visible = True
        Me.WindowState = FormWindowState.Normal
    End Sub

    Private Sub btnMenu_Click(sender As Object, e As EventArgs) Handles btnMenu.Click

        If (slideBar.Width = 239) Then

            slideBar.Visible = False
            slideBar.Width = 70
            panelOpciones.Width = 90
            lineaSideBar.Width = 50
            animacionSlideBar.Show(slideBar)

        Else

            slideBar.Visible = False
            slideBar.Width = 239
            panelOpciones.Width = 268
            lineaSideBar.Width = 215
            animacionSlidebarBack.Show(slideBar)

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

    Private Sub btnCerrar_Click_1(sender As Object, e As EventArgs) Handles btnCerrar.Click
        End

    End Sub

    Private Sub btnMin_Click_1(sender As Object, e As EventArgs) Handles btnMin.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub btnMax_Click_1(sender As Object, e As EventArgs) Handles btnMax.Click
        btnMax.Visible = False
        btnRest.Visible = True
        Me.WindowState = FormWindowState.Maximized
    End Sub

    Private Sub btnRest_Click_1(sender As Object, e As EventArgs) Handles btnRest.Click
        btnRest.Visible = False
        btnMax.Visible = True
        Me.WindowState = FormWindowState.Normal

    End Sub

    Private Sub OcultarSubClase()
        panelSubClase.Visible = False
        panelSubTarea.Visible = False

    End Sub

    Private Sub MostrarSubClase(opcionMenu As Panel)

        If opcionMenu.Visible = False Then
            OcultarSubClase()
            opcionMenu.Visible = True

        Else
            opcionMenu.Visible = False

        End If
    End Sub

    Private Sub btnArreglos_Click(sender As Object, e As EventArgs) Handles btnArreglos.Click
        abrirFormulario(Arreglos)
    End Sub

    Private Sub btnProgClas_Click_1(sender As Object, e As EventArgs) Handles btnProgClas.Click
        MostrarSubClase(panelSubClase)

    End Sub

    Private Sub btnProgTar_Click(sender As Object, e As EventArgs) Handles btnProgTar.Click
        MostrarSubClase(panelSubTarea)

    End Sub

    Private Sub btnHome_Click(sender As Object, e As EventArgs) Handles btnHome.Click
        abrirFormulario(Bienvenida)
    End Sub

    Private Sub btnLibretaAhorro_Click(sender As Object, e As EventArgs) Handles btnLibretaAhorro.Click
        abrirFormulario(LibretaAhorro)
    End Sub
End Class
