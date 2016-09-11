using UnityEngine;
using System.Collections;

public class FlickerLights : MonoBehaviour
{

    public float startFlicker = 15f;
    public float shutoff = 5f;
    private Light _lite;
    public GameObject elevatorMusic;
    public AudioSource creepyMusic;
    public GameObject monster;


    void Start()
    {
        _lite = this.GetComponent<Light>();
        StartCoroutine(LateCall());
    }

    IEnumerator LateCall()
    {
        yield return new WaitForSeconds(startFlicker);
        _lite.enabled = !_lite.enabled;
        yield return new WaitForSeconds(Random.Range(0.1f, 0.3f));
        _lite.enabled = !_lite.enabled;
        yield return new WaitForSeconds(Random.Range(0.1f, 0.5f));
        _lite.enabled = !_lite.enabled;
        yield return new WaitForSeconds(Random.Range(0.1f, 0.5f));
        _lite.enabled = !_lite.enabled;
        yield return new WaitForSeconds(shutoff);
        _lite.enabled = false;
        elevatorMusic.SetActive(false);

        if(!creepyMusic.isPlaying)
           creepyMusic.PlayDelayed(1.5f);
        yield return new WaitForSeconds(7f);
        Transform[] ChildrenTransforms = monster.GetComponentsInChildren<Transform>(true);
        foreach (Transform t in ChildrenTransforms)
            t.gameObject.SetActive(true);      // enable all the objects in the list (even the parent)
    }


}
