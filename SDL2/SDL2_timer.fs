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

.( load SDL2_timer.fs )

\ All timer words
\     SDL_AddTimer
\     SDL_GetPerformanceCounter
\     SDL_GetPerformanceFrequency
\     SDL_RemoveTimer


\ Wait a specified number of milliseconds before returning
z" SDL_Delay"               1 SDL2.dll Delay ( ms -- fl ) 

\ Get the number of milliseconds since SDL library initialization  @TODO à tester
z" SDL_GetTicks"            0 SDL2.dll GetTicks ( -- ms ) 

\ Get the number of milliseconds since SDL library initialization  @TODO à tester
z" SDL_GetTicks64"          0 SDL2.dll GetTicks64 ( -- ms ) 









