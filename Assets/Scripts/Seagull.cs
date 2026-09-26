using UnityEngine;

public class Seagull : Bird
{
    public GameObject vfx_explosion;
    bool exploded = false;
    
    public override void Panic()
    {
        if (exploded) return;
        Invoke(nameof(Explosion), 0.2f);
    }

    void Explosion()
    {
        var go_expl = Instantiate(vfx_explosion, transform.position, transform.rotation);
        go_expl.transform.parent = null;
        Destroy(gameObject);
    }
}