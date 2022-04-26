using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Tilemaps;

public class tileclicker : MonoBehaviour
{
    
    public TileBase TileGet;
    public TileBase TileToSet;
    public TileBase TilePlayer1;
    public TileBase TilePlayer2;
    
    public Transform Player;
    public Transform Player2;

    private Tilemap map;
    private Vector3Int PrePosition;
    private Vector3Int ZemyaTile;
    private int Activities=0;
    private int Limits=1;
    private bool Playmaker=false;
    private Camera mainCamera;

    void Start()
    {
        map = GetComponent<Tilemap>();
        mainCamera = Camera.main;
        PrePosition.Set(20, 20, 0);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.R)){
            Playmaker=!(Playmaker);
            Debug.Log(Playmaker);

        }
        
        if (Input.GetMouseButtonDown(0))
        {
           
            Vector3 clickWorldPosition = mainCamera.ScreenToWorldPoint(Input.mousePosition);
            Vector3Int clickCellPosition = map.WorldToCell(clickWorldPosition);
            clickCellPosition.z+=1;
            //Act0
            if(Activities==0  && Limits>0){
                Debug.Log(clickCellPosition);
                if(map.GetTile(clickCellPosition) != null){
                Debug.Log(map.GetTile(clickCellPosition));

                clickCellPosition.z+=1;
                PrePosition=clickCellPosition;


                Player.position = map.CellToWorld(clickCellPosition);
                ZemyaTile = clickCellPosition;
                ZemyaTile.z-=1;

                clickCellPosition.x+=1;
                ZemyaTile.x+=1;
                if(map.GetTile(ZemyaTile) != null){map.SetTile(clickCellPosition, TileToSet);}
                
                clickCellPosition.x-=2;
                ZemyaTile.x-=2;
                if(map.GetTile(ZemyaTile) != null){map.SetTile(clickCellPosition, TileToSet);}
                if((clickCellPosition.y)%2!=0){
                    clickCellPosition.x+=1;
                    ZemyaTile.x+=1;
                }
                
                clickCellPosition.y+=1;
                ZemyaTile.y+=1;
                if(map.GetTile(ZemyaTile) != null){map.SetTile(clickCellPosition, TileToSet);}
                clickCellPosition.y-=2;
                ZemyaTile.y-=2;
                if(map.GetTile(ZemyaTile) != null){map.SetTile(clickCellPosition, TileToSet);}
                clickCellPosition.x+=1;
                ZemyaTile.x+=1;
                if(map.GetTile(ZemyaTile) != null){map.SetTile(clickCellPosition, TileToSet);}
                clickCellPosition.y+=2;
                ZemyaTile.y+=2;
                if(map.GetTile(ZemyaTile) != null){map.SetTile(clickCellPosition, TileToSet);}
                Activities+=1;
                }
            }

            //Act1
            if(Activities!=0 && Activities<2){

            if(map.GetTile(clickCellPosition) != null){
            
            clickCellPosition.z+=1;

            if(map.GetTile(clickCellPosition) != null){
            PrePosition.z-=1;
            map.SetTile(PrePosition, TilePlayer1);
            PrePosition.z+=1;
            

            PrePosition.x+=1;
            map.SetTile(PrePosition, null);
            PrePosition.x-=2;
            map.SetTile(PrePosition, null);
            if((PrePosition.y)%2!=0){
                PrePosition.x+=1;
            }
            
            PrePosition.y+=1;
            map.SetTile(PrePosition, null);
            PrePosition.y-=2;
            map.SetTile(PrePosition, null);
            PrePosition.x+=1;
            map.SetTile(PrePosition, null);
            PrePosition.y+=2;
            map.SetTile(PrePosition, null);

            PrePosition=clickCellPosition;
            

            
            


            Debug.Log(clickCellPosition);
            
            if(map.GetTile(clickCellPosition) == TileToSet){
                map.SetTile(clickCellPosition, null);
            }
            Player.position = map.CellToWorld(clickCellPosition);
            
            

            ZemyaTile = clickCellPosition;
            ZemyaTile.z-=1;

            clickCellPosition.x+=1;
            ZemyaTile.x+=1;
            if(map.GetTile(ZemyaTile) != null){map.SetTile(clickCellPosition, TileToSet);}
            
            clickCellPosition.x-=2;
            ZemyaTile.x-=2;
            if(map.GetTile(ZemyaTile) != null){map.SetTile(clickCellPosition, TileToSet);}
            if((clickCellPosition.y)%2!=0){
                clickCellPosition.x+=1;
                ZemyaTile.x+=1;
            }
            
            clickCellPosition.y+=1;
            ZemyaTile.y+=1;
            if(map.GetTile(ZemyaTile) != null){map.SetTile(clickCellPosition, TileToSet);}
            clickCellPosition.y-=2;
            ZemyaTile.y-=2;
            if(map.GetTile(ZemyaTile) != null){map.SetTile(clickCellPosition, TileToSet);}
            clickCellPosition.x+=1;
            ZemyaTile.x+=1;
            if(map.GetTile(ZemyaTile) != null){map.SetTile(clickCellPosition, TileToSet);}
            clickCellPosition.y+=2;
            ZemyaTile.y+=2;
            if(map.GetTile(ZemyaTile) != null){map.SetTile(clickCellPosition, TileToSet);}


            Activities+=1;
            }
            }
            
            }
            

        
            
            
            //map.SwapTile(TileGet, TileToSet);
        }
    }
}
