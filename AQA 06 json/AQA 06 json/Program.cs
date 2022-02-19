using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using System.IO;


namespace AQA_06_json
{

    public class Shops
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public List<Phones> phones { get; set; }

        public void countphone(myLog log)
        {
            int countIOS = 0;
            int countAND = 0;
            for (int i = 0; i < phones.Count; i++)
            {
                if (phones[i].IsAvailable == true)
                {
                    if (phones[i].OperationSystemType == "IOS")
                    {
                        countIOS++;
                    }
                    if (phones[i].OperationSystemType == "Android")
                    {
                        countAND++;
                    }
                }
            }
            log.logger.LogInformation($"Count phones IOS :{countIOS}");
            log.logger.LogInformation($"Count phones Android :{countAND}");
        }

        public static Phones analysisModel(List<Shops> pList,myLog log)
        {
            Boolean wrong = true;
            Phones model = new Phones();
            while (wrong)
            {
                int count = 0;
                log.logger.LogInformation("\nWhich mobile phone do you want to buy ?");
                model.Model = Console.ReadLine();
                foreach (Shops glo in pList)
                {
                    for (int i = 0; i < glo.phones.Count; i++)
                    {
                        if (model.Model == glo.phones[i].Model && glo.phones[i].IsAvailable == true)
                        {
                            model = glo.phones[i];
                            log.logger.LogInformation("\nModel found");
                            log.logger.LogInformation("\nId                 : " + glo.Id);
                            log.logger.LogInformation("Name               : " + glo.Name);
                            log.logger.LogInformation("Description        : " + glo.Description);
                            for (int j = 0; j < glo.phones.Count; j++)
                            {
                                if (glo.phones[j].IsAvailable == true)
                                {
                                    log.logger.LogInformation("\nModel              :" + glo.phones[j].Model);
                                    log.logger.LogInformation("OperationSystemType: " + glo.phones[j].OperationSystemType);
                                    log.logger.LogInformation("MarketLaunchDate   : " + glo.phones[j].MarketLaunchDate);
                                    log.logger.LogInformation("Price              : " + glo.phones[j].Price);
                                }
                            }
                            wrong = false;
                            break;
                        }
                        try
                        {
                            if (model.Model != glo.phones[i].Model && i + 1 == glo.phones.Count)
                            {
                                count++;
                                if (count == pList.Count)
                                {
                                    log.logger.LogInformation("This mobile phone is not found");
                                }
                            }
                        }
                        catch (ModelException ex)
                        {
                            log.logger.LogInformation($"Ошибка: {ex.Message}");
                        }
                        if (model.Model == glo.phones[i].Model && glo.phones[i].IsAvailable == false)
                        {
                            log.logger.LogInformation($"This mobile phone is out of stock in {glo.Name}");
                            break;
                        }
                    }
                }
            }
            return model;
        }

        public static void whichshops(List<Shops> pList, Phones model,myLog log)
        {
            Boolean wrong = true;
            while (wrong)
            {
                int count = 0;
                log.logger.LogInformation($"\nIn which store do you want to buy the mobile phone {model.Model}?");
                string whichshops = Console.ReadLine();
                foreach (Shops glo2 in pList)
                {
                    for (int i = 0; i < glo2.phones.Count; i++)
                    {

                        try
                        {
                            if (whichshops != glo2.Name && i + 1 == glo2.phones.Count)
                            {
                                count++;
                                if (count == pList.Count)
                                {
                                    log.logger.LogInformation("This shop is not found");
                                }
                            }
                        }
                        catch (WhichShopsException ex)
                        {
                            log.logger.LogInformation($"Ошибка: {ex.Message}");
                        }

                        if (whichshops == glo2.Name && glo2.phones[i] == model)

                        {
                            log.logger.LogInformation($"Order for {model.Model} {model.OperationSystemType}, price {model.Price}, market launch date {model.MarketLaunchDate}, in shop {glo2.Name}  has been successfully placed");
                            wrong = false;
                            break;
                        }
                        if (whichshops == glo2.Name && glo2.phones[i] != model && i + 1 == glo2.phones.Count)
                        {
                            log.logger.LogInformation("This store exists, but this model is not available or it has ended");
                        }
                    }
                }
            }
        }
    }


        class ModelException : Exception
        {
            public ModelException(string message) : base(message) { }

        }


        class WhichShopsException : Exception
        {
            public WhichShopsException(string message) : base(message) { }
        }


        public class Phones
        {
            public string Model { get; set; }
            public string OperationSystemType { get; set; }
            public string MarketLaunchDate { get; set; }
            public int Price { get; set; }
            public bool IsAvailable { get; set; }
            public int ShopId { get; set; }
        }
    

    public class myLog
    {
        public ILogger<Program> logger;

        public myLog()
        {
            ILoggerFactory loggerFactory = LoggerFactory.Create(config => { config.AddConsole(); });
            logger = loggerFactory.CreateLogger<Program>();
        }
    }

     public class Program
     {
         public static void Main(string[] args)
         {
                myLog log = new myLog();
            try
            {
                String JSONstring = File.ReadAllText(@"C:\\Users\User\Desktop\json6.txt");
                List<Shops> pList = JsonConvert.DeserializeObject<List<Shops>>(JSONstring);
                foreach (Shops p in pList)
                {
                    log.logger.LogInformation("\nShops:");
                    log.logger.LogInformation("Id   : " + p.Id + "   ");
                    log.logger.LogInformation("Name  : " + p.Name);
                    log.logger.LogInformation("Description: " + p.Description);
                    p.countphone(log);
                }
                Phones model = Shops.analysisModel(pList, log);
                Shops.whichshops(pList, model,log);
            }
            catch (FileNotFoundException)
            {
                log.logger.LogInformation($"File :{File.ReadAllText(@"C:\\Users\User\Desktop\json6.txt")} was not found");
            }
             Console.Read();
         }
     }
}