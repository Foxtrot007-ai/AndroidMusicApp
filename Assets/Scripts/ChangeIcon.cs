using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ChangeIcon : MonoBehaviour
{
    public Text m_MyText;
    public GameObject musician;
    // Start is called before the first frame update
    void Start()
    {
        m_MyText = GetComponent<Text>();
        musician = GameObject.FindGameObjectWithTag("Musician");
    }

    // Update is called once per frame
    void Update()
    {
        if (musician.GetComponent<Musician>().IntervalOrTriad)
        {
            m_MyText.text = "T";
        }
        else m_MyText.text = "I";
    }
}
