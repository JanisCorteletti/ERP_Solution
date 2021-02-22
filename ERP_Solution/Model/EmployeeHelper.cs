using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace ERP_Solution.Model
{
    public class EmployeeHelper
    {
        const string BASE_URL = "https://gorest.co.in/public-api/users";
        const string TOKEN = "fa114107311259f5f33e70a5d85de34a2499b4401da069af0b1d835cd5ec0d56";

        public static async Task<string> ListAll(int page)
        {

            using (HttpClient client = new HttpClient())
            {
                using (HttpResponseMessage res = await client.GetAsync(BASE_URL + "?page=" + page))
                {
                    using (HttpContent content = res.Content)
                    {
                        string data = await content.ReadAsStringAsync();
                        if (data != null)
                        {
                            return data;
                        }

                    }
                }
            }
            return string.Empty;

        }

        public static async Task<string> Create(Employee employee)
        {
            var inputObject = new Dictionary<string, string> {
                { "name", employee.Name },
                { "email", employee.Email },
                { "status", employee.Status},
                { "gender", employee.Gender} };

            var input = new FormUrlEncodedContent(inputObject);

            using (HttpClient client = new HttpClient())
            {
                client.DefaultRequestHeaders.Add("Authorization", string.Format("Bearer {0}", TOKEN));

                using (HttpResponseMessage response = await client.PostAsync(BASE_URL, input))
                {
                    using (HttpContent content = response.Content)
                    {
                        string data = await content.ReadAsStringAsync();
                        if (data != null)
                        {
                            return data;
                        }
                    }
                }
            }
            return string.Empty;
        }

        public static async Task<string> Update(Employee employee)
        {
            string empoyeeId = employee.Id.ToString();
            string url_empolyee = BASE_URL + "/" + empoyeeId;

            var inputObject = new Dictionary<string, string> {

                { "name", employee.Name },
                { "email", employee.Email },
                { "status", employee.Status},
                { "gender", employee.Gender} };

            var input = new FormUrlEncodedContent(inputObject);

            using (HttpClient client = new HttpClient())
            {
                client.DefaultRequestHeaders.Add("Authorization", string.Format("Bearer {0}", TOKEN));

                using (HttpResponseMessage response = await client.PutAsync(url_empolyee, input))
                {
                    using (HttpContent content = response.Content)
                    {
                        string data = await content.ReadAsStringAsync();
                        if (data != null)
                        {
                            return data;
                        }
                    }
                }
            }
            return string.Empty;
        }

        public static async Task<string> Delete(Employee employee)
        {
            string empoyeeId = employee.Id.ToString();
            string url_empolyee = BASE_URL + "/" + empoyeeId;

            using (HttpClient client = new HttpClient())
            {
                client.DefaultRequestHeaders.Add("Authorization", string.Format("Bearer {0}", TOKEN));

                using (HttpResponseMessage response = await client.DeleteAsync(url_empolyee))
                {
                    using (HttpContent content = response.Content)
                    {
                        string data = await content.ReadAsStringAsync();
                        if (data != null)
                        {
                            return data;
                        }
                    }
                }
            }
            return string.Empty;
        }

        public static async Task<string> ListById(int emmployeeId)
        {

            using (HttpClient client = new HttpClient())
            {
                using (HttpResponseMessage res = await client.GetAsync(BASE_URL + "?id=" + emmployeeId))
                {
                    using (HttpContent content = res.Content)
                    {
                        string data = await content.ReadAsStringAsync();
                        if (data != null)
                        {
                            return data;
                        }

                    }
                }
            }
            return string.Empty;

        }

        public static async Task<string> ListByString(string stringValue)
        {

            using (HttpClient client = new HttpClient())
            {
                using (HttpResponseMessage res = await client.GetAsync(BASE_URL + stringValue))
                {
                    using (HttpContent content = res.Content)
                    {
                        string data = await content.ReadAsStringAsync();
                        if (data != null)
                        {
                            return data;
                        }

                    }
                }
            }
            return string.Empty;

        }

        public static async Task<string> ListPage()
        {

            using (HttpClient client = new HttpClient())
            {
                using (HttpResponseMessage res = await client.GetAsync(BASE_URL))
                {
                    using (HttpContent content = res.Content)
                    {
                        string data = await content.ReadAsStringAsync();
                        if (data != null)
                        {
                            return data;
                        }

                    }
                }
            }
            return string.Empty;

        }


    }
}
