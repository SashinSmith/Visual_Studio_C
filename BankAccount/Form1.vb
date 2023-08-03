Imports System.Security.Cryptography

Public Class Form1
    'arrays to be edited
    Dim arrCheck(,) = New String(3, 0) {}
    Dim arrSave(,) = New String(3, 0) {}
    'date string to hold date and put into textfile
    Dim myDateStr As String
    Dim lenSave As Integer
    Dim lenCheck As Integer
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'loads the data into grid
        loadData()
        'sets date
        Dim todayDate As Date
        todayDate = Today
        myDateStr = todayDate.ToString("dd-MM-yyyy")
        txtDate.Text = myDateStr
        'hides check panel
        pnlCheck.Hide()
    End Sub

    Sub loadData()
        'gets the text file and adds it to the array
        Dim splitLine As String()
        Dim myline As String
        Dim rows() As String = IO.File.ReadAllLines("C:\Users\Sashin\Documents\Unisa 2022\Assignments\ICT3611_A4\ICT3611_A5_Project\BankAccount\checking.txt")
        Dim count As Integer = 0
        ReDim arrCheck(3, rows.Length)
        Do Until count = rows.Length
            myline = rows(count)
            splitLine = Split(myline, ",")
            For i As Integer = 0 To 3
                arrCheck(i, count) = splitLine(i)
            Next
            count += 1
        Loop
        Dim splitLine1 As String()
        Dim rows1 As String() = IO.File.ReadAllLines("C:\Users\Sashin\Documents\Unisa 2022\Assignments\ICT3611_A4\ICT3611_A5_Project\BankAccount\savings.txt")
        count = 0
        ReDim arrSave(3, rows1.Length)
        Do Until count = rows1.Length
            myline = rows1(count)
            splitLine1 = Split(myline, ",")
            For i As Integer = 0 To 3
                arrSave(i, count) = splitLine1(i)
            Next
            count += 1
        Loop
    End Sub

    Private Sub chbAcc_SelectedIndexChanged(sender As Object, e As EventArgs) Handles chbAcc.SelectedIndexChanged
        'hides the check panel when savings is selected and shows check panel when check is selected
        If chbAcc.SelectedIndex = 0 Then
            pnlCheck.Hide()
        Else
            pnlCheck.Show()
        End If
        tableMaker()
    End Sub

    Private Sub btnDeposit_Click(sender As Object, e As EventArgs) Handles btnDeposit.Click
        Dim myBalance As Integer
        'deposits the account that is selected
        If chbAcc.SelectedIndex = 0 Then
            myBalance = Val(arrSave(3, lenSave - 1)) + Val(txtDeposit.Text)
            lenSave += 1
            'increases size of the array while keeping the data
            ReDim Preserve arrSave(3, lenSave)
            'adds new data
            arrSave(0, lenSave - 1) = myDateStr
            arrSave(1, lenSave - 1) = "Deposit"
            arrSave(2, lenSave - 1) = txtDeposit.Text
            arrSave(3, lenSave - 1) = myBalance.ToString
            MsgBox("Balance for Savings has been Updated With Deposit")
        ElseIf chbAcc.SelectedIndex = 1 Then
            myBalance = Val(arrCheck(3, lenCheck - 1)) + Val(txtDeposit.Text)
            lenCheck += 1
            'increases size of the array while keeping the data
            ReDim Preserve arrCheck(3, lenCheck)
            'adds new data
            arrCheck(0, lenCheck - 1) = myDateStr
            arrCheck(1, lenCheck - 1) = "Deposit"
            arrCheck(2, lenCheck - 1) = txtDeposit.Text
            arrCheck(3, lenCheck - 1) = myBalance.ToString
            MsgBox("Balance for Checking has been Updated With Deposit")
        End If
        writeTxt()
    End Sub
    'writes data into text files
    Sub writeTxt()
        'clears textfile
        Dim lineTemp As String
        lineTemp = ""
        System.IO.File.WriteAllText("C:\Users\Sashin\Documents\Unisa 2022\Assignments\ICT3611_A4\ICT3611_A5_Project\BankAccount\savings.txt", "")
        Dim myFile As IO.StreamWriter
        'allows file to be appended
        myFile = New IO.StreamWriter("C:\Users\Sashin\Documents\Unisa 2022\Assignments\ICT3611_A4\ICT3611_A5_Project\BankAccount\savings.txt", True)
        'writes from array to textfile
        For i As Integer = 0 To lenSave - 1
            For k As Integer = 0 To 3
                lineTemp += arrSave(k, i)
                lineTemp += ","
            Next
            myFile.WriteLine(lineTemp)
            lineTemp = ""
        Next
        myFile.Close()
        'clears textfile
        lineTemp = ""
        System.IO.File.WriteAllText("C:\Users\Sashin\Documents\Unisa 2022\Assignments\ICT3611_A4\ICT3611_A5_Project\BankAccount\checking.txt", "")
        'allows file to be appended
        myFile = New IO.StreamWriter("C:\Users\Sashin\Documents\Unisa 2022\Assignments\ICT3611_A4\ICT3611_A5_Project\BankAccount\checking.txt", True)
        'writes from array to textfile
        For i As Integer = 0 To lenCheck - 1
            For k As Integer = 0 To 3
                lineTemp += arrCheck(k, i)
                lineTemp += ","
            Next
            myFile.WriteLine(lineTemp)
            lineTemp = ""
        Next
        myFile.Close()

        tableMaker()
    End Sub
    'creates the table/grid for details viewing
    Sub tableMaker()
        Dim row As String() = New String() {}
        dgvTrans.Rows.Clear()
        'sets column amount
        dgvTrans.ColumnCount = 4
        'sets column headings
        dgvTrans.Columns(0).Name = "Date"
        dgvTrans.Columns(1).Name = "Type of Transaction"
        dgvTrans.Columns(2).Name = "Account"
        dgvTrans.Columns(3).Name = "New Balance"
        lenSave = arrSave.GetLength(1) - 1
        lenCheck = arrCheck.GetLength(1) - 1
        'writes to selected account for grid
        If chbAcc.SelectedIndex = 0 Then
            For i As Integer = 0 To lenSave - 1
                'adds line to the grid
                row = New String() {arrSave(0, i), arrSave(1, i), arrSave(2, i), arrSave(3, i)}
                dgvTrans.Rows.Add(row)
            Next
            txtBalance.Text = arrSave(3, lenSave - 1)
        ElseIf chbAcc.SelectedIndex = 1 Then
            For i As Integer = 0 To lenCheck - 1
                'adds line to the grid
                row = New String() {arrCheck(0, i), arrCheck(1, i), arrCheck(2, i), arrCheck(3, i)}
                dgvTrans.Rows.Add(row)
            Next
            txtBalance.Text = arrCheck(3, lenCheck - 1)
        End If
    End Sub
    'withdrawal code
    Private Sub btnDraw_Click(sender As Object, e As EventArgs) Handles btnDraw.Click
        Dim myBalance As Integer
        'gets correct account
        If chbAcc.SelectedIndex = 0 Then
            myBalance = Val(arrSave(3, lenSave - 1))
            'checks if balance is big enough
            If myBalance > Val(txtDraw.Text) Then
                myBalance -= Val(txtDraw.Text)
                lenSave += 1
                ReDim Preserve arrSave(3, lenSave)
                arrSave(0, lenSave - 1) = myDateStr
                arrSave(1, lenSave - 1) = "Withdrawal"
                arrSave(2, lenSave - 1) = "-" + txtDraw.Text
                arrSave(3, lenSave - 1) = myBalance.ToString
                MsgBox("Withdrawal Successful")
            Else
                MsgBox("Insufficient Funds")
            End If

        ElseIf chbAcc.SelectedIndex = 1 Then
            myBalance = Val(arrCheck(3, lenCheck - 1))
            If myBalance > Val(txtDraw.Text) Then
                myBalance -= Val(txtDraw.Text)
                lenCheck += 1
                ReDim Preserve arrSave(3, lenSave)
                arrCheck(0, lenCheck - 1) = myDateStr
                arrCheck(1, lenCheck - 1) = "Withdrawal"
                arrCheck(2, lenCheck - 1) = "-" + txtDraw.Text
                arrCheck(3, lenCheck - 1) = myBalance.ToString
                MsgBox("Withdrawal Successful")
            Else
                MsgBox("Insufficient Funds")
            End If
        End If
        writeTxt()
    End Sub

    Private Sub cmbTransAcc_SelectedIndexChanged(sender As Object, e As EventArgs)
        'changes label based on section
        If cmbTransAcc.SelectedIndex = 0 Then
            lblAcc.Text = "to Checking"
        Else
            lblAcc.Text = "to Savings"
        End If
    End Sub

    Private Sub btnTrans_Click(sender As Object, e As EventArgs) Handles btnTrans.Click
        Dim myBalance As Integer
        'checks which account is being used
        If cmbTransAcc.SelectedIndex = 0 Then

            myBalance = Val(arrSave(3, lenSave - 1))
            If myBalance > Val(txtTrans.Text) Then
                myBalance = Val(arrSave(3, lenSave - 1)) - Val(txtTrans.Text)
                lenSave += 1
                'updates the amount to be subtracted
                ReDim Preserve arrSave(3, lenSave)
                arrSave(0, lenSave - 1) = myDateStr
                arrSave(1, lenSave - 1) = "Transfer"
                arrSave(2, lenSave - 1) = "-" + txtTrans.Text
                arrSave(3, lenSave - 1) = myBalance.ToString
                'updates amount to be added
                myBalance = Val(arrCheck(3, lenCheck - 1)) + Val(txtTrans.Text)
                lenCheck += 1
                ReDim Preserve arrCheck(3, lenCheck)
                arrCheck(0, lenCheck - 1) = myDateStr
                arrCheck(1, lenCheck - 1) = "Transfer"
                arrCheck(2, lenCheck - 1) = txtTrans.Text
                arrCheck(3, lenCheck - 1) = myBalance.ToString
                MsgBox("Balances Updated")
            End If

        ElseIf cmbTransAcc.SelectedIndex = 1 Then

            myBalance = Val(arrCheck(3, lenCheck - 1))
            If myBalance > Val(txtTrans.Text) Then
                'updates the amount to be subtracted
                myBalance = Val(arrCheck(3, lenCheck - 1)) - Val(txtTrans.Text)
                lenCheck += 1
                ReDim Preserve arrCheck(3, lenCheck)
                arrCheck(0, lenCheck - 1) = myDateStr
                arrCheck(1, lenCheck - 1) = "Transfer"
                arrCheck(2, lenCheck - 1) = "-" + txtTrans.Text
                arrCheck(3, lenCheck - 1) = myBalance.ToString
                'updates amount to be added
                myBalance = Val(arrSave(3, lenSave - 1)) + Val(txtTrans.Text)
                lenSave += 1
                ReDim Preserve arrSave(3, lenSave)
                arrSave(0, lenSave - 1) = myDateStr
                arrSave(1, lenSave - 1) = "Transfer"
                arrSave(2, lenSave - 1) = txtTrans.Text
                arrSave(3, lenSave - 1) = myBalance.ToString
                MsgBox("Balances Updated")
            End If
        End If
        writeTxt()
    End Sub

    Private Sub btnCheck_Click(sender As Object, e As EventArgs) Handles btnCheck.Click
        'checks if amount is enough for order
        Dim myBalance As Integer
        myBalance = Val(arrCheck(3, lenCheck - 1))
        MsgBox(myBalance)
        If myBalance > Val(txtPayAmount.Text) Then
            myBalance -= Val(txtPayAmount.Text)
            lenCheck += 1
            ReDim Preserve arrSave(3, lenSave)
            arrCheck(0, lenCheck - 1) = myDateStr
            arrCheck(1, lenCheck - 1) = txtOrder.Text
            arrCheck(2, lenCheck - 1) = "-" + txtPayAmount.Text
            arrCheck(3, lenCheck - 1) = myBalance.ToString
            MsgBox("Order Successful")
        Else
            MsgBox("Insufficient Funds")
        End If
        writeTxt()
    End Sub

    Private Sub cmbTransAcc_SelectedIndexChanged_1(sender As Object, e As EventArgs) Handles cmbTransAcc.SelectedIndexChanged
        'changes label
        If cmbTransAcc.SelectedIndex = 1 Then
            lblAcc.Text = "to Savings"
        Else
            lblAcc.Text = "to Checking"
        End If
    End Sub
End Class
