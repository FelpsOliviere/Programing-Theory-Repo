using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BadGuyTryingToChangeAnimalNames : MonoBehaviour
{
    public List<string> animalNames;

    // Start is called before the first frame update
    void Start()
    {
        ABadGuyDoingBadStuff();
    }

    void ABadGuyDoingBadStuff()
    {
        animalNames.Add("Fish");
        animalNames.Add("Bird");
        animalNames.Add("Dog");

        //GameObject.Find("Animal_Moose_01").GetComponent<Moose>().animalname = animalNames[2];
        //GameObject.Find("Animal_Fox_01").GetComponent<Fox>().animalname = animalNames[1];
        //GameObject.Find("Animal_Doe_01").GetComponent<Doe>().animalname = animalNames[0];
    }
}
