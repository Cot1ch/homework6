using System;

namespace Tumakov6
{
    internal class Building
    {
        #region Fields
        private static ulong _Number = 1;
        private uint _Height;
        private uint _CountFloors;
        private uint _CountFlats;
        private uint _СountEntrance;
        #endregion

        #region Properties
        public ulong number
            { get { return _Number++; } 
            set { _Number = value; } }
        public uint height 
            { get { return _Height; } 
            set { _Height = value; } }
        public uint countFloors
            { get { return _CountFloors; } 
            set { _CountFloors = value; } }
        public uint countFlat
            { get { return _CountFlats; } 
            set { _CountFlats = value; } }
        public uint countEntrance
            { get { return _СountEntrance; } 
            set { _СountEntrance = value; } }
        #endregion

        #region Methods
        /// <summary>
        /// Возвращает высоту этажа
        /// </summary>
        /// <returns>Число типа double</returns>
        public double FloorsHeight()
        {
            return (double)height / countFloors;
        }

        /// <summary>
        /// Возвращает количество квартир в подъезде
        /// </summary>
        /// <returns>Число типа double</returns>
        public double FlatsInEntrance()
        {
            return (double)countFlat / countEntrance;
        }

        /// <summary>
        /// Возвращает количество квартир на этаже
        /// </summary>
        /// <returns>Число типа double</returns>
        public double FlatsOnFloor()
        {
            return (double)countFlat / countFloors / countEntrance;
        }
        #endregion
    }
}
