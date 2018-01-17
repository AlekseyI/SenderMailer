using System;
using Converters;
using Constants;
using System.Collections.Generic;
using System.Linq;

namespace SmtpSender.Data
{
    public class DataForm : IDataForm<MainForm>
    {

        public MainForm Entity { get; }

        public DataForm(MainForm container)
        {

            Entity = container ?? throw new ArgumentException(nameof(DataForm));
        }

        public int? Port
        {
            get => string.IsNullOrEmpty(Entity.Port.Text) ? throw new ArgumentException(MainConstants.PortError) :
                int.Parse(Entity.Port.Text);
            set => Entity.Port.Text = value.ToString();
        }

        public string MyName
        {
            get => string.IsNullOrEmpty(Entity.MyName.Text) ? throw new ArgumentException(MainConstants.MyNameError):
                Entity.MyName.Text;
            set => Entity.MyName.Text = value;
        }
        public string MyMail
        {
            get => string.IsNullOrEmpty(Entity.MyMail.Text) ? throw new ArgumentException(MainConstants.MyMailError) :
                Entity.MyMail.Text;
            set => Entity.MyMail.Text = value;
        }
        public string MyPassword
        {
            get => string.IsNullOrEmpty(Entity.MyPassword.Text) ? throw new ArgumentException(MainConstants.MyPasswordError) :
                Entity.MyPassword.Text;
            set => Entity.MyPassword.Text = value;
        }
        public string MailTo
        {
            get => string.IsNullOrEmpty(Entity.MailTo.Text) ? throw new ArgumentException(MainConstants.MailToError) :
                Entity.MailTo.Text;
            set => Entity.MailTo.Text = value;
        }
        public bool? IsSsl
        {
            get => Converter.IntToBool(Entity.IsSsl.SelectedIndex) ?? throw new ArgumentException(nameof(IsSsl));
            set => Entity.IsSsl.SelectedIndex = (int)Converter.BoolToInt(value) ;
        }
        public bool? IsHtml
        {
            get => Converter.IntToBool(Entity.IsHtml.SelectedIndex) ?? throw new ArgumentException(nameof(IsHtml));
            set => Entity.IsHtml.SelectedIndex = (int)Converter.BoolToInt(value);
        }
        public string TypeMail
        {
            get => Entity.TypeMail.Text.Substring(1, Entity.TypeMail.Text.Length - 1) ?? throw new ArgumentException(nameof(TypeMail));
            set => Entity.TypeMail.Text = MainConstants.Dog + value;
        }
        public string TypeMyMail
        {
            get => Entity.TypeMyMail.Text.Substring(1, Entity.TypeMyMail.Text.Length - 1) ?? throw new ArgumentException(nameof(TypeMyMail));
            set => Entity.TypeMyMail.Text = MainConstants.Dog + value;
        }
        public string Subject
        {
            get => string.IsNullOrEmpty(Entity.Subject.Text) ? throw new ArgumentException(MainConstants.SubjectError) :
                Entity.Subject.Text;
            set => Entity.Subject.Text = value;
        }
        public string TextMessage
        {
            get => Entity.TextMessage.Text;
            set => Entity.TextMessage.Text = value;
        }

        public bool? IsAsyncSend
        {
            get => Converter.IntToBool(Entity.IsAsyncSend.SelectedIndex) ?? throw new ArgumentException(nameof(IsAsyncSend));
            set => Entity.IsAsyncSend.SelectedIndex = (int)Converter.BoolToInt(value);
        }

        public string StatusSend
        {
            get => Entity.StatusSend.Text;
            set => Entity.StatusSend.Text = value;
        }
        public List<string> Attachments => Entity.OpenFiles.FileName != MainConstants.NoFiles ?
            Entity.OpenFiles.FileNames.ToList() :
            null;
    }
}
