using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin : MonoBehaviour


{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Destroy(this.gameObject, 2f);
        
    }

    void OnTriggerEnter2D(Collider2D coinPickup)
    {
        //if coin hits player
        if (coinPickup.tag == "Player")
        {
            GameObject.Find("GameManager").GetComponent<GameManager>().EarnScore(1);
            Destroy(this.gameObject);
        }
    }
}
