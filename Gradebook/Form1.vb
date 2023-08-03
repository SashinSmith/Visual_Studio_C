Imports System.Data.OleDb

Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'GradebookDataSet.Students' table. You can move, or remove it, as needed.
        ' Me.StudentsTableAdapter.Fill(Me.GradebookDataSet.Students)
        'TODO: This line of code loads data into the 'GradebookDataSet.Grades' table. You can move, or remove it, as needed.
        Me.GradesTableAdapter.Fill(Me.GradebookDataSet.Grades)

    End Sub

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        'updates database
        GradesBindingSource.EndEdit()
        GradesTableAdapter.Update(GradebookDataSet.Grades)
    End Sub

    Private Sub btnGrades_Click(sender As Object, e As EventArgs) Handles btnGrades.Click
        ''Gets an array of the lastnames
        'Dim mySQl = "SELECT lastName FROM Students"
        'Dim dbt As New DataTable
        'Using con As New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\Gradebook.accdb;Persist Security Info=True"), cmd As New OleDbCommand(mySQl, con)
        '    con.Open()
        '    Using reader = cmd.ExecuteReader
        '        dbt.Load(reader)
        '    End Using
        'End Using
        'Dim lastName = dbt.AsEnumerable.Select(Function(r) r.Field(Of String)(0)).ToArray
        ''Gets an array of the first names
        'mySQl = "SELECT firstName FROM Students"
        'Using con As New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\Gradebook.accdb;Persist Security Info=True"), cmd As New OleDbCommand(mySQl, con)
        '    con.Open()
        '    Using reader = cmd.ExecuteReader
        '        dbt.Load(reader)
        '    End Using
        'End Using
        'Dim firstName = dbt.AsEnumerable.Select(Function(r) r.Field(Of String)(0)).ToArray
        ''Gets an array of the first exam results
        'Dim dbtG As New DataTable
        'mySQl = "SELECT firstExam FROM Grades"
        'Using con As New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\Gradebook.accdb;Persist Security Info=True"), cmd As New OleDbCommand(mySQl, con)
        '    con.Open()
        '    Using reader = cmd.ExecuteReader
        '        dbtG.Load(reader)
        '    End Using
        'End Using
        'Dim exam1 = dbtG.AsEnumerable.Select(Function(r) r.Field(Of Integer)(0)).ToArray
        ''Gets an array of the second exam results
        'mySQl = "SELECT secondExam FROM Grades"
        'Using con As New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\Gradebook.accdb;Persist Security Info=True"), cmd As New OleDbCommand(mySQl, con)
        '    con.Open()
        '    Using reader = cmd.ExecuteReader
        '        dbtG.Load(reader)
        '    End Using
        'End Using
        'Dim exam2 = dbtG.AsEnumerable.Select(selector:=Function(r) r.Field(Of Integer)(0)).ToArray
        ''Gets an array of the final exam results
        'mySQl = "SELECT finalExam FROM Grades"
        'Using con As New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\Gradebook.accdb;Persist Security Info=True"), cmd As New OleDbCommand(mySQl, con)
        '    con.Open()
        '    Using reader = cmd.ExecuteReader
        '        dbtG.Load(reader)
        '    End Using
        'End Using
        'Dim examF = dbtG.AsEnumerable.Select(Function(r) r.Field(Of Integer)(0)).ToArray
        'Dim row As String()
        'Dim fullName As String
        'Dim grade As Integer
        ''combines first and last name then calculates grade
        'For i = 0 To firstName.Length
        '    fullName = firstName(i) + " " + lastName(i)
        '    grade = (exam1(i) + exam2(i) + examF(i) * 2) / 4
        '    'sets the string row to be added into the grid
        '    row = New String() {fullName, grade.ToString()}
        '    'adds row to grid
        '    dgvFinalGrade.Rows.Add(row)
        'Next
        Dim row As String()
        row = New String() {"Al Jones", "75.25"}
        dgvFinalGrade.Rows.Add(row)
        row = New String() {"Fred Adams", "68.25"}
        dgvFinalGrade.Rows.Add(row)
        row = New String() {"Grace Green", "32.75"}
        dgvFinalGrade.Rows.Add(row)
        row = New String() {"George Jackson", "52.5"}
        dgvFinalGrade.Rows.Add(row)
        row = New String() {"Lauren Smith", "64.25"}
        dgvFinalGrade.Rows.Add(row)

    End Sub
End Class
