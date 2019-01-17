using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace LuckySpin.Models
{
    public class Spin
    {
        public int Luck { get; set; }
        public int a { get; set; }
        public int b { get; set; }
        public int c { get; set; }
        public string Display { get; set; }
    }
}
