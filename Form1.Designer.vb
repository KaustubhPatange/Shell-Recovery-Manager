<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    'Inherits System.Windows.Forms.Form
    Inherits MaterialSkin.Controls.MaterialForm

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
        Me.RichTextBox1 = New System.Windows.Forms.RichTextBox()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AddLinesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.OpenScriptToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DaemonToolsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AdbRootToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AdbStartserverToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AdbKillserverToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AdbDeviceToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SaveToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SaveToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.EditToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.UndoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RedoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AddCommandsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RebootToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RebootRecoveryToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ShellArgumentToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RecoveryArgumentToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.WipeDalvikCacheToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ShellArgumentToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.RecoveryArgumentToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.WipeDataToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ShellArgumentToolStripMenuItem2 = New System.Windows.Forms.ToolStripMenuItem()
        Me.RecoveryArgumentToolStripMenuItem2 = New System.Windows.Forms.ToolStripMenuItem()
        Me.WipeSystemToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ShellArgumentToolStripMenuItem3 = New System.Windows.Forms.ToolStripMenuItem()
        Me.WipeCacheToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ShellArgumentToolStripMenuItem4 = New System.Windows.Forms.ToolStripMenuItem()
        Me.RecoveryArgumentToolStripMenuItem3 = New System.Windows.Forms.ToolStripMenuItem()
        Me.MountRwToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DataToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SystemToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.FlashZipPackageToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AddRecoveryCacheLinesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem2 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem3 = New System.Windows.Forms.ToolStripMenuItem()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.RichTextBox2 = New System.Windows.Forms.RichTextBox()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.SuToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExampleScriptsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.FlashZipToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.FlashRomToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ViewToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.FontToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SearchTextToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HelpAboutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AboutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'RichTextBox1
        '
        Me.RichTextBox1.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RichTextBox1.Location = New System.Drawing.Point(12, 91)
        Me.RichTextBox1.Name = "RichTextBox1"
        Me.RichTextBox1.Size = New System.Drawing.Size(526, 341)
        Me.RichTextBox1.TabIndex = 0
        Me.RichTextBox1.Text = ""
        '
        'MenuStrip1
        '
        Me.MenuStrip1.BackColor = System.Drawing.Color.White
        Me.MenuStrip1.Dock = System.Windows.Forms.DockStyle.None
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem, Me.ViewToolStripMenuItem, Me.EditToolStripMenuItem, Me.HelpAboutToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 64)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(264, 24)
        Me.MenuStrip1.TabIndex = 1
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AddLinesToolStripMenuItem, Me.OpenScriptToolStripMenuItem, Me.DaemonToolsToolStripMenuItem, Me.SaveToolStripMenuItem, Me.SaveToolStripMenuItem1})
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(37, 20)
        Me.FileToolStripMenuItem.Text = "&File"
        '
        'AddLinesToolStripMenuItem
        '
        Me.AddLinesToolStripMenuItem.Name = "AddLinesToolStripMenuItem"
        Me.AddLinesToolStripMenuItem.Size = New System.Drawing.Size(151, 22)
        Me.AddLinesToolStripMenuItem.Text = "New Script"
        '
        'OpenScriptToolStripMenuItem
        '
        Me.OpenScriptToolStripMenuItem.Name = "OpenScriptToolStripMenuItem"
        Me.OpenScriptToolStripMenuItem.Size = New System.Drawing.Size(151, 22)
        Me.OpenScriptToolStripMenuItem.Text = "Open Script"
        '
        'DaemonToolsToolStripMenuItem
        '
        Me.DaemonToolsToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AdbRootToolStripMenuItem, Me.AdbStartserverToolStripMenuItem, Me.AdbKillserverToolStripMenuItem, Me.AdbDeviceToolStripMenuItem})
        Me.DaemonToolsToolStripMenuItem.Name = "DaemonToolsToolStripMenuItem"
        Me.DaemonToolsToolStripMenuItem.Size = New System.Drawing.Size(151, 22)
        Me.DaemonToolsToolStripMenuItem.Text = "Daemon Tools"
        '
        'AdbRootToolStripMenuItem
        '
        Me.AdbRootToolStripMenuItem.Name = "AdbRootToolStripMenuItem"
        Me.AdbRootToolStripMenuItem.Size = New System.Drawing.Size(156, 22)
        Me.AdbRootToolStripMenuItem.Text = "adb root"
        '
        'AdbStartserverToolStripMenuItem
        '
        Me.AdbStartserverToolStripMenuItem.Name = "AdbStartserverToolStripMenuItem"
        Me.AdbStartserverToolStripMenuItem.Size = New System.Drawing.Size(156, 22)
        Me.AdbStartserverToolStripMenuItem.Text = "adb start-server"
        '
        'AdbKillserverToolStripMenuItem
        '
        Me.AdbKillserverToolStripMenuItem.Name = "AdbKillserverToolStripMenuItem"
        Me.AdbKillserverToolStripMenuItem.Size = New System.Drawing.Size(156, 22)
        Me.AdbKillserverToolStripMenuItem.Text = "adb kill-server"
        '
        'AdbDeviceToolStripMenuItem
        '
        Me.AdbDeviceToolStripMenuItem.Name = "AdbDeviceToolStripMenuItem"
        Me.AdbDeviceToolStripMenuItem.Size = New System.Drawing.Size(156, 22)
        Me.AdbDeviceToolStripMenuItem.Text = "adb device"
        '
        'SaveToolStripMenuItem
        '
        Me.SaveToolStripMenuItem.Name = "SaveToolStripMenuItem"
        Me.SaveToolStripMenuItem.Size = New System.Drawing.Size(151, 22)
        Me.SaveToolStripMenuItem.Text = "Execute "
        '
        'SaveToolStripMenuItem1
        '
        Me.SaveToolStripMenuItem1.Name = "SaveToolStripMenuItem1"
        Me.SaveToolStripMenuItem1.Size = New System.Drawing.Size(151, 22)
        Me.SaveToolStripMenuItem1.Text = "Save"
        '
        'EditToolStripMenuItem
        '
        Me.EditToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.UndoToolStripMenuItem, Me.RedoToolStripMenuItem, Me.AddCommandsToolStripMenuItem, Me.AddRecoveryCacheLinesToolStripMenuItem, Me.ExampleScriptsToolStripMenuItem})
        Me.EditToolStripMenuItem.Name = "EditToolStripMenuItem"
        Me.EditToolStripMenuItem.Size = New System.Drawing.Size(39, 20)
        Me.EditToolStripMenuItem.Text = "&Edit"
        '
        'UndoToolStripMenuItem
        '
        Me.UndoToolStripMenuItem.Name = "UndoToolStripMenuItem"
        Me.UndoToolStripMenuItem.Size = New System.Drawing.Size(205, 22)
        Me.UndoToolStripMenuItem.Text = "Undo"
        '
        'RedoToolStripMenuItem
        '
        Me.RedoToolStripMenuItem.Name = "RedoToolStripMenuItem"
        Me.RedoToolStripMenuItem.Size = New System.Drawing.Size(205, 22)
        Me.RedoToolStripMenuItem.Text = "Redo"
        '
        'AddCommandsToolStripMenuItem
        '
        Me.AddCommandsToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SuToolStripMenuItem, Me.RebootToolStripMenuItem, Me.RebootRecoveryToolStripMenuItem, Me.WipeDalvikCacheToolStripMenuItem, Me.WipeDataToolStripMenuItem, Me.WipeSystemToolStripMenuItem, Me.WipeCacheToolStripMenuItem, Me.MountRwToolStripMenuItem, Me.FlashZipPackageToolStripMenuItem})
        Me.AddCommandsToolStripMenuItem.Name = "AddCommandsToolStripMenuItem"
        Me.AddCommandsToolStripMenuItem.Size = New System.Drawing.Size(205, 22)
        Me.AddCommandsToolStripMenuItem.Text = "Add Commands"
        '
        'RebootToolStripMenuItem
        '
        Me.RebootToolStripMenuItem.Name = "RebootToolStripMenuItem"
        Me.RebootToolStripMenuItem.Size = New System.Drawing.Size(170, 22)
        Me.RebootToolStripMenuItem.Text = "reboot"
        '
        'RebootRecoveryToolStripMenuItem
        '
        Me.RebootRecoveryToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ShellArgumentToolStripMenuItem, Me.RecoveryArgumentToolStripMenuItem})
        Me.RebootRecoveryToolStripMenuItem.Name = "RebootRecoveryToolStripMenuItem"
        Me.RebootRecoveryToolStripMenuItem.Size = New System.Drawing.Size(170, 22)
        Me.RebootRecoveryToolStripMenuItem.Text = "reboot recovery"
        '
        'ShellArgumentToolStripMenuItem
        '
        Me.ShellArgumentToolStripMenuItem.Name = "ShellArgumentToolStripMenuItem"
        Me.ShellArgumentToolStripMenuItem.Size = New System.Drawing.Size(177, 22)
        Me.ShellArgumentToolStripMenuItem.Text = "Shell argument"
        '
        'RecoveryArgumentToolStripMenuItem
        '
        Me.RecoveryArgumentToolStripMenuItem.Name = "RecoveryArgumentToolStripMenuItem"
        Me.RecoveryArgumentToolStripMenuItem.Size = New System.Drawing.Size(177, 22)
        Me.RecoveryArgumentToolStripMenuItem.Text = "Recovery argument"
        '
        'WipeDalvikCacheToolStripMenuItem
        '
        Me.WipeDalvikCacheToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ShellArgumentToolStripMenuItem1, Me.RecoveryArgumentToolStripMenuItem1})
        Me.WipeDalvikCacheToolStripMenuItem.Name = "WipeDalvikCacheToolStripMenuItem"
        Me.WipeDalvikCacheToolStripMenuItem.Size = New System.Drawing.Size(170, 22)
        Me.WipeDalvikCacheToolStripMenuItem.Text = "Wipe Dalvik cache"
        '
        'ShellArgumentToolStripMenuItem1
        '
        Me.ShellArgumentToolStripMenuItem1.Name = "ShellArgumentToolStripMenuItem1"
        Me.ShellArgumentToolStripMenuItem1.Size = New System.Drawing.Size(179, 22)
        Me.ShellArgumentToolStripMenuItem1.Text = "Shell Argument"
        '
        'RecoveryArgumentToolStripMenuItem1
        '
        Me.RecoveryArgumentToolStripMenuItem1.Name = "RecoveryArgumentToolStripMenuItem1"
        Me.RecoveryArgumentToolStripMenuItem1.Size = New System.Drawing.Size(179, 22)
        Me.RecoveryArgumentToolStripMenuItem1.Text = "Recovery Argument"
        '
        'WipeDataToolStripMenuItem
        '
        Me.WipeDataToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ShellArgumentToolStripMenuItem2, Me.RecoveryArgumentToolStripMenuItem2})
        Me.WipeDataToolStripMenuItem.Name = "WipeDataToolStripMenuItem"
        Me.WipeDataToolStripMenuItem.Size = New System.Drawing.Size(170, 22)
        Me.WipeDataToolStripMenuItem.Text = "Wipe Data"
        '
        'ShellArgumentToolStripMenuItem2
        '
        Me.ShellArgumentToolStripMenuItem2.Name = "ShellArgumentToolStripMenuItem2"
        Me.ShellArgumentToolStripMenuItem2.Size = New System.Drawing.Size(177, 22)
        Me.ShellArgumentToolStripMenuItem2.Text = "Shell argument"
        '
        'RecoveryArgumentToolStripMenuItem2
        '
        Me.RecoveryArgumentToolStripMenuItem2.Name = "RecoveryArgumentToolStripMenuItem2"
        Me.RecoveryArgumentToolStripMenuItem2.Size = New System.Drawing.Size(177, 22)
        Me.RecoveryArgumentToolStripMenuItem2.Text = "Recovery argument"
        '
        'WipeSystemToolStripMenuItem
        '
        Me.WipeSystemToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ShellArgumentToolStripMenuItem3})
        Me.WipeSystemToolStripMenuItem.Name = "WipeSystemToolStripMenuItem"
        Me.WipeSystemToolStripMenuItem.Size = New System.Drawing.Size(170, 22)
        Me.WipeSystemToolStripMenuItem.Text = "Wipe System"
        '
        'ShellArgumentToolStripMenuItem3
        '
        Me.ShellArgumentToolStripMenuItem3.Name = "ShellArgumentToolStripMenuItem3"
        Me.ShellArgumentToolStripMenuItem3.Size = New System.Drawing.Size(154, 22)
        Me.ShellArgumentToolStripMenuItem3.Text = "Shell argument"
        '
        'WipeCacheToolStripMenuItem
        '
        Me.WipeCacheToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ShellArgumentToolStripMenuItem4, Me.RecoveryArgumentToolStripMenuItem3})
        Me.WipeCacheToolStripMenuItem.Name = "WipeCacheToolStripMenuItem"
        Me.WipeCacheToolStripMenuItem.Size = New System.Drawing.Size(170, 22)
        Me.WipeCacheToolStripMenuItem.Text = "Wipe Cache"
        '
        'ShellArgumentToolStripMenuItem4
        '
        Me.ShellArgumentToolStripMenuItem4.Name = "ShellArgumentToolStripMenuItem4"
        Me.ShellArgumentToolStripMenuItem4.Size = New System.Drawing.Size(177, 22)
        Me.ShellArgumentToolStripMenuItem4.Text = "Shell argument"
        '
        'RecoveryArgumentToolStripMenuItem3
        '
        Me.RecoveryArgumentToolStripMenuItem3.Name = "RecoveryArgumentToolStripMenuItem3"
        Me.RecoveryArgumentToolStripMenuItem3.Size = New System.Drawing.Size(177, 22)
        Me.RecoveryArgumentToolStripMenuItem3.Text = "Recovery argument"
        '
        'MountRwToolStripMenuItem
        '
        Me.MountRwToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.DataToolStripMenuItem, Me.SystemToolStripMenuItem})
        Me.MountRwToolStripMenuItem.Name = "MountRwToolStripMenuItem"
        Me.MountRwToolStripMenuItem.Size = New System.Drawing.Size(170, 22)
        Me.MountRwToolStripMenuItem.Text = "Mount rw"
        '
        'DataToolStripMenuItem
        '
        Me.DataToolStripMenuItem.Name = "DataToolStripMenuItem"
        Me.DataToolStripMenuItem.Size = New System.Drawing.Size(116, 22)
        Me.DataToolStripMenuItem.Text = "/data"
        '
        'SystemToolStripMenuItem
        '
        Me.SystemToolStripMenuItem.Name = "SystemToolStripMenuItem"
        Me.SystemToolStripMenuItem.Size = New System.Drawing.Size(116, 22)
        Me.SystemToolStripMenuItem.Text = "/system"
        '
        'FlashZipPackageToolStripMenuItem
        '
        Me.FlashZipPackageToolStripMenuItem.Name = "FlashZipPackageToolStripMenuItem"
        Me.FlashZipPackageToolStripMenuItem.Size = New System.Drawing.Size(170, 22)
        Me.FlashZipPackageToolStripMenuItem.Text = "Flash Zip Package"
        '
        'AddRecoveryCacheLinesToolStripMenuItem
        '
        Me.AddRecoveryCacheLinesToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripMenuItem2, Me.ToolStripMenuItem3})
        Me.AddRecoveryCacheLinesToolStripMenuItem.Name = "AddRecoveryCacheLinesToolStripMenuItem"
        Me.AddRecoveryCacheLinesToolStripMenuItem.Size = New System.Drawing.Size(205, 22)
        Me.AddRecoveryCacheLinesToolStripMenuItem.Text = "Add recovery cache lines"
        '
        'ToolStripMenuItem2
        '
        Me.ToolStripMenuItem2.Name = "ToolStripMenuItem2"
        Me.ToolStripMenuItem2.Size = New System.Drawing.Size(187, 22)
        Me.ToolStripMenuItem2.Text = "First argument <"
        '
        'ToolStripMenuItem3
        '
        Me.ToolStripMenuItem3.Name = "ToolStripMenuItem3"
        Me.ToolStripMenuItem3.Size = New System.Drawing.Size(187, 22)
        Me.ToolStripMenuItem3.Text = "Second argument <<"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(13, 439)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(121, 18)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Debug Window"
        '
        'RichTextBox2
        '
        Me.RichTextBox2.BackColor = System.Drawing.SystemColors.MenuText
        Me.RichTextBox2.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RichTextBox2.ForeColor = System.Drawing.Color.Teal
        Me.RichTextBox2.Location = New System.Drawing.Point(12, 461)
        Me.RichTextBox2.Name = "RichTextBox2"
        Me.RichTextBox2.Size = New System.Drawing.Size(526, 96)
        Me.RichTextBox2.TabIndex = 3
        Me.RichTextBox2.Text = ""
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'SuToolStripMenuItem
        '
        Me.SuToolStripMenuItem.Name = "SuToolStripMenuItem"
        Me.SuToolStripMenuItem.Size = New System.Drawing.Size(170, 22)
        Me.SuToolStripMenuItem.Text = "su"
        '
        'ExampleScriptsToolStripMenuItem
        '
        Me.ExampleScriptsToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FlashZipToolStripMenuItem, Me.FlashRomToolStripMenuItem})
        Me.ExampleScriptsToolStripMenuItem.Name = "ExampleScriptsToolStripMenuItem"
        Me.ExampleScriptsToolStripMenuItem.Size = New System.Drawing.Size(205, 22)
        Me.ExampleScriptsToolStripMenuItem.Text = "Example Scripts"
        '
        'FlashZipToolStripMenuItem
        '
        Me.FlashZipToolStripMenuItem.Name = "FlashZipToolStripMenuItem"
        Me.FlashZipToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.FlashZipToolStripMenuItem.Text = "Flash Zip"
        '
        'FlashRomToolStripMenuItem
        '
        Me.FlashRomToolStripMenuItem.Name = "FlashRomToolStripMenuItem"
        Me.FlashRomToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.FlashRomToolStripMenuItem.Text = "Flash Rom"
        '
        'ViewToolStripMenuItem
        '
        Me.ViewToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FontToolStripMenuItem, Me.SearchTextToolStripMenuItem})
        Me.ViewToolStripMenuItem.Name = "ViewToolStripMenuItem"
        Me.ViewToolStripMenuItem.Size = New System.Drawing.Size(44, 20)
        Me.ViewToolStripMenuItem.Text = "&View"
        '
        'FontToolStripMenuItem
        '
        Me.FontToolStripMenuItem.Name = "FontToolStripMenuItem"
        Me.FontToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.FontToolStripMenuItem.Text = "Font"
        '
        'SearchTextToolStripMenuItem
        '
        Me.SearchTextToolStripMenuItem.Name = "SearchTextToolStripMenuItem"
        Me.SearchTextToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.SearchTextToolStripMenuItem.Text = "Search Text"
        '
        'HelpAboutToolStripMenuItem
        '
        Me.HelpAboutToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AboutToolStripMenuItem})
        Me.HelpAboutToolStripMenuItem.Name = "HelpAboutToolStripMenuItem"
        Me.HelpAboutToolStripMenuItem.Size = New System.Drawing.Size(44, 20)
        Me.HelpAboutToolStripMenuItem.Text = "&Help"
        '
        'AboutToolStripMenuItem
        '
        Me.AboutToolStripMenuItem.Name = "AboutToolStripMenuItem"
        Me.AboutToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.AboutToolStripMenuItem.Text = "About"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(550, 580)
        Me.Controls.Add(Me.RichTextBox2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.RichTextBox1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.MaximizeBox = False
        Me.Name = "Form1"
        Me.Sizable = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Shell Recovery Manager"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents RichTextBox1 As RichTextBox
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents FileToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AddLinesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents OpenScriptToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DaemonToolsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SaveToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Label1 As Label
    Friend WithEvents RichTextBox2 As RichTextBox
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents AdbRootToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AdbStartserverToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AdbKillserverToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AdbDeviceToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EditToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents UndoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents RedoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SaveToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents AddRecoveryCacheLinesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem2 As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem3 As ToolStripMenuItem
    Friend WithEvents AddCommandsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents FlashZipPackageToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SystemToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DataToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents MountRwToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents RecoveryArgumentToolStripMenuItem3 As ToolStripMenuItem
    Friend WithEvents ShellArgumentToolStripMenuItem4 As ToolStripMenuItem
    Friend WithEvents WipeCacheToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ShellArgumentToolStripMenuItem3 As ToolStripMenuItem
    Friend WithEvents WipeSystemToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents RecoveryArgumentToolStripMenuItem2 As ToolStripMenuItem
    Friend WithEvents ShellArgumentToolStripMenuItem2 As ToolStripMenuItem
    Friend WithEvents WipeDataToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents RecoveryArgumentToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents ShellArgumentToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents WipeDalvikCacheToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents RecoveryArgumentToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ShellArgumentToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents RebootRecoveryToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents RebootToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SuToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ExampleScriptsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents FlashZipToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents FlashRomToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ViewToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents FontToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SearchTextToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents HelpAboutToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AboutToolStripMenuItem As ToolStripMenuItem
End Class
