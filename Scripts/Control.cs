using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Control : MonoBehaviour
{

    private Transform player;
    public float speed;
    public float maxB, minB;

    public GameObject shot;
    public Transform shotSpawn;
    public float fireRate = 0.4f;
    
    private float nextFire;
    // Start is called before the first frame update
    void Start()
    {
        player = GetComponent<Transform>();
  
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        float h = Input.GetAxis("Horizontal");

        if (player.position.x < minB && h < 0)
        {
            h = 0;
        }
        else if (player.position.x > maxB && h > 0)
        {
            h = 0;
        }
        player.position += Vector3.right * h * speed;
    }

    void Update()
    {
        
        if(Input.GetButton("Fire1") && Time.time > nextFire)
        {
            nextFire = Time.time + fireRate;
            if (Scoring.HighScore >= 1000)
                {
                nextFire -= 0.3f;
                }
            Instantiate(shot, shotSpawn.position, shotSpawn.rotation);
        }
    }
}
