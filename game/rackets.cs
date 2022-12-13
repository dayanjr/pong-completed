class rackets : numbers
{
    //int leftRacketHeight = 0;
    //int rightRacketHeight = 0;
     //int leftPlayerPoints = 0; 
    //int rightPlayerPoints = 0;

    
     private static int leftRacketHeight = 0;
     private static int rightRacketHeight = 0;
     private static int leftPlayerPoints = 0;
     private static int rightPlayerPoints = 0;
     public int getracket()
     {
      GetfieldWidth();
     var l = GetfieldWidth() / 2;
      return l;
     }

    public void setleftracketheight(int newheight)
    {
      leftRacketHeight = newheight;
    }
    public void setrightracketheight(int newheight)
    {
      rightRacketHeight = newheight;
    }
     public int GetleftRacketHeight()
     {
        return leftRacketHeight;
     }
     public int GetrightRacketHeight()
     {
        return rightRacketHeight;
     }
     public int GetleftPlayerPoints()
     {
        return leftPlayerPoints;
     }
     public int GetrightPlayerPoints()
     {
        return rightPlayerPoints;
     }
    
}