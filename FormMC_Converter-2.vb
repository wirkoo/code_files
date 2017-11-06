Imports System.IO
Public Class Form2
    Private Sub back_Click(sender As Object, e As EventArgs) Handles back.Click
        'This is code for "Main Window" button.

        Form1.Show() 'I am displaying the form 1 with saving state for this form2'
        Me.Hide() 'For not loosing the contents of this form, therfore I hide it.

        'When we click again on button (text to morse), it shows this form withouth loosing
        'the data
    End Sub

    Private Sub ex_Click(sender As Object, e As EventArgs) Handles ex.Click
        'This event handles closing the form with loosing all contents.
        Me.Close()


    End Sub

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub convert_Click(sender As Object, e As EventArgs) Handles convert.Click

        Dim variable As String = input.Text 'memory location named variable hold the input data. (input is the name of textbox under the Input label)

        Dim length As Integer = Len(variable) 'length variable gets the lenth of above string that is stord in variable, by using Len() function

        Dim i As Integer 'this integer for "for loop"
        Dim y As Integer 'this also for "for loop"
        Dim out As String 'out variable hold the output that is concatenated via for loops

        'here i am generating four arrays of string
        'small alphabets, large alphabets, numbers, symbols and their morse codes
        'these are all stored in arrays

        Dim small_alphabets() As String = {" ", "a", "b", "c", "d", "e", "f", "g", "h", "i", "j", "k", "l", "m", "n", "o", "p", "q", "r", "s", "t", "u", "v", "w", "x", "y", "z"}
        Dim morse_small_alphabets() As String = {"/", ".-", "-...", "-.-.", "-..", ".", "..-.", "--.", "....", "..", ".---", "-.-", ".-..", "--", "-.", "---", ".--.", "--.-", ".-.", "...", "-", "..-", "...-", ".--", "-..-", "-.--", "--.."}
        Dim large_alphabets() As String = {"A", "B", "C", "D", "E", "F", "G", "H", "I", "J", "K", "L", "M", "N", "O", "P", "Q", "R", "S", "T", "U", "V", "W", "X", "Y", "Z"}
        Dim morse_large_alphabets() As String = {".-", "-...", "-.-.", "-..", ".", "..-.", "--.", "....", "..", ".---", "-.-", ".-..", "--", "-.", "---", ".--.", "--.-", ".-.", "...", "-", "..-", "...-", ".--", "-..-", "-.--", "--.."}
        Dim numbers() As String = {"0", "1", "2", "3", "4", "5", "6", "7", "8", "9"}
        Dim morse_numbers() As String = {"-----", ".----", "..---", "...--", "....-", ".....", "-....", "--...", "---..", "----."}
        Dim symbols() As String = {".", ",", ":", "?", "'", "@", "="}
        Dim morse_symbols() As String = {".-.-.-", "--..--", "---...", "..--..", ".----.", ".--.-.", "-...-"}

        'here is the main code of my program

        'i am looping the input taken from textbox to it's complete length
        'next for loop (line 52) checks that first character of input entered lies between small alphabets ? 
        'if it lies in it , then corresponding morse code is stored in out variable
        'this checks the same with large alphabets, numbers and symbols

        For i = 0 To length - 1
            For y = 0 To 26
                If variable(i) = small_alphabets(y) Then
                    out += morse_small_alphabets(y) + " "
                End If
            Next
            For y = 0 To 25
                If variable(i) = large_alphabets(y) Then
                    out += morse_large_alphabets(y) + " "
                End If
            Next
            For y = 0 To 9
                If variable(i) = numbers(y) Then
                    out += morse_numbers(y) + " "
                End If
            Next
            For y = 0 To 6
                If variable(i) = symbols(y) Then
                    out += morse_symbols(y) + " "
                End If
            Next
        Next

        'this event (after performing the above code) also shows the output stored in out variable

        output.Text = out 'output is the name of text box under the Output label i.e. TextBox2 and it's text becomes whatever is got in "out" variable via above loops
    End Sub

    Private Sub clear_Click(sender As Object, e As EventArgs) Handles clear.Click
        input.Clear() 'builtin function clear which clears the text of input textbox
        output.Clear() 'builtin function clear which clears the text of output textbox
    End Sub

    Private Sub save_Click(sender As Object, e As EventArgs) Handles save.Click
        sfd.ShowDialog() 'sfd is the name i choose for SimpleFileDialogue event in the toolbox
        'this button generate event of showing SimpleFileDialogue which is the built in functionality for saving things on computer

    End Sub

    Private Sub sfd_FileOk(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles sfd.FileOk
        'Here is the code of 'SimpleFileDialogue event
        'Streamwrite Class is from the SyStem.IO namespace imported at the first line of this code page
        Dim SW As StreamWriter 'SW instantiated from StreamWriter Class
        SW = New StreamWriter(sfd.FileName, False) 'SW uses the function of Streamwriter which hold the event of writing files
        SW.WriteLine("input = " & input.Text) 'writing inside files :) 
        SW.WriteLine("output = " & output.Text)
        SW.Close() 'closing the handling of file
    End Sub
End Class
