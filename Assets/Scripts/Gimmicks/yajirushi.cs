using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class yajirushi : MonoBehaviour {


    [SerializeField]
    private float speed;



    // Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
        this.transform.position += Vector3.forward * speed*Time.deltaTime;
        if (transform.position.z > 2.5)
        {
            transform.position = new Vector3(0, -0.7f, 0.5f);
        }
	}
}
