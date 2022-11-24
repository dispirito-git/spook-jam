using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class updateBigDoor : MonoBehaviour
{
    public GameObject r0;
    public GameObject r1;
    private bool rs= true;
    private bool r1s = true;
    private bool r2s = true;
    private bool r3s = true;
    public GameObject r2;
    public GameObject r3;
    //public GameObject r4;


    //to represent num of runes we have
    [SerializeField] private int numOfRunes;

    [SerializeField] public Sprite[] spriteArray;
    public SpriteRenderer spriteRenderer;
    
    // Start is called before the first frame update
    void Start()
    {
        numOfRunes = PlayerPrefs.GetInt("numRunes");
        spriteRenderer = gameObject.GetComponent<SpriteRenderer>();
        spriteRenderer.sprite = spriteArray[numOfRunes];

    }

    // Update is called once per frame
    void Update()
    {
        /*
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
        if (!r2.activeSelf && r2s)
        {
            numOfRunes++;
            r2s = !r2s;
        }
        if (!r3.activeSelf && r3s)
        {
            numOfRunes++;
            r3s = !r3s;
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
                break;s
            case 3:
                ChangeSprite(3);
                break;
            case 4:
                ChangeSprite(4);
                break;
            default:
                break;
        }*/
        if (numOfRunes == 4)
        {
            //Debug.Log("Unlocked");
            transform.GetComponent<ClickBark>().enabled = false;
        }
    }

    public void ChangeSprite()
    {
        numOfRunes++;

        PlayerPrefs.SetInt("numRunes", numOfRunes);
        spriteRenderer.sprite = spriteArray[numOfRunes];
    }
}
