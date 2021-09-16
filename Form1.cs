using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Net;
using System.Net.Mail;
using System.Threading;
using System.Timers;
using System.Security;

namespace Sendmailz
{
    public partial class Form1 : Form
    {
       // private System.Timers.Timer timerClock = new System.Timers.Timer();
        private const int TIMER_INTERVAL = 50;
        private string TimeStamp, CBody;
        private int count;
        private bool MailSent;
        //Email variable
        private string SMTPserver, IDstr, FromEmail, FromName, ToList, Subject, Body, Password;
        private int Port;
        private bool bSSL;
        //__________________________


        public Form1()
        {
            InitializeComponent();
            timer1.Interval = TIMER_INTERVAL;
            timer1.Start();
        }




        private void button1_Click(object sender, EventArgs e)
        {
            
           // MessageBox mymessage;
            SMTPserver = TBSMTP.Text.ToString();
            IDstr =TBID.Text.ToString();
            Port = int.Parse(TBPORT.Text);
            Password =MBTPASS.Text.ToString();

            ToList =TBTO.Text.ToString();
            FromEmail= TBFROM.Text.ToString();
            FromName =TBAKA.Text.ToString();
            Subject =TBSUBJECT.Text.ToString();
            Body = RTBBODY.Text.ToString();
            if (CBSSL.Checked)
                bSSL = true;
            else
                bSSL = false;


            TimeStamp = "\n\n\n\nTimestamp->" + "." + TBHour.Text + "." + TBMinu.Text + "." + TBSeco.Text;
            Body += TimeStamp;

            count =0;
            while(count<5)
            {
               MailSent = sendMail(bSSL, SMTPserver, IDstr, Port, FromEmail, FromName, ToList, Subject, Body, Password);
                

                if (MailSent)
                {
                    MessageBox.Show("MAIL SENT! \n\r SUCESS!", "RESULT:",MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    break;
                }
                else
                {
                    count++;
                }

            }
            if (count >0)
                MessageBox.Show("MAIL SENDING \n\r FAILED", "RESULT:",MessageBoxButtons.OK, MessageBoxIcon.Error);

        }


        public bool sendMail(bool bSSL,string SMTPserver, string IDstr, int Port,string FromEmail, string FromName, string ToList, string Subject, string Body, string Password)
        {
            MailMessage Msg = new MailMessage();
            //change body into html format
            Body = Body.Replace("\n", "\n<br>");
            //set message sender
            Msg.From = new MailAddress(FromEmail, FromName);

            //sets the mail recipients                                 //person(s) who will receive an email
            //(in this case 2 person will be emailed)
            Msg.To.Add(new MailAddress(ToList));

            //set to true if you want to use html in the body
            Msg.IsBodyHtml = true;
            Msg.Subject = Subject;

            //body of the email message with html tag
            Msg.Body = Body;

            //Allows applications to send e-mail
            // host server :  smtp.gmail.com
            //port number : 587
            SmtpClient objMail = new SmtpClient(SMTPserver, Port);

            //Some SMTP servers require you to authenticate first
            //gmail uses SSL      
            //info object contains the gmail
            //username, and password
            NetworkCredential info = new NetworkCredential(IDstr, Password);

            objMail.DeliveryMethod = SmtpDeliveryMethod.Network;
            objMail.Credentials = info;
            objMail.EnableSsl = bSSL;

            try
            {
                //final step send email
                objMail.Send(Msg);
                return true;
            }
            catch
            {
                return false;
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            string m_CSec = DateTime.Now.Second.ToString();
            string m_CMin = DateTime.Now.Minute.ToString();
            string m_CHor = DateTime.Now.Hour.ToString();
            
            TBHour.Text = m_CHor;
            TBMinu.Text = m_CMin;
            TBSeco.Text = m_CSec;
            if (AlarmTog.Checked)
            {
                NUDHor.Enabled = false;
                NUDMin.Enabled = false;
                NUDSec.Enabled = false;

                if ((m_CSec == NUDSec.Value.ToString()) && (m_CMin == NUDMin.Value.ToString()) && (m_CHor == NUDHor.Value.ToString()))//alarm on
                {                   
                    button1_Click(sender, e);
                    timer1.Stop();

                }
            }
            else
            {
                NUDHor.Enabled = true;
                NUDMin.Enabled = true;
                NUDSec.Enabled = true;
            }


            if (CBLSC.Checked)
            {
                TBSMTP.Enabled = false;
                TBID.Enabled = false;
                TBPORT.Enabled = false;
                MBTPASS.Enabled = false;
            }
            else
            {
                TBSMTP.Enabled = true;
                TBID.Enabled = true;
                TBPORT.Enabled = true;
                MBTPASS.Enabled = true;
            }


        }

        private void Form1_Load(object sender, EventArgs e)
        {
            TBSeco.Enabled = false;
            TBMinu.Enabled = false;
            TBHour.Enabled = false;

            FromEmail = "something@someting.com";
            FromName = "As Known As who";
            ToList = " some@somelocation.com";
            Subject = "Regarding ";
            Body = String.Format
                (
                "Dear Madam / Sir," +
                "  \n\n" +
                "\n" +
                "Best regards,\n" +
                "Jaewoo Joung\n" +
                "\n" +
                "DAS(Driver Assistance Systems) R&D Engineer\n" +
                "Mando Hella Elektronik\n" +
                "10-42, Songdo-dong, Yeonsu-gu, Incheon, Rep of KOREA, 406-840\n" +
                "Phone:   +82-(0)32-850-7252\n" +
                "Fax:       +82 (0) 32-850-7111\n" +
                "Mobile:  +82-(0)10-9317-7628\n" +
                "MAIL:   jjoung@mandohella.com\n" +
                "   \n"   
                );
            SMTPserver = "smtp.gmail.com";
            IDstr = "youremail@gmail.com";
 
            Port = 587;
            bSSL = true;
            Password = "typeyourpassword";



            TBSMTP.Text = SMTPserver;
            TBID.Text = IDstr;
            TBPORT.Text = Port.ToString();
            MBTPASS.Text = Password;
            

            TBFROM.Text = FromEmail;
            TBTO.Text =  ToList;
            TBAKA.Text = FromName;
            TBSUBJECT.Text = Subject;
            RTBBODY.Text = Body;

            CBSSL.CheckState = CheckState.Checked;
            CBLSC.CheckState = CheckState.Unchecked;
            MailSent =false;

        }




    }

 
 
}
