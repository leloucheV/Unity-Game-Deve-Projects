using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Movement : MonoBehaviour {
    private Rigidbody rb;
    public float Speed;
    public Text countText;
    private int count;
    public Text winText;
	// Use this for initialization
	void Start () {

        rb = GetComponent<Rigidbody>();
        count = 0;
        setCountText();
        winText.text = "";
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    void FixedUpdate()
    {
        //always remember that this is where physics calculations are made before execution in update

        float horizontalMovement = Input.GetAxis("Horizontal");
        float verticalMovement = Input.GetAxis("Vertical");

        Vector3 movement = new Vector3(horizontalMovement, 0, verticalMovement);
        rb.AddForce(movement*Speed);



    }

    void OnTriggerEnter(Collider other)
    {

        if (other.gameObject.CompareTag("Pickup"))
        {
            other.gameObject.SetActive(false);
            count = count + 1;
            setCountText();
        }

       
    }
    void setCountText()
    {
        countText.text = "Points:" + count.ToString();
        if (count == 7)
        {
            winText.text = "You have won!";
        }
    }
}
