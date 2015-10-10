using UnityEngine;
using System.Collections;

public class WindBlastPush : MonoBehaviour {
    private Rigidbody2D body;

	// Use this for initialization
	void Start () {
        Rigidbody2D body = GetComponent< Rigidbody2D >();
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    void OnCollisionEnter2D( Collision2D coll ) {
        // If colliding object is physics enabled and not kinematic
        // Apply a force to it in the direction of blast travel
    }
}
