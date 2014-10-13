Option Strict On

Public Class Form1

    Private Sub btnSubmit_Click(sender As Object, e As EventArgs) Handles btnSubmit.Click
        txtOutput.Clear()
        Dim st As String = txtInput.Text.Trim
        Dim result As String = ""
        For i = st.Length - 1 To 0 Step -1 'The step -1 is critical as the string wouldn't execute otherwise
            result = result & st.Chars(i)
        Next
        ' Please write your code here!
        txtOutput.Text = result

    End Sub
End Class
