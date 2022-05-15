using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PalletsBehavior : MonoBehaviour
{
    [SerializeField] Transform leftPallet;
    [SerializeField] Transform rightPallet;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Z))
        {
            leftPallet.Rotate(0, 0, 45);
        }

        if (Input.GetKeyUp(KeyCode.Z))
        {
            leftPallet.Rotate(0, 0, -45);
        }

        if (Input.GetKeyDown(KeyCode.M))
        {
            rightPallet.Rotate(0, 0, -45);
        }

        if (Input.GetKeyUp(KeyCode.M))
        {
            rightPallet.Rotate(0, 0, 45);
        }
    }
}
