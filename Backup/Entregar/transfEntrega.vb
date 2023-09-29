Public Class transfEntrega

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim f13 As New finalEntrega
        f13.Show()
        Me.Hide()
    End Sub

    Private Sub Label10_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label10.Click
        Dim f11 As New mediosPagoEntrega
        f11.Show()
        Me.Hide()
    End Sub
End Class