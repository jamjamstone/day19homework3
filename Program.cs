namespace day19homework3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Milk milk1 = new Milk();
            Milk milk2 = new Milk();
            Milk milk3 = new Milk();
            VendingMachine milkMachine = new VendingMachine();
            milkMachine.EnqueueMilk(milk1);
            milkMachine.EnqueueMilk(milk2);
            milkMachine.EnqueueMilk(milk3);
            milk1.LeftDate = 15;
            milk2.LeftDate = 8;
            milk3.LeftDate = 5;
            milkMachine.DequeueMilk();
            milkMachine.DequeueMilk();
            milkMachine.DequeueMilk();
            milkMachine.DequeueMilk();
        }
    }
}
