using practice.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace practice.ViewModel
{
    public class SampleModel
    {
        public List<Player> Player { get; set; }
        public List<Staff> Staff { get; set; }
        public List<Stadium> Stadium { get; set; }

    }
}