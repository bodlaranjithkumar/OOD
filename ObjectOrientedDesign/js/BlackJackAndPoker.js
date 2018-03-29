// Represents a deck of cards
var Deck = function() {
	var cards = new Array();
	
	var pushCard = function(card){
		cards.push(card);
	}
	
	var shuffle = function() {}
	var sort = function() {}
}

var Card = function(){
	var value;
	var symbol;
}

var SymbolEnum = {
	Club : 1,
	Spade: 2,
	Diamond: 3,
	Heart: 4
}

var Hand = function() {
	var cards = new Array();
	
	var pushCard = function(card){
		cards.push(card);
	}
	
	var score = function(){}
}

var Machine = function() {
	var game = Prompt("Select a game from below list:\n 1 - BlackJack \t 2 - Poker");
}

Machine.prototype.startGame = function(game){
	switch(gameNumber){
		case 1:
			game = new BlackJack();
		case 2: 
			game = new Poker();
	}			
	game.play();
}
	
// displays the winner to the console
Machine.prototype.displayWinner = function(player){}

// helper function for adding inheritance
var inheritsFrom = function (child, parent) {
    child.prototype = Object.create(parent.prototype);
};


var Game = function() {}

Game.prototype.play = function(){
	var deck = new Deck();
	deck.shuffle();
}
Game.prototype.buildScoresMap = function(){}
Game.prototype.findWinner = function(players){}


var Player = function(){
	var score;
}


var BlackJack = function(){}
inheritsFrom(BlackJack, Game)

// Steps of the game
BlackJack.prototype.play = function(){
	Game.prototype.play.call(this);	
}

// Game rules to find the winner.
BlackJack.prototype.findWinner = function(hands){
	Game.prototype.call(this);
}

var BlackJackHand = function(){}
inheritsFrom(BlackJackHand, Hand)

BlackJackHand.prototype.Score = function(){
	Hand.prototype.call(this);	
}

// Computes combination of sum of face card values. This differs when one of the card is Ace.
BlackJackHand.prototype.possibleScores = function(){}
BlackJackHand.prototype.setScore = function(player){}	



var Poker = function(){}
inheritsFrom(Poker, Game)

// Steps of the game
Poker.prototype.play = function(){
	Game.prototype.play.call(this);	
}

// Game rules to find the winner.
Poker.prototype.findWinner = function(hands){
	Game.prototype.call(this);
}


var PokerHand = function(){}
inheritsFrom(PokerHand, Hand)

PokerHand.prototype.Score = function(){
	Hand.prototype.call(this);	
}

// Computes combination of sum of face card values. This differs when one of the card is Ace.
PokerHand.prototype.possibleScores = function(){}
PokerHand.prototype.setScore = function(player){}	