<%@ Page Title="" Language="C#" MasterPageFile="~/CRMSite.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="WebSerivce.Default" %>
<asp:Content ID="Content1" ContentPlaceHolderID="title" runat="server">
��ҳ
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .style1
        {
            width: 100%;
        }
        .style2
        {
            height: 7px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <asp:FormView ID="fv_addcustomer" runat="server" CellPadding="4" DataKeyNames="cid" 
        DataSourceID="SqlDS_Customer" ForeColor="#333333" DefaultMode="Insert">
        <FooterStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
        <RowStyle BackColor="#F7F6F3" ForeColor="#333333" />
        <InsertItemTemplate>
            <table class="style1">
                <tr>
                    <td>
                        �ͻ�����:</td>
                    <td>
                        <asp:TextBox ID="customernameTextBox" runat="server" 
                            Text='<%# Bind("customername") %>' />
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" 
                            ControlToValidate="customernameTextBox" ErrorMessage="*" 
                            ValidationGroup="addcustomer">�ͻ�����û����д</asp:RequiredFieldValidator>
                    </td>
                    <td>
                        �绰:</td>
                    <td>
                        <asp:TextBox ID="phoneTextBox" runat="server" Text='<%# Bind("phone") %>' />
                    </td>
                </tr>
                <tr>
                    <td>
                        �Ա�:</td>
                    <td>
                        <asp:RadioButtonList ID="RadioButtonList1" runat="server" 
                            RepeatDirection="Horizontal" SelectedValue='<%# bind("gender") %>'>
                            <asp:ListItem Value="True" Selected="True">��</asp:ListItem>
                            <asp:ListItem Value="False">Ů</asp:ListItem>
                        </asp:RadioButtonList>
                    </td>
                    <td>
                        ����:</td>
                    <td>
                        <asp:TextBox ID="emailTextBox" runat="server" Text='<%# Bind("email") %>' />
                    </td>
                </tr>
                <tr>
                    <td>
                        ��˾����:</td>
                    <td>
                        <asp:TextBox ID="companynameTextBox" runat="server" 
                            Text='<%# Bind("companyname") %>' />
                    </td>
                    <td>
                        �ֻ�:</td>
                    <td>
                        <asp:TextBox ID="mobileTextBox" runat="server" Text='<%# Bind("mobile") %>' />
                    </td>
                </tr>
                <tr>
                    <td>
                        ����:</td>
                    <td>
                        <asp:TextBox ID="departmentTextBox" runat="server" 
                            Text='<%# Bind("department") %>' />
                    </td>
                    <td>
                        ��ͥ�绰:</td>
                    <td>
                        <asp:TextBox ID="homephoneTextBox" runat="server" 
                            Text='<%# Bind("homephone") %>' />
                    </td>
                </tr>
                <tr>
                    <td>
                        ְλ:</td>
                    <td>
                        <asp:TextBox ID="positionTextBox" runat="server" 
                            Text='<%# Bind("position") %>' />
                    </td>
                    <td>
                        ����:</td>
                    <td>
                        <asp:TextBox ID="faxTextBox" runat="server" Text='<%# Bind("fax") %>' />
                    </td>
                </tr>
                <tr>
                    <td>
                        ��˾��ַ:</td>
                    <td>
                        <asp:TextBox ID="addressTextBox" runat="server" Text='<%# Bind("address") %>' />
                    </td>
                    <td>
                        �ʱ�:</td>
                    <td>
                        <asp:TextBox ID="zipTextBox" runat="server" Text='<%# Bind("zip") %>' />
                    </td>
                </tr>
                <tr>
                    <td>
                        ��˾��ַ:</td>
                    <td>
                        <asp:TextBox ID="websiteTextBox" runat="server" Text='<%# Bind("website") %>' />
                    </td>
                    <td>
                        &nbsp;</td>
                    <td>
                        &nbsp;</td>
                </tr>
                <tr>
                    <td>
                        ��ע:</td>
                    <td colspan="3">
                        <asp:TextBox ID="descriptionTextBox" runat="server" Height="190px" 
                            Text='<%# Bind("description") %>' Width="260px" />
                    </td>
                </tr>
                <tr>
                    <td>
                        &nbsp;</td>
                    <td>
                        <asp:LinkButton ID="InsertButton" runat="server" CausesValidation="True" 
                            CommandName="Insert" Text="���" ValidationGroup="addcustomer" />
                    </td>
                    <td>
                        &nbsp;</td>
                    <td>
                        <asp:LinkButton ID="InsertCancelButton" runat="server" CausesValidation="False" 
                            CommandName="Cancel" Text="ȡ��" />
                    </td>
                </tr>
            </table>
        </InsertItemTemplate>       
        <PagerStyle BackColor="#284775" ForeColor="White" HorizontalAlign="Center" />
        <HeaderStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
        <EditRowStyle BackColor="#999999" />
    </asp:FormView>
    <hr />
    <asp:GridView ID="gv_customer" runat="server" AllowPaging="True" 
    AllowSorting="True" AutoGenerateColumns="False" CellPadding="4" 
    DataKeyNames="cid" DataSourceID="SqlDS_Customer" ForeColor="#333333" 
    GridLines="None">
    <RowStyle BackColor="#F7F6F3" ForeColor="#333333" />
    <Columns>
        <asp:CommandField ShowDeleteButton="True" ShowEditButton="True" />
        <asp:BoundField DataField="cid" HeaderText="cid" InsertVisible="False" 
            ReadOnly="True" SortExpression="cid" Visible="False" />
        <asp:BoundField DataField="customername" HeaderText="�ͻ�����" 
            SortExpression="customername" />
        <asp:TemplateField HeaderText="�Ա�" SortExpression="gender">
            <EditItemTemplate>
                <asp:CheckBox ID="CheckBox1" runat="server" Checked='<%# Bind("gender") %>' />
            </EditItemTemplate>
            <ItemTemplate>
                <asp:Label ID="Label1" runat="server" Text='<%# Convert.ToBoolean(Eval("gender"))?"��":"Ů" %>'></asp:Label>
            </ItemTemplate>
        </asp:TemplateField>
        <asp:BoundField DataField="companyname" HeaderText="��˾����" 
            SortExpression="companyname" />
        <asp:BoundField DataField="department" HeaderText="����" 
            SortExpression="department" />
        <asp:BoundField DataField="position" HeaderText="ְλ" 
            SortExpression="position" />
        <asp:BoundField DataField="address" HeaderText="��˾��ַ" 
            SortExpression="address" />
        <asp:BoundField DataField="website" HeaderText="��˾��ַ" 
            SortExpression="website" />
        <asp:BoundField DataField="phone" HeaderText="�绰" SortExpression="phone" />
        <asp:BoundField DataField="zip" HeaderText="�ʱ�" SortExpression="zip" />
        <asp:BoundField DataField="email" HeaderText="����" SortExpression="email" />
        <asp:BoundField DataField="mobile" HeaderText="�ֻ�" SortExpression="mobile" />
        <asp:BoundField DataField="fax" HeaderText="����" SortExpression="fax" />
        <asp:BoundField DataField="homephone" HeaderText="��ͥ�绰" 
            SortExpression="homephone" />
        <asp:BoundField DataField="description" HeaderText="��ע" 
            SortExpression="description" />
    </Columns>
    <FooterStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
    <PagerStyle BackColor="#284775" ForeColor="White" HorizontalAlign="Center" />
    <SelectedRowStyle BackColor="#E2DED6" Font-Bold="True" ForeColor="#333333" />
    <HeaderStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
    <EditRowStyle BackColor="#999999" />
    <AlternatingRowStyle BackColor="White" ForeColor="#284775" />
</asp:GridView>
<asp:SqlDataSource ID="SqlDS_Customer" runat="server" 
    ConnectionString="<%$ ConnectionStrings:crmConnectionString %>" 
    SelectCommand="SELECT * FROM [customer]" 
        DeleteCommand="delete from customer where cid=@cid" 
        InsertCommand="INSERT INTO customer(customername, gender, companyname, department, position, address, website, phone, zip, email, mobile, fax, homephone, description, owner) VALUES (@customername, @gender, @companyname, @department, @position, @address, @website, @phone, @zip, @email, @mobile, @fax, @homephone, @description, @owner)" 
        UpdateCommand="CreateCustomer " UpdateCommandType="StoredProcedure">
    <DeleteParameters>
        <asp:Parameter Name="cid" />
    </DeleteParameters>
    <UpdateParameters>
        <asp:Parameter Name="RETURN_VALUE" Type="Int32" Direction="ReturnValue" />
        <asp:Parameter Name="cid" Type="String" />
        <asp:Parameter Name="customername" Type="String" />
        <asp:Parameter Name="gender" Type="Boolean" />
        <asp:Parameter Name="companyname" Type="String" />
        <asp:Parameter Name="department" Type="String" />
        <asp:Parameter Name="position" Type="String" />
        <asp:Parameter Name="address" Type="String" />
        <asp:Parameter Name="website" Type="String" />
        <asp:Parameter Name="phone" Type="String" />
        <asp:Parameter Name="zip" Type="String" />
        <asp:Parameter Name="email" Type="String" />
        <asp:Parameter Name="mobile" Type="String" />
        <asp:Parameter Name="fax" Type="String" />
        <asp:Parameter Name="homephone" Type="String" />
        <asp:Parameter Name="description" Type="String" />
        <asp:SessionParameter Name="owner" SessionField="UID" Type="String" />
    </UpdateParameters>
    <InsertParameters>
        <asp:FormParameter FormField="customername" Name="customername" />
        <asp:FormParameter DefaultValue="" FormField="gender" Name="gender" 
            Type="Boolean" />
        <asp:FormParameter DefaultValue="" FormField="companyname" Name="companyname" 
            Type="String" />
        <asp:FormParameter DefaultValue="" FormField="department" Name="department" 
            Type="String" />
        <asp:FormParameter FormField="position" Name="position" Type="String" />
        <asp:FormParameter FormField="address" Name="address" Type="String" />
        <asp:FormParameter FormField="website" Name="website" Type="String" />
        <asp:FormParameter FormField="phone" Name="phone" Type="String" />
        <asp:FormParameter FormField="zip" Name="zip" Type="String" />
        <asp:FormParameter FormField="email" Name="email" Type="String" />
        <asp:FormParameter FormField="mobile" Name="mobile" Type="String" />
        <asp:FormParameter FormField="fax" Name="fax" Type="String" />
        <asp:FormParameter FormField="homephone" Name="homephone" Type="String" />
        <asp:FormParameter FormField="description" Name="description" Type="String" />
        <asp:SessionParameter Name="owner" SessionField="UID" Type="String" />
    </InsertParameters>
    </asp:SqlDataSource>

</asp:Content>
