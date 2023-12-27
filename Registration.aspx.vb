Imports System.Data
Imports System.Data.SqlClient
Partial Class Registration
    Inherits System.Web.UI.Page

    Dim cn As New SqlConnection("Data Source=.\SQLEXPRESS;AttachDbFilename=D:\Study\Sem-5\ASP.Net\WebSite1\App_Data\Cloths.mdf;Integrated Security=True;User Instance=True")
    Dim ds As New DataSet()
    Dim cmd As SqlCommand
    Dim adp As SqlDataAdapter
    Dim dr As SqlDataReader

    Protected Sub btnReg_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnReg.Click
        RequiredFieldValidator2.Visible = True
        RegularExpressionValidator1.Visible = True
        CompareValidator1.Visible=True
        Dim x As Integer = 0
        Dim gen As String

        If rbtnFemale.Checked Then
            gen = "Female"
        ElseIf rbtnMale.Checked Then
            gen = "Male"
        Else
            gen = "Not specified"
        End If

        cn.Open()
        cmd = New SqlCommand("select username from tblUser where username='" + txtUName.Text + "'", cn)
        dr = cmd.ExecuteReader()
        If dr.HasRows Then
            dr.Close()
            cn.Close()
            lblErrorMsg.Text = "Username is laready used..!! Please select another"
        Else
            dr.Close()
            cmd = New SqlCommand("insert into tblUser values('" + txtUName.Text + "','" + txtPass.Text + "','" + txtEmail.Text + "','" + gen + "','" + txtName.Text + "')", cn)
            x = cmd.ExecuteNonQuery()
            If x > 0 Then
                Response.Redirect("Login.aspx")
            End If
        End If
        cn.Close()
    End Sub

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If Session("uname") <> Nothing Then
            Response.Redirect("HomePage.aspx")
        End If
    End Sub
End Class
