using System.Threading;
using UnityEngine;

public class OnTriggerInteraction : MonoBehaviour
{

    [SerializeField] private Animator toxtricityAnimator;
    [SerializeField] private Animator pickachuAnimator;
    private void OnTriggerEnter(Collider other)
    {
        toxtricityAnimator.SetBool("isInteracting", true);
        pickachuAnimator.SetBool("isInteracting", true);
        //Thread.Sleep(200); // Simulate a delay for the animation
        Debug.Log("Trigger Entered");
    }
    private void OnTriggerExit(Collider other)
    {
        pickachuAnimator.SetBool("isInteracting", false);
        toxtricityAnimator.SetBool("isInteracting", false);
        Debug.Log("Trigger Exited");
    }
}
