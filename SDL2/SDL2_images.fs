\ *********************************************************************
\ SDL2 / images
\    Filename:      SDL2_images.fs
\    Date:          03 nov 2024
\    Updated:       03 nov 2024
\    File Version:  1.0
\    Forth:         eFORTH Windows & SDL2
\    Author:        Marc PETREMANN
\    GNU General Public License
\ *********************************************************************


.( load SDL2_images.fs )

\ Load a surface from a file
\ SDL_LoadBMP is a macro for SDL_LoadBMP_RW


\ Load a BMP image from a seekable SDL data stream
z" SDL_LoadBMP_RW"          2 SDL2.dll LoadBMP_RW ( *file n -- 0|surface )

\ Use this function to create a new SDL_RWops structure 
\ for reading from and/or writing to a named file
z" SDL_RWFromFile"          2 SDL2.dll RWFromFile ( file mode -- n )


\ ***  Upper level words definitions  ******************************************

: LoadBMP  ( zstr -- 0|surface )
    z" rb" RWFromFile 1 LoadBMP_RW
  ;

: SDL.load-image  ( zstr -- surface )
    LoadBMP ?dup 0= if
        drop -1 SDL.error
    then
  ;


