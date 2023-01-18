using System.Runtime.CompilerServices;
using System;
using System.Collections.Generic;
using ParkingLot.Interface;

namespace ParkingLot
{
    public class ParkingLot : IPublisher
    {
        public string Name { get; }
        public int Capacity { get; }
        public int Occupied { get; set; }

        public ParkingLot(string name, int capacity)
        {
            this.Name = name;
            this.Capacity = capacity;
            this.Occupied = 0;
            Subcribers = new List<ISubscriber>();
        }

        [MethodImpl(MethodImplOptions.Synchronized)]
        public void Enter()
        {
            if (Occupied < Capacity)
            {
                Occupied++;
                Notify("A car entered the lot");
            }
            else
            {
                throw new InvalidOperationException("parking lot is full");
            }
        }

        [MethodImpl(MethodImplOptions.Synchronized)]
        public void Exit()
        {
            if (Occupied > 0)
            {
                Occupied--;
                Notify("A car left the lot");
            }
            else
            {
                throw new InvalidOperationException("parking lot is empty");
            }
        }

        public IList<ISubscriber> Subcribers { get; set; }

        public void AddSubscriber(ISubscriber subscriber)
        {
            this.Subcribers.Add(subscriber);
        }

        public void RemoveSubscriber(ISubscriber subscriber)
        {
            this.Subcribers.Remove(subscriber);
        }

        public void Notify(string message)
        {
            foreach (var subscriber in this.Subcribers)
            {
                subscriber.Update(this, message);
            }
        }
    }
}