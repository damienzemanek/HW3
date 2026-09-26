using UnityEngine;

public class Pigeon : Bird
{
    public float moveSpeed;

    protected override void Update()
    {
        base.Update();
        if (state != BirdState.Panic) return;
        Vector3 dirToPlayer = transform.position - player.transform.position;
        transform.Translate(dirToPlayer.normalized * moveSpeed * Time.deltaTime, Space.World);
    }
}