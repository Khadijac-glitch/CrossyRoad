using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject objectToSpawn;  // Référence au prefab à spawner
    public Transform spawnPoint;      // Point où l'objet va apparaître
    public float spawnDelay = 2.0f;  // Délai avant de spawn (en secondes)

    void Start()
    {
        // Lancer le spawn après un délai
        InvokeRepeating("SpawnObject", spawnDelay, spawnDelay);
    }

    void SpawnObject()
    {
        // Créer une nouvelle instance de l'objet à la position spécifiée
        GameObject gameObject1 = Instantiate(objectToSpawn, spawnPoint.position, spawnPoint.rotation);
    }
}
