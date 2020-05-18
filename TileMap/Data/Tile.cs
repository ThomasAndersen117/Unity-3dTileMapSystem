using UnityEngine;

[CreateAssetMenu(fileName = "New_Tile", menuName = "ScriptableObjects/TileMap/New Tile")]
public class Tile : ScriptableObject
{
    
    public bool isWalkable;
    public GameObject tile;

}
