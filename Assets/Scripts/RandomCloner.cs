using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomCloner : MonoBehaviour
{
    public int randomNumber;
    public int min;
    public int max;

    // Start is called before the first frame update
    void Start()
    {

    }

    public void CloneRandom()
    {
        randomNumber = Random.Range(min, max + 1);
    }
}
