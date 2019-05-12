﻿using System;

using MailKit.Net.Smtp;
using MailKit;
using MimeKit;

namespace Domain
{
    public class EmailSender
    {


        public void SendEmail(Player player)
        {
            using (var client = new SmtpClient())
            {

                var message = new MimeMessage();
                message.From.Add(new MailboxAddress("PoolChampion App", "CwPoolChampion@gmail.com"));
                message.To.Add(new MailboxAddress($"{player.Name}", $"{player.EmailAdress}"));
                message.Subject = "You have a pending PoolChampion game to confirm";

                message.Body = new TextPart("plain")
                {
                    Text = $@"Hi {player.Name}," +
                    	"\n\nI just wanted to let you know that Monica and I were going to go play some paintball, you in?\n\n-- Joey"
                };

                client.ServerCertificateValidationCallback = (s, c, h, e) => true;

                client.Connect("smtp.gmail.com", 587, false);

                // Note: only needed if the SMTP server requires authentication
                client.Authenticate("CwPoolChampion", "NgBYNK4A5QgN2ss8");

                client.Send(message);
                client.Disconnect(true);
            }
        }


    }
}