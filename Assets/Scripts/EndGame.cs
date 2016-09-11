using UnityEngine;
using System.Collections;

public class EndGame : MonoBehaviour
{

    public float endGame = 35f;
    private Light _lite;


    void Start()
    {
        _lite = this.GetComponent<Light>();
        StartCoroutine(LateCall());
    }

    IEnumerator LateCall()
    {
        yield return new WaitForSeconds(endGame);
        _lite.enabled = false;
    }
}
