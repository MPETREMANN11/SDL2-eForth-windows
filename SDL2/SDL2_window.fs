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


.( load SDL2_window.fs )

\ Info: https://wiki.libsdl.org/SDL2/CategoryVideo

\ ***  SDL2 binding to window functions  ***************************************


\ Create a window with the specified position, dimensions, and flags.
z" SDL_CreateWindow"        6 SDL2.dll CreateWindow ( strz x y w h fl -- win ) 

\ Destroy a window.
z" SDL_DestroyWindow"       1 SDL2.dll DestroyWindow ( window -- ) 

\ Get the window flags
z" SDL_GetWindowFlags"      1 SDL2.dll GetWindowFlags ( window -- fl ) 

\ Get the size of a window in pixels, store values in variables
z" SDL_GetWindowSizeInPixels"  3 SDL2.dll GetWindowSizeInPixels ( windows addr-w addr-h -- fl ) 

\ Hide a window
z" SDL_HideWindow"          1 SDL2.dll HideWindow ( windows -- fl ) 

\ Make a window as large as possible
z" SDL_MaximizeWindow"      1 SDL2.dll MaximizeWindow ( window -- fl ) 

\ Minimize a window to an iconic representation
z" SDL_MinimizeWindow"      1 SDL2.dll MinimizeWindow ( window -- fl ) 

\ Raise a window above other windows and set the input focus
z" SDL_RaiseWindow"         1 SDL2.dll RaiseWindow ( windows -- fl ) 

\ Restore the size and position of a minimized or maximized window
z" SDL_RestoreWindow"       1 SDL2.dll RestoreWindow ( windows -- fl ) 

\ Set the size of a window's client area
z" SDL_SetWindowSize"       3 SDL2.dll SetWindowSize ( window w h -- fl ) 

\ Show a window
z" SDL_ShowWindow"          1 SDL2.dll ShowWindow ( windows -- fl ) 









\ ***  Upper level words definitions  ******************************************

\ Create a window with the specified position, dimensions, and flags.
: SDL.CreateWindow  ( strz x y w h fl -- window )
    \ CreateWindow return 0 or windowflag
    z" Could not Create Window " SetError drop
    CreateWindow ?dup 0= if
        drop -1 SDL.error
    then
  ;

