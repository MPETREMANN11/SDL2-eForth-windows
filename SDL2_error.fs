\ *********************************************************************
\ SDL2 / Errors managing
\    Filename:      SDL2_error.fs
\    Date:          28 oct 2024
\    Updated:       29 oct 2024
\    File Version:  1.0
\    Forth:         eFORTH Windows & SDL2
\    Author:        Marc PETREMANN
\    GNU General Public License
\ *********************************************************************

\ Reference: https://wiki.libsdl.org/SDL2/CategoryAPI


\ Clear any previous error message for this thread
z" SDL_ClearError"          0 SDL2.dll ClearError ( -- )

\ Retrieve a message about the last error that occurred on the current thread
z" SDL_GetError"            0 SDL2.dll GetError ( -- zstr )

\ https://wiki.libsdl.org/SDL2/SDL_GetErrorMsg
\ SDL_GetErrorMsg

\ Set the SDL error message for the current thread
z" SDL_SetError"            1 SDL2.dll SetError ( zstr -- -1 )




\ ***  Upper level words definitions  ******************************************

\ send error message and abort if fl is not null
: SDL.error  ( fl -- )
    if
        exit
    then
    getError z>s type
    abort
  ;

