using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{

    public GameObject target;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 temp = target.transform.position - transform.position;
        temp.z = -10;
        transform.position = Vector3.Lerp(transform.position, temp, .002f);
    }
}
