
class deal : numbers
{
    static void Main(string[] args)
    {
        numbers numb = new numbers();
        rackets rackets = new rackets();
        const char fieldFile = '#';
        const char racketTile = '|';
        const char ballTile = 'O';
        const int racketLength = 10 / 4;
        int ballx = numb.GetfieldLenght() / 2;
        int bally = numb.GetfieldWidth() / 2;
        bool isBallGoingDown = true;
        bool isBallGoingRight = true;
        int scoreboardx = numb.GetfieldLenght() / 2 - 2;
        int scoreboardy =  numb.GetfieldWidth() + 3;
        ///
        const int fieldWidth2 = 10;
        const int racketLength2 = fieldWidth2 / 4;
        int leftRacketHeight2 = 0;
        int rightRacketHeight2 = 0;
        ///

        string line = string.Concat(Enumerable.Repeat(fieldFile, numb.GetfieldLenght()));
         int leftRacketHeight = rackets.GetleftRacketHeight();
         int rightRacketHeight = rackets.GetrightRacketHeight();
         int leftplayerPoints = rackets.GetleftPlayerPoints();
         int rightplayerPoints = rackets.GetrightPlayerPoints();
        Console.Clear();

           while (true)
            {
                Console.SetCursorPosition(0, 0);
                Console.WriteLine(line);

                Console.SetCursorPosition(0, numb.GetfieldWidth());
                Console.WriteLine(line);
                for (int i = 0; i < racketLength; i++)
                {
                    Console.SetCursorPosition(0, i + 1 + rackets.GetleftRacketHeight());
                    Console.WriteLine(racketTile);
                    Console.SetCursorPosition(numb.GetfieldLenght() - 1, i + 1 + rackets.GetrightRacketHeight());
                    Console.WriteLine(racketTile);
                }

                while(!Console.KeyAvailable)
                {
                    Console.SetCursorPosition(ballx, bally);
                    Console.WriteLine(ballTile);
                    Thread.Sleep(100);
                    Console.SetCursorPosition(ballx, bally);
                    Console.WriteLine(' ');

                    if (isBallGoingDown)
                    {
                        bally++;
                    }
                    else
                    {
                        bally--;
                    }
                    if (isBallGoingRight){
                        ballx++;
                    }
                    else
                    {
                        ballx--;
                    }
                    if(bally == 1 || bally == numb.GetfieldWidth() - 1)
                    {
                        isBallGoingDown = !isBallGoingDown;
                    }
                    if(ballx == 1)
                    {
                        if(bally >= rackets.GetleftRacketHeight() + 1 && bally <= rackets.GetleftRacketHeight() + racketLength)
                        {
                            isBallGoingRight = !isBallGoingRight;
                        }
                        else
                        {
                            rightplayerPoints++;
                            bally = numb.GetfieldWidth() / 2;
                            ballx = numb.GetfieldLenght() / 2;
                            Console.SetCursorPosition(scoreboardx, scoreboardy);
                            Console.WriteLine($"{leftplayerPoints} | {rightplayerPoints}");
                             if(rackets.GetleftPlayerPoints() == 10)
                            {
                                goto outer;

                            }

                        }
                    }
                    if(ballx == numb.GetfieldLenght() - 2)
                    {
                        if(bally >= rightRacketHeight + 1 && bally <= rightRacketHeight + racketLength)
                        {
                            isBallGoingRight = !isBallGoingRight;
                        }
                        else
                        {
                            
                            leftplayerPoints++;
                            bally = numb.GetfieldWidth() / 2;
                            ballx = numb.GetfieldLenght() / 2;
                            Console.SetCursorPosition(scoreboardx, scoreboardy);
                            Console.WriteLine($"{leftplayerPoints} | {rightplayerPoints}");
                            if(rackets.GetrightPlayerPoints() == 10)
                            {
                                goto outer;

                            }

                        }
                    }


                }
                switch (Console.ReadKey().Key)
               {
                  case ConsoleKey.UpArrow:
                    if(rightRacketHeight2 > 0)
                    {
                      rightRacketHeight2--;
                    }
                    break;
                  case ConsoleKey.DownArrow:
                    if(rightRacketHeight2 < fieldWidth2 - racketLength2 - 1)
                    {
                      rightRacketHeight2++;
                    }
                    break;
                  case ConsoleKey.W:
                    if(leftRacketHeight2 > 0)
                    {
                      leftRacketHeight2--;
                    }
                    break;
                  case ConsoleKey.S:
                    if(leftRacketHeight2 < fieldWidth2 - racketLength2 - 1)
                    {
                      leftRacketHeight2++;
                    }
                    break;
                }
                  for (int i = 1; i < numb.GetfieldWidth(); i++)
                {
                    Console.SetCursorPosition(0, i);
                    Console.WriteLine(" ");
                    Console.SetCursorPosition(numb.GetfieldLenght() - 1, i);
                    Console.WriteLine(" ");
                }
               
            }
            outer:;
            Console.Clear();
            Console.SetCursorPosition(0, 0);
            if(rackets.GetrightPlayerPoints() == 10)
            {
                Console.WriteLine("Right player won!");
            }
            else
            {
              Console.WriteLine("Left player won!");  
            }
        
    }
}