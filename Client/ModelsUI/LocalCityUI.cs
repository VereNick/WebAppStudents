﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Client.ModelsUI
{
    public class LocalCityUI
    {
        public int Id { get; set; }
        public string CityName { get; set; }
        public int RegionId { get; set; }
        public RegionUI Region { get; set; }
    }
}
