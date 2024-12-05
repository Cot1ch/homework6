using System.Collections.Generic;

namespace homework6
{
    internal class Maternity
    {
        #region Fields
        private List<string> _Address;
        private string _Name;
        private byte _Capacity;
        private List<WomanInLabor> _Patients;
        private List<MedicalStaff> _Staff;
        #endregion

        #region Properties

        public Maternity(string name, List<string> address, byte capacity, List<WomanInLabor> patients, List<MedicalStaff> staff)
        {
            this.Name = name;
            this.Address = address;
            this.Capacity = capacity;
            this.Patients = patients;
            this.Staff = staff;
        }
        public List<string> Address
        {
            get { return _Address; }
            set { _Address = value; }
        }
        public string Name
        { 
            get { return _Name; } 
            set {_Name = value; } 
        }
        public byte Capacity
        { 
            get { return _Capacity; } 
            set {_Capacity = value; } 
        }
        public List<WomanInLabor> Patients
        { 
            get { return _Patients; } 
            set { _Patients = value; } 
        }
        public List<MedicalStaff> Staff
        { 
            get { return _Staff; } 
            set { _Staff = value; } 
        }
        #endregion

        #region Methods
        public bool IsFull()
        {
            if (Patients.Count < Capacity)
            {
                return true;
            }
            return false;
        }

        public void PrintStaff()
        {
            foreach (MedicalStaff staff in Staff)
            {
                staff.ShowInfo();
            }
        }

        public void PrintPatient()
        {
            foreach (WomanInLabor patient in Patients)
            {
                patient.ShowInfo();
            }
        }

        public void AddPatient(WomanInLabor patient)
        {
            Patients.Add(patient);
        }

        public void AddStaff(MedicalStaff staff)
        {
            Staff.Add(staff);
        }
        #endregion
    }
}
