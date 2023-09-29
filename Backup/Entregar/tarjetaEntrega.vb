Public Class tarjetaEntrega

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

            Dim f13 As New finalEntrega
            f13.Show()
            Me.Hide()

        End If


    End Sub

    Private Sub Panel1_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles Panel1.Paint

    End Sub

    Private Sub Label10_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label10.Click
        Dim f11 As New mediosPagoEntrega
        f11.Show()
        Me.Hide()
    End Sub

    Private Sub Label7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label7.Click

    End Sub

    Private Sub Label9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label9.Click

    End Sub

    Private Sub Label8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label8.Click

    End Sub

    Private Sub Label6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label6.Click

    End Sub

    Private Sub Label3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label3.Click

    End Sub

    Private Sub Label2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label2.Click

    End Sub

    Private Sub Label4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label4.Click

    End Sub

    Private Sub Label5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label5.Click

    End Sub

    Private Sub Form12_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub TextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox1.TextChanged

    End Sub
End Class