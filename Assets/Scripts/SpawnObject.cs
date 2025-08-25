using System.Collections;
using System.Collections.Generic;
using JetBrains.Annotations;
using Meta.XR.ImmersiveDebugger.UserInterface.Generic;
using UnityEngine;

public class SpawnObject : MonoBehaviour
{
    
        public GameObject cube;

    // Start is called before the first frame update
    void Start()
    {
      
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void spawnCube()
    {
        Instantiate(cube, transform.position, transform.rotation);
    }
}
