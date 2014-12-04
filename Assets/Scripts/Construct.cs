﻿using UnityEngine;
using System.Collections;

public class Construct : MonoBehaviour {

    DetectTiles detectTiles;
    PlayerController playerController;
    public Object turret;
    public Object wall;

    void Awake()
    {
        playerController = GetComponent<PlayerController>();
        detectTiles = GetComponent<DetectTiles>();
    }
    public void CreateTurret()
    {
        if (playerController.Ammo >= 50
            && playerController.Metal >= 50
            && playerController.Wood >= 50
            && playerController.Copper >= 50
            )
        {
            playerController.Ammo -= 50;
            playerController.Metal -= 50;
            playerController.Wood -= 50;
            playerController.Copper -= 50;
            detectTiles.SelectedTile.GetComponent<Tile>().CreateStructure(turret);
        }
    }

    public void CreateWall()
    {
        if (playerController.Ammo >= 25
            && playerController.Metal >= 25
            && playerController.Wood >= 25
            && playerController.Copper >= 25
            )
        {
            playerController.Ammo -= 25;
            playerController.Metal -= 25;
            playerController.Wood -= 25;
            playerController.Copper -= 25;
            detectTiles.SelectedTile.GetComponent<Tile>().CreateStructure(wall);
        }
    }
}