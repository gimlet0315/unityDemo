using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TransPos : MonoBehaviour
{
    //public Vector3 oldPosition;
    public Vector3 newPosition;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnCollisionEnter(Collision collision)
    {

        
        if(collision.gameObject.CompareTag("checkpoint"))
        {
            transform.position=newPosition;
        }
        
    }

}
