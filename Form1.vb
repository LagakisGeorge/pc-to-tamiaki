Imports System.IO


Public Class Form1
    Public WhoFocus As Integer


    Private Sub DateTimePicker2_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles D2.ValueChanged
        KEIMENO()

    End Sub

    Private Sub DateTimePicker1_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles D1.ValueChanged
        KEIMENO()

    End Sub

    Sub KEIMENO()
        '  EPO.Text = "ΓΙΑ ΤΟ ΔΙΑΣΤΗΜΑ ΑΠΟ " + Format(D1.Value, "dd/MM/yyyy") + " ΕΩΣ " + Format(D2.Value, "dd/MM/yyyy")

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        '"plu" 00-0038      ΕΙΔΟΣ 1 (ΦΠΑ 6%)              1,000   1230,10     6,00 1
        '"mod" -0,09        123456789012345678901234
        '"plu" 00-0039      ΕΙΔΟΣ 2 (ΦΠΑ 13%)             1,000      0,11    13,00 2
        '"mod" -0,10
        '"plu" 00-0040      ΕΙΔΟΣ 3 (ΦΠΑ 24%)             2,000      0,10    24,00 3
        '"mod" -0,19
        '"plu" 00-0041      ΕΙΔΟΣ 4 (ΦΠΑ 0%)              3,000      0,10     0,00 5
        '"mod" -0,29

        '"dis" 0,01
        '"to1"  1      0.01
        '"to2"  2      0.01
        '"to3"  3      0.01

        'FileOpen(1, "C:\FISLINK\TESTFL.1", OpenMode.Output, OpenAccess.Write)
        'FilePut(1, "SSSSA")
        'FilePut(1, "SSSSA2")
        'FileClose(1)
        Dim C As String
        Dim N As Single
        Dim n1 As Single
        Dim n2 As Single
        Dim n3 As Single
        n1 = Val(Replace(TR1.Text, ",", "."))
        n2 = Val(Replace(TR2.Text, ",", "."))
        n3 = Val(Replace(TR3.Text, ",", "."))

        N = n1 + n2 + n3
        If N > 100 Then
            MsgBox("ΥΠΕΡΒΑΣΗ 100Ε")
            Exit Sub
        End If
        If N < 0.03 Then
            MsgBox("δεν βαλατε ποσό")
            Exit Sub
        End If




        Dim objStreamWriter As StreamWriter


        'Pass the file path and the file name to the StreamWriter constructor.
        objStreamWriter = New StreamWriter("C:\FISLINK\TESTFL.1", False, System.Text.Encoding.Default)




       
        Dim C0 As String = Replace(Format(N - 0.01, "######0.00"), ".", ",")
        Dim n0 As Integer
        n0 = Len(C0)
        'C= """plu""" + " 00-0038      ΥΠΗΡΕΣΙΕΣ ΓΥΜΝΑΣΤΗΡΙΟΥ        1,00" + Space(11 - n0) + C0 + "       24 1"
        '============================= ===================================  =========================



        



        '                 C = """plu""" + " 00-0038      ΥΠΗΡΕΣΙΕΣ ΓΥΜΝΑΣΤΗΡΙΟΥ        1,00" + Space(11 - n0) + C0 + "       24 1"
        C = """plu""" + " 00-0038      " + Mid(DIE.Text + Space(24), 1, 24) + "      1,00" + Space(11 - n0) + C0 + "    24,00 1"

        objStreamWriter.WriteLine(C)




        C = """plu""" + " 00-0038      " + Mid("" + Trim(EPO.Text) + "  VOUCHER" + Space(24), 1, 24) + "      1,00    " + "   0,01" + "    24,00 1"

        objStreamWriter.WriteLine(C)




        '  C = """plu""" + " 00-0038      ΥΠΗΡΕΣΙΕΣ ΓΥΜΝΑΣΤΗΡΙΟΥ        1,00" + Space(11 - n0) + C0 + "       24 1"

        '  objStreamWriter.WriteLine(C)


        ' C = """plu""" + " 00-0038      " + Format(D1.Value, "dd/MM/yy") + " ΕΩΣ " + Format(D2.Value, "dd/MM/yy") + "         1,000   " + "   0,01" + "       24 1"

        '  objStreamWriter.WriteLine(C)


        'Write a second line of text.  337308889
        objStreamWriter.WriteLine("""to1""" + "  1      " + Replace(Format(n1, "##0.00"), ".", ","))
        objStreamWriter.WriteLine("""to2""" + "  2      " + Replace(Format(n2, "##0.00"), ".", ","))
        objStreamWriter.WriteLine("""to3""" + "  3      " + Replace(Format(n3, "##0.00"), ".", ","))

        If Val(TR1.Text) > 0 Then
            WhoFocus = 1
        Else
            WhoFocus = 2
        End If

        '"to2"  2      0.01
        '"to3"  3      0.01)

        'Close the file.
        objStreamWriter.Close()



        TR1.Text = ""
        TR2.Text = ""
        TR3.Text = ""
        EPO.Text = ""
        DIE.Text = ""


        EPO.Focus()



    End Sub

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        WhoFocus = 2
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        DIE.Text = "ΠΕΡΙΦΕΡΙΑΚΑ ΥΠΟΛΟΓΙΣΤΩΝ"
        If WhoFocus = 2 Then
            TR2.Focus()
        Else
            TR1.Focus()
        End If



    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        DIE.Text = "ΑΞΕΣΣΟΥΑΡ ΚΙΝΗΤΩΝ"
        If WhoFocus = 2 Then
            TR2.Focus()
        Else
            TR1.Focus()
        End If

    End Sub

    Private Sub EPO_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles EPO.GotFocus
        EPO.BackColor = Color.Yellow
    End Sub

    Private Sub EPO_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles EPO.KeyUp
        If e.KeyCode = 13 Then
            Button2.Focus()
        End If
    End Sub

    Private Sub EPO_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles EPO.LostFocus
        EPO.BackColor = Color.White
    End Sub



    Private Sub TR1_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles TR1.GotFocus
        TR1.BackColor = Color.Yellow
    End Sub

    Private Sub TR1_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TR1.KeyUp
        If e.KeyCode = 13 Then
            Button1.Focus()
        End If
    End Sub

    Private Sub TR1_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles TR1.LostFocus
        TR1.BackColor = Color.White
    End Sub

    Private Sub TR2_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles TR2.GotFocus
        TR2.BackColor = Color.Yellow
    End Sub

    Private Sub TR2_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TR2.KeyUp
        If e.KeyCode = 13 Then
            Button1.Focus()
        End If
    End Sub

    

    Private Sub TR2_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles TR2.LostFocus
        TR2.BackColor = Color.White
    End Sub

    
    Private Sub EPO_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EPO.TextChanged

    End Sub

    Private Sub TR2_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TR2.TextChanged

    End Sub

    Private Sub TR1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TR1.TextChanged

    End Sub

    Private Sub Button2_Enter(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button2.Enter
        'DIE.Text = "ΑΝΤΑΛΛΑΚΤΙΚΑ ΥΠΟΛΟΓΙΣΤΩΝ"
        'If WhoFocus = 2 Then
        '    TR2.Focus()
        'Else
        '    TR1.Focus()
        'End If
    End Sub

    Private Sub Button3_Enter(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button3.Enter
        'DIE.Text = "ΑΝΤΑΛΛΑΚΤΙΚΑ ΥΠΟΛΟΓΙΣΤΩΝ"
        'If WhoFocus = 2 Then
        '    TR2.Focus()
        'Else
        '    TR1.Focus()
        'End If
    End Sub

    Private Sub Button1_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button1.GotFocus
        If Val(TR1.Text) + Val(TR2.Text) = 0 Then
            If WhoFocus = 2 Then
                TR2.Focus()
            Else
                TR1.Focus()
            End If
        End If
    End Sub

    Private Sub Button2_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button2.GotFocus
        If Len(EPO.Text) = 0 Then
            EPO.Focus()

        End If
    End Sub
End Class
