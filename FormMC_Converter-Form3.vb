Imports System.IO
Public Class Form3
    'this form is pretty much uses the same functionality of form2 except code logic which converts
    'morse to text insted text to morse code. loops logic is reversed here. 
    Private Sub back_Click(sender As Object, e As EventArgs) Handles back.Click
        Form1.Show()
        Me.Hide()
    End Sub

    Private Sub ex_Click(sender As Object, e As EventArgs) Handles ex.Click
        Me.Close()
    End Sub

    Private Sub convert_Click(sender As Object, e As EventArgs) Handles convert.Click
        Dim variable As String = input.Text
        Dim var_array As String() = variable.Split(" ")
        Dim length As Integer = Len(variable)

        Dim i As Integer
        Dim y As Integer
        Dim out As String


        Dim small_alphabets() As String = {" ", "a", "b", "c", "d", "e", "f", "g", "h", "i", "j", "k", "l", "m", "n", "o", "p", "q", "r", "s", "t", "u", "v", "w", "x", "y", "z"}
        Dim morse_small_alphabets() As String = {" ", ".-", "-...", "-.-.", "-..", ".", "..-.", "--.", "....", "..", ".---", "-.-", ".-..", "--", "-.", "---", ".--.", "--.-", ".-.", "...", "-", "..-", "...-", ".--", "-..-", "-.--", "--.."}
        Dim large_alphabets() As String = {"A", "B", "C", "D", "E", "F", "G", "H", "I", "J", "K", "L", "M", "N", "O", "P", "Q", "R", "S", "T", "U", "V", "W", "X", "Y", "Z"}
        Dim morse_large_alphabets() As String = {".-", "-...", "-.-.", "-..", ".", "..-.", "--.", "....", "..", ".---", "-.-", ".-..", "--", "-.", "---", ".--.", "--.-", ".-.", "...", "-", "..-", "...-", ".--", "-..-", "-.--", "--.."}
        Dim numbers() As String = {"0", "1", "2", "3", "4", "5", "6", "7", "8", "9"}
        Dim morse_numbers() As String = {"-----", ".----", "..---", "...--", "....-", ".....", "-....", "--...", "---..", "----."}
        Dim symbols() As String = {".", ",", ":", "?", "'", "@", "="}
        Dim morse_symbols() As String = {".-.-.-", "--..--", "---...", "..--..", ".----.", ".--.-.", "-...-"}

        For i = 0 To var_array.Length - 1
            For y = 0 To 26
                If var_array(i) = morse_small_alphabets(y) Then
                    out += small_alphabets(y)
                End If
            Next
            For y = 0 To 9
                If var_array(i) = morse_numbers(y) Then
                    out += numbers(y)
                End If
            Next
            For y = 0 To 6
                If var_array(i) = morse_symbols(y) Then
                    out += symbols(y)
                End If
            Next
        Next


        output.Text = out
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        input.Clear()
        output.Clear()
    End Sub

    Private Sub sfd_FileOk(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles sfd.FileOk
        Dim SW As StreamWriter
        SW = New StreamWriter(sfd.FileName, False)
        SW.WriteLine("input = " & input.Text)
        SW.WriteLine("output = " & output.Text)
        SW.Close()
    End Sub

    Private Sub save_Click(sender As Object, e As EventArgs) Handles save.Click
        sfd.ShowDialog()
    End Sub
End Class