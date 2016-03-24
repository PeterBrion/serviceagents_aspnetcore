﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.Extensions.OptionsModel;
using Toolbox.ServiceAgents;
using Toolbox.ServiceAgents.Settings;
using SampleApi.Models;
using System.Threading;

namespace SampleApi.ServiceAgents
{
    public class DemoAgent : AgentBase, IDemoAgent
    {
        public DemoAgent(IServiceProvider serviceProvider, IOptions<ServiceAgentSettings> options) 
            : base(serviceProvider, options)
        {
        }

        //A basic get operation
        public Task<Address> GetAddressAsync(int id)
        {
            return GetAsync<Address>($"adress?id={id}");
        }

        //A basic post operation
        public Task<Address> PostAddressAsync(Address adress)
        {
            return PostAsync<Address>($"adress", adress);
        }
    }
}