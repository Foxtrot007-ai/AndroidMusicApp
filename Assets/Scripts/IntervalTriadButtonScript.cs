using System.Collections;
using System.Collections.Generic;
using System.Security.Permissions;
using UnityEngine;

public class IntervalTriadButtonScript : MonoBehaviour
{
    public GameObject Musician;
    public BoxCollider2D jd;
    public SpriteRenderer spriteRenderer;
    public Sprite ClickedSprite;
    public Sprite BaseSprite;
    public bool Clicked;
    public bool touched;

    public void Change()
    {
        touched = true;
    }
    // Start is called before the first frame update
    void Start()
    {
        Musician = GameObject.FindWithTag("Musician");
        spriteRenderer = GetComponent<SpriteRenderer>();
        jd = GetComponent<BoxCollider2D>();
    }

    // Update is called once per frame
    void Update()
    {
        
        if (touched)
        {
            spriteRenderer.sprite = ClickedSprite;
            Clicked = true;
            touched = false;
        }
        else
        {
            spriteRenderer.sprite = BaseSprite;
        }
  
    
        if (Clicked)
        {
            Musician.GetComponent<Musician>().ChangeIntervalTriad = true;
            Clicked = false;
        }
    }
}
