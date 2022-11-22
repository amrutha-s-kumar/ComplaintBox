<%@ Page Title="" Language="C#" MasterPageFile="~/GUEST/guest.Master" AutoEventWireup="true" CodeBehind="userregistration.aspx.cs" Inherits="ComplaintBox.GUEST.userregistration" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">


    
     
    <h3>Register here!!!!</h3>
    <table bgcolor="white" align="center" class="auto-style1"  > 
         <h1><center>Registration Form</center></h1> 
                <tr>  
                    <td>Name :</td>  
                    <td>  
                        <asp:TextBox ID="name" runat="server"></asp:TextBox>  
                    </td>  
  
               </tr>  
                <tr>  
                    <td>Email :</td>  
                     <td> <asp:TextBox ID="email" runat="server"  ></asp:TextBox></td>  
                </tr>  
                

         <tr>  
                    <td>Place :</td>  
                    <td>  
                        <asp:TextBox ID="place" runat="server"  ></asp:TextBox>  
                    </td>  
                </tr>  
               <tr>  
                    <td>Phone Number :</td>  
                    <td>  
                        <asp:TextBox ID="phone" runat="server"  ></asp:TextBox>  
                    </td>  
                </tr>  
                       
                <tr>  
                    <td>Username :</td>  
                    <td>  
                        <asp:TextBox ID="user" runat="server" ></asp:TextBox>  
                    </td>  
                </tr>
                 
                <tr>  
                    <td>Password :</td>  
                    <td>  
                        <asp:TextBox ID="password" runat="server" TextMode="Password"></asp:TextBox>  
                    </td>  
                </tr>  
                <tr>  
                    <td class="auto-style1">  
                        <asp:Button ID="Button1" runat="server" Text="Submit" OnClick="Button1_Click"/>  
                    </td>  
                </tr>

           
            </table>

         
     
    

</asp:Content>
