using UnityEngine;
using System.Collections;

public class Pusher : MonoBehaviour {
    private Rigidbody2D rb;

	// Use this for initialization
	void Start () {
        rb = GetComponent< Rigidbody2D >();
    }
	
	// Update is called once per frame
	void Update () {
	
	}

    void OnCollisionEnter2D( Collision2D coll ) {
        // FIXME Currently does nothing, as far as I can tell
        // Apply push in the direction the object is currently traveling
        coll.gameObject.GetComponent< Rigidbody2D >().AddForce( rb.velocity );
    }
}
