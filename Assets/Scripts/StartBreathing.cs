using UnityEngine;
using System.Collections;

public class StartBreathing : MonoBehaviour {

    public AudioSource monsterBreathing;

    public void OnEnable()
    {
        if (!monsterBreathing.isPlaying)
            monsterBreathing.Play();
    }
}
