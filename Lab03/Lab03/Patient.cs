using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab03
{
    public class Patient
    {
        [StringLength(11, ErrorMessage = "OIB must be 11 characters long")]
        public string OIB { get; set; }

        [StringLength(9, ErrorMessage = "MBO must be 9 characters long")]
        public string MBO { get; set; }

        public string FullName { get; set; }

        public DateTime Birthday { get; set; }

        public string Gender { get; set; }

        public string Diagnosis { get; set; }

        public Patient(string OIB, string MBO, string FullName, DateTime Birthday, string Gender, string Diagnosis)
        {
            if (OIB.Length != 11)
                throw new ArgumentException("OIB must be 11 characters long.");

            if (MBO.Length != 9)
                throw new ArgumentException("MBO must be 9 characters long.");

            this.OIB = OIB;
            this.MBO = MBO;
            this.FullName = FullName;
            this.Birthday = Birthday;
            this.Gender = Gender;
            this.Diagnosis = Diagnosis;
        }
    }
}
