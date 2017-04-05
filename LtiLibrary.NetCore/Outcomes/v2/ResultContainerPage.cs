﻿using LtiLibrary.NetCore.Common;
using Newtonsoft.Json;

namespace LtiLibrary.NetCore.Outcomes.v2
{
    public class ResultContainerPage : JsonLdObject
    {
        public ResultContainerPage()
        {
            Type = LtiConstants.LisResultContainerType;
        }

        /// <summary>
        /// URI for the next page. If there is no next page, the NextPage property will be null.
        /// </summary>
        [JsonProperty("nextPage")]
        public string NextPage { get; set; }

        /// <summary>
        /// The Results within this page.
        /// </summary>
        [JsonProperty("pageOf")]
        public ResultContainer ResultContainer { get; set; }
    }
}
