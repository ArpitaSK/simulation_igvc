using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using System.Text;

public class car : MonoBehaviour {
    private Rigidbody r;
    private string filePath = @"C:\vehicleparam.csv";
    private string delimiter = ",";
    private StringBuilder sb = new StringBuilder();
	// Use this for initialization
	void Start () {
        r = GetComponent<Rigidbody>();
	}
	
	// Update is called once per frame
	void Update () {
 
        float x1 =  r.velocity.x;
        float x2 = r.velocity.y;
        float x3 =  r.velocity.z;
        double speed =  Mathf.Sqrt(x1 * x1 + x2 * x2 + x3 * x3);
        speed = speed * 3.6 * 0.621*0.305;
        float x4 = r.angularVelocity.magnitude;
        Debug.Log("Speed: "+x4);
        sb.AppendLine(delimiter+speed);
        File.AppendAllText(filePath, sb.ToString());
       // File.WriteAllText("C:\abc.csv",csv.ToString());
	}
}
