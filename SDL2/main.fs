\ *********************************************************************
\ SDL2 / Simple DirectMedia Player for eForth
\    Filename:      main.fs
\    Date:          19 oct 2024
\    Updated:       29 oct 2024
\    File Version:  1.0
\    Forth:         eFORTH Windows
\    Author:        Marc PETREMANN
\    GNU General Public License
\ *********************************************************************


\ load SDL2 library
s" SDL2.fs"     included

\ load SDL2 tests
s" tests/CreateWindow.fs"    included

\ load SDL2 tests
s" tests/DrawLines.fs"    included
