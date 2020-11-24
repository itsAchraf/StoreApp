<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ConnectionPage
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
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txt2 = New System.Windows.Forms.TextBox()
        Me.txt1 = New System.Windows.Forms.TextBox()
        Me.b2 = New System.Windows.Forms.Button()
        Me.b1 = New System.Windows.Forms.Button()
        Me.msg = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Tai Le", 9.75!, System.Drawing.FontStyle.Bold)
        Me.Label2.Location = New System.Drawing.Point(40, 105)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(90, 16)
        Me.Label2.TabIndex = 31
        Me.Label2.Text = "mot de passe"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Tai Le", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(58, 80)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(72, 16)
        Me.Label1.TabIndex = 30
        Me.Label1.Text = "Utilisateur"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'txt2
        '
        Me.txt2.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txt2.Location = New System.Drawing.Point(136, 103)
        Me.txt2.Name = "txt2"
        Me.txt2.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txt2.Size = New System.Drawing.Size(187, 20)
        Me.txt2.TabIndex = 29
        '
        'txt1
        '
        Me.txt1.Location = New System.Drawing.Point(136, 78)
        Me.txt1.Name = "txt1"
        Me.txt1.Size = New System.Drawing.Size(187, 20)
        Me.txt1.TabIndex = 28
        '
        'b2
        '
        Me.b2.Font = New System.Drawing.Font("Microsoft Tai Le", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.b2.Location = New System.Drawing.Point(133, 4)
        Me.b2.Name = "b2"
        Me.b2.Size = New System.Drawing.Size(114, 29)
        Me.b2.TabIndex = 55
        Me.b2.Text = "Fermer"
        Me.b2.UseVisualStyleBackColor = True
        '
        'b1
        '
        Me.b1.BackColor = System.Drawing.Color.Gainsboro
        Me.b1.Font = New System.Drawing.Font("Microsoft Tai Le", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.b1.Location = New System.Drawing.Point(13, 4)
        Me.b1.Name = "b1"
        Me.b1.Size = New System.Drawing.Size(114, 29)
        Me.b1.TabIndex = 54
        Me.b1.Text = "Connecter"
        Me.b1.UseVisualStyleBackColor = False
        '
        'msg
        '
        Me.msg.Font = New System.Drawing.Font("Microsoft Tai Le", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.msg.ForeColor = System.Drawing.Color.Red
        Me.msg.Location = New System.Drawing.Point(84, 126)
        Me.msg.Name = "msg"
        Me.msg.Size = New System.Drawing.Size(234, 33)
        Me.msg.TabIndex = 56
        Me.msg.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.b1)
        Me.Panel1.Controls.Add(Me.b2)
        Me.Panel1.Location = New System.Drawing.Point(71, 132)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(261, 48)
        Me.Panel1.TabIndex = 57
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Bahnschrift SemiCondensed", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Blue
        Me.Label3.Location = New System.Drawing.Point(130, 28)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(131, 35)
        Me.Label3.TabIndex = 58
        Me.Label3.Text = "Bienvenue"
        '
        'ConnectionPage
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(392, 231)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.msg)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txt2)
        Me.Controls.Add(Me.txt1)
        Me.Name = "ConnectionPage"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Connection"
        Me.Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents txt2 As TextBox
    Friend WithEvents b2 As Button
    Friend WithEvents b1 As Button
    Friend WithEvents txt1 As TextBox
    Friend WithEvents msg As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label3 As Label
End Class
