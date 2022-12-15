﻿using MemesFinderGateway.Interfaces.DecisionMaker;
using MemesFinderGateway.Managers.DecisionMaker;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace MemesFinderGateway.Infrastructure.DependencyInjection
{
	public static class ServiceCollectionExtensions
	{
		public static IServiceCollection AddDecisionManager(this IServiceCollection services, IConfiguration configuration)
		{
			services.Configure<RollDiceDecisionMakerOptions>(configuration.GetSection("RollDiceDecisionMakerOptions"));
			services.AddTransient<IDecisionMaker, RollDiceDecisionMaker>();

			services.AddTransient<IDecisionMakerManager, DecisionMakerManager>();
			return services;
		}
	}
}
