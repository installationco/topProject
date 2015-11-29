using UnityEngine;
using System.Collections;

public class CameraMainScript : MonoBehaviour {

    public GameObject Cap;
	
	void Update () 
    {
        this.GetComponent<Rigidbody2D>().velocity = (Cap.transform.position - this.transform.position) * 10;
	}
}
