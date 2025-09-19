﻿using Microsoft.Extensions.DependencyInjection;
using MediatR.NotificationPublishers;

namespace Application
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddApplication(this IServiceCollection services)
        {
            services.AddMediatR(config =>
            {
                config.RegisterServicesFromAssemblyContaining<ApplicationAssemblyReference>();

                config.NotificationPublisher = new TaskWhenAllPublisher();
            });

            return services;
        }
    }

}
