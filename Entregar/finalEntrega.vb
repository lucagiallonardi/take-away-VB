Public Class finalEntrega

    Private Sub Form13_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Label3.Text = "Tu pedido será entregado en " & T & " minutos aproximadamente "
        Label4.Text = Domicilio
        Label6.Text = "(" & Aclaracion & ")"
        Label8.Text = Cliente
    End Sub

    Private Sub Label2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label2.Click

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        enviarPedido(False, formaDePago.transferencia)

        Me.Close()
    End Sub


End Class