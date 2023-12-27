Imports System.Data
Imports System.Data.SqlClient
Imports System.IO
Partial Class HomePage
    Inherits System.Web.UI.Page

    Dim cn As New SqlConnection("Data Source=.\SQLEXPRESS;AttachDbFilename=D:\Study\Sem-5\ASP.Net\WebSite1\App_Data\Cloths.mdf;Integrated Security=True;User Instance=True")
    Dim ds As New DataSet()
    Dim cmd As SqlCommand
    Dim adp As SqlDataAdapter

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If Session("uname") Is Nothing Then
            Response.Redirect("Login.aspx")
        End If

        If Not Request.QueryString("did") Is Nothing Then
            Dim id As String
            id = Request.QueryString("did")
            cn.Open()
            cmd = New SqlCommand("delete from tblProduct where productid='" + id + "'", cn)
            cmd.ExecuteNonQuery()
            cn.Close()
            fillrepeater()
        End If

        fillgrid()
        fillrepeater()
    End Sub

    Sub fillgrid()
        ds.Clear()
        cn.Open()
        cmd = New SqlCommand("select * from tblProduct", cn)
        adp = New SqlDataAdapter(cmd)
        adp.Fill(ds)
        cn.Close()
    End Sub
    Protected Sub btnSort_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnSort.Click
        ds.Clear()
        cn.Open()
        cmd = New SqlCommand("select * from tblProduct order by price", cn)
        adp = New SqlDataAdapter(cmd)
        adp.Fill(ds)
        cn.Close()

        rptrBook.DataSource = ds
        rptrBook.DataBind()
    End Sub

    Protected Sub btnSortName_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnSortName.Click
        ds.Clear()
        cn.Open()
        cmd = New SqlCommand("select * from tblProduct order by bname", cn)
        adp = New SqlDataAdapter(cmd)
        adp.Fill(ds)
        cn.Close()

        rptrBook.DataSource = ds
        rptrBook.DataBind()
    End Sub

    Protected Sub btnSortDesc_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnSortDesc.Click
        ds.Clear()
        cn.Open()
        cmd = New SqlCommand("select * from tblProduct order by price desc", cn)
        adp = New SqlDataAdapter(cmd)
        adp.Fill(ds)
        cn.Close()

        rptrBook.DataSource = ds
        rptrBook.DataBind()
    End Sub

    Protected Sub btnNameSearch_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnNameSearch.Click
        ds.Clear()
        cn.Open()
        cmd = New SqlCommand("select * from tblProduct where pname like '%" + txtSearchName.Text + "%'", cn)
        adp = New SqlDataAdapter(cmd)
        adp.Fill(ds)
        cn.Close()

        rptrBook.DataSource = ds
        rptrBook.DataBind()
    End Sub

    Protected Sub btnReset_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnReset.Click
        fillgrid()
    End Sub

    Protected Sub btnSeacrhPrice_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnSeacrhPrice.Click
        Dim str As String
        str = "select * from tblProduct "

        If txtMaxPrice.Text <> "" And txtMinPrice.Text <> "" Then
            str = str + " where price between '" + txtMinPrice.Text + "' and '" + txtMaxPrice.Text + "'"
        End If

        If txtMaxPrice.Text = "" And txtMinPrice.Text <> "" Then
            str = str + " where price > '" + txtMinPrice.Text + "'"
        End If

        If txtMaxPrice.Text <> "" And txtMinPrice.Text = "" Then
            str = str + " where price < '" + txtMaxPrice.Text + "'"
        End If

        ds.Clear()
        cn.Open()
        cmd = New SqlCommand(str, cn)
        adp = New SqlDataAdapter(cmd)
        adp.Fill(ds)
        cn.Close()

        rptrBook.DataSource = ds
        rptrBook.DataBind()
    End Sub
    Sub fillrepeater()
        ds.Clear()
        cn.Open()
        cmd = New SqlCommand("select * from tblProduct", cn)
        adp = New SqlDataAdapter(cmd)
        adp.Fill(ds)
        cn.Close()
        rptrBook.DataSource = ds
        rptrBook.DataBind()
    End Sub
End Class
