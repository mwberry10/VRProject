using UnityEngine;

public class PistolBehavior : MonoBehaviour
{
    public GameObject laserTemplate;
    public Transform spawnPoint;
    public int clipSize;
    private int shotsRemaining;

    public void ShootLaser()
    {
       if (shotsRemaining > 0) {
           GameObject clone = Instantiate(laserTemplate, spawnPoint.position, spawnPoint.rotation);
           Rigidbody rb = clone.GetComponent<Rigidbody>();
           rb.AddForce(spawnPoint.forward * 12, ForceMode.Impulse);
           shotsRemaining = shotsRemaining - 1;
       }
       
    }
    public void reload() {
        shotsRemaining = clipSize;
    }
}
