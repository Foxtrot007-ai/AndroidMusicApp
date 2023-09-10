using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DJscript : MonoBehaviour
{
    public AudioSource m_MyAudioSource;
    public GameObject musician;
    public AudioClip C1;
    public AudioClip Cis1;
    public AudioClip D1;
    public AudioClip Dis1;
    public AudioClip E1;
    public AudioClip F1;
    public AudioClip Fis1;
    public AudioClip G1;
    public AudioClip Gis1;
    public AudioClip A1;
    public AudioClip Ais1;
    public AudioClip H1;
    public AudioClip C2;
    public AudioClip Cis2;
    public AudioClip D2;
    public AudioClip Dis2;
    public AudioClip E2;
    public AudioClip F2;
    public AudioClip Fis2;
    public AudioClip G2;
    public AudioClip Gis2;
    public AudioClip A2;
    public AudioClip Ais2;
    public AudioClip H2;

    public bool what;
    public bool canplay=true;
    public bool Triad1 = false;
    public bool Triad2 = false;
    public bool Triad3 = false;
    public bool Interval1 = false;
    public bool Interval12 = false;
    // Start is called before the first frame update
    void Start()
    {
        musician = GameObject.FindGameObjectWithTag("Musician");
        m_MyAudioSource = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        if(musician.GetComponent<Musician>().Calculate)
        {
            Triad1 = true;
            Triad2 = false;
            Triad3 = false;
            Interval1 = true;
            Interval12 = false;
            what = musician.GetComponent<Musician>().IntervalOrTriad;
        }
        if(m_MyAudioSource.isPlaying==false)
        {
            canplay = true;
        }
        if(musician.GetComponent<Musician>().canmusic)
        {
            if (what)
            {
                if (canplay)
                {
                    if (Triad1)
                    {
                        switch (musician.GetComponent<Musician>().WhichNotes)
                        {
                            case 0:
                                m_MyAudioSource.clip = C1;
                                break;
                            case 1:
                                m_MyAudioSource.clip = Cis1;
                                break;
                            case 2:
                                m_MyAudioSource.clip = D1;
                                break;
                            case 3:
                                m_MyAudioSource.clip = Dis1;
                                break;
                            case 4:
                                m_MyAudioSource.clip = E1;
                                break;
                            case 5:
                                m_MyAudioSource.clip = F1;
                                break;
                            case 6:
                                m_MyAudioSource.clip = Fis1;
                                break;
                            case 7:
                                m_MyAudioSource.clip = G1;
                                break;
                            case 8:
                                m_MyAudioSource.clip = Gis1;
                                break;
                            case 9:
                                m_MyAudioSource.clip = A1;
                                break;
                            case 10:
                                m_MyAudioSource.clip = Ais1;
                                break;
                            case 11:
                                m_MyAudioSource.clip = H1;
                                break;
                            case 12:
                                m_MyAudioSource.clip = C2;
                                break;
                            case 13:
                                m_MyAudioSource.clip = Cis2;
                                break;
                            case 14:
                                m_MyAudioSource.clip = D2;
                                break;
                            case 15:
                                m_MyAudioSource.clip = Dis2;
                                break;
                            case 16:
                                m_MyAudioSource.clip = E2;
                                break;
                            case 17:
                                m_MyAudioSource.clip = F2;
                                break;
                            case 18:
                                m_MyAudioSource.clip = Fis2;
                                break;
                            case 19:
                                m_MyAudioSource.clip = G2;
                                break;
                            case 20:
                                m_MyAudioSource.clip = Gis2;
                                break;
                            case 21:
                                m_MyAudioSource.clip = A2;
                                break;
                            case 22:
                                m_MyAudioSource.clip = Ais2;
                                break;
                            case 23:
                                m_MyAudioSource.clip = H2;
                                break;
                        }
                        m_MyAudioSource.Play();
                        canplay = false;
                        Triad1 = false;
                        Triad2 = true;
                    }
                    else if (Triad2)
                    {
                        switch (musician.GetComponent<Musician>().SecondNoteTriad)
                        {
                            case 0:
                                m_MyAudioSource.clip = C1;
                                break;
                            case 1:
                                m_MyAudioSource.clip = Cis1;
                                break;
                            case 2:
                                m_MyAudioSource.clip = D1;
                                break;
                            case 3:
                                m_MyAudioSource.clip = Dis1;
                                break;
                            case 4:
                                m_MyAudioSource.clip = E1;
                                break;
                            case 5:
                                m_MyAudioSource.clip = F1;
                                break;
                            case 6:
                                m_MyAudioSource.clip = Fis1;
                                break;
                            case 7:
                                m_MyAudioSource.clip = G1;
                                break;
                            case 8:
                                m_MyAudioSource.clip = Gis1;
                                break;
                            case 9:
                                m_MyAudioSource.clip = A1;
                                break;
                            case 10:
                                m_MyAudioSource.clip = Ais1;
                                break;
                            case 11:
                                m_MyAudioSource.clip = H1;
                                break;
                            case 12:
                                m_MyAudioSource.clip = C2;
                                break;
                            case 13:
                                m_MyAudioSource.clip = Cis2;
                                break;
                            case 14:
                                m_MyAudioSource.clip = D2;
                                break;
                            case 15:
                                m_MyAudioSource.clip = Dis2;
                                break;
                            case 16:
                                m_MyAudioSource.clip = E2;
                                break;
                            case 17:
                                m_MyAudioSource.clip = F2;
                                break;
                            case 18:
                                m_MyAudioSource.clip = Fis2;
                                break;
                            case 19:
                                m_MyAudioSource.clip = G2;
                                break;
                            case 20:
                                m_MyAudioSource.clip = Gis2;
                                break;
                            case 21:
                                m_MyAudioSource.clip = A2;
                                break;
                            case 22:
                                m_MyAudioSource.clip = Ais2;
                                break;
                            case 23:
                                m_MyAudioSource.clip = H2;
                                break;
                        }
                        m_MyAudioSource.Play();
                        canplay = false;
                        Triad2 = false;
                        Triad3 = true;
                    }
                    else if (Triad3)
                    {
                        switch (musician.GetComponent<Musician>().ThirdNoteTriad)
                        {
                            case 0:
                                m_MyAudioSource.clip = C1;
                                break;
                            case 1:
                                m_MyAudioSource.clip = Cis1;
                                break;
                            case 2:
                                m_MyAudioSource.clip = D1;
                                break;
                            case 3:
                                m_MyAudioSource.clip = Dis1;
                                break;
                            case 4:
                                m_MyAudioSource.clip = E1;
                                break;
                            case 5:
                                m_MyAudioSource.clip = F1;
                                break;
                            case 6:
                                m_MyAudioSource.clip = Fis1;
                                break;
                            case 7:
                                m_MyAudioSource.clip = G1;
                                break;
                            case 8:
                                m_MyAudioSource.clip = Gis1;
                                break;
                            case 9:
                                m_MyAudioSource.clip = A1;
                                break;
                            case 10:
                                m_MyAudioSource.clip = Ais1;
                                break;
                            case 11:
                                m_MyAudioSource.clip = H1;
                                break;
                            case 12:
                                m_MyAudioSource.clip = C2;
                                break;
                            case 13:
                                m_MyAudioSource.clip = Cis2;
                                break;
                            case 14:
                                m_MyAudioSource.clip = D2;
                                break;
                            case 15:
                                m_MyAudioSource.clip = Dis2;
                                break;
                            case 16:
                                m_MyAudioSource.clip = E2;
                                break;
                            case 17:
                                m_MyAudioSource.clip = F2;
                                break;
                            case 18:
                                m_MyAudioSource.clip = Fis2;
                                break;
                            case 19:
                                m_MyAudioSource.clip = G2;
                                break;
                            case 20:
                                m_MyAudioSource.clip = Gis2;
                                break;
                            case 21:
                                m_MyAudioSource.clip = A2;
                                break;
                            case 22:
                                m_MyAudioSource.clip = Ais2;
                                break;
                            case 23:
                                m_MyAudioSource.clip = H2;
                                break;
                        }
                        m_MyAudioSource.Play();
                        canplay = false;
                        Triad3 = false;

                    }
                    else
                    {
                        musician.GetComponent<Musician>().canmusic = false;
                    }
                }
            }
            else
            {
                if (canplay)
                {


                    if (Interval1)
                    {


                        switch (musician.GetComponent<Musician>().WhichNotes)
                        {
                            case 0:
                                m_MyAudioSource.clip = C1;
                                break;
                            case 1:
                                m_MyAudioSource.clip = Cis1;
                                break;
                            case 2:
                                m_MyAudioSource.clip = D1;
                                break;
                            case 3:
                                m_MyAudioSource.clip = Dis1;
                                break;
                            case 4:
                                m_MyAudioSource.clip = E1;
                                break;
                            case 5:
                                m_MyAudioSource.clip = F1;
                                break;
                            case 6:
                                m_MyAudioSource.clip = Fis1;
                                break;
                            case 7:
                                m_MyAudioSource.clip = G1;
                                break;
                            case 8:
                                m_MyAudioSource.clip = Gis1;
                                break;
                            case 9:
                                m_MyAudioSource.clip = A1;
                                break;
                            case 10:
                                m_MyAudioSource.clip = Ais1;
                                break;
                            case 11:
                                m_MyAudioSource.clip = H1;
                                break;
                            case 12:
                                m_MyAudioSource.clip = C2;
                                break;
                            case 13:
                                m_MyAudioSource.clip = Cis2;
                                break;
                            case 14:
                                m_MyAudioSource.clip = D2;
                                break;
                            case 15:
                                m_MyAudioSource.clip = Dis2;
                                break;
                            case 16:
                                m_MyAudioSource.clip = E2;
                                break;
                            case 17:
                                m_MyAudioSource.clip = F2;
                                break;
                            case 18:
                                m_MyAudioSource.clip = Fis2;
                                break;
                            case 19:
                                m_MyAudioSource.clip = G2;
                                break;
                            case 20:
                                m_MyAudioSource.clip = Gis2;
                                break;
                            case 21:
                                m_MyAudioSource.clip = A2;
                                break;
                            case 22:
                                m_MyAudioSource.clip = Ais2;
                                break;
                            case 23:
                                m_MyAudioSource.clip = H2;
                                break;
                        }
                        m_MyAudioSource.Play();
                        Interval1 = false;
                        canplay = false;
                        Interval12 = true;
                    }
                    else if (Interval12)
                    {


                        switch (musician.GetComponent<Musician>().SecondNoteInterval)
                        {
                            case 0:
                                m_MyAudioSource.clip = C1;
                                break;
                            case 1:
                                m_MyAudioSource.clip = Cis1;
                                break;
                            case 2:
                                m_MyAudioSource.clip = D1;
                                break;
                            case 3:
                                m_MyAudioSource.clip = Dis1;
                                break;
                            case 4:
                                m_MyAudioSource.clip = E1;
                                break;
                            case 5:
                                m_MyAudioSource.clip = F1;
                                break;
                            case 6:
                                m_MyAudioSource.clip = Fis1;
                                break;
                            case 7:
                                m_MyAudioSource.clip = G1;
                                break;
                            case 8:
                                m_MyAudioSource.clip = Gis1;
                                break;
                            case 9:
                                m_MyAudioSource.clip = A1;
                                break;
                            case 10:
                                m_MyAudioSource.clip = Ais1;
                                break;
                            case 11:
                                m_MyAudioSource.clip = H1;
                                break;
                            case 12:
                                m_MyAudioSource.clip = C2;
                                break;
                            case 13:
                                m_MyAudioSource.clip = Cis2;
                                break;
                            case 14:
                                m_MyAudioSource.clip = D2;
                                break;
                            case 15:
                                m_MyAudioSource.clip = Dis2;
                                break;
                            case 16:
                                m_MyAudioSource.clip = E2;
                                break;
                            case 17:
                                m_MyAudioSource.clip = F2;
                                break;
                            case 18:
                                m_MyAudioSource.clip = Fis2;
                                break;
                            case 19:
                                m_MyAudioSource.clip = G2;
                                break;
                            case 20:
                                m_MyAudioSource.clip = Gis2;
                                break;
                            case 21:
                                m_MyAudioSource.clip = A2;
                                break;
                            case 22:
                                m_MyAudioSource.clip = Ais2;
                                break;
                            case 23:
                                m_MyAudioSource.clip = H2;
                                break;
                        }
                        m_MyAudioSource.Play();
                        canplay = false;
                        Interval12 = false;
                    }
                    else
                    {
                        musician.GetComponent<Musician>().canmusic = false;
                    }
                    
                }
            }
        }
    }
}
