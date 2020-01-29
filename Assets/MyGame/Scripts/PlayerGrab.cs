using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerGrab : MonoBehaviour { 

    public GameObject plasticCup;
    public GameObject inventar;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        plasticCup.transform.SetParent(inventar.transform);
        plasticCup.transform.position = inventar.transform.position;
    }
}
