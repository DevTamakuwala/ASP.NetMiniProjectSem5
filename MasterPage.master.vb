
Partial Class MasterPage
    Inherits System.Web.UI.MasterPage

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        lblWelcome.Text = Session("name").ToString()

        If Not Session("uname").ToString() = "admin" Then
            lbtnAddNew.Visible = False
            btnEdt.Visible = False
            'btnOrders.Visible = False
        End If
    End Sub
End Class

