using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnController : MonoBehaviour
{
    public GameObject carroPrefab;
    public float rateSpawn;
    public float currentTime;

    // Start is called before the first frame update
    void Start()
    {
        currentTime = 0;
    }

    // Update is called once per frame
    void Update()
    {
        currentTime += Time.deltaTime;
        if (currentTime >= rateSpawn)
        {
            currentTime = 0;
            GameObject temPrefab = Instantiate(carroPrefab) as GameObject;
            temPrefab.transform.position = new Vector3(transform.position.x, temPrefab.transform.position.y, temPrefab.transform.position.z);
        }
    }
}
