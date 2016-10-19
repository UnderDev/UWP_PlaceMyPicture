﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace testApi_Facebook
{
    class PicturePlaceModel
    {
        public class Location
        {
            public string city { get; set; }
            public string country { get; set; }
            public double latitude { get; set; }
            public double longitude { get; set; }
        }

        public class Place
        {
            public string name { get; set; }
            public Location location { get; set; }
            public string id { get; set; }
        }

        public class Datum
        {
            public string source { get; set; }
            public string id { get; set; }
            public Place place { get; set; }
        }

        public class Cursors
        {
            public string before { get; set; }
            public string after { get; set; }
        }

        public class Paging
        {
            public Cursors cursors { get; set; }
            public string next { get; set; }
        }

        public class Photos
        {
            public List<Datum> data { get; set; }
            public Paging paging { get; set; }
        }

        public class PicturePlaceObject
        {
            public Photos photos { get; set; }
            public string id { get; set; }
        }
    }
}
