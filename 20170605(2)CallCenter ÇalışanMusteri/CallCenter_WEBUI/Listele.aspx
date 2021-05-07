<%@ Page Title="" Language="C#" MasterPageFile="~/Main.Master" AutoEventWireup="true" CodeBehind="Listele.aspx.cs" Inherits="CallCenter_WEBUI.Listele" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

        <style type="text/css">
        .auto-style1 {
            width: 100%;
        }
        th{

            font-weight:bold;
            font-size:11px;
            font-family:'Trebuchet MS', 'Lucida Sans Unicode', 'Lucida Grande', 'Lucida Sans', Arial, sans-serif;
            color:#4f6b72;
            border-right:1px solid #C1DAD7;
            border-left:1px solid #C1DAD7;
            border-top:1px solid #C1DAD7;
            letter-spacing: 2px;
            padding:5px 5px 5px 5px;
            text-align:left;
            background:#CAE8EA;
        }

        td{
            border-right:1px solid #C1DAD7;
            border-bottom:1px solid #C1DAD7;
            padding:6px 6px 6px 6px;
            color:#4f6b72;
            background:#fff;
        }
    </style>

     <br /> <br /> 
    <br /> 

    <table class="auto-style1">
        <tr>
            <td>    <asp:DropDownList ID="ddlTip" runat="server" AutoPostBack="true"  onSelectedIndexChanged="ddlTip_SelectedIndexChanged" ValidateRequestMode="Disabled"></asp:DropDownList>
</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td>    <asp:GridView ID="grvListele" runat="server" Width="326px" OnRowCommand="grvListele_RowCommand">
        <Columns>
            <asp:TemplateField>
                <ItemTemplate>
                    <asp:Button ID="btnDetay" runat="server" Text="DETAY" CommandArgument='<%#Eval("MusteriID") %>' CommandName="DETAY"/>
                </ItemTemplate>
            </asp:TemplateField>

        </Columns>
    </asp:GridView></td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td> <asp:Button ID="btnEkle" runat="server" Text="Yeni Musteri Ekle" CommandArgument='<%#Eval("TipID") %>' CommandName="Yeni Musteri Ekle" OnClick="btnEkle_Click" /></td>
            <td>&nbsp;</td>
        </tr>
    </table>
</asp:Content>
