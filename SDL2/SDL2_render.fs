\ *********************************************************************
\ SDL2 / Events managing
\    Filename:      SDL2_events.fs
\    Date:          28 oct 2024
\    Updated:       28 oct 2024
\    File Version:  1.0
\    Forth:         eFORTH Windows & SDL2
\    Author:        Marc PETREMANN
\    GNU General Public License
\ *********************************************************************


\ ***  SDL2 binding to render functions  ***************************************

\ infos: https://wiki.libsdl.org/SDL2/SDL_CreateRenderer
\ Create a 2D rendering context for a window
z" SDL_CreateRenderer"      3 SDL2.dll CreateRenderer (  -- render ) 

\ Destroy the rendering context for a window and free associated textures
z" SDL_DestroyRenderer"     1 SDL2.dll DestroyRenderer ( render -- fl ) 

\ Clear the current rendering target with the drawing color
z" SDL_RenderClear"         1 SDL2.dll RenderClear ( render -- 0|err ) 

\ Set the color used for drawing operations (Rect, Line and Clear)
z" SDL_SetRenderDrawColor"  5 SDL2.dll SetRenderDrawColor ( renderer r g b a -- fl ) 

