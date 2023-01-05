using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClickAndDestroy : MonoBehaviour
{
    
    // Update is called once per frame
    void Update()
    {
        if(input.(GetMouseButtonDown(0)))
        
        {RaycastHit hit;
        Ray ray = Camera.Main.ScreenPointToRay (Input.mousePosition)};

        if (Physic.Raycast(ray, out hit))
        (
            MeshCollider bc = hit.collider as MeshCollider;
            if (mc != null)
            destroy(mc.gameObejct);
        )
    }
}
