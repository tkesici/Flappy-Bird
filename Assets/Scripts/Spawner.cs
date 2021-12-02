using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
    
{
    public FlappyBird flappyBird;
    public GameObject pipes;
    public float height;
    public float time;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(SpawnObject(time));
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public IEnumerator SpawnObject(float time)
    {
        while(!flappyBird.isDead)
        {
       
            Instantiate(pipes, new Vector3(3, Random.Range(-height, height), 0), Quaternion.identity);
            yield return new WaitForSeconds(time);
        }
    }
}
