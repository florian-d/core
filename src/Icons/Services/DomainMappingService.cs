﻿using System.Collections.Generic;

namespace Bit.Icons.Services
{
    public class DomainMappingService : IDomainMappingService
    {
        private readonly Dictionary<string, string> _map = new Dictionary<string, string>
        {
            ["login.yahoo.com"] = "yahoo.com",
            ["accounts.google.com"] = "google.com",
            ["photo.wallgreens.com"] = "wallgreens.com",
            ["passport.yandex.com"] = "yandex.com",
            // TODO: Add others here
        };

        public string MapDomain(string hostname)
        {
            if(_map.ContainsKey(hostname))
            {
                return _map[hostname];
            }

            return hostname;
        }
    }
}