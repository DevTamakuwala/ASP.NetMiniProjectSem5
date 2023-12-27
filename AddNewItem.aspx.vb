Imports System.Data
Imports System.Data.SqlClient
Imports System.IO
Partial Class AddNewItem
    Inherits System.Web.UI.Page

    Dim cn As New SqlConnection("Data Source=.\SQLEXPRESS;AttachDbFilename=D:\Study\Sem-5\ASP.Net\WebSite1\App_Data\Cloths.mdf;Integrated Security=True;User Instance=True")
    Dim ds As New DataSet()
    Dim cmd As SqlCommand
    Dim adp As SqlDataAdapter
    Protected Sub btnInsert_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnInsert.Click
        cn.Open()

        fup.SaveAs(Server.MapPath("~/images/") + Path.GetFileName(fup.FileName))

        cmd = New SqlCommand("insert into tblProduct values('" + txtBname.Text + "','" + txtAname.Text + "','" + txtDesc.Text + "','" + txtPrice.Text + "','" + fup.FileName + "')", cn)
        cmd.ExecuteNonQuery()
        cn.Close()
        Response.Redirect("HomePage.aspx")
        clear()
    End Sub
    Sub clear()
        txtAname.Text = ""
        txtBname.Text = ""
        txtPrice.Text = ""
    End Sub
    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If Session("uname") Is Nothing Then
            Response.Redirect("Login.aspx")
        End If
    End Sub
End Class
