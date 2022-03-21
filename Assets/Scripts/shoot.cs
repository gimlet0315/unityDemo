using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shoot : MonoBehaviour
{
    public GameObject projectilePrefab;
    public float fireRate = 0.5F;//0.5秒实例化一个子弹
    private float nextFire = 0.0F;
    public float speed = 5f;//子弹速度

    /*private void Update()
    {
        if (Input.GetButton("Fire1") && Time.time > nextFire)
        {
            nextFire = Time.time + fireRate;
            Rigidbody clone = (Rigidbody)Instantiate(projectilePrefab, transform.position, transform.rotation);//实例化一个子弹预制,并转成刚体
            if (clone != null)
            {
                clone.velocity = transform.TransformDirection(Vector3.forward * speed);
            }
        }
    }*/
}
