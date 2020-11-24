Public Class ConnectionPage
    Private Sub Form4_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        msg.Text = ""
    End Sub

    Private Sub b2_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub b1_Click(sender As Object, e As EventArgs) Handles b1.Click
        '82; 107
        '71; 132
        Dim name As String = txt1.Text.Trim.ToString
        Dim password As String = txt2.Text.Trim.ToString
        If password.Count < 6 Then
            Panel1.Location = New Point(71, 145)
        End If
        If name.Equals("") Or password.Equals("") Then
            msg.Text = "veuillez remplir tous champs SVP"
            Panel1.Location = New Point(71, 145)
            If password.Count < 6 Then
                txt2.Text = ""
                txt2.Select()
            End If
        Else
            Try
                Dim id As Integer = ScalarQueryNumber("SELECT UID FROM User WHERE name='" + name + "' and password='" + password + "'")
                If id <> 0 Then
                    set_Type(ScalarQueryString("SELECT userType FROM User WHERE UID=" + id.ToString))
                    set_ID(id)
                    SalesPage.Show()
                    Me.Close()
                Else
                    Panel1.Location = New Point(71, 159)
                    msg.Text = "le mote de passe ou nom d'utilisateur incorrect"
                    txt1.Select()
                End If
            Catch ex As Exception
                msg.Text = "Aucune connexion à la base de données"
                Panel1.Location = New Point(71, 145)
            End Try

        End If
    End Sub

    Private Sub b2_Click_1(sender As Object, e As EventArgs) Handles b2.Click
        End
    End Sub
End Class