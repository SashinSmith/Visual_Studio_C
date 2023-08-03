Public Class Form1
    'Public 3d array that is used to store data from the text file
    Public arrSeats(,) = New String(14, 5) {}
    'shared variables between form1 and form2 to track index
    Public Property rowIndex As Integer
    Public Property columIndex As Integer

    Private Sub lsbRows_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lsbRows.SelectedIndexChanged
        'displays the selected row in the edit boxes
        Dim rowNum = lsbRows.SelectedIndex.ToString()
        txbRow.Text = rowNum
        'changes to correct value as array indexes from 0
        rowNum -= 1
        txbA.Text = arrSeats(rowNum, 0)
        txbB.Text = arrSeats(rowNum, 1)
        txbC.Text = arrSeats(rowNum, 2)
        txbD.Text = arrSeats(rowNum, 3)
        txbE.Text = arrSeats(rowNum, 4)
        txbF.Text = arrSeats(rowNum, 5)
        'sets shared variable
        rowIndex = rowNum
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'onloads opens text file to be read into the 3d array
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
        'procedure to populate text field with the array
        Seats()
    End Sub

    Sub Seats()
        lsbRows.Items.Clear()
        lsbRows.Items.Add("ABC  DEF")
        For i As Integer = 0 To 14
            'adds line to the edit field
            lsbRows.Items.Add(arrSeats(i, 0) + arrSeats(i, 1) + arrSeats(i, 2) + "  " + arrSeats(i, 3) + arrSeats(i, 4) + arrSeats(i, 5))
        Next
    End Sub

    Private Sub btnStats_Click(sender As Object, e As EventArgs) Handles btnStats.Click
        'sets counter variables for the statistics button
        Dim filSeats, avaWind, regM, lowM, vegM As Integer
        regM = 0
        vegM = 0
        filSeats = 0
        lowM = 0
        avaWind = 0
        'checks every element in the array
        For i As Integer = 0 To 14
            For k As Integer = 0 To 5
                If arrSeats(i, k) <> "." Then
                    'adds to filled seats if not a "."
                    filSeats += 1
                    'case statement to count meal types
                    Select Case arrSeats(i, k)
                        Case "R"
                            regM += 1
                        Case "V"
                            vegM += 1
                        Case "L"
                            lowM += 1
                    End Select

                Else
                    'checks if the free seat is a window seat
                    If k = 0 Or k = 5 Then
                        avaWind += 1
                    End If
                End If
            Next
        Next
        'adds the data to the edit
        lstStats.Items.Add("Seats filled:   " + filSeats.ToString)
        lstStats.Items.Add("Windows avail:  " + avaWind.ToString)
        lstStats.Items.Add("Regular meals:  " + regM.ToString)
        lstStats.Items.Add("LowCal meals:   " + lowM.ToString)
        lstStats.Items.Add("Veggie meals:   " + vegM.ToString)
    End Sub
    'hides form1 and shows form2 as well as sets the correct colum index based on choice
    Private Sub txbA_Click(sender As Object, e As EventArgs) Handles txbA.Click
        columIndex = 0
        Me.Hide()
        Form2.Show()
    End Sub

    Private Sub txbB_Click(sender As Object, e As EventArgs) Handles txbB.Click
        columIndex = 1
        Me.Hide()
        Form2.Show()
    End Sub

    Private Sub txbC_Click(sender As Object, e As EventArgs) Handles txbC.Click
        columIndex = 2
        Me.Hide()
        Form2.Show()
    End Sub

    Private Sub txbD_Click(sender As Object, e As EventArgs) Handles txbD.Click
        columIndex = 3
        Me.Hide()
        Form2.Show()
    End Sub

    Private Sub txbE_Click(sender As Object, e As EventArgs) Handles txbE.Click
        columIndex = 4
        Me.Hide()
        Form2.Show()
    End Sub

    Private Sub txbF_Click(sender As Object, e As EventArgs) Handles txbF.Click
        columIndex = 5
        Me.Hide()
        Form2.Show()
    End Sub


End Class
