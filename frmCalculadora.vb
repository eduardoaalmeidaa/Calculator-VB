Public Class frmCalculadora
    Dim intCalculadora As Integer = 0
    Dim booOperador As Boolean = False
    Dim strGuardaOperador As String = ""

    Private Sub btomais_Click(sender As Object, e As EventArgs) Handles btoMais.Click
        If strGuardaOperador = "" Then
            intCalculadora = Me.lblDsp.Text
        ElseIf strGuardaOperador = "+" Then
            intCalculadora += Me.lblDsp.Text
        ElseIf strGuardaOperador = "-" Then
            intCalculadora -= Me.lblDsp.Text
        ElseIf strGuardaOperador = "*" Then
            intCalculadora *= Me.lblDsp.Text
        ElseIf strGuardaOperador = "/" Then
            intCalculadora /= Me.lblDsp.Text
        End If
        Me.lblDsp.Text = intCalculadora
        strGuardaOperador = "+"
        lblOperador.Text = strGuardaOperador
        booOperador = True
    End Sub

    Private Sub bto0_Click(sender As Object, e As EventArgs) Handles bto0.Click
        If Me.lblDsp.Text = "0" Or booOperador = True Then
            Me.lblDsp.Text = "0"
            booOperador = False
        Else
            Me.lblDsp.Text = Me.lblDsp.Text & "0"
        End If
    End Sub

    Private Sub bto1_Click(sender As Object, e As EventArgs) Handles bto1.Click

        If Me.lblDsp.Text = "0" Or booOperador = True Then
            Me.lblDsp.Text = "1"
            booOperador = False
        Else
            Me.lblDsp.Text &= "1"
        End If
    End Sub

    Private Sub bto2_Click(sender As Object, e As EventArgs) Handles bto2.Click

        If Me.lblDsp.Text = "0" Or booOperador = True Then
            Me.lblDsp.Text = "2"
            booOperador = False
        Else
            Me.lblDsp.Text = Me.lblDsp.Text & "2"
        End If
    End Sub

    Private Sub bto3_Click(sender As Object, e As EventArgs) Handles bto3.Click
        If Me.lblDsp.Text = "0" Or booOperador = True Then
            Me.lblDsp.Text = "3"
            booOperador = False
        Else
            Me.lblDsp.Text = Me.lblDsp.Text & "3"
        End If
    End Sub

    Private Sub bto4_Click(sender As Object, e As EventArgs) Handles bto4.Click
        If Me.lblDsp.Text = 0 Or booOperador = True Then
            Me.lblDsp.Text = "4"
            booOperador = False
        Else
            Me.lblDsp.Text = Me.lblDsp.Text & "4"
        End If
    End Sub

    Private Sub bto5_Click(sender As Object, e As EventArgs) Handles bto5.Click
        If Me.lblDsp.Text = "0" Or booOperador = True Then
            Me.lblDsp.Text = "5"
            booOperador = False
        Else
            Me.lblDsp.Text = Me.lblDsp.Text & "5"
        End If
    End Sub

    Private Sub bto6_Click(sender As Object, e As EventArgs) Handles bto6.Click
        If Me.lblDsp.Text = "0" Or booOperador = True Then
            Me.lblDsp.Text = "6"
            booOperador = False
        Else
            Me.lblDsp.Text = Me.lblDsp.Text & "6"
        End If
    End Sub

    Private Sub bto7_Click(sender As Object, e As EventArgs) Handles bto7.Click
        If Me.lblDsp.Text = "0" Or booOperador = True Then
            Me.lblDsp.Text = "7"
            booOperador = False
        Else
            Me.lblDsp.Text = Me.lblDsp.Text & "7"
        End If
    End Sub

    Private Sub bto8_Click(sender As Object, e As EventArgs) Handles bto8.Click
        If Me.lblDsp.Text = "0" Or booOperador = True Then
            Me.lblDsp.Text = "8"
            booOperador = False
        Else
            Me.lblDsp.Text = Me.lblDsp.Text & "8"
        End If
    End Sub

    Private Sub bto9_Click(sender As Object, e As EventArgs) Handles bto9.Click
        If Me.lblDsp.Text = "0" Or booOperador = True Then
            Me.lblDsp.Text = "9"
            booOperador = False
        Else
            Me.lblDsp.Text = Me.lblDsp.Text & "9"
        End If
    End Sub

    Private Sub btoponto_Click(sender As Object, e As EventArgs) Handles btoponto.Click
        Me.lblDsp.Text = "."
    End Sub
    Private Sub btoigual_Click(sender As Object, e As EventArgs) Handles btoIgual.Click
        If strGuardaOperador = "" Then
            intCalculadora = Me.lblDsp.Text
        ElseIf strGuardaOperador = "+" Then
            intCalculadora += Me.lblDsp.Text
        ElseIf strGuardaOperador = "-" Then
            intCalculadora -= Me.lblDsp.Text
        ElseIf strGuardaOperador = "*" Then
            intCalculadora *= Me.lblDsp.Text
        ElseIf strGuardaOperador = "/" Then
            intCalculadora /= Me.lblDsp.Text
        End If
        Me.lblDsp.Text = intCalculadora
        strGuardaOperador = ""
        lblOperador.Text = ""
        booOperador = True
    End Sub
    Private Sub btomultiplicação_Click(sender As Object, e As EventArgs) Handles btoMultiplicação.Click
        If strGuardaOperador = "" Then
            intCalculadora = Me.lblDsp.Text
        ElseIf strGuardaOperador = "+" Then
            intCalculadora += Me.lblDsp.Text
        ElseIf strGuardaOperador = "-" Then
            intCalculadora -= Me.lblDsp.Text
        ElseIf strGuardaOperador = "*" Then
            intCalculadora *= Me.lblDsp.Text
        ElseIf strGuardaOperador = "/" Then
            intCalculadora /= Me.lblDsp.Text
        End If
        Me.lblDsp.Text = intCalculadora
        strGuardaOperador = "*"
        lblOperador.Text = "*"
        booOperador = True
    End Sub
    Private Sub btodivisão_Click(sender As Object, e As EventArgs) Handles btoDivisão.Click
        If strGuardaOperador = "" Then
            intCalculadora = Me.lblDsp.Text
        ElseIf strGuardaOperador = "+" Then
            intCalculadora += Me.lblDsp.Text
        ElseIf strGuardaOperador = "-" Then
            intCalculadora -= Me.lblDsp.Text
        ElseIf strGuardaOperador = "*" Then
            intCalculadora *= Me.lblDsp.Text
        ElseIf strGuardaOperador = "/" Then
            intCalculadora /= Me.lblDsp.Text
        End If
        Me.lblDsp.Text = intCalculadora
        strGuardaOperador = "/"
        lblOperador.Text = "/"
        booOperador = True
    End Sub
    Private Sub btoDelete_Click(sender As Object, e As EventArgs) Handles btoDelete.Click
        Me.lblDsp.Text = "0"
        intCalculadora = 0
        lblOperador.Text = ""
        strGuardaOperador = ""
        booOperador = False
    End Sub

    Private Sub btoOff_Click(sender As Object, e As EventArgs)
        End
    End Sub

    Private Sub frmCalculadora_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.Delete Or e.KeyCode = Keys.Escape Then
            Me.lblDsp.Text = "0"
            lblOperador.Text = ""
            strGuardaOperador = ""
            intCalculadora = 0
        ElseIf e.KeyCode = Keys.Oemplus Then
            If strGuardaOperador = "" Then
                intCalculadora = Me.lblDsp.Text
            ElseIf strGuardaOperador = "+" Then
                intCalculadora += Me.lblDsp.Text
            ElseIf strGuardaOperador = "-" Then
                intCalculadora -= Me.lblDsp.Text
            ElseIf strGuardaOperador = "*" Then
                intCalculadora *= Me.lblDsp.Text
            ElseIf strGuardaOperador = "/" Then
                intCalculadora /= Me.lblDsp.Text
            End If
            Me.lblDsp.Text = intCalculadora
            strGuardaOperador = ""
            lblOperador.Text = ""
            booOperador = True
        ElseIf e.KeyCode = Keys.Add Then
            If strGuardaOperador = "" Then
                intCalculadora = Me.lblDsp.Text
            ElseIf strGuardaOperador = "+" Then
                intCalculadora += Me.lblDsp.Text
            ElseIf strGuardaOperador = "-" Then
                intCalculadora -= Me.lblDsp.Text
            ElseIf strGuardaOperador = "*" Then
                intCalculadora *= Me.lblDsp.Text
            ElseIf strGuardaOperador = "/" Then
                intCalculadora /= Me.lblDsp.Text
            End If
            Me.lblDsp.Text = intCalculadora
            strGuardaOperador = "+"
            lblOperador.Text = "+"
            booOperador = True
        ElseIf e.KeyCode = Keys.Divide Then
            If strGuardaOperador = "" Then
                intCalculadora = Me.lblDsp.Text
            ElseIf strGuardaOperador = "+" Then
                intCalculadora += Me.lblDsp.Text
            ElseIf strGuardaOperador = "-" Then
                intCalculadora -= Me.lblDsp.Text
            ElseIf strGuardaOperador = "*" Then
                intCalculadora *= Me.lblDsp.Text
            ElseIf strGuardaOperador = "/" Then
                intCalculadora /= Me.lblDsp.Text
            End If
            Me.lblDsp.Text = intCalculadora
            strGuardaOperador = "/"
            lblOperador.Text = "/"
            booOperador = True
        ElseIf e.KeyCode = Keys.Multiply Then
            If strGuardaOperador = "" Then
                intCalculadora = Me.lblDsp.Text
            ElseIf strGuardaOperador = "+" Then
                intCalculadora += Me.lblDsp.Text
            ElseIf strGuardaOperador = "-" Then
                intCalculadora -= Me.lblDsp.Text
            ElseIf strGuardaOperador = "*" Then
                intCalculadora *= Me.lblDsp.Text
            ElseIf strGuardaOperador = "/" Then
                intCalculadora /= Me.lblDsp.Text
            End If
            Me.lblDsp.Text = intCalculadora
            strGuardaOperador = "*"
            lblOperador.Text = "*"
            booOperador = True

        ElseIf e.KeyCode = Keys.Subtract Then
            If strGuardaOperador = "" Then
                intCalculadora = Me.lblDsp.Text
            ElseIf strGuardaOperador = "+" Then
                intCalculadora += Me.lblDsp.Text
            ElseIf strGuardaOperador = "-" Then
                intCalculadora -= Me.lblDsp.Text
            ElseIf strGuardaOperador = "*" Then
                intCalculadora *= Me.lblDsp.Text
            ElseIf strGuardaOperador = "/" Then
                intCalculadora /= Me.lblDsp.Text
            End If
            Me.lblDsp.Text = intCalculadora
            strGuardaOperador = "-"
            lblOperador.Text = "-"
            booOperador = True
        ElseIf e.KeyCode = Keys.NumPad0 Then
            If Me.lblDsp.Text = "0" Or booOperador = True Then
                Me.lblDsp.Text = "0"
                booOperador = False
            Else
                Me.lblDsp.Text = Me.lblDsp.Text & "0"
            End If
        ElseIf e.KeyCode = Keys.NumPad1 Then
            If Me.lblDsp.Text = "0" Or booOperador = True Then
                Me.lblDsp.Text = "1"
                booOperador = False
            Else
                Me.lblDsp.Text = Me.lblDsp.Text & "1"
            End If
        ElseIf e.KeyCode = Keys.NumPad2 Then
            If Me.lblDsp.Text = "0" Or booOperador = True Then
                Me.lblDsp.Text = "2"
                booOperador = False
            Else
                Me.lblDsp.Text = Me.lblDsp.Text & "2"
            End If
        ElseIf e.KeyCode = Keys.NumPad3 Then
            If Me.lblDsp.Text = "0" Or booOperador = True Then
                Me.lblDsp.Text = "3"
                booOperador = False
            Else
                Me.lblDsp.Text = Me.lblDsp.Text & "3"
            End If
        ElseIf e.KeyCode = Keys.NumPad4 Then
            If Me.lblDsp.Text = "0" Or booOperador = True Then
                Me.lblDsp.Text = "4"
                booOperador = False
            Else
                Me.lblDsp.Text = Me.lblDsp.Text & "4"
            End If
        ElseIf e.KeyCode = Keys.NumPad5 Then
            If Me.lblDsp.Text = "0" Or booOperador = True Then
                Me.lblDsp.Text = "5"
                booOperador = False
            Else
                Me.lblDsp.Text = Me.lblDsp.Text & "5"
            End If
        ElseIf e.KeyCode = Keys.NumPad6 Then
            If Me.lblDsp.Text = "0" Or booOperador = True Then
                Me.lblDsp.Text = "6"
                booOperador = False
            Else
                Me.lblDsp.Text = Me.lblDsp.Text & "6"
            End If
        ElseIf e.KeyCode = Keys.NumPad7 Then
            If Me.lblDsp.Text = "0" Or booOperador = True Then
                Me.lblDsp.Text = "7"
                booOperador = False
            Else
                Me.lblDsp.Text = Me.lblDsp.Text & "7"
            End If
        ElseIf e.KeyCode = Keys.NumPad8 Then
            If Me.lblDsp.Text = "0" Or booOperador = True Then
                Me.lblDsp.Text = "8"
                booOperador = False
            Else
                Me.lblDsp.Text = Me.lblDsp.Text & "8"
            End If
        ElseIf e.KeyCode = Keys.NumPad9 Then
            If Me.lblDsp.Text = "0" Or booOperador = True Then
                Me.lblDsp.Text = "9"
                booOperador = False
            Else
                Me.lblDsp.Text = Me.lblDsp.Text & "9"
            End If
        End If
    End Sub
    Private Sub btoMenos_Click(sender As Object, e As EventArgs) Handles btoMenos.Click
        If strGuardaOperador = "" Then
            intCalculadora = Me.lblDsp.Text
        ElseIf strGuardaOperador = "+" Then
            intCalculadora += Me.lblDsp.Text
        ElseIf strGuardaOperador = "-" Then
            intCalculadora -= Me.lblDsp.Text
        ElseIf strGuardaOperador = "*" Then
            intCalculadora *= Me.lblDsp.Text
        ElseIf strGuardaOperador = "/" Then
            intCalculadora /= Me.lblDsp.Text
        End If
        Me.lblDsp.Text = intCalculadora
        strGuardaOperador = "-"
        lblOperador.Text = "-"
        booOperador = True
    End Sub
    Private Sub frmCalculadora_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        MsgBox("Abriu a Calculadora", MsgBoxStyle.Information, "Tela de Login")
    End Sub
    Private Sub frmCalculadora_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Me.KeyPress

    End Sub
End Class