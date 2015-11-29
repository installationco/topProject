using UnityEngine;
using System.Collections;

public class hui : MonoBehaviour {

    public GameObject Suriken;
    Transform dulo;

    void Start()
    {
        dulo = this.transform.GetChild(0);
    }

	void Update ()
    {
        this.GetComponent<Rigidbody2D>().velocity = new Vector2(2, this.GetComponent<Rigidbody2D>().velocity.y);
        if (Input.GetMouseButtonDown(0))
        {
            this.GetComponent<Rigidbody2D>().velocity += new Vector2(0, 5);
        }
        Vector2 kostil = new Vector2(this.transform.position.x + 1, this.transform.position.y + 0.1f);
        if (Input.GetMouseButtonDown(1))
        {
            Instantiate(Suriken, dulo.position, transform.rotation);
        }

	}
}
