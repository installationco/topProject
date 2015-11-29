using UnityEngine;
using System.Collections;

public class hui : MonoBehaviour {
	void Update ()
    {
        this.GetComponent<Rigidbody2D>().velocity = new Vector2(2, this.GetComponent<Rigidbody2D>().velocity.y);
        if (Input.GetMouseButtonDown(0))
        {
            this.GetComponent<Rigidbody2D>().velocity += new Vector2(0, 5);
        }
	}
}
