\ *********************************************************************
\ SDL2 / Simple DirectMedia Player for eForth
\    Filename:      SDL2.fs
\    Date:          19 oct 2024
\    Updated:       07 nov 2024
\    File Version:  1.0
\    Forth:         eFORTH Windows & SDL2
\    Author:        Marc PETREMANN
\    GNU General Public License
\ *********************************************************************


\ Source: https://wiki.libsdl.org/SDL2/CategoryAPI 



DEFINED? L, invert [IF]
\ compile 32 bits value in dictionnary
: L,  ( u -- )
    dup c,
    8 rshift dup c,
    8 rshift dup c,
    8 rshift dup c,
    drop
  ;
[THEN]

DEFINED? .( invert [IF]
-1 value COMMENT_DISPLAY
: .(   
    [char] ) parse 
    COMMENT_DISPLAY if
        type cr 
    else
        2drop
    then
  ; immediate
[THEN]

DEFINED? NULL invert [IF]
0 constant NULL
[THEN]


vocabulary SDL2
only FORTH also  windows also  structures also
SDL2 definitions

\ Entry point to SDL2.dll library
z" SDL2.dll" dll SDL2.dll
SDL2

\ load diverses tools
include dumpTool.fs             \ dump tool
include assert.fs               \ assert for tests

\ load SDL2 library
include SDL2_CONSTANTS.fs       \ contain lot of CONSTANTS
include SDL2_STRUCTURES.fs      \ contain Datas Structures
include SDL2_error_init.fs      \ manage Errors
include SDL2_events.fs          \ events operations
include SDL2_rwops.fs           \ Read/Write operations
include SDL2_images.fs          \ Contain images bindings
include SDL2_render.fs
include SDL2_surface.fs         \ Contain surfaces bindings
include SDL2_timer.fs
include SDL2_window.fs          \ Contain windows bindings

include SDL2_tests.fs           \ make many tests


\ ***  Words not tested  *******************************************************

\ returns the SDL_AudioStatus of the audio device opened by SDL_OpenAudio
z" SDL_GetAudioStatus"      0 SDL2.dll GetAudioStatus ( -- status ) 

\ get the directory where the application was run from
z" SDL_GetBasePath"         0 SDL2.dll GetBasePath ( -- strz ) 

\ returns the total number of logical CPU cores
z" SDL_GetCPUCount"         0 SDL2.dll GetCPUCount ( -- n ) 

\ returns the active cursor or NULL if there is no mouse
z" SDL_GetCursor"           0 SDL2.dll GetCursor ( -- n ) 



\ Get the code revision of SDL that is linked against your program
z" SDL_GetRevision"         0 SDL2.dll GetRevision ( -- zstr ) 


\ Get the version of SDL that is linked against your program
z" SDL_GetVersion"          1 SDL2.dll GetVersion ( *ver -- ) 



\ Use this function to compute arc cosine of x @TODO: en test
\ z" SDL_acos"          2 SDL2.dll acos ( x -- ) 



\ ***  Upper level words definitions  ******************************************

only FORTH



