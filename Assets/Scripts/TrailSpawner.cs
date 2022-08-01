using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrailSpawner : MonoBehaviour
{
    [SerializeField]
    private GameObject cube;

    private GameObject spawnedCube;

    public Transform cameraPosition;

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(SpawnCube());
    }

    IEnumerator SpawnCube()
    {
        while (true)
        {
            yield return new WaitForSeconds(Random.Range(1, 3));
            spawnedCube = Instantiate(cube);
            spawnedCube.transform.position = cameraPosition.position;
        }
    }

}
