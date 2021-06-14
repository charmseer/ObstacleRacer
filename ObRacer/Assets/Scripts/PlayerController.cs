using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.InputSystem;

public class PlayerController : MonoBehaviour
{
    private PlayerActionControls playerActionControls;

    [SerializeField] private float speed;
    //[SerializeField] private float mapWidth = 25f;
    public Rigidbody rb;
    public float forwardForce = 100f;

    public AudioSource engineSound;
    

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
        if (Keyboard.current.spaceKey.IsActuated())
        {
            rb.AddForce(0, 0, forwardForce * Time.deltaTime, ForceMode.VelocityChange);
            engineSound.Play();
        }
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

        //if(Keyboard.current.spaceKey.wasPressedThisFrame)

        if (rb.position.y < -1.5f)
        {
            //Time.timeScale = 0f;
            //Destroy(gameObject); // Doesn't work camera still follows so we get error messages.
            FindObjectOfType<GameManager>().FallOffPause();
            //FindObjectOfType<GameManager>().EndGame();
        }


    }
}