using UnityEngine;

public class Player : MonoBehaviour
{
    public float moveSpeed = 5f;

    [Header("-- Private references --")]
    [SerializeField] private int coinsCollected = 0;

    // Update is called once per frame
    void FixedUpdate()
    {
        Vector3 newPosition = transform.position;
            if(Input.GetKey(KeyCode.A)) {
                newPosition.x -= moveSpeed * Time.deltaTime;
            }
            if(Input.GetKey(KeyCode.D)) {
                newPosition.x += moveSpeed * Time.deltaTime;
            }
            if(Input.GetKey(KeyCode.W)) {
                newPosition.y += moveSpeed * Time.deltaTime;
            }
            if(Input.GetKey(KeyCode.S)) {
                newPosition.y -= moveSpeed * Time.deltaTime;
            }            
        transform.position = newPosition;
    }

    // OnTriggerEnter2D is called once, when two GameObjects with Collider2Ds hit each other
        // - One GameObject must have a Rigidbody2D as well
        // - One of the Collider2Ds must be a Trigger
    void OnTriggerEnter2D(Collider2D coll) {
        if(coll.gameObject.tag.Equals("Coin")) {
            coinsCollected += 1;
            Destroy(coll.gameObject);
        }
    }

}
