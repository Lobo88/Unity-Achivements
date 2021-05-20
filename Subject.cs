using UnityEngine;
using System.Collections;
using System.Collections.Generic;

namespace ObserverPattern
{
    //Wywołuje metodę powiadamiania
    public class Subject
    {
        //Lista obserwatorów, którzy czekają, aż coś się wydarzy
        List<Observer> observers = new List<Observer>();

        //Wysyłaj powiadomienia, jeśli coś się stało
        public void Notify()
        {
            
            for (int i = 0; i < observers.Count; i++)
            {
                // Powiadom wszystkich obserwatorów, nawet jeśli niektórzy mogą nie być zainteresowani tym, co się stało
                // Każdy obserwator powinien sprawdzić, czy jest zainteresowany tym wydarzeniem
                observers[i].OnNotify();
                
            }
        }

        //Dodanie obserwatora do listy
        public void AddObserver(Observer observer)
        {
            observers.Add(observer);
        }

        //Wyrzucenie osberwatora z listy
        public void RemoveObserver(Observer observer)
        {
            observers.Remove(observer);
        }
    }
}