Imports System.IO

'In this form , i used toolstrip and richtextbox from toolbox.
'In toolstrip I used five toolstrip labels as Select All, Cut, Copy, Save, Exit.

Public Class main
    Private Sub ToolStrip1_ItemClicked(sender As Object, e As ToolStripItemClickedEventArgs) Handles ToolStrip1.ItemClicked

    End Sub

    Private Sub ToolStripLabel3_Click(sender As Object, e As EventArgs) Handles ToolStripLabel3.Click
        'Select all text code by builtin SelectAll() function
        RichTextBox.SelectAll()
    End Sub
    Private Sub ToolStripLabel2_Click(sender As Object, e As EventArgs) Handles ToolStripLabel2.Click
        'this label handles the event with following code which is to copy all text
        RichTextBox.SelectAll() 'it first selected all text in richtextbox
        My.Computer.Clipboard.SetText(RichTextBox.Text) 'then it copies to clipboard

    End Sub

    Private Sub ToolStripLabel1_Click(sender As Object, e As EventArgs) Handles ToolStripLabel1.Click
        'this handles the event of cut the code.
        My.Computer.Clipboard.SetText(RichTextBox.Text) 'copies text to clipboard
        RichTextBox.Clear() ' and then clears all text as per logic of 'Cut' text.

    End Sub

    Private Sub ToolStripLabel4_Click(sender As Object, e As EventArgs) Handles ToolStripLabel4.Click
        sfd.ShowDialog()
        'sfd name i gave to SimpleFileDialogue which pops up the window of saving files.
    End Sub


    Private Sub ToolStripLabel5_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub ToolStripLabel6_Click(sender As Object, e As EventArgs) Handles ToolStripLabel6.Click
        'This is exit label of toolstrip.
        If MessageBox.Show("Do you really Want to Save existing File ?", "Wait", MessageBoxButtons.YesNo) = Windows.Forms.DialogResult.Yes Then
            'On clicking exit label, it shows a message box with caption of "Wait"
            'First parameter of Messagebox.Show() is the actual message, 
            'third parameter returns two buttons of Yes No which hold corresponding built in functionality 
            'If statement actually checks the result of button event of messagebox'
            'On returning Yes, it runs the following line of code i.e. sfd.showdialog()
            sfd.ShowDialog()
        Else
            Me.Close() 'If user clicks on "NO" then it closes the software
        End If
    End Sub

    Private Sub sfd_FileOk(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles sfd.FileOk
        'i described this code in MC converter, that's the same
        Dim SW As StreamWriter
        SW = New StreamWriter(sfd.FileName, False)
        SW.WriteLine(RichTextBox.Text)
        SW.Close()
    End Sub

    Private Sub RichTextBox_TextChanged(sender As Object, e As EventArgs) Handles RichTextBox.TextChanged


    End Sub

    Private Sub main_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub CutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CutToolStripMenuItem.Click
        'First item of 'context menu strip' i.e. right click option inside text editor
        'holds the same code for 'Cut' the text
        My.Computer.Clipboard.SetText(RichTextBox.Text)
        RichTextBox.Clear()
    End Sub

    Private Sub CopyToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CopyToolStripMenuItem.Click
        'Second item of 'context menu strip' i.e. right click option inside text editor
        'holds the same code for 'copyin' the text to clipboard
        My.Computer.Clipboard.SetText(RichTextBox.Text)
    End Sub

    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        'Last item of 'context menu strip' i.e. right click option inside text editor
        'same functionality as of 'Exit' (in toolstirp)
        If MessageBox.Show("Do you really Want to Save existing File ?", "Wait", MessageBoxButtons.YesNo) = Windows.Forms.DialogResult.Yes Then
            sfd.ShowDialog()
        Else
            Me.Close()
        End If
    End Sub

    Private Sub PasteToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PasteToolStripMenuItem.Click
        'third item of 'context menu strip' i.e. right click option inside text editor
        'holds the same code for 'paste' the text that is already copied in clipboard
        RichTextBox.Text = My.Computer.Clipboard.GetText()

    End Sub

    Private Sub ContextMenuStrip1_Opening(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles ContextMenuStrip1.Opening
        'this loads context menu strip, i used from toolbox
        'this actually gives option of right click inside the text editor.
        '
    End Sub
End Class
