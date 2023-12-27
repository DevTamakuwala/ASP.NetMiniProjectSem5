Imports System.Data
Imports System.Data.SqlClient
Partial Class MyOrdesrs
    Inherits System.Web.UI.Page
    Dim cn As New SqlConnection("Data Source=.\SQLEXPRESS;AttachDbFilename=D:\Study\Sem-5\ASP.Net\WebSite1\App_Data\Cloths.mdf;Integrated Security=True;User Instance=True")
    Dim ds As New DataSet()
    Dim cmd As SqlCommand
    Dim adp As SqlDataAdapter
    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If Session("uname") Is Nothing Then
            Response.Redirect("Login.aspx")
        End If
        fillrepater()
    End Sub

    Sub fillrepater()
        Dim qry As String
        If Session("name") <> "Admin" Then
            qry = "select * from tblOrder o,tblProduct p, tblUser u where p.pid=o.productId and o.userId = u.userId and o.userid='" + Session("uid").ToString() + "'"
        Else
            qry = "select * from tblOrder o,tblProduct p, tblUser u where p.pid=o.productId and o.userId = u.userId"
        End If
        ds.Clear()
        cn.Open()
        cmd = New SqlCommand(qry, cn)
        adp = New SqlDataAdapter(cmd)
        adp.Fill(ds)
        cn.Close()

        myorders.DataSource = ds
        myorders.DataBind()
    End Sub
End Class
