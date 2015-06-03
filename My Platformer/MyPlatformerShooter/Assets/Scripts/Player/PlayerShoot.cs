using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class PlayerShoot : MonoBehaviour {

   // public float shootSpeed;

    //public float bulletSpeed;

    public int ammoCount;

    public Text ammoText;

    public GameObject bulletOBj;

    public Transform bulletShot;


    //private Transform bulletsParent;

   

	// Use this for initialization
	void Start () 
    {
       // bulletsParent = GameObject.Find("Bullets Parent") as Transform;

       // bulletOBj.transform.parent = bulletsParent;

	
	}
	
	// Update is called once per frame
	void Update () 
    {
        ammoText.text = "Ammo: " + ammoCount.ToString();

        if (ammoCount >= 1)
        {

            if (Input.GetKey(KeyCode.RightControl) || Input.GetKey(KeyCode.LeftControl))
            {
                ammoCount--;

                Instantiate(bulletOBj, new Vector3(bulletShot.transform.position.x, bulletShot.transform.position.y, bulletShot.transform.position.z), transform.rotation);

                // bulletOBj.GetComponent<Rigidbody2D>().velocity = transform.forward * bulletSpeed;

            }
        }
	
	}
}
