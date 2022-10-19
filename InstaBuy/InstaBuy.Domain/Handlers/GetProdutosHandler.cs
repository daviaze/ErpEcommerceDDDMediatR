
using Dapper;
using FirebirdSql.Data.FirebirdClient;
using InstaBuy.Domain.Entities;
using InstaBuy.Domain.Handlers.Request;
using MediatR;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InstaBuy.Domain.Handlers
{
    public class GetProdutosHandler : IRequestHandler<GetProdutosRequest, IEnumerable<Produto>>
    {
        public async Task<IEnumerable<Produto>> Handle(GetProdutosRequest request, CancellationToken cancellationToken)
        {
            try
            {
                using (FbConnection connection = new FbConnection("DataSource=192.168.0.250; Database=inova; username= SYSDBA; password = masterkey"))
                {
                    IEnumerable<Produto> allProducts = await connection.QueryAsync<Produto>("SELECT P.idproduto as InternalCode, P.descricaoproduto as Name, P.ean as Barcodes, COALESCE(P.precoavista, 0) as Price, COALESCE(P.precopromocao, 0) as PromoPrice FROM PRODUTO  P");

                    return allProducts;
                }
            }catch
            {
                throw;
            }
        }
    }
}
