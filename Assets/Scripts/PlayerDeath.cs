using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerDeath : MonoBehaviour
{
    private Animator playerAnim;
    private AudioSource playerAudio;
    public bool isOnGround=true;
    public bool gameOver=false;
    public ParticleSystem explosionParticle;
    public ParticleSystem dirtParticle;
    public AudioClip crashSound;
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
        float y = transform.position.y;
        float y_enemy=GameObject.FindWithTag("Enemy").GetComponent<Transform>().position.y;
        
        if(collision.gameObject.CompareTag("Enemy")&&y<=y_enemy)
        {
            gameOver=true;
            Debug.Log("Game Over");
            //Destroy(gameObject);
            playerAnim.SetBool("Death_b",true);
            playerAnim.SetInteger("DeathType_int",1);
            explosionParticle.Play();
            dirtParticle.Stop();
            playerAudio.PlayOneShot(crashSound,1.0f);

        }
    }

}

