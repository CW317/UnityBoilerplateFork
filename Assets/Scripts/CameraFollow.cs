using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public Transform target;

    void Update()
    {
        // keep the Y and follow the X position of the target with a lerp (smooth) function
        transform.position = Vector3.Lerp(transform.position, new Vector3(target.position.x, // only follow X
            target.position.y, transform.position.z), t: 10 * Time.deltaTime);
    }
}
