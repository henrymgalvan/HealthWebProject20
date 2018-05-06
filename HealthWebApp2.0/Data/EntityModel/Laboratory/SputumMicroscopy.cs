using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HealthWebApp2._0.Data.EntityModel.Laboratory
{
    public enum Results
    {

    }
    public class SputumMicroscopy
    {
        public long Id { get; set; }

        public long Laboratory_Number { get; set; }
        public DateTime DateOfExamination { get; set; }
        public DateTime ReleaseDate { get; set; }
        public Results Result { get; set; }
        public int No_Of_AFB { get; set; }
        public bool Method { get; set; }
        //Fluorescent Acid Fast Microscopy 
        //Ziehl Neelsen
        public string Remarks { get; set; }
    }
}
