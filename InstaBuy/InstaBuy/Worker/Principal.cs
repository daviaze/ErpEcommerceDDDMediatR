using InstaBuy.Application.Handlers.Request;
using MediatR;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InstaBuy.Worker
{
    public class Principal : BackgroundService
    {
        public IMediator _mediator;

        public Principal(IMediator mediator)
        {
            _mediator = mediator;
        }

        protected override Task ExecuteAsync(CancellationToken stoppingToken)
        {
             return _mediator.Send(new FilaRequest(), stoppingToken);
        }
    }
}
