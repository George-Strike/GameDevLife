using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using System;
using System.Text.RegularExpressions;
using Assets.Models;
using System.IO;

public class CoreGame : MonoBehaviour
{
    [SerializeField] private GameModel _gameModel = new GameModel();
    #region GameObjects
    public GameObject canvasField;
    public GameObject menuPanel;
    public GameObject overviewPanel;
    public GameObject gameCostField;
    public GameObject hardwareCostField;
    public GameObject engineCostField;
    public GameObject gameTitleField;
    public GameObject gameGenreField;
    public GameObject gameTypeField;
    public GameObject gamePriceField;
    public GameObject dateField;
    #endregion

    #region Properties
    public int devCostTotal
    {
        get => int.Parse(gameCostField.GetComponent<TextMeshProUGUI>().text);
    }
    public string hardware
    {
        get => hardwareCostField.GetComponent<TextMeshProUGUI>().text;
    }
    public string engine
    {
        get => engineCostField.GetComponent<TextMeshProUGUI>().text;
    }
    public string engineName
    {
        get => Regex.Replace(engine, @"(-)([\s\S]*)", string.Empty).TrimEnd();
    }
    public string hardwareName
    {
        get => Regex.Replace(hardware, @"(-)([\s\S]*)", string.Empty).TrimEnd();
    }
    //public int gamePrice
    //{
    //    get => int.Parse(gamePriceField.GetComponent<TextMeshProUGUI>().text);
    //}
    public string gameTitle
    {
        get => gameTitleField.GetComponent<TextMeshProUGUI>().text;
    }
    public string gameGenre
    {
        get => gameGenreField.GetComponent<TextMeshProUGUI>().text;
    }
    public string gameType
    {
        get => gameTypeField.GetComponent<TextMeshProUGUI>().text;
    }
    #endregion

    public Dictionary<string, int> GameOverviewDictionary()
    {
        int hardwareCost = int.Parse(Regex.Replace(hardware, @"([\s\S]*)(-)", string.Empty).Trim());
        int engineCost = int.Parse(Regex.Replace(engine, @"([\s\S]*)(-)", string.Empty).Trim());

        return new Dictionary<string, int>()
        {
            { hardwareName, hardwareCost },
            { engineName, engineCost }
        };
    }
    public void CalculateGameCost()
    {
        Debug.Log(gamePriceField.GetComponent<TextMeshProUGUI>().text);
        Dictionary<string, int> gameOverviewDictionary = GameOverviewDictionary();
        int gameCostTotal = devCostTotal;
        gameCostTotal = gameOverviewDictionary[hardwareName] + gameOverviewDictionary[engineName];
        gameCostField.GetComponent<TextMeshProUGUI>().text = gameCostTotal.ToString();
    }

    public void AddGameDetailsToJSON()
    {
        _gameModel.Title = gameTitle;
        _gameModel.Genre = gameGenre;
        _gameModel.Type = gameType;
        _gameModel.Hardware = hardwareName;
        _gameModel.Engine = engineName;
        //Price = gamePrice;
        _gameModel.ReviewScore = "";
        _gameModel.Fans = "";
        _gameModel.ReleaseDate = DateTime.UtcNow;
        _gameModel.UnitsSold = 0;
        _gameModel.DevelopmentCost = devCostTotal;
        _gameModel.Revenue = 0;
        _gameModel.Profit = 0;
        _gameModel.TotalSales = 0;
        _gameModel.SaleRank = "";
        Debug.Log(_gameModel.Title);
        var filePath = @"Assets/Resources/GameInfo.json";
        string gameJSON = JsonUtility.ToJson(_gameModel, true);
        Debug.Log(gameJSON);
        if (File.Exists(filePath))
        {
            File.AppendAllText(filePath, gameJSON);
        }
        else
        {
            File.WriteAllText(filePath, JsonUtility.ToJson(gameJSON));
        }
    }

    public void HideOrshowPanels()
    {

        if (menuPanel.activeSelf)
        {
            menuPanel.SetActive(false);
            overviewPanel.SetActive(true);
        }
        else
        {
            menuPanel.SetActive(true);
        }
    }

    public void Show()
    {
        canvasField.SetActive(true);
    }

    void Start()
    {
        canvasField.SetActive(false);
        overviewPanel.SetActive(false);
        //overviewPanel.SetActive(false);
        //menuPanel.SetActive(false);
    }
}

