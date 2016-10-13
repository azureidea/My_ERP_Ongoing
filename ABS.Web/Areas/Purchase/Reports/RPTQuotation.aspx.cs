﻿using ABS.Models;
using ABS.Models.ViewModel.Inventory;
using ABS.Reports.Inventory;
using ABS.Service.Inventory.Factories;
using ABS.Service.Sales.Factories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ABS.Web.Areas.Purchase.Reports
{
    public partial class RPTQuotation : System.Web.UI.Page
    {
        PIMgt objPIMgt = new PIMgt();
        QuotationMgt objQuotationMgt = new QuotationMgt(); 

        protected void Page_Load(object sender, EventArgs e)
        {
            int lUserID = Convert.ToInt16(Session["UserID"]);
            int lCompanyID = Convert.ToInt16(Session["CompanyID"]);

            if (!IsPostBack)
            {
                if (!IsPostBack && lUserID > 0 && lCompanyID > 0)
                {
                    LoadCompany(lUserID, lCompanyID);
                    // LoadPI(lUserID, lCompanyID);
                    ListItem item = new ListItem("--Select Issue No--", "-1");
                    ddlQuotation.Items.Insert(0, item);
                }
                else if (lUserID == 0 || lCompanyID == 0)
                {
                    Response.Redirect("~/Account/Login");
                }

                LoadQuotation(lUserID, lCompanyID);
            }
        }

        protected void btnShowReport_Click(object sender, EventArgs e)
        {
            if (ddlQuotation.SelectedValue != "0")
            {
                ReportViewer1.Report = new rptQuotation();
                (ReportViewer1.Report as rptQuotation).pramrptQuotationNo = ddlQuotation.SelectedValue.ToString();
                (ReportViewer1.Report as rptQuotation).createdBy = Convert.ToInt16(Session["UserID"]);
                (ReportViewer1.Report as rptQuotation).companyId = Convert.ToInt16(ddlCompany.SelectedValue);
                ReportViewer1.RefreshReport();
            }
            else
            {
                Page.ClientScript.RegisterStartupScript(this.GetType(), "myScript", "WarningMessage();", true);

                //ReportViewer1.Report = new rpt_HDOMasterDetail();

                ////(ReportViewer1.Report as rpt_HDOMasterDetail).pramHDONo = ddlHDONo.SelectedValue.ToString();// "PI-00000155-Revise-2";
                //ReportViewer1.RefreshReport();
            }
        }      
        protected void LoadQuotation(int lUserID, int companyID)
        {
            List<vmQuotation> lstIssueMaster = objQuotationMgt.GetQuotationList()
                                             .Select(m => new vmQuotation
                                             {
                                                 QuotationID = m.QuotationID,
                                                 QuotationNo = m.QuotationNo,
                                                 CompanyID   = m.CompanyID 
                                              })
                                             .Where(m => m.CompanyID == companyID).ToList();
            ddlQuotation.DataSource = lstIssueMaster.OrderByDescending(x=>x.QuotationID);
            ddlQuotation.DataValueField = "QuotationNo";
            ddlQuotation.DataTextField = "QuotationNo";
            ddlQuotation.DataBind();
            ListItem item = new ListItem("--Select Quotation No--", "-1");
            ddlQuotation.Items.Insert(0, item);
        }

        protected void LoadCompany(int lUserID, int companyID)
        {
            List<CmnCompany> lstCmnCompany = objPIMgt.GetPICompany(lUserID).Select(m => new CmnCompany { CompanyID = m.CompanyID, CompanyName = m.CompanyName, IsDeleted = m.IsDeleted }).ToList();
            ddlCompany.DataSource = lstCmnCompany;
            ddlCompany.DataValueField = "CompanyID";
            ddlCompany.DataTextField = "CompanyName";

            ddlCompany.DataBind();

            int lCompanyID = Convert.ToInt16(Session["CompanyID"]);
            ddlCompany.SelectedValue = lCompanyID.ToString();
            //ListItem item = new ListItem("--Select Company--", "-1");
            //ddlCompany.Items.Insert(0, item);

        }

        protected void ddlCompany_SelectedIndexChanged(object sender, EventArgs e)
        {
            int companyID = Convert.ToInt16(ddlCompany.SelectedValue);
            if (companyID > 0)
            {
                LoadQuotation(Convert.ToInt16(Session["UserID"]), companyID);
            }
        }       
    }
}