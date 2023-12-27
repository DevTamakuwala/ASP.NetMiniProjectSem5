Imports System.Data
Imports System.Data.SqlClient

Partial Class MoreInfo
    Inherits System.Web.UI.Page

    Dim cn As New SqlConnection("Data Source=.\SQLEXPRESS;AttachDbFilename=D:\Study\Sem-5\ASP.Net\WebSite1\App_Data\Cloths.mdf;Integrated Security=True;User Instance=True")
    Dim ds As New DataSet()
    Dim cmd As SqlCommand
    Dim adp As SqlDataAdapter
    Dim dr As SqlDataReader
    Dim pid As Integer

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If Session("uname") Is Nothing Then
            Response.Redirect("Login.aspx")
        End If
        pid = Request.QueryString("pid")

        cn.Open()
        cmd = New SqlCommand("select * from tblProduct where pid=" + pid.ToString(), cn)
        dr = cmd.ExecuteReader()
        dr.Read()
        pimg.ImageUrl = "images/" + dr("image").ToString()
        lblAname.Text = dr("company").ToString()
        lblDesc.Text = dr("description").ToString()
        lblpname.Text = dr("pname").ToString()
        lblPrice.Text = dr("price").ToString()
        cn.Close()
    End Sub

    Protected Sub btnByNow_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnByNow.Click
        cn.Open()
        cmd = New SqlCommand("insert into tblOrder values('" + pid.ToString() + "','" + Session("uid").ToString() + "','" + Now.Date.ToString() + "')", cn)
        cmd.ExecuteNonQuery()
        cn.Close()
        Response.Redirect("MyOrdesrs.aspx")
    End Sub
End Class
