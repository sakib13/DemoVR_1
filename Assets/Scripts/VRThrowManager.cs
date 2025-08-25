using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class VRThrowManager : MonoBehaviour {
    public GameObject cubePrefab; // Assign BB_ThrowableCube
    public Transform spawnPoint;

    public void ThrowCubeRight() {
        GameObject cube = Instantiate(cubePrefab, spawnPoint.position, spawnPoint.rotation);
        Rigidbody rb = cube.GetComponent<Rigidbody>();
        if (rb != null) {
            rb.velocity = Vector3.zero;
            rb.angularVelocity = Vector3.zero;
            Debug.DrawRay(spawnPoint.position, spawnPoint.forward * 2f, Color.red, 2f);
            rb.AddForce(spawnPoint.forward * 5f, ForceMode.Impulse);
        }
    }
}