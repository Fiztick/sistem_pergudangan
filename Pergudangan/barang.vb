Imports MySql.Data.MySqlClient

Public Class barang
    Private jenisBarang As String
    Private satuan As String
    Private namaBarang As String
    Private stockBarang As Integer
    Private tanggalOrder As String
    Private jumlahOrder As Integer
    Private statusOrder As Boolean
    Private idBarang As Integer

    Public Shared dbConn As New MySqlConnection
    Public Shared sqlCommand As New MySqlCommand
    Public Shared sqlRead As MySqlDataReader
    Private sqlQuery As String

    Private server As String = "localhost"
    Private username As String = "root"
    Private password As String = ""
    Private database As String = "pergudangan"

    Public Property jenisBarangProperty() As String
        Get
            Return jenisBarang
        End Get
        Set(ByVal value As String)
            jenisBarang = value
        End Set
    End Property

    Public Property satuanProperty() As String
        Get
            Return satuan
        End Get
        Set(ByVal value As String)
            satuan = value
        End Set
    End Property

    Public Property namaBarangProperty() As String
        Get
            Return namaBarang
        End Get
        Set(ByVal value As String)
            namaBarang = value
        End Set
    End Property

    Public Property stockBarangProperty() As String
        Get
            Return stockBarang
        End Get
        Set(ByVal value As String)
            stockBarang = value
        End Set
    End Property

    Public Property tanggalOrderProperty() As String
        Get
            Return tanggalOrder
        End Get
        Set(ByVal value As String)
            tanggalOrder = value
        End Set
    End Property

    Public Property jumlahOrderProperty() As Integer
        Get
            Return jumlahOrder
        End Get
        Set(ByVal value As Integer)
            jumlahOrder = value
        End Set
    End Property

    Public Property statusOrderProperty() As Boolean
        Get
            Return statusOrder
        End Get
        Set(ByVal value As Boolean)
            statusOrder = value
        End Set
    End Property

    Public Property idBarangProperty() As Boolean
        Get
            Return idBarang
        End Get
        Set(ByVal value As Boolean)
            idBarang = value
        End Set
    End Property

    Public Function GetDataJenisBarangDB() As DataTable
        Dim result As New DataTable

        dbConn.ConnectionString = "server =" + server + ";" + "user id=" + username + ";" _
        + "password=" + password + ";" + "database=" + database
        dbConn.Open()
        sqlCommand.Connection = dbConn
        sqlCommand.CommandText = "SELECT id_jenis_barang as 'ID Jenis Barang', 
                                        jenis_barang 'Jenis Barang',
                                        satuan as 'Satuan'
                                        FROM jenis_barang"

        sqlRead = sqlCommand.ExecuteReader
        result.Load(sqlRead)
        sqlRead.Close()
        dbConn.Close()
        Return result
    End Function

    Public Function AddDataJenisBarangDB(jenis_barang As String,
                                         satuan As String)

        dbConn.ConnectionString = "server =" + server + ";" + "user id=" + username + ";" _
        + "password=" + password + ";" + "database=" + database

        Try
            dbConn.Open()
            sqlCommand.Connection = dbConn
            sqlQuery = "INSERT INTO jenis_barang(jenis_barang, satuan) VALUE('" _
                        & jenis_barang & "', '" _
                        & satuan & "')"

            Debug.WriteLine(sqlQuery)

            sqlCommand = New MySqlCommand(sqlQuery, dbConn)
            sqlRead = sqlCommand.ExecuteReader
            dbConn.Close()
            sqlRead.Close()
        Catch ex As Exception
            Return ex.Message
        Finally
            dbConn.Dispose()
        End Try
        Return 0
    End Function

    Public Function GetDataJenisBarangByIDDB(id As Integer) As List(Of String)
        Dim result As New List(Of String)

        dbConn.ConnectionString = "server =" + server + ";" + "user id=" + username + ";" _
        + "password=" + password + ";" + "database=" + database
        dbConn.Open()
        sqlCommand.Connection = dbConn

        sqlCommand.CommandText = "SELECT jenis_barang, satuan
                                    FROM jenis_barang
                                    WHERE id_jenis_barang='" & id & "'"
        sqlRead = sqlCommand.ExecuteReader

        While sqlRead.Read
            result.Add(sqlRead.GetString(0).ToString)
            result.Add(sqlRead.GetString(1).ToString)
        End While

        sqlRead.Close()
        dbConn.Close()
        Return result
    End Function

    Public Function UpdateDataJenisBarangByIDDB(id As Integer,
                                                jenis As String,
                                                satuan As String)

        dbConn.ConnectionString = "server =" + server + ";" + "user id=" + username + ";" _
        + "password=" + password + ";" + "database=" + database

        Try
            dbConn.Open()
            sqlCommand.Connection = dbConn

            sqlQuery = "UPDATE jenis_barang SET " &
                        "jenis_barang='" & jenis & "', " &
                        "satuan='" & satuan & "'" &
                        "WHERE id_jenis_barang='" & id & "'"

            sqlCommand = New MySqlCommand(sqlQuery, dbConn)
            sqlRead = sqlCommand.ExecuteReader

            sqlRead.Close()
            dbConn.Close()
        Catch ex As Exception
            Return ex.Message
        Finally
            dbConn.Dispose()
        End Try
        Return 0
    End Function

    Public Function DeleteDataJenisBarangByIDDB(id As Integer)

        dbConn.ConnectionString = "server =" + server + ";" + "user id=" + username + ";" _
        + "password=" + password + ";" + "database=" + database

        Try
            dbConn.Open()
            sqlCommand.Connection = dbConn

            sqlQuery = "DELETE 
                        FROM jenis_barang
                        WHERE id_jenis_barang='" & id & "'"

            sqlCommand = New MySqlCommand(sqlQuery, dbConn)
            sqlRead = sqlCommand.ExecuteReader

            sqlRead.Close()
            dbConn.Close()
        Catch ex As Exception
            Return ex.Message
        Finally
            dbConn.Dispose()
        End Try
        Return 0
    End Function

    Public Function GetDataBarangGudangDB() As DataTable
        Dim result As New DataTable

        dbConn.ConnectionString = "server =" + server + ";" + "user id=" + username + ";" _
        + "password=" + password + ";" + "database=" + database
        dbConn.Open()
        sqlCommand.Connection = dbConn
        sqlCommand.CommandText = "SELECT id_barang as 'ID Barang', 
                                        id_jenis_barang 'ID Jenis Barang',
                                        barang as 'Nama Barang',
                                        stock as 'Stock Barang'
                                        FROM barang"

        sqlRead = sqlCommand.ExecuteReader
        result.Load(sqlRead)
        sqlRead.Close()
        dbConn.Close()
        Return result
    End Function


    Public Function AddDataBarangDB(jenis_barang As String,
                                    barang As String,
                                    stock As Integer)
        Dim IDJenisBarang As Integer

        dbConn.ConnectionString = "server =" + server + ";" + "user id=" + username + ";" _
        + "password=" + password + ";" + "database=" + database

        ' Buat nyari id jenis barang dari nama jenis barangnya
        dbConn.Open()
        sqlCommand.Connection = dbConn
        sqlCommand.CommandText = "SELECT id_jenis_barang 
                                  FROM jenis_barang
                                  WHERE jenis_barang ='" & jenis_Barang & "'"
        sqlRead = sqlCommand.ExecuteReader
        While sqlRead.Read
            IDJenisBarang = sqlRead.GetString(0).ToString
        End While

        sqlRead.Close()
        dbConn.Close()

        Try
            dbConn.Open()
            sqlCommand.Connection = dbConn
            sqlQuery = "INSERT INTO barang(id_jenis_barang, barang, stock) VALUE(" _
                        & IDJenisBarang & ", '" _
                        & barang & "', " _
                        & stock & ")"

            Debug.WriteLine(sqlQuery)

            sqlCommand = New MySqlCommand(sqlQuery, dbConn)
            sqlRead = sqlCommand.ExecuteReader
            dbConn.Close()
            sqlRead.Close()
        Catch ex As Exception
            Return ex.Message
        Finally
            dbConn.Dispose()
        End Try
        Return 0
    End Function

    Public Function GetDataBarangByIDDB(id_barang As Integer, id_jenis_barang As Integer) As List(Of String)
        Dim result As New List(Of String)

        dbConn.ConnectionString = "server =" + server + ";" + "user id=" + username + ";" _
        + "password=" + password + ";" + "database=" + database
        dbConn.Open()
        sqlCommand.Connection = dbConn

        sqlCommand.CommandText = "SELECT 
                                    (SELECT jenis_barang
                                     FROM jenis_barang
                                     WHERE id_jenis_barang='" & id_jenis_barang & "'), 
                                  barang, stock
                                  FROM barang
                                  WHERE id_barang='" & id_barang & "'"
        sqlRead = sqlCommand.ExecuteReader
        Debug.WriteLine(sqlCommand.CommandText)

        While sqlRead.Read
            result.Add(sqlRead.GetString(0).ToString)
            result.Add(sqlRead.GetString(1).ToString)
            result.Add(sqlRead.GetString(2).ToString)
        End While

        sqlRead.Close()
        dbConn.Close()
        Return result
    End Function

    Public Function UpdateDataBarangByIDDB(id_barang As Integer,
                                           jenis_barang As String,
                                           nama_barang As String,
                                           stock As String)
        Dim IDJenisBarang As Integer

        dbConn.ConnectionString = "server =" + server + ";" + "user id=" + username + ";" _
        + "password=" + password + ";" + "database=" + database

        ' buat nyari id jenis barang dari nama jenis barangnya
        dbConn.Open()
        sqlCommand.Connection = dbConn
        sqlCommand.CommandText = "SELECT id_jenis_barang 
                                  FROM jenis_barang
                                  WHERE jenis_barang ='" & jenis_barang & "'"
        Debug.WriteLine(sqlCommand.CommandText)
        sqlRead = sqlCommand.ExecuteReader
        While sqlRead.Read
            IDJenisBarang = sqlRead.GetString(0).ToString
        End While

        sqlRead.Close()
        dbConn.Close()

        Try
            dbConn.Open()
            sqlCommand.Connection = dbConn

            sqlQuery = "UPDATE barang SET " &
                        "id_jenis_barang ='" & IDJenisBarang & "', " &
                        "barang='" & nama_barang & "', " &
                        "stock='" & stock & "'" &
                        "WHERE id_barang='" & id_barang & "'"

            sqlCommand = New MySqlCommand(sqlQuery, dbConn)
            sqlRead = sqlCommand.ExecuteReader
            Debug.WriteLine(sqlQuery)

            sqlRead.Close()
            dbConn.Close()
        Catch ex As Exception
            Return ex.Message
        Finally
            dbConn.Dispose()
        End Try
        Return 0
    End Function

    Public Function DeleteDataBarangByIDDB(id As Integer)

        dbConn.ConnectionString = "server =" + server + ";" + "user id=" + username + ";" _
        + "password=" + password + ";" + "database=" + database

        Try
            dbConn.Open()
            sqlCommand.Connection = dbConn

            sqlQuery = "DELETE 
                        FROM barang
                        WHERE id_barang='" & id & "'"

            sqlCommand = New MySqlCommand(sqlQuery, dbConn)
            sqlRead = sqlCommand.ExecuteReader

            sqlRead.Close()
            dbConn.Close()
        Catch ex As Exception
            Return ex.Message
        Finally
            dbConn.Dispose()
        End Try
        Return 0
    End Function

    Public Function GetDataOrderBarangDB() As DataTable
        Dim result As New DataTable

        dbConn.ConnectionString = "server =" + server + ";" + "user id=" + username + ";" _
        + "password=" + password + ";" + "database=" + database
        dbConn.Open()
        sqlCommand.Connection = dbConn
        sqlCommand.CommandText = "SELECT id_order as 'ID Order', 
                                  id_barang as 'ID Barang',
                                  tanggal_order as 'Tanggal Order',
                                  jumlah_order as 'Jumlah Order'
                                  FROM order_barang
                                  WHERE status_order = 1"
        Debug.WriteLine(sqlCommand.CommandText)

        sqlRead = sqlCommand.ExecuteReader
        result.Load(sqlRead)
        sqlRead.Close()
        dbConn.Close()
        Return result
    End Function

    Public Function GetDataOrderBarangByIDDB() As DataTable
        Dim result As New DataTable

        dbConn.ConnectionString = "server =" + server + ";" + "user id=" + username + ";" _
        + "password=" + password + ";" + "database=" + database
        dbConn.Open()
        sqlCommand.Connection = dbConn
        sqlCommand.CommandText = "SELECT id_order as 'ID Order', 
                                  id_barang as 'ID Barang',
                                  tanggal_order as 'Tanggal Order',
                                  jumlah_order as 'Jumlah Order'
                                  FROM order_barang
                                  "
        Debug.WriteLine(sqlCommand.CommandText)

        sqlRead = sqlCommand.ExecuteReader
        result.Load(sqlRead)
        sqlRead.Close()
        dbConn.Close()
        Return result
    End Function

    Public Function GetDataViewBarangByIDDB(id_order_barang As Integer, id_barang As Integer) As List(Of String)
        Dim result As New List(Of String)
        dbConn.ConnectionString = "server =" + server + ";" + "user id=" + username + ";" _
        + "password=" + password + ";" + "database=" + database

        dbConn.Open()
        sqlCommand.Connection = dbConn

        sqlCommand.CommandText = "SELECT id_barang, tanggal_order, jumlah_order
                                  FROM order_barang
                                  WHERE id_barang='" & id_order_barang & "'"
        sqlRead = sqlCommand.ExecuteReader
        Debug.WriteLine(sqlCommand.CommandText)

        While sqlRead.Read
            result.Add(sqlRead.GetString(0).ToString)
            result.Add(sqlRead.GetString(1).ToString)
            result.Add(sqlRead.GetString(2).ToString)
        End While

        sqlRead.Close()
        dbConn.Close()
        Return result
    End Function

    Public Function AddDataOrderBarangDB(id_barang As String,
                                         tanggal_order As Date,
                                         jumlah_order As Integer)
        dbConn.ConnectionString = "server =" + server + ";" + "user id=" + username + ";" _
        + "password=" + password + ";" + "database=" + database

        sqlRead.Close()
        dbConn.Close()

        Try
            dbConn.Open()
            sqlCommand.Connection = dbConn
            sqlQuery = "INSERT INTO order_barang(id_barang, tanggal_order, jumlah_order, status_order) VALUE(" _
                        & id_barang & ", '" _
                        & tanggal_order.ToString("yyyy/MM/dd") & "', '" _
                        & jumlah_order & "', '" _
                        & 1 & "')"

            Debug.WriteLine(sqlQuery)

            sqlCommand = New MySqlCommand(sqlQuery, dbConn)
            sqlRead = sqlCommand.ExecuteReader
            dbConn.Close()
            sqlRead.Close()
        Catch ex As Exception
            Return ex.Message
        Finally
            dbConn.Dispose()
        End Try
        Return 0
    End Function

    Public Function DeleteDataOrderBarangByIDDB(id As Integer)

        dbConn.ConnectionString = "server =" + server + ";" + "user id=" + username + ";" _
        + "password=" + password + ";" + "database=" + database

        Try
            dbConn.Open()
            sqlCommand.Connection = dbConn

            sqlQuery = "UPDATE order_barang
                        SET status_order = '0'
                        WHERE id_order='" & id & "'"

            Debug.WriteLine(sqlQuery)

            sqlCommand = New MySqlCommand(sqlQuery, dbConn)
            sqlRead = sqlCommand.ExecuteReader

            sqlRead.Close()
            dbConn.Close()
        Catch ex As Exception
            Return ex.Message
        Finally
            dbConn.Dispose()
        End Try
        Return 0
    End Function
End Class
