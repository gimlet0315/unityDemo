using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BrickDamage : MonoBehaviour
{
    public ParticleSystem explosionParticle;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
        

    }

     void OnCollisionEnter(Collision collision)
    {
        float y = transform.position.y-0.5f;
        //GameObject player=GameObject.FindWithTag("Player");
        float y_player=GameObject.FindWithTag("Player").GetComponent<Transform>().position.y;

        

        if(collision.gameObject.CompareTag("Player")&&y>y_player)
        {
            explosionParticle.Play();
            Destroy(gameObject);

        }
    }

}
