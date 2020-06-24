Imports System.ComponentModel

Public Class BolsaSolidaria
    Private info(9, 6), numId, nomComple, inte, depart, muni As String
    Private contador, usuario As Integer

    Private Sub btnIngresar_Click(sender As Object, e As EventArgs) Handles btnIngresar.Click
        usuario = 0
        numId = txtNumId.Text

        If numId.Length <> 13 Then
            MessageBox.Show("Ingrese un numero de identidad valido", "Ingreso", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtNumId.Clear()

        ElseIf compararId(numId) = 0 Then

            info(contador, 0) = txtNumId.Text
            info(contador, 1) = txtNomComp.Text
            info(contador, 2) = mtbIntegrantes.Text
            info(contador, 3) = txtDepart.Text
            info(contador, 4) = txtMuni.Text

            If chkPobreza.Checked = True Then
                info(contador, 5) = "Pobreza"

            Else
                info(contador, 5) = "Pobreza Extrema"

            End If

            If Val(info(contador, 2)) > 0 And Val(info(contador, 2)) <= 3 Then

                chkBasic.Checked = True
                info(contador, 6) = "Basica"
                txtBolsaBas.Text = "2 arroz, 1 aceite, 3 maseca, 4 frijoles, 4 maiz"

            Else
                chkRegul.Checked = True
                info(contador, 6) = "Regular"
                txtBolsaReg.Text = "4 arroz, 2 aceite, 6 maseca, 8 frijoles, 8 maiz"
            End If

            Do While numId <> info(usuario, 0)
                usuario += 1
            Loop

            imprimirDatos(usuario)

        Else
            MessageBox.Show("Ha ingresado una persona que ya ha sido beneficiada", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            limpiarTodo()

        End If
        contador += 1
    End Sub

    Private Function compararId(IdUsuario As String)
        Dim respuesta As Integer

        For i = 0 To 9 Step 1

            If IdUsuario = info(i, 0) Then
                respuesta = 1

            Else
                respuesta = 0

            End If
        Next

        If respuesta = 1 Then
            Return 1

        Else
            Return 0

        End If
    End Function

    Private Sub imprimirDatos(Posicion)

        dgvReporte.Rows.Add(info(Posicion, 0), info(Posicion, 1), info(Posicion, 2), info(Posicion, 3), info(Posicion, 4), info(Posicion, 5), info(Posicion, 6))

    End Sub

    Private Sub txtNumId_TextChanged(sender As Object, e As EventArgs) Handles txtNumId.TextChanged

    End Sub

    Private Sub txtNumId_Validating(sender As Object, e As CancelEventArgs) Handles txtNumId.Validating
        If DirectCast(sender, TextBox).Text.Length > 0 Then
            Me.ErrorValidacion.SetError(sender, "")
        Else
            Me.ErrorValidacion.SetError(sender, "Es un campo obligatorio")
        End If
    End Sub

    Private Sub limpiarTodo()
        txtNumId.Clear()
        txtNomComp.Clear()
        txtBolsaBas.Clear()
        txtBolsaReg.Clear()

        mtbIntegrantes.Clear()

        txtDepart.Clear()
        txtMuni.Clear()

        chkPobreza.Checked = False
        chkPobrezaExt.Checked = False
        chkBasic.Checked = False
        chkRegul.Checked = False
    End Sub
    Private Sub btnLimpiar_Click(sender As Object, e As EventArgs) Handles btnLimpiar.Click
        limpiarTodo()
    End Sub

    Private Sub chkPobreza_CheckedChanged(sender As Object, e As EventArgs) Handles chkPobreza.CheckedChanged
        If chkPobreza.Checked = True Then
            chkPobrezaExt.Enabled = False

        Else
            chkPobrezaExt.Enabled = True

        End If

    End Sub

    Private Sub chkPobrezaExt_CheckedChanged(sender As Object, e As EventArgs) Handles chkPobrezaExt.CheckedChanged
        If chkPobrezaExt.Checked = True Then
            chkPobreza.Enabled = False

        Else
            chkPobreza.Enabled = True

        End If

    End Sub

    Private Sub btnLimpiarlb_Click(sender As Object, e As EventArgs) Handles btnLimpiarlb.Click
        dgvReporte.Rows.Clear()

    End Sub

    Private Sub txtNomComp_TextChanged(sender As Object, e As EventArgs) Handles txtNomComp.TextChanged

    End Sub

    Private Sub txtNomComp_Validating(sender As Object, e As CancelEventArgs) Handles txtNomComp.Validating
        If DirectCast(sender, TextBox).Text.Length > 0 Then
            Me.ErrorValidacion.SetError(sender, "")
        Else
            Me.ErrorValidacion.SetError(sender, "Es un campo obligatorio")
        End If
    End Sub

    Private Sub txtDepart_TextChanged(sender As Object, e As EventArgs) Handles txtDepart.TextChanged

    End Sub

    Private Sub txtDepart_Validating(sender As Object, e As CancelEventArgs) Handles txtDepart.Validating
        If DirectCast(sender, TextBox).Text.Length > 0 Then
            Me.ErrorValidacion.SetError(sender, "")
        Else
            Me.ErrorValidacion.SetError(sender, "Es un campo obligatorio")
        End If
    End Sub

    Private Sub txtMuni_TextChanged(sender As Object, e As EventArgs) Handles txtMuni.TextChanged

    End Sub

    Private Sub txtMuni_Validating(sender As Object, e As CancelEventArgs) Handles txtMuni.Validating
        If DirectCast(sender, TextBox).Text.Length > 0 Then
            Me.ErrorValidacion.SetError(sender, "")
        Else
            Me.ErrorValidacion.SetError(sender, "Es un campo obligatorio")
        End If
    End Sub
End Class