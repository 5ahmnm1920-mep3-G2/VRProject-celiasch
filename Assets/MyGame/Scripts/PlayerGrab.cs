using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerGrab : MonoBehaviour { 

    public GameObject plasticCup;
    public GameObject inventar;
    public GameObject tree1;

    bool inHands = false;
    Vector3 binPos;


    // Start is called before the first frame update
    void Start()
    {
        binPos = new Vector3(-1.26f, 0.1f, 0.02f);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            if (!inHands)
            {
                plasticCup.transform.SetParent(inventar.transform);
                plasticCup.transform.localPosition = new Vector3(2.14f, 0.186f, 1.93f);
                inHands = true;           
            } else if (inHands)
            {
                this.GetComponent<PlayerGrab>().enabled = false;
                plasticCup.transform.SetParent(null);
                plasticCup.transform.localPosition = binPos;
                tree1.transform.localPosition = new Vector3(2.14f, 0.186f, 1.93f);
                inHands = false;
            }
        }

    
    }
}

