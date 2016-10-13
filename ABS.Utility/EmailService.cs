﻿using ABS.Models.ViewModel.EmailService;
using ABS.Models.ViewModel.SystemCommon;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Web;

namespace ABS.Utility
{
    public class Signature_All
    {
        public String Name { get; set; }

    }
    public class EmailService
    {
        

        public int SendMailNotificationApproval()
        {
            int result = 0;
            try
            {

                MailMessage mail = new MailMessage();
                SmtpClient SmtpServer = new SmtpClient("smtp.gmail.com");

                mail.From = new MailAddress("md.mahfuzbappy@gmail.com");
                mail.To.Add("ammahfuzbappy@gmail.com");
                string subject = "Notification of Invoice Creation! Invoice No: " + 121 + ".";
                string body = "Dear Sir\n";
                body += "As you earlier said one Invoice is created Invoice No:" + 22 + " \n";
                body += "And Discount(%):" + 1 + "\n";
                body += "\n";
                body += "Thanks by\n";
                body += "-------------------\n";
                body += "Mahfuz Bappy";
                body += "\n";
                body += "\n";
                body += "Note: This mail is generated by Amber .";

                SmtpServer.Port = 25;
                SmtpServer.Credentials = new System.Net.NetworkCredential("md.mahfuzbappy@gmail.com", "123");
                SmtpServer.EnableSsl = false;

                SmtpServer.Send(mail);
                result = 1;
            }
            catch (Exception ex)
            {
                result = 0;
                ErrorLog.Log(ex);
                ex.ToString();
            }

            return result;
        }

        //Refference By Hira Vai
        #region Refference By Hira Vai
        public static void SendMailInvoice(string transactionNo, string singnature, int userId, int NextUserId)
        {
            try
            {
                var userName = "";
                List<Signature_All> toAddress = new List<Signature_All>();
                var fromAddress = "";
                using (var db = new ABS.Models.ERP_Entities())
                {
                    userName = db.CmnUserAuthentications.SingleOrDefault(x => x.UserID == userId).LoginID;
                    fromAddress = "amberbusinesssuite@amber.com.bd";
                    Signature_All SendToUser = new Signature_All();
                    int nextUser = NextUserId;
                    SendToUser.Name = db.CmnUserAuthentications.SingleOrDefault(x => x.UserID == nextUser).LoginEmail;
                    toAddress.Add(SendToUser);

                }
                string fromPassword = "suite.54#";
                string soNUmber1 = transactionNo;
                string dealerName = "Dname";
                string subject = "Notification of HDO Creation! HDO No: " + soNUmber1 + ".";
                string body = "Dear Sir\n";
                body += "As you earlier said one HDO is Checked HDO No:" + soNUmber1 + " \n";
                body += "\n";
                body += "Thanks by\n";
                body += "-------------------\n";
                body += userName;
                body += "\n";
                body += "\n";
                body += "Note: This mail is generated by Assl.";
                if (toAddress != null)
                    ABS.Utility.EmailService.MailReport(fromAddress, fromPassword, toAddress, subject, body, soNUmber1, "");
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static void MailReport(string from, string fromPassword, List<Signature_All> toAddressList, string subject, string body, string softid, string copy)
        {
            try
            {
                MailMessage message = new MailMessage();
                foreach (var mailadd in toAddressList)
                {
                    //Please Enabled Later
                    // message.To.Add((mailadd.EmailID.ToString()));
                    message.To.Add(mailadd.Name);
                }
                message.From = new MailAddress(from, "ABS Notification");
                message.Subject = subject;
                message.Body = body;
                var smtp = new System.Net.Mail.SmtpClient();
                {
                    smtp.Host = "mail.amber.com.bd";
                    smtp.Port = 25;
                    smtp.EnableSsl = false;
                    smtp.DeliveryMethod = System.Net.Mail.SmtpDeliveryMethod.Network;
                    smtp.Credentials = new NetworkCredential(from, fromPassword);
                    smtp.Timeout = 20000;
                }
                smtp.Send(message);
            }
            catch (Exception ix1)
            {
                throw ix1;
            }
        }
        #endregion Refference By Hira Vai

        public async Task<int> PasswordRecovery(vmRecoverUser model)
        {
            int result = 0;
            string sender = "amberbusinesssuite@amber.com.bd";
            string receiver = model.LoginEmail;
            MailMessage Msg = new MailMessage();

            try
            {
                Msg.From = new MailAddress(sender);
                Msg.To.Add(receiver);
                StreamReader reader = new StreamReader(HttpContext.Current.Server.MapPath("~/EmailTemplate/PasswordRecovery.html"));
                string readFile = reader.ReadToEnd();
                string StrContent = "";
                StrContent = readFile;

                StrContent = StrContent.Replace("[UserID]", model.UserID);
                StrContent = StrContent.Replace("[LoginID]", model.LoginID);
                StrContent = StrContent.Replace("[LoginEmail]", model.LoginEmail);
                StrContent = StrContent.Replace("[Password]", model.Password);
                StrContent = StrContent.Replace("[RequestedIP]", model.RequestedIP);
                StrContent = StrContent.Replace("[CompanyName]", model.CompanyName);

                Msg.Subject = model.CompanyName + " - Password Recovery";
                Msg.Body = StrContent.ToString();
                Msg.IsBodyHtml = true;

                using (var smtp = new SmtpClient())
                {
                    var credential = new NetworkCredential
                    {
                        UserName = "amberbusinesssuite@amber.com.bd",
                        Password = "suite.54#"
                    };
                    smtp.Credentials = credential;
                  
                    smtp.Host = "mail.amber.com.bd";
                    smtp.Port = 25;
                    smtp.EnableSsl = false;
                    smtp.DeliveryMethod = System.Net.Mail.SmtpDeliveryMethod.Network;
                   
                    smtp.Timeout = 20000;
                    await smtp.SendMailAsync(Msg);
                    result = 1;
                }
            }
            catch (Exception ex)
            {
                ex.ToString();
                result = 0;
            }
            return result;
        }

        public async Task<int> UserRegistration(vmUser model)
        {
            int result = 0;
            //string sender = "epos@amber.com.bd";
            string sender = "amberbusinesssuite@amber.com.bd";
            string receiver = model.LoginEmail;
            MailMessage Msg = new MailMessage();

            try
            {
                Msg.From = new MailAddress(sender);
                Msg.To.Add(receiver);
                StreamReader reader = new StreamReader(HttpContext.Current.Server.MapPath("~/EmailTemplate/UserRegistration.html"));
                string readFile = reader.ReadToEnd();
                string StrContent = "";
                StrContent = readFile;

                StrContent = StrContent.Replace("[UserID]", model.UserID.ToString());
                StrContent = StrContent.Replace("[LoginID]", model.LoginID);
                StrContent = StrContent.Replace("[LoginEmail]", model.LoginEmail);
                StrContent = StrContent.Replace("[Password]", model.Password);
                StrContent = StrContent.Replace("[RequestedIP]", model.RequestedIP);
                StrContent = StrContent.Replace("[CompanyName]", model.CompanyName);

                Msg.Subject = model.CompanyName + " - Account Details";
                Msg.Body = StrContent.ToString();
                Msg.IsBodyHtml = true;

                using (var smtp = new SmtpClient())
                {
                    var credential = new NetworkCredential
                    {
                        UserName = "amberbusinesssuite@amber.com.bd",
                        Password = "suite.54#"
                    };
                    smtp.Credentials = credential;
                    smtp.Host = "mail.amber.com.bd";
                    smtp.Port = 25;
                    smtp.EnableSsl = false;
                    await smtp.SendMailAsync(Msg);
                    result = 1;
                }
            }
            catch (Exception ex)
            {
                ex.ToString();
                result = 0;
            }
            return result;
        }

        public async Task<int> NotificationMail(vmNotificationMail model)
        {
            int result = 0;
            string sender = "amberbusinesssuite@amber.com.bd";
            string receiver = model.nextUserEmailAddress;
            StreamReader reader = null;
            MailMessage Msg = new MailMessage();
            try
            {
                Msg.From = new MailAddress(sender);
                Msg.To.Add(receiver);
                if (model.isApproved)
                {
                    reader = new StreamReader(HttpContext.Current.Server.MapPath("~/EmailTemplate/Notification.html"));
                    Msg.Subject = model.menuName + " - Notification";
                }
                else
                {
                    reader = new StreamReader(HttpContext.Current.Server.MapPath("~/EmailTemplate/Decline.html"));
                    Msg.Subject = model.menuName + " - Declination";                    
                }
                string readFile = reader.ReadToEnd();
                string StrContent = "";
                StrContent = readFile;

                StrContent = StrContent.Replace("[nextUser]", model.nextUser.ToString());
                StrContent = StrContent.Replace("[companyName]", model.companyName);
                StrContent = StrContent.Replace("[menuName]", model.menuName);
                StrContent = StrContent.Replace("[customCode]", model.customCode);
                StrContent = StrContent.Replace("[message]", model.message);
                StrContent = StrContent.Replace("[currentUser]", model.currentUser);
                StrContent = StrContent.Replace("[comments]", model.comments); 

                Msg.Body = StrContent.ToString();
                Msg.IsBodyHtml = true;

                using (var smtp = new SmtpClient())
                {
                    var credential = new NetworkCredential
                    {
                        UserName = "amberbusinesssuite@amber.com.bd",
                        Password = "suite.54#"
                    };
                    smtp.Credentials = credential;
                    smtp.Host = "mail.amber.com.bd";
                    smtp.Port = 25;
                    smtp.EnableSsl = false;
                    smtp.DeliveryMethod = System.Net.Mail.SmtpDeliveryMethod.Network;
                    smtp.Timeout = 50000;
                    await smtp.SendMailAsync(Msg);
                    result = 1;


                    
    }
            }
            catch (Exception ex)
            {
                ex.ToString();
                result = 0;
            }
            return result;
        }
    }
}