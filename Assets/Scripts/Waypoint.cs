using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Waypoint : MonoBehaviour
{
    [SerializeField] Tower playerTowerPrefab;
    [SerializeField] Tower enemyTowerPrefab;
    [SerializeField] bool isPlaceble;
    public bool IsPlaceble { get { return isPlaceble; } }

    GameManager gameManager;

    private void Awake() 
    {
        gameManager = FindObjectOfType<GameManager>();
    }

    void OnMouseDown() 
    {
        bool playerTurn = gameManager.GetPlayerTurn();
        if (isPlaceble && playerTurn)
        {
            PlaceTowersPlayer();
            Vector2Int transformPos = new Vector2Int(Mathf.RoundToInt(transform.position.x), Mathf.RoundToInt(transform.position.z));
            gameManager.RegisterPosGrid(transformPos, 1);
            gameManager.SwitchPlayerTurn();
        }
        else if(isPlaceble && !playerTurn)
        {
            PlaceTowersEnemy();
            Vector2Int transformPos = new Vector2Int(Mathf.RoundToInt(transform.position.x), Mathf.RoundToInt(transform.position.z));
            gameManager.RegisterPosGrid(transformPos, 2);
            gameManager.SwitchPlayerTurn();
        }
    }

    void PlaceTowersPlayer()
    {
        bool isPlaced = playerTowerPrefab.CreateTower(playerTowerPrefab, transform.position);
        isPlaceble = !isPlaced;
    }

     void PlaceTowersEnemy()
    {
        bool isPlaced = enemyTowerPrefab.CreateTower(enemyTowerPrefab, transform.position);
        isPlaceble = !isPlaced;
    }
}
