using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// INHERITANCE
public class Chicken : Animal
{
    public bool hasPeak;
    public int wings;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    //POLYMORPHISM
    public override string Talk()
    {
        return "Pio";
    }
}
