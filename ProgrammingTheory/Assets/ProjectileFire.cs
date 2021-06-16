using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProjectileFire : MonoBehaviour
{
    public float projectileSpeed = 10f;
    public float fireDirection = 1.0f;
    public float verticalBounds = 5.0f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.up * Time.deltaTime * fireDirection * projectileSpeed);

        if(transform.position.y >= verticalBounds)
        {
            Destroy(gameObject);
        }
    }
}
