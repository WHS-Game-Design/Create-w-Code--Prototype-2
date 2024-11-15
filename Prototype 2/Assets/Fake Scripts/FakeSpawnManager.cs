using System.Collections;
using UnityEngine;

public class FakeSpawnManager : MonoBehaviour
{
    [SerializeField] private GameObject[] animal;

    void Start() => InvokeRepeating(nameof(SpawnAnimals), 2, 1);
    void SpawnAnimals() => Instantiate(animal[Random.Range(0, animal.Length)], new(Random.Range(-15, 15), 0, 20), animal[Random.Range(0, animal.Length)].transform.rotation);
}
