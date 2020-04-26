using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New Game", menuName = "ScriptableObjects/GameObjects")]
public class GameScript : ScriptableObject
{
    public string Title;
    public string Genre;
    public string Type;
    public string Hardware;
    public string Engine;
    public int Price;
    public int Cost;
    public int Revenue;
    public int sales;
}
