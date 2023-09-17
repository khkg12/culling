using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;


public class CapsuleCulling : MonoBehaviour
{        
    MeshRenderer meshRenderer;
    
    void Start()
    {     
        meshRenderer = GetComponent<MeshRenderer>();              
    }
    
    void Update()
    {        
        if(CullingManager.Instance.isRender(transform.position))
        {
            meshRenderer.enabled = true;
        }
        else
        {
            meshRenderer.enabled = false;
        }
    }
}
