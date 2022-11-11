using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class updateBigDoor : MonoBehaviour
{
    public GameObject r0;
    public GameObject r1;
    private bool rs = true;
    private bool r1s = true;
    //public GameObject r2;
    //public GameObject r3;
    //public GameObject r4;


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
        if (!r0.activeSelf && rs)
        {
            numOfRunes++;
            rs = !rs;
        }
        if (!r1.activeSelf && r1s)
        {
            numOfRunes++;
            r1s = !r1s;
        }

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
        if (numOfRunes == 2)
        {
            Debug.Log("Unlocked");
        }
    }

    void ChangeSprite(int i)
    {
        spriteRenderer.sprite = spriteArray[i];
    }
}
