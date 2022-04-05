using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using GeoCoordinatePortable;

namespace ParserLibrary
{
    public class LocationModel : ITrackable
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public GeoCoordinate GeoPoint { get; set; }
    }
}
