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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.TextBoxIs = New System.Windows.Forms.RichTextBox()
        Me.OpenButton = New System.Windows.Forms.Button()
        Me.SaveButton = New System.Windows.Forms.Button()
        Me.SaveAsButton = New System.Windows.Forms.Button()
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
        Me.TextBoxIs.WordWrap = False
        '
        'OpenButton
        '
        Me.OpenButton.BackColor = System.Drawing.SystemColors.Control
        Me.OpenButton.Location = New System.Drawing.Point(2, 2)
        Me.OpenButton.Margin = New System.Windows.Forms.Padding(0)
        Me.OpenButton.Name = "OpenButton"
        Me.OpenButton.Size = New System.Drawing.Size(70, 28)
        Me.OpenButton.TabIndex = 3
        Me.OpenButton.Text = "Open"
        Me.OpenButton.UseVisualStyleBackColor = False
        '
        'SaveButton
        '
        Me.SaveButton.BackColor = System.Drawing.SystemColors.Control
        Me.SaveButton.Location = New System.Drawing.Point(74, 2)
        Me.SaveButton.Margin = New System.Windows.Forms.Padding(0)
        Me.SaveButton.Name = "SaveButton"
        Me.SaveButton.Size = New System.Drawing.Size(70, 28)
        Me.SaveButton.TabIndex = 4
        Me.SaveButton.Text = "Save"
        Me.SaveButton.UseVisualStyleBackColor = False
        '
        'SaveAsButton
        '
        Me.SaveAsButton.BackColor = System.Drawing.SystemColors.Control
        Me.SaveAsButton.Location = New System.Drawing.Point(146, 2)
        Me.SaveAsButton.Margin = New System.Windows.Forms.Padding(0)
        Me.SaveAsButton.Name = "SaveAsButton"
        Me.SaveAsButton.Size = New System.Drawing.Size(70, 28)
        Me.SaveAsButton.TabIndex = 5
        Me.SaveAsButton.Text = "Save as"
        Me.SaveAsButton.UseVisualStyleBackColor = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(120.0!, 120.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.BackColor = System.Drawing.SystemColors.MenuBar
        Me.ClientSize = New System.Drawing.Size(800, 600)
        Me.Controls.Add(Me.SaveAsButton)
        Me.Controls.Add(Me.SaveButton)
        Me.Controls.Add(Me.OpenButton)
        Me.Controls.Add(Me.TextBoxIs)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "Form1"
        Me.Text = "Calc > Untitled"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TextBoxIs As RichTextBox
    Friend WithEvents OpenButton As Button
    Friend WithEvents SaveButton As Button
    Friend WithEvents SaveAsButton As Button
End Class
