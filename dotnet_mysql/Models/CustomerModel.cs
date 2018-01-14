using System;
namespace dotnet_mysql.Models
{
    public class CustomerModel
    {
        public string id { get; set; }
        public string name { get; set; }
        public string username { get; set; }
        public string password { get; set; }
        public DateTime birthday { get; set; }
    }
}
