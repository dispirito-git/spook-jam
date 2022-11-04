using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class updateBigDoor : MonoBehaviour
{
    //to represent num of runes we have
    [SerializeField] private int numOfRunes;

    [SerializeField] public Sprite[] spriteArray;
    public SpriteRenderer spriteRenderer;
    
    // Start is called before the first frame update
    void Start()
    {
        numOfRunes = 0;
        spriteRenderer = gameObject.GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        switch (numOfRunes)
        {
            case 0:
                ChangeSprite(0);
                break;
            case 1:
                ChangeSprite(1);
                break;
            case 2:
                ChangeSprite(2);
                break;
            case 3:
                ChangeSprite(3);
                break;
            case 4:
                ChangeSprite(4);
                break;
            default:
                break;
        }
    }

    void ChangeSprite(int i)
    {
        spriteRenderer.sprite = spriteArray[i];
    }
}
