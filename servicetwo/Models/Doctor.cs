using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Servicetwo.Models
{
    public class Doctor
    {
        public int DoctorId { get; set; }
        public string DoctorName { get; set; }
    }

    public class DoctorDb : List<Doctor>
    {
        public DoctorDb()
        {
            Add(new Doctor() { DoctorId = 1, DoctorName = "Meharsh"});
            Add(new Doctor() { DoctorId = 2, DoctorName = "Shivani" });
        }
    }
}
