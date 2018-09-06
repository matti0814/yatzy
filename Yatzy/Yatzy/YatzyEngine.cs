using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Yatzy
{
    public class YatzyEngine
    {
        public List<Dice> Kasta(int amount)
        {

            Random side = new Random();
            List<Dice> diceList = new List<Dice>();
            for (int i = 0; i < amount; i++)

            {
                diceList.Add(new Dice());
            }
            foreach (var item in diceList)
            {
                item.Side = side.Next(1, 7);
            }
            return diceList;

        } //Kastar tärningar
        public int totalScoreFromThrow(List<Dice> thrownDices)
        {
            int sum = 0;
            foreach (var item in thrownDices)
            {
                sum += item.Side;
            }
            return sum;
        } //Räknar ut summan av tärningarna
        

    
        

    }
}
