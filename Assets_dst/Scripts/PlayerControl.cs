using UnityEngine;

public class PlayerControl : MonoBehaviour
{
    public float speed = 0.5f;

    public float turnspeed = 0.5f;
    // Start is called before the first frame update

    // Update is called once per frame
    void Update()
    {
     transform.Translate(Vector3.forward * ((Time.deltaTime) * speed));
     transform.Translate(Vector3.right * ((Time.deltaTime) * turnspeed));
    }
}
