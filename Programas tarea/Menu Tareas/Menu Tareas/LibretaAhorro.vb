Imports System.ComponentModel

Public Class LibretaAhorro
    Private monto(), total As Double
    Private nombre, numId, numRegisId, pais, ciudad, datos(,) As String
    Private edad, contador, usuario, montoU As Integer

    'Procedimientos
    Private Sub activarControles()
        txtSaldo.Enabled = False
        btnRetirar.Enabled = True
        btnDepositar.Enabled = True
    End Sub

    Private Sub desactivarControles()
        txtSaldo.Enabled = True
        btnRegistrar.Enabled = True
        btnRetirar.Enabled = False
        btnDepositar.Enabled = False
    End Sub

    Private Sub limpiar()
        desactivarControles()
        mtbNumId.Clear()
        txtSaldo.Clear()
        lstDepositos.Items.Clear()
        lstRetiros.Items.Clear()

        mtbSalidaId.Clear()
        mtbEdad.Clear()
        txtNombre.Clear()
        txtPais.Clear()
        txtCiudad.Clear()

    End Sub

    Private Sub LibretaAhorro_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        desactivarControles()
    End Sub

    Private Sub mostrarSaldo(Posicion As Integer)
        txtSaldo.Text = monto(Posicion)

    End Sub

    Private Sub mostrarDatos(Posicion As Integer)
        mtbSalidaId.Text = datos(Posicion, 0)
        txtNombre.Text = datos(Posicion, 1)
        mtbEdad.Text = datos(Posicion, 2)
        txtPais.Text = datos(Posicion, 3)
        txtCiudad.Text = datos(Posicion, 4)

    End Sub

    Private Function leer(mensaje As String)
        Dim cantidad As Double
        cantidad = InputBox("Ingrese un monto a" & mensaje, "Operación")
        mostrarSaldo(usuario)

        Return cantidad
    End Function

    Private Sub btnCalcular_Click(sender As Object, e As EventArgs) Handles btnCalcular.Click
        Dim Inte As Double

        Inte = monto(contador) * 0.3

        txtInteres.Text = Inte
        txtTotal.Text = monto(contador) + Inte

    End Sub

    Private Sub btnRegistrar_Click(sender As Object, e As EventArgs) Handles btnRegistrar.Click
        numId = mtbNumId.Text
        limpiar()

        ReDim datos(10, 5)
        ReDim monto(10)

        If numId.Length <> 15 Then
            MessageBox.Show("Ingrese un numero de identidad valido", "Registro", MessageBoxButtons.OK, MessageBoxIcon.Warning)

        Else
            MessageBox.Show("Numero de identidad correcto,
Por favor llene los siguientes datos:", "Registro", MessageBoxButtons.OK, MessageBoxIcon.Information)

            datos(contador, 0) = numId
            datos(contador, 1) = InputBox("Ingrese su primer nombre y primer apellido", "Registro")
            datos(contador, 2) = InputBox("Ingrese su edad", "Registro")
            datos(contador, 3) = InputBox("Ingrese su pais", "Registro")
            datos(contador, 4) = InputBox("Ingrese la ciudad en la que reside", "Registro")
            monto(contador) = InputBox("Ingrese un monto inicial para su cuenta", "Registro")

            mtbNumId.Clear()
            contador += 1
        End If
    End Sub

    Private Sub btnIngresar_Click(sender As Object, e As EventArgs) Handles btnIngresar.Click
        numRegisId = mtbIngresoId.Text
        usuario = 0
        If numRegisId.Length <> 15 Then
            MessageBox.Show("Ingrese un numero de identidad valido", "Registro", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            mtbIngresoId.Clear()
        Else

            Do
                usuario += 1
                Exit Do
            Loop While numRegisId <> datos(usuario, 0)

            MessageBox.Show("Numero de identidad correcto", "Registro", MessageBoxButtons.OK, MessageBoxIcon.Information)
            mostrarSaldo(usuario)
            mostrarDatos(usuario)
            mtbIngresoId.Clear()
            activarControles()

        End If
    End Sub

    Private Sub btnLimpiar_Click(sender As Object, e As EventArgs) Handles btnLimpiar.Click
        limpiar()
    End Sub

    Private Sub btnDepositar_Click(sender As Object, e As EventArgs) Handles btnDepositar.Click
        Dim deposito As Double

        monto(usuario) = Val(txtSaldo.Text)

        If (monto(usuario) > 0) Then
            activarControles()
            mostrarSaldo(usuario)

        Else
            MessageBox.Show("Monto mayor a 0", "Ingresar monto correcto", MessageBoxButtons.OK, MessageBoxIcon.Error)

        End If

        deposito = leer("Depositar")
        monto(usuario) += deposito
        lstDepositos.Items.Add(deposito)
        mostrarSaldo(usuario)
    End Sub

    Private Sub btnRetirar_Click(sender As Object, e As EventArgs) Handles btnRetirar.Click
        Dim retiro As Double

        monto(usuario) = Val(txtSaldo.Text)

        If (monto(usuario) > 0) Then
            activarControles()
            mostrarSaldo(usuario)

        Else
            MessageBox.Show("Monto mayor a 0", "Ingresar monto correcto", MessageBoxButtons.OK, MessageBoxIcon.Error)

        End If

        retiro = leer("Retirar")
        If (retiro > monto(usuario)) Then
            MessageBox.Show("Saldo insuficiente", "Deposite mas", MessageBoxButtons.OK, MessageBoxIcon.Information)

        Else
            monto(usuario) -= retiro
            lstRetiros.Items.Add(retiro)
            mostrarSaldo(usuario)

        End If
    End Sub
End Class