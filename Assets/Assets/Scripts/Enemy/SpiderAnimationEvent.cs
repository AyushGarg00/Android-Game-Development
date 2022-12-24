using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpiderAnimationEvent : MonoBehaviour
{
    private Spider _spider;

    // Start is called before the first frame update
    void Start()
    {
        _spider = transform.parent.GetComponent<Spider>();
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void Fire()
    {
        Debug.Log("Spider should fire");
        _spider.Attack();
    }
}
