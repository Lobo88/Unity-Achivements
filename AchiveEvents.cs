using UnityEngine;
using System.Collections;


namespace ObserverPattern
{
    //Events
    public abstract class AchiveEvents
    {
        public abstract bool ShowAchivements();
        public abstract int onedead();
    }


   
    public class Dead3Box2 : AchiveEvents
    {
        public override bool ShowAchivements()
        {
            return true;
        }
        public override int onedead()
        {
            return 1;
        }
    }

}