﻿<%@ Page Language="C#" AutoEventWireup="true" Inherits="ROYcms.UI.Admin._Default" Codebehind="Default.aspx.cs" %>
<%@ Register src="../Resources.ascx" tagname="Resources" tagprefix="Resources" %>
<%@ Register src="../AdminMenu.ascx" tagname="AdminMenu" tagprefix="AdminMenu" %>
<!DOCTYPE HTML>
<html>
<head id="Head1" runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title>在线文件管理</title>
</head>
<body>
<form id="form1" runat="server">
<Resources:Resources ID="Resources1" runat="server" />
    <script type="text/javascript" language="javascript">  
    $(function() {
        $("#checkedAll").click(function() { 
            if ($(this).attr("checked") == true) { // 全选
                    $("input[@type='checkbox']").each(function() {
                    $(this).attr("checked", true);
                    });
                } else { // 取消全选
                    $("input[@type='checkbox']").each(function() {
                    $(this).attr("checked", false);
                });
            }
        });
    });

$('#btnUpload').live('Click', function() {
$("form1").submit();

});


//    $().ready(function() {
//        $('#divCreate').jqm({trigger: '#create'});
//        $('#divRename').jqm({trigger: '#rename'});
//        $('#divDelete').jqm({trigger: '#delete'});
//        $('#divUpload').jqm({trigger: '#upload'});
//        $('#divCopy').jqm({trigger: '#copy'});
//        $('#divPaste').jqm({trigger: '#paste'});
//        $('#divCut').jqm({trigger: '#cut'});
//        $('#divCreateFile').jqm({trigger: '#createfile'}); 
//    });
    </script>

   <table width="100%" border="0" class="tiao_top">
              <tr>
                <td nowrap><div  class="tiao_con">
                <a href="Default.aspx"><img align="absmiddle" title="刷新" alt="刷新" src="/administrator/images/ico/refresh.gif" />刷新</a> 
                <a href="javascript:void(0);" id="create"><img align="absmiddle" title="新建" alt="新建" src="/administrator/images/ico/folder_new.gif" />新建文件夹</a> 
                
               <!-- <a href="javascript:void(0);" id="createfile"><img align="absmiddle" title="新建" alt="新建" src="/administrator/images/ico/file_new.gif" />新建文件</a>-->
                 
                <a href="javascript:void(0);" id="cut"><img align="absmiddle" title="剪切" alt="剪切" src="/administrator/images/ico/cut.gif" />剪切</a> 
                <a href="javascript:void(0);" id="copy"><img align="absmiddle" title="复制" alt="复制" src="/administrator/images/ico/copy.gif" />复制</a> 
                <a href="javascript:void(0);" id="paste"><img align="absmiddle" title="粘贴" alt="粘贴" src="/administrator/images/ico/paste.gif" />粘贴</a> 
                <a href="javascript:void(0);" id="rename"><img align="absmiddle" title="重命名" alt="重命名" src="/administrator/images/ico/rename.gif" />重命名</a> 
                <a href="javascript:void(0);" id="delete"><img align="absmiddle" title="删除" alt="删除" src="/administrator/images/ico/delete.gif" />删除</a> 
                <a rel="facebox" title="Zip文件上传" href="/administrator/FileManager/UPfile_zip.aspx" id="A1"><img align="absmiddle" title="Zip上传" alt="Zip上传" src="/administrator/images/ico/up.gif" />Zip上传</a>
                <a rel="facebox" title="文件上传" href="#divUpload" id="upload"><img align="absmiddle" title="上传" alt="上传" src="/administrator/images/ico/up.gif" />上传</a>
                
                
                </div></td>
                <td  align="right" nowrap><AdminMenu:AdminMenu ID="AdminMenu1" runat="server" /></td>
              </tr>
        </table>
   
   <div id="divCreate" class="jqmWindow" style="display:none;">
       <h3>新建文件夹</h3>
       名称：<asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
       <asp:Button ID="btnCreateFolder" runat="server" Text="确定" OnClick="btnCreateFolder_Click" />
       <asp:Button ID="btnPanel2Cancel" runat="server" Text="取消" /><br />
   </div>
   
      <div id="divCreateFile" class="jqmWindow" style="display:none;">
       <h3>新建文件</h3>
       名称：<asp:TextBox ID="TextBox4" runat="server" Text="New File.txt"></asp:TextBox>
       <asp:Button ID="Button1" runat="server" Text="确定" OnClick="btnCreateFile_Click" />
       <asp:Button ID="Button4" runat="server" Text="取消" /><br />
   </div>
   
   <div id="divUpload" class="jqmWindow" style="display:none;">
       <h3>文件上传</h3>
       选择文件：<asp:FileUpload ID="FileUpload1" runat="server" />
       <asp:Button ID="btnUpload" runat="server" Text="确定"  OnClick="btnUpload_Click" ></asp:Button>
      
       <asp:Button ID="btnPanel3Cancel" runat="server" Text="取消" />
   </div>
   
   <div id="divRename" class="jqmWindow" style="display:none;">
       <h3>重命名</h3>
       新名称：
       <asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>
       <asp:Button ID="btnRename" runat="server" Text="确定" OnClick="btnRename_Click" />
       <asp:Button ID="btnPanel4Cancel" runat="server" Text="取消" />
   </div>
   
   <div id="divDelete" class="jqmWindow" style="display:none;">
       <h3>删除文件</h3>
       <p>确定删除选中的文件或文件夹吗？<br /><br />
       <asp:Button ID="btnDelete" runat="server" Text="确定" OnClick="btnDelete_Click" />
       <asp:Button ID="Button2" runat="server" Text="取消" /></p>
   </div>
   
   <div id="divCopy" class="jqmWindow" style="display:none;">
       <h3>复制文件</h3>
       <p>确定复制选中的文件或文件夹吗？<br /><br />
       <asp:Button ID="btnCopy" runat="server" Text="确定" OnClick="btnCopy_Click" />
       <asp:Button ID="Button3" runat="server" Text="取消" /></p>
   </div>
   
   <div id="divPaste" class="jqmWindow" style="display:none;">
       <h3>粘贴文件</h3>
       <p>确定粘贴选中的文件或文件夹吗？<br /><br />
       <asp:Button ID="btnPaste" runat="server" Text="确定" OnClick="btnPaste_Click" />
       <asp:Button ID="Button5" runat="server" Text="取消" /></p>
   </div>
   
   <div id="divCut" class="jqmWindow" style="display:none;">
       <h3>剪切文件</h3>
       <p>确定剪切选中的文件或文件夹吗？<br /><br />
       <asp:Button ID="btnCut" runat="server" Text="确定" OnClick="btnCut_Click" />
       <asp:Button ID="Button7" runat="server" Text="取消" /></p>
   </div>
  

   <div style="padding:5px; display:none"><strong>当前目录路径: </strong>
   <asp:Label ID="lblCurrentPath" Font-Bold="true" runat="server" Font-Names="Verdana" Font-Size="12px"></asp:Label>
   </div>

        <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" 
            Width="100%" OnRowCommand="GridView1_RowCommand" Font-Names="Verdana" 
            Font-Size="12px" OnRowDataBound="GridView1_RowDataBound" CellPadding="3" 
            BorderStyle="solid" BorderWidth="1px" CssClass="TBlist">
            <Columns>
                <asp:TemplateField>
                    <ItemTemplate>
                        <asp:CheckBox ID="CheckBox1" runat="server" />
                    </ItemTemplate>
                    <HeaderTemplate>
                        <input type="checkbox" name="checkedAll" id="checkedAll"/>
                    </HeaderTemplate>
                    <ItemStyle Width="3%" Wrap="False" HorizontalAlign="Center" />
                </asp:TemplateField>
                <asp:TemplateField HeaderText="名称">
                    <EditItemTemplate>
                        <asp:TextBox ID="TextBox1" runat="server" Text='<%# Bind("Name") %>'></asp:TextBox>
                    </EditItemTemplate>
                    <ItemTemplate>
                        <asp:LinkButton ID="LinkButton1" runat="server" CommandArgument='<%# Eval("FullName") %>' Text='<%# Eval("Name") %>'></asp:LinkButton>
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:BoundField DataField="CreationDate" HeaderText="创建日期" >
                    <ItemStyle Width="12%" Wrap="False" />
                </asp:BoundField>
                <asp:BoundField DataField="Size" HeaderText="大小" DataFormatString="{0} KB" >
                    <ItemStyle HorizontalAlign="center" Width="5%" Wrap="False" />
                </asp:BoundField>
            </Columns>
            <FooterStyle BackColor="White" ForeColor="#cccccc" />
            <RowStyle ForeColor="#cccccc" />
            <PagerStyle BackColor="White" ForeColor="#cccccc" HorizontalAlign="Left" />
            <SelectedRowStyle BackColor="#669999" Font-Bold="True" ForeColor="White" />
            <HeaderStyle Font-Bold="True"  BackColor="#F4FBFF" ForeColor="#666666" />
        </asp:GridView>

  
</form>
</body>
</html>