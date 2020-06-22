Public Class Arreglos
    Private mComputadoras(,) As String
    Private cantComputadoras As Integer
    Private index As Byte
    Private encuentra As Boolean = False

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
        cmbComputadoras.Text = ""
        cmbComputadoras.Items.Clear()
        cmbPrecios.Text = ""
        cmbPrecios.Items.Clear()
        cmbCompus.Text = ""
        cmbCompus.Items.Clear()
        txtCant.Clear()
        txtMarca.Clear()
        txtModelo.Clear()
        txtPrecio.Clear()
        txtCantidad.Clear()
        txtCantVender.Clear()

    End Sub

    Private Sub Arreglos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtCantidad.Enabled = False
        txtPrecio.Enabled = False
        txtModelo.Enabled = False
        txtCantVender.Enabled = False
    End Sub

    Private Sub btnRegist_Click(sender As Object, e As EventArgs) Handles btnRegist.Click

        cantComputadoras = Val(txtCantComp.Text)
        ReDim mComputadoras(cantComputadoras, 3)

        For i = 0 To (cantComputadoras - 1) Step 1

            mComputadoras(i, 0) = InputBox("Ingrese la marca N." & (i + 1), "Registro")
            mComputadoras(i, 1) = InputBox("Ingrese el modelo N." & (i + 1), "Registro")
            mComputadoras(i, 2) = InputBox("Ingrese el precio N." & (i + 1), "Registro")
            mComputadoras(i, 3) = InputBox("Ingrese la cantidad N." & (i + 1), "Registro")
            index = i
        Next

        txtCantComp.Clear()
    End Sub

    Private Sub btnBuscar_Click(sender As Object, e As EventArgs) Handles btnBuscar.Click
        Dim marca As String
        marca = txtMarca.Text.ToLower

        For i = 0 To (cantComputadoras - 1) Step 1
            If (mComputadoras(i, 0).ToLower = marca) Then
                txtModelo.Text = mComputadoras(i, 1)
                txtPrecio.Text = mComputadoras(i, 2)
                txtCantidad.Text = mComputadoras(i, 3)
                encuentra = True
                txtCantVender.Enabled = True
                btnVender.Enabled = True
                btnBuscar.Enabled = True
            End If
        Next
        If (encuentra = False) Then
            MessageBox.Show("Lo sentimos, pero no contamos 
con el ordenador ingresado", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtMarca.Clear()
        End If
    End Sub

    Private Sub btnVender_Click(sender As Object, e As EventArgs) Handles btnVender.Click
        Dim cantVender, stock As Integer

        cantVender = Val(txtCantVender.Text)
        stock = mComputadoras(index, 3)

        If cantVender > stock Then
            MessageBox.Show("El stock es insuficiente", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)

        ElseIf cantVender = stock Then
            MessageBox.Show("Stock vacío", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtCantidad.Text = "0"

        Else
            mComputadoras(index, 3) = stock - cantVender
            MessageBox.Show("Venta Realizada", "Venta", MessageBoxButtons.OK, MessageBoxIcon.Information)
            txtCantidad.Text = mComputadoras(index, 3)
        End If
    End Sub

    Private Sub btnLimpiarEsp_Click(sender As Object, e As EventArgs) Handles btnLimpiarEsp.Click
        txtMarca.Clear()
        txtCantVender.Clear()

    End Sub

    Private Sub btnGenerarOrd_Click(sender As Object, e As EventArgs) Handles btnGenerarOrd.Click
        Dim computadoras(3) As String
        computadoras(0) = "Toshiba"
        computadoras(1) = "Dell"
        computadoras(2) = "Asus"
        computadoras(3) = "MAC"
        For i = 0 To (computadoras.Length - 1) Step 1
            cmbComputadoras.Items.Add(computadoras(i))
        Next
    End Sub

    Private Sub btnGenerarPre_Click(sender As Object, e As EventArgs) Handles btnGenerarPre.Click
        Dim precio(3) As Integer
        precio(0) = 22500
        precio(1) = 21000
        precio(2) = 29000
        precio(3) = 42000
        For i = 0 To (precio.Length - 1) Step 1
            cmbPrecios.Items.Add(precio(i))
        Next
    End Sub
End Class