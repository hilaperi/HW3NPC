using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RedHumanMotion : MonoBehaviour
{
    float speed;
    float angularSpeed;
    float hMove, vMove;
   // AudioSource audioSource;
   CharacterController cController;

    // Start is called before the first frame update
    void Start()
    {
        speed = 7f;
        angularSpeed = 100f;
        cController = GetComponent<CharacterController>();
       // audioSource = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        //speed = SliderBehaviour.speed_level * 0.5f;
        // if a key was pressed
        if (Input.GetButton("Horizontal") || Input.GetButton("Vertical"))
        {
            hMove = Input.GetAxis("Horizontal") * angularSpeed * Time.deltaTime;
            vMove = Input.GetAxis("Vertical") * speed * Time.deltaTime;
            GetComponent<Animation>().Play("ShieldWarrior@Walk01");
            transform.Rotate(0, hMove, 0);

            //pos is the x-z coordinate of a character
            //For the terrain 
            Vector3 pos = new Vector3(transform.position.x, 0, transform.position.z);
           // Vector3 point;
           // point.y = Terrain.activeTerrain.SampleHeight(pos) - transform.position.y; // delta in Y direction
            Vector3 direction = Vector3.forward * vMove;
           // direction.y = point.y;
            // TransformDirection transforms coordinates to GLOBALs
            cController.Move(transform.TransformDirection(direction));

            // sound effect
            //  if (!audioSource.isPlaying)
            // {
            //  audioSource.PlayDelayed(0.2f);
            //                audioSource.Play();
            // }


        }
        else
        {
            GetComponent<Animation>().Play("ShieldWarrior@Idle01");
        }
    }
}