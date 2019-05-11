using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gun : MonoBehaviour {
    public GameObject bulletPrefab;
    public GameObject explosion;

    // Use this for initialization
    void Start () {
        
	}
	
	// Update is called once per frame
	void Update () {
	
	}
    public void shoot()
    {
     GameObject go = Instantiate(bulletPrefab, transform.position, transform.rotation) as GameObject;
     go.GetComponent<Rigidbody>().AddForce(transform.forward * 1500, ForceMode.Impulse);
     GameObject co = Instantiate(explosion, transform.position, Quaternion.LookRotation(transform.forward));
     Destroy(go, 5f);
     }

    
}
