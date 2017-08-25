<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="AddCustomer.aspx.cs" Inherits="GangaTraders.AddCustomer" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
      <div class="form-horizontal">
        <hr />
        <div class="form-group">
            <asp:HiddenField runat="server" ID="hdfCustomerID" />
            <div class="col-md-10">
                <asp:Label ID="lblMessage" runat="server" CssClass="control-label"></asp:Label>
            </div>
        </div>
           <div class="form-group">
          
            <div class="col-md-10">
                <asp:Label ID="lblTitle" Text="AddCustomer" runat="server" CssClass="control-label"></asp:Label>
            </div>
        </div>
        <div class="form-group">
            <asp:Label ID="lblCustomerName" Text="Customer Name:" runat="server" CssClass="control-label col-md-2"></asp:Label>
            <div class="col-md-3">
                <asp:TextBox ID="txtCustomerName" runat="server" CssClass="form-control"></asp:TextBox>
            </div>
        </div>
        <div class="form-group">
            <asp:Label ID="lblGSTINNo" Text="GSTIN:" runat="server" CssClass="control-label col-md-2"></asp:Label>
            <div class="col-md-3">
                <asp:TextBox ID="txtGSTINNo" runat="server" CssClass="form-control"></asp:TextBox>
            </div>
        </div>
        <div class="form-group">
            <asp:Label ID="lblState" Text="State:" runat="server" CssClass="control-label col-md-2"></asp:Label>
            <div class="col-md-3">
                 <asp:TextBox ID="txtState" runat="server" CssClass="form-control"></asp:TextBox>
            </div>
        </div>
        <div class="form-group">
            <asp:Label ID="lblStateCode" Text="StateCode:" runat="server" CssClass="control-label col-md-2"></asp:Label>
            <div class="col-md-3">
                <asp:TextBox ID="txtStateCode" runat="server" CssClass="form-control"></asp:TextBox>
            </div>
        </div>
        <div class="form-group">
            <asp:Label ID="lblPayementTerm" Text="PayementTerm:" runat="server" CssClass="control-label col-md-2"></asp:Label>
            <div class="col-md-3">
                <asp:TextBox ID="txtPayementTerm" runat="server"  CssClass="form-control" ></asp:TextBox>
            </div>
        </div>
        <div class="form-group">
            <asp:Label ID="lblstrTransportationMode" Text="TransportationMode:" runat="server" CssClass="control-label col-md-2"></asp:Label>
            <div class="col-md-3">
                <asp:TextBox ID="txtTransportationMode" runat="server" CssClass="form-control"></asp:TextBox>
            </div>
        </div>
        <div class="form-group">
            <asp:Label ID="lblstrAddress" CssClass="control-label col-md-2" Text="Address:" runat="server"></asp:Label>
            <div class="col-md-3">
                <asp:TextBox ID="txtAddress" runat="server" TextMode="MultiLine" Columns="25" Rows="3" CssClass="form-control"></asp:TextBox>
            </div>
        </div>
        
        <div class="form-group">

            <div class="col-md-3">
                <asp:Button runat="server" ID="btnSave" Text="Save" OnClick="btnSave_Click" />
                <asp:Button runat="server" ID="btnClear" Text="Clear" OnClick="btnClear_Click" />
            </div>
        </div>
    </div>
</asp:Content>
