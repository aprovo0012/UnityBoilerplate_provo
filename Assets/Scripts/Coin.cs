using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin : MonoBehaviour
{
    private Platform_Manager _manager;
    void Start()
    {
        _manager = FindObjectOfType<Platform_Manager>();
    }

    // Update is called once per frame
    void OnTriggerEnter(Collider other)
    {
        _manager.CollectCoin();
        Destroy(this.gameObject);
    }
}
