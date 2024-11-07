\ *********************************************************************
\ SDL2 / Surface
\    Filename:      SDL2_surface.fs
\    Date:          06 nov 2024
\    Updated:       06 nov 2024
\    File Version:  1.0
\    Forth:         eFORTH Windows & SDL2
\    Author:        Marc PETREMANN
\    GNU General Public License
\ *********************************************************************

.( load SDL2_rwops.fs )

\ SDL_AllocRW
\ SDL_FreeRW
\ SDL_LoadFile
\ SDL_LoadFile_RW
\ SDL_ReadBE16
\ SDL_ReadBE32
\ SDL_ReadBE64
\ SDL_ReadLE16
\ SDL_ReadLE32
\ SDL_ReadLE64
\ SDL_ReadU8
\ SDL_RWclose
\ SDL_RWFromConstMem
\ SDL_RWFromFP
\ SDL_RWFromMem
\ SDL_RWread
\ SDL_RWseek
\ SDL_RWsize
\ SDL_RWtell
\ SDL_RWwrite
\ SDL_WriteBE16
\ SDL_WriteBE32
\ SDL_WriteBE64
\ SDL_WriteLE16
\ SDL_WriteLE32
\ SDL_WriteLE64
\ SDL_WriteU8


\ Use this function to create a new SDL_RWops structure 
\ for reading from and/or writing to a named file
z" SDL_RWFromFile"          2 SDL2.dll RWFromFile ( file mode -- n )

