using InstaBuy.Domain.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InstaBuy.Domain.Handlers.Request
{
    public class GetProdutosRequest : IRequest<IEnumerable<Produto>>
    {
    }
}
