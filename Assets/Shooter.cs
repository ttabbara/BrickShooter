using UnityEngine;
using System.Collections;

public class Shooter : MonoBehaviour {

    public Rigidbody projectile;
    public Transform shotPos;
    public float shotForce = 1000;
    public float moveSpeed = 10;
    private const float verticalConstraint = 0.25f;

	// Update is called once per frame
	void Update () {
        
        float h = Input.GetAxis("Horizontal") * Time.deltaTime * moveSpeed;
        float v = Input.GetAxis("Vertical") * Time.deltaTime * moveSpeed;

        if (transform.position.y + v > verticalConstraint)
        {
            transform.Translate(new Vector3(h, v, 0));
        }

        if (Input.GetButtonUp("Fire1"))
        {
            Rigidbody shot = Instantiate(projectile, shotPos.position, shotPos.rotation) as Rigidbody;
            shot.AddForce(shotPos.forward * shotForce);
        }
	}
}
