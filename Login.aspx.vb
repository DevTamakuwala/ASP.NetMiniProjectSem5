Imports System.Data
Imports System.Data.SqlClient
Partial Class _Default
    Inherits System.Web.UI.Page

    Dim cn As New SqlConnection("Data Source=.\SQLEXPRESS;AttachDbFilename=D:\Study\Sem-5\ASP.Net\WebSite1\App_Data\Cloths.mdf;Integrated Security=True;User Instance=True")
    Dim ds As New DataSet()
    Dim cmd As SqlCommand
    Dim adp As SqlDataAdapter
    Dim dr As SqlDataReader

    Protected Sub btnLogin_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnLogin.Click
        cn.Open()
        cmd = New SqlCommand("select * from tblUser where username='" + txtUser.Text + "' and password='" + txtPass.Text + "'", cn)
        dr = cmd.ExecuteReader()
        Dim httpCookie As New HttpCookie("Username")
        httpCookie.Values.Add("User Name", txtUser.Text)
        httpCookie.Expires.AddDays(1)
        Response.Cookies.Add(httpCookie)
        If dr.HasRows Then
            dr.Read()
            Session("uid") = dr("userId")
            Session("uname") = dr("username")
            Session("name") = dr("name")
            Response.Redirect("HomePage.aspx")
        Else
            lblErrorMsg.Text = "Invalid Username or Passsword"
        End If
        cn.Close()
    End Sub

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If Session("uname") <> Nothing Then
            Response.Redirect("HomePage.aspx")
        End If
        Dim cookie As HttpCookie = Request.Cookies("Username")
    End Sub
End Class
