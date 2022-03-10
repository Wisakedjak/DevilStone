using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{

    public GameObject Devil;
    public GameObject StonePrefab;
    public GameObject startButton;
    GameObject StoneRef;
    // Start is called before the first frame update
    void Start()
    {
        StoneRef = GameObject.FindGameObjectWithTag("StoneRef");
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void Size2()
    {
        Devil.gameObject.transform.localScale = new Vector3(Devil.gameObject.transform.localScale.x * 2.0f, Devil.gameObject.transform.localScale.y * 2.0f, Devil.gameObject.transform.localScale.z * 2.0f);
    }

    public void Size1()
    {
        Devil.gameObject.transform.localScale = new Vector3(Devil.gameObject.transform.localScale.x / 4.0f, Devil.gameObject.transform.localScale.y / 4.0f, Devil.gameObject.transform.localScale.z / 4.0f);
    }

    public void StartingGame()
    {
        GameObject stone= Instantiate(StonePrefab, StoneRef.transform.position, StoneRef.transform.rotation);
        startButton.SetActive(false);
    }

}