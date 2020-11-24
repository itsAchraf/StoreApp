Imports MySql.Data.MySqlClient
Module all
    Public connection As New MySqlConnection
    Public commande As New MySqlCommand
    Public reader As MySqlDataReader


    Private user_ID As Integer
    Private user_Type As String


    Function get_ID() As Integer
        Return user_ID
    End Function

    Sub set_ID(ID As Integer)
        user_ID = ID
    End Sub

    Function get_Type() As String
        Return user_Type
    End Function

    Sub set_Type(type As String)
        Console.WriteLine("****")
        user_Type = type
    End Sub

    Function connecter() As MySqlCommand
        connection.ConnectionString = "data source=Localhost; initial catalog=Store_DB; user=root; password=mysql;"
        commande.Connection = connection
        Try
            connection.Open()
            Console.WriteLine("connecter")
            Return commande
        Catch ex As Exception
            Return Nothing
        End Try
    End Function
    Sub deconnecter()
        connection.Close()
        If reader IsNot Nothing Then
            reader.Close()
        End If
    End Sub
    Sub loadCombo(txt As ComboBox, query As String)
        txt.Items.Clear()
        connecter()
        commande.CommandText = query
        reader = commande.ExecuteReader
        While reader.Read
            txt.Items.Add(reader(0))
        End While
        deconnecter()
    End Sub

    Sub loadDGV(DGV As DataGridView, query As String)
        connecter()
        commande.CommandText = query
        reader = commande.ExecuteReader
        If reader.HasRows Then
            Dim table As New DataTable
            table.Load(reader)
            DGV.DataSource = table
        End If
        deconnecter()
    End Sub
    Sub loadDGVtoMultipleSearch(DGV As DataGridView, query As String)
        connecter()
        Try
            commande.CommandText = query
            reader = commande.ExecuteReader
            Dim table As New DataTable
            table.Load(reader)
            DGV.DataSource = table
            deconnecter()
        Catch
            deconnecter()
        End Try
    End Sub
    Function ScalarQueryString(query As String) As String
        Dim cn As New MySqlConnection("data source=Localhost; initial catalog=Store_DB; user=root; password=mysql;")
        Dim cm As New MySqlCommand
        cm.Connection = cn
        cn.Open()
        Dim v As String
        cm.CommandText = query
        v = cm.ExecuteScalar.ToString()
        cn.Close()
        If v.Trim.Equals("") Then
            Return 0
        End If
        Return v
    End Function


    Function ScalarQueryNumber(query As String) As Single
        Dim cn As New MySqlConnection("data source=Localhost; initial catalog=Store_DB; user=root; password=mysql;")
        Dim cm As New MySqlCommand
        cm.Connection = cn
        cn.Open()
        Dim v As Single
        cm.CommandText = query
        Try
            v = cm.ExecuteScalar
        Catch ex As Exception
            cn.Close()
            Return 0
        End Try
        cn.Close()
        If v = Nothing Then
            Return 0
        End If
        Return v
    End Function

    Sub ExecuteQuery(query As String)
        Dim cn As New MySqlConnection("data source=Localhost; initial catalog=Store_DB; user=root; password=mysql;")
        Dim cm As New MySqlCommand
        cm.Connection = cn
        cn.Open()
        Dim v As Single
        cm.CommandText = query
        cm.ExecuteNonQuery()
        cn.Close()
    End Sub
End Module
