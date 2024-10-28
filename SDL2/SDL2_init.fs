\ *********************************************************************
\ SDL2 / initialisation managing
\    Filename:      SDL2_init.fs
\    Date:          28 oct 2024
\    Updated:       28 oct 2024
\    File Version:  1.0
\    Forth:         eFORTH Windows & SDL2
\    Author:        Marc PETREMANN
\    GNU General Public License
\ *********************************************************************



\     SDL_Init
\     SDL_InitSubSystem
\     SDL_Quit
\     SDL_QuitSubSystem
\     SDL_WasInit



\ Initialize the SDL library
\ Returns 0 on success or a negative error code on failure; 
\ call SDL_GetError() for more information
z" SDL_Init"                1 SDL2.dll Init ( flags -- 0|err ) 



\ ***  Upper level words definitions  ******************************************

\ Initialize SDL with error management
: SDL.init ( n -- )
    z" Could not Initialize environement " SetError drop
    Init 0= if
        -1 SDL.error
    then
  ;


