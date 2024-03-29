﻿Imports System.ComponentModel
Imports System.Drawing
Imports System.Globalization
Imports System.IO
Imports System.Text
Imports System.Text.RegularExpressions
Imports System.Threading
Public Class Form1
    Public OpenedFile As String = ""
    Public LastText As String = ""
    Public LastPosition As Integer = 0
    Public LastOperationIsUndo As Boolean = False
    Public CanMissText As Boolean = False


    Public Class UndoItem
        Public Property Start As Integer = 0
        Public Property NewEnd As Integer = 0
        Public Property OldEnd As Integer = 0
        Public Property OldDiff As String = ""
        Public Property NewDiff As String = ""
        Public Property Position As Integer = 0
    End Class

    Public UndoArray As New Stack
    Public RedoArray As New Stack

    Public Class LastSave
        Public Property Text As String = ""
        Public Property UndoCount As Integer = 0
    End Class

    Function MakeSaveData()
        LastSaved.Text = TextBoxIs.Text
        LastSaved.UndoCount = UndoArray.Count()
    End Function

    Public LastSaved As New LastSave

    Private Sub TextBoxIs_KeyDown(sender As Object, e As KeyEventArgs) Handles TextBoxIs.KeyDown
        If e.KeyCode = Keys.Enter And Not e.Shift Then
            e.SuppressKeyPress = True
            Dim Position As Integer = TextBoxIs.SelectionStart
            Dim FirstText, Row As String
            Thread.CurrentThread.CurrentCulture = New CultureInfo("en-Us")
            If TextBoxIs.Lines.Length = 0 Then
                Row = ""
            Else
                Row = TextBoxIs.Lines(TextBoxIs.GetLineFromCharIndex(Position))
            End If
            Row = LCase(Row)
            For i As Integer = 0 To 9
                Row = Row.Replace(Convert.ToString(i) + "(", Convert.ToString(i) + "*(")
                Row = Row.Replace(")" + Convert.ToString(i), ")*" + Convert.ToString(i))
                Row = Row.Replace(Convert.ToString(i) + "pi", Convert.ToString(i) + "*pi")
                Row = Row.Replace("pi" + Convert.ToString(i), "pi*" + Convert.ToString(i))
                Row = Row.Replace(Convert.ToString(i) + "e", Convert.ToString(i) + "*e")
                Row = Row.Replace("e" + Convert.ToString(i), "e*" + Convert.ToString(i))
            Next
            Row = Row.Replace("pi(", "pi*(")
            Row = Row.Replace("e(", "e*(")
            Row = Row.Replace(")pi", ")*pi")
            Row = Row.Replace(")e", ")*e")
            Row = Row.Replace("pi", Convert.ToString(Math.PI))
            Row = Row.Replace("e", Convert.ToString(Math.E))
            Row = Row.Replace(")(", ")*(")
            Row = Row.Replace(" ", "")
            Row = Row.Replace(",", ".")
            FirstText = Row + ""
            Row = Calculate(Row)
            If Row = FirstText Then
                Row = ""
            End If
            If Row <> "" Then
                Try
                    TextBoxIs.SelectionStart = TextBoxIs.GetFirstCharIndexFromLine(TextBoxIs.GetLineFromCharIndex(Position) + 1) - 2
                Catch ex As Exception
                    TextBoxIs.SelectionStart = TextBoxIs.TextLength
                End Try
            End If
            TextBoxIs.SelectedText = vbCrLf + Row
            If Row <> "" Then
                Try
                    TextBoxIs.SelectionStart = TextBoxIs.GetFirstCharIndexFromLine(TextBoxIs.GetLineFromCharIndex(Position) + 2) - 2
                Catch ex As Exception
                    TextBoxIs.SelectionStart = TextBoxIs.TextLength
                End Try
            End If
        End If

        If e.KeyCode = Keys.KeyCode.Enter And e.Shift Then
            e.SuppressKeyPress = True
            TextBoxIs.SelectedText = vbCrLf
        End If

        If e.KeyCode = Keys.KeyCode.Z And e.Control Then
            e.SuppressKeyPress = True
            If UndoArray.Count > 0 Then
                LastOperationIsUndo = True
                Dim Position As Integer = TextBoxIs.SelectionStart
                Dim MakeUndo As UndoItem = UndoArray.Pop()
                TextBoxIs.SelectionStart = MakeUndo.Start
                TextBoxIs.SelectionLength = MakeUndo.NewEnd - MakeUndo.Start
                TextBoxIs.SelectedText = ""
                If MakeUndo.OldDiff <> "" Then
                    LastOperationIsUndo = True
                    TextBoxIs.SelectedText = MakeUndo.OldDiff
                    TextBoxIs.SelectionStart = MakeUndo.Position
                End If
                MakeUndo.Position = Position + 0
                RedoArray.Push(MakeUndo)
            End If
        End If

        If e.KeyCode = Keys.KeyCode.Y And e.Control Then
            e.SuppressKeyPress = True
            If RedoArray.Count > 0 Then
                LastOperationIsUndo = True
                Dim Position As Integer = TextBoxIs.SelectionStart
                Dim MakeRedo As UndoItem = RedoArray.Pop()
                TextBoxIs.SelectionStart = MakeRedo.Start
                TextBoxIs.SelectionLength = MakeRedo.OldEnd - MakeRedo.Start
                TextBoxIs.SelectedText = ""
                If MakeRedo.NewDiff <> "" Then
                    LastOperationIsUndo = True
                    TextBoxIs.SelectedText = MakeRedo.NewDiff
                End If
                TextBoxIs.SelectionStart = MakeRedo.Position
                MakeRedo.Position = Position + 0
                UndoArray.Push(MakeRedo)
            End If
        End If
    End Sub

    Function ConvertToString(dbl As Double)
        Dim str As String
        str = Convert.ToString(dbl)
        If str.Contains("E") Then
            Dim EIndex As Integer = str.IndexOf("E")
            Dim power As Integer = Convert.ToInt32(str.Substring(EIndex + 2)) - 1
            If str(0) = "-" Then
                str = "-0." + New String("0", power) + str.Substring(1, EIndex - 1)
            Else
                str = "0." + New String("0", power) + str.Substring(0, EIndex)
            End If
        End If
        Return str
    End Function

    Function Calculate(str As String)
        Dim start, count As Integer
        Dim s1, s2, s3, f, c1, c2 As String
        Dim c1d, c2d As Double

        'Try
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
                                Try
                                    If IsNumeric(s1(s1.Length - i)) Then
                                        s1 = s1.Substring(0, s1.Length - i + 1) + "*" + f
                                    End If
                                Catch ex As Exception

                                End Try
                                Select Case f
                                    Case "sin"
                                        s2 = ConvertToString(Math.Round(Math.Sin(Convert.ToDouble(s2) * Math.PI / 180), 9))
                                    Case "cos"
                                        s2 = ConvertToString(Math.Round(Math.Cos(Convert.ToDouble(s2) * Math.PI / 180), 9))
                                    Case "tan"
                                        s2 = ConvertToString(Math.Round(Math.Tan(Convert.ToDouble(s2) * Math.PI / 180), 9))
                                    Case "ctn"
                                        s2 = ConvertToString(Math.Round(Math.Tan(1 / Convert.ToDouble(s2) * Math.PI / 180), 9))
                                    Case "arcsin"
                                        s2 = ConvertToString(Math.Round(Math.Asin(Convert.ToDouble(s2)) * 180 / Math.PI, 9))
                                    Case "arccos"
                                        s2 = ConvertToString(Math.Round(Math.Acos(Convert.ToDouble(s2)) * 180 / Math.PI, 9))
                                    Case "arctan"
                                        s2 = ConvertToString(Math.Round(Math.Atan(Convert.ToDouble(s2)) * 180 / Math.PI, 9))
                                    Case "arcctg"
                                        s2 = ConvertToString(Math.Round(1 / Math.Atan(Convert.ToDouble(s2)) * 180 / Math.PI, 9))
                                    Case "sinh"
                                        s2 = ConvertToString(Math.Round(Math.Sinh(Convert.ToDouble(s2) * Math.PI / 180), 9))
                                    Case "cosh"
                                        s2 = ConvertToString(Math.Round(Math.Cosh(Convert.ToDouble(s2) * Math.PI / 180), 9))
                                    Case "tanh"
                                        s2 = ConvertToString(Math.Round(Math.Tanh(Convert.ToDouble(s2) * Math.PI / 180), 9))
                                    Case "arcsinh"
                                        s2 = ConvertToString(Math.Round(Math.Asinh(Convert.ToDouble(s2)) * 180 / Math.PI, 9))
                                    Case "arccosh"
                                        s2 = ConvertToString(Math.Round(Math.Acosh(Convert.ToDouble(s2)) * 180 / Math.PI, 9))
                                    Case "arctanh"
                                        s2 = ConvertToString(Math.Round(Math.Atanh(Convert.ToDouble(s2)) * 180 / Math.PI, 9))
                                    Case "sqrt"
                                        s2 = ConvertToString(Math.Round(Convert.ToDouble(s2) ^ 0.5, 9))
                                    Case "ln"
                                        s2 = ConvertToString(Math.Round(Math.Log(Convert.ToDouble(s2)), 9))
                                    Case "lg"
                                        s2 = ConvertToString(Math.Round(Math.Log(Convert.ToDouble(s2)) / Math.Log(10), 9))
                                    Case "log"
                                        If s2.Contains(";") Then
                                            s2 = ConvertToString(Math.Round(Math.Log(Convert.ToDouble(s2.Substring(s2.IndexOf(";") + 1))) / Math.Log(Convert.ToDouble(s2.Substring(0, s2.IndexOf(";")))), 9))
                                        Else
                                            s2 = ConvertToString(Math.Round(Math.Log(Convert.ToDouble(s2)), 9))
                                        End If
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

            While str.Contains("!")
                c1 = ""
                start = 0
                count = 1
                For i As Integer = 0 To str.Length
                    If (IsNumeric(str(i)) Or str(i) = "," Or str(i) = ".") And c1 = "" Then
                        c1 = str(i)
                        start = i + 0
                        count = 1
                    ElseIf IsNumeric(str(i)) Or str(i) = "," Or str(i) = "." Then
                        c1 += str(i)
                        count += 1
                    ElseIf str(i) = "!" Then
                        count += 1
                        c1d = Convert.ToDouble(c1)
                        s1 = str.Substring(0, start)
                        c2d = 1
                        For j As Integer = 1 To c1d
                            c2d = c2d * j
                        Next
                        s2 = ConvertToString(c2d)
                        s3 = str.Substring(start + count)
                        str = s1 + s2 + s3
                        Exit For
                    Else
                        c1 = ""
                    End If
                Next
            End While

            While str.Contains("^")
                c1 = ""
                c2 = ""
                start = 0
                count = 0
                For i As Integer = str.Length() - 1 To 0 Step -1
                    If ((IsNumeric(str(i)) Or str(i) = "," Or str(i) = ".") Or (str(i) = "-" And Not IsNumeric(str(Math.Max(i - 1, 0))))) And c1 = "" Then
                        c2 = str(i) + c2
                        count += 1
                    ElseIf str(i) = "^" And c1 = "" Then
                        c1 = " "
                        count += 1
                    ElseIf c1 <> "" And ((IsNumeric(str(i)) Or str(i) = "," Or str(i) = ".") Or (str(i) = "-" And i = 0)) Then
                        c1 = str(i) + c1
                        count += 1
                    ElseIf c1 <> "" And ((IsNumeric(str(i)) Or str(i) = "," Or str(i) = ".") Or (str(i) = "-" And Not IsNumeric(str(Math.Max(i - 1, 0))))) Then
                        c1 = str(i) + c1
                        count += 1
                    ElseIf str(i) <> "," And str(i) <> "." And Not IsNumeric(str(i)) And c1 = "" Then
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
                s2 = ConvertToString(Math.Round(c1d ^ c2d, 9))
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
                    If ((IsNumeric(str(i)) Or str(i) = "," Or str(i) = ".") Or (c1 = "" And str(i) = "-")) And c2 = "" Then
                        c1 = c1 + str(i)
                        count += 1
                    ElseIf (str(i) = "*" Or str(i) = "/") And c2 = "" Then
                        c2 = " "
                        count += 1
                        f = str(i)
                    ElseIf c2 <> "" And ((IsNumeric(str(i)) Or str(i) = "," Or str(i) = ".") Or (c2 = " " And str(i) = "-")) Then
                        c2 = c2 + str(i)
                        count += 1
                    ElseIf str(i) <> "," And str(i) <> "." And Not IsNumeric(str(i)) And c2 = "" Then
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
                        s2 = ConvertToString(Math.Round(c1d * c2d, 9))
                    Case "/"
                        s2 = ConvertToString(Math.Round(c1d / c2d, 9))
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
                    If (IsNumeric(str(i)) Or str(i) = "," Or str(i) = "." Or (c1 = "" And str(i) = "-")) And c2 = "" Then
                        c1 = c1 + str(i)
                        count += 1
                    ElseIf (str(i) = "+" Or str(i) = "-") And c2 = "" Then
                        c2 = " "
                        count += 1
                        f = str(i)
                    ElseIf c2 <> "" And ((IsNumeric(str(i)) Or str(i) = "," Or str(i) = ".") Or (c2 = " " And str(i) = "-")) Then
                        c2 = c2 + str(i)
                        count += 1
                    ElseIf str(i) <> "," And str(i) <> "." And Not IsNumeric(str(i)) And c2 = "" Then
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
                        s2 = ConvertToString(Math.Round(c1d + c2d, 9))
                    Case "-"
                        s2 = ConvertToString(Math.Round(c1d - c2d, 9))
                End Select
                s3 = str.Substring(start + count)
                str = s1 + s2 + s3
            End While
            For Each num In Regex.Split(str, ";")
                If Not IsNumeric(num) Or num.Contains("£") Then
                    Return ""
                End If
            Next
            Return str
        'Catch ex As Exception
        'Return ""
        'End Try
    End Function

    Private Sub SaveAsButton_Click(sender As Object, e As EventArgs) Handles SaveAsButton.Click
        Dim SaveAsFile As New SaveFileDialog
        SaveAsFile.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*"
        If SaveAsFile.ShowDialog <> DialogResult.Cancel Then
            Save(SaveAsFile.FileName)
            OpenedFile = SaveAsFile.FileName
            MakeSaveData()
        End If
    End Sub
    Private Sub OpenButton_Click(sender As Object, e As EventArgs) Handles OpenButton.Click
        FunctionOpenFile()
    End Sub
    Function FunctionOpenFile()
        Dim OpenFile As New OpenFileDialog
        OpenFile.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*"
        If OpenFile.ShowDialog <> DialogResult.Cancel Then
            If CanMissText Then
                Dim QuestionAboutDataMiss As DialogResult = MessageBox.Show("Do you want to save changes?", "Calc", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Exclamation)
                If QuestionAboutDataMiss = DialogResult.Cancel Then
                    Exit Function
                ElseIf QuestionAboutDataMiss = DialogResult.Yes Then
                    FunctionSaveFile()
                End If
            End If
            Dim TextFromFile As String = IO.File.ReadAllText(OpenFile.FileName)
            TextBoxIs.Text = TextFromFile
            OpenedFile = OpenFile.FileName
            Me.Text = "Calc > " + OpenedFile
            UndoArray.Clear()
            RedoArray.Clear()
            MakeSaveData()
            CanMissText = False
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
            Else
                Return False
            End If
        Else
            Save(OpenedFile)
        End If
        Return True
    End Function
    Function Save(path As String)
        Dim f As FileStream = File.Create(path)
        Dim filebytes As Byte() = New UTF8Encoding(True).GetBytes(TextBoxIs.Text)
        f.Write(filebytes, 0, filebytes.Length)
        f.Close()
        Me.Text = "Calc > " + path
        MakeSaveData()
        CanMissText = False
    End Function

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim args() As String = Environment.GetCommandLineArgs()
        Try
            TextBoxIs.Text = IO.File.ReadAllText(args(1))
                TextBoxIs.SelectionStart = 0
                TextBoxIs.SelectionLength = 0
            OpenedFile = args(1)
            Me.Text = "Calc > " + OpenedFile
            UndoArray.Clear()
            CanMissText = False
            MakeSaveData()
        Catch ex As Exception

        End Try
        Me.ToolStripComboBoxFont.Margin = New System.Windows.Forms.Padding(LabelFont.Size.Width, 0, 0, 0)
        Me.LabelFont.Location = New System.Drawing.Point(FileCollection.Size.Width + HelpToolStripMenuItem.Size.Width, 0)
        Dim RectangleData = Me.RectangleToScreen(Me.ClientRectangle)
        TextBoxIs.Size = New Size(RectangleData.Width, RectangleData.Height - 32)
        HelpTextBox.Size = New Size(RectangleData.Width, (RectangleData.Height) / 2)
    End Sub

    Private Sub Form1_Resize(sender As Object, e As EventArgs) Handles MyBase.Resize
        Dim RectangleData = Me.RectangleToScreen(Me.ClientRectangle)
        TextBoxIs.Size = New Size(RectangleData.Width, RectangleData.Height - 32)
        HelpTextBox.Size = New Size(RectangleData.Width, (RectangleData.Height) / 2)
        HelpTextBox.Top = (RectangleData.Height) / 2
    End Sub
    Private Sub TextBoxIs_TextChanged(sender As Object, e As EventArgs) Handles TextBoxIs.TextChanged
        If Not LastOperationIsUndo Then
            Dim NewUndoItem As New UndoItem
            Dim CurrentText As String = TextBoxIs.Text
            NewUndoItem.Start = 0
            If CurrentText.Length <> 0 And LastText.Length <> 0 Then
                While LastText(NewUndoItem.Start) = CurrentText(NewUndoItem.Start)
                    NewUndoItem.Start += 1
                    If NewUndoItem.Start = LastText.Length Or NewUndoItem.Start = CurrentText.Length Then
                        Exit While
                    End If
                End While
                NewUndoItem.OldEnd = LastText.Length - 1
                NewUndoItem.NewEnd = CurrentText.Length - 1
                While CurrentText(NewUndoItem.NewEnd) = LastText(NewUndoItem.OldEnd) And NewUndoItem.NewEnd > NewUndoItem.Start And NewUndoItem.OldEnd > NewUndoItem.Start
                    NewUndoItem.NewEnd -= 1
                    NewUndoItem.OldEnd -= 1
                End While
                NewUndoItem.NewEnd += 1
                NewUndoItem.OldEnd += 1
            Else
                NewUndoItem.NewEnd = CurrentText.Length
                NewUndoItem.OldEnd = LastText.Length
            End If
            NewUndoItem.NewDiff = CurrentText.Substring(NewUndoItem.Start, NewUndoItem.NewEnd - NewUndoItem.Start)
            NewUndoItem.OldDiff = LastText.Substring(NewUndoItem.Start, NewUndoItem.OldEnd - NewUndoItem.Start)
            NewUndoItem.Position = LastPosition + 0
            UndoArray.Push(NewUndoItem)
            RedoArray.Clear()
        Else
            LastOperationIsUndo = False
        End If
        LastText = TextBoxIs.Text + ""
        LastPosition = TextBoxIs.SelectionStart + 0
        If (LastSaved.Text <> TextBoxIs.Text Or LastSaved.UndoCount <> UndoArray.Count) And Me.Text(Me.Text.Length - 1) <> "*" Then
            Me.Text += "*"
            CanMissText = True
        ElseIf LastSaved.Text = TextBoxIs.Text And LastSaved.UndoCount = UndoArray.Count And Me.Text(Me.Text.Length - 1) = "*" Then
            If OpenedFile = "" Then
                Me.Text = "Calc > Untitled"
            Else
                Me.Text = "Calc > " + OpenedFile
            End If
            CanMissText = False
        End If
    End Sub

    Private Sub Form1_Closing(sender As Object, e As CancelEventArgs) Handles MyBase.Closing
        If CanMissText Then
            Dim QuestionAboutDataMiss As DialogResult = MessageBox.Show("Do you want to save changes?", "Calc", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Exclamation)
            If QuestionAboutDataMiss = DialogResult.Cancel Then
                e.Cancel = True
            ElseIf QuestionAboutDataMiss = DialogResult.Yes Then
                If Not FunctionSaveFile() Then
                    e.Cancel = True
                End If
            End If
        End If
    End Sub

    Private Sub HelpToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles HelpToolStripMenuItem.Click
        Dim RectangleData = Me.RectangleToScreen(Me.ClientRectangle)
        If HelpTextBox.Visible Then
            HelpTextBox.Visible = False
            TextBoxIs.Size = New Size(RectangleData.Width, RectangleData.Height - 32)
        Else
            HelpTextBox.Visible = True
            TextBoxIs.Size = New Size(RectangleData.Width, (RectangleData.Height - 32) / 2)
        End If
    End Sub

    Private Sub ToolStripComboBoxFont_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ToolStripComboBoxFont.SelectedIndexChanged
        TextBoxIs.Font = New Font("Segoe UI", ToolStripComboBoxFont.Text)
    End Sub
End Class