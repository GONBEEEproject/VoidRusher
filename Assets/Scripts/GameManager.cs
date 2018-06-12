using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using DG.Tweening;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{

    public bool isPlay = false;
    private bool prePlay = true;

    [SerializeField]
    private GameObject Rig;

    [SerializeField]
    private GameObject[] titles;

    [SerializeField]
    private GameObject goal;

    [SerializeField]
    private GameObject youdied;

    [SerializeField]
    private Slider slider;

    [SerializeField]
    private AudioClip diedSE, goalSE;



    private AudioSource AS;





    [ContextMenu("GameStart")]
    public void GameStart()
    {
        isPlay = true;
        //for(int i = 0; i < titles.Length; i++)
        //{
        //    Color color=titles[i].GetComponent<Renderer>().material.color;
        //    alpha =color.a;
        //    DOTween.To(
        //        () => alpha,

        //        num => alpha = num,

        //        0,

        //        5.0f

        //        );

        //    color = new Color(color.r, color.g, color.b, alpha);
        //}
    }

    public void GameEnd()
    {
        RenderSettings.fogColor = Color.red;
        AS.PlayOneShot(diedSE);
        youdied.SetActive(true);
        isPlay = false;
    }

    public void GameClear()
    {
        goal.SetActive(true);
        AS.PlayOneShot(goalSE);
        isPlay = false;
    }

    [ContextMenu("GameReset")]
    public void GameReset()
    {
        RenderSettings.fogColor = new Color(0, 255, 255, 255);
        SceneManager.LoadScene(0);


    }

    // Use this for initialization
    void Start()
    {
        goal.SetActive(false);
        youdied.SetActive(false);
        AS = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        if (GvrControllerInput.ClickButtonDown && prePlay)
        {
            prePlay = false;
            GameStart();
        }

        if (GvrControllerInput.AppButtonDown)
        {
            GameReset();
        }

        if (isPlay)
        {
            slider.value = Rig.transform.position.z;
        }
    } 
}
