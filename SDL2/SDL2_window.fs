\ *********************************************************************
\ SDL2 / Windows managing
\    Filename:      SDL2_window.fs
\    Date:          28 oct 2024
\    Updated:       28 oct 2024
\    File Version:  1.0
\    Forth:         eFORTH Windows & SDL2
\    Author:        Marc PETREMANN
\    GNU General Public License
\ *********************************************************************


\ ***  SDL2 binding to window functions  ***************************************


\ Create a window with the specified position, dimensions, and flags.
z" SDL_CreateWindow"        6 SDL2.dll CreateWindow ( strz x y w h fl -- win ) 

\ Destroy a window.
z" SDL_DestroyWindow"       1 SDL2.dll DestroyWindow ( window -- ) 

\ Get the window flags
z" SDL_GetWindowFlags"      1 SDL2.dll GetWindowFlags ( window -- win-flag ) 

\ Get the size of a window in pixels, store values in variables
z" SDL_GetWindowSizeInPixels"  3 SDL2.dll GetWindowSizeInPixels ( windows addr-w addr-h -- fl ) 

\ Set the size of a window's client area
z" SDL_SetWindowSize"  3 SDL2.dll SetWindowSize ( window w h -- fl ) 

\ ***  Upper level words definitions  ******************************************

\ Create a window with the specified position, dimensions, and flags.
: SDL.CreateWindow  ( strz x y w h fl -- window )
    \ CreateWindow return 0 or windowflag
    z" Could not Create Window " SetError drop
    CreateWindow ?dup 0= if
        drop -1 SDL.error
    then
  ;

