using UnityEngine;
using System.Collections;


public class ClickAndDestroy : MonoBehaviour
{
    
    Ray ray;
    RaycastHit hit;
    
    // Update is called once per frame
    void Update()
    {
        if(Input.GetMouseButtonDown(0))
        {
            ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        }

        if (Physics.Raycast(ray, out hit))
        {
            MeshCollider bc = hit.collider as MeshCollider;
            if (bc != null) Destroy(bc.gameObject);
        }
    }
}
