﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Up_1_Buy : MonoBehaviour {

    private string up_name;
    private int up_cost = 20;
    private int up_cost_finall = 0;
    private int up_number_upgrades;

    private void Update()
    {
        Upgrade();
    }

    void Upgrade()
    {
        up_number_upgrades = Stats.up_1;
        up_cost_finall = up_cost * up_number_upgrades;
        Stats.up_1_cost = up_cost_finall;
    }
}
