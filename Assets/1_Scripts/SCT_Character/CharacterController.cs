using System.Collections;
using System.Collections.Generic;
using UnityEngine;


// HP
// Skill Delay
// Strength
// Defence
// Agility
// Fire rate
// Speed
public class CharacterController : MonoBehaviour
{
    [SerializeField] private bool b_direction;
    [SerializeField] private ForceMode e_mode;
    [SerializeField] private Rigidbody rb_character;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        rb_character.AddForce(Vector3.right * (b_direction ? 1 : -1), e_mode);
    }
}
