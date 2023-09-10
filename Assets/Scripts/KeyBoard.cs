using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeyBoard : MonoBehaviour
{
    public GameObject C1;
    public GameObject Cis1;
    public GameObject D1;
    public GameObject Dis1;
    public GameObject E1;
    public GameObject F1;
    public GameObject Fis1;
    public GameObject G1;
    public GameObject Gis1;
    public GameObject A1;
    public GameObject Ais1;
    public GameObject H1;
    public GameObject C2;
    public GameObject Cis2;
    public GameObject D2;
    public GameObject Dis2;
    public GameObject E2;
    public GameObject F2;
    public GameObject Fis2;
    public GameObject G2;
    public GameObject Gis2;
    public GameObject A2;
    public GameObject Ais2;
    public GameObject H2;
    public GameObject musician;


    // Start is called before the first frame update
    void Start()
    {
        musician = GameObject.FindGameObjectWithTag("Musician");
    }

    // Update is called once per frame
    void Update()
    {
        if (musician.GetComponent<Musician>().canshow)
        {

            C1.SetActive(false);
            Cis1.SetActive(false);
            D1.SetActive(false);
            Dis1.SetActive(false);
            E1.SetActive(false);
            F1.SetActive(false);
            Fis1.SetActive(false);
            G1.SetActive(false);
            Gis1.SetActive(false);
            A1.SetActive(false);
            Ais1.SetActive(false);
            H1.SetActive(false);
            C2.SetActive(false);
            Cis2.SetActive(false);
            D2.SetActive(false);
            Dis2.SetActive(false);
            E2.SetActive(false);
            F2.SetActive(false);
            Fis2.SetActive(false);
            G2.SetActive(false);
            Gis2.SetActive(false);
            A2.SetActive(false); 
            Ais2.SetActive(false);
            H2.SetActive(false);

            if (musician.GetComponent<Musician>().IntervalOrTriad)
            {
                switch (musician.GetComponent<Musician>().WhichNotes)
                {
                    case 0:
                        C1.SetActive(true);
                        break;
                    case 1:
                        Cis1.SetActive(true);
                        break;
                    case 2:
                        D1.SetActive(true);
                        break;
                    case 3:
                        Dis1.SetActive(true);
                        break;
                    case 4:
                        E1.SetActive(true);
                        break;
                    case 5:
                        F1.SetActive(true);
                        break;
                    case 6:
                        Fis1.SetActive(true);
                        break;
                    case 7:
                        G1.SetActive(true);
                        break;
                    case 8:
                        Gis1.SetActive(true);
                        break;
                    case 9:
                        A1.SetActive(true);
                        break;
                    case 10:
                        Ais1.SetActive(true);
                        break;
                    case 11:
                        H1.SetActive(true);
                        break;
                    case 12:
                        C2.SetActive(true);
                        break;
                    case 13:
                        Cis2.SetActive(true);
                        break;
                    case 14:
                        D2.SetActive(true);
                        break;
                    case 15:
                        Dis2.SetActive(true);
                        break;
                    case 16:
                        E2.SetActive(true);
                        break;
                    case 17:
                        F2.SetActive(true);
                        break;
                    case 18:
                        Fis2.SetActive(true);
                        break;
                    case 19:
                        G2.SetActive(true);
                        break;
                    case 20:
                        Gis2.SetActive(true);
                        break;
                    case 21:
                        A2.SetActive(true);
                        break;
                    case 22:
                        Ais2.SetActive(true);
                        break;
                    case 23:
                        H2.SetActive(true);
                        break;
                }
                switch (musician.GetComponent<Musician>().SecondNoteTriad)
                {
                    case 0:
                        C1.SetActive(true);
                        break;
                    case 1:
                        Cis1.SetActive(true);
                        break;
                    case 2:
                        D1.SetActive(true);
                        break;
                    case 3:
                        Dis1.SetActive(true);
                        break;
                    case 4:
                        E1.SetActive(true);
                        break;
                    case 5:
                        F1.SetActive(true);
                        break;
                    case 6:
                        Fis1.SetActive(true);
                        break;
                    case 7:
                        G1.SetActive(true);
                        break;
                    case 8:
                        Gis1.SetActive(true);
                        break;
                    case 9:
                        A1.SetActive(true);
                        break;
                    case 10:
                        Ais1.SetActive(true);
                        break;
                    case 11:
                        H1.SetActive(true);
                        break;
                    case 12:
                        C2.SetActive(true);
                        break;
                    case 13:
                        Cis2.SetActive(true);
                        break;
                    case 14:
                        D2.SetActive(true);
                        break;
                    case 15:
                        Dis2.SetActive(true);
                        break;
                    case 16:
                        E2.SetActive(true);
                        break;
                    case 17:
                        F2.SetActive(true);
                        break;
                    case 18:
                        Fis2.SetActive(true);
                        break;
                    case 19:
                        G2.SetActive(true);
                        break;
                    case 20:
                        Gis2.SetActive(true);
                        break;
                    case 21:
                        A2.SetActive(true);
                        break;
                    case 22:
                        Ais2.SetActive(true);
                        break;
                    case 23:
                        H2.SetActive(true);
                        break;
                }
                switch (musician.GetComponent<Musician>().ThirdNoteTriad)
                {
                    case 0:
                        C1.SetActive(true);
                        break;
                    case 1:
                        Cis1.SetActive(true);
                        break;
                    case 2:
                        D1.SetActive(true);
                        break;
                    case 3:
                        Dis1.SetActive(true);
                        break;
                    case 4:
                        E1.SetActive(true);
                        break;
                    case 5:
                        F1.SetActive(true);
                        break;
                    case 6:
                        Fis1.SetActive(true);
                        break;
                    case 7:
                        G1.SetActive(true);
                        break;
                    case 8:
                        Gis1.SetActive(true);
                        break;
                    case 9:
                        A1.SetActive(true);
                        break;
                    case 10:
                        Ais1.SetActive(true);
                        break;
                    case 11:
                        H1.SetActive(true);
                        break;
                    case 12:
                        C2.SetActive(true);
                        break;
                    case 13:
                        Cis2.SetActive(true);
                        break;
                    case 14:
                        D2.SetActive(true);
                        break;
                    case 15:
                        Dis2.SetActive(true);
                        break;
                    case 16:
                        E2.SetActive(true);
                        break;
                    case 17:
                        F2.SetActive(true);
                        break;
                    case 18:
                        Fis2.SetActive(true);
                        break;
                    case 19:
                        G2.SetActive(true);
                        break;
                    case 20:
                        Gis2.SetActive(true);
                        break;
                    case 21:
                        A2.SetActive(true);
                        break;
                    case 22:
                        Ais2.SetActive(true);
                        break;
                    case 23:
                        H2.SetActive(true);
                        break;
                }
              
            }
            else
            {
                switch (musician.GetComponent<Musician>().WhichNotes)
                {
                    case 0:
                        C1.SetActive(true);
                        break;
                    case 1:
                        Cis1.SetActive(true);
                        break;
                    case 2:
                        D1.SetActive(true);
                        break;
                    case 3:
                        Dis1.SetActive(true);
                        break;
                    case 4:
                        E1.SetActive(true);
                        break;
                    case 5:
                        F1.SetActive(true);
                        break;
                    case 6:
                        Fis1.SetActive(true);
                        break;
                    case 7:
                        G1.SetActive(true);
                        break;
                    case 8:
                        Gis1.SetActive(true);
                        break;
                    case 9:
                        A1.SetActive(true);
                        break;
                    case 10:
                        Ais1.SetActive(true);
                        break;
                    case 11:
                        H1.SetActive(true);
                        break;
                    case 12:
                        C2.SetActive(true);
                        break;
                    case 13:
                        Cis2.SetActive(true);
                        break;
                    case 14:
                        D2.SetActive(true);
                        break;
                    case 15:
                        Dis2.SetActive(true);
                        break;
                    case 16:
                        E2.SetActive(true);
                        break;
                    case 17:
                        F2.SetActive(true);
                        break;
                    case 18:
                        Fis2.SetActive(true);
                        break;
                    case 19:
                        G2.SetActive(true);
                        break;
                    case 20:
                        Gis2.SetActive(true);
                        break;
                    case 21:
                        A2.SetActive(true);
                        break;
                    case 22:
                        Ais2.SetActive(true);
                        break;
                    case 23:
                        H2.SetActive(true);
                        break;
                }
                switch (musician.GetComponent<Musician>().SecondNoteInterval)
                {
                    case 0:
                        C1.SetActive(true);
                        break;
                    case 1:
                        Cis1.SetActive(true);
                        break;
                    case 2:
                        D1.SetActive(true);
                        break;
                    case 3:
                        Dis1.SetActive(true);
                        break;
                    case 4:
                        E1.SetActive(true);
                        break;
                    case 5:
                        F1.SetActive(true);
                        break;
                    case 6:
                        Fis1.SetActive(true);
                        break;
                    case 7:
                        G1.SetActive(true);
                        break;
                    case 8:
                        Gis1.SetActive(true);
                        break;
                    case 9:
                        A1.SetActive(true);
                        break;
                    case 10:
                        Ais1.SetActive(true);
                        break;
                    case 11:
                        H1.SetActive(true);
                        break;
                    case 12:
                        C2.SetActive(true);
                        break;
                    case 13:
                        Cis2.SetActive(true);
                        break;
                    case 14:
                        D2.SetActive(true);
                        break;
                    case 15:
                        Dis2.SetActive(true);
                        break;
                    case 16:
                        E2.SetActive(true);
                        break;
                    case 17:
                        F2.SetActive(true);
                        break;
                    case 18:
                        Fis2.SetActive(true);
                        break;
                    case 19:
                        G2.SetActive(true);
                        break;
                    case 20:
                        Gis2.SetActive(true);
                        break;
                    case 21:
                        A2.SetActive(true);
                        break;
                    case 22:
                        Ais2.SetActive(true);
                        break;
                    case 23:
                        H2.SetActive(true);
                        break;
                }
               
            }
        }
    }
}
