using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
 



public class Musician : MonoBehaviour
{
    public bool IntervalOrTriad = false; // false -> Interwal, true-> triad;
    public int WhichNotes = 0; // C - > 0 , Cis -> 1, D -> 2....
    public bool Calculate = false; // false -> do nothing , true ->starting.
    public int IntervalOption = 0; 
    public int TriadOption = 1; // 1 -> + , 2 -> o , 3 -> '<' , 4 -> '>'.
    public bool UpOrDown = false; //false -> Up , true -> Down.
    public int SecondNoteInterval;
    public int SecondNoteTriad;
    public int ThirdNoteTriad;
    public bool ChangeIntervalTriad;

    public bool canshow = false;
    public bool canmusic = false;

    public GameObject Interval;
    public GameObject Triad;

    public void IntervalTriadChange()
    {
        if (IntervalOrTriad)
        {
            IntervalOrTriad = false;
        }
        else IntervalOrTriad = true;
    }
    public void Calcul()
    {
        if(!canmusic)
        {
        Calculate = true;
        }
        
    }    
    public void NoteChange()
    {
        WhichNotes++;
        if(WhichNotes>11)
        {
            WhichNotes -= 12;
        }
    }

    public void IntervalChange()
    {
        IntervalOption++;
        if(IntervalOption>12)
        {
            IntervalOption -= 13;
        }
    }
    public void TriadChange()
    {
        TriadOption++;
        if(TriadOption>4)
        {
            TriadOption = 1;
        }
    }
    public void ArrowSwap()
    {
        if (UpOrDown)
        {
            UpOrDown = false;
        }
        else UpOrDown = true;
    }
    void Start()
    {
        
        
    }

    // Update is called once per frame
    void Update()
    {
        canshow = false;
        if(IntervalOrTriad)
        {
            Interval.SetActive(false);
            Triad.SetActive(true);
        }
        else
        {
            Interval.SetActive(true);
            Triad.SetActive(false);
        }

        if(ChangeIntervalTriad)
        {
            if (IntervalOrTriad)
            {
                IntervalOrTriad = false;
            }
            else IntervalOrTriad = true;
            ChangeIntervalTriad = false;
        }
       
        if(Calculate&&!canmusic)
        {
            if(WhichNotes>11)
            {
                WhichNotes -= 12;
            }
               
            if(UpOrDown)
            {
                //Which octave

                WhichNotes+= 12;
            }

            if(!IntervalOrTriad)
            {
                //Interval Option
                if(UpOrDown)
                {
                    SecondNoteInterval = WhichNotes - IntervalOption;
                }
                else  SecondNoteInterval = WhichNotes + IntervalOption;
              
                Calculate = false;
            }
            else
            {
                //Triad Option
                if (UpOrDown)
                {
                    switch (TriadOption)
                    {
                        case 1:
                            SecondNoteTriad = WhichNotes -4;
                            ThirdNoteTriad = SecondNoteTriad - 3;
                            break;
                        case 2:
                            SecondNoteTriad = WhichNotes - 3;
                            ThirdNoteTriad = SecondNoteTriad - 4;
                            break;
                        case 3:
                            SecondNoteTriad = WhichNotes - 3;
                            ThirdNoteTriad = SecondNoteTriad - 3;
                            break;
                        case 4:
                            SecondNoteTriad = WhichNotes - 4;
                            ThirdNoteTriad = SecondNoteTriad -4;
                            break;
                    }
                }
                else
                {
                    switch (TriadOption)
                    {
                        case 1:
                            SecondNoteTriad = WhichNotes + 4;
                            ThirdNoteTriad = SecondNoteTriad + 3;
                            break;
                        case 2:
                            SecondNoteTriad = WhichNotes + 3;
                            ThirdNoteTriad = SecondNoteTriad + 4;
                            break;
                        case 3:
                            SecondNoteTriad = WhichNotes + 3;
                            ThirdNoteTriad = SecondNoteTriad + 3;
                            break;
                        case 4:
                            SecondNoteTriad = WhichNotes + 4;
                            ThirdNoteTriad = SecondNoteTriad + 4;
                            break;
                    }
                }
                Calculate= false;
            }

            canshow = true;
            canmusic = true;
        }
    }
}
