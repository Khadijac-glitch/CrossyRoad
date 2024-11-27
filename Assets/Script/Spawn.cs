using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject objectToSpawn;  // R�f�rence au prefab � spawner
    public Transform spawnPoint;      // Point o� l'objet va appara�tre
    public float spawnDelay = 2.0f;  // D�lai avant de spawn (en secondes)

    void Start()
    {
        // Lancer le spawn apr�s un d�lai
        InvokeRepeating("SpawnObject", spawnDelay, spawnDelay);
    }

    void SpawnObject()
    {
        // Cr�er une nouvelle instance de l'objet � la position sp�cifi�e
        GameObject gameObject1 = Instantiate(objectToSpawn, spawnPoint.position, spawnPoint.rotation);
    }
}
