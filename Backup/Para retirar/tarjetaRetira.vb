Public Class tarjetaRetira

    Private Sub Label3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label3.Click

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If TextBox1.Text.Length < 16 Or TextBox1.Text.Length > 16 Then
            MsgBox("El numero de la tarjeta debe contener 16 numeros")

        ElseIf TextBox2.Text.Length > 3 Or TextBox2.Text.Length < 3 Then
            MsgBox("El codigo de seguridad debe contener 3 numeros")

        ElseIf TextBox5.Text.Length < 2 Or TextBox5.Text.Length > 2 Then
            MsgBox("El Mes debe contener 2 numeros")
        ElseIf TextBox6.Text.Length < 2 Or TextBox6.Text.Length > 2 Then
            MsgBox("El Año debe contener 2 numeros")

        Else

            Dim f7 As New final2retira
            f7.Show()
            Me.Hide()

        End If
    End Sub

    Private Sub Label10_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label10.Click
        Dim f4 As New mediosPagoRetira
        f4.Show()
        Me.Hide()
    End Sub

    Private Sub Form5_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub
End Class