ClickOnCircles Game

Game logic:

  =>Managers:
    ->GameOverManager
      removes ui elements and circles that weren poped by player and shows score with buttons play again
      and exit to main menu
    ->ScenesManager
      helps to navigate between scenes in game. There can be only one Object of SceneManager
    ->ScoreManager
      manages the score of player and writes the score to the ui layer
    ->SoundManager
      plays the sound which is required
    ->SpawnManager
      creates the object uding prefab. It calculates the size of camera and makes the field in which it
      will be spawning circles

  =>UI:
    ->UIGame
      helps to controll the SceneManager via code not via unity editor to make buttons reply to user input
      in gameScene
    ->UIMenu
      same as UIGame but in Menu scene

  =>Other classes:
    ->ChangeParametersCircle
      changes the parameters of circle while spawning
    ->CountdownTimer
      helps to count the time of round
    ->InputHandler
      checks the click on circles

Overall:
  The logic of objects in game is simple: every manager controlls the specific field of game and has an 
  empty object with the same name. For text I used TextMeshPro. I made a flexible sprites for buttons 
  that are practical in use because they can have different ratios. 

