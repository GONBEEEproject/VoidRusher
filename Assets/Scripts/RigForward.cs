using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RigForward : MonoBehaviour
{

    [SerializeField]
    private float speed;

    GameManager gm;


    // Use this for initialization
    void Start()
    {
        gm = GameObject.Find("GameManager").GetComponent<GameManager>();
    }

    // Update is called once per frame
    void Update()
    {



        if (gm.isPlay)
        {
            transform.position += Vector3.forward * speed * Time.deltaTime;
        }


    }



}
