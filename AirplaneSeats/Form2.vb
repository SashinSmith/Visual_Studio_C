Imports System.IO

Public Class Form2
    'public variables
    Public arrSeats(,) = New String(14, 5) {}
    Dim col As Integer
    Dim row As Integer
    'adds textfile into array
    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim splitLine As String()
        Dim myline As String
        Dim count As Integer = 0
        Dim rows() As String = IO.File.ReadAllLines("C:\Users\Sashin\Documents\Unisa 2022\Assignments\ICT3611_A4\ICT3611_A5_Project\AirplaneSeats\seats.txt")
        Do Until count = 15
            myline = rows(count)
            splitLine = Split(myline, ",")
            For i As Integer = 0 To 5
                arrSeats(count, i) = splitLine(i)
            Next
            count += 1
        Loop
        'sets varaibles as the public varaible in form1
        col = Form1.columIndex
        row = Form1.rowIndex
    End Sub
    'updates the textfile to the changed information
    Sub UpdateTxt()
        'clears textfile
        Dim lineTemp As String
        lineTemp = ""
        System.IO.File.WriteAllText("C:\Users\Sashin\Documents\Unisa 2022\Assignments\ICT3611_A4\ICT3611_A5_Project\AirplaneSeats\seats.txt", "")
        Dim myFile As IO.StreamWriter
        'allows file to be appended
        myFile = New IO.StreamWriter("C:\Users\Sashin\Documents\Unisa 2022\Assignments\ICT3611_A4\ICT3611_A5_Project\AirplaneSeats\seats.txt", True)
        'writes from array to textfile
        For i As Integer = 0 To 14
            For k As Integer = 0 To 5
                lineTemp += arrSeats(i, k) + ","
            Next
            myFile.WriteLine(lineTemp)
            lineTemp = ""
        Next
        myFile.Close()
        Me.Hide()
        'restarts application to update information in edit field on form1
        Application.Restart()
    End Sub
    'onchecked it will change to the appropriate data and then run the updateTxt procedure
    Private Sub rbFree_CheckedChanged(sender As Object, e As EventArgs) Handles rbFree.CheckedChanged
        arrSeats(row, col) = "."
        UpdateTxt()
    End Sub

    Private Sub rbReg_CheckedChanged(sender As Object, e As EventArgs) Handles rbReg.CheckedChanged
        arrSeats(row, col) = "R"
        UpdateTxt()
    End Sub

    Private Sub rbLow_CheckedChanged(sender As Object, e As EventArgs) Handles rbLow.CheckedChanged
        arrSeats(row, col) = "L"
        UpdateTxt()
    End Sub

    Private Sub rbVeg_CheckedChanged(sender As Object, e As EventArgs) Handles rbVeg.CheckedChanged
        arrSeats(row, col) = "V"
        UpdateTxt()
    End Sub
End Class