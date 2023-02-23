using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject[] animalPrefabs;
    public int startTime = 1;
    public int delayTime = 4;
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("aminalsRepeating", startTime, delayTime);
    }

    // Update is called once per frame
    void Update()
    {
    }
    public void aminalsRepeating(){

         //Using a Random Range Method
            int animalIndex = Random.Range(0,2);
            int animalRangeX = Random.Range(-23,23);
            Vector3 positionRX = new Vector3(animalRangeX,0,20);
          Instantiate(animalPrefabs[animalIndex], positionRX , animalPrefabs[animalIndex].transform.rotation);
          

    }
}
