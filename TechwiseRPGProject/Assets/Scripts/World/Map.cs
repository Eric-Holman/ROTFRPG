using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Map : MonoBehaviour
{

    public Dictionary<Vector2Int, MonoBehaviour> OccupiedCells {get; private set;} = new Dictionary<Vector2Int, MonoBehaviour>(); //list value to store which cells are occupied. This way we can determine where the character can not move I.E NPCS and

    public Grid Grid {get; private set;}
    private void Awake()
    {
            Grid =  GetComponent<Grid>();
            OccupiedCells.Clear();
    }
}