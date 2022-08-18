using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectPool : MonoBehaviour
{
    [Serializable]
    public struct Pool
    {
        public Queue<GameObject> pooledObjects;
        public GameObject objectPrefab;
        public int poolSize;
    }

    [SerializeField] public Pool[] pools = null;
    [SerializeField] private List<GameObject> stickman = new List<GameObject>();
    
    public bool isPool = false;
    public int a = 15;
    public int b = 30;


    private void Awake()
    {
        for (int j = 0; j < pools.Length; j++)
        {
            pools[j].pooledObjects = new Queue<GameObject>();

            for (int i = 0; i < pools[j].poolSize; i++)
            {
                GameObject obj = Instantiate(pools[j].objectPrefab);
                obj.SetActive(false);
                stickman.Add(obj);

                pools[j].pooledObjects.Enqueue(obj);
            }
        }
    }
    private void Update()
    {
        if (isPool&&stickman.Count<=b)
        {
            while (isPool)
            {
                
                b += a;
                PoolUpdate();
                isPool = false;
            }
           
        }
    }

    public GameObject GetPooledObject(int objectType)
    {
        if (objectType >= pools.Length)
        {
            return null;
        }

        GameObject obj = pools[objectType].pooledObjects.Dequeue();

        obj.SetActive(true);


        pools[objectType].pooledObjects.Enqueue(obj);

        return obj;
    }
    public void PoolUpdate()
    {
        for (int j = 0; j < pools.Length; j++)
        {
            pools[j].pooledObjects = new Queue<GameObject>();

            for (int i = 0; i < pools[j].poolSize; i++)
            {
                GameObject obj = Instantiate(pools[j].objectPrefab);
                obj.SetActive(false);
                stickman.Add(obj);

                pools[j].pooledObjects.Enqueue(obj);
            }
        }
    }
}