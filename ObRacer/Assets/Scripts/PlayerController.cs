using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerController : MonoBehaviour
{
    private PlayerActionControls playerActionControls;

    [SerializeField] private float speed;
    //[SerializeField] private float mapWidth = 25f;
    public Rigidbody rb;
    public float forwardForce = 1000f;

    

    private void Awake()
    {
        playerActionControls = new PlayerActionControls();

    }

    private void OnEnable()
    {
        playerActionControls.Enable();
    }

    private void OnDisable()
    {
        playerActionControls.Disable();
    }
    // Start is called before the first frame update
    void Start()
    {

    }

    private void FixedUpdate()
    {
        rb.AddForce(0, 0, forwardForce * Time.deltaTime, ForceMode.VelocityChange);
    }
    // Update is called once per frame
    void Update()
    {
        //Read the movement value
        float movementInput = playerActionControls.Land.Move.ReadValue<float>();

        //Move the player
        Vector3 currentPosition = transform.position;
        currentPosition.x += movementInput * speed * Time.deltaTime;

        //currentPosition.x = Mathf.Clamp(currentPosition.x, -mapWidth, mapWidth);

        transform.position = currentPosition;

        if (rb.position.y < -1.5f)
        {
            //Destroy(gameObject); // Doesn't work camera still follows so we get error messages.
            FindObjectOfType<GameManager>().FallOffPause();
            //FindObjectOfType<GameManager>().EndGame();
        }


    }
}