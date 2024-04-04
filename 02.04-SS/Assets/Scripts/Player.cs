using UnityEngine;

public class Player : MonoBehaviour
{
    public float moveSpeed = 5f;
    private Animator animator;

    public AudioClip audioClip;
    private AudioSource audioSource;

    [Header("-- Private references --")]
    [SerializeField] private int coinsCollected = 0;

    void Start()
    {
        animator = GetComponent<Animator>();
        audioSource = GetComponent<AudioSource>();
        audioSource.clip = audioClip;
    }


    void Update()
    {
        if (Input.GetKeyDown(KeyCode.A))
        {
            animator.SetInteger("Walk", 4);
        }

        if (Input.GetKeyDown(KeyCode.D))
        {
            animator.SetInteger("Walk", 3);
        }

        if (Input.GetKeyDown(KeyCode.W))
        {
            animator.SetInteger("Walk", 1);
        }

        if (Input.GetKeyDown(KeyCode.S))
        {
            animator.SetInteger("Walk", 2);
        }
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        Vector3 newPosition = transform.position;
        if (Input.GetKey(KeyCode.A))
        {
            newPosition.x -= moveSpeed * Time.deltaTime;
        }
        if (Input.GetKey(KeyCode.D))
        {
            newPosition.x += moveSpeed * Time.deltaTime;
        }
        if (Input.GetKey(KeyCode.W))
        {
            newPosition.y += moveSpeed * Time.deltaTime;
        }
        if (Input.GetKey(KeyCode.S))
        {
            newPosition.y -= moveSpeed * Time.deltaTime;
        }
        transform.position = newPosition;
    }

    // OnTriggerEnter2D is called once, when two GameObjects with Collider2Ds hit each other
    // - One GameObject must have a Rigidbody2D as well
    // - One of the Collider2Ds must be a Trigger
    void OnTriggerEnter2D(Collider2D coll)
    {
        if (coll.gameObject.tag.Equals("Coin"))
        {
            coinsCollected += 1;
            Destroy(coll.gameObject);
        }

        if (coll.gameObject.tag.Equals("Coin"))
        {
            audioSource.Play();
        }
    }

}
