namespace Lib.ProblemSolving;

public static class Challenge2
{
    public static int DiceFacesCalculator(int dice1, int dice2, int dice3)
    {
        int[] diceValuesArray = { dice1, dice2, dice3 };

        //Given there are dices, numbers must be between 1 and 6, if not, throw exception
        //run a first iteration and those tests to fail before put this border case.

        if (diceValuesArray.Any(x => x < 1 || x > 6))
        {
            throw new Exception("Dice out of number range");
        }

        //if the 3 dices are equal, return dice value multiplied by 3
        if (dice1 == dice2 && dice2 == dice3)
        {
            return dice1 * 3;
        }
        else
        {
            //if dice1 is equal to dice2 or dice3, return dice1 value multiplied by 2
            if (dice1 == dice2 || dice1 == dice3)
            {
                return dice1 * 2;
            }
            else
            {
                //if dice2 is equal to dice 3, return dice2 muliplied by 2
                if (dice2 == dice3)
                {
                    return dice2 * 2;
                }
                else
                {
                    //if the 3 dices are different, return the greatest value.
                    return Math.Max(diceValuesArray[0], Math.Max(diceValuesArray[1], diceValuesArray[2]));
                }
            }
        }
    }
}