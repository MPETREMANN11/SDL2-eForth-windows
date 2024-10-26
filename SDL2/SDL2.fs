\ *********************************************************************
\ SDL2 / Simple DirectMedia Player for eForth
\    Filename:      SDL2.fs
\    Date:          19 oct 2024
\    Updated:       19 oct 2024
\    File Version:  1.0
\    Forth:         eFORTH Windows
\    Author:        Marc PETREMANN
\    GNU General Public License
\ *********************************************************************

\ Source: https://wiki.libsdl.org/SDL2/CategoryAPI 

vocabulary SDL2
SDL2 definitions  windows
z" SDL2.dll" dll SDL2
SDL2

\ load SDL2 library
s" windowsFlags.fs" included



4096 constant SDL_MAX_LOG_MESSAGE       \ maximum size of a log message prior to SDL 2.0.24



\ compute arc cosine of x                               @ERROR: dont- work
\ z" SDL_acos"                1 SDL2 acos ( float:n -- n ) 





\ infos: https://wiki.libsdl.org/SDL2/SDL_CreateRenderer
\ Create a 2D rendering context for a window
z" SDL_CreateRenderer"      3 SDL2 CreateRenderer (  -- ) 

\ infos: https://wiki.libsdl.org/SDL2/SDL_CreateWindow
\ Create a window with the specified position, dimensions, and flags.
z" SDL_CreateWindow"        6 SDL2 CreateWindow ( strz x y w h fl -- win ) 




\ returns the SDL_AudioStatus of the audio device opened by SDL_OpenAudio
z" SDL_GetAudioStatus"      0 SDL2 GetAudioStatus ( -- status ) 

\ get the directory where the application was run from
z" SDL_GetBasePath"         0 SDL2 GetBasePath ( -- strz ) 

\ returns the total number of logical CPU cores
z" SDL_GetCPUCount"         0 SDL2 GetCPUCount ( -- n ) 

\ returns the active cursor or NULL if there is no mouse
z" SDL_GetCursor"           0 SDL2 GetCursor ( -- n ) 

\ Retrieve a message about the last error that occurred on the current thread
z" SDL_GetError"            1 SDL2 GetError ( n -- ) 






\ infos: https://wiki.libsdl.org/SDL2/SDL_Init
\ Initialize the SDL library
\ Returns 0 on success or a negative error code on failure; 
\ call SDL_GetError() for more information
z" SDL_Init"                1 SDL2 Init ( n -- n ) 

\ Initialize SDL with error management
: SDL.init ( n -- )
    Init
    if
        ." SDl could not intialize! SDL_Error: " getError .
    then
  ;





\ structure that defines a point                        @ERROR: don-t work ??
\ z" SDL_Point"               0 SDL2 Point ( x y -- ) 

