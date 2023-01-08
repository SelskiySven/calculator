<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class HelpForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(HelpForm))
        Me.HelpTextBox = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'HelpTextBox
        '
        Me.HelpTextBox.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.HelpTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.HelpTextBox.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.HelpTextBox.Location = New System.Drawing.Point(14, 16)
        Me.HelpTextBox.Margin = New System.Windows.Forms.Padding(0)
        Me.HelpTextBox.Multiline = True
        Me.HelpTextBox.Name = "HelpTextBox"
        Me.HelpTextBox.ReadOnly = True
        Me.HelpTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.HelpTextBox.Size = New System.Drawing.Size(753, 511)
        Me.HelpTextBox.TabIndex = 0
        Me.HelpTextBox.Text = resources.GetString("HelpTextBox.Text")
        '
        'HelpForm
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.ClientSize = New System.Drawing.Size(776, 536)
        Me.Controls.Add(Me.HelpTextBox)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.Name = "HelpForm"
        Me.Text = "Help"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents HelpTextBox As TextBox
End Class
