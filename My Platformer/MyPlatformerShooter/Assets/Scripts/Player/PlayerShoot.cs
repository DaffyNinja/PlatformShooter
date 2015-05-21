using UnityEngine;
using System.Collections;

public class PlayerShoot : MonoBehaviour {

   // public float shootSpeed;

    //public float bulletSpeed;

    public GameObject bulletOBj;

    public Transform bulletShot;

   

	// Use this for initialization
	void Start () 
    {
	
	}
	
	// Update is called once per frame
	void Update () 
    {
        if (Input.GetKey(KeyCode.RightControl))
        {
            Instantiate(bulletOBj, new Vector3(bulletShot.transform.position.x, bulletShot.transform.position.y, bulletShot.transform.position.z), transform.rotation);

           // bulletOBj.GetComponent<Rigidbody2D>().velocity = transform.forward * bulletSpeed;

            
        }
	
	}
}
