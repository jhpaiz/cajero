Public Class Cajero
    Public contador As Integer
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Label1.Text = TimeOfDay
        TextBox2.Text = Val(TextBox2.Text) + 1
        ' aca se cuentan los diez segundos
        If TextBox2.Text = 10 Then
            Beep()
            MsgBox("Tiempo Superado", vbOKOnly + 48, "Información")
            TextBox2.Text = 0
            TextBox1.Text = ""
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        TextBox2.Text = 0
        ' aca se captura el tamaño del pin
        If Len(TextBox1.Text) < 4 Then
            MsgBox("Pin Incompleto", vbOKOnly + 32, "Alerta")
            contador = contador + 1
            TextBox1.Text = ""
        Else
            ' si el pin es correcto
            If TextBox1.Text = "0123" Then
                MsgBox("BIENVENIDO A LA BANCA EN LINEA", vbOKOnly, "Banco Industrial")
            Else
                ' si el pin tiene el tamaño correcto pero es incorrecto
                MsgBox("Pin Incorrecto", vbOKOnly + 32, "Información")
                contador = contador + 1
                TextBox1.Text = ""
            End If
        End If
        'Label3.Caption = Val(contador)
        If contador = 3 Then
            MsgBox("superados los intentos permitidos", vbOKOnly + 16, "Alerta")
            End
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        End
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        contador = 0
    End Sub
End Class
