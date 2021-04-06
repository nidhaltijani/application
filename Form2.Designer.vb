<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmwlcm
    Inherits System.Windows.Forms.Form

    'Form remplace la méthode Dispose pour nettoyer la liste des composants.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmwlcm))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.btninscri = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label1.Font = New System.Drawing.Font("Algerian", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(244, 37)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(439, 37)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Bienvenue chez nous!"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(247, 94)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(433, 41)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Avec KNS ne restez jamais en panne! Réservez votre voiture!"
        '
        'Label3
        '
        Me.Label3.Location = New System.Drawing.Point(228, 200)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(120, 22)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Nom d'utilisateur"
        '
        'Label4
        '
        Me.Label4.Location = New System.Drawing.Point(228, 269)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(117, 22)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Mot de passe "
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(404, 200)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(363, 22)
        Me.TextBox1.TabIndex = 4
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(404, 269)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(363, 22)
        Me.TextBox2.TabIndex = 5
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(794, 214)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(194, 60)
        Me.Button1.TabIndex = 6
        Me.Button1.Text = "Se connecter"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.Location = New System.Drawing.Point(144, 405)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(201, 25)
        Me.Label5.TabIndex = 7
        Me.Label5.Text = "Vous n'avez pas de compte ?"
        '
        'btninscri
        '
        Me.btninscri.Location = New System.Drawing.Point(395, 392)
        Me.btninscri.Name = "btninscri"
        Me.btninscri.Size = New System.Drawing.Size(198, 66)
        Me.btninscri.TabIndex = 8
        Me.btninscri.Text = "Inscription"
        Me.btninscri.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(790, 392)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(198, 66)
        Me.Button3.TabIndex = 9
        Me.Button3.Text = "Quitter"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'frmwlcm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.WpfApplication1.My.Resources.Resources.background
        Me.ClientSize = New System.Drawing.Size(1000, 484)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.btninscri)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmwlcm"
        Me.Text = "KNS"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox2 As System.Windows.Forms.TextBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents btninscri As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button
End Class
