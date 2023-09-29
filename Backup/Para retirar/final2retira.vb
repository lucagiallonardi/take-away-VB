Public Class final2retira

    Private Sub Form7_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Label3.Text = "Su pedido estará listo en " & T & " minutos"
        Label4.Text = "Podrá retirarlo por nuestro local en " & Domicilio
    End Sub

    Private Sub Label4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label4.Click

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        enviarPedido(True, formaDePago.transferencia)
        Me.Close()

    End Sub
End Class