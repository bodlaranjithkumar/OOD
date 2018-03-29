//using System;
//using System.Collections.Generic;

//namespace ObjectOrientedDesign
//{
//    class Deck
//    {
//        List<Card> cards;

//        public void Shuffle() { }
//        public void Sort() { }
//    }

//    class Card
//    {
//        public int value;
//        public Symbol symbol;
//    }

//    enum Symbol
//    {
//        Club,
//        Spade,
//        Diamond,
//        Heart
//    }

//    class Hand
//    {
//        public List<Card> Cards;

//        //public virtual int Score() { }
//    }

//    class Machine
//    {
//        Game game;

//        public static void Main()
//        {
//            Console.WriteLine("Select a game from below list:\n 1 - BlackJack \t 2 - Poker ");
//            int gameNumber = Console.Read();
//            StartGame(gameNumber);
//        }

//        private static void StartGame(int gameNumber)
//        {
//            switch (gameNumber)
//            {
//                case 1:
//                    game = new BlackJack();
//                    break;
//                case 2:
//                    game = new Poker();
//                    break;
//            }
//            game.play();
//        }

//        // displays the winner to the console
//        private void DisplayWinner(Player player) { }
//    }

//    abstract class Game
//    {
//        public virtual void Play()
//        {
//            Deck deck = new Deck();
//            deck.shuffle();
//        }

//        // maps score for each player in the game.
//        public void BuildScoresMap() { }

//        public abstract player FindWinner(List<Player> players) { }
//    }

//    class Player
//    {
//        int score;
//        int getScore() { return score; }

//        void SetScore(int score) { this.score = score; }
//    }

//    class BlackJack : Game
//    {
//        // Steps of the game
//        public override void Play() { }

//        // Game rules to find the winner.
//        public override player FindWinner(List<Player> players) { }
//    }

//    class BlackJackHand : Hand
//    {
//        public override int Score() { }

//        // Computes combination of sum of face card values. This differs when one of the card is Ace.
//        private List<int> PossibleScores() { }

//        public void SetScore(Player player)
//        {
//            player.setScore(score);
//        }
//    }

//    class Poker : Game
//    {
//        // Steps of the game
//        public override void Play() { }

//        // Game rules to find the winner.
//        public override Player FindWinner(List<Player> players) { }
//    }

//    class PokerHand : Hand
//    {
//        public override int Score() { }

//        public void SetScore(Player player)
//        {
//            player.SetScore(score);
//        }
//    }
//}