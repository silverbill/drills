using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

public class MainClass{
    public void Main(){
        Team myTeam = new Team("Cowboys");
        List<Player> players = new List<Player>();
        players.Add(new Player ("Witten", 22));
        players.Add(new Player ("Jones", 23));
        players.Add(new Player ("Romo", 5));
        players.Add(new Player ("Smith", 44));
        players.Add(new Player ("DelRio", 5));
    }

public class Team{
    string name;
    string Players;
    int Points;
    public Team(string name){
        this.name = name;
    }
}   
public class Player{
    string name; //getter and setter
    int points;
    public Player(){  
    }
    public Player (string name, int points){
        this.name = name;
        this.points = points;
    }
}    
}    

