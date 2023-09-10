using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class IntervalIcon : MonoBehaviour
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

        switch(musician.GetComponent<Musician>().IntervalOption)
        {
            case 0:
                m_MyText.text = "1";
                m_MyText.color = orange;
                break;
            case 1:
                m_MyText.text = "2>";
                m_MyText.color = Color.blue;
                break;
            case 2:
                m_MyText.text = "2<";
                m_MyText.color = Color.red;
                break;
            case 3:
                m_MyText.text = "3>";
                m_MyText.color = Color.blue;
                break;
            case 4:
                m_MyText.text = "3<";
                m_MyText.color = Color.red;
                break;
            case 5:
                m_MyText.text = "4";
                m_MyText.color = orange;
                break;
            case 6:
                m_MyText.text = "4<";
                m_MyText.color = Color.black;
                break;
            case 7:
                m_MyText.text = "5";
                m_MyText.color = orange;
                break;
            case 8:
                m_MyText.text = "6>";
                m_MyText.color = Color.blue;
                break;
            case 9:
                m_MyText.text = "6<";
                m_MyText.color = Color.red;
                break;
            case 10:
                m_MyText.text = "7>";
                m_MyText.color = Color.blue;
                break;
            case 11:
                m_MyText.text = "7<";
                m_MyText.color = Color.red;
                break;
            case 12:
                m_MyText.text = "8";
                m_MyText.color = orange;
                break;
        }
    }
}
