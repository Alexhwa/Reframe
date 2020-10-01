using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Interable_objects : MonoBehaviour
{
    // Start is called before the first frame update
    public Transform Spawnpoint;
    public GameObject Prefab;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            Instantiate(Prefab, Spawnpoint.position, Spawnpoint.rotation);
            Debug.Log("Spawning");
        }
    }
}
