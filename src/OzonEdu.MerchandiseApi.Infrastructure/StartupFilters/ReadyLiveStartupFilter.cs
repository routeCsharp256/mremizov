﻿using System;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using OzonEdu.MerchandiseApi.Infrastructure.Middlewares;

namespace OzonEdu.MerchandiseApi.Infrastructure.StartupFilters
{
    internal sealed class ReadyLiveStartupFilter : IStartupFilter
    {
        public Action<IApplicationBuilder> Configure(Action<IApplicationBuilder> next)
        {
            return app =>
            {
                app.Map("/ready", builder => builder.UseMiddleware<ReadyMiddleware>());
                app.Map("/live", builder => builder.UseMiddleware<LiveMiddleware>());

                next(app);
            };
        }
    }
}
