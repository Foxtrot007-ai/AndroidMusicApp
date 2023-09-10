using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IconIT : MonoBehaviour
{
    public GameObject Musician;
    public SpriteRenderer spriteRenderer;
    public Sprite BaseSprite;
    public Sprite NewSprite;
    // Start is called before the first frame update
    void Start()
    {
        Musician = GameObject.FindGameObjectWithTag("Musician");
        spriteRenderer = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Musician.GetComponent<Musician>().IntervalOrTriad)
        {
            spriteRenderer.sprite = NewSprite;
        }
        else spriteRenderer.sprite = BaseSprite;
    }
}
