﻿namespace LtiLibrary.NetCore.Lti2
{
    public class ServiceProviderName : LocalizedName
    {
        public ServiceProviderName(string name)
        {
            Key = "service_provider.name";
            Value = name;
        }
    }
}
