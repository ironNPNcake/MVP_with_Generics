<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Wera.aspx.cs" Inherits="MVP_with_Generics.Wera" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <div style="width: 1000px; margin-left: auto; margin-right: auto;">
                <asp:Label ID="tutajtekst" runat="server" />
                &nbsp;
                 <asp:Button Text="Kliknij mnie :)" runat="server" ID="btnW" OnClick="btnW_Click" />
            </div>
        </div>
    </form>
</body>
</html>
