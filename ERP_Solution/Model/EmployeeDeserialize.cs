using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ERP_Solution.Model
{
    public class EmployeeDeserialize
    {
        public class Pagination
        {
            public int total { get; set; }
            public int pages { get; set; }
            public int page { get; set; }
            public int limit { get; set; }
        }

        public class Meta
        {
            public Pagination pagination { get; set; }
        }

        public class Datum
        {
            public int id { get; set; }
            public string name { get; set; }
            public string email { get; set; }
            public string gender { get; set; }
            public string status { get; set; }
            public DateTime created_at { get; set; }
            public DateTime updated_at { get; set; }
        }

        public class Root
        {
            public int code { get; set; }
            public Meta meta { get; set; }
            public List<Datum> data { get; set; }
        }

        public class DatumResponseError
        {
            public string field { get; set; }
            public string message { get; set; }
        }

        public class RootResponseError
        {
            public int code { get; set; }
            public object meta { get; set; }
            public List<DatumResponseError> data { get; set; }
        }

        public class DataResponse
        {
            public int id { get; set; }
            public string name { get; set; }
            public string email { get; set; }
            public string gender { get; set; }
            public string status { get; set; }
            public DateTime created_at { get; set; }
            public DateTime updated_at { get; set; }
        }

        public class RootResponse
        {
            public int code { get; set; }
            public object meta { get; set; }
            public DataResponse data { get; set; }
        }

        public class RootResponseDelete
        {
            public int code { get; set; }
            public object meta { get; set; }
            public object data { get; set; }
        }
    }
}
