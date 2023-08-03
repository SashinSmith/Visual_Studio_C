Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnCalc.Click
        Dim cat(5), fee(5) As String
        Dim catInd(5), age(5), totalCost, totalDiscount As Integer

        age(0) = CInt(txtAge1.Text)
        age(1) = CInt(txtAge2.Text)
        age(2) = CInt(txtAge3.Text)
        age(3) = CInt(txtAge4.Text)
        age(4) = CInt(txtAge5.Text)
        age(5) = CInt(txtAge6.Text)

        cat(0) = cbCat1.SelectedItem
        cat(1) = cbCat2.SelectedItem
        cat(2) = cbCat3.SelectedItem
        cat(3) = cbCat4.SelectedItem
        cat(4) = cbCat5.SelectedItem
        cat(5) = cbCat6.SelectedItem

        catInd(0) = cbCat1.SelectedIndex
        catInd(1) = cbCat2.SelectedIndex
        catInd(2) = cbCat3.SelectedIndex
        catInd(3) = cbCat4.SelectedIndex
        catInd(4) = cbCat5.SelectedIndex
        catInd(5) = cbCat6.SelectedIndex

        fee(0) = txtFee1.Text
        fee(1) = txtFee2.Text
        fee(2) = txtFee3.Text
        fee(3) = txtFee4.Text
        fee(4) = txtFee5.Text
        fee(5) = txtFee6.Text

        If CheckData(age, cat, catInd, fee) = True Then
            totalCost = 0
            For i As Integer = 0 To 5
                totalCost = totalCost + CInt(fee(i))
            Next
            totalDiscount = 0
            For i As Integer = 0 To 5
                Select Case catInd(i)
                    Case 0
                        If catInd(i) <> -1 Then
                            totalDiscount = totalDiscount + 100
                        End If
                    Case 1
                        If catInd(i) <> -1 Then
                            totalDiscount = totalDiscount + 40
                        End If
                    Case 2
                        If catInd(i) <> -1 Then
                            totalDiscount = totalDiscount + 10
                        End If
                    Case 3
                        If catInd(i) <> -1 Then
                            totalDiscount = totalDiscount + 50
                        End If
                End Select
            Next
            MessageBox.Show("Total cost = R" + CStr(totalCost) + " Total discount = " + CStr(totalDiscount) + "%", "Price")
        Else
            MessageBox.Show("Please enter the correct information", "Warning")
        End If



    End Sub

    Function CheckData(age, cat, catInd, fee) As Boolean
        For i As Integer = 0 To 5
            Select Case age(i)
                Case 1 To 2
                    If catInd(i) <> -1 Then
                        If cat(i) <> "Toddler" And fee(i) <> 0 Then
                            Return False
                        End If
                    End If
                Case 3 To 5
                    If catInd(i) <> -1 Then
                        If cat(i) <> "Pre-school" And fee(i) <> 240 Then
                            Return False
                        End If
                    End If
                Case 6 To 17
                    If catInd(i) <> -1 Then
                        If cat(i) <> "Scholar" And fee(i) <> 360 Then
                            Return False
                        End If
                    End If
                Case 18 To 65
                    If catInd(i) <> -1 Then
                        If cat(i) <> "Adult" And fee(i) <> 400 Then
                            Return False
                        End If
                    End If
                Case 65 To 250
                    If catInd(i) <> -1 Then
                        If cat(i) <> "Pensioners" And fee(i) <> 200 Then
                            Return False
                        End If
                    End If
                Case Else
                    Return False
            End Select
        Next
        Return True
    End Function

End Class
