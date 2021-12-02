<%@ Page Language="C#" AutoEventWireup="true" CodeFile="rgform.aspx.cs" Inherits="rgform" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>studentregistrationform</title>
    
    </head>
<body>
    <form id="form1" runat="server">
        <div>
            <table>
                <caption><h2>Student Registration Form<h2/></caption>

                <tr>
                    <th><asp:Label ID="Label1" runat="server" Text="First Name:"></asp:Label></th>
                    <td><asp:TextBox ID="fname" runat="server"  placeholder="Enter First Name" required></asp:TextBox></td>
                </tr>

                <tr>
                    <th><asp:Label ID="Label2" runat="server" Text="Last Name:"></asp:Label></th>
                    <td><asp:TextBox ID="lname" runat="server" placeholder="Enter Last Name" required></asp:TextBox></td>
                </tr>

                <tr>
                    <th><asp:Label ID="Label8" runat="server" Text="Mobile:"></asp:Label></th>
                    <td><input type="tel" name="mo" placeholder="Enter Mobile Number" pattern="[0-9]{10}" required/></td>
                </tr>

                <tr>
                    <th><asp:Label ID="Label3" type="email" runat="server" Text="Email:"></asp:Label></th>
                    <td><asp:TextBox ID="email" runat="server" placeholder="Enter Email-Id" TextMode="Email" required></asp:TextBox></td>
                </tr>

                <tr>
                    <th><asp:Label ID="Label4"  runat="server" Text="Username:"></asp:Label></th>
                    <td><asp:TextBox ID="uname" runat="server" placeholder="Enter Username" required></asp:TextBox></td>
                </tr>

                <tr>
                    <th><asp:Label ID="Label5"  runat="server" Text="Password:"></asp:Label></th>
                    <td><asp:TextBox  ID="pass" runat="server" placeholder="Enter Password" TextMode="Password" pattern="(?=.*\d)(?=.*[a-z])(?=.*[A-Z]).{8,}" 
                        title="Must contain at least one number and one uppercase  and lowercase letter, and at least 8 or more characters"></asp:TextBox></td>
                </tr>

                <tr>
                    <th><asp:Label ID="Label6"  runat="server" Text="DOB:"></asp:Label></th>
                    <td><asp:TextBox  ID="bdate" runat="server"   TextMode="Date"></asp:TextBox></td>
                </tr>

                <tr>
                    <th><asp:Label ID="Label7"  runat="server" Text="Gender:"></asp:Label></th>
                    <td><input type="radio" name="gender"/>Male<input type="radio" name="gender"/>Female</td>
                </tr>

                <tr>
                    <th><asp:Label ID="Label9" runat="server" Text="Address:"></asp:Label></th>
                    <td><asp:TextBox ID="add" runat="server" ></asp:TextBox></td>
                </tr>

                <tr>
                <th><asp:Label ID="Label11" runat="server" Text="Highest Qualification:"></asp:Label></th>
                <td><Select name="" id="">
                     <option value="Phd">Phd</option>
	                <option value="Graduate">Graduate</option>
                    <option value="UnderGraduate">UnderGraduate</option>
	                <option value="Diploma">Diploma</option>
	                <option value="10th/12th">10th/12th</option>
	                <option value="others">Others</option>
                </td>
                </tr>

                <tr>
                    <th><asp:Label ID="Label10" runat="server" Text="Upload Document:"></asp:Label></th>
                    <td><input  type="file" name="file"/></td>
                </tr>

                <tr>
                    <td></td>
                    <td><input type="submit"/>&nbsp<input type="reset"/></td>
                <tr/>
                

                    


            </table>
                    
                   
        </div>
        
    </form>
</body>
</html>
