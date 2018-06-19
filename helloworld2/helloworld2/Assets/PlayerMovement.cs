using UnityEngine;

public class PlayerMovement : MonoBehaviour {
    public Rigidbody rb;
	// Use this for initialization
	void Start () {
        Debug.Log("Hello World");
        rb.useGravity = true;
        rb.AddForce(0, 10, 0);
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
