\ *********************************************************************
\ SDL2 / tests
\    Filename:      tests.fs
\    Date:          24 oct 2024
\    Updated:       24 oct 2024
\    File Version:  1.0
\    Forth:         eFORTH Windows
\    Author:        Marc PETREMANN
\    GNU General Public License
\ *********************************************************************

\ initialize SDL environment
SDL_INIT_VIDEO SDL.Init

\ define size and position for SDL window
800 constant SCREEN_WIDTH
400 constant SCREEN_HEIGHT
200 constant X0_SCREEN_POSITION
 50 constant Y0_SCREEN_POSITION

z" My first window with SDL2" 
    X0_SCREEN_POSITION Y0_SCREEN_POSITION 
    SCREEN_WIDTH SCREEN_HEIGHT 
    SDL_WINDOW_SHOWN CreateWindow
    value WIN0

\ WIN0 -1 0 CreateRenderer
\ value REN0



