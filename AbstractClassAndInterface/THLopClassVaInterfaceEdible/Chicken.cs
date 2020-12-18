namespace THLopClassVaInterfaceEdible
{
    public class Chicken:AAnimal,IIdible
    {
        public override string MakeSound()
        {
            return "What is the Chicken say: cuc cuc cuc tat";
        }

        public string HowToEat()
        {
            return "could be fried";
        }
    }
}