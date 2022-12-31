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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.HelpToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip = New System.Windows.Forms.MenuStrip()
        Me.FileCollection = New System.Windows.Forms.ToolStripMenuItem()
        Me.OpenButton = New System.Windows.Forms.ToolStripMenuItem()
        Me.SaveButton = New System.Windows.Forms.ToolStripMenuItem()
        Me.SaveAsButton = New System.Windows.Forms.ToolStripMenuItem()
        Me.TextBoxIs = New System.Windows.Forms.TextBox()
        Me.LabelFont = New System.Windows.Forms.Label()
        Me.ComboBoxFont = New System.Windows.Forms.ComboBox()
        Me.ContextMenuStrip1.SuspendLayout()
        Me.MenuStrip.SuspendLayout()
        Me.SuspendLayout()
        '
        'HelpToolStripMenuItem
        '
        Me.HelpToolStripMenuItem.Name = "HelpToolStripMenuItem"
        Me.HelpToolStripMenuItem.Size = New System.Drawing.Size(44, 24)
        Me.HelpToolStripMenuItem.Text = "Help"
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.ContextMenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem})
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(93, 26)
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(92, 22)
        Me.FileToolStripMenuItem.Text = "File"
        '
        'MenuStrip
        '
        Me.MenuStrip.AutoSize = False
        Me.MenuStrip.BackColor = System.Drawing.SystemColors.Control
        Me.MenuStrip.GripMargin = New System.Windows.Forms.Padding(0)
        Me.MenuStrip.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.MenuStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileCollection, Me.HelpToolStripMenuItem})
        Me.MenuStrip.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow
        Me.MenuStrip.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip.Name = "MenuStrip"
        Me.MenuStrip.Padding = New System.Windows.Forms.Padding(0)
        Me.MenuStrip.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional
        Me.MenuStrip.Size = New System.Drawing.Size(784, 24)
        Me.MenuStrip.TabIndex = 8
        '
        'FileCollection
        '
        Me.FileCollection.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.OpenButton, Me.SaveButton, Me.SaveAsButton})
        Me.FileCollection.Name = "FileCollection"
        Me.FileCollection.Size = New System.Drawing.Size(37, 24)
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
        'TextBoxIs
        '
        Me.TextBoxIs.AcceptsTab = True
        Me.TextBoxIs.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBoxIs.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.TextBoxIs.Location = New System.Drawing.Point(0, 24)
        Me.TextBoxIs.Margin = New System.Windows.Forms.Padding(0)
        Me.TextBoxIs.MaxLength = 2147483647
        Me.TextBoxIs.Multiline = True
        Me.TextBoxIs.Name = "TextBoxIs"
        Me.TextBoxIs.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.TextBoxIs.Size = New System.Drawing.Size(784, 536)
        Me.TextBoxIs.TabIndex = 1
        Me.TextBoxIs.WordWrap = False
        '
        'LabelFont
        '
        Me.LabelFont.AutoSize = True
        Me.LabelFont.Location = New System.Drawing.Point(83, 3)
        Me.LabelFont.Margin = New System.Windows.Forms.Padding(0)
        Me.LabelFont.Name = "LabelFont"
        Me.LabelFont.Size = New System.Drawing.Size(31, 15)
        Me.LabelFont.TabIndex = 9
        Me.LabelFont.Text = "Font"
        '
        'ComboBoxFont
        '
        Me.ComboBoxFont.FormattingEnabled = True
        Me.ComboBoxFont.Items.AddRange(New Object() {"5", "6", "7", "8", "9", "10", "11", "12", "14", "16", "18", "20", "22", "24", "26", "28", "36"})
        Me.ComboBoxFont.Location = New System.Drawing.Point(120, 0)
        Me.ComboBoxFont.Margin = New System.Windows.Forms.Padding(0)
        Me.ComboBoxFont.Name = "ComboBoxFont"
        Me.ComboBoxFont.Size = New System.Drawing.Size(50, 23)
        Me.ComboBoxFont.TabIndex = 10
        Me.ComboBoxFont.Text = "9"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.ClientSize = New System.Drawing.Size(784, 561)
        Me.Controls.Add(Me.ComboBoxFont)
        Me.Controls.Add(Me.LabelFont)
        Me.Controls.Add(Me.TextBoxIs)
        Me.Controls.Add(Me.MenuStrip)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.MenuStrip
        Me.Margin = New System.Windows.Forms.Padding(1, 2, 1, 2)
        Me.Name = "Form1"
        Me.Text = "Calc > Untitled"
        Me.ContextMenuStrip1.ResumeLayout(False)
        Me.MenuStrip.ResumeLayout(False)
        Me.MenuStrip.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ContextMenuStrip1 As ContextMenuStrip
    Friend WithEvents FileToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents MenuStrip As MenuStrip
    Friend WithEvents FileCollection As ToolStripMenuItem
    Friend WithEvents OpenButton As ToolStripMenuItem
    Friend WithEvents SaveButton As ToolStripMenuItem
    Friend WithEvents SaveAsButton As ToolStripMenuItem
    Friend WithEvents TextBoxIs As TextBox
    Friend WithEvents HelpToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents LabelFont As Label
    Friend WithEvents ComboBoxFont As ComboBox
End Class
