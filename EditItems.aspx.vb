Imports System.Data
Imports System.Data.SqlClient
Imports System.IO
Partial Class EditItems
    Inherits System.Web.UI.Page
    Dim cn As New SqlConnection("Data Source=.\SQLEXPRESS;AttachDbFilename=D:\Study\Sem-5\ASP.Net\WebSite1\App_Data\Cloths.mdf;Integrated Security=True;User Instance=True")
    Dim ds As New DataSet()
    Dim cmd As SqlCommand
    Dim dr As SqlDataReader
    Dim adp As SqlDataAdapter
    Dim pid As String


    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If Session("uname") Is Nothing Then
            Response.Redirect("Login.aspx")
        End If
        If Not Request.QueryString("uid") Is Nothing Then
            pid = Request.QueryString("uid")
            cn.Open()
            cmd = New SqlCommand("select * from tblProduct where pid='" + pid + "'", cn)
            dr = cmd.ExecuteReader()
            dr.Read()
            txtPid.Text = dr("pid")
            txtPid.Enabled = False
            cn.Close()
            fillrepeater1()
        End If
        If Not Request.QueryString("did") Is Nothing Then
            pid = Request.QueryString("did")
            cn.Open()
            cmd = New SqlCommand("delete from tblProduct where pid='" + pid + "'", cn)
            cmd.ExecuteNonQuery()
            cn.Close()
        End If
        fillrepeater()
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

    Sub fillrepeater1()
        ds.Clear()
        cn.Open()
        cmd = New SqlCommand("select * from tblProduct where pid='" + pid + "'", cn)
        adp = New SqlDataAdapter(cmd)
        adp.Fill(ds)
        cn.Close()
        Repeater1.DataSource = ds
        Repeater1.DataBind()
    End Sub


    Sub clear()
        txtPid.Text = ""
        txtPname.Text = ""
        txtCname.Text = ""
        txtDesc.Text = ""
        txtPrice.Text = ""
    End Sub

    Protected Sub btnUpdate_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnUpdate.Click
        Dim img As String

        cn.Open()
        cmd = New SqlCommand("select image from tblProduct where pid='" + pid + "'", cn)
        dr = cmd.ExecuteReader()
        dr.Read()
        If (fup.FileName <> "") Then
            img = fup.FileName
            fup.SaveAs(Server.MapPath("~/images/") + Path.GetFileName(img))
            Dim tmpName As String = fup.FileName

            Try
                If (File.Exists(tmpName)) Then
                    File.Copy(tmpName, "images\" & img)
                Else
                    Throw New Exception("Cannot upload image")
                End If

                File.Delete("images\" & dr("image"))
            Catch ex As Exception
                Response.Write("An error occurred: " & ex.Message)
            End Try
        Else
            fup.SaveAs(Server.MapPath("~/images/") + Path.GetFileName(fup.FileName))
        End If
        cn.Close()


        cn.Open()
        cmd = New SqlCommand("update tblProduct set pname='" + txtPname.Text + "', company='" + txtCname.Text + "', description='" + txtDesc.Text + "', price='" + txtPrice.Text + "', image='" + fup.FileName + "' where pid='" + txtPid.Text + "'", cn)
        cmd.ExecuteNonQuery()
        cn.Close()
        fillrepeater()
        clear()
        Response.Redirect("HomePage.aspx")
    End Sub
End Class
