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
        Me.CloseButton = New System.Windows.Forms.Button()
        Me.MoveWindow = New System.Windows.Forms.Label()
        Me.OpenButton = New System.Windows.Forms.Button()
        Me.SaveButton = New System.Windows.Forms.Button()
        Me.SaveAsButton = New System.Windows.Forms.Button()
        Me.HideButton = New System.Windows.Forms.Button()
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
        Me.MoveWindow.Location = New System.Drawing.Point(214, 0)
        Me.MoveWindow.Name = "MoveWindow"
        Me.MoveWindow.Size = New System.Drawing.Size(522, 32)
        Me.MoveWindow.TabIndex = 2
        Me.MoveWindow.Text = "Untitled"
        Me.MoveWindow.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'OpenButton
        '
        Me.OpenButton.Location = New System.Drawing.Point(1, 1)
        Me.OpenButton.Name = "OpenButton"
        Me.OpenButton.Size = New System.Drawing.Size(70, 30)
        Me.OpenButton.TabIndex = 3
        Me.OpenButton.Text = "Open"
        Me.OpenButton.UseVisualStyleBackColor = True
        '
        'SaveButton
        '
        Me.SaveButton.Location = New System.Drawing.Point(72, 1)
        Me.SaveButton.Name = "SaveButton"
        Me.SaveButton.Size = New System.Drawing.Size(70, 30)
        Me.SaveButton.TabIndex = 4
        Me.SaveButton.Text = "Save"
        Me.SaveButton.UseVisualStyleBackColor = True
        '
        'SaveAsButton
        '
        Me.SaveAsButton.Location = New System.Drawing.Point(143, 1)
        Me.SaveAsButton.Name = "SaveAsButton"
        Me.SaveAsButton.Size = New System.Drawing.Size(70, 30)
        Me.SaveAsButton.TabIndex = 5
        Me.SaveAsButton.Text = "Save as"
        Me.SaveAsButton.UseVisualStyleBackColor = True
        '
        'HideButton
        '
        Me.HideButton.Cursor = System.Windows.Forms.Cursors.Hand
        Me.HideButton.FlatAppearance.BorderSize = 0
        Me.HideButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightGray
        Me.HideButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.HideButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.HideButton.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.HideButton.Location = New System.Drawing.Point(736, 0)
        Me.HideButton.Name = "HideButton"
        Me.HideButton.Size = New System.Drawing.Size(32, 32)
        Me.HideButton.TabIndex = 6
        Me.HideButton.Text = "—"
        Me.HideButton.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(120.0!, 120.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.ClientSize = New System.Drawing.Size(800, 600)
        Me.Controls.Add(Me.HideButton)
        Me.Controls.Add(Me.SaveAsButton)
        Me.Controls.Add(Me.SaveButton)
        Me.Controls.Add(Me.OpenButton)
        Me.Controls.Add(Me.MoveWindow)
        Me.Controls.Add(Me.CloseButton)
        Me.Controls.Add(Me.TextBoxIs)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "Form1"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TextBoxIs As RichTextBox
    Friend WithEvents CloseButton As Button
    Friend WithEvents MoveWindow As Label
    Friend WithEvents OpenButton As Button
    Friend WithEvents SaveButton As Button
    Friend WithEvents SaveAsButton As Button
    Friend WithEvents HideButton As Button
End Class
