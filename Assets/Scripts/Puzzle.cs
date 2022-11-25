using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace Assets.Scripts
{
    class Puzzle
    {
        private int[] answers;
        private bool cd = false;
        private int which;
        private string whichdex = "abc";
        public Puzzle (int[] answers, int which)
        {
            this.answers = answers;
            this.which = which;
        }
        public int[] getAnswers()
        {
            return answers;
        }
        public bool getCd()
        {
            return cd;
        }
        public int getWhich()
        {
            return which;
        }
        public void checkBoard(GameObject temp, GameObject board, GameObject rune)
        {
            int c = 0;
            //Debug.Log(hit.collider.gameObject);
            //Debug.Log(temp.transform.eulerAngles.z);
            temp.transform.Rotate(0, 0, 90f);
            Debug.Log("ROtate");
            for (int num = 0; num < 16; num++)
            {
                //Debug.Log(num+":");
                //Debug.Log(board.GetComponentsInChildren<SpriteRenderer>()[num + 1].gameObject.transform.eulerAngles.z + "v"+ answers[num]);
                //Debug.Log("a:" + answers[num]);
                if (MathF.Abs(board.GetComponentsInChildren<SpriteRenderer>()[num + 1].gameObject.transform.eulerAngles.z - answers[num]) < 49)
                {
                    c++;
                }
                //Debug.Log(c);

            }
            //Debug.Log(c);
            if (c == 16)
            {
                //Debug.Log("Closed" + which);
                cd = true;
                String ne = PlayerPrefs.GetString("PuzzleStats").Replace(whichdex[which], '1'); //Basically PuzzleStats default is abc so it looks at the abc string to see which letter it needs based on which and turns it to one which means its done
                PlayerPrefs.SetString("PuzzleStats", ne); 
                board.SetActive(false);
                rune.SetActive(true);
                rune.GetComponent<SpriteRenderer>().sortingOrder = 3;
                //rune.layer = 3;
            }

        }
    }
}
