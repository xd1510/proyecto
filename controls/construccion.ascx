<%@ Control Language="C#" AutoEventWireup="true" CodeFile="construccion.ascx.cs" ClassName="construct" Inherits="Controls_construccion" %>
 <style type='text/css'>    
      /*@import url("dist/css/css.css");*/
       
            .ctrConstruccionDiv {
            width:22%;
            border:1px solid black;
        /*    margin-left:15px;*/
            margin-top:10px;
            margin-bottom:10px;
             margin-right:0px;
             display:block;
            }

            .ctrConstruccionImgs {
            width:100% !important;
            }
            .borderTop {
                border-top:1px solid black;
            }
            .borderBottom {
                border-bottom:1px solid black;
            }

 </style>

<div class="ctrConstruccionDiv" style="float:left"> 
   
    <asp:Image ID="Image1" runat="server" ImageUrl="~/dist/img/star.jpg"  Width="50px" CssClass="ctrConstruccionImgs"/>
     <div>
        <asp:Label ID="lblTitulo" runat="server" Text="Contruccion 1" CssClass="borderTop"></asp:Label>
         </div>
        <div>
        <asp:Label ID="lblMejoras" runat="server" Text=""  CssClass="borderTop"></asp:Label>
        </div>
         <div>
        <asp:Label ID="label1" runat="server" Text="Recursos necesarios" CssClass="borderTop"></asp:Label>
        </div>
        <div>
        <asp:Label ID="lblRecursos" runat="server" Text="" CssClass="borderTop"></asp:Label>
        </div>
         <div>
        <asp:Label ID="label2" runat="server" Text="Instalaciones necesarias" CssClass="borderTop"></asp:Label>
        </div>
        <div>
        <asp:Label ID="lblInstalaciones" runat="server" Text="" CssClass="borderTop"></asp:Label>
        </div>
        <div>
        <asp:ImageButton ID="ImageButton1" runat="server" />
        </div>
</div>

