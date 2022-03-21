using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_move : MonoBehaviour
{
    private Rigidbody playerRb;
    private Animator playerAnim;
    public bool isOnGround=true;
    public bool gameOver=false;
    public ParticleSystem dirtParticle;
    private float xVelocity;

    public float forward;
    public float speed=20.0f;
    // Start is called before the first frame update
    void Start()
    {
        playerRb=GetComponent<Rigidbody>();
        playerAnim=GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        forward=Input.GetAxis("Horizontal");

        
        if(forward<0)
        {
            transform.rotation=Quaternion.Euler(0,-90,0);
        }
        else if(forward>0)
        {
            transform.rotation=Quaternion.Euler(0,90,0);
        }

        float forwarD=System.Math.Abs(forward);

        transform.Translate(Vector3.forward*Time.deltaTime*speed*forwarD);

    }      

    private void OnCollisionEnter(Collision collision)
    {

        if(collision.gameObject.CompareTag("Ground")||collision.gameObject.CompareTag("Obstacle"))
        {
            isOnGround=true;
            dirtParticle.Play();
        }       
    }
   
}