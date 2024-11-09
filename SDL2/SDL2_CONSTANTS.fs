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


\ *** Events ???

64 constant SDL_TEXTEDITINGEVENT_TEXT_SIZE


\ SDL EventType
$100 constant SDL_QUIT              \ User-requested quit

\     These application events have special meaning on iOS, see README-ios.md for details 
\     SDL_APP_TERMINATING,        \ The application is being terminated by the OS
\                                      Called on iOS in applicationWillTerminate()
\                                      Called on Android in onDestroy()
\                                 
\     SDL_APP_LOWMEMORY,          \ The application is low on memory, free memory if possible.
\                                      Called on iOS in applicationDidReceiveMemoryWarning()
\                                      Called on Android in onLowMemory()
\                                 
\     SDL_APP_WILLENTERBACKGROUND, \ The application is about to enter the background
\                                      Called on iOS in applicationWillResignActive()
\                                      Called on Android in onPause()
\                                 
\     SDL_APP_DIDENTERBACKGROUND, \ The application did enter the background and may not get CPU for some time
\                                      Called on iOS in applicationDidEnterBackground()
\                                      Called on Android in onPause()
\                                 
\     SDL_APP_WILLENTERFOREGROUND, \ The application is about to enter the foreground
\                                      Called on iOS in applicationWillEnterForeground()
\                                      Called on Android in onResume()
\                                 
\     SDL_APP_DIDENTERFOREGROUND, \ The application is now interactive
\                                      Called on iOS in applicationDidBecomeActive()
\                                      Called on Android in onResume()
\                                 
\ 
\     SDL_LOCALECHANGED,  \ The user's locale preferences have changed. 
\ 
\     Display events 
\     SDL_DISPLAYEVENT   = 0x150,  \ Display state change 
\ 
\     Window events 
$200 constant SDL_WINDOWEVENT       \ Window state change
\     SDL_SYSWMEVENT,             \ System specific event 
\ 
\ *** Keyboard events 
$300 constant SDL_KEYDOWN           \ Key pressed
$301 constant SDL_KEYUP             \ Key released
$302 constant SDL_TEXTEDITING       \ Keyboard text editing (composition)
$303 constant SDL_TEXTINPUT         \ Keyboard text input

\     
\     
\     SDL_KEYMAPCHANGED,          \ Keymap changed due to a system event such as an
\                                      input language or keyboard layout change.
\                                 
\     SDL_TEXTEDITING_EXT,       \ Extended keyboard text editing (composition) 
\ 
\     Mouse events 
\     SDL_MOUSEMOTION    = 0x400, \ Mouse moved 
\     SDL_MOUSEBUTTONDOWN,        \ Mouse button pressed 
\     SDL_MOUSEBUTTONUP,          \ Mouse button released 
\     SDL_MOUSEWHEEL,             \ Mouse wheel motion 
\ 
\     Joystick events 
\     SDL_JOYAXISMOTION  = 0x600, \ Joystick axis motion 
\     SDL_JOYBALLMOTION,          \ Joystick trackball motion 
\     SDL_JOYHATMOTION,           \ Joystick hat position change 
\     SDL_JOYBUTTONDOWN,          \ Joystick button pressed 
\     SDL_JOYBUTTONUP,            \ Joystick button released 
\     SDL_JOYDEVICEADDED,         \ A new joystick has been inserted into the system 
\     SDL_JOYDEVICEREMOVED,       \ An opened joystick has been removed 
\     SDL_JOYBATTERYUPDATED,      \ Joystick battery level change 
\ 
\     Game controller events 
\     SDL_CONTROLLERAXISMOTION  = 0x650, \ Game controller axis motion 
\     SDL_CONTROLLERBUTTONDOWN,          \ Game controller button pressed 
\     SDL_CONTROLLERBUTTONUP,            \ Game controller button released 
\     SDL_CONTROLLERDEVICEADDED,         \ A new Game controller has been inserted into the system 
\     SDL_CONTROLLERDEVICEREMOVED,       \ An opened Game controller has been removed 
\     SDL_CONTROLLERDEVICEREMAPPED,      \ The controller mapping was updated 
\     SDL_CONTROLLERTOUCHPADDOWN,        \ Game controller touchpad was touched 
\     SDL_CONTROLLERTOUCHPADMOTION,      \ Game controller touchpad finger was moved 
\     SDL_CONTROLLERTOUCHPADUP,          \ Game controller touchpad finger was lifted 
\     SDL_CONTROLLERSENSORUPDATE,        \ Game controller sensor was updated 
\     SDL_CONTROLLERUPDATECOMPLETE_RESERVED_FOR_SDL3,
\     SDL_CONTROLLERSTEAMHANDLEUPDATED,  \ Game controller Steam handle has changed 
\ 
\     Touch events 
\     SDL_FINGERDOWN      = 0x700,
\     SDL_FINGERUP,
\     SDL_FINGERMOTION,
\ 
\     Gesture events 
\     SDL_DOLLARGESTURE   = 0x800,
\     SDL_DOLLARRECORD,
\     SDL_MULTIGESTURE,
\ 
\     Clipboard events 
\     SDL_CLIPBOARDUPDATE = 0x900, \ The clipboard or primary selection changed 
\ 
\     Drag and drop events 
\     SDL_DROPFILE        = 0x1000, \ The system requests a file open 
\     SDL_DROPTEXT,                 \ text/plain drag-and-drop event 
\     SDL_DROPBEGIN,                \ A new set of drops is beginning (NULL filename) 
\     SDL_DROPCOMPLETE,             \ Current set of drops is now complete (NULL filename) 
\ 
\     Audio hotplug events 
\     SDL_AUDIODEVICEADDED = 0x1100, \ A new audio device is available 
\     SDL_AUDIODEVICEREMOVED,        \ An audio device has been removed. 
\ 
\     Sensor events 
\     SDL_SENSORUPDATE = 0x1200,     \ A sensor was updated 
\ 
\     Render events 
\     SDL_RENDER_TARGETS_RESET = 0x2000, \ The render targets have been reset and their contents need to be updated 
\     SDL_RENDER_DEVICE_RESET, \ The device has been reset and all textures need to be recreated 
\ 
\     Internal events 
\     SDL_POLLSENTINEL = 0x7F00, \ Signals the end of an event poll cycle 
\ 
\     /** Events SDL_USEREVENT through SDL_LASTEVENT are for your use,
\      *  and should be allocated with SDL_RegisterEvents()
\      
\     SDL_USEREVENT    = 0x8000,
\ 
\     /**
\      *  This last event is only for bounding internal arrays
\      
\     SDL_LASTEVENT    = 0xFFFF
\ } SDL_EventType;






\ SDL_WINDOW_INPUT_GRABBED = SDL_WINDOW_MOUSE_GRABBED \ equivalent to SDL_WINDOW_MOUSE_GRABBED for compatibility 

