using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{

    public float fireRate = 1f;
    public float moveSpeed = 5f;
    public float projectileFireHeight = 0.75f;
    public float screenBounds = 7.5f;

    public GameObject projectilePrefab;

    private float horizonatlInput;
    private bool canFire = true;
    private float nextFire = 0.0f;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        horizonatlInput = Input.GetAxis("Horizontal");

        transform.Translate(Vector3.right * Time.deltaTime * moveSpeed * horizonatlInput);

        if(transform.position.x < -screenBounds)
        {
            transform.position = new Vector3(-screenBounds, transform.position.y, transform.position.z);
        }
        else if(transform.position.x > screenBounds)
        {
            transform.position = new Vector3(screenBounds, transform.position.y, transform.position.z);
        }

        bool hasFired = Input.GetKey("space");
        
        if (hasFired)
        {
            Fire();
        }
    }

    private void Fire()
    {
        canFire = Time.time >= nextFire;
        if (canFire)
        {
            Vector3 projectileOffset = new Vector3(0, projectileFireHeight, 0);
            Instantiate(projectilePrefab, transform.position + projectileOffset, projectilePrefab.transform.rotation);
            nextFire = Time.time + fireRate;
        }

       
        
    }
}
