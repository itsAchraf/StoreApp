Imports MySql.Data.MySqlClient
Imports System.Runtime.InteropServices
Public Class Parametre
    Dim F, B, Q As Integer
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        B = 1
        b1_Click(Nothing, Nothing)
        cmbx()
    End Sub
    Private Sub ajBu_Click(sender As Object, e As EventArgs) Handles ajBu.Click
        If checkTextBox().Length <> 0 Then
            If F = 1 Then
                ExecuteQuery("INSERT INTO Fournisseur(FID,Fournisseur,adress,telephone,email) VALUES (NULL,'" + checkTextBox(0) + "','" + checkTextBox(1) + "','" + checkTextBox(2) + "','" + checkTextBox(3) + "')")
            ElseIf F = 2 Then
                Console.WriteLine(QteValue)
                For i = 1 To QteValue()
                    Console.WriteLine("insiade Loop" + i.ToString)
                    ExecuteQuery("INSERT INTO Produit (NumSerie,designation,Categorie,FID,prix)  VALUES (NULL,'" + checkTextBox(0) + "','" + checkTextBox(1) + "',(SELECT FID FROM Fournisseur where Fournisseur ='" + txt7.Text + "'),'" + checkTextBox(3) + "')")
                Next
            ElseIf F = 3 Then
                ExecuteQuery("INSERT INTO User (UID,name,password,usertype) VALUES (NULL,'" + checkTextBox(0) + "','" + checkTextBox(1) + "','" + checkTextBox(2) + "')")
            End If
            newLaod()
            'clearAll()
        Else
            Console.WriteLine("Error")
        End If

    End Sub
    Function checkTextBox() As String()
        If F = 1 Then
            If txt1.Text.ToString.Trim.Length = 0 Or
           txt2.Text.ToString.Trim.Length = 0 Or
           txt3.Text.ToString.Trim.Length = 0 Or
           txt4.Text.ToString.Trim.Length = 0 Then
                Return {}
            Else
                Return {txt1.Text.ToString.Trim, txt2.Text.ToString.Trim, txt3.Text.ToString.Trim, txt4.Text.ToString.Trim}
            End If
        ElseIf F = 2 Then
            If B = 1 Then
                If txt7.Text.ToString.Trim.Length = 0 Or
               txt5.Text.ToString.Trim.Length = 0 Or
               txt6.Text.ToString.Trim.Length = 0 Or
               txt8.Text.ToString.Trim.Length = 0 Then
                    Return {}
                Else
                    Return {txt5.Text.ToString.Trim, txt6.Text.ToString.Trim, txt7.Text.ToString.Trim, txt8.Text.ToString.Trim}
                End If
            ElseIf B = 0 Then
                If txt7.Text.ToString.Trim.Length = 0 Or
              txt5.Text.ToString.Trim.Length = 0 Or
              ntxt6.Text.ToString.Trim.Length = 0 Or
              txt8.Text.ToString.Trim.Length = 0 Then
                    Return {}
                Else
                    Return {txt5.Text.ToString.Trim, ntxt6.Text.ToString.Trim, txt7.Text.ToString.Trim, txt8.Text.ToString.Trim}
                End If
            End If
        ElseIf F = 3 Then
            If txt9.Text.ToString.Trim.Length = 0 Or
       txt10.Text.ToString.Trim.Length = 0 Or
       txt11.Text.ToString.Trim.Length = 0 Then
                Return {}
            Else
                Return {txt9.Text.ToString.Trim, txt10.Text.ToString.Trim, txt11.Text.ToString.Trim}
            End If
        ElseIf F = 4 Then
            If txtp1.Text.ToString.Trim.Length = 0 Or
       Not txtp2.Text.ToString.Trim.Equals(txtp3.Text.ToString.Trim) Then
                Return {}
            Else
                Return {txtp2.Text.ToString.Trim}
            End If
        End If
    End Function

    Private Sub b1_Click(sender As Object, e As EventArgs) Handles b1.Click
        search.Visible = True
        fournisseur.Visible = True
        produit.Visible = False
        user.Visible = False
        pass.Visible = False
        F = 1
        b1.BackColor = Color.RoyalBlue
        b2.BackColor = Color.Gainsboro
        b3.BackColor = Color.Gainsboro
        clearAll()
        loadCombo(search, "SELECT DISTINCT Fournisseur FROM Fournisseur")
        Label9.Text = "Fournisseur :"
    End Sub

    Private Sub b2_Click(sender As Object, e As EventArgs) Handles b2.Click
        search.Visible = True
        fournisseur.Visible = False
        produit.Visible = True
        user.Visible = False
        pass.Visible = False
        F = 2
        b1.BackColor = Color.Gainsboro
        b2.BackColor = Color.RoyalBlue
        b3.BackColor = Color.Gainsboro
        clearAll()
        loadCombo(search, "SELECT DISTINCT designation FROM Produit")
        Label9.Text = "designation :"
    End Sub

    Private Sub b3_Click(sender As Object, e As EventArgs) Handles b3.Click
        fournisseur.Visible = False
        produit.Visible = False
        user.Visible = True
        pass.Visible = False
        search.Visible = True
        F = 3
        b1.BackColor = Color.Gainsboro
        b2.BackColor = Color.Gainsboro
        b3.BackColor = Color.RoyalBlue
        clearAll()
        loadCombo(search, "SELECT DISTINCT name FROM User")
        Label9.Text = "Nom :"
        If Not get_Type.Equals("admin") Then
            F = 4
            fournisseur.Visible = False
            produit.Visible = False
            user.Visible = False
            pass.Visible = True
            search.Visible = False
            Label9.Text = ""
        End If
    End Sub
    Sub cmbx()
        loadCombo(txt11, "SELECT DISTINCT usertype FROM User")
        loadCombo(txt6, "SELECT DISTINCT Categorie FROM Produit")
        loadCombo(txt7, "SELECT DISTINCT Fournisseur FROM Fournisseur")
        txt6.Items.Add("autre")
        Qte.Items.Clear()
        For i = 1 To 10
            Qte.Items.Add(i)
        Next
        Qte.Items.Add("plus")
    End Sub

    Private Sub txt6_SelectedIndexChanged(sender As Object, e As EventArgs) Handles txt6.SelectedIndexChanged
        If txt6.Text.Equals("autre") Then
            txt6.Visible = False
            ntxt6.Visible = True
            B = 0
        End If
        Return
    End Sub

    Private Sub endBu_Click(sender As Object, e As EventArgs) Handles endBu.Click
        SalesPage.Show()
        Me.Close()
    End Sub

    Private Sub search_SelectedIndexChanged(sender As Object, e As EventArgs) Handles search.SelectedIndexChanged
        connecter()
        If F = 1 Then
            all.commande.CommandText = "SELECT * FROM Fournisseur where Fournisseur='" + search.Text + "'"
            all.reader = all.commande.ExecuteReader
            If all.reader.Read Then
                txt1.Text = all.reader(1)
                txt2.Text = all.reader(2)
                txt3.Text = all.reader(3)
                txt4.Text = all.reader(4)
            Else
                newLaod()
            End If
        ElseIf F = 2 Then
            all.commande.CommandText = "SELECT NumSerie,designation,Categorie,Fournisseur,prix FROM Produit P,Fournisseur F where designation='" + search.Text + "' and F.FID=P.FID"
            all.reader = all.commande.ExecuteReader
            If all.reader.Read Then
                txt5.Text = all.reader(1)
                txt6.Text = all.reader(2)
                txt7.Text = all.reader(3)
                txt8.Text = all.reader(4)
            Else
                newLaod()
            End If
        ElseIf F = 3 Then
            all.commande.CommandText = "SELECT * FROM User where name='" + search.Text + "'"
            all.reader = all.commande.ExecuteReader
            If all.reader.Read Then
                txt9.Text = all.reader(1)
                txt10.Text = all.reader(2)
                txt11.Text = all.reader(3)
            Else
                newLaod()
            End If
        End If
        deconnecter()
    End Sub

    Private Sub UpdBu_Click(sender As Object, e As EventArgs) Handles UpdBu.Click
        If checkTextBox().Length <> 0 Then
            If F = 1 Then
                ExecuteQuery("UPDATE Fournisseur SET Fournisseur ='" + checkTextBox(0) + "',adress='" + checkTextBox(1) + "',telephone='" + checkTextBox(2) + "',email='" + checkTextBox(3) + "' WHERE Fournisseur='" + search.Text + "'")
            ElseIf F = 2 Then
                ExecuteQuery("UPDATE Produit SET designation='" + checkTextBox(0) + "',Categorie='" + checkTextBox(1) + "',FID=(SELECT FID FROM Fournisseur where Fournisseur ='" + txt7.Text + "'),Prix=" + checkTextBox(3) + " WHERE designation='" + search.Text + "'")
            ElseIf F = 3 Then
                ExecuteQuery("UPDATE User SET name='" + checkTextBox(0) + "',password='" + checkTextBox(1) + "',usertype='" + checkTextBox(2) + "' WHERE name='" + search.Text + "'")
            End If
            newLaod()
        Else
            Console.WriteLine("Error")
        End If
    End Sub

    Sub clearAll()
        search.Items.Clear()
        txt1.Text = ""
        txt2.Text = ""
        txt3.Text = ""
        txt4.Text = ""
        txt5.Text = ""
        txt6.Text = ""
        ntxt6.Text = ""
        txt7.Text = ""
        txt8.Text = ""
        txt9.Text = ""
        txt10.Text = ""
        txt11.Text = ""
        ntxt6.Visible = False
        txt6.Visible = True
        B = 1
    End Sub

    Private Sub delBu_Click(sender As Object, e As EventArgs) Handles delBu.Click
        If checkTextBox().Length <> 0 Then
            Try
                If F = 1 Then
                    ExecuteQuery("DELETE FROM Fournisseur WHERE Fournisseur='" + search.Text + "'")
                ElseIf F = 2 Then
                    ExecuteQuery("DELETE FROM Produit WHERE désignation='" + search.Text + "'")
                ElseIf F = 3 Then
                    ExecuteQuery("DELETE FROM User WHERE name='" + search.Text + "'")
                End If
                newLaod()
            Catch ex As Exception
                MsgBox("erreur de suppression")
            End Try
        Else
            Console.WriteLine("Error")
        End If
    End Sub

    Private Sub Label9_Click(sender As Object, e As EventArgs) Handles Label9.Click

    End Sub

    Sub newLaod()
        clearAll()
        If F = 1 Then
            b1_Click(Nothing, Nothing)
        ElseIf F = 2 Then
            b2_Click(Nothing, Nothing)
        ElseIf F = 3 Then
            b3_Click(Nothing, Nothing)
        End If
        cmbx()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        ExecuteQuery("UPDATE User SET password='" + checkTextBox(0) + "' WHERE UID='" + get_ID.ToString + "'")
    End Sub

    Private Sub Qte_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Qte.SelectedIndexChanged
        If Qte.Text.Equals("plus") Then
            Qte.Visible = False
            txtQte.Visible = True
            Q = 1
        End If
    End Sub

    Function QteValue() As Integer
        If Q = 1 Then
            Return Integer.Parse(txtQte.Text)
        Else
            Return Integer.Parse(Qte.Text)
        End If
    End Function

End Class
