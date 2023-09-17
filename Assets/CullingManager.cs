using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class CullingManager : MonoBehaviour
{
        
    public static CullingManager Instance
    {
        get
        {
            if(instance == null)
            {
                instance = FindObjectOfType<CullingManager>();
            }
            return instance;
        }
    }
    private static CullingManager instance;

    float x;
    float y;

    public float Left
    {
        get => Camera.main.transform.position.x - x;
    }
    public float Right
    {
        get => Camera.main.transform.position.x + x;
    }
    public float Top
    {
        get => Camera.main.transform.position.y + y;
    }
    public float Bottom
    {
        get => Camera.main.transform.position.y - y;
    }

    public bool isRender(Vector3 pos)
    {        
        if ((pos.x >= Left && pos.x <= Right) && (pos.y >= Bottom && pos.y <= Top)) return true;
        return false;
    }

    void Awake()
    {                
        x = Camera.main.orthographicSize * Screen.width / Screen.height; // 화면 중앙에서 화면끝까지의 길이
        y = Camera.main.orthographicSize;
    }  
}
