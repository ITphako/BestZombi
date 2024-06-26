
﻿using System;

public interface IZombiLife
{
        event Action Dying;

        void TakeDamage(int damage);
}