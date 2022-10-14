using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KillAndDamage : Avatar
{
    private void Start()
    {
        Avatar avatar = new Avatar();

        avatar.Kill();
        avatar.Damage(10);
    }
}
