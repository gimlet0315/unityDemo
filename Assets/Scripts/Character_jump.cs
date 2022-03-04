using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Character_jump : MonoBehaviour
{
    private Rigidbody playerRb;
    private Animator playerAnim;
    private AudioSource playerAudio;
    public float jumpForce=10;
    public float gravityModifier;
    public bool isOnGround=true;
    public bool gameOver=false;
    public ParticleSystem explosionParticle;
    public ParticleSystem dirtParticle;
    public AudioClip jumpSound;
    public AudioClip crashSound;
    //private float multi=3.0f;

    public float forward;
    public float speed=20.0f;
    // Start is called before the first frame update
    void Start()
    {
        playerRb=GetComponent<Rigidbody>();
        playerAnim=GetComponent<Animator>();
        playerAudio=GetComponent<AudioSource>();
        Physics.gravity*= gravityModifier;
    }

    // Update is called once per frame
    void Update()
    {
        forward=Input.GetAxis("Horizontal");
        transform.Translate(Vector3.forward*Time.deltaTime*speed*forward);

        if(Input.GetKeyDown(KeyCode.Space)&& isOnGround&&!gameOver)//!gameOver表示游戏未结束（gameOver表示0）
        {
            playerRb.AddForce(Vector3.up*jumpForce,ForceMode.Impulse);
            isOnGround = false;
            playerAnim.SetTrigger("Jump_trig");
            dirtParticle.Stop();
            playerAudio.PlayOneShot(jumpSound,1.0f);

            //原型：public void AddForce (Vector3 force, ForceMode mode= ForceMode.Force);force类型可以为：Acceleration、Impulse 或 Velocity Change；
            //效果：因为是施加的“力”，所以跳跃，有向上跳的动作，并且下落；而不是直接位移到高空不动；
        }
    }
    private void OnCollisionEnter(Collision collision)
    {

        if(collision.gameObject.CompareTag("Ground")||collision.gameObject.CompareTag("Obstacle"))
        {
            isOnGround=true;
            dirtParticle.Play();
        }
        /*else if(collision.gameObject.CompareTag("Obstacle"))
        {
            gameOver=true;
            Debug.Log("Game Over");
            playerAnim.SetBool("Death_b",true);
            playerAnim.SetInteger("DeathType_int",1);
            explosionParticle.Play();
            dirtParticle.Stop();
            playerAudio.PlayOneShot(crashSound,1.0f);

        }*/
    }
}
