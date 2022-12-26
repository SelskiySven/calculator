Imports System.Drawing

Public Class HelpForm
    Private Sub HelpForm_Resize(sender As Object, e As EventArgs) Handles Me.Resize
        HelpTextBox.Size = New Size(Me.Size.Width - 36, Me.Size.Height - 65)
    End Sub

    Private Sub HelpForm_Load(sender As Object, e As EventArgs) Handles Me.Load
        HelpTextBox.SelectionStart = 0
        HelpTextBox.SelectionLength = 0
    End Sub
End Class