Imports System.Net
Imports System.Net.Mail

Public Enum formaDePago
    efectivo
    debito
    credito
    transferencia
End Enum

Module Confirmar
    Function enviarPedido(ByVal retira As Boolean, ByVal pago As formaDePago)
        'convierto el array que tiene los productos a una sola cadena de texto
        Dim pedido As String = ""
        For i As Integer = 0 To 9
            If productosTotal(i) IsNot Nothing Then
                pedido += productosTotal(i) & vbCrLf
            End If

        Next

        Try
            'usamos el servicio SMTP de outlook
            Dim Message As New System.Net.Mail.MailMessage()
            Dim SMTP As New System.Net.Mail.SmtpClient
            'mail configurado para enviar los datos
            SMTP.Credentials = New System.Net.NetworkCredential("pizzasdelcentro123@outlook.com", "ly785612")
            SMTP.Host = "smtp.office365.com"
            SMTP.Port = 587
            SMTP.EnableSsl = True

            ' CONFIGURACION DEL MENSAJE
            'Este es el mail que recibe los datos, se puede modificar a eleccion para probar
            Message.To.Add("lgiallonardi@gmail.com")
            Message.From = New System.Net.Mail.MailAddress("pizzasdelcentro123@outlook.com", "Pizzas del Centro", System.Text.Encoding.UTF8)
            Message.Subject = "Pedido realizado desde la app"
            Message.SubjectEncoding = System.Text.Encoding.UTF8

            'convierto el booleano de la entrega en una cadena de texto
            Dim formaDelivery As String = "Entrega en domicilio"
            If retira Then
                formaDelivery = "Retira en local"
            End If

            ' datos del pedido realizado:
            Message.Body = "Pedidio realizado por " & Cliente & ":  " & pedido & vbCrLf & _
                            "Total en pesos: $ " & P & vbCrLf & _
                            "Forma de entrega: " & formaDelivery & vbCrLf & _
                            "Direccion de envio: " & Domicilio & vbCrLf & _
                            "Forma de Pago: " & formaDePago.efectivo.ToString & vbCrLf & _
                            "Aclaraciones: " & Aclaracion

            '---------------------------------------------------------------------------------------------------------------------
            Message.BodyEncoding = System.Text.Encoding.UTF8
            Message.Priority = System.Net.Mail.MailPriority.Normal
            Message.IsBodyHtml = False
            SMTP.Send(Message)
            MessageBox.Show("El pedido se envió correctamente.", "¡Gracias!", MessageBoxButtons.OK, MessageBoxIcon.Information)

        Catch ex As Exception
            MessageBox.Show("Error al enviar el pedido: " & ex.Message, "Lo sentimos...", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Function

End Module
