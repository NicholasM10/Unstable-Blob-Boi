using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelGenerator : MonoBehaviour
{
    public GameObject wallObj;
    public Character character;

    //Total game length in X axis
    public float gameTileLength = 100f;

    void Start()
    {
        GenerateFoundation();
    }

    public void GenerateFoundation()
    {
        for (int i = 0; i < gameTileLength; i++)
        {
            GameObject obj = Instantiate(wallObj);
            obj.transform.position = new Vector3(i - 10, -5, 0);

        }
    }
}
