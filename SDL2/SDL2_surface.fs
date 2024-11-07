\ *********************************************************************
\ SDL2 / Surface
\    Filename:      SDL2_surface.fs
\    Date:          02 nov 2024
\    Updated:       02 nov 2024
\    File Version:  1.0
\    Forth:         eFORTH Windows & SDL2
\    Author:        Marc PETREMANN
\    GNU General Public License
\ *********************************************************************

.( load SDL2_surface.fs )

\ SDL_ConvertPixels
\ SDL_ConvertSurface
\ SDL_ConvertSurfaceFormat
\ SDL_CreateRGBSurface
\ SDL_CreateRGBSurfaceFrom
\ SDL_CreateRGBSurfaceWithFormat
\ SDL_CreateRGBSurfaceWithFormatFrom
\ SDL_FillRect
\ SDL_FillRects
\ SDL_GetClipRect
\ SDL_GetColorKey
\ SDL_GetSurfaceAlphaMod
\ SDL_GetSurfaceBlendMode
\ SDL_GetSurfaceColorMod
\ SDL_GetYUVConversionMode
\ SDL_GetYUVConversionModeForResolution
\ SDL_HasColorKey
\ SDL_HasSurfaceRLE
\ SDL_LockSurface
\ SDL_LowerBlit
\ SDL_LowerBlitScaled
\ SDL_PremultiplyAlpha
\ SDL_SaveBMP_RW
\ SDL_SetClipRect
\ SDL_SetColorKey
\ SDL_SetSurfaceAlphaMod
\ SDL_SetSurfaceBlendMode
\ SDL_SetSurfaceColorMod
\ SDL_SetSurfacePalette
\ SDL_SetSurfaceRLE
\ SDL_SetYUVConversionMode
\ SDL_SoftStretch
\ SDL_SoftStretchLinear
\ SDL_UnlockSurface
\ SDL_UpperBlit
\ SDL_UpperBlitScaled



\ Free an RGB surface
z" SDL_FreeSurface"         1 SDL2.dll FreeSurface ( surface -- flags ) 

\ Load a surface from a file
\ SDL_LoadBMP is a macro for SDL_LoadBMP_RW

\ Load a BMP image from a seekable SDL data stream
z" SDL_LoadBMP_RW"          2 SDL2.dll LoadBMP_RW ( *file n -- 0|surface )



\ ***  Upper level words definitions  ******************************************

: LoadBMP  ( zstr -- 0|surface )
    z" rb" RWFromFile 1 LoadBMP_RW
  ;

: SDL.load-image  ( zstr -- surface )
    LoadBMP ?dup 0= if
        drop -1 SDL.error
    then
  ;





