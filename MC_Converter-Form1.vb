Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'This loads the vb form and this is the code when we click on form
    End Sub

    Private Sub mc_to_text_Click(sender As Object, e As EventArgs) Handles mc_to_text.Click
        'form 3 is "morse to text" converter window
        Form3.Show()
    End Sub

    Private Sub text_to_mc_Click(sender As Object, e As EventArgs) Handles text_to_mc.Click
        'On form when we click on "text to morse code" button then it shows the 
        'next window where we convert text to morse code
        'Show is the builtin function 
        Form2.Show()
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub
End Class
