using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TraidIcon : MonoBehaviour
{
    public Text m_MyText;
    public GameObject musician;
    public Color orange = new Color(249, 105, 14, 1);
    // Start is called before the first frame update
    void Start()
    {
        m_MyText = GetComponent<Text>();
        musician = GameObject.FindGameObjectWithTag("Musician");
    }

    // Update is called once per frame
    void Update()
    {
        switch (musician.GetComponent<Musician>().TriadOption)
        {
            case 1:
                m_MyText.text = "+";
                m_MyText.color = Color.red;
                break;
            case 2:
                m_MyText.text = "-";
                m_MyText.color = Color.blue;
                break;
            case 3:
                m_MyText.text = ">";
                m_MyText.color = Color.magenta;
                break;
            case 4:
                m_MyText.text = "<";
                m_MyText.color = orange;
                break;
        }
    }
}

