﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Device.Location;

namespace TrackingSystem.Helpers
{
    public static class DistanceCalculator
    {
        public static double Calculate(double lat1,double lat2,double long1,double long2)
        {
            var geoCoordFirst = new GeoCoordinate(lat1, long1);
            var geoCoordSecond = new GeoCoordinate(lat2,long2);

            var distance = geoCoordFirst.GetDistanceTo(geoCoordSecond);
         
            return distance;

            var R = 6371000; // earths diameter metres
            var latRadian1 = DegreeToRadian(lat1);
            var latRadian2 = DegreeToRadian(lat2);
            var deltaLat = DegreeToRadian(lat2- lat1);
            var deltaLong = DegreeToRadian(long2- long1);

            var a = Math.Sin(deltaLat / 2) * Math.Sin(deltaLat / 2) +
                    Math.Cos(lat1) * Math.Cos(lat2) *
                    Math.Sin(deltaLong / 2) * Math.Sin(deltaLong / 2);

            var c = 2 * Math.Atan2(Math.Sqrt(a), Math.Sqrt(1 - a));

            distance = R * c;

            return distance;
        }

        private static double DegreeToRadian(double angle)
        {
            return Math.PI * angle / 180.0;
        }
    }
}