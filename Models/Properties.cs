using System;
using System.Collections.Generic;
using System.Text;

namespace Coordinates.Models
{
    public class Properties
    {
        public int osm_id { get; set; }
        public string boundary { get; set; }
        public int? admin_level { get; set; }
        public string parents { get; set; }
        public string name { get; set; }
        public string local_name { get; set; }
        public string name_en { get; set; }
    }
}
