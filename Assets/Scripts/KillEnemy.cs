using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KillEnemy : MonoBehaviour
{
    public ParticleSystem explosionParticle;
    // Start is called before the first frame update &&y<y_player
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
       

    }
    void OnCollisionEnter(Collision collision)
    {
        float y = transform.position.y;
        float y_player=GameObject.FindWithTag("Player").GetComponent<Transform>().position.y;

        

        if(collision.gameObject.CompareTag("Player")&&y_player>y)
        {
            explosionParticle.Play();
            Destroy(gameObject);

        }
    }
}
