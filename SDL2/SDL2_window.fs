\ *********************************************************************
\ SDL2 / Windows managing
\    Filename:      SDL2_window.fs
\    Date:          28 oct 2024
\    Updated:       05 nov 2024
\    File Version:  1.0
\    Forth:         eFORTH Windows & SDL2
\    Author:        Marc PETREMANN
\    GNU General Public License
\ *********************************************************************


.( load SDL2_window.fs )

\ SDL_CreateWindowFrom
\ SDL_DestroyWindowSurface
\ SDL_DisableScreenSaver
\ SDL_EnableScreenSaver
\ SDL_FlashWindow
\ SDL_GetClosestDisplayMode
\ SDL_GetCurrentDisplayMode
\ SDL_GetCurrentVideoDriver
\ SDL_GetDesktopDisplayMode
\ SDL_GetDisplayBounds
\ SDL_GetDisplayDPI
\ SDL_GetDisplayMode
\ SDL_GetDisplayName
\ SDL_GetDisplayOrientation
\ SDL_GetDisplayUsableBounds
\ SDL_GetGrabbedWindow
\ SDL_GetNumDisplayModes
\ SDL_GetNumVideoDisplays
\ SDL_GetNumVideoDrivers
\ SDL_GetPointDisplayIndex
\ SDL_GetRectDisplayIndex
\ SDL_GetVideoDriver
\ SDL_GetWindowBordersSize
\ SDL_GetWindowBrightness
\ SDL_GetWindowData
\ SDL_GetWindowDisplayIndex
\ SDL_GetWindowDisplayMode
\ SDL_GetWindowFromID
\ SDL_GetWindowGammaRamp
\ SDL_GetWindowGrab
\ SDL_GetWindowICCProfile
\ SDL_GetWindowKeyboardGrab
\ SDL_GetWindowMaximumSize
\ SDL_GetWindowMinimumSize
\ SDL_GetWindowMouseGrab
\ SDL_GetWindowMouseRect
\ SDL_GetWindowOpacity
\ SDL_GetWindowPixelFormat
\ SDL_GetWindowPosition
\ SDL_GetWindowSize
\ SDL_GetWindowSizeInPixels
\ SDL_GetWindowSurface
\ SDL_GetWindowTitle
\ SDL_GL_CreateContext
\ SDL_GL_DeleteContext
\ SDL_GL_ExtensionSupported
\ SDL_GL_GetAttribute
\ SDL_GL_GetCurrentContext
\ SDL_GL_GetCurrentWindow
\ SDL_GL_GetDrawableSize
\ SDL_GL_GetProcAddress
\ SDL_GL_GetSwapInterval
\ SDL_GL_LoadLibrary
\ SDL_GL_MakeCurrent
\ SDL_GL_ResetAttributes
\ SDL_GL_SetAttribute
\ SDL_GL_SetSwapInterval
\ SDL_GL_SwapWindow
\ SDL_GL_UnloadLibrary
\ SDL_HasWindowSurface
\ SDL_IsScreenSaverEnabled
\ SDL_SetWindowAlwaysOnTop
\ SDL_SetWindowBordered
\ SDL_SetWindowBrightness
\ SDL_SetWindowData
\ SDL_SetWindowDisplayMode
\ SDL_SetWindowFullscreen
\ SDL_SetWindowGammaRamp
\ SDL_SetWindowGrab
\ SDL_SetWindowHitTest
\ SDL_SetWindowIcon
\ SDL_SetWindowInputFocus
\ SDL_SetWindowKeyboardGrab
\ SDL_SetWindowMaximumSize
\ SDL_SetWindowMinimumSize
\ SDL_SetWindowModalFor
\ SDL_SetWindowMouseGrab
\ SDL_SetWindowMouseRect
\ SDL_SetWindowOpacity
\ SDL_SetWindowPosition
\ SDL_SetWindowResizable
\ SDL_ShowWindow
\ SDL_UpdateWindowSurface
\ SDL_UpdateWindowSurfaceRects
\ SDL_VideoInit
\ SDL_VideoQuit

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

\ Set the icon for a window
z" SDL_SetWindowIcon"       2 SDL2.dll SetWindowIcon ( window icon -- 0|err ) 

\ Set the size of a window's client area
z" SDL_SetWindowSize"       3 SDL2.dll SetWindowSize ( window w h -- fl ) 

\ Set the title of a window
z" SDL_SetWindowTitle"      2 SDL2.dll SetWindowTitle ( window title -- fl ) 

\ Show a window
z" SDL_ShowWindow"          1 SDL2.dll ShowWindow ( windows -- fl ) 



\ xxxxxx @TODO à tester rapidement
z" SDL_GetWindowID"         1 SDL2.dll GetWindowID ( window -- 0|id ) 



\ Get the position of a window @TODO à tester rapidement
z" SDL_GetWindowPosition"   3 SDL2.dll GetWindowPosition ( window *x *y -- 0|err ) 

\ Set the position of a window @TODO à tester rapidement
z" SDL_SetWindowPosition"   3 SDL2.dll SetWindowPosition ( window x y -- 0|err ) 

\ Get the title of a window @TODO à tester rapidement
z" SDL_GetWindowTitle"      1 SDL2.dll GetWindowTitle ( window -- char* ) 










\ ***  Upper level words definitions  ******************************************

\ Create a window with the specified position, dimensions, and flags.
: SDL.CreateWindow  ( strz x y w h fl -- window )
    \ CreateWindow return 0 or windowflag
    z" Could not Create Window " SetError drop
    CreateWindow ?dup 0= if
        drop -1 SDL.error
    then
  ;

