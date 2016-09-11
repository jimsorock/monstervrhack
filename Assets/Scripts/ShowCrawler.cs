using UnityEngine;
using System.Collections;

public class ShowCrawler : MonoBehaviour
{


    public float show = 25f;

    void Start()
    {
        StartCoroutine(ActivateRoutine());
    }
    private IEnumerator ActivateRoutine()
    {
        yield return new WaitForSeconds(show);    // and now we wait !

        // make a list of all children
        Transform[] ChildrenTransforms = this.gameObject.GetComponentsInChildren<Transform>(true);
        foreach (Transform t in ChildrenTransforms)
            t.gameObject.SetActive(true);      // enable all the objects in the list (even the parent)
    }
}
