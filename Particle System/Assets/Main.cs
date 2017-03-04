using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Main : MonoBehaviour {
    //public GameObject Butterfly;
    // Use this for initialization
    GameObject world;
    void Start () {
        world = GameObject.Find("world");
    }
	
	// Update is called once per frame
	void Update () {
        if (this.transform.position.x < 1.5 && this.transform.position.x > 0.5 && this.transform.position.z < 1.5 && this.transform.position.z > 0.5)
         {
            Debug.Log("world transform");
            world.transform.position = new Vector3(1, 0.2f, 1);
            //GameObject world = Instantiate(Butterfly, transform.position, transform.rotation);
        }
    }

}
