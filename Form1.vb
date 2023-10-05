Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        'Microsoft.VisualBasic.Left("Microsoft Visual", 5)-Wrong. Did not declare the data type and prompt the output into a msgbox

        Dim FirstName As String
        FirstName = Microsoft.VisualBasic.Left("Ntebaleng Letaoana", 9)
        MsgBox(FirstName)


    End Sub
End Class
