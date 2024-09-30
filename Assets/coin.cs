using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class coin : MonoBehaviour
{
    // reference to the coin prefab
    public GameObject CoinPrefab;

    public Vector2 coinOffsett = new Vector2(0, 1);

    void Start()
    {
        SpawnCoin();
    }

    // Update is called once per frame
    void SpawnCoin()
    {
        Vector3 coinPosition = transform.position + (Vector3)coinOffsett;

        Instantiate(CoinPrefab, coinPosition, Quaternion.identity);
    }
}
