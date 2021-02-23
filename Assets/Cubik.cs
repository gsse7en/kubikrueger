using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cubik : MonoBehaviour
{
    public GameObject myPrefab;
    public Material newMaterialRef;


    // This script will simply instantiate the Prefab when the game starts.
    void Start()
    {
        for(int i = 0; i < 3; i++)
        {
            for(int j = 0; j < 3; j++)
            {
                for(int k = 0; k < 3; k++)
                {
                    GameObject go = Instantiate(myPrefab, new Vector3(i*2f, j*2f, k*1.4f), Quaternion.identity) as GameObject;
                    go.AddComponent<piece>();
                    Renderer rend = go.AddComponent<Renderer>();
                    if (rend != null){
                        rend.material = newMaterialRef;
                    }
                }
            }
        }
        // Instantiate at position (0, 0, 0) and zero rotation.
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
