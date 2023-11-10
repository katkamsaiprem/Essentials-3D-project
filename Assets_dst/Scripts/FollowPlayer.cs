using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    public GameObject player;

    private readonly Vector3 _offset = new(0, 5, -8);
    // Start is called before the first frame update

    // Update is called once per frame
    void LateUpdate()
    {
        transform.position = player.transform.position+_offset;

    }
}
