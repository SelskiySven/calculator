<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.TextBoxIs = New System.Windows.Forms.RichTextBox()
        Me.CloseButton = New System.Windows.Forms.Button()
        Me.MoveWindow = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'TextBoxIs
        '
        Me.TextBoxIs.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBoxIs.Location = New System.Drawing.Point(0, 32)
        Me.TextBoxIs.Margin = New System.Windows.Forms.Padding(0)
        Me.TextBoxIs.Name = "TextBoxIs"
        Me.TextBoxIs.Size = New System.Drawing.Size(800, 568)
        Me.TextBoxIs.TabIndex = 0
        Me.TextBoxIs.Text = ""
        '
        'CloseButton
        '
        Me.CloseButton.Cursor = System.Windows.Forms.Cursors.Hand
        Me.CloseButton.FlatAppearance.BorderSize = 0
        Me.CloseButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red
        Me.CloseButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.CloseButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.CloseButton.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.CloseButton.Location = New System.Drawing.Point(768, 0)
        Me.CloseButton.Name = "CloseButton"
        Me.CloseButton.Size = New System.Drawing.Size(32, 32)
        Me.CloseButton.TabIndex = 1
        Me.CloseButton.Text = "X"
        Me.CloseButton.UseVisualStyleBackColor = True
        '
        'MoveWindow
        '
        Me.MoveWindow.BackColor = System.Drawing.SystemColors.Control
        Me.MoveWindow.Location = New System.Drawing.Point(0, 0)
        Me.MoveWindow.Name = "MoveWindow"
        Me.MoveWindow.Size = New System.Drawing.Size(768, 32)
        Me.MoveWindow.TabIndex = 2
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 600)
        Me.Controls.Add(Me.MoveWindow)
        Me.Controls.Add(Me.CloseButton)
        Me.Controls.Add(Me.TextBoxIs)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "Form1"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TextBoxIs As RichTextBox
    Friend WithEvents CloseButton As Button
    Friend WithEvents MoveWindow As Label
End Class
