using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using Constants;
using SmtpSender.Data;
using Converters;


namespace SmtpSender
{
    public partial class MainForm : Form
    {



        public MainForm()
        {
            InitializeComponent();
            InitSettings();


        }




        private void InitSettings()
        {

            IsSsl.SelectedIndex = (int)Converter.BoolToInt(true);
            Port.Text = MainConstants.Port.ToString();
            IsHtml.SelectedIndex = (int)Converter.BoolToInt(true);
            var dataMails = MainConstants.Mails.Select((mail) => MainConstants.Dog + mail).ToList();
            TypeMail.DataSource = dataMails;
            dataMails.ForEach((item) => TypeMyMail.Items.Add(item));
            TypeMyMail.SelectedIndex = 0;
            IsAsyncSend.SelectedIndex = (int)Converter.BoolToInt(true);
            

        }


        private void buttonFile_Click(object sender, EventArgs e)
        {
            if (OpenFiles.ShowDialog() == DialogResult.OK)
            {
                AttachFiles.DataSource = OpenFiles.SafeFileNames;
            }
        }

        private void buttonSend_Click(object sender, EventArgs e)
        {
            try
            {
                var senderMails = new Senders.SmtpSender(new DataForm(this));
                senderMails.Send();
            }
            catch(Exception ex)
            {
                MessageBox.Show(this, ex.Message, MainConstants.CaptionError, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }
    }
}
