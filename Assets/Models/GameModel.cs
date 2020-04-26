using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace Assets.Models
{
    [Serializable]
    public class GameModel
    {
        public string Title {get; set;}
        public string Genre {get; set;}
        public string Type {get; set;}
        public string Hardware {get; set;}
        public string Engine {get; set;}
        public string ReviewScore {get; set;}
        public string Fans {get; set;}
        public DateTime ReleaseDate {get; set;}
        public int UnitsSold {get; set;}
        public int Price {get; set;}
        public int DevelopmentCost {get; set;}
        public int Revenue {get; set;}
        public int Profit {get; set;}
        public int TotalSales {get; set;}
        public string SaleRank {get; set;}
    }
    //GameModel game = new GameModel
    //{
    //    Title = gameTitle,
    //    Genre = gameGenre,
    //    Type = gameType,
    //    Hardware = hardwareName,
    //    Engine = engineName,
    //    //Price = gamePrice,
    //    ReviewScore = null,
    //    Fans = null,
    //    ReleaseDate = DateTime.UtcNow,
    //    UnitsSold = 0,
    //    DevelopmentCost = devCostTotal,
    //    Revenue = 0,
    //    Profit = 0,
    //    TotalSales = 0,
    //    SaleRank = null
    //};
}
