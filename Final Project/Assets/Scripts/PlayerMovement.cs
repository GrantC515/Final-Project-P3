using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class PlayerMovement : MonoBehaviour
{

    [SerializeField] public float _moveSpeed = 10f;
    public float _charHealth = 5f;
    public TextMeshProUGUI healthText;
    public float jumpForce = 10;
    private float moveDirection = 0;
    public bool isOnGround = false;
    public bool isGameOver = false;
    private Rigidbody _playerRB;
    public GameObject orientation;

    // Start is called before the first frame update
    void Start()
    {
        _playerRB = GetComponent<Rigidbody>();
        
    }

    // Update is called once per frame
    void Update()
    {
        Movement();
        GameOver();
        PlayerJump();
    }

    void Movement()
    {
        float horizontalInput = Input.GetAxis("Horizontal") * _moveSpeed * Time.deltaTime;
        float verticalInput = Input.GetAxis("Vertical") * _moveSpeed * Time.deltaTime;

        transform.Translate(horizontalInput, -verticalInput, 0f);
        //moveDirection = orientation * verticalInput * orientation.right * horizontalInput;
    }

    public void PlayerJump()
    {
        if(Input.GetKeyDown(KeyCode.Space) && isOnGround && !isGameOver)
        {
            _playerRB.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
            isOnGround = false;
        }
    }

    public void UpdateHealth()
    {
        _charHealth --;
        healthText.text = _charHealth.ToString();
    }

        private void OnCollisionEnter(Collision other) 
    {
       if(other.gameObject.CompareTag("Projectile")) 
        {
            UpdateHealth();
        }
    }

    public void GameOver()
    {
        if(_charHealth <= 0)
        {
            SceneManager.LoadScene(2);
        }
    }

    private void IsOnGround(Collision other)
    {
        if(other.gameObject.CompareTag("Ground"))
        {
            isOnGround = true;
        }
    }
}
