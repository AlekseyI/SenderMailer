using System.Collections.Generic;

namespace Constants
{
    public static class MainConstants
    {
        public const int Port = 587;

        public const int ShowTimeStatus = 3000;

        public const string Dog = "@";

        public const string NoFiles = "FileName";

        public const string SmtpHost = "smtp";
        public const string SendError = "Возникла ошибка при отправке";

        public const string PleasureHtml = "<br><br>--------------------<br>С Уважением,<br>";
        public const string PleasureText = "\n\n--------------------\nС Уважением,\n";

        public const string Complete = "Отправлено";
        public const string InProcess = "Отправляется...";

        public const string CaptionError = "Ошибка";

        public const string MyMailError = "Не указана ваша почта";
        public const string MyPasswordError = "Вы не указали пароль к своей почте";
        public const string SubjectError = "Забыли про тему письма";
        public const string MailToError = "Кому отправлять???";
        public const string MyNameError = "Не указано имя отправителя";
        public const string PortError = "Неправильно указан порт";



        public static List<string> Mails = new List<string>()
        {
            "mail.ru",
            "gmail.com",
            "yandex.ru" 
        };
    }

   
}
