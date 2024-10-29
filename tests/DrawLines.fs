\ *********************************************************************
\ SDL2 / tests
\    Filename:      DrawLines.fs
\    Date:          29 oct 2024
\    Updated:       29 oct 2024
\    File Version:  1.0
\    Forth:         eFORTH Windows & SDL2
\    Author:        Marc PETREMANN
\    GNU General Public License
\ *********************************************************************


forth definitions
SDL2

: drawLines ( -- )
    \ window BG black
    REN0 0 0 0 255 SetRenderDrawColor drop
    REN0 RenderClear drop
    REN0 RenderPresent drop

    \ color to white - draw simple line
    REN0 255 255 255 255 SetRenderDrawColor drop
    REN0 10 20 1200 45 RenderDrawLine drop
    REN0 1200 45 10 100 RenderDrawLine drop
    REN0 RenderPresent drop

  ;


: main ( -- )
    initEnvironement
    initNewWindow
    drawLines
    begin
        key drop
    -1 until
    freeRessources
  ;

\ main

