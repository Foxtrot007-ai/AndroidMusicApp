using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriadOrIntervalFiveLine : MonoBehaviour
{
    public GameObject notecase0;
    public GameObject notecase1;
    public GameObject notecase2;
    public GameObject notecase3;
    public GameObject notecase4;

    public GameObject musician;
    // Start is called before the first frame update
    void Start()
    {
        musician = GameObject.FindGameObjectWithTag("Musician");   
    }

    // Update is called once per frame
    void Update()
    {
        if(musician.GetComponent<Musician>().IntervalOrTriad)
        {
            notecase0.SetActive(false);
            notecase1.SetActive(false);
            notecase2.SetActive(true);
            notecase3.SetActive(true);
            notecase4.SetActive(true);
        }
        else
        {
            notecase0.SetActive(true);
            notecase1.SetActive(true);
            notecase2.SetActive(false);
            notecase3.SetActive(false);
            notecase4.SetActive(false);
        }
    }
}
