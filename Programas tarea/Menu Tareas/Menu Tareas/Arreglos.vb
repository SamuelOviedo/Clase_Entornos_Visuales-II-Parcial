Public Class Arreglos

    Private Sub btnGenerar_Click(sender As Object, e As EventArgs) Handles btnGenerar.Click

        Dim computadoras(3) As String

        computadoras(0) = "Toshiba"
        computadoras(1) = "Dell"
        computadoras(2) = "Asus"
        computadoras(3) = "MAC"

        For i = 0 To (computadoras.Length - 1) Step 1
            cmbComputadoras.Items.Add(computadoras(i))

        Next

    End Sub

    Private Sub btnSolicitar_Click(sender As Object, e As EventArgs) Handles btnSolicitar.Click

        Dim precio(3) As Integer

        precio(0) = 22500
        precio(1) = 21000
        precio(2) = 29000
        precio(3) = 42000

        For i = 0 To (precio.Length - 1) Step 1
            cmbPrecios.Items.Add(precio(i))

        Next

    End Sub

    Private Sub btnSolicitarInput_Click(sender As Object, e As EventArgs) Handles btnSolicitarInput.Click

        Dim cant As Integer
        Dim comp() As String

        cant = Val(txtCant.Text) - 1
        ReDim comp(cant)

        For i = 0 To (comp.Length - 1) Step 1
            comp(i) = InputBox("Ingrese la marca de la pc", "Ingreso")

        Next

        For j = 0 To (comp.Length - 1) Step 1
            cmbCompus.Items.Add(comp(j))

        Next

    End Sub

    Private Sub btnLimpiar_Click(sender As Object, e As EventArgs) Handles btnLimpiar.Click

        cmbComputadoras.Items.Clear()
        cmbPrecios.Items.Clear()
        cmbCompus.Items.Clear()
        txtCant.Clear()

    End Sub

    Private Sub btnHome_Click(sender As Object, e As EventArgs) Handles btnHome.Click
        Me.Close()
    End Sub
End Class