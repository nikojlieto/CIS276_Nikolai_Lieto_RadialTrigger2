using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RadialTrigger : MonoBehaviour
{
    [SerializeField]
    private float radius = 4f;
    private bool isInside;
    [SerializeField]
    private float distance;
    

    private void OnDrawGizmos(){
        
        //calculate if within the radius
        Vector3 va = GameObject.Find("ObjectP").transform.position - transform.position;
        distance = Mathf.Sqrt(Mathf.Pow(va.x, 2f)+ Mathf.Pow(va.y, 2f)+Mathf.Pow(va.z, 2f));
        isInside = distance <= radius;
        if(isInside){
            UnityEditor.Handles.color = Color.green;
        } else {
            UnityEditor.Handles.color = Color.red;
        }
        UnityEditor.Handles.DrawWireDisc(transform.position, Vector3.forward, radius);
    }
    void Start()
    {
        
    }

    
}
