using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
[CreateAssetMenu(fileName = "New_TileType", menuName = "ScriptableObjects/TileMap/New Tile Type")]
public class ColorToTile : ScriptableObject
{
    public Color color;
    public Tile tile;
}
