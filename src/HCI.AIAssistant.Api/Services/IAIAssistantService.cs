using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HCI.AIAssistant.Api.Services
{
    public interface IAIAssistantService
    {
        public Task<string> SendMessageAndGetResponseAsync(string message);
    }
}