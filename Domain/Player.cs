using System;
using System.Linq;


namespace Domain
{
    public class Player
    {
        public string Name { get; set; }
        public string EmailAdress { get; set; }

       

         public Player (string name)
        {
            Name = name;
        }

        public Player(string name, string emailAddress)
        {
            Name = name;
            EmailAdress = emailAddress;
        }

        public void ConfirmGame(Game game)
        {
            game.IsConfirmed = true;
        }




    }
}
