using System;
using System.Collections.Generic;
using System.Linq;
using Domain;
using NUnit.Framework;
using Shouldly;

using MailKit.Net.Smtp;
using MailKit;
using MimeKit;

namespace DomainTest
{
    [TestFixture]
    public class EmailSenderTest
    {
        [Test]
        [Category("Unit")]
        public void CanSendEmail()
        {
            var player1 = new Player("Daniel");
            player1.EmailAdress = "daniellaraedinburgh@gmail.com";
            var emailAddress = player1.EmailAdress;
            var EmailSender = new EmailSender();
            EmailSender.SendEmail(player1);
            emailAddress.ShouldNotBe(null);
        }
    }
}
