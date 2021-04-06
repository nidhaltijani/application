Public Class Form1

    Private Sub Form1_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Label3_Click(sender As System.Object, e As System.EventArgs) Handles Label3.Click

    End Sub

    Private Sub Label4_Click(sender As System.Object, e As System.EventArgs) Handles Label4.Click

    End Sub


    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        If TextBox1.Text = "" And TextBox2.Text = "" Then
            MessageBox.Show("vous devez taper vos coordonnées")

        ElseIf TextBox1.Text = "" Then
            MessageBox.Show("vous devez taper votre CIN")
        ElseIf TextBox1.Text.Length <> 8 Then
            MessageBox.Show("le numero de CIN doit contenir 8 chiffres!")
        ElseIf TextBox2.Text = "" Then
            MessageBox.Show("vous devez taper votre mot de passe")
        ElseIf TextBox1.Text.Length <> 0 And TextBox2.Text.Length <> 0 Then
            Form10.Show()
            Me.Hide()

        End If
    End Sub

    Private Sub Button2_Click(sender As System.Object, e As System.EventArgs) Handles Button2.Click
        Form2.Show()
        Me.Hide()

    End Sub

    Private Sub TextBox1_TextChanged(sender As System.Object, e As System.EventArgs) Handles TextBox1.TextChanged

    End Sub

    Private Sub TextBox1_KeyPress(sender As System.Object, e As System.Windows.Forms.KeyPressEventArgs) Handles TextBox1.KeyPress
        If (Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57) And Asc(e.KeyChar) <> 8 Then
            e.KeyChar = ""
        End If
    End Sub

    Private Sub TextBox2_TextChanged(sender As System.Object, e As System.EventArgs) Handles TextBox2.TextChanged

    End Sub


    Private Sub TextBox2_Leave(sender As System.Object, e As System.EventArgs) Handles TextBox2.Leave
        If (Len(TextBox2.Text) < 6) Then
            MsgBox("mot de passe doit dépasser 6 caractères", vbInformation, "ATTENTION!")
        End If
    End Sub
    Dim place1 As String "c:\projet peven\peven.txt"
    Private Sub command1_click()
        Dim tmp As String
        Dim CIN As String
        Dim mdps As String
        CIN = TextBox1.Text
        mdps = TextBox2.Text
        Open place1 for input as 1
        Do Until EOF(1)
            LineInput#(1, tmp)
            If ((InStr(tmp, CIN)) > 0) Then
                MsgBox("Pardon vous n'êtes pas encore inscrit")
            End If
        Loop
        Close#(1)

    End Sub
End Class
