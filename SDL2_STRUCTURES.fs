\ *********************************************************************
\ SDL2 / Simple DirectMedia Player for eForth - structures definition
\    Filename:      SD2_STRUCTURES.fs
\    Date:          28 oct 2024
\    Updated:       29 oct 2024
\    File Version:  1.0
\    Forth:         eFORTH Windows
\    Author:        Marc PETREMANN
\    GNU General Public License
\ *********************************************************************



\ ***  SDL_Color  **************************************************************

struct SDL_Color
    i8 field ->Color-r
    i8 field ->Color-g
    i8 field ->Color-b
    i8 field ->Color-a

: SDL_Color!  { r g b addr -- }
      r addr ->Color-r C!
      g addr ->Color-g C!
      b addr ->Color-b C!
    $ff addr ->Color-a C!
  ;

\ example:
\ create border-color SDL_Color allot
\   $ff $00 $00 border-color SDL_Color!


\ ***  SDL_Point  **************************************************************

struct SDL_Point
    i32 field ->Point-x
    i32 field ->Point-y

: SDL_Point!  { x y addr -- }
    x addr ->Point-x L!
    y addr ->Point-y L!
  ;

\ example:
\ create start-pos SDL_Point allot
\   25 70 start-pos SDL_Point!


\ ***  SDL_Rect  ***************************************************************

struct SDL_Rect
    i32 field ->Rect-x
    i32 field ->Rect-y
    i32 field ->Rect-w
    i32 field ->Rect-h


: SDL_Rect!  { x y w h addr -- }
    x addr ->Rect-x L!
    y addr ->Rect-y L!
    w addr ->Rect-w L!
    h addr ->Rect-h L!
  ;

\ example:
\ create ext-bord SDL_Rect allot
\   25 70 100 100 ext-bord SDL_Rect!


