Imports System.Drawing.Graphics
Public Class AnalyticsPage
    Private Sub Form3_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        actualiser()
    End Sub
    Sub actualiser()
        txt1.Items.Clear()
        txt1.Items.Add("Profits")
        txt1.Items.Add("Ventes")
        txt1.Items.Add("Commandes")
        txt1.Text = "Profits"
        title.Text = "P r o f i t s"
        topTeen("7days")
        allD()
    End Sub
    Sub allD()
        Dim f As Single
        f = ScalarQueryNumber("SELECT SUM(prix) FROM Ventes")
        txt2.Text = "Total Profits :  " + Format(f, "0,000.00").ToString + " MAD"

        f = ScalarQueryNumber("SELECT COUNT(VID) FROM Ventes")
        txt3.Text = "Total Ventes : " + f.ToString

        f = ScalarQueryNumber("SELECT COUNT(distinct Commande_ID) FROM Commande")
        txt4.Text = "Total Commandes :  " + f.ToString

        f = ScalarQueryNumber("SELECT COUNT(distinct Commande_ID) FROM Commande WHERE etat_Commande='prete'")
        txt5.Text = "Commandes Prete :  " + f.ToString

        f = ScalarQueryNumber("SELECT COUNT(distinct Commande_ID) FROM Commande WHERE etat_Commande='En Cours'")
        txt6.Text = "Commandes En Cours :  " + f.ToString

        f = ScalarQueryNumber("SELECT COUNT(distinct Commande_ID) FROM Commande WHERE etat_Commande='Livree'")
        txt7.Text = "Commandes Livre :  " + f.ToString

        f = ScalarQueryNumber("SELECT COUNT(distinct Commande_ID) FROM Commande WHERE etat_Commande='annulee'")
        txt8.Text = "Commandes Annulee :  " + f.ToString

        f = ScalarQueryNumber("SELECT COUNT(*) FROM Produit WHERE statut='available'")
        txt9.Text = "les produits stockés :  " + f.ToString
    End Sub





    Sub Profits()
        today_Profits()
        yesterday_Profits()
        lastSevenDays_Profits()
        lastThirtyDays_Profits()
    End Sub
    Sub Ventes()
        today_Ventes()
        yesterday_Ventes()
        lastSevenDays_Ventes()
        lastThirtyDays_Ventes()
    End Sub
    Sub Commandes()
        today_Commandes()
        yesterday_Commandes()
        lastSevenDays_Commandes()
        lastThirtyDays_Commandes()
    End Sub








    Sub today_Profits()
        Dim f As Single = ScalarQueryNumber("SELECT SUM(prix) FROM Ventes WHERE date=CURDATE()")
        Dim Num_Day As String = ScalarQueryNumber("SELECT count(*) FROM Ventes WHERE date=CURDATE()")
        l1.Text = Format(f, "0.00").ToString + " MAD"
        l2.Text = Num_Day + " Produit"

    End Sub
    Sub yesterday_Profits()
        Dim f As Single = ScalarQueryNumber("SELECT SUM(prix) FROM Ventes WHERE date=SUBDATE(CURDATE(),1)")
        Dim s As Single = ScalarQueryNumber("SELECT SUM(prix) FROM Ventes WHERE date=SUBDATE(CURDATE(),8)")
        Dim r As Single = (f - s)
        Dim p As Single = ((r) * 100) / f
        If r > 0 Then
            l4.ForeColor = Color.Green
            l3.Text = Format(f, "0.00").ToString + " MAD"
            l4.Text = "+" + r.ToString + " MAD (+" + Format(p, "0.00").ToString + "%)"
        End If
        If r < 0 Then
            l4.ForeColor = Color.Red
            l3.Text = Format(f, "0.00").ToString + " MAD"
            l4.Text = r.ToString + " MAD (" + Format(p, "0.00").ToString + "%)"
        End If
    End Sub
    Sub lastSevenDays_Profits()
        Dim f As Single = ScalarQueryNumber("SELECT SUM(prix) FROM Ventes WHERE (date BETWEEN SUBDATE(CURDATE(),7) And CURDATE())")
        Dim s As Single = ScalarQueryNumber("SELECT SUM(prix) FROM Ventes WHERE (date BETWEEN SUBDATE(CURDATE(),15) And SUBDATE(CURDATE(),8) )")
        Dim r As Single = (f - s)
        Dim p As Single = ((r) * 100) / f
        If r > 0 Then
            l6.ForeColor = Color.Green
            l5.Text = Format(f, "0.00").ToString + " MAD"
            l6.Text = "+" + r.ToString + " MAD (+" + Format(p, "0.00").ToString + "%)"
        End If
        If r < 0 Then
            l6.ForeColor = Color.Red
            l5.Text = Format(f, "0.00").ToString + " MAD"
            l6.Text = r.ToString + " MAD (" + Format(p, "0.00").ToString + "%)"
        End If
    End Sub
    Sub lastThirtyDays_Profits()
        Dim f As Single = ScalarQueryNumber("SELECT SUM(prix) FROM Ventes WHERE (date BETWEEN SUBDATE(CURDATE(),30) And CURDATE())")
        Dim s As Double = ScalarQueryNumber("SELECT SUM(prix) FROM Ventes WHERE (date BETWEEN SUBDATE(CURDATE(),60) And SUBDATE(CURDATE(),31) )")
        Dim r As Single = (f - s)
        Dim p As Single = ((r) * 100) / f
        If r > 0 Then
            l8.ForeColor = Color.Green
            l7.Text = Format(f, "0,000.00").ToString + " MAD"
            l8.Text = "+" + r.ToString + " MAD (+" + Format(p, "0.00").ToString + "%)"
        End If
        If r < 0 Then
            l8.ForeColor = Color.Red
            l7.Text = Format(f, "0,000.00").ToString + " MAD"
            l8.Text = r.ToString + " MAD (" + Format(p, "0.00").ToString + "%)"
        End If
    End Sub










    Sub today_Ventes()
        Dim f As String = ScalarQueryNumber("SELECT COUNT(VID) FROM Ventes WHERE date=CURDATE()")
        l1.Text = f
        l2.Text = " "

    End Sub
    Sub yesterday_Ventes()
        Dim f As Single = ScalarQueryNumber("SELECT COUNT(VID) FROM Ventes WHERE date=SUBDATE(CURDATE(),1)")
        Dim s As Single = ScalarQueryNumber("SELECT COUNT(VID) FROM Ventes WHERE date=SUBDATE(CURDATE(),8)")
        Dim r As Single = (f - s)
        Dim p As Single = ((r) * 100) / f
        If r > 0 Then
            l4.ForeColor = Color.Green
            l3.Text = f.ToString
            l4.Text = "+" + r.ToString + "  (+" + Format(p, "0.00").ToString + "%)"
        End If
        If r < 0 Then
            l4.ForeColor = Color.Red
            l3.Text = f.ToString
            l4.Text = r.ToString + "  (" + Format(p, "0.00").ToString + "%)"
        End If
    End Sub
    Sub lastSevenDays_Ventes()
        Dim f As Single = ScalarQueryNumber("SELECT COUNT(VID) FROM Ventes WHERE (date BETWEEN SUBDATE(CURDATE(),7) And CURDATE())")
        Dim s As Single = ScalarQueryNumber("SELECT COUNT(VID) FROM Ventes WHERE (date BETWEEN SUBDATE(CURDATE(),15) And SUBDATE(CURDATE(),8) )")
        Dim r As Single = (f - s)
        Dim p As Single = ((r) * 100) / f
        If r > 0 Then
            l6.ForeColor = Color.Green
            l5.Text = f.ToString
            l6.Text = "+" + r.ToString + "  (+" + Format(p, "0.00").ToString + "%)"
        End If
        If r < 0 Then
            l6.ForeColor = Color.Red
            l5.Text = f.ToString
            l6.Text = r.ToString + "  (" + Format(p, "0.00").ToString + "%)"
        End If
    End Sub
    Sub lastThirtyDays_Ventes()
        Dim f As Single = ScalarQueryNumber("SELECT COUNT(VID) FROM Ventes WHERE (date BETWEEN SUBDATE(CURDATE(),30) And CURDATE())")
        Dim s As Double = ScalarQueryNumber("SELECT COUNT(VID) FROM Ventes WHERE (date BETWEEN SUBDATE(CURDATE(),60) And SUBDATE(CURDATE(),31) )")
        Dim r As Single = (f - s)
        Dim p As Single = ((r) * 100) / f
        If r > 0 Then
            l8.ForeColor = Color.Green
            l7.Text = f.ToString
            l8.Text = "+" + r.ToString + "  (+" + Format(p, "0.00").ToString + "%)"
        End If
        If r < 0 Then
            l8.ForeColor = Color.Red
            l7.Text = f.ToString
            l8.Text = r.ToString + "  (" + Format(p, "0.00").ToString + "%)"
        End If
    End Sub














    Sub today_Commandes()
        Dim f As String = ScalarQueryNumber("SELECT COUNT(distinct Commande_ID) FROM Commande WHERE DataD=CURDATE()")
        l1.Text = f
        l2.Text = " "

    End Sub
    Sub yesterday_Commandes()
        Dim f As Single = ScalarQueryNumber("SELECT COUNT(distinct Commande_ID) FROM Commande WHERE DataD=SUBDATE(CURDATE(),1)")
        Dim s As Single = ScalarQueryNumber("SELECT COUNT(distinct Commande_ID) FROM Commande WHERE DataD=SUBDATE(CURDATE(),8)")
        Dim r As Single = (f - s)
        Dim p As Single = ((r) * 100) / f
        If r > 0 Then
            l4.ForeColor = Color.Green
            l3.Text = f.ToString
            l4.Text = "+" + r.ToString + "  (+" + Format(p, "0.00").ToString + "%)"
        End If
        If r < 0 Then
            l4.ForeColor = Color.Red
            l3.Text = f.ToString
            l4.Text = r.ToString + "  (" + Format(p, "0.00").ToString + "%)"
        End If
    End Sub
    Sub lastSevenDays_Commandes()
        Dim f As Single = ScalarQueryNumber("SELECT COUNT(distinct Commande_ID) FROM Commande WHERE (DataD BETWEEN SUBDATE(CURDATE(),7) And CURDATE())")
        Dim s As Single = ScalarQueryNumber("SELECT COUNT(distinct Commande_ID) FROM Commande WHERE (DataD BETWEEN SUBDATE(CURDATE(),15) And SUBDATE(CURDATE(),8) )")
        Dim r As Single = (f - s)
        Dim p As Single = ((r) * 100) / f
        If r > 0 Then
            l6.ForeColor = Color.Green
            l5.Text = f.ToString
            l6.Text = "+" + r.ToString + "  (+" + Format(p, "0.00").ToString + "%)"
        End If
        If r < 0 Then
            l6.ForeColor = Color.Red
            l5.Text = f.ToString
            l6.Text = r.ToString + "  (" + Format(p, "0.00").ToString + "%)"
        End If
    End Sub
    Sub lastThirtyDays_Commandes()
        Dim f As Single = ScalarQueryNumber("SELECT COUNT(distinct Commande_ID) FROM Commande WHERE (DataD BETWEEN SUBDATE(CURDATE(),30) And CURDATE())")
        Dim s As Double = ScalarQueryNumber("SELECT COUNT(distinct Commande_ID) FROM Commande WHERE (DataD BETWEEN SUBDATE(CURDATE(),60) And SUBDATE(CURDATE(),31) )")
        Dim r As Single = (f - s)
        Dim p As Single = ((r) * 100) / f
        If r > 0 Then
            l8.ForeColor = Color.Green
            l7.Text = f.ToString
            l8.Text = "+" + r.ToString + "  (+" + Format(p, "0.00").ToString + "%)"
        End If
        If r < 0 Then
            l8.ForeColor = Color.Red
            l7.Text = f.ToString
            l8.Text = r.ToString + "  (" + Format(p, "0.00").ToString + "%)"
        End If
    End Sub

    Private Sub txt1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles txt1.SelectedIndexChanged
        Select Case txt1.Text.ToString
            Case "Profits"
                Profits()
                title.Text = "P r o f i t s"
            Case "Commandes"
                Commandes()
                title.Text = "C o m m a n d e s"
            Case "Ventes"
                Ventes()
                title.Text = "V e n t e s"
        End Select

    End Sub

    Sub topTeen(d As String)
        Dim stDate As String()
        Select Case d
            Case "7days"
                bu30j.BackColor = Color.Gainsboro
                bu7j.BackColor = Color.RoyalBlue
                stDate = New String() {" (date BETWEEN SUBDATE(CURDATE(),7) And CURDATE()) ", " (date BETWEEN SUBDATE(CURDATE(),15) And SUBDATE(CURDATE(),8)) "}
            Case "30days"
                bu30j.BackColor = Color.RoyalBlue
                bu7j.BackColor = Color.Gainsboro
                stDate = New String() {" (date BETWEEN SUBDATE(CURDATE(),30) And CURDATE()) ", " (date BETWEEN SUBDATE(CURDATE(),61) And SUBDATE(CURDATE(),31)) "}
        End Select
        Dim listA As New List(Of String)
        Dim listB As New List(Of String)
        Dim listC As New List(Of String)
        Dim listD As New List(Of Single)
        Dim listR As New List(Of Single)
        Dim listE As New List(Of String)
        Dim txtA As New List(Of Label) From {a1, a2, a3, a4, a5, a6, a7}
        Dim txtB As New List(Of Label) From {b1, b2, b3, b4, b5, b6, b7}
        Dim txtC As New List(Of Label) From {c1, c2, c3, c4, c5, c6, c7}
        Dim txtD As New List(Of Label) From {d1, d2, d3, d4, d5, d6, d7}
        Dim txtE As New List(Of Label) From {e1, e2, e3, e4, e5, e6, e7}
        Dim lst As New List(Of List(Of Label)) From {txtA, txtB, txtC, txtD, txtE}
        For Each ls As List(Of Label) In lst
            For Each item As Label In ls
                item.Text = "--"
            Next
        Next
        connecter()
        commande.CommandText = "SELECT distinct Prod_designation FROM Ventes where " + stDate(0) + " Group By Prod_designation order by count(Prod_designation) DESC LIMIT 7"
        reader = commande.ExecuteReader
        While reader.Read
            listA.Add(reader(0)) 'Prod_designation
        End While
        deconnecter()
        For Each item As String In listA
            listE.Add(ScalarQueryNumber("SELECT COUNT(Prod_designation) FROM Ventes where Prod_designation='" + item + "'")) 'prix
            listB.Add(ScalarQueryNumber("SELECT distinct prix FROM produit where designation='" + item + "'")) 'prix
            listC.Add(ScalarQueryNumber("SELECT COUNT(*) FROM Produit WHERE statut='available' and designation='" + item + "'")) 'quantite
            Dim f As Single = ScalarQueryNumber("SELECT COUNT(VID) FROM Ventes WHERE " + stDate(0) + " and Prod_designation='" + item + "'")
            Dim s As Single = ScalarQueryNumber("SELECT COUNT(VID) FROM Ventes WHERE " + stDate(1) + " and Prod_designation='" + item + "'")
            Dim r As Single = (f - s)
            Dim p As Single = (r * 100) / f
            listD.Add(p)
            listR.Add(r)
        Next

        Dim n As Integer = 0
        For Each item As String In listA
            txtA(n).Text = item
            n += 1
        Next
        n = 0
        For Each item As String In listB
            txtB(n).Text = item + " MAD"
            n += 1
        Next
        n = 0
        For Each item As String In listC
            txtC(n).Text = item
            n += 1
        Next
        n = 0
        For Each item As String In listR
            txtD(n).Text = ""
            txtD(n).Text = item
            n += 1
        Next
        n = 0
        For Each item As Single In listD
            If item > 0 Then
                txtD(n).ForeColor = Color.Green
                txtD(n).Text += "(+" + Format(item, "0.0") + "%)"
            End If
            If item < 0 Then
                txtD(n).ForeColor = Color.Red
                txtD(n).Text += "(" + Format(item, "0.0") + "%)"
            End If
            n += 1
        Next
        n = 0
        For Each item As String In listE
            txtE(n).Text = item
            n += 1
        Next
    End Sub
    Private Sub bu7j_Click(sender As Object, e As EventArgs) Handles bu7j.Click
        topTeen("7days")
    End Sub

    Private Sub bu30j_Click(sender As Object, e As EventArgs) Handles bu30j.Click
        topTeen("30days")
    End Sub

    Private Sub bu_Actualiser_Click(sender As Object, e As EventArgs) Handles bu_Actualiser.Click
        actualiser()
    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint
        'Panel1.BorderStyle = BorderStyle.FixedSingle
        'e.Graphics.DrawRectangle(New Pen(Color.WhiteSmoke, 0.02), Nothing)
    End Sub

    Private Sub a0_Click(sender As Object, e As EventArgs) Handles a0.Click

    End Sub

    Private Sub bu_end_Click(sender As Object, e As EventArgs) Handles bu_end.Click
        SalesPage.Show()
        Me.Close()
    End Sub
End Class