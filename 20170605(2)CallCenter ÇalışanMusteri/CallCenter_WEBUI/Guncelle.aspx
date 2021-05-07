<%@ Page Title="" Language="C#" MasterPageFile="~/Main.Master" AutoEventWireup="true" CodeBehind="Guncelle.aspx.cs" Inherits="CallCenter_WEBUI.Guncelle" %>

<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="asp" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">

</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:ScriptManager ID="ScriptManager1" runat="server" EnableScriptGlobalization="true"></asp:ScriptManager>
                    <asp:CalendarExtender ID="CalendarExtender1" runat="server" PopupPosition="Right" TargetControlID="txtDogumTarihi"></asp:CalendarExtender>

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

    <table class="auto-style1">
        <tr>
            <td>Ad</td>
            <td>
                <asp:TextBox ID="txtAd" runat="server"></asp:TextBox>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ErrorMessage="Boş Geçilemez" ControlToValidate="txtAd"></asp:RequiredFieldValidator>
            </td>
        </tr>
        <tr>
            <td>Soyad</td>
            <td>
                <asp:TextBox ID="txtSoyad" runat="server"></asp:TextBox>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ErrorMessage="Boş Geçilemez" ControlToValidate="txtSoyad"></asp:RequiredFieldValidator>
            </td>
        </tr>
        <tr>
            <td>TC</td>
            <td>
                <asp:TextBox ID="txtTCNO" runat="server"></asp:TextBox>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ErrorMessage="Boş Geçilemez" ControlToValidate="txtTCNO"></asp:RequiredFieldValidator>
            </td>
        </tr>
        <tr>
            <td>DogumTarihi</td>
            <td>
                <asp:TextBox ID="txtDogumTarihi" runat="server"></asp:TextBox>
                <%--<asp:RangeValidator ID="RangeValidator2" runat="server" ControlToValidate="txtDogumTarihi" ErrorMessage="18 yaşından küçük olamaz." MinimumValue="18" MaximumValue="80" Type="Date"></asp:RangeValidator>--%>
            </td>
        </tr>
        <tr>
            <td>Unvan</td>
            <td>
                <asp:DropDownList ID="ddlUnvan" runat="server" AutoPostBack="false  " ValidateRequestMode="Disabled">
                </asp:DropDownList>

                <%--<asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" ErrorMessage="Boş Geçilemez" ControlToValidate="ddlUnvan"></asp:RequiredFieldValidator>--%>
            </td>
        </tr>
        <tr>
            <td>Email</td>
            <td>
                <asp:TextBox ID="txtEmail" runat="server"></asp:TextBox>
                <%--<asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" ErrorMessage="Hatalı Format" ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*"></asp:RegularExpressionValidator>--%>
            </td>
        </tr>
        <tr>
            <td>Telefon</td>
            <td>
                <asp:TextBox ID="txtTelefon" runat="server" Height="22px"></asp:TextBox>
                <%--<asp:RequiredFieldValidator ID="RequiredFieldValidator5" runat="server" ErrorMessage="Boş Geçilemez" ControlToValidate="txtTelefon"></asp:RequiredFieldValidator>--%>
                <%--<asp:RangeValidator ID="RangeValidator1" runat="server" ErrorMessage="Telefon Numarası Onbir Haneli Olmalı." ControlToValidate="txtTelefon" Type="Integer" MaximumValue="11" MinimumValue="11"></asp:RangeValidator>--%>
            </td>
        </tr>
        <tr>
            <td>Adres</td>
            <td>
                <asp:TextBox ID="txtAdres" runat="server" Height="57px" style="margin-top: 0px" TextMode="MultiLine"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td>&nbsp;</td>
            <td>
                <asp:Button ID="btnGuncelle" runat="server" Text="Guncelle" OnClick="btnGuncelle_Click" />
            </td>
        </tr>
    </table>
</asp:Content>
