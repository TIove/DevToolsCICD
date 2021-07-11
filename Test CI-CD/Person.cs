namespace Test_CI_CD
{
    public class Person
    {
        public Person(int energy)
        {
            Energy = energy;
        }
        
        private int Energy { get; set; }
        
        public bool Walk(int distance)

     {
            if (distance > Energy)
            {
                return false;
            }
            
            
            Energy -= distance;
            return true;
        }

        public void Sleep(int time)
        {
            Energy += time;
        }

        public void Eat(int calories)
        {
            var energyFromFood = calories / 2000;
            Energy += energyFromFood;
        }
    }
}