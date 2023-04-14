using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CaseStudy_EmployeeDetails
{
    public class BusinessLogic
    {
        public Form1 form;

        string apiToken = ConfigurationManager.AppSettings["ApiToken"];

        public BusinessLogic() 
        {
            
        }
        public async Task AddEmployee(string name, string email, string gender, string status)
        {

            string apiurl1 = "https://gorest.co.in/public-api/users";
            try

            {
                using (var client = new HttpClient())
                {
                    client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", apiToken);
                    var parameters = new FormUrlEncodedContent(new[]
                    {
                        new KeyValuePair<string, string>("name", name),
                        new KeyValuePair<string, string>("email", email),
                        new KeyValuePair<string, string>("gender", gender),
                        new KeyValuePair<string, string>("status", status)
                     }
                    );

                    var response = await client.PostAsync(apiurl1, parameters);

                    var responseString = await response.Content.ReadAsStringAsync();
                    MessageBox.Show(responseString);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error occured" + ex.Message);
            }
        }

        public async Task EditEmployeeDetails(string name, string email, string gender, string status, string id)
        {

            string apiurl1 = "https://gorest.co.in/public-api/users/";
            try

            {
                string Eid = id;

                if (string.IsNullOrEmpty(Eid))
                {
                    MessageBox.Show("EmpId is mandatory for updating details");
                    return;
                }

                // getting employee details
                String baseurl = "https://gorest.co.in/public-api/users/";

                string endpoint = Eid;
                string url = $"{baseurl}{endpoint}";

                HttpClient httpclient = new HttpClient();
                httpclient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", apiToken);
                HttpResponseMessage responseGetApi = await httpclient.GetAsync(url);

                string responsebody = responseGetApi.Content.ReadAsStringAsync().Result;
                var employeeData = JsonConvert.DeserializeObject<EmployeeData>(responsebody);
                List<EmployeeDetails> list = new List<EmployeeDetails>
                {
                    employeeData.data
                };

                string name1 = string.IsNullOrEmpty(name) ? employeeData.data.name : name;
                string email1 = string.IsNullOrEmpty(email) ? employeeData.data.email : email;
                string gender1 = string.IsNullOrEmpty(gender) ? employeeData.data.gender : gender;
                string Estatus1 = string.IsNullOrEmpty(status) ? employeeData.data.status : status;

                using (var client = new HttpClient())
                {
                    client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", apiToken);
                    var parameters = new FormUrlEncodedContent(new[]
                    {
                         new KeyValuePair<string, string>("id", Eid),
                         new KeyValuePair<string, string>("name", name1),
                         new KeyValuePair<string, string>("email", email1),
                         new KeyValuePair<string, string>("gender", gender1),
                         new KeyValuePair<string, string>("status", Estatus1)
                     });

                    apiurl1 = apiurl1 + Eid;
                    var response = await client.PutAsync(apiurl1, parameters);

                    var responseString = await response.Content.ReadAsStringAsync();
                    MessageBox.Show(responseString);
                    var responseJson = JsonDocument.Parse(responseString).RootElement;
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error occured" + ex.Message);
            }
        }

        public async Task DeleteEmployeeDetails(string id)
        {
            try
            {
                if (!String.IsNullOrEmpty(id))
                {
                    HttpClient client = new HttpClient();
                    client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", apiToken);

                    string param1 = id;

                    var response = await client.DeleteAsync($"https://gorest.co.in/public-api/users/{param1}");
                    response.EnsureSuccessStatusCode();

                    if (response.IsSuccessStatusCode)
                    {

                        MessageBox.Show("Deleted Successfuly");

                    }
                }
                else
                {
                    MessageBox.Show("Enter the employee ID");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        public async void GetAllEmployeeDetails(DataGridView dataView)
        {
            String url = "https://gorest.co.in/public-api/users";

            HttpClient client = new HttpClient();
            client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", apiToken);
            HttpResponseMessage response = await client.GetAsync(url);
            string responsebody = response.Content.ReadAsStringAsync().Result;

            var employeeData = JsonConvert.DeserializeObject<Employees>(responsebody);
            //dataGridView1.DataSource = employeeData.data;
           
            dataView.DataSource= employeeData.data;
        }

        public async Task SearchEmployee(string id, DataGridView dataView)
        {
            String baseurl = "https://gorest.co.in/public-api/users/";

            string endpoint = id;
            string url = $"{baseurl}{endpoint}";

            HttpClient clint = new HttpClient();
            clint.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", apiToken);
            HttpResponseMessage response = await clint.GetAsync(url);

            string responsebody = response.Content.ReadAsStringAsync().Result;


            var employeeData = JsonConvert.DeserializeObject<EmployeeData>(responsebody);
            List<EmployeeDetails> list = new List<EmployeeDetails>
            {
                employeeData.data
            };
            dataView.DataSource = list;

        }
    }
}
