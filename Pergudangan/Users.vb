Imports System.Security.Cryptography
Imports MySql.Data.MySqlClient

Public Class Users

    Private TripleDes As New TripleDESCryptoServiceProvider
    Private username As String
    Private password As String

    Public Shared dbConn As New MySqlConnection
    Public Shared sqlCommand As New MySqlCommand
    Public Shared sqlRead As MySqlDataReader
    Private sqlQuery As String

    Private server As String = "localhost"
    Private username_db As String = "root"
    Private password_db As String = ""
    Private database As String = "pergudangan"

    Public Property usernameProperty() As String
        Get
            Return username
        End Get
        Set(ByVal value As String)
            value = username
        End Set
    End Property

    Public Property passwordProperty() As String
        Get
            Return password
        End Get
        Set(ByVal value As String)
            value = password
        End Set
    End Property

    Public Function EncryptMD5(ByVal password As String)
        ' Initialize the MD5 Hash
        Dim x As New System.Security.Cryptography.MD5CryptoServiceProvider()
        ' Converting password strings to bytes
        Dim bs As Byte() = System.Text.Encoding.UTF8.GetBytes(password)
        ' Hash every bytes to MD5
        bs = x.ComputeHash(bs)
        ' Append the bytes into string
        Dim s As New System.Text.StringBuilder()
        For Each b As Byte In bs
            s.Append(b.ToString("x2").ToLower())
        Next
        Return s.ToString()
    End Function

    Public Function CheckAuthDB(username_login As String, password_login As String) As List(Of String)
        Dim result As New List(Of String)

        ' Initialize connection to database
        dbConn.ConnectionString = "server =" + server + ";" + "user id=" + username_db + ";" _
            + "password =" + password_db + ";" + "database =" + database

        Try
            ' Open connection
            dbConn.Open()
            sqlcommand.Connection = dbConn
            ' Query for run
            Dim queryAuth = "SELECT id_user, username FROM users
                             WHERE username='" & username_login & "' AND password='" & EncryptMD5(password_login) & "'"
            sqlcommand.CommandText = queryAuth
            ' Write queryAuth on console
            Debug.WriteLine(queryAuth)
            ' Read the command
            sqlRead = sqlcommand.ExecuteReader

            ' Checking the database
            If sqlRead.HasRows Then
                While sqlRead.Read
                    result.Add(sqlRead.GetString(0).ToString)
                    result.Add(sqlRead.GetString(1).ToString)
                End While
            End If

            sqlRead.Close()
            dbConn.Close()
        Catch ex As Exception
            Debug.WriteLine(ex.Message)
        Finally
            dbConn.Dispose()
        End Try

        Return result
    End Function

    Public Function AddUserToDB(username_regist As String, password_regist As String)
        Dim today = Date.Now()

        ' Initialize connection to database
        dbConn.ConnectionString = "server =" + server + ";" + "user id=" + username_db + ";" _
            + "password =" + password_db + ";" + "database =" + database

        Try
            ' Open connection
            dbConn.Open()
            sqlCommand.Connection = dbConn
            ' Query for run
            sqlQuery = "INSERT INTO users(username, password, registered_at) VALUE('" _
                & username_regist & "','" _
                & EncryptMD5(password_regist) & "','" _
                & today.ToString("yyyy/MM/dd") & "')"
            ' Write queryAuth on console
            Debug.WriteLine(sqlQuery)
            ' Read the command
            sqlCommand = New MySqlCommand(sqlQuery, dbConn)
            sqlRead = sqlCommand.ExecuteReader

            sqlRead.Close()
            dbConn.Close()
        Catch ex As Exception
            Debug.WriteLine(ex.Message)
        Finally
            dbConn.Dispose()
        End Try

        Return 0
    End Function

    Public Function CheckUsernameRegistToDB(username_regist As String)
        ' Initialize connection to database
        dbConn.ConnectionString = "server =" + server + ";" + "user id=" + username_db + ";" _
            + "password =" + password_db + ";" + "database =" + database

        Try
            ' Open connection
            dbConn.Open()
            sqlCommand.Connection = dbConn
            ' Query for run
            Dim queryAuth = "SELECT username FROM users
                             WHERE username='" & username_regist & "'"
            sqlCommand.CommandText = queryAuth
            ' Write queryAuth on console
            Debug.WriteLine(queryAuth)
            ' Read the command
            sqlRead = sqlCommand.ExecuteReader

            ' Checking the database
            If sqlRead.HasRows Then
                ' Check apa username udh dipake
                While sqlRead.Read
                    If String.Compare(username_regist, sqlRead.GetString(0).ToString()) = 0 Then
                        Return 0
                    End If
                End While
            End If

            sqlRead.Close()
            dbConn.Close()
        Catch ex As Exception
            Debug.WriteLine(ex.Message)
        Finally
            dbConn.Dispose()
        End Try

        Return 1
    End Function

End Class
