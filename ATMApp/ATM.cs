using ATMapp;

namespace ATMapp
{
    public class ATM
    {
        private int hundred = 10;
        private int fifty = 10;
        private int twenty = 10;
        private int ten = 10;
        private int five = 10;
        private int one = 10;

        public ATM()
        { }
        public void reset()
        {
            hundred = 10;
            fifty = 10;
            twenty = 10;
            ten = 10;
            five = 10;
            one = 10;
        }
        public string DisplayAmounts()
        {
            return "Hundred " + hundred + " Fifty " + fifty + " Twenty " + twenty + " Ten " + ten + " Five " + five + " One " + one;
        }
        public bool Withdraw(int something)
        {
            {
                if (hundred > 0)
                {
                    while (something % 100 == 0 && something >= 100)
                    {
                        something -= 100;
                        hundred -= 1;
                    }
                }
                if (fifty > 0)
                {
                    while (something % 50 == 0 && something >= 50)
                    {
                        something -= 50;
                        fifty -= 1;
                    }
                }
                if (twenty > 0)
                {
                    while (something % 20 == 0 && something >= 20)
                    {
                        something -= 20;
                        twenty -= 1;
                    }
                }
                if (ten > 0)
                {
                    while (something % 10 == 0 && something >= 10)
                    {
                        something -= 50;
                        ten -= 1;
                    }
                }
                if (five > 0)
                {
                    while (something % 5 == 0 && something >= 5)
                    {
                        something -= 5;
                        five -= 1;
                    }
                }
                if (one > 0)
                {
                    while (something % 1 == 0 && something >= 1)
                    {
                        something -= 1;
                        one -= 1;
                    }
                }
                return true;
            }
        }
        public bool denominations(int somethingelse)
        {
            if (somethingelse == 100 || somethingelse == 50 || somethingelse == 20 || somethingelse == 10 || somethingelse == 5 || somethingelse == 1) { }
            return false;
        }
    }
       }