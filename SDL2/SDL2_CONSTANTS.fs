\ *********************************************************************
\ SDL2 / Simple DirectMedia Player for eForth - constants definition
\    Filename:      SDLconstants.fs
\    Date:          24 oct 2024
\    Updated:       27 oct 2024
\    File Version:  1.0
\    Forth:         eFORTH Windows
\    Author:        Marc PETREMANN
\    GNU General Public License
\ *********************************************************************

\ infos:
\ https://github.com/PixelsuftJS/minsdl2js/blob/86aca43794bd670ae9c180d7f8a97820e42ea84e/sdl2.js#L18


.( load SDL2_CONSTANTS.fs )

4096 constant SDL_MAX_LOG_MESSAGE       \ maximum size of a log message prior to SDL 2.0.24


\ ***  ALPHA channel  **********************************************************

255 constant SDL_ALPHA_OPAQUE
0   constant SDL_ALPHA_TRANSPARENT



\ ***  INIT  *******************************************************************

$00000001 constant SDL_INIT_TIMER          \ timer subsystem
$00000010 constant SDL_INIT_AUDIO          \ audio subsystem
$00000020 constant SDL_INIT_VIDEO          \ video subsystem; automatically initializes the events subsystem
$00000200 constant SDL_INIT_JOYSTICK       \ joystick subsystem; automatically initializes the events subsystem
$00001000 constant SDL_INIT_HAPTIC         \ haptic (force feedback) subsystem
$00002000 constant SDL_INIT_GAMECONTROLLER \ controller subsystem; automatically initializes the joystick subsystem
$00004000 constant SDL_INIT_EVENTS         \ events subsystem
$00008000 constant SDL_INIT_SENSOR
$00100000 constant SDL_INIT_NOPARACHUTE
$0000F231 constant SDL_INIT_EVERYTHING


\ ***  WINDOW  *****************************************************************

$0001 constant SDL_WINDOW_FULLSCREEN        \ fullscreen window
$0002 constant SDL_WINDOW_OPENGL            \ window usable with OpenGL context 
$0004 constant SDL_WINDOW_SHOWN             \ window is visible 
$0008 constant SDL_WINDOW_HIDDEN            \ window is not visible 
$0010 constant SDL_WINDOW_BORDERLESS        \ no window decoration 
$0020 constant SDL_WINDOW_RESIZABLE         \ window can be resized 
$0040 constant SDL_WINDOW_MINIMIZED         \ window is minimized 
$0080 constant SDL_WINDOW_MAXIMIZED         \ window is maximized 
$0100 constant SDL_WINDOW_MOUSE_GRABBED     \ window has grabbed mouse input 
$0200 constant SDL_WINDOW_INPUT_FOCUS       \ window has input focus 
$0400 constant SDL_WINDOW_MOUSE_FOCUS       \ window has mouse focus 
SDL_WINDOW_FULLSCREEN $1000 or 
      constant SDL_WINDOW_FULLSCREEN_DESKTOP
$0800 constant SDL_WINDOW_FOREIGN           \ window not created by SDL 
$2000 constant SDL_WINDOW_ALLOW_HIGHDPI     \ window should be created in high-DPI mode if supported.

$00004000 constant SDL_WINDOW_MOUSE_CAPTURE \ window has mouse captured (unrelated to MOUSE_GRABBED) 
$00008000 constant SDL_WINDOW_ALWAYS_ON_TOP \ window should always be above others 
$00010000 constant SDL_WINDOW_SKIP_TASKBAR  \ window should not be added to the taskbar 
$00020000 constant SDL_WINDOW_UTILITY       \ window should be treated as a utility window 
$00040000 constant SDL_WINDOW_TOOLTIP       \ window should be treated as a tooltip 
$00080000 constant SDL_WINDOW_POPUP_MENU    \ window should be treated as a popup menu 
$00100000 constant SDL_WINDOW_KEYBOARD_GRABBED \ window has grabbed keyboard input 
$10000000 constant SDL_WINDOW_VULKAN        \ window usable for Vulkan surface 
$20000000 constant SDL_WINDOW_METAL         \ window usable for Metal view 

\ SDL_WINDOW_INPUT_GRABBED = SDL_WINDOW_MOUSE_GRABBED \ equivalent to SDL_WINDOW_MOUSE_GRABBED for compatibility 

