Public Class final2Entrega

    Private Sub Form15_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Label3.Text = "Tu pedido será entregado en " & T & " minutos aproximadamente "
        Label4.Text = Domicilio
        Label6.Text = "(" & Aclaracion & ")"
        Label8.Text = Cliente
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        enviarPedido(False, formaDePago.efectivo)
        Me.Close()
    End Sub


    Private Sub Label3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label3.Click

    End Sub
End Class