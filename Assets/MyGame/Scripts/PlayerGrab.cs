using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerGrab : MonoBehaviour { 

    public GameObject plasticCup;
    public GameObject inventar;

    bool inHands = false;
    Vector3 cupPos;


    // Start is called before the first frame update
    void Start()
    {
        cupPos = plasticCup.transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            if (!inHands)
            {
                plasticCup.transform.SetParent(inventar.transform);
                plasticCup.transform.localPosition = new Vector3(-1.26f, 0.04f, 0.02f);
                inHands = true;           
            } else if (inHands)
            {
                this.GetComponent<PlayerGrab>().enabled = false;
                plasticCup.transform.SetParent(null);
                plasticCup.transform.localPosition = cupPos;
                inHands = false;
            }
        }

    }
}

