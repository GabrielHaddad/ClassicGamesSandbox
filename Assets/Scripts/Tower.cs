using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tower : MonoBehaviour
{
    public bool CreateTower(Tower tower, Vector3 position)
    {
        Instantiate(tower, position, Quaternion.identity);
        return true;
    }
}
