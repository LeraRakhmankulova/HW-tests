using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumTests
{
    public class CommentData
    {
        public CommentData(string description)
        {
            Description = description;
        }

        public string Description { get; set; }
    }

}
