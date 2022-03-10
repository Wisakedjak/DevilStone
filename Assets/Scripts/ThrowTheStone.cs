using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Lean.Common;
using Lean.Touch;

public class ThrowTheStone : MonoBehaviour
{
    GameObject StoneRef;
    public GameObject StonePrefab;
    bool isCreated=true;
    bool isThrown;

    void Start()
    {
        StoneRef = GameObject.FindGameObjectWithTag("StoneRef");
        GetComponent<Rigidbody>().isKinematic = true;
        GetComponent<LeanTouch>().enabled = true;
        isThrown = false;


    }
    void Update()
    {
        if(isCreated && GetComponent<LeanTouch>().isSwipe == true)
        {
            isThrown = true;
            isCreated = false;
            GetComponent<LeanTouch>().isSwipe = false;
            StartCoroutine(NewStone());
        }
        if (!isThrown)
        {
            transform.position = StoneRef.transform.position;
            transform.rotation = StoneRef.transform.rotation;
        }
    }
    IEnumerator NewStone()
    {
        yield return new WaitForSeconds(2.0f);
        Instantiate(StonePrefab,StoneRef.transform.position,StoneRef.transform.rotation);
        isCreated = true;
    }
}
