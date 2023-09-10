using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeyShowcase : MonoBehaviour
{
    public SpriteRenderer spriteRenderer;
    public Sprite ArrowUp;
    public Sprite ArrowDown;

    public GameObject Musician;

    // Start is called before the first frame update
    void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
        Musician = GameObject.FindGameObjectWithTag("Musician");
    }

    // Update is called once per frame
    void Update()
    {
        if (Musician.GetComponent<Musician>().UpOrDown)
        {
            spriteRenderer.sprite = ArrowDown;
        }
        else spriteRenderer.sprite = ArrowUp;
    }
}
