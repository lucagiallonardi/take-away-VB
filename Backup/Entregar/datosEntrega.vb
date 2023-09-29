Public Class datosEntrega

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Domicilio = TextBox2.Text
        Cliente = TextBox1.Text
        Aclaracion = RichTextBox1.Text

        If TextBox1.Text = "" Or TextBox2.Text = "" Or RichTextBox1.Text = "" Then
            MsgBox("Por favor complete todos los datos de entrega")
        Else
            Dim f11 As New mediosPagoEntrega
            f11.Show()
            Me.Hide()
        End If
    End Sub

    Private Sub TextBox2_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox2.TextChanged

    End Sub

    Private Sub Form9_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Label10_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label10.Click
        Dim f2 As New menu
        f2.Show()
        Me.Hide()
    End Sub
End Class