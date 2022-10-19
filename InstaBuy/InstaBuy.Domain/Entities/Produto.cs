using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InstaBuy.Domain.Entities
{
    public class Produto
    {
            [JsonProperty("internal_code")]
            public string InternalCode { get; set; }

            [JsonProperty("visible")]
            public bool Visible { get; set; }

            [JsonProperty("stock")]
            public int Stock { get; set; }

            [JsonProperty("name")]
            public string Name { get; set; }

            [JsonProperty("barcodes")]
            public string Barcodes { get; set; }

            [JsonProperty("price")]
            public double Price { get; set; }

            [JsonProperty("promo_price")]
            public double PromoPrice { get; set; }

            [JsonProperty("promo_start_at")]
            public string PromoStartAt { get; set; }

            [JsonProperty("promo_end_at")]
            public string PromoEndAt { get; set; }

    }
}
