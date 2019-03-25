# Bomberman-Replica
First videogame development project.

# Introduction
This is a replica of the classic Bomberman Game in SNES.

The idea is to place a bomb near a wall to destroy it and use the same bomb to defeat the second player.

# Controls

It is a Two-Player game.

- Player One Controls
<pre>
  ○ UpArrowKey    | Move Up
  ○ DownArrowKey  | Move Down
  ○ LeftArrowKey  | Move Left
  ○ RightArrowKey | Move Right
  ○ SpaceBar      | Place Bomb
</pre>  
  
  
- Player Two Controls
<pre>
  ○ NumPad8 | Move Up
  ○ NumPad5 | Move Down
  ○ NumPad4 | Move Left
  ○ NumPad6 | Move Right
  ○ EndKey  | Place Bomb

</pre>


# Changing Controls
You can change the controls by making changes in the following files present in <i>/Assets/Scripts</i> directory.

- Player One
<pre>
○ Player One Movement | Player1.cs
○ Player One Bomb     | BombSpawner.cs
</pre>

- Player Two
<pre>
○ Player One Movement | Player2Script.cs
○ Player One Bomb     | Player2BombSpawner.cs
</pre>

