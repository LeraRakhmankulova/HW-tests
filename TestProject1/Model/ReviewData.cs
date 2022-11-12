using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumTests
{
    public class ReviewData
    {
        public ReviewData(string description)
        {
            Description = description;
        }

        public string Description { get; set; }
    }

}
