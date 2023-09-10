using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class ArrowIcon : MonoBehaviour
{
    public GameObject musician;
    public Image image;
    public Sprite up;
    public Sprite down;
    // Start is called before the first frame update
    void Start()
    {
        musician = GameObject.FindGameObjectWithTag("Musician");
        image = GetComponent<Image>();
    }

    // Update is called once per frame
    void Update()
    {
        if (musician.GetComponent<Musician>().UpOrDown)
        {
            image.sprite = down;
        }
        else image.sprite = up;
    }
}
