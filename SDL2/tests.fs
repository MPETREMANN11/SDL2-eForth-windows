\ *********************************************************************
\ SDL2 / tests
\    Filename:      tests.fs
\    Date:          24 oct 2024
\    Updated:       26 oct 2024
\    File Version:  1.0
\    Forth:         eFORTH Windows
\    Author:        Marc PETREMANN
\    GNU General Public License
\ *********************************************************************


forth definitions
SDL2

\ initialize SDL environment
SDL_INIT_VIDEO SDL.Init

\ define size and position for SDL window
800 constant SCREEN_WIDTH
400 constant SCREEN_HEIGHT
200 constant X0_SCREEN_POSITION
 50 constant Y0_SCREEN_POSITION

0 value WIN0
0 value REN0

: initNewWindow ( -- )
    \ create new window
    z" My first window with SDL2"    
    X0_SCREEN_POSITION Y0_SCREEN_POSITION
    SCREEN_WIDTH SCREEN_HEIGHT
    SDL_WINDOW_SHOWN
    SDL.CreateWindow  to WIN0
    \ create a new renderer
    WIN0 -1 0 CreateRenderer  to REN0
  ;

variable SDLquit
variable SDLevent

: draw ( -- )
    REN0 255 0 0 255 SetRenderDrawColor drop
    REN0 RenderClear drop
  ;

\ free ressources, end renderer and window
: freeRessources ( -- )
    REN0 DestroyRenderer drop
    WIN0 DestroyWindow   drop
    Quit
  ;

: main ( -- )
    initNewWindow
    draw
    begin
        key drop
    -1 until
    freeRessources
  ;

\ main





