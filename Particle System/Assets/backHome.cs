using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class backHome : MonoBehaviour {
    GameObject head;
    public Transform target;
    public float speed;
    // Use this for initialization
    void Start () {
        head = GameObject.Find("Main Camera");
    }
	
	// Update is called once per frame
	void Update () {
        if (head.transform.position.x < 3.5 && head.transform.position.x > 2.5 && head.transform.position.z < 3.5 && head.transform.position.z > 2.5)
        {
            Debug.Log("cat");
            float step = speed * Time.deltaTime;
            transform.position = Vector3.MoveTowards(transform.position, target.position, step);
            //GameObject world = Instantiate(Butterfly, transform.position, transform.rotation);
        }
    }
}
