using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{

    public bool isSpawn = true;
    [SerializeField] private ObjectPool objectPool;
    void Start()
    {
        StartCoroutine(SpawnStickman());
    }

    public IEnumerator SpawnStickman()
    {
        yield return new WaitForSeconds(1f);

        while (isSpawn)
        {
            
            if (GameController.Instance.groundStickman.Count < GameController.Instance.stickmanCount)
            {
                int randomColor = Random.Range(0,0);
                print(randomColor);
                GameObject obj =   objectPool.GetPooledObject(randomColor);
                float randomPosX = Random.Range(4.55f, -3.85f);
                float randomPosZ = Random.Range(5.62f, -8.72f);
                obj.transform.position = new Vector3(randomPosX,4.3f,randomPosZ);
                GameController.Instance.groundStickman.Add(obj);
                
            }
            yield return new WaitForSeconds(2f);
        }
    }
}
