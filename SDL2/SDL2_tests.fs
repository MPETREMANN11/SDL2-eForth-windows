\ *********************************************************************
\ SDL2 / tests
\    Filename:      SDL2_tests.fs
\    Date:          06 nov 2024
\    Updated:       06 nov 2024
\    File Version:  1.0
\    Forth:         eFORTH Windows
\    Author:        Marc PETREMANN
\    GNU General Public License
\ *********************************************************************

.( load SDL2_tests.fs )

\ order

\ test structures
assert( SDL_Color      4 = )
assert( SDL_Palette   16 = )
assert( SDL_Point      8 = )
assert( SDL_Rect      16 = )
assert( SDL_version    3 = )




