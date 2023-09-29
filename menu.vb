Public Class menu

    Private Sub Form2_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load


        'PRODUCTO 1'
        Dim Producto1 As Productos = New Productos()
        Producto1.Nombre = "Hamburguesa con queso"
        Producto1.Precio = 10
        Producto1.Descripcion = "Hamburguesa de carne con queso cheddar"
        Producto1.Tiempo = 5

        nombre1.Text = Producto1.Nombre
        Descripcion1.Text = Producto1.Descripcion
        Precio1.Text = "$ " & Producto1.Precio


        'PRODUCTO 2'
        Dim Producto2 As Productos = New Productos()
        Producto2.Nombre = "Hamburguesa cheddar y panceta"
        Producto2.Precio = 15
        Producto2.Descripcion = "Hamburguesa de carne con queso cheddar y panceta crocante"
        Producto2.Tiempo = 5

        nombre2.Text = Producto2.Nombre
        Descripcion2.Text = Producto2.Descripcion
        Precio2.Text = "$ " & Producto2.Precio


        'PRODUCTO 3'
        Dim Producto3 As Productos = New Productos()
        Producto3.Nombre = "Hamburguesa completa"
        Producto3.Precio = 15
        Producto3.Descripcion = "Hamburguesa de carne con queso, tomate y lechuga"
        Producto3.Tiempo = 5

        nombre3.Text = Producto3.Nombre
        Descripcion3.Text = Producto3.Descripcion
        Precio3.Text = "$ " & Producto3.Precio


        'PRODUCTO 4'
        Dim Producto4 As Productos = New Productos()
        Producto4.Nombre = "Papas fritas"
        Producto4.Precio = 10
        Producto4.Descripcion = "Porción de papas fritas"
        Producto4.Tiempo = 2

        nombre4.Text = Producto4.Nombre
        Descripcion4.Text = Producto4.Descripcion
        Precio4.Text = "$ " & Producto4.Precio


        'PRODUCTO 5'
        Dim Producto5 As Productos = New Productos()
        Producto5.Nombre = "Agua mineral"
        Producto5.Precio = 5
        Producto5.Descripcion = "Agua mineral con o sin gas"
        Producto5.Tiempo = 0

        nombre5.Text = Producto5.Nombre
        Descripcion5.Text = Producto5.Descripcion
        Precio5.Text = "$ " & Producto5.Precio



        'PRODUCTO 6'
        Dim Producto6 As Productos = New Productos()
        Producto6.Nombre = "Gaseosa"
        Producto6.Precio = 5
        Producto6.Descripcion = "Coca-cola, Sprite o Fanta"
        Producto6.Tiempo = 0

        nombre6.Text = Producto6.Nombre
        Descripcion6.Text = Producto6.Descripcion
        Precio6.Text = "$ " & Producto6.Precio


        'PRODUCTO 7'
        Dim Producto7 As Productos = New Productos()
        Producto7.Nombre = "Cerveza"
        Producto7.Precio = 10
        Producto7.Descripcion = "Rubia, roja o negra"
        Producto7.Tiempo = 0

        nombre7.Text = Producto7.Nombre
        Descripcion7.Text = Producto7.Descripcion
        Precio7.Text = "$ " & Producto7.Precio



        'PRODUCTO 8'
        Dim Producto8 As Productos = New Productos()
        Producto8.Nombre = "Flan"
        Producto8.Precio = 20
        Producto8.Descripcion = "Flan casero con crema y dulce de leche"
        Producto8.Tiempo = 1

        nombre8.Text = Producto8.Nombre
        Descripcion8.Text = Producto8.Descripcion
        Precio8.Text = "$ " & Producto8.Precio


        'PRODUCTO 9'
        Dim Producto9 As Productos = New Productos()
        Producto9.Nombre = "Torta oreo"
        Producto9.Precio = 20
        Producto9.Descripcion = "Porción individual de torta oreo"
        Producto9.Tiempo = 1

        nombre9.Text = Producto9.Nombre
        Descripcion9.Text = Producto9.Descripcion
        Precio9.Text = "$ " & Producto9.Precio


        'PRODUCTO 10'
        Dim Producto10 As Productos = New Productos()
        Producto10.Nombre = "Cheescake"
        Producto10.Precio = 20
        Producto10.Descripcion = "Cheescake con frutos rojos"
        Producto10.Tiempo = 1

        nombre10.Text = Producto10.Nombre
        Descripcion10.Text = Producto10.Descripcion
        Precio10.Text = "$ " & Producto10.Precio

    End Sub

    Private Sub Label1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label1.Click

    End Sub

    Private Sub Label2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label2.Click

    End Sub

    Private Sub Label3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label3.Click

    End Sub

    Private Sub Label4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label4.Click

    End Sub

    Private Sub CheckBox2_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox2.CheckedChanged
        If CheckBox2.Checked = True Then
            CheckBox1.Checked = False
        End If
    End Sub

    Private Sub GroupBox1_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub Label5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub GroupBox2_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub Label6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub VScrollBar1_Scroll(ByVal sender As System.Object, ByVal e As System.Windows.Forms.ScrollEventArgs)

    End Sub

    Private Sub Label5_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label5.Click

    End Sub

    Private Sub Label6_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label6.Click

    End Sub

    Private Sub Label7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label7.Click

    End Sub

    Private Sub GroupBox1_Enter_1(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub GroupBox1_Enter_2(ByVal sender As System.Object, ByVal e As System.EventArgs)
    End Sub

    Private Sub Panel1_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles Panel1.Paint

    End Sub

    Private Sub Label9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles nombre1.Click

    End Sub

    Private Sub CheckedListBox1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub CheckedListBox2_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub Add1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Add1.Click

        Dim Producto1 As Productos = New Productos()
        Producto1.Nombre = "Hamburguesa con queso"
        Producto1.Precio = 10
        Producto1.Descripcion = "Hamburguesa de carne con queso cheddar"
        Producto1.Tiempo = 5

        productosTotal(0) = Producto1.Nombre

        For i As Integer = 9 To 100
            Dim nombreLabel As String = "Label" & i.ToString()
            Dim etiqueta As Label = Me.Controls.Find(nombreLabel, True).FirstOrDefault()


            If etiqueta IsNot Nothing And etiqueta.Text = "" Then
                etiqueta.Text = Producto1.Nombre & " $ " & Producto1.Precio
                deshacer(i) = Producto1.Precio
                destiempo(i) = Producto1.Tiempo
                T = T + Producto1.Tiempo
                P = P + Producto1.Precio
                Label103.Text = "$ " & P
                Exit For
            End If
        Next
    End Sub


    Private Sub Panel2_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles Panel2.Paint

    End Sub

    Private Sub Label88_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub Label87_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub Label23_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label23.Click

    End Sub

    Private Sub Label97_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label97.Click

    End Sub

    Private Sub Label19_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label19.Click

    End Sub

    Private Sub Add2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Add2.Click

        Dim Producto2 As Productos = New Productos()
        Producto2.Nombre = "Hamburguesa cheddar y panceta"
        Producto2.Precio = 15
        Producto2.Descripcion = "Hamburguesa de carne con queso cheddar y panceta crocante"
        Producto2.Tiempo = 5

        productosTotal(1) = Producto2.Nombre

        For i As Integer = 9 To 100
            Dim nombreLabel As String = "Label" & i.ToString()
            Dim etiqueta As Label = Me.Controls.Find(nombreLabel, True).FirstOrDefault()


            If etiqueta IsNot Nothing And etiqueta.Text = "" Then
                etiqueta.Text = Producto2.Nombre & " $ " & Producto2.Precio
                deshacer(i) = Producto2.Precio
                destiempo(i) = Producto2.Tiempo
                T = T + Producto2.Tiempo
                P = P + Producto2.Precio
                Label103.Text = "$ " & P

                Exit For
            End If
        Next
    End Sub


    Private Sub Label101_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label101.Click

    End Sub

    Private Sub Label103_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label103.Click

    End Sub

    Private Sub Add3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Add3.Click

        Dim Producto3 As Productos = New Productos()
        Producto3.Nombre = "Hamburguesa completa"
        Producto3.Precio = 15
        Producto3.Descripcion = "Hamburguesa de carne con queso, tomate y lechuga"
        Producto3.Tiempo = 5

        productosTotal(2) = Producto3.Nombre

        For i As Integer = 9 To 100
            Dim nombreLabel As String = "Label" & i.ToString()
            Dim etiqueta As Label = Me.Controls.Find(nombreLabel, True).FirstOrDefault()


            If etiqueta IsNot Nothing And etiqueta.Text = "" Then
                etiqueta.Text = Producto3.Nombre & " $ " & Producto3.Precio
                deshacer(i) = Producto3.Precio
                destiempo(i) = Producto3.Tiempo
                T = T + Producto3.Tiempo
                P = P + Producto3.Precio
                Label103.Text = "$ " & P

                Exit For
            End If
        Next
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub Button2_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        For i As Integer = 100 To 9 Step -1
            Dim nombreLabel As String = "Label" & i.ToString()
            Dim etiqueta As Label = Me.Controls.Find(nombreLabel, True).FirstOrDefault()
            If etiqueta IsNot Nothing And etiqueta.Text <> "" Then
                etiqueta.Text = ""
                P = P - deshacer(i)
                T = T - destiempo(i)
                Label103.Text = "$ " & P
                Exit For
            End If
            Label103.Text = "$ " & P
        Next
    End Sub

    Private Sub CheckBox1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox1.CheckedChanged
        If CheckBox1.Checked = True Then
            CheckBox2.Checked = False

        End If
    End Sub


    Private Sub Panel3_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs)

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If CheckBox1.Checked = False And CheckBox2.Checked = False Then
            MsgBox("Debe seleccionar un metodo de entrega")
        End If
        If Label9.Text = "" Then
            MsgBox("Debe generar un pedido para avanzar")
        ElseIf CheckBox1.Checked = True And Label9.Text <> "" Then
            T = T + Delivery
            Dim f9 As New datosEntrega
            f9.Show()
            Me.Hide()
        ElseIf CheckBox2.Checked = True And Label9.Text <> "" Then
            Domicilio = "CALLE 123 - BUENOS AIRES"
            Dim f4 As New mediosPagoRetira
            f4.Show()
            Me.Hide()
        End If
    End Sub

    Private Sub PictureBox2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox2.Click

    End Sub

    Private Sub Add4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Add4.Click
        Dim Producto4 As Productos = New Productos()
        Producto4.Nombre = "Papas fritas"
        Producto4.Precio = 5
        Producto4.Descripcion = "Porción de papas fritas"
        Producto4.Tiempo = 2

        productosTotal(3) = Producto4.Nombre

        For i As Integer = 9 To 100
            Dim nombreLabel As String = "Label" & i.ToString()
            Dim etiqueta As Label = Me.Controls.Find(nombreLabel, True).FirstOrDefault()


            If etiqueta IsNot Nothing And etiqueta.Text = "" Then
                etiqueta.Text = Producto4.Nombre & " $ " & Producto4.Precio
                deshacer(i) = Producto4.Precio
                destiempo(i) = Producto4.Tiempo
                T = T + Producto4.Tiempo
                P = P + Producto4.Precio
                Label103.Text = "$ " & P

                Exit For
            End If
        Next

    End Sub

    Private Sub Add5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Add5.Click

        Dim Producto5 As Productos = New Productos()
        Producto5.Nombre = "Agua mineral"
        Producto5.Precio = 5
        Producto5.Descripcion = "Agua mineral con o sin gas"
        Producto5.Tiempo = 0

        productosTotal(4) = Producto5.Nombre

        For i As Integer = 9 To 100
            Dim nombreLabel As String = "Label" & i.ToString()
            Dim etiqueta As Label = Me.Controls.Find(nombreLabel, True).FirstOrDefault()


            If etiqueta IsNot Nothing And etiqueta.Text = "" Then
                etiqueta.Text = Producto5.Nombre & " $ " & Producto5.Precio
                deshacer(i) = Producto5.Precio
                destiempo(i) = Producto5.Tiempo
                T = T + Producto5.Tiempo
                P = P + Producto5.Precio
                Label103.Text = "$ " & P

                Exit For
            End If
        Next

    End Sub

    Private Sub Add6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Add6.Click
        Dim Producto6 As Productos = New Productos()
        Producto6.Nombre = "Gaseosa"
        Producto6.Precio = 5
        Producto6.Descripcion = "Coca-cola, Sprite o Fanta"
        Producto6.Tiempo = 0

        productosTotal(5) = Producto6.Nombre

        For i As Integer = 9 To 100
            Dim nombreLabel As String = "Label" & i.ToString()
            Dim etiqueta As Label = Me.Controls.Find(nombreLabel, True).FirstOrDefault()


            If etiqueta IsNot Nothing And etiqueta.Text = "" Then
                etiqueta.Text = Producto6.Nombre & " $ " & Producto6.Precio
                deshacer(i) = Producto6.Precio
                destiempo(i) = Producto6.Tiempo
                T = T + Producto6.Tiempo
                P = P + Producto6.Precio
                Label103.Text = "$ " & P

                Exit For
            End If
        Next
    End Sub

    Private Sub Add7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Add7.Click
        Dim Producto7 As Productos = New Productos()
        Producto7.Nombre = "Cerveza"
        Producto7.Precio = 10
        Producto7.Descripcion = "Rubia, roja o negra"
        Producto7.Tiempo = 0

        productosTotal(6) = Producto7.Nombre

        For i As Integer = 9 To 100
            Dim nombreLabel As String = "Label" & i.ToString()
            Dim etiqueta As Label = Me.Controls.Find(nombreLabel, True).FirstOrDefault()


            If etiqueta IsNot Nothing And etiqueta.Text = "" Then
                etiqueta.Text = Producto7.Nombre & " $ " & Producto7.Precio
                deshacer(i) = Producto7.Precio
                destiempo(i) = Producto7.Tiempo
                T = T + Producto7.Tiempo
                P = P + Producto7.Precio
                Label103.Text = "$ " & P

                Exit For
            End If
        Next
    End Sub

    Private Sub Add8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Add8.Click
        Dim Producto8 As Productos = New Productos()
        Producto8.Nombre = "Flan casero"
        Producto8.Precio = 20
        Producto8.Descripcion = "Flan casero con crema y dulce de leche"
        Producto8.Tiempo = 1

        productosTotal(7) = Producto8.Nombre

        For i As Integer = 9 To 100
            Dim nombreLabel As String = "Label" & i.ToString()
            Dim etiqueta As Label = Me.Controls.Find(nombreLabel, True).FirstOrDefault()


            If etiqueta IsNot Nothing And etiqueta.Text = "" Then
                etiqueta.Text = Producto8.Nombre & " $ " & Producto8.Precio
                deshacer(i) = Producto8.Precio
                destiempo(i) = Producto8.Tiempo
                T = T + Producto8.Tiempo
                P = P + Producto8.Precio
                Label103.Text = "$ " & P

                Exit For
            End If
        Next
    End Sub

    Private Sub Add9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Add9.Click
        Dim Producto9 As Productos = New Productos()
        Producto9.Nombre = "Torta oreo"
        Producto9.Precio = 20
        Producto9.Descripcion = "Porción individual de torta oreo"
        Producto9.Tiempo = 1

        productosTotal(8) = Producto9.Nombre

        For i As Integer = 9 To 100
            Dim nombreLabel As String = "Label" & i.ToString()
            Dim etiqueta As Label = Me.Controls.Find(nombreLabel, True).FirstOrDefault()


            If etiqueta IsNot Nothing And etiqueta.Text = "" Then
                etiqueta.Text = Producto9.Nombre & " $ " & Producto9.Precio
                deshacer(i) = Producto9.Precio
                destiempo(i) = Producto9.Tiempo
                T = T + Producto9.Tiempo
                P = P + Producto9.Precio
                Label103.Text = "$ " & P

                Exit For
            End If
        Next
    End Sub

    Private Sub Add10_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Add10.Click
        Dim Producto10 As Productos = New Productos()
        Producto10.Nombre = "Cheescake"
        Producto10.Precio = 20
        Producto10.Descripcion = "Cheescake con frutos rojos"
        Producto10.Tiempo = 1

        productosTotal(9) = Producto10.Nombre

        For i As Integer = 9 To 100
            Dim nombreLabel As String = "Label" & i.ToString()
            Dim etiqueta As Label = Me.Controls.Find(nombreLabel, True).FirstOrDefault()


            If etiqueta IsNot Nothing And etiqueta.Text = "" Then
                etiqueta.Text = Producto10.Nombre & " $ " & Producto10.Precio
                deshacer(i) = Producto10.Precio
                destiempo(i) = Producto10.Tiempo
                T = T + Producto10.Tiempo
                P = P + Producto10.Precio
                Label103.Text = "$ " & P

                Exit For
            End If
        Next
    End Sub

    Private Sub Panel3_Paint_1(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles Panel3.Paint

    End Sub
End Class