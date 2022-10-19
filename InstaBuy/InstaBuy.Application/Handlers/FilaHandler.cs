using InstaBuy.Application.Handlers.Request;
using InstaBuy.Domain.Handlers.Request;
using MediatR;
using Serilog;

namespace InstaBuy.Application.Handlers
{
    public class FilaHandler : IRequestHandler<FilaRequest>
    {
        private readonly IMediator _mediator;
        private readonly ILogger _logger;
        public FilaHandler(IMediator mediator, ILogger logger)
        {
            _mediator = mediator;
            _logger = logger;
        }

        public async Task<Unit> Handle(FilaRequest request, CancellationToken cancellationToken)
        {
            try
            {
                while (true)
                {
                    var produtos = await _mediator.Send(new GetProdutosRequest(), cancellationToken);
                    Thread.Sleep(1000);
                    _logger.Information("Buscando todos os produtos");
                }
            }
            catch (Exception e)
            {
                _logger.Error(e.Message);
                await Handle(request, cancellationToken);
            }
            return Unit.Value;
        }
    }
}
