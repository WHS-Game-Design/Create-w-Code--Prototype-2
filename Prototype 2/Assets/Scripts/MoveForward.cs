using UnityEngine;

public class MoveForward : MonoBehaviour
{
    // [SerializeField] private float speed = 40f;
    [SerializeField] private float speedMin = 10f;
    [SerializeField] private float speedMax = 40f;

    private readonly float limitZ = 30;

    void Update()
    {
        float speed = Random.Range(speedMin, speedMax);
        
        transform.Translate(speed * Time.deltaTime * Vector3.forward);

        if(Mathf.Abs(transform.position.z) > limitZ)
        {
            Destroy(gameObject);
        }

        if(transform.position.z < -limitZ)
        {
            Debug.Log("I just lost the game.");
        }
    }

    void OnTriggerEnter(Collider collider)
    {
        Debug.Log("Hit something");
        Destroy(collider.gameObject);
        Destroy(gameObject);
    }
}
