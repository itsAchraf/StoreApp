Imports System.Runtime.InteropServices
Public Class SalesPage
    Dim o As Integer
    Dim listV As New List(Of String)

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        loadNewData()
        SendMessage(Me.txt5.Handle, &H1501, 0, "min")
        SendMessage(Me.txt6.Handle, &H1501, 0, "max")
    End Sub

    Sub loadNewData()
        loadCombo(txt1, "SELECT DISTINCT NumSerie FROM Produit WHERE statut='available'")
        loadCombo(txt2, "SELECT DISTINCT designation FROM Produit WHERE statut='available'")
        loadCombo(txt3, "SELECT DISTINCT Categorie FROM Produit WHERE statut='available'")
        loadCombo(txt4, "SELECT DISTINCT Fournisseur FROM Produit P,Fournisseur F WHERE F.FID=P.FID and statut='available'")
        loadDGV(DGV, "SELECT NumSerie,designation,Categorie,Fournisseur,prix FROM Produit P,Fournisseur F WHERE F.FID=P.FID and statut='available' order by NumSerie ")
        pp.Visible = True
        p1.Visible = False
        p2.Visible = False
        pp.Location = New Point(pp.Location.X, 441)
        p1.Location = New Point(p1.Location.X, 441)
        GlobPan.Location = New Point(GlobPan.Location.X, 39)
        o = 2
        labTotal.Visible = False
        txtTotal.Visible = False
        listV.Clear()
        txtTotal.Text = "0"
        If Not get_Type().Equals("admin") Then
            b3.Visible = False
            b4.Location = New Point(427, 6)
            b2.Location = New Point(262, 6)
            b1.Location = New Point(97, 6)
        End If
        DTP.Value = DateTime.Now
    End Sub

    Sub multipleSearch()
        Dim query = ""
        Dim v1, v2, v3, v4, v5, v6 As String
        If Not txt1.Text.Trim.Equals("") Then
            query += " And NumSerie ='" + txt1.Text.Trim + "'"
        End If
        If Not txt2.Text.Trim.Equals("") Then
            query += " and designation='" + txt2.Text.Trim + "'"
        End If
        If Not txt3.Text.Trim.Equals("") Then
            query += " and Categorie='" + txt3.Text.Trim + "'"
        End If
        If Not txt4.Text.Trim.Equals("") Then
            query += " and Fournisseur='" + txt4.Text.Trim + "'"
        End If
        If Not txt5.Text.Trim.Equals("") And Not txt6.Text.Trim.Equals("") Then
            query += " and Prix BETWEEN " + txt5.Text.Trim + " AND " + txt6.Text.Trim + ""
        ElseIf txt5.Text.Trim.Equals("") And Not txt6.Text.Trim.Equals("") Then
            query += " and Prix < " + txt6.Text.Trim + ""
        ElseIf Not txt5.Text.Trim.Equals("") And txt6.Text.Trim.Equals("") Then
            query += " and Prix > " + txt5.Text.Trim + ""
        End If
        If Not query.Trim.Equals("") Then
            loadDGVtoMultipleSearch(DGV, "SELECT NumSerie,designation,Categorie,Fournisseur,prix FROM Produit P,Fournisseur F where F.FID=P.FID and statut='available' " + query)
        Else
            loadDGVtoMultipleSearch(DGV, "SELECT NumSerie,designation,Categorie,Fournisseur,prix FROM Produit P,Fournisseur F where F.FID=P.FID and statut='available' order by NumSerie")
        End If
    End Sub











    Private Sub insertNewProductToBox()
        txtTotal.Text = Val(txtTotal.Text) + ScalarQueryNumber("SELECT prix FROM Produit WHERE NumSerie=" + txt1.Text)
        listV.Add(txt1.Text)
        Dim query = ""
        For Each item As String In listV
            If listV.IndexOf(item) = 0 Then
                query += item
            Else
                query += "," + item
            End If
        Next
        loadDGVtoMultipleSearch(DGV, "SELECT NumSerie,designation,Categorie,Fournisseur,prix FROM Produit P,Fournisseur F where F.FID=P.FID and NumSerie IN (" + query + ")")

    End Sub







    Private Sub buVen_Click(sender As Object, e As EventArgs) Handles buVen.Click
        pp.Visible = False
        p1.Visible = True
        p2.Visible = False
        o = 1
        labTotal.Visible = True
        txtTotal.Visible = True
    End Sub






    Private Sub commandBu_Click(sender As Object, e As EventArgs) Handles commandBu.Click
        pp.Visible = False
        p1.Visible = True
        p2.Visible = True
        pp.Location = New Point(pp.Location.X, 500)
        p1.Location = New Point(p1.Location.X, 500)
        GlobPan.Location = New Point(GlobPan.Location.X, 99)
        o = 2
        labTotal.Visible = True
        txtTotal.Visible = True
    End Sub






































    Sub newCommande()
        Dim Commande_ID As String = ScalarQueryNumber("SELECT Max(Commande_ID)+1 FROM Commande ")
        If o = 1 Then
            For Each item As String In listV
                ExecuteQuery("INSERT INTO Ventes (VID,UID,NumSerie,Prod_designation,prix,Commande_ID,date) VALUES (NULL," + get_ID().ToString + ", " + item + ",(SELECT designation FROM Produit WHERE NumSerie=" + item + "),(SELECT prix FROM Produit WHERE NumSerie=" + item + "),0,now())")
            Next
            For Each item As String In listV
                ExecuteQuery("DELETE FROM Produit WHERE NumSerie='" + item + "'")
            Next
        ElseIf o = 2 Then
            For Each item As String In listV
                ExecuteQuery("INSERT INTO Commande (Commande_ID,NumSerie,ID_Client,Name_Client,designation,prix,DataD,DateL,etat_Commande)
                VALUES (" + Commande_ID + "," + item + ",'" + txtUserID.Text + "','" + txtNom.Text + "',
                (SELECT designation FROM Produit WHERE NumSerie=" + item + "),
                (SELECT prix FROM Produit WHERE NumSerie=" + item + "),now(),'" + DTP.Value.ToString("yyyy-MM-dd") + "','En Cours')")
            Next
            For Each item As String In listV
                ExecuteQuery("UPDATE Produit SET statut ='unavailable' WHERE NumSerie= " + item)
            Next
        End If

    End Sub
    Private Sub insertBu_Click(sender As Object, e As EventArgs) Handles insertBu.Click
        insertNewProductToBox()
    End Sub
    Private Sub valideBu_Click(sender As Object, e As EventArgs) Handles valideBu.Click
        Select Case MsgBox("validé votre confirmation", MsgBoxStyle.OkCancel, "caption")
            Case MsgBoxResult.Ok
                newCommande()
                loadNewData()
            Case MsgBoxResult.Cancel
                loadNewData()
        End Select

    End Sub
    Private Sub cancelBu_Click(sender As Object, e As EventArgs) Handles cancelBu.Click
        If listV.Count <> 0 Then
            txtTotal.Text = Val(txtTotal.Text) - ScalarQueryNumber("SELECT prix FROM  Produit WHERE NumSerie=" + listV(listV.Count - 1))
            listV.Remove(listV(listV.Count - 1))
        End If
    End Sub









    Private Sub txt1_SelectedIndexChanged_1(sender As Object, e As EventArgs) Handles txt1.TextChanged
        multipleSearch()
    End Sub

    Private Sub txt3_SelectedIndexChanged_1(sender As Object, e As EventArgs) Handles txt3.TextChanged
        multipleSearch()
    End Sub

    Private Sub txt2_SelectedIndexChanged(sender As Object, e As EventArgs) Handles txt2.TextChanged
        multipleSearch()
    End Sub

    Private Sub txt4_SelectedIndexChanged_1(sender As Object, e As EventArgs) Handles txt4.TextChanged
        multipleSearch()
    End Sub

    Private Sub txt5_TextChanged_1(sender As Object, e As EventArgs) Handles txt5.TextChanged
        multipleSearch()
    End Sub

    Private Sub txt6_TextChanged_1(sender As Object, e As EventArgs) Handles txt6.TextChanged
        multipleSearch()
    End Sub

    Private Sub txt1_SelectedIndexChanged(sender As Object, e As EventArgs)
        multipleSearch()
    End Sub

    Private Sub txt2_SelectedIndexChanged_1(sender As Object, e As EventArgs)
        multipleSearch()
    End Sub

    Private Sub txt4_SelectedIndexChanged(sender As Object, e As EventArgs)
        multipleSearch()
    End Sub

    Private Sub txt5_TextChanged(sender As Object, e As EventArgs)
        multipleSearch()
    End Sub

    Private Sub txt6_TextChanged(sender As Object, e As EventArgs)
        multipleSearch()
    End Sub
    Private Sub txt3_SelectedIndexChanged(sender As Object, e As EventArgs)
        multipleSearch()
    End Sub
    <DllImport("user32.dll", CharSet:=CharSet.Auto)>
    Private Shared Function SendMessage(ByVal hWnd As IntPtr, ByVal msg As Integer, ByVal wParam As Integer, <MarshalAs(UnmanagedType.LPWStr)> ByVal lParam As String) As Int32
    End Function

    Private Sub ParamBu_Click(sender As Object, e As EventArgs) Handles b1.Click
        Parametre.Show()
        Me.Close()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles b2.Click
        OrderPage.Show()
        Me.Close()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles b3.Click
        AnalyticsPage.Show()
        Me.Close()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles b4.Click
        End
    End Sub
End Class