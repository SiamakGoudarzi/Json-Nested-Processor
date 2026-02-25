using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using static JasonSerializedDeserialized.Program;

namespace JasonSerializedDeserialized
{
    public static class DataHelper
    {
        public static void ProcessData(this Data data)
        {
            if (data == null || data.Price == null || data.Color == null || data.OfferPrice == null)
            {
                return;
            }
            else
            {
                data.PriceAndOfferpriceByColor = new Dictionary<string, Tuple<int, int>>();

                for (int i = 0; i < data.Price.Length; i++)
                {
                    data.PriceAndOfferpriceByColor[data.Color[i]] = new Tuple<int, int>(
                        int.Parse(data.Price[i]),
                        int.Parse(data.OfferPrice[i])
                    );
                }


            }

        }
    }
}
