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
s" SDLconstants.fs" included



4096 constant SDL_MAX_LOG_MESSAGE       \ maximum size of a log message prior to SDL 2.0.24



\ compute arc cosine of x                                       @ERROR: dont- work
\ z" SDL_acos"                1 SDL2 acos ( float:n -- n ) 





\ infos: https://wiki.libsdl.org/SDL2/SDL_CreateRenderer
\ Create a 2D rendering context for a window
z" SDL_CreateRenderer"      3 SDL2 CreateRenderer (  -- render ) 

\ infos: https://wiki.libsdl.org/SDL2/SDL_CreateWindow
\ Create a window with the specified position, dimensions, and flags.
z" SDL_CreateWindow"        6 SDL2 CreateWindow ( strz x y w h fl -- win ) 

\ Destroy the rendering context for a window and free associated textures
z" SDL_DestroyRenderer"     1 SDL2 DestroyRenderer ( render -- ) 

\ Destroy a window.
z" SDL_DestroyWindow"       1 SDL2 DestroyWindow ( window -- ) 

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
z" SDL_Init"                1 SDL2 Init ( n -- 0|err ) 


\ \ structure that defines a point                        @ERROR: don-t work ??
\ \ z" SDL_Point"               0 SDL2 Point ( x y -- ) 


\ Poll for currently pending events.
\ Returns 1 if there is a pending event or 0 if there are none available.
z" SDL_PollEvent"           0 SDL2 PollEvent ( -- n ) 

\ Clear the current rendering target with the drawing color
z" SDL_RenderClear"                1 SDL2 RenderClear ( render -- 0|err ) 

\ Update the screen with any rendering performed since the previous call
z" SDL_RenderPresent"       1 SDL2 RenderPresent ( render -- ) 

\ Clean up all initialized subsystems.
z" SDL_Quit"                0 SDL2 Quit ( win -- ) 

\ Set the color used for drawing operations (Rect, Line and Clear)
z" SDL_SetRenderDrawColor"  5 SDL2 SetRenderDrawColor ( renderer r g b a -- fl ) 



\ ***  Upper level words definitions  ******************************************

\ Initialize SDL with error management
: SDL.init ( n -- )
    Init
    if
        ." SDl could not intialize! SDL_Error: " getError .
    then
  ;

\ Create a window with the specified position, dimensions, and flags.
: SDL.CreateWindow  ( strz x y w h fl -- win )
    CreateWindow ?dup 0=
    if
        ." Window could not be created! SDL_Error: " getError .
    then
  ;


