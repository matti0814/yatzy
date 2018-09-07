using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Yatzy
{
    public class YatzyEngine
    {

        public List<Dice> CreateFiveDices()
        {
            List<Dice> diceList = new List<Dice>();
            for (int i = 0; i < 6; i++)

            {
                diceList.Add(new Dice());
            }
            return diceList;
        } // Skapar fem tärningar
        public List<Dice> Kasta(List<Dice> dices)
        {
            Random side = new Random();       
            foreach (var item in dices)
            {
                item.Side = side.Next(1, 7);
            }
            return dices;

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
