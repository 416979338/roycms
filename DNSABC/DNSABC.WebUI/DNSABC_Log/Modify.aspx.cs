﻿using System;
using System.Data;
using System.Configuration;
using System.Collections;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;
using System.Text;
using ROYcms.Common;
using LTP.Accounts.Bus;
namespace DNSABC.Web.DNSABC_Log
{
    public partial class Modify : Page
    {       

        		protected void Page_Load(object sender, EventArgs e)
		{
			if (!Page.IsPostBack)
			{
				if (Request.Params["id"] != null && Request.Params["id"].Trim() != "")
				{
					int Id=(Convert.ToInt32(Request.Params["id"]));
					ShowInfo(Id);
				}
			}
		}
			
	private void ShowInfo(int Id)
	{
		DNSABC.BLL.DNSABC_Log bll=new DNSABC.BLL.DNSABC_Log();
		DNSABC.Model.DNSABC_Log model=bll.GetModel(Id);
		this.lblId.Text=model.Id.ToString();
		this.txtUserID.Text=model.UserID.ToString();
		this.txtLogType.Text=model.LogType.ToString();
		this.txtContent.Text=model.Content;
		this.txtOperator.Text=model.Operator;
		this.txtIp.Text=model.Ip;
		this.txtAdminID.Text=model.AdminID.ToString();
		this.txtObjectType.Text=model.ObjectType;
		this.txtObjectID.Text=model.ObjectID;
		this.txtRemark.Text=model.Remark;
		this.txtCreateTime.Text=model.CreateTime.ToString();

	}

		public void btnSave_Click(object sender, EventArgs e)
		{
			
			string strErr="";
			if(!PageValidate.IsNumber(txtUserID.Text))
			{
				strErr+="用户ID格式错误！\\n";	
			}
			if(!PageValidate.IsNumber(txtLogType.Text))
			{
				strErr+="日志类型格式错误！\\n";	
			}
			if(this.txtContent.Text.Trim().Length==0)
			{
				strErr+="内容不能为空！\\n";	
			}
			if(this.txtOperator.Text.Trim().Length==0)
			{
				strErr+="操作人不能为空！\\n";	
			}
			if(this.txtIp.Text.Trim().Length==0)
			{
				strErr+="操作IP 考虑反向代理的情况不能为空！\\n";	
			}
			if(!PageValidate.IsNumber(txtAdminID.Text))
			{
				strErr+="【管理员字段】管理员ID格式错误！\\n";	
			}
			if(this.txtObjectType.Text.Trim().Length==0)
			{
				strErr+="业务编码【管理员字段】不能为空！\\n";	
			}
			if(this.txtObjectID.Text.Trim().Length==0)
			{
				strErr+="业务标识【管理员字段】不能为空！\\n";	
			}
			if(this.txtRemark.Text.Trim().Length==0)
			{
				strErr+="备注【管理员字段】不能为空！\\n";	
			}
			if(!PageValidate.IsDateTime(txtCreateTime.Text))
			{
				strErr+="操作时间格式错误！\\n";	
			}

			if(strErr!="")
			{
				MessageBox.Show(this,strErr);
				return;
			}
			int Id=int.Parse(this.lblId.Text);
			int UserID=int.Parse(this.txtUserID.Text);
			int LogType=int.Parse(this.txtLogType.Text);
			string Content=this.txtContent.Text;
			string Operator=this.txtOperator.Text;
			string Ip=this.txtIp.Text;
			int AdminID=int.Parse(this.txtAdminID.Text);
			string ObjectType=this.txtObjectType.Text;
			string ObjectID=this.txtObjectID.Text;
			string Remark=this.txtRemark.Text;
			DateTime CreateTime=DateTime.Parse(this.txtCreateTime.Text);


			DNSABC.Model.DNSABC_Log model=new DNSABC.Model.DNSABC_Log();
			model.Id=Id;
			model.UserID=UserID;
			model.LogType=LogType;
			model.Content=Content;
			model.Operator=Operator;
			model.Ip=Ip;
			model.AdminID=AdminID;
			model.ObjectType=ObjectType;
			model.ObjectID=ObjectID;
			model.Remark=Remark;
			model.CreateTime=CreateTime;

			DNSABC.BLL.DNSABC_Log bll=new DNSABC.BLL.DNSABC_Log();
			bll.Update(model);
			ROYcms.Common.MessageBox.ShowAndRedirect(this,"保存成功！","list.aspx");

		}


        public void btnCancle_Click(object sender, EventArgs e)
        {
            Response.Redirect("list.aspx");
        }
    }
}
