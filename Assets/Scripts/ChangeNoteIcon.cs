using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ChangeNoteIcon : MonoBehaviour
{
    public Text m_MyText;
    public GameObject musician;
    public int Note;
    // Start is called before the first frame update
    void Start()
    {
        m_MyText = GetComponent<Text>();
        musician = GameObject.FindGameObjectWithTag("Musician");
    }


    // Update is called once per frame
    void Update()
    {
        if (musician.GetComponent<Musician>().WhichNotes > 11)
        {
            Note = musician.GetComponent<Musician>().WhichNotes - 12;
        }
        else Note = musician.GetComponent<Musician>().WhichNotes;

        switch (Note)
        {
            case 0:
                m_MyText.text = "C";
                break;
            case 1:
                m_MyText.text = "C#";
                break;
            case 2:
                m_MyText.text = "D";
                break;
            case 3:
                m_MyText.text = "D#";
                break;
            case 4:
                m_MyText.text = "E";
                break;
            case 5:
                m_MyText.text = "F";
                break;
            case 6:
                m_MyText.text = "F#";
                break;
            case 7:
                m_MyText.text = "G";
                break;
            case 8:
                m_MyText.text = "G#";
                break;
            case 9:
                m_MyText.text = "A";
                break;
            case 10:
                m_MyText.text = "A#";
                break;
            case 11:
                m_MyText.text = "H";
                break;

        }

    }
}
