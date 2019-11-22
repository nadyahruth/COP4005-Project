﻿Imports System.Data.SqlClient
Public Class CDB
    Public Function OpenDB() As Boolean
        objSQLCommand = New SqlCommand ' instantiate command object 
        Dim blnResult As Boolean
        If objSQLconn Is Nothing Then
            'we need to instantiate the connection object 
            Try
                objSQLconn = New SqlConnection(gstrConn)
                objSQLconn.Open()
                blnResult = True
            Catch exOpenConnError As Exception
                MessageBox.Show("Cannot open database: " & exOpenConnError.ToString, "Connection Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                blnResult = False
                'you should log this error 
            End Try
        Else
            If objSQLconn.State = ConnectionState.Open Then
                Return True
            Else
                Return False
            End If
        End If
        Return blnResult
    End Function
    Public Sub CloseDB()
        Try
            objSQLconn.Close() 'closing connection to the database
        Catch ex As Exception
            MessageBox.Show("Error, attempting to close database" & ex.ToString, "Database error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    Public Function GetDataReaderBySP(ByVal strSP As String, ByRef params As ArrayList) As SqlDataReader
        If Not OpenDB() Then
            'should error log this probelm 
            Return Nothing

        End If
        objSQLCommand = New SqlCommand(strSP, objSQLconn)
        objSQLCommand.CommandType = CommandType.StoredProcedure
        If Not params Is Nothing Then 'add each paramter into the command object 
            For Each p As SqlParameter In params
                objSQLCommand.Parameters.Add(p)
            Next
        End If
        Try
            Return objSQLCommand.ExecuteReader()
        Catch ex As Exception
            MessageBox.Show("Failed to get data reader: " & ex.ToString, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error)

        End Try
        Return Nothing
    End Function
    Public Function GetDataAdpaterBySP(ByVal strSP As String, ByRef params As ArrayList) As SqlDataAdapter
        objSQLCommand = New SqlCommand(strSP, objSQLconn)
        Dim sqlDA As SqlDataAdapter
        objSQLCommand.CommandType = CommandType.StoredProcedure
        If Not params Is Nothing Then
            For Each p As SqlParameter In params
                objSQLCommand.Parameters.Add(p)
            Next
        End If
        Try
            sqlDA = New SqlDataAdapter(objSQLCommand)
            Return sqlDA
        Catch ex As Exception
            MessageBox.Show("Failed to get data adapter: " & ex.ToString, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Function
    Public Function ExecSP(ByVal strSP As String, ByRef params As ArrayList) As Integer
        If Not OpenDB() Then
            Return -1
        End If
        objSQLCommand = New SqlCommand(strSP, objSQLconn)
        Try
            If Not params IsNot Nothing Then
                For Each p As SqlParameter In params
                    objSQLCommand.Parameters.Add(p)
                Next
            End If
            Return objSQLCommand.ExecuteNonQuery
        Catch ex As Exception
            MessageBox.Show("Error Executing SP: " & ex.ToString, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return -1
        End Try
    End Function
    Public Function GetSingleValueFunction(ByVal strSP As String, ByRef params As ArrayList) As String
        Dim sqlDR As SqlDataReader = GetDataReaderBySP(strSP, params)
        Dim strResult As String
        If Not sqlDR Is Nothing Then 'we got a data reader
            If sqlDR.Read Then ' then we hav some data
                strResult = sqlDR.GetValue(0).ToString
                sqlDR.Close()
                Return strResult
            Else
                Return "-1"
            End If
        End If
        Return "-2" ' failed to connect or even get a data reader
    End Function
End Class
