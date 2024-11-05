\ *********************************************************************
\ SDL2 / Render managing
\    Filename:      SDL2_render.fs
\    Date:          29 oct 2024
\    Updated:       05 nov 2024
\    File Version:  1.0
\    Forth:         eFORTH Windows & SDL2
\    Author:        Marc PETREMANN
\    GNU General Public License
\ *********************************************************************

.( load SDL2_render.fs )

\ @TODO - binding and tests
\ SDL_CreateSoftwareRenderer
\ SDL_CreateTexture
\ SDL_CreateWindowAndRenderer
\ SDL_DestroyTexture
\ SDL_GetRenderDrawBlendMode
\ SDL_GetRenderDrawColor
\ SDL_GetRenderDriverInfo
\ SDL_GetRenderer
\ SDL_GetRendererInfo
\ SDL_GetRendererOutputSize
\ SDL_GetRenderTarget
\ SDL_GetTextureAlphaMod
\ SDL_GetTextureBlendMode
\ SDL_GetTextureColorMod
\ SDL_GetTextureScaleMode
\ SDL_GetTextureUserData
\ SDL_GL_BindTexture
\ SDL_GL_UnbindTexture
\ SDL_LockTexture
\ SDL_LockTextureToSurface
\ SDL_QueryTexture
\ SDL_RenderCopyEx
\ SDL_RenderCopyExF
\ SDL_RenderCopyF
\ SDL_RenderFillRects
\ SDL_RenderFlush
\ SDL_RenderGeometry
\ SDL_RenderGeometryRaw
\ SDL_RenderGetClipRect
\ SDL_RenderGetIntegerScale
\ SDL_RenderGetLogicalSize
\ SDL_RenderGetMetalCommandEncoder
\ SDL_RenderGetMetalLayer
\ SDL_RenderGetScale
\ SDL_RenderGetViewport
\ SDL_RenderGetWindow
\ SDL_RenderIsClipEnabled
\ SDL_RenderLogicalToWindow
\ SDL_RenderReadPixels
\ SDL_RenderSetClipRect
\ SDL_RenderSetIntegerScale
\ SDL_RenderSetViewport
\ SDL_RenderSetVSync
\ SDL_RenderTargetSupported
\ SDL_RenderWindowToLogical
\ SDL_SetRenderDrawBlendMode
\ SDL_SetRenderTarget
\ SDL_SetTextureAlphaMod
\ SDL_SetTextureBlendMode
\ SDL_SetTextureColorMod
\ SDL_SetTextureScaleMode
\ SDL_SetTextureUserData
\ SDL_UnlockTexture
\ SDL_UpdateNVTexture
\ SDL_UpdateTexture
\ SDL_UpdateYUVTexture



\ ***  SDL2 binding to render functions  ***************************************

\ Create a 2D rendering context for a window
z" SDL_CreateRenderer"      3 SDL2.dll CreateRenderer (  -- render ) 

\ Create a texture from an existing surface
z" SDL_CreateTextureFromSurface"   2 SDL2.dll CreateTextureFromSurface ( render surface -- 0|texture ) 

\ Destroy the rendering context for a window and free associated textures
z" SDL_DestroyRenderer"     1 SDL2.dll DestroyRenderer ( render -- fl ) 

\ Get the number of 2D rendering drivers available for the current display
z" SDL_GetNumRenderDrivers"        0 SDL2.dll GetNumRenderDrivers ( -- n|err ) 

\ Clear the current rendering target with the drawing color
z" SDL_RenderClear"         1 SDL2.dll RenderClear ( render -- 0|err ) 

\ Copy a portion of the texture to the current rendering target
z" SDL_RenderCopy"          4 SDL2.dll RenderCopy ( render texture srcrect dstrect -- 0|err ) 

\ Copy a portion of the texture to the current rendering, with optional rotation and flipping
z" SDL_RenderCopyEx"        7 SDL2.dll RenderCopyEx ( render texture srcrect dstrect angle center flip -- 0|err ) 

\ Set the color used for drawing operations (Rect, Line and Clear)
z" SDL_SetRenderDrawColor"  5 SDL2.dll SetRenderDrawColor ( renderer r g b a -- 0|err ) 

\ Draw a line on the current rendering target
z" SDL_RenderDrawLine"      5 SDL2.dll RenderDrawLine ( render x1 y1 x2 y2 -- 0|err ) 

\ Draw a series of connected lines on the current rendering target
z" SDL_RenderDrawLines"     3 SDL2.dll RenderDrawLines ( render *points count -- 0|err ) 

\ Draw a point on the current rendering target
z" SDL_RenderDrawPoint"     3 SDL2.dll RenderDrawPoint ( render x y -- 0|err ) 

\ Draw a rectangle on the current rendering target
z" SDL_RenderDrawRect"      2 SDL2.dll RenderDrawRect ( render *rect -- 0|err ) 

\ Draw some number of rectangles on the current rendering target
z" SDL_RenderDrawRects"     3 SDL2.dll RenderDrawRects ( render *rect count -- 0|err ) 

\ Fill a rectangle on the current rendering target with the drawing color
z" SDL_RenderFillRect"      2 SDL2.dll RenderFillRect ( render *rect -- 0|err ) 

\ Fill a rectangle on the current rendering target with the drawing color   @TODO: à tester rapidement
z" SDL_RenderFillRects"     3 SDL2.dll RenderFillRects ( render *rects count -- 0|err ) 

\ Get device independent resolution for rendering
z" SDL_RenderGetLogicalSize"     3 SDL2.dll RenderGetLogicalSize ( render *w *h -- 0|err ) 

\ Update the screen with any rendering performed since the previous call
z" SDL_RenderPresent"       1 SDL2.dll RenderPresent ( render -- ) 

\ Set whether to force integer scales for resolution-independent rendering   @TODO: à tester
\ z" SDL_RenderSetIntegerScale"      2 SDL2.dll RenderSetIntegerScale ( render senable -- 0|err ) 

\ Set a device independent resolution for rendering
z" SDL_RenderSetLogicalSize"      3 SDL2.dll RenderSetLogicalSize ( render w h -- 0|err ) 

\ Set the drawing scale for rendering on the current target   @TODO: à tester
\ z" SDL_RenderSetScale"      3 SDL2.dll RenderSetScale ( render scaleX scaleY -- 0|err ) 







\ Draw multiple points on the current rendering target   @TODO: à tester rapidement
z" SDL_RenderDrawPoints"    3 SDL2.dll RenderDrawPoints ( render *points count -- 0|err ) 





\ Destroy the specified texture    @TODO: à tester
z" SDL_DestroyTexture"        1 SDL2.dll DestroyTexture ( texture -- n|err ) 









