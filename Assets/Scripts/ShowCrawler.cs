using UnityEngine;
using System.Collections;

public class ShowCrawler : MonoBehaviour
{

    public AudioSource monsterScream;
    public void OnEnable()
    {
        if (!monsterScream.isPlaying)
            monsterScream.Play();




    }

}
