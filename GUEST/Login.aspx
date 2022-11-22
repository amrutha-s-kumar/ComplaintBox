<%@ Page Title="" Language="C#" MasterPageFile="~/GUEST/guest.Master" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="ComplaintBox.GUEST.Login"  %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <h3>Login here!!!!</h3>
    

    <table bgcolor="white" align="center" class="auto-style1">


     <h1><center>Login Form</center></h1> 
                
                
                <tr>  
                    <td>Username :</td>  
                    <td>  
                        <asp:TextBox ID="user" runat="server" ></asp:TextBox>  
                    </td>  
                </tr>
                 
                <tr>  
                    <td>Password :</td>  
                    <td>  
                        <asp:TextBox ID="password" runat="server"></asp:TextBox>  
                    </td>  
                </tr>  
        
        
                <tr>  
                    <td class="auto-style1">  
                      <center> <asp:Button   ID="Button1" runat="server" Text="Submit" OnClick="Button1_Click"/>  </center> 
                    </td>  
                </tr>
           
            </table>
         
</asp:Content>
