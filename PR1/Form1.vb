Imports System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel

Public Class Form1

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click
        Label1.Text = "Nombre:"
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click

        Dim username, password As String
        username = "admin"
        password = "12345"


        If txtUsername.Text = username And txtPassword.Text = password Then
            MessageBox.Show("Validacion Correcta!!", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Me.Hide()
            Form2.Show()

        Else

            MessageBox.Show("Usuario o contraseña incorrectos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Application.Exit()
    End Sub
End Class
