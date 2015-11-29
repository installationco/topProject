using UnityEngine;
using System.Collections;

public class SurikenScript : MonoBehaviour {

    GameObject Cap;

	void Start () 
    {
        Cap = GameObject.FindGameObjectWithTag("Captain");
        this.GetComponent<Rigidbody2D>().velocity = new Vector2(15 * Mathf.Cos(Cap.transform.rotation.eulerAngles.z * Mathf.PI / 180.0f), 15 * Mathf.Sin(Cap.transform.rotation.eulerAngles.z * Mathf.PI / 180.0f));
	}

    void OnGUI()
    {
        GUI.Label(new Rect(10, 10, 100, 100), Mathf.Cos(Cap.transform.rotation.eulerAngles.z).ToString());
    }
	
	void Update () 
    {
        if (this.transform.position.y < -15)
            Destroy(this.gameObject);
	}
}
