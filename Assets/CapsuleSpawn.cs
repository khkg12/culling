using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CapsuleSpawn : MonoBehaviour
{
    public GameObject capsule;
    void Start()
    {
        SpawnObj(1000);
    }

    public void SpawnObj(int objNum)
    {
        for(int i = 0; i < objNum; i++)
        {
            Vector3 pos = new Vector3(Random.Range(-100, 100), Random.Range(-100, 100), 0);
            Quaternion qua = Quaternion.identity;
            qua.eulerAngles = new Vector3(90, 0, 0);
            Instantiate(capsule, pos, qua);
        }
    }
}
