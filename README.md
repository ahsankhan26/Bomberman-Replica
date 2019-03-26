# Bomberman-Replica
First videogame development project.

# Introduction
This is a replica of the "Super Bomberman" Game in SNES.

The idea is to place a bomb near a wall to destroy it and use the same bomb to defeat the second player.

# Controls

It is a Two-Player game.

- Player One Controls

| Key            | Description |
| -------------- | ----------- |
| UpArrowKey     | Move Up     |
| DownArrowKey   | Move Down   |
| LeftArrowKey   | Move Left   |
| RightArrowKey  | Move Right  |
| SpaceBar       | Place Bomb  |

  
- Player Two Controls

| Key            | Description |
| -------------- | ----------- |
| NumPad8        | Move Up     |
| NumPad5        | Move Down   |
| NumPad4        | Move Left   |
| NumPad6        | Move Right  |
| End Key        | Place Bomb  |


# Changing Controls
You can change the controls by making changes in the following files present in <i>/Assets/Scripts</i> directory.

- Player One
<pre>
○ Player One Movement | Player1.cs
○ Player One Bomb     | BombSpawner.cs
</pre>

- Player Two
<pre>
○ Player Two Movement | Player2Script.cs
○ Player Two Bomb     | Player2BombSpawner.cs
</pre>

