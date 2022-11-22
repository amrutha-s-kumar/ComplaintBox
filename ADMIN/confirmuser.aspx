<%@ Page Title="" Language="C#" MasterPageFile="~/ADMIN/admin.Master" AutoEventWireup="true" CodeBehind="confirmuser.aspx.cs" Inherits="ComplaintBox.ADMIN.confirmuser" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h2>User Confirmation</h2>
          



    <form id="form1" >
        
            <asp:GridView ID="GridView1" runat="server" DataKeyNames="lid" OnRowDeleting="GridView1_RowDeleting">
                <Columns>
                    <asp:CommandField HeaderText="confirm" ShowDeleteButton="True" DeleteText="confirm" />
                    
                </Columns>
                
            </asp:GridView>
    
        <div>
        </div>
        </form>
</asp:Content>
