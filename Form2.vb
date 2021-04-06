Imports System.IO
Public Class Form2
    Private Sub Label3_Click(sender As System.Object, e As System.EventArgs) Handles Label3.Click

    End Sub

    Private Sub ListBox1_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles ListBox1.SelectedIndexChanged

    End Sub

    Private Sub TextBox1_TextChanged(sender As System.Object, e As System.EventArgs) Handles TextBox1.TextChanged

    End Sub

    Private Sub Form2_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        If TextBox1.Text.Length = 0 Or TextBox7.Text.Length = 0 Or TextBox5.Text.Length = 0 Or TextBox4.Text.Length = 0 Or TextBox3.Text.Length = 0 Then
            MessageBox.Show("vous devez saisir tous les coordonnées nécessaires")
        ElseIf TextBox1.Text = "" Then
            MessageBox.Show("vous devez saisir votre nom")
        ElseIf TextBox7.Text = "" Then
            MessageBox.Show("vous devez saisir votre prenom")
        ElseIf TextBox5.Text = "" Then
            MessageBox.Show("vous devez taper votre mot de passe")
        ElseIf TextBox4.Text = "" Then
            MessageBox.Show("vous devez saisir votre numero CIN")
        ElseIf TextBox4.Text.Length <> 8 Then
            MessageBox.Show("votre CIN doit etre composé de 8 chiffres")
        ElseIf TextBox1.Text.Length <> 0 And TextBox7.Text.Length <> 0 And TextBox5.Text.Length <> 0 And TextBox4.Text.Length <> 0 And TextBox3.Text.Length <> 0 And TextBox2.Text.Length <> 0 Then
            Form4.Show()
            Me.Hide()
        ElseIf TextBox2.Text = "" Then
            MessageBox.Show("vous devez saisir votre numero de permis")
        End If
        Dim fs As New FileStream("c:\projet peven\peven.txt", FileMode.Append, FileAccess.Write)
        Dim sw As New StreamWriter(fs)
        sw.WriteLine(TextBox4.Text & "#" & TextBox5.Text & "#" & TextBox1.Text & "#" & TextBox7.Text & "#" & TextBox3.Text & "#" & TextBox2.Text)
        sw.Flush()
        sw.Close()
        fs.Close()
    End Sub

    Private Sub TextBox4_KeyPress(sender As System.Object, e As System.Windows.Forms.KeyPressEventArgs) Handles TextBox4.KeyPress
        If (Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57) And Asc(e.KeyChar) <> 8 Then
            e.KeyChar = ""
        End If
    End Sub

    Private Sub TextBox3_KeyPress(sender As System.Object, e As System.Windows.Forms.KeyPressEventArgs) Handles TextBox3.KeyPress
        If (Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57) And Asc(e.KeyChar) <> 8 Then
            e.KeyChar = ""
        End If
    End Sub

    Private Sub TextBox2_TextChanged(sender As System.Object, e As System.EventArgs) Handles TextBox2.TextChanged

    End Sub

    Private Sub TextBox1_KeyPress(sender As System.Object, e As System.Windows.Forms.KeyPressEventArgs) Handles TextBox1.KeyPress
        If (Asc(e.KeyChar) < 65 Or Asc(e.KeyChar) > 127) And Asc(e.KeyChar) <> 8 Then
            e.KeyChar = ""
        End If
    End Sub

   
    Private Sub TextBox5_Leave(sender As System.Object, e As System.EventArgs) Handles TextBox5.Leave
        If (Len(TextBox5.Text) < 6) Then
            MsgBox("mot de passe doit dépasser 6 caractères", vbInformation, "ATTENTION!")
        End If
    End Sub
    Private Sub TextBox7_KeyPress(sender As System.Object, e As System.Windows.Forms.KeyPressEventArgs) Handles TextBox7.KeyPress
        If (Asc(e.KeyChar) < 65 Or Asc(e.KeyChar) > 127) And Asc(e.KeyChar) <> 8 Then
            e.KeyChar = ""
        End If
    End Sub
    Private Sub TextBox4_Leave(sender As System.Object, e As System.EventArgs) Handles TextBox4.Leave
        If (Len(TextBox4.Text) <> 8) Then
            MsgBox("votre numero CIN doit être composé de 8 chiffres", vbInformation, "ATTENTION!")
        End If
    End Sub
    Private Sub TextBox3_Leave(sender As System.Object, e As System.EventArgs) Handles TextBox3.Leave
        If (Len(TextBox3.Text) <> 8) Then
            MsgBox("votre numero de téléphone doit être composé de 8 chiffres", vbInformation, "ATTENTION!")
        End If
    End Sub
End Class