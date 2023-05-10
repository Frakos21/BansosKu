using APILibrary.Model;
using Newtonsoft.Json;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace APILibrary.API
{
    public class MyAPI
    {
        private string baseurl = "https://localhost:7189/api/";

        public int RegisterUser(string nik, string name, string password)
        {
            try
            {
                var client = new RestClient(baseurl);
                var request = new RestRequest("Auth/AddUser", Method.Post);
                request.AddHeader("Content-Type", "application/json");
                var body = JsonConvert.SerializeObject(new { nik = nik, fullname = name, password = password, role = "USER" });
                request.AddParameter("application/json", body, ParameterType.RequestBody);
                var response = client.Execute(request);
                var responseContent = JsonConvert.DeserializeObject<String>(response.Content.ToString());
                var res = 0;
                if (response.Content == "-2")
                {
                    return -2;
                }
                else if (response.Content == "-1")
                {
                    return -1;
                }
                return 1;
            }
            catch (Exception ex)
            {
                return -1;
            }
        }

        public int Login(string nik, string password) {
            var client = new RestClient(baseurl);
            var request = new RestRequest("Auth/Authentication/"+nik+"/"+password, Method.Get);
            request.AddHeader("Content-Type", "application/json");
            var response = client.Execute(request);
            var responseContent = JsonConvert.DeserializeObject<String>(response.Content);
            if (Convert.ToInt32(responseContent) == -1)
            {
                return -1;
            }
            return Convert.ToInt32(responseContent);
        }

        public UserModel getUserById(int id)
        {
            UserModel res = new UserModel();
            try
            {
                var client = new RestClient(baseurl);
                var request = new RestRequest("Auth/GetUserById/"+id, Method.Get);
                request.AddHeader("Content-Type", "application/json");
                var response = client.Execute(request);
                if (response.StatusCode.ToString() == "OK")
                {
                    res = JsonConvert.DeserializeObject<UserModel>(response.Content.ToString());
                    return res;
                }
            }
            catch (Exception ex)
            {
                return res;
            }
            return res;
        }
        public int updateUser(UserModel user,int id)
        {
            try
            {
                var client = new RestClient(baseurl);
                var request = new RestRequest("Auth/UpdateUser/"+id, Method.Put);
                request.AddHeader("Content-Type", "application/json");
                var body = JsonConvert.SerializeObject(user);
                request.AddParameter("application/json", body, ParameterType.RequestBody);
                var response = client.Execute(request);
                var responseContent = JsonConvert.DeserializeObject<String>(response.Content.ToString());
                if(responseContent == "success")
                {
                    return 1;
                }
            }
            catch (Exception ex)
            {
                return -1;
            }
            return -1;

        }
        public List<BansosModel> GetAllBansos()
        {
            List<BansosModel> res = new List<BansosModel>();
            try
            {
                var client = new RestClient(baseurl);
                var request = new RestRequest("Bansos/GetBansos", Method.Get);
                request.AddHeader("Content-Type", "application/json");
                var response = client.Execute(request);

                if (response.StatusCode.ToString() == "OK")
                {
                    res = JsonConvert.DeserializeObject<List<BansosModel>>(response.Content);

                    return res;
                }
            }
            catch (Exception ex)
            {

                return res;
            }

            return res;
        }
    }
}
