using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Platform_Manager : MonoBehaviour
{
    int coins = 0;
    public void CollectCoin()
    {
        coins++;
    }

    public int GetCoin()
    {
        return coins;
    }
}
