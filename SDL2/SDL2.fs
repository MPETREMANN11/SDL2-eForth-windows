\ *********************************************************************
\ SDL2 / Simple DirectMedia Player for eForth
\    Filename:      SDL2.fs
\    Date:          19 oct 2024
\    Updated:       28 oct 2024
\    File Version:  1.0
\    Forth:         eFORTH Windows & SDL2
\    Author:        Marc PETREMANN
\    GNU General Public License
\ *********************************************************************

\ Source: https://wiki.libsdl.org/SDL2/CategoryAPI 

vocabulary SDL2
SDL2 definitions  windows

\ Entry point to SDL2.dll library
z" SDL2.dll" dll SDL2.dll
SDL2

\ load SDL2 library
include SDL2_CONSTANTS.fs
include SDL2_error.fs

include SDL2_init.fs
include SDL2_render.fs
include SDL2_window.fs





\ returns the SDL_AudioStatus of the audio device opened by SDL_OpenAudio
z" SDL_GetAudioStatus"      0 SDL2.dll GetAudioStatus ( -- status ) 

\ get the directory where the application was run from
z" SDL_GetBasePath"         0 SDL2.dll GetBasePath ( -- strz ) 

\ returns the total number of logical CPU cores
z" SDL_GetCPUCount"         0 SDL2.dll GetCPUCount ( -- n ) 

\ returns the active cursor or NULL if there is no mouse
z" SDL_GetCursor"           0 SDL2.dll GetCursor ( -- n ) 



\ Poll for currently pending events.
\ Returns 1 if there is a pending event or 0 if there are none available.
z" SDL_PollEvent"           0 SDL2.dll PollEvent ( -- n ) 






\ Draw a line on the current rendering target   @TODO: à tester rapidement
z" SDL_RenderDrawLine"      5 SDL2.dll RenderDrawLine ( render x1 y1 x2 y2 -- 0|err ) 



\ Draw a series of connected lines on the current rendering target   @TODO: à tester rapidement
z" SDL_RenderDrawLines"     3 SDL2.dll RenderDrawLines ( render *points count -- 0|err ) 






\ Draw a point on the current rendering target   @TODO: à tester rapidement
z" SDL_RenderDrawPoint"     3 SDL2.dll RenderDrawPoint ( render x y -- 0|err ) 

\ Draw multiple points on the current rendering target   @TODO: à tester rapidement
z" SDL_RenderDrawPoints"    3 SDL2.dll RenderDrawPoints ( render *points count -- 0|err ) 






\ Update the screen with any rendering performed since the previous call
z" SDL_RenderPresent"       1 SDL2.dll RenderPresent ( render -- ) 

\ Draw a rectangle on the current rendering target   @TODO: à tester rapidement
z" SDL_RenderDrawRect"      2 SDL2.dll RenderDrawRect ( render *rect -- 0|err ) 

\ Draw some number of rectangles on the current rendering target   @TODO: à tester rapidement
z" SDL_RenderDrawRects"     3 SDL2.dll RenderDrawRects ( render *rect count -- 0|err ) 

\ Fill a rectangle on the current rendering target with the drawing color   @TODO: à tester rapidement
z" SDL_RenderFillRect"      2 SDL2.dll RenderFillRect ( render *rect -- 0|err ) 

\ Fill a rectangle on the current rendering target with the drawing color   @TODO: à tester rapidement
z" SDL_RenderFillRects"     3 SDL2.dll RenderFillRects ( render *rects count -- 0|err ) 

\ Set the drawing scale for rendering on the current target   @TODO: à tester
z" SDL_RenderSetScale"      3 SDL2.dll RenderSetScale ( render scaleX scaleY -- ) 

\ Clean up all initialized subsystems.
z" SDL_Quit"                0 SDL2.dll Quit ( win -- ) 
\ @TODO: vérifier paramètre "parasite" laissé sur la pile....





\ ***  Upper level words definitions  ******************************************



