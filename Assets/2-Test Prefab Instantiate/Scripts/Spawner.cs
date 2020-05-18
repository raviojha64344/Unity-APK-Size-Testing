using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{

    [SerializeField]
    private GameObject goPrefab;

    [SerializeField]
    private int count = 100;

    void Start()
    {
        Spawn(count);   
    }

    private void Spawn(int count)
    {
        float xPos = 0f,zPos = 0f, yPos = 0f;
        for (int i = 0; i < count; i++)
        {
            GameObject go = Instantiate(goPrefab, transform);
            go.transform.position = new Vector3(xPos, yPos, zPos);
            xPos++;
            if (i % 10 == 0)
            {
                xPos = 0f;
                zPos++;
            }
            if(zPos == 10)
            {
                zPos = 0;
                yPos++;
            }
        }
    }
}
