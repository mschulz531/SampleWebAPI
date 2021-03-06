using System;
using System.Web.Http;

namespace SampleWebAPI
{
    public static class OptionsMessageHandlerConfig
    {
        public static void Configure(HttpConfiguration config)
        {
            if (config == null)
                throw new ArgumentNullException(nameof(config));

            config.MessageHandlers.Add(new OptionsHttpMessageHandler());
        }
    }
}
