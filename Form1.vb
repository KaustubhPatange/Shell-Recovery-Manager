Imports System.Diagnostics
Imports System
Imports System.IO
Imports System.Management
Imports System.Text.RegularExpressions
Imports System.Collections.Generic
Public Class Form1
    Private psi As ProcessStartInfo
    Private cmd As Process
    Private Delegate Sub InvokeWithString(ByVal text As String)

    Private Sub CMD_Exited(ByVal sender As Object, ByVal e As EventArgs)
        'Me.Close()
        RichTextBox2.AppendText(Text & "All done!!!")
        RichTextBox2.ScrollToCaret()
    End Sub
    ' This sub gets called in a different thread so invokation is required
    Private Sub Async_Data_Received(ByVal sender As Object, ByVal e As DataReceivedEventArgs)
        Me.Invoke(New InvokeWithString(AddressOf Sync_Output), e.Data)
    End Sub
    Private Sub Sync_Output(ByVal text As String)
        RichTextBox2.AppendText(text & Environment.NewLine)
        RichTextBox2.ScrollToCaret()
    End Sub
    Private Sub NewScriptToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AddLinesToolStripMenuItem.Click
        If MsgBox("Are you Sure?", MsgBoxStyle.YesNo, "Warning") = vbYes Then
            RichTextBox1.Clear()
        End If
    End Sub

    Private Sub OpenScriptToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles OpenScriptToolStripMenuItem.Click
        OpenFileDialog1.Filter = ".srm files | *.srm | All Files | *.*"
        OpenFileDialog1.FileName = "Select a File"
        OpenFileDialog1.RestoreDirectory = True
        If OpenFileDialog1.ShowDialog() = DialogResult.OK Then
            RichTextBox1.Text = IO.File.ReadAllText(OpenFileDialog1.FileName)
        End If
    End Sub

    Private Sub AdbRootToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AdbRootToolStripMenuItem.Click
        Me.RichTextBox2.Text = " "
        Dim myprocess As Process = New Process


        myprocess.StartInfo.FileName = "adb"
        myprocess.StartInfo.Arguments = "root"
        myprocess.StartInfo.UseShellExecute = False
        myprocess.StartInfo.CreateNoWindow = True
        myprocess.StartInfo.RedirectStandardInput = True
        myprocess.StartInfo.RedirectStandardOutput = True
        myprocess.StartInfo.RedirectStandardError = True
        myprocess.Start()


        While (myprocess.HasExited = False)
            Dim sLine As String = myprocess.StandardOutput.ReadLine
            If (Not String.IsNullOrEmpty(sLine)) Then

            End If
            Me.RichTextBox2.Text &= sLine & vbCrLf

            Application.DoEvents()
        End While

    End Sub



    Private Sub AdbStartserverToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AdbStartserverToolStripMenuItem.Click
        Me.RichTextBox2.Text = " "
        Dim myprocess As Process = New Process


        myprocess.StartInfo.FileName = "adb"
        myprocess.StartInfo.Arguments = "start-server"
        myprocess.StartInfo.UseShellExecute = False
        myprocess.StartInfo.CreateNoWindow = True
        myprocess.StartInfo.RedirectStandardInput = True
        myprocess.StartInfo.RedirectStandardOutput = True
        myprocess.StartInfo.RedirectStandardError = True
        myprocess.Start()


        While (myprocess.HasExited = False)
            Dim sLine As String = myprocess.StandardOutput.ReadLine
            If (Not String.IsNullOrEmpty(sLine)) Then

            End If
            Me.RichTextBox2.Text &= sLine & vbCrLf

            Application.DoEvents()
        End While
        Me.RichTextBox2.Text &= "Server Started"
    End Sub

    Private Sub AdbKillserverToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AdbKillserverToolStripMenuItem.Click
        Me.RichTextBox2.Text = " "
        Dim myprocess As Process = New Process


        myprocess.StartInfo.FileName = "adb"
        myprocess.StartInfo.Arguments = "kill-server"
        myprocess.StartInfo.UseShellExecute = False
        myprocess.StartInfo.CreateNoWindow = True
        myprocess.StartInfo.RedirectStandardInput = True
        myprocess.StartInfo.RedirectStandardOutput = True
        myprocess.StartInfo.RedirectStandardError = True
        myprocess.Start()


        While (myprocess.HasExited = False)
            Dim sLine As String = myprocess.StandardOutput.ReadLine
            If (Not String.IsNullOrEmpty(sLine)) Then

            End If
            Me.RichTextBox2.Text &= sLine & vbCrLf

            Application.DoEvents()
        End While
        Me.RichTextBox2.Text &= "Server Killed"
    End Sub

    Private Sub AdbDeviceToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AdbDeviceToolStripMenuItem.Click
        psi = New ProcessStartInfo("adb", "devices")

        Dim systemencoding As System.Text.Encoding =
            System.Text.Encoding.GetEncoding(Globalization.CultureInfo.CurrentUICulture.TextInfo.OEMCodePage)
        With psi
            .UseShellExecute = False  ' Required for redirection
            .RedirectStandardError = True
            .RedirectStandardOutput = True
            .RedirectStandardInput = True
            .CreateNoWindow = True
            .StandardOutputEncoding = systemencoding  ' Use OEM encoding for console applications
            .StandardErrorEncoding = systemencoding
        End With
        ' EnableraisingEvents is required for Exited event
        cmd = New Process With {.StartInfo = psi, .EnableRaisingEvents = False}
        AddHandler cmd.ErrorDataReceived, AddressOf Async_Data_Received
        AddHandler cmd.OutputDataReceived, AddressOf Async_Data_Received
        AddHandler cmd.Exited, AddressOf CMD_Exited

        cmd.Start()

        ' Start async reading of the redirected streams
        ' Without these calls the events won't fire
        cmd.BeginOutputReadLine()
        cmd.BeginErrorReadLine()
    End Sub

    Private Sub UndoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles UndoToolStripMenuItem.Click
        RichTextBox1.Undo()
    End Sub

    Private Sub RedoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RedoToolStripMenuItem.Click
        RichTextBox1.Redo()
    End Sub

    Private Sub SuToolStripMenuItem_Click(sender As Object, e As EventArgs)
        Dim insertText = "su"
        Dim insertPos As Integer = RichTextBox1.SelectionStart
        RichTextBox1.Text = RichTextBox1.Text.Insert(insertPos, insertText)
        RichTextBox1.SelectionStart = insertPos + insertText.Length
        SendKeys.Send("{Enter}")
    End Sub

    Private Sub RebootToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RebootToolStripMenuItem.Click
        Dim insertText = "reboot"
        Dim insertPos As Integer = RichTextBox1.SelectionStart
        RichTextBox1.Text = RichTextBox1.Text.Insert(insertPos, insertText)
        RichTextBox1.SelectionStart = insertPos + insertText.Length
        SendKeys.Send("{Enter}")
    End Sub


    Private Sub SaveToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles SaveToolStripMenuItem1.Click
        Dim saveFileDialog1 As New SaveFileDialog()
        saveFileDialog1.FileName = ""
        saveFileDialog1.Filter = ".srm Files|*.srm"
        saveFileDialog1.RestoreDirectory = True

        If saveFileDialog1.ShowDialog() = DialogResult.OK Then
            IO.File.WriteAllText(saveFileDialog1.FileName, RichTextBox1.Text)
            MsgBox("File Saved", MsgBoxStyle.OkOnly)
        End If
    End Sub

    Private Sub SaveToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SaveToolStripMenuItem.Click
        RichTextBox2.Text = "Preparing Script" & Environment.NewLine
        IO.File.WriteAllText("flash.srm", RichTextBox1.Text)
        Threading.Thread.Sleep(500)
        RichTextBox2.Text += "Executing Shells" & Environment.NewLine
        Threading.Thread.Sleep(1000)
        Shell("cmd.exe /c adb shell < flash.srm")
        RichTextBox2.Text += "Done" & Environment.NewLine
    End Sub



    Private Sub ToolStripMenuItem2_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem2.Click
        Dim index = RichTextBox1.SelectionStart
        Dim currentLine = RichTextBox1.GetLineFromCharIndex(index)
        Dim currentColumn = index - RichTextBox1.GetFirstCharIndexFromLine(currentLine)
        Dim serial = RichTextBox1.Lines(currentLine).ToString()
        RichTextBox1.Text = RichTextBox1.Text.Replace(serial, "echo '" + serial + " ' > /cache/recovery/command ")
        ' Dim delLine As Integer = 4
        'Dim lines As List(Of String) = System.IO.File.ReadAllLines("infile.txt").ToList
        'lines.RemoveAt(delLine - 1) ' index starts at 0 
        'System.IO.File.WriteAllLines("outfile.txt", lines)
        'RichTextBox1.Text = RichTextBox1.Text.Replace(currentLine, " ")
    End Sub

    Private Sub ToolStripMenuItem3_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem3.Click
        Dim index = RichTextBox1.SelectionStart
        IO.File.WriteAllText("infile.txt", RichTextBox1.Text)
        Dim currentLine = RichTextBox1.GetLineFromCharIndex(index)
        Dim currentColumn = index - RichTextBox1.GetFirstCharIndexFromLine(currentLine)
        Dim serial = RichTextBox1.Lines(currentLine).ToString()
        Dim delLine As Integer = currentLine
        Dim lines As List(Of String) = System.IO.File.ReadAllLines("infile.txt").ToList
        lines.RemoveAt(delLine) ' index starts at 0 
        System.IO.File.WriteAllLines("outfile.txt", lines)
        RichTextBox1.Text = IO.File.ReadAllText("outfile.txt")

        My.Computer.FileSystem.DeleteFile("outfile.txt")
        My.Computer.FileSystem.DeleteFile("infile.txt")
        RichTextBox1.Text &= "echo '" + serial + " ' >> /cache/recovery/command "
        'RichTextBox1.Text = RichTextBox1.Text.Replace(serial, " ")
    End Sub

    Private Sub RecoveryArgumentToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RecoveryArgumentToolStripMenuItem.Click
        Dim insertText = "boot-recovery"
        Dim insertPos As Integer = RichTextBox1.SelectionStart
        RichTextBox1.Text = RichTextBox1.Text.Insert(insertPos, insertText)
        RichTextBox1.SelectionStart = insertPos + insertText.Length
        SendKeys.Send("{Enter}")
    End Sub

    Private Sub ShellArgumentToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ShellArgumentToolStripMenuItem.Click
        Dim insertText = "reboot recovery"
        Dim insertPos As Integer = RichTextBox1.SelectionStart
        RichTextBox1.Text = RichTextBox1.Text.Insert(insertPos, insertText)
        RichTextBox1.SelectionStart = insertPos + insertText.Length
        SendKeys.Send("{Enter}")
    End Sub

    Private Sub ShellArgumentToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles ShellArgumentToolStripMenuItem1.Click
        Dim insertText = "rm -r /data/dalvik-cache"
        Dim insertPos As Integer = RichTextBox1.SelectionStart
        RichTextBox1.Text = RichTextBox1.Text.Insert(insertPos, insertText)
        RichTextBox1.SelectionStart = insertPos + insertText.Length
        SendKeys.Send("{Enter}")
    End Sub

    Private Sub RecoveryArgumentToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles RecoveryArgumentToolStripMenuItem1.Click
        Dim insertText = "--wipe_cache"
        Dim insertPos As Integer = RichTextBox1.SelectionStart
        RichTextBox1.Text = RichTextBox1.Text.Insert(insertPos, insertText)
        RichTextBox1.SelectionStart = insertPos + insertText.Length
        SendKeys.Send("{Enter}")
    End Sub

    Private Sub RecoveryArgumentToolStripMenuItem2_Click(sender As Object, e As EventArgs) Handles RecoveryArgumentToolStripMenuItem2.Click
        Dim insertText = "--wipe_data"
        Dim insertPos As Integer = RichTextBox1.SelectionStart
        RichTextBox1.Text = RichTextBox1.Text.Insert(insertPos, insertText)
        RichTextBox1.SelectionStart = insertPos + insertText.Length
        SendKeys.Send("{Enter}")
    End Sub

    Private Sub ShellArgumentToolStripMenuItem2_Click(sender As Object, e As EventArgs) Handles ShellArgumentToolStripMenuItem2.Click
        If RichTextBox1.Text.Contains("mount -o remount rw /data") Then
            Dim insertText = "rm -rf /data/*"
            Dim insertPos As Integer = RichTextBox1.SelectionStart
            RichTextBox1.Text = RichTextBox1.Text.Insert(insertPos, insertText)
            RichTextBox1.SelectionStart = insertPos + insertText.Length
            SendKeys.Send("{Enter}")
        Else
            MsgBox("In order to wipe data, you must add an mount /data argument")
        End If
    End Sub

    Private Sub ShellArgumentToolStripMenuItem3_Click(sender As Object, e As EventArgs) Handles ShellArgumentToolStripMenuItem3.Click
        If RichTextBox1.Text.Contains("mount -o remount rw /system") Then
            Dim insertText = "rm -rf /system/*"
            Dim insertPos As Integer = RichTextBox1.SelectionStart
            RichTextBox1.Text = RichTextBox1.Text.Insert(insertPos, insertText)
            RichTextBox1.SelectionStart = insertPos + insertText.Length
            SendKeys.Send("{Enter}")
        Else
            MsgBox("In order to wipe system, you must add an mount /system argument")
        End If
    End Sub

    Private Sub ShellArgumentToolStripMenuItem4_Click(sender As Object, e As EventArgs) Handles ShellArgumentToolStripMenuItem4.Click
        Dim insertText = "rm -rf /cache/*"
        Dim insertPos As Integer = RichTextBox1.SelectionStart
        RichTextBox1.Text = RichTextBox1.Text.Insert(insertPos, insertText)
        RichTextBox1.SelectionStart = insertPos + insertText.Length
        SendKeys.Send("{Enter}")
    End Sub

    Private Sub RecoveryArgumentToolStripMenuItem3_Click(sender As Object, e As EventArgs) Handles RecoveryArgumentToolStripMenuItem3.Click
        Dim insertText = "--wipe_cache"
        Dim insertPos As Integer = RichTextBox1.SelectionStart
        RichTextBox1.Text = RichTextBox1.Text.Insert(insertPos, insertText)
        RichTextBox1.SelectionStart = insertPos + insertText.Length
        SendKeys.Send("{Enter}")
    End Sub

    Private Sub DataToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DataToolStripMenuItem.Click
        Dim insertText = "mount -o remount rw /data"
        Dim insertPos As Integer = RichTextBox1.SelectionStart
        RichTextBox1.Text = RichTextBox1.Text.Insert(insertPos, insertText)
        RichTextBox1.SelectionStart = insertPos + insertText.Length
        SendKeys.Send("{Enter}")
    End Sub

    Private Sub SystemToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SystemToolStripMenuItem.Click
        Dim insertText = "mount -o remount rw /system"
        Dim insertPos As Integer = RichTextBox1.SelectionStart
        RichTextBox1.Text = RichTextBox1.Text.Insert(insertPos, insertText)
        RichTextBox1.SelectionStart = insertPos + insertText.Length
        SendKeys.Send("{Enter}")
    End Sub

    Private Sub AdbBackupToolStripMenuItem_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub FlashZipPackageToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles FlashZipPackageToolStripMenuItem.Click
        OpenFileDialog1.Filter = ".zip files | *.zip | All Files | *.*"
        OpenFileDialog1.FileName = "Select a Zip File to Flash"
        OpenFileDialog1.RestoreDirectory = True
        If OpenFileDialog1.ShowDialog() = DialogResult.OK Then
            Me.RichTextBox2.Text = " "
            Dim myprocess As Process = New Process


            myprocess.StartInfo.FileName = "adb"
            myprocess.StartInfo.Arguments = "push " + OpenFileDialog1.FileName + " /sdcard/"
            myprocess.StartInfo.UseShellExecute = False
            myprocess.StartInfo.CreateNoWindow = True
            myprocess.StartInfo.RedirectStandardInput = True
            myprocess.StartInfo.RedirectStandardOutput = True
            myprocess.StartInfo.RedirectStandardError = True
            myprocess.Start()


            While (myprocess.HasExited = False)
                Dim sLine As String = myprocess.StandardOutput.ReadLine
                If (Not String.IsNullOrEmpty(sLine)) Then

                End If
                Me.RichTextBox2.Text &= sLine & vbCrLf

                Application.DoEvents()
            End While

            'RichTextBox1.Text = IO.File.ReadAllText(OpenFileDialog1.FileName)
        End If
        Dim insertText = "--update_package=/sdcard/" + OpenFileDialog1.SafeFileName
        Dim insertPos As Integer = RichTextBox1.SelectionStart
        RichTextBox1.Text = RichTextBox1.Text.Insert(insertPos, insertText)
        RichTextBox1.SelectionStart = insertPos + insertText.Length
        SendKeys.Send("{Enter}")
    End Sub

    Private Sub SuToolStripMenuItem_Click_1(sender As Object, e As EventArgs)
        Dim insertText = "su"
        Dim insertPos As Integer = RichTextBox1.SelectionStart
        RichTextBox1.Text = RichTextBox1.Text.Insert(insertPos, insertText)
        RichTextBox1.SelectionStart = insertPos + insertText.Length
        SendKeys.Send("{Enter}")
    End Sub

    Private Sub SuToolStripMenuItem_Click_2(sender As Object, e As EventArgs) Handles SuToolStripMenuItem.Click
        Dim insertText = "su"
        Dim insertPos As Integer = RichTextBox1.SelectionStart
        RichTextBox1.Text = RichTextBox1.Text.Insert(insertPos, insertText)
        RichTextBox1.SelectionStart = insertPos + insertText.Length
        SendKeys.Send("{Enter}")
    End Sub

    Private Sub FlashZipToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles FlashZipToolStripMenuItem.Click
        If MsgBox("This will clear all Current script?", vbYesNo) = vbYes Then
            RichTextBox1.Text = " "
            RichTextBox1.Text = "su"
            RichTextBox1.Text &= Environment.NewLine & "echo 'boot-recovery ' > /cache/recovery/command"
            OpenFileDialog1.Filter = ".zip files | *.zip | All Files | *.*"
            OpenFileDialog1.FileName = "Select a Zip File to Flash"
            OpenFileDialog1.RestoreDirectory = True
            If OpenFileDialog1.ShowDialog() = DialogResult.OK Then
                Me.RichTextBox2.Text = " "
                Dim myprocess As Process = New Process


                myprocess.StartInfo.FileName = "adb"
                myprocess.StartInfo.Arguments = "push " + OpenFileDialog1.FileName + " /sdcard/"
                myprocess.StartInfo.UseShellExecute = False
                myprocess.StartInfo.CreateNoWindow = True
                myprocess.StartInfo.RedirectStandardInput = True
                myprocess.StartInfo.RedirectStandardOutput = True
                myprocess.StartInfo.RedirectStandardError = True
                myprocess.Start()


                While (myprocess.HasExited = False)
                    Dim sLine As String = myprocess.StandardOutput.ReadLine
                    If (Not String.IsNullOrEmpty(sLine)) Then

                    End If
                    Me.RichTextBox2.Text &= sLine & vbCrLf

                    Application.DoEvents()
                End While
            End If
            RichTextBox1.Text &= Environment.NewLine & "echo '--update_package=/sdcard/" + OpenFileDialog1.SafeFileName + "' >> /cache/recovery/command"
            RichTextBox1.Text &= Environment.NewLine & "reboot recovery"
        End If
    End Sub

    Private Sub FlashRomToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles FlashRomToolStripMenuItem.Click
        If MsgBox("This is an Experimental, At your own risk", vbYesNo) = vbYes Then
            If MsgBox("This will clear all Current script?", vbYesNo) = vbYes Then
                RichTextBox1.Text = " "
                RichTextBox1.Text = "su"
                RichTextBox1.Text &= Environment.NewLine & "echo 'boot-recovery ' > /cache/recovery/command "
                RichTextBox1.Text &= Environment.NewLine & "echo '--wipe_cache ' >> /cache/recovery/command "
                OpenFileDialog1.Filter = ".zip files | *.zip | All Files | *.*"
                OpenFileDialog1.FileName = "Select a Rom File to Flash"
                OpenFileDialog1.RestoreDirectory = True
                If OpenFileDialog1.ShowDialog() = DialogResult.OK Then
                    Me.RichTextBox2.Text = " "
                    Me.RichTextBox2.Text = "Pushing Rom File may take time.."
                    Dim myprocess As Process = New Process


                    myprocess.StartInfo.FileName = "adb"
                    myprocess.StartInfo.Arguments = "push " + OpenFileDialog1.FileName + " /sdcard/"
                    myprocess.StartInfo.UseShellExecute = False
                    myprocess.StartInfo.CreateNoWindow = True
                    myprocess.StartInfo.RedirectStandardInput = True
                    myprocess.StartInfo.RedirectStandardOutput = True
                    myprocess.StartInfo.RedirectStandardError = True
                    myprocess.Start()
                    RichTextBox2.ScrollToCaret()
                    RichTextBox1.ReadOnly = True
                    MenuStrip1.Visible = False
                    RichTextBox1.Cursor = Cursors.WaitCursor

                    Me.Cursor = Cursors.WaitCursor
                    While (myprocess.HasExited = False)
                        Dim sLine As String = myprocess.StandardOutput.ReadLine
                        If (Not String.IsNullOrEmpty(sLine)) Then

                        End If


                        ' Me.RichTextBox2.Text &= sLine & vbCrLf
                        RichTextBox2.AppendText(sLine & vbCrLf)
                        Application.DoEvents()
                    End While
                    RichTextBox2.ScrollToCaret()
                End If
                RichTextBox1.ReadOnly = False
                MenuStrip1.Visible = True
                RichTextBox1.Cursor = Cursors.IBeam
                Me.Cursor = Cursors.Arrow
                RichTextBox1.Text &= Environment.NewLine & "echo '--update_package=/sdcard/" + OpenFileDialog1.SafeFileName + "' >> /cache/recovery/command"
                RichTextBox1.Text &= Environment.NewLine & "echo '--wipe_data ' >> /cache/recovery/command"
                RichTextBox1.Text &= Environment.NewLine & "echo '--wipe_cache ' >> /cache/recovery/command "
                RichTextBox1.Text &= Environment.NewLine & "mount -o remount rw /system" & Environment.NewLine & "rm -rf /system/*" & Environment.NewLine & "reboot recovery"
            End If
        End If
    End Sub

    Private Sub FontToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles FontToolStripMenuItem.Click
        Try
            Dim dlg As FontDialog = New FontDialog
            dlg.Font = RichTextBox1.Font
            If dlg.ShowDialog = System.Windows.Forms.DialogResult.OK Then
                RichTextBox1.Font = dlg.Font
            End If
        Catch ex As Exception : End Try
    End Sub

    Private Sub SearchTextToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SearchTextToolStripMenuItem.Click
        Dim a As String
        Dim b As String
        a = InputBox("Enter text to be found")
        b = InStr(RichTextBox1.Text, a)
        If b Then
            RichTextBox1.Focus()
            RichTextBox1.SelectionStart = b - 1
            RichTextBox1.SelectionLength = Len(a)
        Else
            MsgBox("Text not found.")
        End If
    End Sub

    Private Sub AboutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AboutToolStripMenuItem.Click
        AboutBox1.ShowDialog()
    End Sub
End Class
