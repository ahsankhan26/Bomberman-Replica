using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Tilemaps;

public class mapDestroyer : MonoBehaviour
{

    public Tilemap tilemap;         //to get the walls tilemap with colliders

    public Tile wallTile;               //to differentiate that if this tile then dont destroy
    public Tile destructibleTile;       //destroy this tile

    public GameObject explosionPrefab;  //contains the explosion animation
    public GameObject player1;



    public void Explode(Vector2 worldPos)
    {
        Vector3Int originCell = tilemap.WorldToCell(worldPos);  //origin cell is the location of the bomb drop

        //following lines of code execute the explode function on the place of bomb and 1 tile in all four direction excluding Z-axis
        ExplodeCell(originCell);
        ExplodeCell(originCell + new Vector3Int(1, 0, 0));
        ExplodeCell(originCell + new Vector3Int(0, 1, 0));
        ExplodeCell(originCell + new Vector3Int(1, 0, 0));
        ExplodeCell(originCell + new Vector3Int(-1, 0, 0));
        ExplodeCell(originCell + new Vector3Int(0, -1, 0));
        

    }

    void ExplodeCell(Vector3Int cell)
    {

        Tile tile = tilemap.GetTile<Tile>(cell);



        if (tile == wallTile) //if unbreakable wall than do nothing 
        {
            return;
        }

        if (tile == destructibleTile)
        {
            tilemap.SetTile(cell, null);    //destroy the tile
        }

        //explosion
        Vector3 pos = tilemap.GetCellCenterWorld(cell);
        Instantiate(explosionPrefab, pos, Quaternion.identity);
    }
}
