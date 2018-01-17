using System.Collections.Generic;

namespace SmtpSender.Data
{
    public interface IDataForm<T> : IData<T>
    {
        int? Port { get; set; }
        string MyName { get; set; }
        string MyMail { get; set; }
        string MyPassword { get; set; }
        string MailTo { get; set; }
        string TypeMail { get; set; }
        string TextMessage { get; set; }
        string Subject { get; set; }
        string TypeMyMail { get; set; }
        bool? IsSsl { get; set; }
        bool? IsHtml { get; set; }
        bool? IsAsyncSend { get; set; }
        string StatusSend { get; set; }
        List<string> Attachments { get;}
    }
}
