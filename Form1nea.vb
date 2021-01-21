Imports System.IO


Public Class Form1nea


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

        N = Val(TR1.Text) + Val(TR2.Text) + Val(TR3.Text)


        If N < 0.03 Then
            MsgBox("δεν βαλατε ποσό")
            Exit Sub
        End If




        Dim objStreamWriter As StreamWriter


        'Pass the file path and the file name to the StreamWriter constructor.
        objStreamWriter = New StreamWriter("C:\FISLINK\TESTFL.1", False, System.Text.Encoding.Default)





        Dim C0 As String = Replace(Format(N - 0.03, "######0.00"), ".", ",")
        Dim n0 As Integer
        n0 = Len(C0)


        C = """plu""" + " 00-0038      ΥΠΗΡΕΣΙΕΣ ΓΥΜΝΑΣΤΗΡΙΟΥ        1,00" + Space(11 - n0) + C0 + "       24 1"

        objStreamWriter.WriteLine(C)










        C = """plu""" + " 00-0038      " + Mid(EPO.Text + Space(24), 1, 24) + "      1,000   " + "   0,01" + "       24 1"

        objStreamWriter.WriteLine(C)


        C = """plu""" + " 00-0038      " + Mid(DIE.Text + Space(24), 1, 24) + "      1,000   " + "   0,01" + "       24 1"

        objStreamWriter.WriteLine(C)

        C = """plu""" + " 00-0038      " + Format(D1.Value, "dd/MM/yy") + " ΕΩΣ " + Format(D2.Value, "dd/MM/yy") + "         1,000   " + "   0,01" + "       24 1"

        objStreamWriter.WriteLine(C)


        'Write a second line of text.
        objStreamWriter.WriteLine("""to1""" + "  1      " + Replace(Format(Val(TR1.Text), "##0.00"), ".", ","))
        objStreamWriter.WriteLine("""to2""" + "  2      " + Replace(Format(Val(TR2.Text), "##0.00"), ".", ","))
        objStreamWriter.WriteLine("""to3""" + "  3      " + Replace(Format(Val(TR3.Text), "##0.00"), ".", ","))



        '"to2"  2      0.01
        '"to3"  3      0.01)

        'Close the file.
        objStreamWriter.Close()



        TR1.Text = ""
        TR2.Text = ""
        TR3.Text = ""
        EPO.Text = ""
        DIE.Text = ""





    End Sub
End Class
