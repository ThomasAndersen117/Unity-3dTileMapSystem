using System;
using System.CodeDom.Compiler;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[CreateAssetMenu(fileName = "Level Manager", menuName = "ScriptableObjects/Managers/Level Manager")]
public class GameManager : ScriptableObject
{
    public List<Team> Teams = new List<Team>();
    public Texture2D Level;
    public Map map;
    public ColorToTile[] TileTypes;
    public Var.IntVarable mapScale;
    public void GenerateLevel()
    {
        map.CreateMap(Level.width, Level.height);
        readLevel();

    }

    private void readLevel()
    {

        for(int x = 0; x< Level.width; x++)
        {
            for (int y = 0; y < Level.height; y++)
            {
                GenerateTile(x, y);
                Vector3 position = new Vector3(x, 0, y);
                if(map.tiles[x,y] != null)
                    Instantiate(map.tiles[x, y].tile, position, Quaternion.identity, FindObjectOfType<StartLevel>().transform);
            }
        }
    
    }

    private void GenerateTile(int x, int y)
    {
        Color t = Level.GetPixel(x, y);
        foreach(ColorToTile thing in TileTypes)
        {
            if (!thing.color.Equals(t))
            {
                map.tiles[x, y] = thing.tile;
                Debug.Log("non_Defualt Tile Loaded");
            }
            else
            {
                map.tiles[x, y] = map.defualtTile;
                Debug.Log("No non_Defualt Tile");
            }

        }

    }
}

