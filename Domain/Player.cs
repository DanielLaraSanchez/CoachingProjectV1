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
            if((game.Player1.Name == this.Name || game.Player2.Name == this.Name) && this.Name != game.Creator.Name)
            {
                game.IsConfirmed = true;//here we will have to wait for the confirmation coming back from player that has been sent a link to the confirmation modal.

            }
        }

        public void SetGameResults(Game game, Player player)
        {
            Player playerToBeSentConfirmationEmail = DecideWhoIsToBeSentConfirmationEmail(game);

            if (game.Player1.Name == this.Name || game.Player2.Name == this.Name)
            {
                game.Winner = player;
                game.EmailSender().SendEmail(playerToBeSentConfirmationEmail);//players should have like a "pending confirmation inbox" which will be automatically loaded first thing when logging in. in case there is no items pending first thing loaded will be the creation of game form. 
            }
           
        }

        public Player DecideWhoIsToBeSentConfirmationEmail(Game game)
        {
            if(game.Player1.Name == this.Name)
            {
                return game.Player2;
            }
            return game.Player1;
        }

        public Game CreateGame(Player player1, Player player2)
        {
            Game game = new Game(player1, player2);
            game.Creator = this;
            return game;
        }


    }

}
