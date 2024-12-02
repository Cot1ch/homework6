using System;

namespace Tumakov6
{
    internal class Building
    {
        private static ulong _Number = 0;
        private uint _Height;
        private uint _CountFloors;
        private uint _CountFlats;
        private uint _СountEntrance;

        public ulong number
            { get { return _Number++; } set { _Number = value; } }
        public uint height 
            { get { return _Height; } set { _Height = value; } }
        public uint countFloors
            { get { return _CountFloors; } set { _CountFloors = value; } }
        public uint countFlat
            { get { return _CountFlats; } set { _CountFlats = value; } }
        public uint countEntrance
            { get { return _СountEntrance; } set { _СountEntrance = value; } }

        public double FloorsHeight()
        {
            return (double)height / countFloors;
        }
        public double FlatsInEntrance()
        {
            return (double)countFlat / countEntrance;
        }
        public double FlatsOnFloor()
        {
            return (double)countFlat / countFloors / countEntrance;
        }

    }
}
