Imports System.Windows.Forms.VisualStyles.VisualStyleElement
Imports MySql.Data.MySqlClient
Imports Mysqlx.XDevAPI

Public Class Form1
    Dim con As MySqlConnection
    Dim cmd As MySqlCommand

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        Form2.Show()
        Me.Hide()
        txtUN.Text = ""
        txtPW.Text = ""
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click



        If String.IsNullOrWhiteSpace(txtUN.Text) Then
            MessageBox.Show("Please Input Username!", "Try Again", MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
            txtUN.Focus()
        End If

        If String.IsNullOrWhiteSpace(txtUN.Text) Then
            MessageBox.Show("Please Input Username!", "Try Again", MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
            txtUN.Focus()
        End If

        con = New MySqlConnection("Server=localhost;Database=urbanfarming;username=root;password=")
        cmd = New MySqlCommand("SELECT * FRoM `login` WHERE `username` = @username AND `password` = @password", con)
        cmd.Parameters.AddWithValue("@username", txtUN.Text)
        cmd.Parameters.AddWithValue("@password", txtPW.Text)

        Dim adapter As New MySqlDataAdapter(cmd)

        Dim table As New DataTable

        adapter.Fill(table)

        If table.Rows.Count() = 0 Then
            MessageBox.Show("Username or Password are Invalid")
        Else
            MessageBox.Show("Login Successfully!")
            Form3.Show()
            Me.Hide()
        End If
    End Sub

    Private Sub txtUN_TextChanged(sender As Object, e As EventArgs) Handles txtUN.TextChanged

    End Sub

    Private Sub txtPW_TextChanged(sender As Object, e As EventArgs) Handles txtPW.TextChanged

    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs)

    End Sub

    Private Sub PictureBox2_Click_1(sender As Object, e As EventArgs)

    End Sub
End Class
