\ *********************************************************************
\ SDL2 / tests
\    Filename:      LoadBMP.fs
\    Date:          03 nov 2024
\    Updated:       03 nov 2024
\    File Version:  1.0
\    Forth:         eFORTH Windows & SDL2
\    Author:        Marc PETREMANN
\    GNU General Public License
\ *********************************************************************



.( load loadBMP.fs )


forth definitions
SDL2 also
SDL_structures


z" SDL2/logo01.bmp"     constant ZFILE
\ z" r"                   constant ZMODE
ZFILE ZMODE RWFromFile SDL.error

    
: init-window ( -- )
    \ window BG white
    REN0 255 255 255 255 SetRenderDrawColor drop
    REN0 RenderClear drop
    REN0 RenderPresent drop
  ;


0 value IMAGE01

: main ( -- )
    initEnvironement
    initNewWindow
    ZFILE SDL.load-image to IMAGE01
    begin
        key drop
        \ 2000 Delay
    -1 until
    freeRessources
  ;

\ main

