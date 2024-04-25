using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLIDPrinciples
{
    /// <summary>
    /// Open/Closed Principle - Принцип открытости / закрытости
    /// Сущности программы должны быть открыты для расширения, но закрыты для изменения
    /// </summary>
    internal class O
    {
        private void example()
        {
            var text = "вам пришла ЗП 124 рубля";
            NotificationService.SendNotification(new SMSNotification(text));
            text = "у нас появилось очередное ультравыгодное предложение";
            NotificationService.SendNotification(new EmailNotification(text));
        }
    }
    public static class NotificationService
    {
        public static void SendNotification(INotification notification)
        {
            notification.SendNotification(notification.Text);
        }
    }
    public interface INotification 
    {
        public string Text { get; }
        public void SendNotification(string text);
    }

    public class EmailNotification : INotification
    {
        public string Text { get; }

        public EmailNotification(string text)
        {
            Text = text;
        }

        public void SendNotification(string text)
        {
            //отправить уведомление по почте
        }
    }
    public class SMSNotification : INotification
    {
        public string Text { get; }

        public SMSNotification(string text)
        {
            Text = text;
        }

        public void SendNotification(string text)
        {
            //отправить уведомление по SMS
        }
    }
}
