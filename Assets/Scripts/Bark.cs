using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace Assets.Scripts
{
    class Bark
    {
        private String text;
        private InterObj start;
        private GameObject stop;
        private static float time;
        private bool active = false;
        private bool done = false;
        /*
        public Bark(String text, InterObj start)
        {
            this.text = text;
            this.start = start;
            this.stop = null;

        }*/
        public Bark(String text, InterObj start, GameObject stop)
        {
            this.text = text;
            this.start = start;
            this.stop = stop;

        }
        public String getText()
        {
            return text;
        }
        public void setT(float t)
        {
            time = t;
        }
        public float getT()
        {
            return time;
        }
        public bool getDone()
        {
            return done;
        }
      
        public void setActive(bool a)
        {
            active = a;
        }
        public bool getActive()
        {
            return active;
        }

        
        public bool getStopStatus()
        {
            //Debug.Log(this.stop+getText());
            if (this.stop != null)
            {
                //Debug.Log("Stop is " + this.stop.activeSelf);
                done = this.stop.activeSelf;
                return this.stop.activeSelf;
            }
            return false;
        }

        public bool StartClicked()
        {
            return start.isClicked();
        }
    }
}
