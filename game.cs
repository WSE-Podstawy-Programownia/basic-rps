using System;
using static System.Console;
using System.Collections.Generic;

class Game {
  Player playerOne, playerTwo;
   //dodawanie slownika
 Dictionary<string, string> inputTable = new Dictionary<string, string> () 
    {
      {"1", "Rock"},
      {"2", "Paper"},
      {"3", "Scissors"}
    };
  public GamesRecord gamesRecord;

  public Game (bool singleplayer = false) {
    playerOne = new Player ();
    if (singleplayer) playerTwo = new AIPlayer ();
    else playerTwo = new Player ();
    gamesRecord = new GamesRecord ();
  }

  public string GetPlayerInput (Player player){
    string rawInput;
    string properInput;
    WriteLine ("{0}, Choose:\n[1] Rock\n[2] Paper\n[3] Scissors", player.playerName);
    rawInput = ReadLine();

    while (rawInput != "1" && rawInput != "2" && rawInput != "3") {
        WriteLine ("Wrong input. Please enter correct one.\nPlayer One, choose:\n[1] Rock\n[2] Paper\n[3] Scissors");
        rawInput = ReadLine();
    }

    if (rawInput == "1") { properInput = "Rock"; }
    else if (rawInput == "2") { properInput = "Paper"; }
    else { properInput = "Scissors"; }
    return properInput;
  }

// modyfikacja determineWinner 2c - 63
  public string DetermineWinner (Player playerOne, Player playerTwo){
    if (playerOne.lastInput == playerTwo.lastInput){
        WriteLine ("It's a draw!");
        return "Draw";
    }
    else if ((playerOne.lastInput == "Rock" && playerTwo.lastInput == "Scissors") ||
            (playerOne.lastInput == "Paper" && playerTwo.lastInput == "Rock") ||
            (playerOne.lastInput == "Scissors" && playerTwo.lastInput == "Paper")){
      Console.WriteLine ("{0} won!", playerOne.playerName);
      return String.Format("{0} won!", playerOne.playerName);
    }
    else{
      Console.WriteLine ("{0} won!", playerTwo.playerName);
      return String.Format("{0} won!", playerTwo.playerName);
    }
  }


  public void Play () {
    Clear ();

    playerOne.GetInput(inputTable);
    // string firstPlayerChoiceString = GetPlayerInput(playerOne);

    Clear ();

    playerTwo.GetInput(inputTable);
    // string secondPlayerChoiceString = GetPlayerInput(playerTwo);

    Clear ();

    string gameResult = DetermineWinner(playerOne, playerTwo);
    gamesRecord.AddRecord(playerOne.lastInput, playerTwo.lastInput, gameResult);  //2c-62, pozbycie sie stringow

    WriteLine("Do you want to play another round? [y]");
    if (ReadKey(true).Key == ConsoleKey.Y){
      Play();
    }
  }

  // public void MainMenuLoop (){
  //   ConsoleKeyInfo inputKey;
  //   do {
  //     Clear();
  //     WriteLine ("Rock-Paper-Scissors Menu:\n\t[1] Play a game\n\t[2] Show rules\n\t[3] Display last games' record\n\t[ESC] Exit");
  //     inputKey = ReadKey(true);

  //     if (inputKey.Key == ConsoleKey.D1){
  //       //po wybraniu Play tworzyła nowy obiekt Game i na nim wywoływała metodę Play 1b
  //       game = new Game();
  //       game.Play();  
  //     }

  //     else if (inputKey.Key == ConsoleKey.D2){
  //       DisplayRules(false);
  //     }

  //     else if (inputKey.Key == ConsoleKey.D3){
  //       gamesRecord.DisplayGamesHistory();
  //     }

  //     else { continue; }
  //     WriteLine ("(click any key to continue)");
  //     ReadKey(true);
  //   } while (inputKey.Key != ConsoleKey.Escape);
  // }
}
