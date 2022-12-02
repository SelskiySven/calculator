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
        Me.LabelFont = New System.Windows.Forms.Label()
        Me.FontChange = New System.Windows.Forms.ComboBox()
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.FileCollection = New System.Windows.Forms.ToolStripMenuItem()
        Me.OpenButton = New System.Windows.Forms.ToolStripMenuItem()
        Me.SaveButton = New System.Windows.Forms.ToolStripMenuItem()
        Me.SaveAsButton = New System.Windows.Forms.ToolStripMenuItem()
        Me.TextBoxIs = New System.Windows.Forms.TextBox()
        Me.ContextMenuStrip1.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'LabelFont
        '
        Me.LabelFont.AutoSize = True
        Me.LabelFont.Location = New System.Drawing.Point(54, 4)
        Me.LabelFont.Name = "LabelFont"
        Me.LabelFont.Size = New System.Drawing.Size(38, 20)
        Me.LabelFont.TabIndex = 6
        Me.LabelFont.Text = "Font"
        '
        'FontChange
        '
        Me.FontChange.BackColor = System.Drawing.SystemColors.Window
        Me.FontChange.FormattingEnabled = True
        Me.FontChange.Items.AddRange(New Object() {"8", "9", "10", "11", "12", "14", "16", "18", "20", "22", "24", "26", "28", "36", "48", "72"})
        Me.FontChange.Location = New System.Drawing.Point(96, 0)
        Me.FontChange.Name = "FontChange"
        Me.FontChange.Size = New System.Drawing.Size(57, 28)
        Me.FontChange.TabIndex = 7
        Me.FontChange.Text = "9"
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.ContextMenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem})
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(102, 28)
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(101, 24)
        Me.FileToolStripMenuItem.Text = "File"
        '
        'MenuStrip1
        '
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileCollection})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(800, 28)
        Me.MenuStrip1.TabIndex = 8
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'FileCollection
        '
        Me.FileCollection.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.OpenButton, Me.SaveButton, Me.SaveAsButton})
        Me.FileCollection.Name = "FileCollection"
        Me.FileCollection.Size = New System.Drawing.Size(46, 24)
        Me.FileCollection.Text = "File"
        '
        'OpenButton
        '
        Me.OpenButton.Name = "OpenButton"
        Me.OpenButton.Size = New System.Drawing.Size(196, 26)
        Me.OpenButton.Text = "Open (CTRL+O)"
        '
        'SaveButton
        '
        Me.SaveButton.Name = "SaveButton"
        Me.SaveButton.Size = New System.Drawing.Size(196, 26)
        Me.SaveButton.Text = "Save (CTRL+S)"
        '
        'SaveAsButton
        '
        Me.SaveAsButton.Name = "SaveAsButton"
        Me.SaveAsButton.Size = New System.Drawing.Size(196, 26)
        Me.SaveAsButton.Text = "Save As"
        '
        'TextBoxIs
        '
        Me.TextBoxIs.AcceptsTab = True
        Me.TextBoxIs.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBoxIs.Location = New System.Drawing.Point(0, 28)
        Me.TextBoxIs.Margin = New System.Windows.Forms.Padding(0)
        Me.TextBoxIs.MaxLength = 2147483647
        Me.TextBoxIs.Multiline = True
        Me.TextBoxIs.Name = "TextBoxIs"
        Me.TextBoxIs.Size = New System.Drawing.Size(800, 572)
        Me.TextBoxIs.TabIndex = 1
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(120.0!, 120.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.BackColor = System.Drawing.SystemColors.MenuBar
        Me.ClientSize = New System.Drawing.Size(800, 600)
        Me.Controls.Add(Me.TextBoxIs)
        Me.Controls.Add(Me.FontChange)
        Me.Controls.Add(Me.LabelFont)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "Form1"
        Me.Text = "Calc > Untitled"
        Me.ContextMenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents LabelFont As Label
    Friend WithEvents FontChange As ComboBox
    Friend WithEvents ContextMenuStrip1 As ContextMenuStrip
    Friend WithEvents FileToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents FileCollection As ToolStripMenuItem
    Friend WithEvents OpenButton As ToolStripMenuItem
    Friend WithEvents SaveButton As ToolStripMenuItem
    Friend WithEvents SaveAsButton As ToolStripMenuItem
    Friend WithEvents TextBoxIs As TextBox
End Class
