using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;
using Newtonsoft.Json;
using TestTask.Model;
using TestTask.Logger;

namespace TestTask.Data
{
     public class JsonDataAccess
        {
            public static async Task<List<Transaction>> LoadTransactionsAsync(string filePath)
            {
                try
                {
                    using (var reader = new StreamReader(filePath))
                    {
                        var json = await reader.ReadToEndAsync();
                        return JsonConvert.DeserializeObject<List<Transaction>>(json);
                    }
                }
                catch(Exception ex)
                {
                    Logging.LogError("Error in loading transctions - " + ex.ToString());
                    return new List<Transaction>();
                }
                
            }

            public static async Task<List<ExchangeRate>> LoadExchangeRatesAsync(string filePath)
            {
                try
                {
                    using (var reader = new StreamReader(filePath))
                    {
                        var json = await reader.ReadToEndAsync();
                        return JsonConvert.DeserializeObject<List<ExchangeRate>>(json);
                    }
                }
                catch(Exception ex)
                {
                    Logging.LogError(" Error in loading rates - " + ex.ToString());
                    return new List<ExchangeRate>();
                }
                
            }
        }
    

}
