using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{

    public bool isSpawn = true;
    void Start()
    {
        StartCoroutine(SpawnStickman());
    }

    public IEnumerator SpawnStickman()
    {
        yield return new WaitForSeconds(1f);

        while (isSpawn)
        {
            if (GameController.Instance.groundStickman.Count<10)
            {
                int randomStickman = Random.Range(0, 3);
                float randomPosX = Random.Range(4.55f, -3.85f);
                float randomPosZ = Random.Range(5.62f, -8.72f);
                var Stickman = Instantiate(GameController.Instance.stickman[randomStickman], new Vector3(randomPosX, 4.3f, randomPosZ), Quaternion.identity);
                GameController.Instance.groundStickman.Add(Stickman); 
            }
            yield return new WaitForSeconds(2f);
        }
    }
}
