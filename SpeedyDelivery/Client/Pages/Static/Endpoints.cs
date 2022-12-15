using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SpeedyDelivery.Client.Static
{
    public static class Endpoints
    {
        private static readonly string Prefix = "api";

        public static readonly string MakesEndpoint = $"{Prefix}/restaurants";
        public static readonly string ModelsEndpoint = $"{Prefix}/carts";
        public static readonly string ColoursEndpoint = $"{Prefix}/foods";
    }
}
