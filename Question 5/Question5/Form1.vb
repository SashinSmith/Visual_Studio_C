Public Class Form1
    Dim arrDistance(4, 4) As String
    Private Sub btnCreate_Click(sender As Object, e As EventArgs) Handles btnCreate.Click
        arrDistance(0, 1) = InputBox("Please enter first row index", "Index")
        arrDistance(0, 2) = InputBox("Please enter second row index", "Index")
        arrDistance(0, 3) = InputBox("Please enter third row index", "Index")
        arrDistance(0, 4) = InputBox("Please enter fourth row index", "Index")
        arrDistance(1, 0) = InputBox("Please enter first row index", "Index")
        arrDistance(2, 0) = InputBox("Please enter second row index", "Index")
        arrDistance(3, 0) = InputBox("Please enter third row index", "Index")
        arrDistance(4, 0) = InputBox("Please enter fourth row index", "Index")
        For row As Integer = 1 To 4
            For column As Integer = 1 To 4
                arrDistance(row, column) = InputBox("Please enter value at row: " + CStr(row) + "  column: " + CStr(column), "Index")
            Next
        Next

    End Sub

    Private Sub btnMore_Click(sender As Object, e As EventArgs) Handles btnMore.Click
        For row As Integer = 1 To 4
            For column As Integer = 1 To 4
                If CInt(arrDistance(row, column)) > 1000 Then
                    lbDistances.Text = "The Row Index is " + arrDistance(row, 0) + ". The column index is " + arrDistance(column, 0) + ". The distance is " + arrDistance(row, column)
                End If
            Next
        Next
    End Sub

    Private Sub btnDistance_Click(sender As Object, e As EventArgs) Handles btnDistance.Click
        Dim value As Integer
        value = CInt(txtValue.Text)
        For row As Integer = 1 To 4
            For column As Integer = 1 To 4
                If value = arrDistance(row, column) Then
                    lbDistances.Text = "The Row Index is " + arrDistance(row, 0) + ". The column index is " + arrDistance(column, 0)
                End If
            Next
        Next
    End Sub
End Class
