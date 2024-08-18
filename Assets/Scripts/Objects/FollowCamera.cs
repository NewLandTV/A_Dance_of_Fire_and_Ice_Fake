using UnityEngine;

public class FollowCamera : MonoBehaviour
{
    public Transform target;
    public float speed;

    private void Update()
    {
        transform.position = new Vector3(target.position.x, target.position.y, -10f);
    }
}
