using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParkingLot.Interface
{
    public interface IPublisher
    {
        IList<ISubscriber> Subcribers { get; set; }
        void AddSubscriber(ISubscriber subscriber);
        void RemoveSubscriber(ISubscriber subscriber);
        void Notify(string message);
    }
}
