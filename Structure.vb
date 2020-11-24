Public Class Form1
Public Structure resultType Dim pupil_name As String Dim tutor_group As String Dim mark As Integer
End Structure
Private Sub btnStart_Click(...
        Dim results(4) As resultType
        Dim counter As Integer
For counter = 0 To 4
results(counter).pupil_name = InputBox("Please enter the name of pupil " &
 Note where you put the record definition – at the beginning of the form and not in the code for the button
 counter + 1)
pupil " & counter + 1)
results(counter).tutor_group = InputBox("Please enter the tutor group of
results(counter).mark = InputBox("Please enter the mark of pupil " & Next
For counter = 0 To 4 lstDisplay.Items.Add(results(counter).pupil_name & vbTab &
results(counter).tutor_group & vbTab & results(counter).mark)
Next End Sub
End Class
