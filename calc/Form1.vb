
Public Class Form1
    Private Text As String

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Text = TextBoxIs.Text
        Text = LCase(Text)
        For i As Integer = 0 To 9
            Text = Text.Replace(CStr(i) + "(", CStr(i) + "*(")
            Text = Text.Replace(")" + CStr(i), CStr(i) + ")*")
            Text = Text.Replace(CStr(i) + "pi", CStr(i) + "*pi")
            Text = Text.Replace("pi" + CStr(i), CStr(i) + "pi*")
            Text = Text.Replace(CStr(i) + "e", CStr(i) + "*e")
            Text = Text.Replace("e" + CStr(i), CStr(i) + "e*")
        Next
        Text = Text.Replace("pi", CStr(Math.PI).Replace(",", "."))
        Text = Text.Replace("e", CStr(Math.E).Replace(",", "."))
        Text = Text.Replace(")(", ")*(")
        Text = Text.Replace(" ", "")
        Text = Calculate(Text)
        Text = Text.Replace(",", ".")
        TextBoxIs.Text = Text
    End Sub
    Function Calculate(str As String)
        Dim c1, c2, s1, s2, s3, d As String
        Dim i, j, start, count As Integer
        Dim c2d, c1d, itog As Double

        While str.Contains("(")
            start = 0
            count = 2
            While i < Len(str)
                If str(i) = "(" Then
                    start = i + 0
                    j = i + 1
                    If j = Len(str) Then
                        Return ("Несоответствие скобок")
                    End If
                    c2d = 0
                    While str(j) <> ")" Or c2d <> 0
                        If str(j) = "(" Then
                            c2d += 1
                        End If
                        If str(j) = ")" Then
                            c2d -= 1
                        End If
                        j += 1
                        count += 1
                    End While
                    Exit While
                End If
                i += 1
            End While
            s1 = str.Substring(0, start)
            c1d = Convert.ToDouble(Calculate(str.Substring(start + 1, count - 2)))
            If Len(s1) > 0 Then
                If UCase(s1(Len(s1) - 1)) <> LCase(s1(Len(s1) - 1)) Then
                    i = Len(s1) - 1
                    While UCase(s1(i)) <> LCase(s1(i))
                        d = s1(i) + d
                        i -= 1
                        If i < 0 Then
                            Exit While
                        End If
                    End While
                    s1 = s1.Substring(0, Len(s1) - Len(d))
                    Select Case d
                        Case "sin"
                            c1d = Math.Round(Math.Sin(c1d * Math.PI / 180), 6)
                        Case "cos"
                            c1d = Math.Round(Math.Cos(c1d * Math.PI / 180), 6)
                        Case "tg"
                            c1d = Math.Round(Math.Tan(c1d * Math.PI / 180), 6)
                        Case "ctg"
                            c1d = Math.Round(1 / Math.Tan(c1d * Math.PI / 180), 6)
                        Case "arcsin"
                            c1d = Math.Round(Math.Asin(c1d) * 180 / Math.PI, 6)
                        Case "arccos"
                            c1d = Math.Round(Math.Acos(c1d) * 180 / Math.PI, 6)
                        Case "arctg"
                            c1d = Math.Round(Math.Atan(c1d) * 180 / Math.PI, 6)
                        Case "arcctg"
                            c1d = Math.Round(Math.Atan(1 / (c1d)) * 180 / Math.PI, 6)
                        Case "ln"
                            c1d = Math.Log(c1d)
                        Case "log"
                            i = 0
                            While str.Substring(start + 1, count - 2)(i) <> ","
                                c1 = c1 + str.Substring(start + 1, count - 2)(i)
                                i += 1
                            End While
                            i += 1
                            While i < Len(str.Substring(start + 1, count - 2))
                                c2 = c2 + str.Substring(start + 1, count - 2)(i)
                                i += 1
                            End While
                            c2d = Convert.ToDouble(c2.Replace(".", ","))
                            c1d = Convert.ToDouble(c1.Replace(".", ","))
                            c1d = Math.Log(c2d) / Math.Log(c1d)
                        Case "sqrt"
                            c1d = c1d ^ 0.5
                        Case Else
                            Return ("Неизвестная функция " + d)
                    End Select
                End If
            End If
            s2 = CStr(c1d).Replace(",", ".")
            s3 = str.Substring(start + count, Len(str) - (start + count))
            str = s1 + s2 + s3
            i = 0
        End While

        While str.Contains("^")
            i = Len(str) - 1
            start = Len(str)
            count = 0
            While i >= 0
                If IsNumeric(str(i)) Or str(i) = "." Then
                    c2 = str(i) + c2
                    count += 1
                ElseIf str(i) = "^" Then
                    j = i - 1
                    count += 1
                    While IsNumeric(str(j)) Or str(j) = "."
                        c1 = str(j) + c1
                        count += 1
                        j -= 1
                        If j < 0 Then
                            Exit While
                        End If
                    End While
                    Exit While
                Else
                    c2 = ""
                    count = 0
                    start = i + 0
                End If
                i -= 1
            End While
            c2d = Convert.ToDouble(c2.Replace(".", ","))
            c1d = Convert.ToDouble(c1.Replace(".", ","))
            itog = c1d ^ c2d
            s1 = str.Substring(0, start - count)
            s2 = CStr(itog).Replace(",", ".")
            s3 = str.Substring(start, Len(str) - start)
            str = s1 + s2 + s3
            c2 = ""
            c1 = ""
        End While

        While str.Contains("*") Or str.Contains("/")
            i = 0
            start = 0
            count = 0
            While i < Len(str)
                If IsNumeric(str(i)) Or str(i) = "." Then
                    c1 = c1 + str(i)
                    count += 1
                ElseIf (str(i) = "*" Or str(i) = "/") And i <> 0 Then
                    d = str(i)
                    j = i + 1
                    count += 1
                    If start = 1 And str(0) = "-" Then
                        c1 = "-" + c1
                        count += 1
                        start -= 1
                    End If
                    While IsNumeric(str(j)) Or str(j) = "."
                        c2 = c2 + str(j)
                        count += 1
                        j += 1
                        If j = Len(str) Then
                            Exit While
                        End If
                    End While
                    Exit While
                Else
                    c1 = ""
                    count = 0
                    start = i + 1
                End If
                i += 1
            End While
            c1d = Convert.ToDouble(c1.Replace(".", ","))
            c2d = Convert.ToDouble(c2.Replace(".", ","))
            Select Case d
                Case "*"
                    itog = c1d * c2d
                Case "/"
                    itog = c1d / c2d
            End Select
            s1 = str.Substring(0, start)
            s2 = CStr(itog).Replace(",", ".")
            s3 = str.Substring(start + count, Len(str) - (start + count))
            str = s1 + s2 + s3
            c1 = ""
            c2 = ""
        End While

        While str.Contains("+") Or str.Contains("-")
            If IsNumeric(str) Then
                Exit While
            End If
            i = 0
            start = 0
            count = 0
            While i < Len(str)
                If IsNumeric(str(i)) Or str(i) = "." Then
                    c1 = c1 + str(i)
                    count += 1
                ElseIf (str(i) = "+" Or str(i) = "-") And i <> 0 Then
                    d = str(i)
                    j = i + 1
                    count += 1
                    If start = 1 And str(0) = "-" Then
                        c1 = "-" + c1
                        count += 1
                        start -= 1
                    End If
                    While IsNumeric(str(j)) Or str(j) = "."
                        c2 = c2 + str(j)
                        count += 1
                        j += 1
                        If j = Len(str) Then
                            Exit While
                        End If
                    End While
                    Exit While
                Else
                    c1 = ""
                    count = 0
                    start = i + 1
                End If
                i += 1
            End While
            c1d = Convert.ToDouble(c1.Replace(".", ","))
            c2d = Convert.ToDouble(c2.Replace(".", ","))
            Select Case d
                Case "+"
                    itog = c1d + c2d
                Case "-"
                    itog = c1d - c2d
            End Select
            s1 = str.Substring(0, start)
            s2 = CStr(itog).Replace(",", ".")
            s3 = str.Substring(start + count, Len(str) - (start + count))
            str = s1 + s2 + s3
            c1 = ""
            c2 = ""
        End While
        If IsNumeric(str.Replace(".", ",")) Then
            Return (str)
        Else
            Return ("Не число")
        End If
    End Function
End Class
