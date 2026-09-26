using System;
using UnityEngine;

public class Bird : MonoBehaviour
{
    static readonly int Idle1 = Animator.StringToHash("idle");
    static readonly int Panic1 = Animator.StringToHash("panic");
    static readonly int Curious1 = Animator.StringToHash("curious");
    float dist => Vector3.Distance(transform.position, player.transform.position);

    Animator animator;
    protected Player player;
    
    public enum BirdState
    {
        Idle,
        Curious,
        Panic
    }
    public BirdState state = BirdState.Idle;

    public float curiousDist;
    public float panicDist;

    void Start()
    {
        player = FindObjectOfType<Player>();
        animator = GetComponent<Animator>();
    }
    
    void OnValidate()
    {
        if(panicDist > curiousDist)
            Debug.LogError("Panic Dist must be shorter than curious dist");
    }

    protected virtual void Update()
    {
        var prevState = state;
        if(dist <= curiousDist && dist > panicDist) state = BirdState.Curious;
        else if(dist <= panicDist) state = BirdState.Panic;
        else state = BirdState.Idle;
        if(state != prevState) StateCall();
    }

    void StateCall()
    {
        switch(state)
        {
            case BirdState.Idle: animator.SetTrigger(Idle1);break;
            case BirdState.Curious: animator.SetTrigger(Curious1); break;
            case BirdState.Panic: animator.SetTrigger(Panic1); Panic(); break;
        }
    }

    public virtual void Panic()
    {
        
    }
    
}