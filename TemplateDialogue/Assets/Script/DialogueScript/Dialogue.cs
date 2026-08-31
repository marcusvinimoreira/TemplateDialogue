using UnityEngine;
using System.Collections;

public class Dialogue : MonoBehaviour
{
    [Header("Dialogue")]
    public Sprite profile;
    public string[] speechTxt;
    public string actorName;

    [Header("Interaction")]
    public LayerMask playerLayer;
    public float radious;

    private DialogueControl dc;
    bool onRadious;
    private bool talking;

    private void Start()
    {
        dc = FindFirstObjectByType<DialogueControl>();
    }
    private void FixedUpdate()
    {
        Interact();

    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Z) && onRadious)
        {
            if (!talking)
            {
                talking = true;
                dc.Speech(profile, speechTxt, actorName);
            }
            else
            {
                dc.NextSentence();
            }
        }
    }
    public void Interact()
    {

        Collider2D hit = Physics2D.OverlapCircle(transform.position, radious, playerLayer);
        if (hit != null)
        {
            onRadious = true;

        }
        else
        {
            onRadious = false;
            if(talking)
            {
                talking = false;
                dc.CloseDialogue();
            }
        }
    }

    private void OnDrawGizmosSelected()
    {

        Gizmos.DrawWireSphere(transform.position, radious);

    }

}
