using System;
using System.Net;
using System.Threading.Tasks;
using System.Net.Mail;
using Constants;
using ISednders;
using SmtpSender.Data;
using SmtpSender;
using System.ComponentModel;

namespace Senders
{
    public class SmtpSender : ISender<IDataForm<MainForm>>
    {

        private MailMessage _mailMessage;
        private SmtpClient _smtpClient;

        private IDataForm<MainForm> _data;


        public IDataForm<MainForm> Data => _data;

        public SmtpSender(IDataForm<MainForm> data)
        {

            _data = data ?? throw new ArgumentException(nameof(data));
            InitSettingsAndFillDataMail();
        }

        public SmtpSender() { }

        private void InitSettingsAndFillDataMail()
        {
            MailAddress from = new MailAddress(_data.MyMail + MainConstants.Dog + _data.TypeMyMail, _data.MyName);
            MailAddress to = new MailAddress(_data.MailTo + MainConstants.Dog + _data.TypeMail);
            _mailMessage = new MailMessage(from, to);
            _smtpClient = new SmtpClient(MainConstants.SmtpHost + "." + _data.TypeMail, (int)_data.Port);
            _smtpClient.EnableSsl = (bool)_data.IsSsl;
            _mailMessage.IsBodyHtml = (bool)_data.IsHtml;
            _mailMessage.Body = _data.TextMessage +
                (_mailMessage.IsBodyHtml ?
                MainConstants.PleasureHtml :
                MainConstants.PleasureText) +
                _data.MyName;
            _mailMessage.Subject = _data.Subject;
            _smtpClient.Credentials = new NetworkCredential(_data.MyMail + MainConstants.Dog + _data.TypeMyMail,
                _data.MyPassword);
            if (!(_data.Attachments is null))
                _data.Attachments.ForEach((file) => _mailMessage.Attachments.Add(new Attachment(file)));
        }


        public void Send()
        {
            SetInProcessStatus();
           
            try
            {
                if ((bool)_data.IsAsyncSend)
                {
                    _smtpClient.SendCompleted += _smtpClient_SendCompleted;
                    SendAwait().GetAwaiter();
                }
                else
                {
                    _smtpClient.Send(_mailMessage);
                    ClearDataAndStatusAfterExitTime();

                }
            }
            catch(Exception ex)
            {
                ClearDataAndStatusAfterExitTime(ex.Message);
                throw new SmtpException(ex.Message);
            }
            


        }

        private void ClearDataAndStatusAfterExitTime(string error = null)
        {
            
            _data.StatusSend = error is null ? MainConstants.Complete : MainConstants.SendError;
            _smtpClient.Dispose();
            var delayShow = Task.Delay(MainConstants.ShowTimeStatus).
              ContinueWith(_ =>
              {
                  _data.StatusSend = null;
              });
            delayShow.Wait();
        }

        private void SetInProcessStatus()
        {
            var showStatus = new Task(() =>
            {
                _data.StatusSend = MainConstants.InProcess;
            });
            showStatus.Start();
            showStatus.Wait();
        }




        private void _smtpClient_SendCompleted(object sender, AsyncCompletedEventArgs e)
        {
            ClearDataAndStatusAfterExitTime();
            _smtpClient.SendCompleted -= _smtpClient_SendCompleted;
            
        }

        private async Task SendAwait()
        {
            await _smtpClient.SendMailAsync(_mailMessage);
        }
    }
}
