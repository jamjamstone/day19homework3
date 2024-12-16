using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day19homework3
{
    internal class VendingMachine
    {
        Queue<Milk> _milks=new Queue<Milk>();

        public void EnqueueMilk(Milk milk)
        {
            _milks.Enqueue(milk); 
        }

        public void DequeueMilk()
        {
            if (_milks.Count == 0)
            {
                Console.WriteLine("우유 재고 소진");
            }
            else
            {

                Console.WriteLine($"유통기한: {_milks.Dequeue().LeftDate}, 남은 우유 {_milks.Count}개");
            }
        }


    }
}
