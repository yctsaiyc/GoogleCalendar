<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <script src="https://code.jquery.com/jquery-3.6.0.min.js"></script>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <input type="button" value="click me" onclick="btnAuthorizeGoogle_Click()"/>
        </div>
    </form>
</body>
</html>

<script>
    function btnAuthorizeGoogle_Click() {
            $.ajax({
                type: "POST",
                url: "Default.aspx",
                data: { method: "btnAuthorizeGoogle_Click" },
                success: function () {
                },
                error: function () {
                }
            });
        }
</script>
