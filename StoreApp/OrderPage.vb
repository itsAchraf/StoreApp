Public Class OrderPage
    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadingData()
    End Sub

    Private Sub txt1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles txt1.SelectedIndexChanged
        txt2.Items.Clear()
        connecter()
        all.commande.CommandText = "SELECT DISTINCT Commande_ID FROM Commande WHERE etat_Commande in ('En Cours','livree','annulee','prete') and ID_CLient='" + txt1.Text + "'"
        all.reader = all.commande.ExecuteReader
        Dim i As Integer = 0
        While all.reader.Read
            i += 1
            txt2.Items.Add(all.reader(0))
        End While
        deconnecter()

        If i = 1 Then
            loadDGV(DGV, "SELECT  matricule,NumSerie,designation,prix,DataD,DateL FROM Commande WHERE  ID_CLient='" + txt1.Text + "'")
            loadDGV(DGV, "SELECT  C.NumSerie,C.designation,C.prix,DataD,DateL,P.Categorie,F.Fournisseur FROM Commande C, Produit P,Fournisseur F WHERE F.FID=P.FID and C.designation=P.designation and  ID_CLient='" + txt1.Text + "' group by C.matricule")
            etatCommande(ScalarQueryString("SELECT  etat_Commande FROM Commande WHERE ID_CLient='" + txt1.Text + "'"))
            p.Visible = True
        End If

    End Sub

    Private Sub txt2_SelectedIndexChanged(sender As Object, e As EventArgs) Handles txt2.SelectedIndexChanged
        loadDGV(DGV, "SELECT  matricule,NumSerie,designation,prix,DataD,DateL FROM Commande WHERE Commande_ID=" + txt2.Text)
        loadDGV(DGV, "SELECT  C.NumSerie,C.designation,C.prix,DataD,DateL,P.Categorie,F.Fournisseur FROM Commande C, Produit P,Fournisseur F WHERE F.FID=P.FID and C.designation=P.designation and Commande_ID=" + txt2.Text + " group by C.matricule")
        etatCommande(ScalarQueryString("SELECT  etat_Commande FROM Commande WHERE Commande_ID=" + txt2.Text))
        p.Visible = True
    End Sub

    Sub etatCommande(v As String)
        b1.Enabled = True
        b2.Enabled = True
        b3.Enabled = True
        b4.Enabled = True
        Select Case v
            Case "En Cours"
                b1.BackColor = Color.RoyalBlue
                b2.BackColor = Color.Gainsboro
                b3.BackColor = Color.Gainsboro
                b4.BackColor = Color.Gainsboro
            Case "prete"
                b1.BackColor = Color.Gainsboro
                b2.BackColor = Color.RoyalBlue
                b3.BackColor = Color.Gainsboro
                b4.BackColor = Color.Gainsboro
            Case "livree"
                isLivree()
                b1.BackColor = Color.Gainsboro
                b2.BackColor = Color.Gainsboro
                b3.BackColor = Color.RoyalBlue
                b4.BackColor = Color.Gainsboro
            Case "annulee"
                isCancel()
                b1.BackColor = Color.Gainsboro
                b2.BackColor = Color.Gainsboro
                b3.BackColor = Color.Gainsboro
                b4.BackColor = Color.RoyalBlue
        End Select
    End Sub

    Private Sub b1_Click(sender As Object, e As EventArgs) Handles b1.Click
        Dim r As String = "	Commande_ID =" + txt2.Text
        If txt2.Text.Equals("") Then
            r = "ID_Client ='" + txt1.Text + "'"
        End If
        If isCancel() Then
            For Each item As String In checkProduitOfCommande(r)
                Dim s As String() = item.Split(",")
                ExecuteQuery("UPDATE Commande SET NumSerie =" + s(0) + ",prix=(SELECT Prix FROM Produit WHERE NumSerie =" + s(0) + ") WHERE " + r + " and matricule=" + s(1))
                ExecuteQuery("UPDATE Produit SET statut ='unavailable' WHERE NumSerie =" + s(0))

            Next
        End If
        connecter()
        all.commande.CommandText = "UPDATE Commande SET etat_Commande ='En Cours' WHERE " + r
        all.commande.ExecuteNonQuery()
        deconnecter()
        etatCommande("En Cours")
    End Sub

    Private Sub b2_Click(sender As Object, e As EventArgs) Handles b2.Click
        Dim r As String = "	Commande_ID =" + txt2.Text
        If txt2.Text.Equals("") Then
            r = "ID_Client ='" + txt1.Text + "'"
        End If
        connecter()
        all.commande.CommandText = "UPDATE Commande SET etat_Commande ='prete' WHERE " + r
        all.commande.ExecuteNonQuery()
        deconnecter()
        etatCommande("prete")
    End Sub

    Private Sub b3_Click(sender As Object, e As EventArgs) Handles b3.Click
        If Not isLivree() Then
            Dim list As New List(Of String)
            Dim r As String = "	Commande_ID =" + txt2.Text
            Dim query As String = ""
            Dim i As Integer = 0
            If txt2.Text.Equals("") Then
                r = "ID_Client ='" + txt1.Text + "'"
            End If
            connecter()
            all.commande.CommandText = "SELECT NumSerie,matricule FROM Commande WHERE " + r
            all.reader = all.commande.ExecuteReader
            While all.reader.Read
                list.Add(all.reader(0).ToString + "," + all.reader(1).ToString)
                If i = 0 Then
                    query += all.reader(0).ToString
                Else
                    query += "," + all.reader(0).ToString
                End If
                i += 1
            End While
            deconnecter()
            ExecuteQuery("UPDATE Commande SET etat_Commande ='livree' WHERE " + r)

            For Each item As String In list
                Dim S As String() = item.Split(",")
                ExecuteQuery("INSERT INTO Ventes (VID,UID,NumSerie,Prod_designation,prix,Commande_ID,date) VALUES (NULL, " + get_ID().ToString + ", " + S(0) + ",(SELECT designation FROM Produit WHERE NumSerie=" + S(0) + "),(SELECT prix FROM Produit WHERE NumSerie=" + S(0) + "),(SELECT Commande_ID FROM Commande WHERE matricule=" + S(1) + "),now())")
            Next
            ExecuteQuery(" DELETE FROM Produit WHERE NumSerie IN (" + query + ")")
            etatCommande("livree")
        End If
    End Sub

    Private Sub b4_Click(sender As Object, e As EventArgs) Handles b4.Click
        If Not isCancel() Then
            Console.WriteLine("pass")
            Dim r As String = "	Commande_ID =" + txt2.Text
            Dim query As String = ""
            Dim i As Integer = 0

            If txt2.Text.Equals("") Then
                r = "ID_Client ='" + txt1.Text + "'"
            End If

            connecter()
            all.commande.CommandText = "SELECT NumSerie FROM Commande WHERE " + r
            all.reader = all.commande.ExecuteReader
            While all.reader.Read
                If i = 0 Then
                    query += all.reader(0).ToString
                Else
                    query += "," + all.reader(0).ToString
                End If
                i += 1
            End While
            deconnecter()
            ExecuteQuery("UPDATE Commande SET etat_Commande ='annulee' WHERE " + r)
            ExecuteQuery("UPDATE Produit SET statut ='available' WHERE NumSerie IN (" + query + ")")
            etatCommande("annulee")
        End If
    End Sub
    Sub LoadingData()
        p.Visible = False
        loadDGV(DGV, "SELECT Commande_ID,ID_Client,Name_Client ,sum(prix) as Prix,DataD,DateL,etat_Commande FROM Commande WHERE etat_Commande in ('En Cours','livree','annulee','prete') Group By Commande_ID")
        loadCombo(txt1, "SELECT DISTINCT ID_Client FROM Commande WHERE etat_Commande in ('En Cours','livree','annulee','prete')")
        loadCombo(txt2, "SELECT DISTINCT Commande_ID FROM Commande WHERE etat_Commande in ('En Cours','livree','annulee','prete')")
    End Sub
    Function isLivree() As Boolean
        Dim r As String = "	Commande_ID =" + txt2.Text
        If txt2.Text.Equals("") Then
            r = "ID_Client ='" + txt1.Text + "'"
        End If
        If ScalarQueryString("SELECT  etat_Commande FROM Commande WHERE " + r).Equals("livree") Then
            b1.Enabled = False
            b2.Enabled = False
            b4.Enabled = False
            Return True
        End If
        Return False
    End Function
    Function isCancel() As Boolean
        Dim r As String = "	Commande_ID =" + txt2.Text
        If txt2.Text.Equals("") Then
            r = "ID_Client ='" + txt1.Text + "'"
        End If
        If ScalarQueryString("SELECT  etat_Commande FROM Commande WHERE " + r).Equals("annulee") Then
            If checkProduitOfCommande(r).Equals(Nothing) Then
                Console.WriteLine("en cours")
                b1.Enabled = False
                b2.Enabled = False
                b3.Enabled = False
                Return True
            Else
                Console.WriteLine("enable")
                b1.Enabled = True
                b2.Enabled = False
                b3.Enabled = False
                Return True
            End If
        End If
        Return False
    End Function
    Function checkProduitOfCommande(r As String) As List(Of String)
        Dim query As String = ""
        Dim i As Integer = 0
        Dim list, ListM As New List(Of String)
        Dim listPro As New List(Of String)
        connecter()
        all.commande.CommandText = "SELECT designation,matricule FROM Commande WHERE " + r
        all.reader = all.commande.ExecuteReader

        While all.reader.Read
            list.Add(all.reader(0).ToString)
            ListM.Add(all.reader(1).ToString)
        End While
        all.reader.Close()

        For Each item As String In list
            If Not item.Trim.Equals("") Then
                Dim p As String
                p = ScalarQueryString("SELECT NumSerie FROM Produit WHERE designation ='" + item + "'")
                Console.WriteLine("NS : " + p)
                If Not p.Trim.Equals("") Then
                    listPro.Add(p + "," + ListM(i))
                    i += 1
                Else
                    deconnecter()
                    Return Nothing
                End If
            Else
                deconnecter()
                Return Nothing
            End If
        Next
        deconnecter()
        Return listPro
    End Function

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        SalesPage.Show()
        Me.Close()
    End Sub
End Class