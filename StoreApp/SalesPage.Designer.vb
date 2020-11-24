<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class SalesPage
    Inherits System.Windows.Forms.Form

    'Form remplace la méthode Dispose pour nettoyer la liste des composants.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requise par le Concepteur Windows Form
    Private components As System.ComponentModel.IContainer

    'REMARQUE : la procédure suivante est requise par le Concepteur Windows Form
    'Elle peut être modifiée à l'aide du Concepteur Windows Form.  
    'Ne la modifiez pas à l'aide de l'éditeur de code.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.pp = New System.Windows.Forms.Panel()
        Me.commandBu = New System.Windows.Forms.Button()
        Me.buVen = New System.Windows.Forms.Button()
        Me.p1 = New System.Windows.Forms.Panel()
        Me.valideBu = New System.Windows.Forms.Button()
        Me.cancelBu = New System.Windows.Forms.Button()
        Me.insertBu = New System.Windows.Forms.Button()
        Me.p2 = New System.Windows.Forms.Panel()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.DTP = New System.Windows.Forms.DateTimePicker()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtNom = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtUserID = New System.Windows.Forms.TextBox()
        Me.GlobPan = New System.Windows.Forms.Panel()
        Me.txtTotal = New System.Windows.Forms.Label()
        Me.labTotal = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txt6 = New System.Windows.Forms.TextBox()
        Me.txt5 = New System.Windows.Forms.TextBox()
        Me.txt4 = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txt2 = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txt3 = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txt1 = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.DGV = New System.Windows.Forms.DataGridView()
        Me.b1 = New System.Windows.Forms.Button()
        Me.b2 = New System.Windows.Forms.Button()
        Me.b3 = New System.Windows.Forms.Button()
        Me.b4 = New System.Windows.Forms.Button()
        Me.pp.SuspendLayout()
        Me.p1.SuspendLayout()
        Me.p2.SuspendLayout()
        Me.GlobPan.SuspendLayout()
        CType(Me.DGV, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'pp
        '
        Me.pp.Controls.Add(Me.commandBu)
        Me.pp.Controls.Add(Me.buVen)
        Me.pp.Location = New System.Drawing.Point(97, 441)
        Me.pp.Name = "pp"
        Me.pp.Size = New System.Drawing.Size(495, 44)
        Me.pp.TabIndex = 67
        '
        'commandBu
        '
        Me.commandBu.Font = New System.Drawing.Font("Microsoft Tai Le", 12.0!, System.Drawing.FontStyle.Bold)
        Me.commandBu.Location = New System.Drawing.Point(237, 8)
        Me.commandBu.Name = "commandBu"
        Me.commandBu.Size = New System.Drawing.Size(108, 27)
        Me.commandBu.TabIndex = 68
        Me.commandBu.Text = "Commande"
        Me.commandBu.UseVisualStyleBackColor = True
        '
        'buVen
        '
        Me.buVen.Font = New System.Drawing.Font("Microsoft Tai Le", 12.0!, System.Drawing.FontStyle.Bold)
        Me.buVen.Location = New System.Drawing.Point(129, 8)
        Me.buVen.Name = "buVen"
        Me.buVen.Size = New System.Drawing.Size(108, 27)
        Me.buVen.TabIndex = 67
        Me.buVen.Text = "Vendre"
        Me.buVen.UseVisualStyleBackColor = True
        '
        'p1
        '
        Me.p1.Controls.Add(Me.valideBu)
        Me.p1.Controls.Add(Me.cancelBu)
        Me.p1.Controls.Add(Me.insertBu)
        Me.p1.Location = New System.Drawing.Point(157, 441)
        Me.p1.Name = "p1"
        Me.p1.Size = New System.Drawing.Size(374, 43)
        Me.p1.TabIndex = 68
        Me.p1.Visible = False
        '
        'valideBu
        '
        Me.valideBu.Font = New System.Drawing.Font("Bahnschrift SemiBold Condensed", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.valideBu.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.valideBu.Location = New System.Drawing.Point(253, 6)
        Me.valideBu.Name = "valideBu"
        Me.valideBu.Size = New System.Drawing.Size(119, 29)
        Me.valideBu.TabIndex = 2
        Me.valideBu.Text = "Confirmer"
        Me.valideBu.UseVisualStyleBackColor = True
        '
        'cancelBu
        '
        Me.cancelBu.Font = New System.Drawing.Font("Bahnschrift SemiBold Condensed", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cancelBu.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.cancelBu.Location = New System.Drawing.Point(128, 6)
        Me.cancelBu.Name = "cancelBu"
        Me.cancelBu.Size = New System.Drawing.Size(119, 29)
        Me.cancelBu.TabIndex = 1
        Me.cancelBu.Text = "Annuler"
        Me.cancelBu.UseVisualStyleBackColor = True
        '
        'insertBu
        '
        Me.insertBu.Font = New System.Drawing.Font("Bahnschrift SemiBold Condensed", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.insertBu.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.insertBu.Location = New System.Drawing.Point(3, 6)
        Me.insertBu.Name = "insertBu"
        Me.insertBu.Size = New System.Drawing.Size(119, 29)
        Me.insertBu.TabIndex = 0
        Me.insertBu.Text = "Ajouter"
        Me.insertBu.UseVisualStyleBackColor = True
        '
        'p2
        '
        Me.p2.Controls.Add(Me.Label8)
        Me.p2.Controls.Add(Me.DTP)
        Me.p2.Controls.Add(Me.Label7)
        Me.p2.Controls.Add(Me.txtNom)
        Me.p2.Controls.Add(Me.Label6)
        Me.p2.Controls.Add(Me.txtUserID)
        Me.p2.Location = New System.Drawing.Point(78, 39)
        Me.p2.Name = "p2"
        Me.p2.Size = New System.Drawing.Size(533, 60)
        Me.p2.TabIndex = 69
        Me.p2.Visible = False
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Tai Le", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(36, 35)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(45, 16)
        Me.Label8.TabIndex = 38
        Me.Label8.Text = "Date :"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'DTP
        '
        Me.DTP.CustomFormat = "yyyy-MM-dd"
        Me.DTP.Location = New System.Drawing.Point(87, 33)
        Me.DTP.Name = "DTP"
        Me.DTP.Size = New System.Drawing.Size(190, 20)
        Me.DTP.TabIndex = 37
        Me.DTP.Value = New Date(2019, 6, 9, 0, 0, 0, 0)
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Tai Le", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(279, 11)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(46, 16)
        Me.Label7.TabIndex = 36
        Me.Label7.Text = "Nom :"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'txtNom
        '
        Me.txtNom.Location = New System.Drawing.Point(331, 9)
        Me.txtNom.Name = "txtNom"
        Me.txtNom.Size = New System.Drawing.Size(187, 20)
        Me.txtNom.TabIndex = 35
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Tai Le", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(15, 9)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(66, 16)
        Me.Label6.TabIndex = 34
        Me.Label6.Text = "Client ID:"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'txtUserID
        '
        Me.txtUserID.Location = New System.Drawing.Point(87, 7)
        Me.txtUserID.Name = "txtUserID"
        Me.txtUserID.Size = New System.Drawing.Size(187, 20)
        Me.txtUserID.TabIndex = 33
        '
        'GlobPan
        '
        Me.GlobPan.Controls.Add(Me.txtTotal)
        Me.GlobPan.Controls.Add(Me.labTotal)
        Me.GlobPan.Controls.Add(Me.Label5)
        Me.GlobPan.Controls.Add(Me.txt6)
        Me.GlobPan.Controls.Add(Me.txt5)
        Me.GlobPan.Controls.Add(Me.txt4)
        Me.GlobPan.Controls.Add(Me.Label4)
        Me.GlobPan.Controls.Add(Me.txt2)
        Me.GlobPan.Controls.Add(Me.Label3)
        Me.GlobPan.Controls.Add(Me.txt3)
        Me.GlobPan.Controls.Add(Me.Label2)
        Me.GlobPan.Controls.Add(Me.txt1)
        Me.GlobPan.Controls.Add(Me.Label1)
        Me.GlobPan.Controls.Add(Me.DGV)
        Me.GlobPan.Location = New System.Drawing.Point(25, 39)
        Me.GlobPan.Name = "GlobPan"
        Me.GlobPan.Size = New System.Drawing.Size(639, 396)
        Me.GlobPan.TabIndex = 70
        '
        'txtTotal
        '
        Me.txtTotal.AutoSize = True
        Me.txtTotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold)
        Me.txtTotal.Location = New System.Drawing.Point(443, 369)
        Me.txtTotal.Name = "txtTotal"
        Me.txtTotal.Size = New System.Drawing.Size(17, 18)
        Me.txtTotal.TabIndex = 78
        Me.txtTotal.Text = "0"
        Me.txtTotal.Visible = False
        '
        'labTotal
        '
        Me.labTotal.AutoSize = True
        Me.labTotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold)
        Me.labTotal.Location = New System.Drawing.Point(381, 369)
        Me.labTotal.Name = "labTotal"
        Me.labTotal.Size = New System.Drawing.Size(56, 18)
        Me.labTotal.TabIndex = 77
        Me.labTotal.Text = "Total :"
        Me.labTotal.Visible = False
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Tai Le", 9.75!, System.Drawing.FontStyle.Bold)
        Me.Label5.Location = New System.Drawing.Point(53, 369)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(81, 16)
        Me.Label5.TabIndex = 75
        Me.Label5.Text = "Prix(MAD) :"
        '
        'txt6
        '
        Me.txt6.Location = New System.Drawing.Point(201, 369)
        Me.txt6.Name = "txt6"
        Me.txt6.Size = New System.Drawing.Size(55, 20)
        Me.txt6.TabIndex = 74
        '
        'txt5
        '
        Me.txt5.Location = New System.Drawing.Point(140, 369)
        Me.txt5.Name = "txt5"
        Me.txt5.Size = New System.Drawing.Size(55, 20)
        Me.txt5.TabIndex = 73
        '
        'txt4
        '
        Me.txt4.FormattingEnabled = True
        Me.txt4.Location = New System.Drawing.Point(433, 339)
        Me.txt4.Name = "txt4"
        Me.txt4.Size = New System.Drawing.Size(187, 21)
        Me.txt4.TabIndex = 72
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Tai Le", 9.75!, System.Drawing.FontStyle.Bold)
        Me.Label4.Location = New System.Drawing.Point(339, 341)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(88, 16)
        Me.Label4.TabIndex = 71
        Me.Label4.Text = "Fournisseur :"
        '
        'txt2
        '
        Me.txt2.FormattingEnabled = True
        Me.txt2.Location = New System.Drawing.Point(433, 312)
        Me.txt2.Name = "txt2"
        Me.txt2.Size = New System.Drawing.Size(187, 21)
        Me.txt2.TabIndex = 70
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Tai Le", 9.75!, System.Drawing.FontStyle.Bold)
        Me.Label3.Location = New System.Drawing.Point(336, 314)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(91, 16)
        Me.Label3.TabIndex = 69
        Me.Label3.Text = "Designation :"
        '
        'txt3
        '
        Me.txt3.FormattingEnabled = True
        Me.txt3.Location = New System.Drawing.Point(143, 339)
        Me.txt3.Name = "txt3"
        Me.txt3.Size = New System.Drawing.Size(187, 21)
        Me.txt3.TabIndex = 68
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Tai Le", 9.75!, System.Drawing.FontStyle.Bold)
        Me.Label2.Location = New System.Drawing.Point(62, 341)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(75, 16)
        Me.Label2.TabIndex = 67
        Me.Label2.Text = "Categorie :"
        '
        'txt1
        '
        Me.txt1.FormattingEnabled = True
        Me.txt1.Location = New System.Drawing.Point(143, 312)
        Me.txt1.Name = "txt1"
        Me.txt1.Size = New System.Drawing.Size(187, 21)
        Me.txt1.TabIndex = 66
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Tai Le", 9.75!, System.Drawing.FontStyle.Bold)
        Me.Label1.Location = New System.Drawing.Point(19, 314)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(118, 16)
        Me.Label1.TabIndex = 65
        Me.Label1.Text = "Numero de serie :"
        '
        'DGV
        '
        Me.DGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGV.Location = New System.Drawing.Point(39, 6)
        Me.DGV.Name = "DGV"
        Me.DGV.Size = New System.Drawing.Size(560, 290)
        Me.DGV.TabIndex = 64
        '
        'b1
        '
        Me.b1.Font = New System.Drawing.Font("Bahnschrift SemiCondensed", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.b1.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.b1.Location = New System.Drawing.Point(16, 6)
        Me.b1.Name = "b1"
        Me.b1.Size = New System.Drawing.Size(165, 31)
        Me.b1.TabIndex = 71
        Me.b1.Text = "Parametre"
        Me.b1.UseVisualStyleBackColor = True
        '
        'b2
        '
        Me.b2.Font = New System.Drawing.Font("Bahnschrift SemiCondensed", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.b2.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.b2.Location = New System.Drawing.Point(181, 6)
        Me.b2.Name = "b2"
        Me.b2.Size = New System.Drawing.Size(165, 31)
        Me.b2.TabIndex = 72
        Me.b2.Text = "Commande"
        Me.b2.UseVisualStyleBackColor = True
        '
        'b3
        '
        Me.b3.Font = New System.Drawing.Font("Bahnschrift SemiCondensed", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.b3.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.b3.Location = New System.Drawing.Point(346, 6)
        Me.b3.Name = "b3"
        Me.b3.Size = New System.Drawing.Size(165, 31)
        Me.b3.TabIndex = 73
        Me.b3.Text = "Analytique"
        Me.b3.UseVisualStyleBackColor = True
        '
        'b4
        '
        Me.b4.BackColor = System.Drawing.Color.Gainsboro
        Me.b4.Font = New System.Drawing.Font("Bahnschrift SemiCondensed", 12.0!, System.Drawing.FontStyle.Bold)
        Me.b4.Location = New System.Drawing.Point(511, 6)
        Me.b4.Name = "b4"
        Me.b4.Size = New System.Drawing.Size(165, 31)
        Me.b4.TabIndex = 74
        Me.b4.Text = "Deconnecter"
        Me.b4.UseVisualStyleBackColor = False
        '
        'SalesPage
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(693, 545)
        Me.Controls.Add(Me.b4)
        Me.Controls.Add(Me.pp)
        Me.Controls.Add(Me.b3)
        Me.Controls.Add(Me.b2)
        Me.Controls.Add(Me.b1)
        Me.Controls.Add(Me.p1)
        Me.Controls.Add(Me.p2)
        Me.Controls.Add(Me.GlobPan)
        Me.Name = "SalesPage"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Ventes"
        Me.pp.ResumeLayout(False)
        Me.p1.ResumeLayout(False)
        Me.p2.ResumeLayout(False)
        Me.p2.PerformLayout()
        Me.GlobPan.ResumeLayout(False)
        Me.GlobPan.PerformLayout()
        CType(Me.DGV, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents pp As Panel
    Friend WithEvents commandBu As Button
    Friend WithEvents buVen As Button
    Friend WithEvents p1 As Panel
    Friend WithEvents p2 As Panel
    Friend WithEvents Label8 As Label
    Friend WithEvents DTP As DateTimePicker
    Friend WithEvents Label7 As Label
    Friend WithEvents txtNom As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents txtUserID As TextBox
    Friend WithEvents valideBu As Button
    Friend WithEvents cancelBu As Button
    Friend WithEvents insertBu As Button
    Friend WithEvents GlobPan As Panel
    Friend WithEvents Label5 As Label
    Friend WithEvents txt6 As TextBox
    Friend WithEvents txt5 As TextBox
    Friend WithEvents txt4 As ComboBox
    Friend WithEvents Label4 As Label
    Friend WithEvents txt2 As ComboBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txt3 As ComboBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txt1 As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents DGV As DataGridView
    Friend WithEvents labTotal As Label
    Friend WithEvents txtTotal As Label
    Friend WithEvents b1 As Button
    Friend WithEvents b2 As Button
    Friend WithEvents b3 As Button
    Friend WithEvents b4 As Button
End Class
