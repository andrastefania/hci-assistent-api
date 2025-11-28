using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HCI.AIAssistant.Api.Models.CustomTypes;

namespace HCI.AIAssistant.Api.Services
{
    public interface ISecretsService
    {
        public AIAssistantSecrets? AIAssistantSecrets { get; set; }
        public IoTHubSecrets? IoTHubSecrets { get; set; }
    }
}