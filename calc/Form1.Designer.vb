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
        Me.HelpToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip = New System.Windows.Forms.MenuStrip()
        Me.FileCollection = New System.Windows.Forms.ToolStripMenuItem()
        Me.OpenButton = New System.Windows.Forms.ToolStripMenuItem()
        Me.SaveButton = New System.Windows.Forms.ToolStripMenuItem()
        Me.SaveAsButton = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripComboBoxFont = New System.Windows.Forms.ToolStripComboBox()
        Me.LabelFont = New System.Windows.Forms.Label()
        Me.TextBoxIs = New System.Windows.Forms.TextBox()
        Me.MenuStrip.SuspendLayout()
        Me.SuspendLayout()
        '
        'HelpToolStripMenuItem
        '
        Me.HelpToolStripMenuItem.Name = "HelpToolStripMenuItem"
        Me.HelpToolStripMenuItem.Padding = New System.Windows.Forms.Padding(0)
        Me.HelpToolStripMenuItem.Size = New System.Drawing.Size(36, 32)
        Me.HelpToolStripMenuItem.Text = "Help"
        '
        'MenuStrip
        '
        Me.MenuStrip.AutoSize = False
        Me.MenuStrip.BackColor = System.Drawing.SystemColors.Control
        Me.MenuStrip.GripMargin = New System.Windows.Forms.Padding(0)
        Me.MenuStrip.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.MenuStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileCollection, Me.HelpToolStripMenuItem, Me.ToolStripComboBoxFont})
        Me.MenuStrip.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow
        Me.MenuStrip.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip.Name = "MenuStrip"
        Me.MenuStrip.Padding = New System.Windows.Forms.Padding(0)
        Me.MenuStrip.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional
        Me.MenuStrip.Size = New System.Drawing.Size(784, 32)
        Me.MenuStrip.TabIndex = 8
        '
        'FileCollection
        '
        Me.FileCollection.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.OpenButton, Me.SaveButton, Me.SaveAsButton})
        Me.FileCollection.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.FileCollection.Name = "FileCollection"
        Me.FileCollection.Padding = New System.Windows.Forms.Padding(0)
        Me.FileCollection.Size = New System.Drawing.Size(29, 32)
        Me.FileCollection.Text = "File"
        '
        'OpenButton
        '
        Me.OpenButton.Name = "OpenButton"
        Me.OpenButton.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.O), System.Windows.Forms.Keys)
        Me.OpenButton.Size = New System.Drawing.Size(186, 22)
        Me.OpenButton.Text = "Open "
        '
        'SaveButton
        '
        Me.SaveButton.Name = "SaveButton"
        Me.SaveButton.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.S), System.Windows.Forms.Keys)
        Me.SaveButton.Size = New System.Drawing.Size(186, 22)
        Me.SaveButton.Text = "Save"
        '
        'SaveAsButton
        '
        Me.SaveAsButton.Name = "SaveAsButton"
        Me.SaveAsButton.ShortcutKeys = CType(((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.Shift) _
            Or System.Windows.Forms.Keys.S), System.Windows.Forms.Keys)
        Me.SaveAsButton.Size = New System.Drawing.Size(186, 22)
        Me.SaveAsButton.Text = "Save As"
        '
        'ToolStripComboBoxFont
        '
        Me.ToolStripComboBoxFont.Items.AddRange(New Object() {"5", "6", "7", "8", "9", "10", "11", "12", "14", "16", "18", "20", "22", "24", "26", "28", "36"})
        Me.ToolStripComboBoxFont.Margin = New System.Windows.Forms.Padding(50, 0, 0, 0)
        Me.ToolStripComboBoxFont.Name = "ToolStripComboBoxFont"
        Me.ToolStripComboBoxFont.Size = New System.Drawing.Size(75, 32)
        Me.ToolStripComboBoxFont.Text = "9"
        '
        'LabelFont
        '
        Me.LabelFont.Location = New System.Drawing.Point(63, 0)
        Me.LabelFont.Margin = New System.Windows.Forms.Padding(0)
        Me.LabelFont.Name = "LabelFont"
        Me.LabelFont.Size = New System.Drawing.Size(50, 32)
        Me.LabelFont.TabIndex = 9
        Me.LabelFont.Text = "Font"
        Me.LabelFont.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'TextBoxIs
        '
        Me.TextBoxIs.AcceptsTab = True
        Me.TextBoxIs.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBoxIs.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.TextBoxIs.Location = New System.Drawing.Point(0, 32)
        Me.TextBoxIs.Margin = New System.Windows.Forms.Padding(0)
        Me.TextBoxIs.MaxLength = 2147483647
        Me.TextBoxIs.Multiline = True
        Me.TextBoxIs.Name = "TextBoxIs"
        Me.TextBoxIs.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.TextBoxIs.Size = New System.Drawing.Size(784, 529)
        Me.TextBoxIs.TabIndex = 1
        Me.TextBoxIs.WordWrap = False
        '
        'Form1
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.ClientSize = New System.Drawing.Size(784, 561)
        Me.Controls.Add(Me.LabelFont)
        Me.Controls.Add(Me.TextBoxIs)
        Me.Controls.Add(Me.MenuStrip)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.MenuStrip
        Me.Margin = New System.Windows.Forms.Padding(1, 2, 1, 2)
        Me.Name = "Form1"
        Me.Text = "Calc > Untitled"
        Me.MenuStrip.ResumeLayout(False)
        Me.MenuStrip.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip As MenuStrip
    Friend WithEvents FileCollection As ToolStripMenuItem
    Friend WithEvents OpenButton As ToolStripMenuItem
    Friend WithEvents SaveButton As ToolStripMenuItem
    Friend WithEvents SaveAsButton As ToolStripMenuItem
    Friend WithEvents HelpToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents TextBoxIs As TextBox
    Protected WithEvents LabelFont As Label
    Friend WithEvents ToolStripComboBoxFont As ToolStripComboBox
End Class
