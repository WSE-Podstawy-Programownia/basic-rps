using System;
using static System.Console;

class MainClass {
  static void DisplayWelcomeMessage (){
  WriteLine ("Witaj w grze papier, kamień, nożyce ;)");}

  static string wyborgraczaInput (string player){
  // wnętrze funkcji
  string rawInput;
  string properInput="";
   WriteLine ("{0} proszę wybrać papier (naciśnij 1) / kamień (naciśnij 2) / nożyce (naciśnij 3)", player);

    rawInput = ReadLine();


while (rawInput != "1" && rawInput != "2" && rawInput != "3") {
  WriteLine ("Źle wprowadzona liczba. Proszę wybrać ponownie papier (naciśnij 1) / kamień (naciśnij 2) / nożyce (naciśnij 3)");
  rawInput = ReadLine();
}

  if (rawInput == "1") { properInput = "Papier"; }
else if (rawInput == "2") { properInput = "Kamień"; }
else { properInput = "Nożyce"; }

return properInput;
}

static string DetermineWinner (string wyborgracza1String, string wyborgracza2String){
 
   /* if (wyborgracza1String == wyborgracza2String)
    {
      Console.WriteLine("Remis");
      Tabelawynikow[TabelawynikowCurrentIndex, 2] = "Remis";
    }
    if (wyborgracza1String == "1" && wyborgracza2String == "2")
    {
      Console.WriteLine("Wygrał gracz nr 1");
      Tabelawynikow[TabelawynikowCurrentIndex, 2] = "Pierwszy";
    }
    if (wyborgracza1String == "2" && wyborgracza2String == "1")
    {
      Console.WriteLine("Wygrał gracz nr 2");
      Tabelawynikow[TabelawynikowCurrentIndex, 2] = "Drugi";
    }
    if (wyborgracza1String == "1" && wyborgracza2String == "3")
    {
      Console.WriteLine("Wygrał gracz nr 2");
      Tabelawynikow[TabelawynikowCurrentIndex, 2] = "Drugi";
    }
    if (wyborgracza1String == "3" && wyborgracza2String == "1")
    {
      Console.WriteLine("Wygrał gracz nr 1");
      Tabelawynikow[TabelawynikowCurrentIndex, 2] = "Pierwszy";
    }
  if (wyborgracza1String == "2" && wyborgracza2String == "3")
    {
      Console.WriteLine("Wygrał gracz nr 1");
      Tabelawynikow[TabelawynikowCurrentIndex, 2] = "Pierwszy";
    }
  if (wyborgracza1String == "3" && wyborgracza2String == "2")
    {
      Console.WriteLine("Wygrał gracz nr 2");
      Tabelawynikow[TabelawynikowCurrentIndex, 2] = "Drugi";
    }*/

    if (wyborgracza1String == wyborgracza2String){
  WriteLine ("Remis");
  return "Remis";
}

else if ((wyborgracza1String == "2" && wyborgracza2String == "3") ||
         (wyborgracza1String == "1" && wyborgracza2String == "2") ||
         (wyborgracza1String == "3" && wyborgracza2String == "1")){
  Console.WriteLine ("Wygrał gracz nr 1!");
  return "Wygrał gracz nr 1";
}

else {
  Console.WriteLine ("Wygrał gracz nr 2!");
  return "Wygrał gracz nr 2";
}


}


  public static void Main (string[] args) {
    int TabelawynikowSize = 10;
  string[,] Tabelawynikow = new string[TabelawynikowSize,3];

  


    int TabelawynikowCurrentIndex = 0;

    do {

      DisplayWelcomeMessage();
    /*Console.WriteLine ("Witaj w grze papier, kamień, nożyce ;)");*/
    /*Console.WriteLine ("Graczu nr. 1 proszę wybrać papier (naciśnij 1) / kamień (naciśnij 2) / nożyce (naciśnij 3)");*/

   

string wyborgracza1String = wyborgraczaInput("Gracz1");
Tabelawynikow[TabelawynikowCurrentIndex, 0] = wyborgracza1String;

    /*Tabelawynikow[TabelawynikowCurrentIndex, 0] = wyborgracza1String;*/
    /*Console.WriteLine ("Graczu nr. 2 proszę wybrać papier (naciśnij 1) / kamień (naciśnij 2) / nożyce (naciśnij 3)");
    string wyborgracza2String = Console.ReadLine();
    Tabelawynikow[TabelawynikowCurrentIndex, 1] = wyborgracza2String;*/



string wyborgracza2String = wyborgraczaInput("Gracz2");
Tabelawynikow[TabelawynikowCurrentIndex, 1] = wyborgracza2String;




/* 
  string wyborgracza1String = Console.ReadLine();
  string wyborgracza2String = Console.ReadLine();
Tabelawynikow[TabelawynikowCurrentIndex, 2] = "Pierwszy";
Tabelawynikow[TabelawynikowCurrentIndex, 2] = "Drugi";
TabelawynikowCurrentIndex += 1;
*/

Tabelawynikow[TabelawynikowCurrentIndex, 2] = DetermineWinner(wyborgracza1StringString, wyborgracza2StringString);


Console.WriteLine ("Czy chcesz zakończyć rozgrywkę? (t)");
   } while (Console.ReadLine() != "t");

int TabelawynikowIndex = 0;
int TabelawynikowCurrentSize = 0;


for (int i = 0; i < TabelawynikowIndex; i++){
  Console.WriteLine ("Gra #{0}: {1} - {2}, wygrał gracz {3}",
    i+1, Tabelawynikow[i,0], Tabelawynikow[i,1], Tabelawynikow[i,2]);
}


TabelawynikowCurrentIndex = (TabelawynikowCurrentIndex + 1) % TabelawynikowSize;
if (TabelawynikowCurrentSize < TabelawynikowSize){
  TabelawynikowCurrentSize++;
}

int currentIndex;
if (TabelawynikowCurrentSize < TabelawynikowSize){
  currentIndex = 0;
}
else {
  currentIndex = TabelawynikowCurrentIndex;
}


for (int i = 0; i < TabelawynikowCurrentSize; i++){
    Console.WriteLine ("Gra #{0}: {1} - {2}, wygrał gracz {3}",
    i+1, Tabelawynikow[currentIndex,0], Tabelawynikow[currentIndex,1], Tabelawynikow[currentIndex,2]);
    currentIndex = (currentIndex + 1) % TabelawynikowCurrentSize;
}


}
}