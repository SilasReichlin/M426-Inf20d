using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using ParkingLot.Interface;

namespace ParkingLot
{
    public class DisplaySubscriber : ISubscriber
    {
        public void Update(ParkingLot lot, string message)
        {
            Console.WriteLine($"{message} {lot.Name}: {lot.Occupied}/{lot.Capacity} occupied");
        }
    }
}
