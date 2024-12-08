<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="index.aspx.cs" Inherits="finalproject_cooperatingcrows.gauthiaj" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="lblBinaryMatrixFlipper" runat="server" Text="Given a m x n binary matrix mat. In one step, you can choose one cell and flip it and all the four neighbors of it if they exist (Flip is changing 1 to 0 and 0 to 1). A pair of cells are called neighbors if they share one edge. Return the minimum number of steps required to convert mat to a zero matrix or -1 if you cannot. A binary matrix is a matrix with all cells equal to 0 or 1 only. A zero matrix is a matrix with all cells equal to 0."></asp:Label>
            <br />
            <asp:Label ID="lblBinaryMatrixFlipperTestCase1" runat="server" Text="[0 0]"></asp:Label>
            <br />
            <asp:Label ID="lblBinaryMatrixFlipperTestCase2" runat="server" Text="[0 1]"></asp:Label>
            <br />
            <asp:Button ID="bnSolveBinaryMatrixFlipper" runat="server" Text="Solve" OnClick="bnSolveBinaryMatrixFlipper_Click"/>
            <asp:Label ID="lblBinaryMatrixFlipperSolution" runat="server" Text=""></asp:Label>
        </div>
    </form>
</body>
</html>
