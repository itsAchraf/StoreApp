<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class OrderPage
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
        Me.DGV = New System.Windows.Forms.DataGridView()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txt1 = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txt2 = New System.Windows.Forms.ComboBox()
        Me.b3 = New System.Windows.Forms.Button()
        Me.b2 = New System.Windows.Forms.Button()
        Me.b1 = New System.Windows.Forms.Button()
        Me.p = New System.Windows.Forms.Panel()
        Me.b4 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        CType(Me.DGV, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.p.SuspendLayout()
        Me.SuspendLayout()
        '
        'DGV
        '
        Me.DGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGV.Location = New System.Drawing.Point(24, 43)
        Me.DGV.Name = "DGV"
        Me.DGV.Size = New System.Drawing.Size(742, 286)
        Me.DGV.TabIndex = 0
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Bahnschrift SemiCondensed", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(63, 17)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(59, 18)
        Me.Label9.TabIndex = 60
        Me.Label9.Text = "Client ID :"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txt1
        '
        Me.txt1.FormattingEnabled = True
        Me.txt1.Location = New System.Drawing.Point(124, 16)
        Me.txt1.Name = "txt1"
        Me.txt1.Size = New System.Drawing.Size(211, 21)
        Me.txt1.TabIndex = 59
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Bahnschrift SemiCondensed", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(352, 17)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(78, 18)
        Me.Label1.TabIndex = 62
        Me.Label1.Text = "Commande :"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txt2
        '
        Me.txt2.FormattingEnabled = True
        Me.txt2.Location = New System.Drawing.Point(431, 16)
        Me.txt2.Name = "txt2"
        Me.txt2.Size = New System.Drawing.Size(211, 21)
        Me.txt2.TabIndex = 61
        '
        'b3
        '
        Me.b3.Font = New System.Drawing.Font("Microsoft Tai Le", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.b3.Location = New System.Drawing.Point(269, 6)
        Me.b3.Name = "b3"
        Me.b3.Size = New System.Drawing.Size(127, 37)
        Me.b3.TabIndex = 65
        Me.b3.Text = "Livrée"
        Me.b3.UseVisualStyleBackColor = True
        '
        'b2
        '
        Me.b2.BackColor = System.Drawing.Color.Gainsboro
        Me.b2.Font = New System.Drawing.Font("Microsoft Tai Le", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.b2.Location = New System.Drawing.Point(142, 6)
        Me.b2.Name = "b2"
        Me.b2.Size = New System.Drawing.Size(127, 37)
        Me.b2.TabIndex = 64
        Me.b2.Text = "Prête"
        Me.b2.UseVisualStyleBackColor = False
        '
        'b1
        '
        Me.b1.BackColor = System.Drawing.Color.Gainsboro
        Me.b1.Font = New System.Drawing.Font("Microsoft Tai Le", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.b1.Location = New System.Drawing.Point(15, 6)
        Me.b1.Name = "b1"
        Me.b1.Size = New System.Drawing.Size(127, 37)
        Me.b1.TabIndex = 63
        Me.b1.Text = "En Cours"
        Me.b1.UseVisualStyleBackColor = False
        '
        'p
        '
        Me.p.Controls.Add(Me.b4)
        Me.p.Controls.Add(Me.b1)
        Me.p.Controls.Add(Me.b3)
        Me.p.Controls.Add(Me.b2)
        Me.p.Location = New System.Drawing.Point(114, 335)
        Me.p.Name = "p"
        Me.p.Size = New System.Drawing.Size(556, 50)
        Me.p.TabIndex = 66
        '
        'b4
        '
        Me.b4.Font = New System.Drawing.Font("Microsoft Tai Le", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.b4.Location = New System.Drawing.Point(396, 6)
        Me.b4.Name = "b4"
        Me.b4.Size = New System.Drawing.Size(127, 37)
        Me.b4.TabIndex = 66
        Me.b4.Text = "Annulée"
        Me.b4.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.Gainsboro
        Me.Button1.Font = New System.Drawing.Font("Microsoft Tai Le", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(321, 391)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(127, 37)
        Me.Button1.TabIndex = 67
        Me.Button1.Text = "Fermer"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'OrderPage
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 463)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.p)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txt2)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.txt1)
        Me.Controls.Add(Me.DGV)
        Me.Name = "OrderPage"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Commande"
        CType(Me.DGV, System.ComponentModel.ISupportInitialize).EndInit()
        Me.p.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DGV As DataGridView
    Friend WithEvents Label9 As Label
    Friend WithEvents txt1 As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents txt2 As ComboBox
    Friend WithEvents b3 As Button
    Friend WithEvents b2 As Button
    Friend WithEvents b1 As Button
    Friend WithEvents p As Panel
    Friend WithEvents b4 As Button
    Friend WithEvents Button1 As Button
End Class
