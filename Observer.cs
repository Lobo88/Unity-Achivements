using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using System;

namespace ObserverPattern
{
    [RequireComponent(typeof(GameController))]
    //Chce wiedzieć, kiedy inny obiekt robi coś interesującego
    public abstract class Observer: MonoBehaviour
    {
        public abstract void OnNotify();
    }

    public class Box : Observer
    {
        //Obiekt gry pudełkowej, który coś zrobi
        GameObject boxObj;
        GameObject image;
        //  Co się stanie, gdy to pudełko otrzyma wydarzenie
        //BoxEvents boxEvent;
        AchiveEvents achiveEvent;
      

        public float countDead = 0;
        private void Start()
        {
            
        }
       // public Box(GameObject boxObj, BoxEvents boxEvent)
       // {
           // this.boxObj = boxObj;
           // this.boxEvent = boxEvent;
      //  }
        public Box(GameObject imag, AchiveEvents boxEvent2, int count)
        {
            this.image = imag;
            this.achiveEvent = boxEvent2;
            this.countDead = count;
        }
        //Co zrobi pudełko, jeśli wydarzenie na to pasuje (zawsze będzie pasować, ale prawdopodobnie zmienisz to samodzielnie)
        public override void OnNotify()
        {
            // sumDead(boxEvent.GetJumpForce());
           
            //showAchivemen(achiveEvent.ShowAchivements());
            sumDead(achiveEvent.onedead());

        }

        public void showAchivemen(bool value2)
        {
            Debug.Log(value2);
            image.gameObject.SetActive(value2);
        }

        public void sumDead(float value)
        {
            Debug.Log("value="+value);
            Debug.Log("suma1 działa");
            countDead += value;
            if (countDead == 2)
            {
                showAchivemen(achiveEvent.ShowAchivements());
                Debug.Log("suma2 działa");
            }
        }
        //W tym przypadku pudełko zawsze będzie podskakiwać
        void Jump(float jumpForce)
        {
            //Jeśli pudełko jest blisko ziemi
            if (boxObj.transform.position.y < 0.55f)
            {
                boxObj.GetComponent<Rigidbody>().AddForce(Vector3.up * jumpForce);
            }
        }
    }
}