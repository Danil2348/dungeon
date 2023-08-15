using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Unity.AI.Navigation;

public class genereit : MonoBehaviour
{
    public GameObject floorsdetail;
    public GameObject[] gold;
    public GameObject[] stone;
    public GameObject[] wood;
    private Vector3 mypos;
    private NavMeshSurface navMeshSurface;

    void Awake()
    {
        navMeshSurface = GetComponent<NavMeshSurface>();
        mypos = transform.position;
    }
    void Start()
    {
        Create();
        
    }
    void Create()
    {
        for (int i = 0; i < 7; i++)
        {
            for (int j = 0; j < 7; j++)
            {
                if(i != 3 && j != 6)
                {
                    if (Random.value > 0.8f)
                    {
                        Instantiate(floorsdetail, new Vector3(mypos.x - i, 0, mypos.z - j), transform.rotation);
                    }
                    if (Random.value > 0.5f)
                    {
                        if (Random.value > 0.7f)
                        {
                            Instantiate(wood[Random.Range(0, wood.Length)], new Vector3(mypos.x - i, 0, mypos.z - j), transform.rotation).transform.parent = transform;
                        }
                        if (Random.value > 0.8f)
                        {
                            Instantiate(gold[Random.Range(0, gold.Length)], new Vector3(mypos.x - i, 0, mypos.z - j), transform.rotation).transform.parent = transform;
                        }
                    }
                    else if (Random.value > 0.7f)
                    {
                        Instantiate(stone[Random.Range(0, stone.Length)], new Vector3(mypos.x - i, 0, mypos.z - j), transform.rotation).transform.parent = transform;
                    }
                }
                
            }

        }
        navMeshSurface.BuildNavMesh();

    }
}
