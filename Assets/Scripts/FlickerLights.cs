using UnityEngine;
using System.Collections;

public class FlickerLights : MonoBehaviour
{

    public float startFlicker = 15f;
    public float shutoff = 25f;
    private Light lite;

    void Start()
    {
        lite = this.GetComponent<Light>();
        StartCoroutine(LateCall());
    }

    IEnumerator LateCall()
    {
        yield return new WaitForSeconds(startFlicker);
        lite.enabled = !lite.enabled;
        yield return new WaitForSeconds(Random.Range(0.1f, 0.3f));
        lite.enabled = !lite.enabled;
        yield return new WaitForSeconds(Random.Range(0.1f, 0.5f));
        lite.enabled = !lite.enabled;
        yield return new WaitForSeconds(Random.Range(0.1f, 0.5f));
        lite.enabled = !lite.enabled;
        yield return new WaitForSeconds(shutoff);
        lite.enabled = false;
    }
}
