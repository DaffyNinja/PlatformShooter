using UnityEngine;
using System.Collections;

public class PlayerShootMouse : MonoBehaviour {

    public GameObject bulletOBj;

    public Transform bulletShot;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update ()
    {

        Vector3 pos = Camera.main.WorldToScreenPoint(transform.position);

        Vector3 dir = Input.mousePosition - pos;

        float angle = Mathf.Atan2(dir.y, dir.x) * Mathf.Rad2Deg;

        transform.rotation = Quaternion.AngleAxis(angle, Vector3.forward);

        //Vector3 mousePosition = Input.mousePosition;

        //mousePosition.z = 32;

        //Vector3 lookPos = Camera.main.ScreenToWorldPoint(mousePosition);

        //lookPos = lookPos - transform.position;

        //float angle = Mathf.Atan2(lookPos.x, lookPos.y) * Mathf.Rad2Deg;

        //transform.rotation = Quaternion.AngleAxis(angle, Vector3.forward);



        if (Input.GetMouseButton(0))
        {
            Instantiate(bulletOBj, new Vector3(bulletShot.transform.position.x, bulletShot.transform.position.y, bulletShot.transform.position.z), transform.rotation);

            // bulletOBj.GetComponent<Rigidbody2D>().velocity = transform.forward * bulletSpeed;


        }
	
	}
}
