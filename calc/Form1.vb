Imports System.IO
Imports System.Text
Imports System.Text.RegularExpressions

Public Class Form1
    Public OpenedFile As String = ""
    Private Sub TextBoxIs_KeyDown(sender As Object, e As KeyEventArgs) Handles TextBoxIs.KeyDown
        If e.KeyCode = Keys.Enter And Not e.Shift Then
            e.SuppressKeyPress = True
            Dim Position As Integer = TextBoxIs.SelectionStart
            Dim GeneralText, FirstText As String
            Text = TextBoxIs.Lines(TextBoxIs.GetLineFromCharIndex(Position))
            FirstText = Text + ""
            GeneralText = ""
            Text = LCase(Text)
            For i As Integer = 0 To 9
                Text = Text.Replace(Convert.ToString(i) + "(", Convert.ToString(i) + "*(")
                Text = Text.Replace(")" + Convert.ToString(i), ")*" + Convert.ToString(i))
                Text = Text.Replace(Convert.ToString(i) + "pi", Convert.ToString(i) + "*pi")
                Text = Text.Replace("pi" + Convert.ToString(i), "pi*" + Convert.ToString(i))
                Text = Text.Replace(Convert.ToString(i) + "e", Convert.ToString(i) + "*e")
                Text = Text.Replace("e" + Convert.ToString(i), "e*" + Convert.ToString(i))
            Next
            Text = Text.Replace("pi(", "pi*(")
            Text = Text.Replace("e(", "e*(")
            Text = Text.Replace(")pi", ")*pi")
            Text = Text.Replace(")e", ")*e")
            Text = Text.Replace("pi", Convert.ToString(Math.PI))
            Text = Text.Replace("e", Convert.ToString(Math.E))
            Text = Text.Replace(")(", ")*(")
            Text = Text.Replace(" ", "")
            Text = Text.Replace(",", ".")
            Text = Calculate(Text)
            If Text = FirstText Then
                Text = ""
            End If
            For Each elem In TextBoxIs.Lines.Take(TextBoxIs.GetLineFromCharIndex(Position) + 1).ToArray()
                GeneralText += elem + vbCrLf
            Next
            GeneralText += Text
            For Each elem In TextBoxIs.Lines.Skip(TextBoxIs.GetLineFromCharIndex(Position) + 1).ToArray()
                GeneralText += vbCrLf + elem
            Next
            TextBoxIs.Text = GeneralText
            Try
                TextBoxIs.SelectionStart = TextBoxIs.GetFirstCharIndexFromLine(TextBoxIs.GetLineFromCharIndex(Position) + 2) - 1
            Catch ex As Exception
                TextBoxIs.SelectionStart = TextBoxIs.TextLength
            End Try
        End If

        If e.KeyCode = Keys.KeyCode.S And e.Control Then
            FunctionSaveFile()
        End If

        If e.KeyCode = Keys.KeyCode.O And e.Control Then
            FunctionOpenFile()
        End If
    End Sub
    Function Calculate(str As String)
        Dim start, count As Integer
        Dim s1, s2, s3, f, c1, c2 As String
        Dim c1d, c2d As Double

        Try
            While str.Contains("(") Or str.Contains(")")
                start = -1
                count = 0
                For i As Integer = 0 To str.Length - 1
                    If str(i) = "(" Then
                        start = i + 0
                        count = 0
                    ElseIf str(i) = ")" Then
                        s1 = str.Substring(0, Math.Max(start, 0))
                        s2 = Calculate(str.Substring(start + 1, count))
                        s3 = str.Substring(start + count + 2)
                        If s1.Length > 0 Then
                            If UCase(s1(s1.Length - 1)) <> LCase(s1(s1.Length - 1)) Then
                                i = 1
                                f = ""
                                While UCase(s1(s1.Length - i)) <> LCase(s1(s1.Length - i))
                                    f = s1(s1.Length - i) + f
                                    i += 1
                                    If s1.Length < i Then
                                        Exit While
                                    End If
                                End While
                                Select Case f
                                    Case "sin"
                                        s2 = Convert.ToString(Math.Round(Math.Sin(Convert.ToDouble(s2 * Math.PI / 180)), 6))
                                    Case "cos"
                                        s2 = Convert.ToString(Math.Round(Math.Cos(Convert.ToDouble(s2 * Math.PI / 180)), 6))
                                    Case "tan"
                                        s2 = Convert.ToString(Math.Round(Math.Tan(Convert.ToDouble(s2 * Math.PI / 180)), 6))
                                    Case "ctn"
                                        s2 = Convert.ToString(Math.Round(Math.Tan(1 / Convert.ToDouble(s2 * Math.PI / 180)), 6))
                                    Case "arcsin"
                                        s2 = Convert.ToString(Math.Round(Math.Asin(Convert.ToDouble(s2)) * 180 / Math.PI, 6))
                                    Case "arccos"
                                        s2 = Convert.ToString(Math.Round(Math.Acos(Convert.ToDouble(s2)) * 180 / Math.PI, 6))
                                    Case "arctan"
                                        s2 = Convert.ToString(Math.Round(Math.Atan(Convert.ToDouble(s2)) * 180 / Math.PI, 6))
                                    Case "arcctg"
                                        s2 = Convert.ToString(Math.Round(1 / Math.Atan(Convert.ToDouble(s2)) * 180 / Math.PI, 6))
                                    Case "sinh"
                                        s2 = Convert.ToString(Math.Round(Math.Sinh(Convert.ToDouble(s2 * Math.PI / 180)), 6))
                                    Case "cosh"
                                        s2 = Convert.ToString(Math.Round(Math.Cosh(Convert.ToDouble(s2 * Math.PI / 180)), 6))
                                    Case "tanh"
                                        s2 = Convert.ToString(Math.Round(Math.Tanh(Convert.ToDouble(s2 * Math.PI / 180)), 6))
                                    Case "arcsinh"
                                        s2 = Convert.ToString(Math.Round(Math.Asinh(Convert.ToDouble(s2)) * 180 / Math.PI, 6))
                                    Case "arccosh"
                                        s2 = Convert.ToString(Math.Round(Math.Acosh(Convert.ToDouble(s2)) * 180 / Math.PI, 6))
                                    Case "arctanh"
                                        s2 = Convert.ToString(Math.Round(Math.Atanh(Convert.ToDouble(s2)) * 180 / Math.PI, 6))
                                    Case "sqrt"
                                        s2 = Convert.ToString(Convert.ToDouble(s2) ^ 0.5)
                                    Case "ln"
                                        s2 = Convert.ToString(Math.Log(Convert.ToDouble(s2)))
                                    Case "lg"
                                        s2 = Convert.ToString(Math.Log(Convert.ToDouble(s2)) / Math.Log(10))
                                    Case "log"
                                        s2 = Convert.ToString(Math.Log(Convert.ToDouble(s2.Substring(s2.IndexOf(";") + 1))) / Math.Log(Convert.ToDouble(s2.Substring(0, s2.IndexOf(";")))))
                                End Select
                                str = s1.Substring(0, s1.Length - f.Length) + s2 + s3
                            Else
                                str = s1 + s2 + s3
                            End If
                        Else
                            str = s1 + s2 + s3
                        End If
                        Exit For
                    Else
                        count += 1
                        If i + 1 = str.Length Then
                            str += ")"
                        End If
                    End If
                Next
            End While

            While str.Contains("^")
                c1 = ""
                c2 = ""
                start = 0
                count = 0
                For i As Integer = str.Length() - 1 To 0 Step -1
                    If ((IsNumeric(str(i)) Or str(i) = ".") Or (str(i) = "-" And Not IsNumeric(str(Math.Max(i - 1, 0))))) And c1 = "" Then
                        c2 = str(i) + c2
                        count += 1
                    ElseIf str(i) = "^" And c1 = "" Then
                        c1 = " "
                        count += 1
                    ElseIf c1 <> "" And ((IsNumeric(str(i)) Or str(i) = ".") Or (str(i) = "-" And i = 0)) Then
                        c1 = str(i) + c1
                        count += 1
                    ElseIf c1 <> "" And ((IsNumeric(str(i)) Or str(i) = ".") Or (str(i) = "-" And Not IsNumeric(str(Math.Max(i - 1, 0))))) Then
                        c1 = str(i) + c1
                        count += 1
                    ElseIf str(i) <> "." And Not IsNumeric(str(i)) And c1 = "" Then
                        c2 = ""
                        count = 0
                    Else
                        start = i + 1
                        Exit For
                    End If
                Next
                c1d = Convert.ToDouble(c1)
                c2d = Convert.ToDouble(c2)
                s1 = str.Substring(0, start)
                s2 = Convert.ToString(Math.Round(c1d ^ c2d, 6))
                s3 = str.Substring(start + count)
                str = s1 + s2 + s3
            End While

            While str.Contains("*") Or str.Contains("/")
                c1 = ""
                c2 = ""
                f = ""
                start = 0
                count = 0
                For i As Integer = 0 To str.Length() - 1
                    If ((IsNumeric(str(i)) Or str(i) = ".") Or (c1 = "" And str(i) = "-")) And c2 = "" Then
                        c1 = c1 + str(i)
                        count += 1
                    ElseIf (str(i) = "*" Or str(i) = "/") And c2 = "" Then
                        c2 = " "
                        count += 1
                        f = str(i)
                    ElseIf c2 <> "" And ((IsNumeric(str(i)) Or str(i) = ".") Or (c2 = " " And str(i) = "-")) Then
                        c2 = c2 + str(i)
                        count += 1
                    ElseIf str(i) <> "." And Not IsNumeric(str(i)) And c2 = "" Then
                        c1 = ""
                        start = i + 1
                        count = 0
                    Else
                        Exit For
                    End If
                Next
                c1d = Convert.ToDouble(c1)
                c2d = Convert.ToDouble(c2)
                s1 = str.Substring(0, start)
                Select Case f
                    Case "*"
                        s2 = Convert.ToString(Math.Round(c1d * c2d, 6))
                    Case "/"
                        s2 = Convert.ToString(Math.Round(c1d / c2d, 6))
                End Select
                s3 = str.Substring(start + count)
                str = s1 + s2 + s3
            End While

            While (str.Contains("+") Or str.Contains("-")) And (str.Substring(1).Contains("-") Or str.Substring(1).Contains("+")) And str.Length - str.Replace(";-", " ").Length < Math.Max(str.Length - str.Replace("-", "").Length, 1)
                c1 = ""
                c2 = ""
                f = ""
                start = 0
                count = 0
                For i As Integer = 0 To str.Length() - 1
                    If (IsNumeric(str(i)) Or str(i) = "." Or (c1 = "" And str(i) = "-")) And c2 = "" Then
                        c1 = c1 + str(i)
                        count += 1
                    ElseIf (str(i) = "+" Or str(i) = "-") And c2 = "" Then
                        c2 = " "
                        count += 1
                        f = str(i)
                    ElseIf c2 <> "" And ((IsNumeric(str(i)) Or str(i) = ".") Or (c2 = " " And str(i) = "-")) Then
                        c2 = c2 + str(i)
                        count += 1
                    ElseIf str(i) <> "." And Not IsNumeric(str(i)) And c2 = "" Then
                        c1 = ""
                        start = i + 1
                        count = 0
                    Else
                        Exit For
                    End If
                Next
                c1d = Convert.ToDouble(c1)
                c2d = Convert.ToDouble(c2)
                s1 = str.Substring(0, start)
                Select Case f
                    Case "+"
                        s2 = Convert.ToString(Math.Round(c1d + c2d, 6))
                    Case "-"
                        s2 = Convert.ToString(Math.Round(c1d - c2d, 6))
                End Select
                s3 = str.Substring(start + count)
                str = s1 + s2 + s3
            End While
            For Each num In Regex.Split(str, ";")
                If Not IsNumeric(num) Then
                    Return ""
                End If
            Next
            Return str
        Catch ex As Exception
            Return ""
        End Try
    End Function

    Private Sub CloseButton_Click(sender As Object, e As EventArgs) Handles CloseButton.Click
        Application.Exit()
    End Sub

    Private IsMovingWindow As Boolean = False
    Private DownMouseX, DownMouseY As Integer

    Private Sub MoveWindow_MouseDown(sender As Object, e As MouseEventArgs) Handles MoveWindow.MouseDown
        If e.Button = System.Windows.Forms.MouseButtons.Left Then
            IsMovingWindow = True
            DownMouseX = e.X
            DownMouseY = e.Y
        End If
    End Sub

    Private Sub MoveWindow_MouseMove(sender As Object, e As MouseEventArgs) Handles MoveWindow.MouseMove
        If IsMovingWindow Then
            Dim CurrentWindowPosition = New System.Drawing.Point
            CurrentWindowPosition.X = Me.Location.X + (e.X - DownMouseX)
            CurrentWindowPosition.Y = Me.Location.Y + (e.Y - DownMouseY)
            Me.Location = CurrentWindowPosition
        End If
    End Sub

    Private Sub MoveWindow_MouseUp(sender As Object, e As MouseEventArgs) Handles MoveWindow.MouseUp
        If e.Button = System.Windows.Forms.MouseButtons.Left Then
            IsMovingWindow = False
        End If
    End Sub

    Private Sub SaveAsButton_Click(sender As Object, e As EventArgs) Handles SaveAsButton.Click
        Dim SaveAsFile As New SaveFileDialog
        SaveAsFile.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*"
        If SaveAsFile.ShowDialog <> System.Windows.Forms.DialogResult.Cancel Then
            Save(SaveAsFile.FileName)
            OpenedFile = SaveAsFile.FileName
        End If
    End Sub

    Private Sub OpenButton_Click(sender As Object, e As EventArgs) Handles OpenButton.Click
        FunctionOpenFile()
    End Sub

    Function FunctionOpenFile()
        Dim OpenFile As New OpenFileDialog
        OpenFile.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*"
        If OpenFile.ShowDialog <> System.Windows.Forms.DialogResult.Cancel Then
            TextBoxIs.Text = IO.File.ReadAllText(OpenFile.FileName)
            OpenedFile = OpenFile.FileName
            MoveWindow.Text = OpenedFile
        End If
    End Function

    Private Sub SaveButton_Click(sender As Object, e As EventArgs) Handles SaveButton.Click
        FunctionSaveFile()
    End Sub

    Function FunctionSaveFile()
        If OpenedFile = "" Then
            Dim SaveFile As New SaveFileDialog
            SaveFile.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*"
            If SaveFile.ShowDialog <> System.Windows.Forms.DialogResult.Cancel Then
                Save(SaveFile.FileName)
                OpenedFile = SaveFile.FileName
            End If
        Else
            Save(OpenedFile)
        End If
    End Function

    Private Sub HideButton_Click(sender As Object, e As EventArgs) Handles HideButton.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Function Save(path As String)
        Dim f As FileStream = File.Create(path)
        Dim filebytes As Byte() = New UTF8Encoding(True).GetBytes(TextBoxIs.Text)
        f.Write(filebytes, 0, filebytes.Length)
        f.Close()
        MoveWindow.Text = path
    End Function

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles Me.Load
        Dim args() As String = Environment.GetCommandLineArgs()
        Try
            TextBoxIs.Text = IO.File.ReadAllText(args(1))
            OpenedFile = args(1)
            MoveWindow.Text = OpenedFile
        Catch ex As Exception

        End Try
    End Sub
End Class