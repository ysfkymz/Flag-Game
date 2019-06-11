﻿using UnityEngine;
using System.Collections;

public class Weights : MonoBehaviour
{
    int[,] OBoardWeight = new int[,]
    {
  		{70, 0, 0, 70, 0, 0, 70},
		{60,60, 60, 60,60,60,60},
		{45,50,50, 50, 50,50,45},
		{25,35,35, 35, 35,35,25},
		{25,35,35, 35, 35,35,25},
		{10,20, 20, 20,20,20,10},
		{10,20, 20, 20,20,20,10},
		{0 , 0, 0 , 0 , 0, 0, 0},
		{0 , 0, 0 , 0 , 0, 0, 0}
				
	};

    int[,] OMirrorBoardWeight = new int[,]
    {
        {0 , 0, 0 , 0 , 0, 0, 0},
		{0 , 0, 0 , 0 , 0, 0, 0},
		{10,20, 20, 20,20,20,10},
		{10,20, 20, 20,20,20,10},
		{25,35,35, 35, 35,35,25},
		{25,35,35, 35, 35,35,25},
		{45,50,50, 50, 50,50,45},
		{60,60, 60, 60,60,60,60},
		{70, 0, 0, 70, 0, 0, 70}
    };

   

    int[,] XBoardWeight = new int[,]
    {
        {40 , 35, 35 , 40 , 35, 35, 40},
		{35 , 35, 35 , 35 , 35, 35, 35},
		{35 , 35, 35 , 35 , 35, 35, 35},
		{20 , 25 , 30 , 30, 30, 25, 20},
		{20 , 25 , 30, 30 ,30 ,25 , 20},
		{10 , 10 , 15 , 15 , 15, 10,10},
		{10 , 10, 15,  15,  15, 10 ,10},
		{5  ,5  ,5  , 5  , 5  ,5  ,  5},
		{-50  ,10,  10, -50 ,10,10,-50}
		
    };

    int[,] XMirrorBoardWeight = new int[,]
    {
        {-50  ,10,  10, -50 ,10,10,-50},
		{5  ,5  ,5  , 5  , 5  ,5  ,  5},
		{10 , 10 , 15 , 15 , 15, 10,10},
		{10 , 10, 15,  15,  15, 10 ,10},
		{20 , 25 , 30 , 30, 30, 25, 20},
		{20 , 25 , 30, 30 ,30 ,25 , 20},
		{35 , 35, 35 , 35 , 35, 35, 35},
		{35 , 35, 35 , 35 , 35, 35, 35},
		{40 , 35, 35 , 40 , 35, 35, 40},
    };

    

	public int GetBoardWeight(Piece.pieceType type, Vector2 position, Piece.pieceWork color)
    {
        switch (type)
        {
		case Piece.pieceType.O:
			if (color == Piece.pieceWork.WWORK)
				return OBoardWeight [(int)position.x, (int)position.y];
			else if (color == Piece.pieceWork.BWORK)
				return OMirrorBoardWeight [(int)position.x, (int)position.y];
			else
				return -1;
		case Piece.pieceType.X:
			if (color == Piece.pieceWork.WWORK)
				return XBoardWeight [(int)position.x, (int)position.y];
			else if (color == Piece.pieceWork.BWORK)
				return XMirrorBoardWeight [(int)position.x, (int)position.y];
			else
				return -1;
            default:
                return -1;
        }
    }

    public int GetPieceWeight(Piece.pieceType type)
    {
        switch (type)
        {
            case Piece.pieceType.O:
                return 1;
            case Piece.pieceType.X:
                return 3;
			case Piece.pieceType.WFLAG:
                return 10000;
			case Piece.pieceType.BFLAG:
				return 10000;
            default:
                return -1;
        }
    }
}