﻿using System.Text.Json.Serialization;

namespace WebApi8_Scheduling.Models
{
    public class SchedulingModel
    {
        public int Id { get; set; }
        public DateTime DateHour { get; set; }
        public string Observation { get; set; }

        //Relacionament
        [JsonIgnore]
        public int EnterpriseId { get; set; }
        public EnterpriseModel Enterprise { get; set; }

        public int ClientId { get; set; }
        [JsonIgnore]
        public ClientModel Client { get; set; }

        public int ServiceId { get; set; }
        [JsonIgnore]
        public ServiceModel Service { get; set; }
    }
}
