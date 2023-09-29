Public Class finalRetira

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        enviarPedido(True, formaDePago.efectivo)
        Me.Close()
    End Sub

    Private Sub Form8_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Label3.Text = "Su pedido estará listo en " & T & " minutos"
        Label4.Text = "Podrá retirarlo por nuestro local en " & Domicilio


    End Sub
End Class