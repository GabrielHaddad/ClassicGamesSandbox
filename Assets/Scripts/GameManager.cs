using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    [SerializeField] int gridSize;
    [SerializeField] int cellSize = 10;
    Dictionary<Vector2Int, int> grid;
    bool playerTurn = true;

    void Start() 
    {
        grid = new Dictionary<Vector2Int, int>();

        for(int i = 0; i < gridSize; i++)
        {
            for(int j = 0; j < gridSize; j++)
            {
                grid[new Vector2Int(i, j)] = 0;
            }
        }
    }

    void Update() 
    {
        
        if (grid[new Vector2Int(0, 0)] == 1 && grid[new Vector2Int(0, 1)] == 1 && grid[new Vector2Int(0, 2)] == 1)
        {
            Debug.Log("Azul Ganhou!!");
        }
        else if (grid[new Vector2Int(0, 0)] == 1 && grid[new Vector2Int(1, 0)] == 1 && grid[new Vector2Int(2, 0)] == 1)
        {
            Debug.Log("Azul Ganhou!!");
        }
        else if (grid[new Vector2Int(2, 0)] == 1 && grid[new Vector2Int(2, 1)] == 1 && grid[new Vector2Int(2, 2)] == 1)
        {
           Debug.Log("Azul Ganhou!!"); 
        }
        else if (grid[new Vector2Int(0, 2)] == 1 && grid[new Vector2Int(1, 2)] == 1 && grid[new Vector2Int(2, 2)] == 1)
        {
            Debug.Log("Azul Ganhou!!");
        }
        else if (grid[new Vector2Int(1, 0)] == 1 && grid[new Vector2Int(1, 1)] == 1 && grid[new Vector2Int(1, 2)] == 1)
        {
            Debug.Log("Azul Ganhou!!");
        }
        else if (grid[new Vector2Int(0, 0)] == 1 && grid[new Vector2Int(1, 1)] == 1 && grid[new Vector2Int(2, 2)] == 1)
        {
            Debug.Log("Azul Ganhou!!");
        }
        else if (grid[new Vector2Int(0, 2)] == 1 && grid[new Vector2Int(1, 1)] == 1 && grid[new Vector2Int(2, 0)] == 1)
        {
            Debug.Log("Azul Ganhou!!");
        }

        if (grid[new Vector2Int(0, 0)] == 2 && grid[new Vector2Int(0, 1)] == 2 && grid[new Vector2Int(0, 2)] == 2)
        {
            Debug.Log("Vermelho Ganhou!!");
        }
        else if (grid[new Vector2Int(0, 0)] == 2 && grid[new Vector2Int(1, 0)] == 2 && grid[new Vector2Int(2, 0)] == 2)
        {
            Debug.Log("Vermelho Ganhou!!");
        }
        else if (grid[new Vector2Int(2, 0)] == 2 && grid[new Vector2Int(2, 1)] == 2 && grid[new Vector2Int(2, 2)] == 2)
        {
           Debug.Log("Vermelho Ganhou!!");
        }
        else if (grid[new Vector2Int(0, 2)] == 2 && grid[new Vector2Int(1, 2)] == 2 && grid[new Vector2Int(2, 2)] == 2) 
        {
            Debug.Log("Vermelho Ganhou!!");
        }
        else if (grid[new Vector2Int(1, 0)] == 2 && grid[new Vector2Int(1, 1)] == 2 && grid[new Vector2Int(1, 2)] == 2)
        {
            Debug.Log("Vermelho Ganhou!!");
        }
        else if (grid[new Vector2Int(0, 0)] == 2 && grid[new Vector2Int(1, 1)] == 2 && grid[new Vector2Int(2, 2)] == 2)
        {
            Debug.Log("Vermelho Ganhou!!");
        }
        else if (grid[new Vector2Int(0, 2)] == 2 && grid[new Vector2Int(1, 1)] == 2 && grid[new Vector2Int(2, 0)] == 2)
        {
            Debug.Log("Vermelho Ganhou!!");
        }
        
    }

    public void RegisterPosGrid(Vector2Int pos, int player)
    {
        Vector2Int newPos = new Vector2Int(pos.x / cellSize, pos.y / cellSize);
        grid[newPos] = player;
    }

    public void SwitchPlayerTurn()
    {
        playerTurn = !playerTurn;
    }

    public bool GetPlayerTurn()
    {
        return playerTurn;
    }
}
