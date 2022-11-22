<%@ Page Title="" Language="C#" MasterPageFile="~/ADMIN/admin.Master" AutoEventWireup="true" CodeBehind="productreg.aspx.cs" Inherits="ComplaintBox.ADMIN.productreg" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    
    <h3>Add product here!!!!</h3>
    

    <table bgcolor="white" align="center" class="auto-style1">


     <h1><center>PRODUCT REGISTRATION</center></h1> 
                
                 
                <tr>  
                    <td>Product Name :</td>  
                    <td>  
                        <asp:TextBox ID="name" runat="server" ></asp:TextBox>  
                    </td>  
                </tr>
                 
                <tr>  
                    <td>Description :</td>  
                    <td>  
                        <asp:TextBox ID="description" runat="server"></asp:TextBox>  
                    </td>  
                </tr>  
        
        
                <tr>  
                    <td class="auto-style1">  
                      <center> <asp:Button   ID="Button1" runat="server" Text="ADD" OnClick="Button1_Click"/>  </center> 
                    </td>  
                </tr>
           


        <tr>
                    <td colspan="2">
                        <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" DataKeyNames="pid" OnRowCancelingEdit="GridView1_RowCancelingEdit" OnRowDeleting="GridView1_RowDeleting" OnRowEditing="GridView1_RowEditing" OnRowUpdating="GridView1_RowUpdating"   >
                            <Columns>
                                <asp:BoundField DataField="pid" HeaderText="ID" />
                                <asp:BoundField DataField="pname" HeaderText="product name" />
                                <asp:BoundField DataField="pdescription" HeaderText="product Description" />
                                <asp:CommandField HeaderText="Edit" ShowEditButton="True" />
                                <asp:CommandField HeaderText="Delete" ShowDeleteButton="True" />
                               
                                   
                            </Columns>
                        </asp:GridView>
                    </td>
                </tr>

            </table>

</asp:Content>
