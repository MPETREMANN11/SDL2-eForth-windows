\ *********************************************************************
\ SDL2 / Events managing
\    Filename:      SDL2_events.fs
\    Date:          29 oct 2024
\    Updated:       29 oct 2024
\    File Version:  1.0
\    Forth:         eFORTH Windows & SDL2
\    Author:        Marc PETREMANN
\    GNU General Public License
\ *********************************************************************

.( load SDL2_events.fs )

\ SDL_PeepEvents ( events* n action min max -- n )
\ SDL_HasEvents ( min max -- flag )
\ SDL_FlushEvent ( type -- )
\ SDL_FlushEvents ( min max -- )
\ SDL_WaitEventTimeout ( event timeout -- n )
\ SDL_PushEvent ( event -- flag )
\ SDL_SetEventFilter ( xt data -- )
\ SDL_GetEventFilter ( xt  data* -- flag )
\ SDL_AddEventWatch ( xt data -- )
\ SDL_DelEventWatch ( xt data -- )
\ SDL_FilterEvents ( xt data -- )
\ SDL_RegisterEvents ( n -- n )




\ Set the state of processing events by type  @TODO: à vérifier rapidement
z" SDL_EventState"          2 SDL2.dll EventState ( type state -- status ) 

\ Check for the existence of a certain event type in the event queue  @TODO: à vérifier rapidement
z" SDL_HasEvent"          0 SDL2.dll HasEvent ( type -- FALSE|TRUE ) 

\ Poll for currently pending events
z" SDL_PollEvent"           1 SDL2.dll PollEvent ( event -- 0|1 ) 

\ Pump the event loop, gathering events from the input devices  @TODO: à vérifier rapidement
z" SDL_PumpEvents"          0 SDL2.dll PumpEvents ( -- ) 

\ Wait indefinitely for the next available event  @TODO: à vérifier rapidement
z" SDL_WaitEvent"           1 SDL2.dll WaitEvent ( event -- 0|1 ) 


