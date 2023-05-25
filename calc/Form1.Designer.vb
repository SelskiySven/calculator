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
        Dim resources As ComponentModel.ComponentResourceManager = New ComponentModel.ComponentResourceManager(GetType(Form1))
        HelpToolStripMenuItem = New ToolStripMenuItem()
        MenuStrip = New MenuStrip()
        FileCollection = New ToolStripMenuItem()
        OpenButton = New ToolStripMenuItem()
        SaveButton = New ToolStripMenuItem()
        SaveAsButton = New ToolStripMenuItem()
        ToolStripComboBoxFont = New ToolStripComboBox()
        LabelFont = New Label()
        TextBoxIs = New TextBox()
        HelpTextBox = New TextBox()
        MenuStrip.SuspendLayout()
        SuspendLayout()
        ' 
        ' HelpToolStripMenuItem
        ' 
        HelpToolStripMenuItem.Name = "HelpToolStripMenuItem"
        HelpToolStripMenuItem.Padding = New Padding(0)
        HelpToolStripMenuItem.Size = New Drawing.Size(36, 32)
        HelpToolStripMenuItem.Text = "Help"
        ' 
        ' MenuStrip
        ' 
        MenuStrip.AutoSize = False
        MenuStrip.BackColor = Drawing.SystemColors.Control
        MenuStrip.GripMargin = New Padding(0)
        MenuStrip.ImageScalingSize = New Drawing.Size(20, 20)
        MenuStrip.Items.AddRange(New ToolStripItem() {FileCollection, HelpToolStripMenuItem, ToolStripComboBoxFont})
        MenuStrip.LayoutStyle = ToolStripLayoutStyle.HorizontalStackWithOverflow
        MenuStrip.Location = New Drawing.Point(0, 0)
        MenuStrip.Name = "MenuStrip"
        MenuStrip.Padding = New Padding(0)
        MenuStrip.RenderMode = ToolStripRenderMode.Professional
        MenuStrip.Size = New Drawing.Size(784, 32)
        MenuStrip.TabIndex = 8
        ' 
        ' FileCollection
        ' 
        FileCollection.DropDownItems.AddRange(New ToolStripItem() {OpenButton, SaveButton, SaveAsButton})
        FileCollection.Font = New Drawing.Font("Segoe UI", 9F, Drawing.FontStyle.Regular, Drawing.GraphicsUnit.Point)
        FileCollection.Name = "FileCollection"
        FileCollection.Padding = New Padding(0)
        FileCollection.Size = New Drawing.Size(29, 32)
        FileCollection.Text = "File"
        ' 
        ' OpenButton
        ' 
        OpenButton.Name = "OpenButton"
        OpenButton.ShortcutKeys = Keys.Control Or Keys.O
        OpenButton.Size = New Drawing.Size(186, 22)
        OpenButton.Text = "Open "
        ' 
        ' SaveButton
        ' 
        SaveButton.Name = "SaveButton"
        SaveButton.ShortcutKeys = Keys.Control Or Keys.S
        SaveButton.Size = New Drawing.Size(186, 22)
        SaveButton.Text = "Save"
        ' 
        ' SaveAsButton
        ' 
        SaveAsButton.Name = "SaveAsButton"
        SaveAsButton.ShortcutKeys = Keys.Control Or Keys.Shift Or Keys.S
        SaveAsButton.Size = New Drawing.Size(186, 22)
        SaveAsButton.Text = "Save As"
        ' 
        ' ToolStripComboBoxFont
        ' 
        ToolStripComboBoxFont.Items.AddRange(New Object() {"5", "6", "7", "8", "9", "10", "11", "12", "14", "16", "18", "20", "22", "24", "26", "28", "36"})
        ToolStripComboBoxFont.Margin = New Padding(50, 0, 0, 0)
        ToolStripComboBoxFont.Name = "ToolStripComboBoxFont"
        ToolStripComboBoxFont.Size = New Drawing.Size(75, 32)
        ToolStripComboBoxFont.Text = "9"
        ' 
        ' LabelFont
        ' 
        LabelFont.Location = New Drawing.Point(63, 0)
        LabelFont.Margin = New Padding(0)
        LabelFont.Name = "LabelFont"
        LabelFont.Size = New Drawing.Size(50, 32)
        LabelFont.TabIndex = 9
        LabelFont.Text = "Font"
        LabelFont.TextAlign = Drawing.ContentAlignment.MiddleCenter
        ' 
        ' TextBoxIs
        ' 
        TextBoxIs.AcceptsTab = True
        TextBoxIs.BackColor = Drawing.SystemColors.Window
        TextBoxIs.BorderStyle = BorderStyle.None
        TextBoxIs.Font = New Drawing.Font("Segoe UI", 9F, Drawing.FontStyle.Regular, Drawing.GraphicsUnit.Point)
        TextBoxIs.Location = New Drawing.Point(0, 32)
        TextBoxIs.Margin = New Padding(0)
        TextBoxIs.MaxLength = Integer.MaxValue
        TextBoxIs.Multiline = True
        TextBoxIs.Name = "TextBoxIs"
        TextBoxIs.ScrollBars = ScrollBars.Both
        TextBoxIs.Size = New Drawing.Size(784, 529)
        TextBoxIs.TabIndex = 1
        TextBoxIs.WordWrap = False
        ' 
        ' HelpTextBox
        ' 
        HelpTextBox.BackColor = Drawing.SystemColors.Window
        HelpTextBox.BorderStyle = BorderStyle.FixedSingle
        HelpTextBox.Font = New Drawing.Font("Segoe UI", 12F, Drawing.FontStyle.Regular, Drawing.GraphicsUnit.Point)
        HelpTextBox.Location = New Drawing.Point(0, 263)
        HelpTextBox.Margin = New Padding(0)
        HelpTextBox.Multiline = True
        HelpTextBox.Name = "HelpTextBox"
        HelpTextBox.ReadOnly = True
        HelpTextBox.ScrollBars = ScrollBars.Both
        HelpTextBox.Size = New Drawing.Size(784, 298)
        HelpTextBox.TabIndex = 10
        HelpTextBox.Text = resources.GetString("HelpTextBox.Text")
        HelpTextBox.Visible = False
        ' 
        ' Form1
        ' 
        AutoScaleMode = AutoScaleMode.None
        BackColor = Drawing.SystemColors.Control
        BackgroundImageLayout = ImageLayout.None
        ClientSize = New Drawing.Size(784, 561)
        Controls.Add(HelpTextBox)
        Controls.Add(LabelFont)
        Controls.Add(TextBoxIs)
        Controls.Add(MenuStrip)
        Icon = CType(resources.GetObject("$this.Icon"), Drawing.Icon)
        MainMenuStrip = MenuStrip
        Margin = New Padding(1, 2, 1, 2)
        Name = "Form1"
        Text = "Calc > Untitled"
        MenuStrip.ResumeLayout(False)
        MenuStrip.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
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
    Friend WithEvents HelpTextBox As TextBox
End Class
