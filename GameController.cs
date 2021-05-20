using UnityEngine;
using System.Collections;
using UnityEngine.UI;

namespace ObserverPattern
{
    public class GameController : MonoBehaviour
    {
        public GameObject sphereObj;

        public GameObject box1Obj;
        public GameObject box2Obj;
        public GameObject box3Obj;
        
        public GameObject showAchievements;
        public int dead =0;
        private bool achive=false;
        //Wyśle powiadomienia, że coś się stało każdemu, kto jest zainteresowany
        Subject subject = new Subject();
        public void openAchive()
        {
            
            //showAchievements.isActiveAndEnabled(true);

        }

        void Start()
        {
          
            //Twórz pola, które mogą obserwować wydarzenia i daj im wydarzenie do wykonania
           // Box box1 = new Box(box1Obj, new JumpLittle());
          //  Box box2 = new Box(box2Obj, new JumpMedium());
          //  Box box3 = new Box(box3Obj, new JumpHigh());
            Box boxTest = new Box(showAchievements, new Dead3Box2(), dead);
            //Dodaj pola do listy obiektów czekających, aż coś się wydarzy
           // subject.AddObserver(box1);
           // subject.AddObserver(box2);
          //  subject.AddObserver(box3);
            subject.AddObserver(boxTest);
        }


        void Update()
        {
           // Debug.Log((sphereObj.transform.position).magnitude);
            //Pudełka powinny podskoczyć, jeśli kula jest blisko origo
            if ((sphereObj.transform.position).magnitude < 2f)
            {
                subject.Notify( );
            }
            if (box2Obj==null )
            {
                dead += 1;
              subject.Notify();
               box2Obj = gameObject;
            }
            if (box1Obj == null )
            {
                dead += 1; box1Obj = gameObject;
              subject.Notify();
            }
            if (box3Obj == null )
            {
                dead += 1; box3Obj =gameObject;
                subject.Notify();
            }


        }
     
       
    }
}