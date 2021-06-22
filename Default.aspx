<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<asp:Content runat="server" ID="FeaturedContent" ContentPlaceHolderID="FeaturedContent">
    <section class="featured">
  <div>
    <asp:TextBox id="TEXTBOX_Board" runat="server" TextMode="MultiLine" Text="Please press start." Width="224" Height="306" Font-Bold="true" ReadOnly="true" />

<asp:TextBox ID="TEXTBOXforNextPiece"  runat="server" ReadOnly="true" Font-Bold="true"  TextMode="MultiLine" Width="90" Height="64" />

<br />

<asp:Label ID="LABEL_Board" runat="server" Text="Score: " />


<br />
<asp:Button ID="BUTTON_Start" runat="server" Text="Start New Game" OnClick="BUTTON_Start_Click" />

<br />

<asp:Button ID="BUTTON_Up" runat="server" Text="Up ^" Visible="false" OnClick="BUTTON_Up_Click" />
<asp:Button ID="BUTTON_Down" runat="server" Text="Down V" Visible="false" OnClick="BUTTON_Down_Click"  />

<br />

<asp:Button ID="BUTTON_Left" runat="server" Text="Left <" Visible="false" OnClick="BUTTON_Left_Click" style="height: 26px" />
<asp:Button ID="BUTTON_Right" runat="server" Text="Right >" Visible="false" OnClick="BUTTON_Right_Click" /> 
    </div>
    </section>
</asp:Content>
