using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependencyInjection.Console
{
    class Garage
    {
        public void MOT(IVehicle vehicle)
        {
            System.Console.Write(vehicle.OilLevel);
        }
    }

    interface IVehicle
    {
        int OilLevel { get; set; }
        void Start();
        void Stop();
    }

    class Car: IVehicle
    {
        public int OilLevel { get; set; }
        public void Start()
        {
            //press the start button
        }

        public void Stop()
        {
            throw new NotImplementedException();
        }
    }

    class Bus: IVehicle
    {
        public int OilLevel { get; set; }
        public void Start()
        {
            throw new NotImplementedException();
        }

        public void Stop()
        {
            throw new NotImplementedException();
        }
    }

    class Lorry: IVehicle
    {
        public int OilLevel { get; set; }
        public void Start()
        {
            //pull out the choke
            //turn the key
        }

        public void Stop()
        {
            throw new NotImplementedException();
        }
    }

    class OldSchoolPropellerPLane: IVehicle
    {
        public int OilLevel { get; set; }
        public void Start()
        {
            //spin the propeller
        }

        public void Stop()
        {
            throw new NotImplementedException();
        }
    }



    class AnotherProgram
    {
        public static void Mainzzzz(string[] args)
        {
            Garage g = new Garage();

            var car = new Car();
            g.MOT(car);

            var bus = new Bus();
            g.MOT(bus);

            var lorry = new Lorry();
            g.MOT(lorry);
        }
    }
}
