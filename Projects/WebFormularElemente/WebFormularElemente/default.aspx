<!DOCTYPE html>
<html>
    <head>
    <meta charset="utf-8" />
    <title>WebFormularElemente</title>
    <%@ page language="C#" %>
    <script runat="server">
    private void Page_Load()
    {
        if(IsPostBack)
        {
            ausgabe.Text = "Wir bieten ein Hotel in " + ziel.Value;
            if(allinc.Checked)
                ausgabe.Text += "<br>All Inclusive";

            if(bett2.Checked)
                ausgabe.Text += "<br>Mit 2 Betten";
            else
                ausgabe.Text += "<br>Mit 3 Betten";
        }
    }
    </script>
</head>
<body>
    <p>Ihr Reiseziel:</p>
    <form runat="server">
        <p><select id="ziel" runat="server">
            <option value="Barcelona">Spanien</option>
            <option value="Grenoble" selected="selected">
                Frankreich</option>
            <option value="Genf">Schweiz</option>
            <option value="Graz">Österreich</option>
        </select></p>
        <p><input id="allinc" runat="server"
            type="checkbox">All Inclusive</p>
        <p><input type="radio" name="bett" id="bett2"
            runat="server" checked="True">2-Bett<br>
           <input type="radio" name="bett" id="bett3"
            runat="server">3-Bett</p>
        <p><input runat="server" type="submit" value="Senden"></p>
        <p><asp:Label id="ausgabe" runat="server" /></p>
    </form>
</body>
</html>
