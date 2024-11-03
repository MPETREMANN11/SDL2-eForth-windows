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


.( load SDL2_error_init.fs )

\ Clear any previous error message for this thread
z" SDL_ClearError"          0 SDL2.dll ClearError ( -- )

\ Retrieve a message about the last error that occurred on the current thread
z" SDL_GetError"            0 SDL2.dll GetError ( -- zstr )

\ https://wiki.libsdl.org/SDL2/SDL_GetErrorMsg
\ SDL_GetErrorMsg

\ Set the SDL error message for the current thread
z" SDL_SetError"            1 SDL2.dll SetError ( zstr -- -1 )

\ Initialize the SDL library
\ Returns 0 on success or a negative error code on failure; 
\ call SDL_GetError() for more information
z" SDL_Init"                1 SDL2.dll Init ( flags -- 0|err ) 

\ Clean up all initialized subsystems.
z" SDL_Quit"                0 SDL2.dll Quit ( -- ) 
\ @TODO: vérifier paramètre "parasite" laissé sur la pile....



\ ***  Upper level words definitions  ******************************************

\ free ressources
: SDL.Quit ( -- )
    Quit drop
  ;

\ send error message and abort if fl is not null
: SDL.error  ( fl -- )
    if
        exit
    then
    SDL.Quit
    getError z>s type
    abort
  ;

\ Initialize SDL with error management
: SDL.init ( n -- )
    z" Could not Initialize environement " SetError drop
    Init 0= if
        -1 SDL.error
    then
  ;

