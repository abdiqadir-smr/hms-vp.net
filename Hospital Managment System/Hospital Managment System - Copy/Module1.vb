Imports System.Data.OleDb
Module Module1
    Public Const cs As String = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\Users\a\Documents\Visual Studio 2008\Hospital Managment System\hms_db.mdb; Persist security info=false"
    Dim rdr As OleDbDataReader = Nothing
    Dim dtable As DataTable
    Dim con As OleDbConnection = Nothing
    Dim adp As OleDbDataAdapter
    Dim ds As OleDbCommand = Nothing
    Dim dt As New DataTable
End Module