using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CorePortfolio.Models
{
    public class Project
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public string Status { get; set; }
        public DateTime StartDate { get; set; }
        public bool IsSchoolProj { get; set; }
    }
}
