﻿using System.Text.Json.Serialization;

namespace WebApi8_Scheduling.Models
{
    public class EnterpriseModel
    {
        public int Id { get; set; }
        public string Login { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }
        [JsonIgnore]
        public ICollection<ClientModel> Clients { get; set; } = new List<ClientModel>();
        [JsonIgnore]
        public ICollection<SchedulingModel> Schedulings { get; set; }
    }
}
