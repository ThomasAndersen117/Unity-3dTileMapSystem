using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New_Map", menuName = "ScriptableObjects/TileMap/New TileMap")]
public class Map : ScriptableObject
{

    public Tile defualtTile;
    public ColorToTile[] tileTypes;
    public Tile[,] tiles;
    int _h;
    int _w;

    public void CreateMap(int width, int height)
    {
        _h = height;
        _w = width;
        tiles = new Tile[_w, _h];
    }

}
