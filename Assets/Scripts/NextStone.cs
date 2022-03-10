using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Lean.Touch;

public class NextStone : MonoBehaviour
{
    public GameObject[] Stones;
    public GameObject StoneRef;
    public int StoneNumber=0;
    public void OnCollisionEnter(Collision col)
    {
        if(col.gameObject.tag == "Stone")
        {
            //Stones[StoneNumber].GetComponent<SphereCollider>().enabled = false;
            if(StoneNumber >= 5)
            {
                if (StoneNumber == 9)
                {
                    Stones[4].SetActive(false);
                    Stones[4].transform.position = StoneRef.transform.position;
                    Stones[4].transform.rotation = StoneRef.transform.rotation;
                    //Stones[4].GetComponent<SphereCollider>().enabled = true;
                    Stones[4].GetComponent<LeanTouch>().enabled = true;
                    Stones[4].GetComponent<Rigidbody>().isKinematic = true;
                    Stones[0].SetActive(true);
                    Stones[0].transform.position = StoneRef.transform.position;
                    Stones[0].transform.rotation = StoneRef.transform.rotation;
                    //Stones[0].GetComponent<SphereCollider>().enabled = true;
                    Stones[0].GetComponent<LeanTouch>().enabled = true;
                    Stones[0].GetComponent<Rigidbody>().isKinematic = true;
                    StoneNumber = 0;
                }
                else
                {
                    Stones[StoneNumber + 1].SetActive(true);
                    Stones[StoneNumber + 1].GetComponent<LeanTouch>().enabled = true;
                    Stones[StoneNumber + 1].GetComponent<Rigidbody>().isKinematic = true;
                    Stones[StoneNumber - 5].SetActive(false);
                    Stones[StoneNumber - 5].transform.position = StoneRef.transform.position;
                    Stones[StoneNumber - 5].transform.rotation = StoneRef.transform.rotation;
                    //Stones[StoneNumber - 5].GetComponent<SphereCollider>().enabled = true;
                    Stones[StoneNumber - 5].GetComponent<LeanTouch>().enabled = true;
                    Stones[StoneNumber - 5].GetComponent<Rigidbody>().isKinematic = true;
                    StoneNumber++;
                }
            }
            else
            {
                Stones[StoneNumber + 1].SetActive(true);
                Stones[StoneNumber + 1].GetComponent<LeanTouch>().enabled = true;
                Stones[StoneNumber + 1].GetComponent<Rigidbody>().isKinematic = true;
                //Stones[StoneNumber + 1].GetComponent<SphereCollider>().enabled = true;
                Stones[StoneNumber + 5].SetActive(false);
                Stones[StoneNumber + 5].transform.position = StoneRef.transform.position;
                Stones[StoneNumber + 5].transform.rotation = StoneRef.transform.rotation;
                Stones[StoneNumber + 5].GetComponent<LeanTouch>().enabled = true;
                Stones[StoneNumber + 5].GetComponent<Rigidbody>().isKinematic = true;
                //Stones[StoneNumber + 5].GetComponent<SphereCollider>().enabled = true;
                StoneNumber++;
            }
        }
    }
}
