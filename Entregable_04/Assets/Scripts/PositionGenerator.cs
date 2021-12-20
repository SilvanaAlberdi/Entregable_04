using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;

public class PositionGenerator : MonoBehaviour
{
    private Vector3 RandomPosition()
    {
        int RandomX = Random.Range(-6, 7);
        int RandomY = Random.Range(-3, 4);
        int RandomZ = Random.Range(-1, 2);

        return new Vector3(RandomX, RandomY, RandomZ);
    }
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.R))
        {
            transform.position = RandomPosition();
        }
    }
}
