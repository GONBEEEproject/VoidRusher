using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RigRotation : MonoBehaviour
{

    [SerializeField]
    private float rotateMax;

    private float time;

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
            time += Time.deltaTime;
            transform.rotation = Quaternion.Euler(0, Mathf.Sin(time / 2) * rotateMax, 0);
        }
    }
}
