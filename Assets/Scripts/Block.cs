using UnityEngine;

public class Block : MonoBehaviour
{

    // Update is called once per frame
    private void Update()
    {
        if (transform.position.y < -6f)
        {
            Destroy(gameObject);
        }
    }
}
