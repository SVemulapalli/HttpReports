﻿ 
using System;
using System.Collections.Generic;
using System.Text;

namespace HttpReports.Core.StorageFilters
{
    public class QueryDetailFilter:BasicFilter
    {
        public long RequestId { get; set; } 

        public string Route { get; set; }

        public int StatusCode { get; set; }

        public string LoginInfo { get; set; }

        public string Method { get; set; }

        public string RequestBody { get; set; }

        public string ResponseBody { get; set; }

    }
}
