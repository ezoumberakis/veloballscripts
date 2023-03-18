    using System;
    using UnityEngine;
    using UnityEngine.UI;
     
     
    public class TimedAdUsage : MonoBehaviour
    {
        public Text Time;
        private float msToWait = 21600000;
        public Button AdButton;
        private ulong lastTimeClicked;
     
        private void Start()
        {
     
            lastTimeClicked = ulong.Parse(PlayerPrefs.GetString("LastTimeClicked"));
     
            if (!Ready())
                AdButton.interactable = false;
        }
     
        private void Update()
        {
            if (!AdButton.IsInteractable())
            {
                if (Ready())
                {
                    AdButton.interactable = true;
                    Time.text = "Ad Is Ready!";
                    return;
                }
                ulong diff = ((ulong)DateTime.Now.Ticks - lastTimeClicked);
                ulong m = diff / TimeSpan.TicksPerMillisecond;
                float secondsLeft = (float)(msToWait - m) / 1000.0f;
     
                string r = "";
                //HOURS
                r += ((int)secondsLeft / 3600).ToString() + "h";
                secondsLeft -= ((int)secondsLeft / 3600) * 3600;
                //MINUTES
                r += ((int)secondsLeft / 60).ToString("00") + "m ";
                //SECONDS
                r += (secondsLeft % 60).ToString("00") + "s";
                Time.text = r;
     
     
            }
        }
     
     
        public void Click()
        {
                lastTimeClicked = (ulong)DateTime.Now.Ticks;
                PlayerPrefs.SetString("LastTimeClicked", lastTimeClicked.ToString());
                AdButton.interactable = false;
     
     
        }
        private bool Ready()
        {
            ulong diff = ((ulong)DateTime.Now.Ticks - lastTimeClicked);
            ulong m = diff / TimeSpan.TicksPerMillisecond;
     
            float secondsLeft = (float)(msToWait - m) / 1000.0f;
     
            if (secondsLeft < 0)
            {
                //DO SOMETHING WHEN TIMER IS FINISHED
                return true;
            }
     
            return false;
        }
    }
      
     
          
                        
