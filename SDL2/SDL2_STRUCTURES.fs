\ *********************************************************************
\ SDL2 / Simple DirectMedia Player for eForth - structures definition
\    Filename:      SD2_STRUCTURES.fs
\    Date:          28 oct 2024
\    Updated:       29 oct 2024
\    File Version:  1.0
\    Forth:         eFORTH Windows
\    Author:        Marc PETREMANN
\    GNU General Public License
\ *********************************************************************


.( load SDL2_STRUCTURES.fs )


vocabulary SDL_structures
SDL_structures definitions


struct SDL_Color
     i8 field ->Color-r
     i8 field ->Color-g
     i8 field ->Color-b
     i8 field ->Color-a

struct SDL_Palette
    i32 field ->Palette-ncolors
    SDL_Color field ->Palette-colors
    i32 field ->Palette-version
    i32 field ->Palette-refcount

struct SDL_PixelFormat
    i32 field ->PixelFormat-format
    SDL_Palette field ->PixelFormat-Palette
\ @TODO à vérifier, grosse confusion entre différentes sources
     i8 field ->PixelFormat-Bshift
    i32 field ->PixelFormat-refcount
    i32 field ->PixelFormat-Gmask
     i8 field ->PixelFormat-Gloss
    i32 field ->PixelFormat-format
    i32 field ->PixelFormat-Bmask
    i32 field ->PixelFormat-Amask
    i32 field ->PixelFormat-Rmask
    i64 field ->PixelFormat-palette
     i8 field ->PixelFormat-Bloss
     i8 field ->PixelFormat-Gshift
     i8 field ->PixelFormat-Aloss
     i8 field ->PixelFormat-BytesPerPixel
     i8 field ->PixelFormat-BitsPerPixel
     i8 field ->PixelFormat-Rloss
    i64 field ->PixelFormat-next
    i16 field ->PixelFormat-padding
     i8 field ->PixelFormat-Rshift
     i8 field ->PixelFormat-Ashift

struct SDL_Point
    i32 field ->Point-x
    i32 field ->Point-y

struct SDL_Rect
    i32 field ->Rect-x
    i32 field ->Rect-y
    i32 field ->Rect-w
    i32 field ->Rect-h

: ->SDL_Rect { item addr0 -- addr1 }
    SDL_Rect item * addr0 +
  ;










\ *** SDL event  ***************************************************************

struct SDL_CommonEvent
     i32 field ->CommonEvent-type
     i32 field ->CommonEvent-timestamp  \ In milliseconds, populated using GetTicks


\ ** original C Code for SDL_EVENT version SDL2
\ /**
\  *  \brief General event structure
\  */
\ typedef union SDL_Event
\ {
\     Uint32 type;                    /**< Event type, shared with all events */
\     SDL_GenericEvent generic;       /**< Generic event data */
\     SDL_WindowEvent window;         /**< Window event data */
\     SDL_KeyboardEvent key;          /**< Keyboard event data */
\     SDL_TextEditingEvent edit;      /**< Text editing event data */
\     SDL_TextInputEvent text;        /**< Text input event data */
\     SDL_MouseMotionEvent motion;    /**< Mouse motion event data */
\     SDL_MouseButtonEvent button;    /**< Mouse button event data */
\     SDL_MouseWheelEvent wheel;      /**< Mouse wheel event data */
\     SDL_JoyAxisEvent jaxis;         /**< Joystick axis event data */
\     SDL_JoyBallEvent jball;         /**< Joystick ball event data */
\     SDL_JoyHatEvent jhat;           /**< Joystick hat event data */
\     SDL_JoyButtonEvent jbutton;     /**< Joystick button event data */
\     SDL_JoyDeviceEvent jdevice;     /**< Joystick device change event data */
\ 	SDL_ControllerAxisEvent caxis;		/**< Game Controller axis event data */
\ 	SDL_ControllerButtonEvent cbutton;  /**< Game Controller button event data */
\ 	SDL_ControllerDeviceEvent cdevice;  /**< Game Controller device event data */
\     SDL_QuitEvent quit;             /**< Quit request event data */
\     SDL_UserEvent user;             /**< Custom event data */
\     SDL_SysWMEvent syswm;           /**< System dependent window event data */
\     SDL_TouchFingerEvent tfinger;   /**< Touch finger event data */
\     SDL_MultiGestureEvent mgesture; /**< Gesture event data */
\     SDL_DollarGestureEvent dgesture; /**< Gesture event data */
\     SDL_DropEvent drop;             /**< Drag and drop event data */
\ 
\     /* This is necessary for ABI compatibility between Visual C++ and GCC
\        Visual C++ will respect the push pack pragma and use 52 bytes for
\        this structure, and GCC will use the alignment of the largest datatype
\        within the union, which is 8 bytes.
\ 
\        So... we'll add padding to force the size to be 56 bytes for both.
\     */
\     Uint8 padding[56];
\ } SDL_Event;


\ union SDL_Event
struct SDL_Event
                       i32 field ->Event-type
\ 	drop 0 56 bytes: SDL_Event-padding
\ 	drop 0 SDL_CommonEvent bytes:				SDL_Event-common
\ 	drop 0 SDL_DisplayEvent bytes:				SDL_Event-display
\ 	drop 0 SDL_WindowEvent bytes:				SDL_Event-window
\ 	drop 0 SDL_KeyboardEvent bytes:				SDL_Event-key
\ 	drop 0 SDL_TextEditingEvent bytes:			SDL_Event-edit
\ 	drop 0 SDL_TextEditingExtEvent bytes:		SDL_Event-editExt
\ 	drop 0 SDL_TextInputEvent bytes:			SDL_Event-text
\ 	drop 0 SDL_MouseMotionEvent bytes:			SDL_Event-motion
\ 	drop 0 SDL_MouseButtonEvent bytes:			SDL_Event-button
\ 	drop 0 SDL_MouseWheelEvent bytes:			SDL_Event-wheel
\ 	drop 0 SDL_JoyAxisEvent bytes:				SDL_Event-jaxis
\ 	drop 0 SDL_JoyBallEvent bytes:				SDL_Event-jball
\ 	drop 0 SDL_JoyHatEvent bytes:				SDL_Event-jhat
\ 	drop 0 SDL_JoyButtonEvent bytes:			SDL_Event-jbutton
\ 	drop 0 SDL_JoyDeviceEvent bytes:			SDL_Event-jdevice
\ 	drop 0 SDL_JoyBatteryEvent bytes:			SDL_Event-jbattery
\ 	drop 0 SDL_ControllerAxisEvent bytes:		SDL_Event-caxis
\ 	drop 0 SDL_ControllerButtonEvent bytes:		SDL_Event-cbutton
\ 	drop 0 SDL_ControllerDeviceEvent bytes:		SDL_Event-cdevice
\ 	drop 0 SDL_ControllerTouchpadEvent bytes:	SDL_Event-ctouchpad
\ 	drop 0 SDL_ControllerSensorEvent bytes:		SDL_Event-csensor
\ 	drop 0 SDL_AudioDeviceEvent bytes:			SDL_Event-adevice
\ 	drop 0 SDL_TouchFingerEvent bytes:			SDL_Event-tfinger
\ 	drop 0 SDL_MultiGestureEvent bytes:			SDL_Event-mgesture
\ 	drop 0 SDL_DollarGestureEvent bytes:		SDL_Event-dgesture
\ 	drop 0 SDL_DropEvent bytes:					SDL_Event-drop
\ 	drop 0 SDL_SensorEvent bytes:				SDL_Event-sensor
\ 	drop 0 SDL_QuitEvent bytes:					SDL_Event-quit
\ 	drop 0 SDL_UserEvent bytes:					SDL_Event-user
\ 	drop 0 SDL_SysWMEvent bytes:				SDL_Event-syswm


\ struct SDL_Event    \ version mauvaise apparement
\                        i32 field ->Event-type
\ \ @TODO: gros souci de cohérence par rapport au code C
\                         16 field ->Event-jhat
\                         24 field ->Event-window
\                         12 field ->Event-cdevice
\                         16 field ->Event-adevice
\                         48 field ->Event-sensor
\                         20 field ->Event-jball
\                         20 field ->Event-caxis
\                         28 field ->Event-button
\                         16 field ->Event-jbutton
\                         40 field ->Event-csensor
\                         44 field ->Event-wheel
\                         36 field ->Event-motion
\                         40 field ->Event-mgesture
\                         40 field ->Event-dgesture
\                         24 field ->Event-drop
\     SDL_CommonEvent        field ->Event-common
\                         32 field ->Event-key
\                         52 field ->Event-edit
\                         20 field ->Event-display
\                         16 field ->Event-cbutton
\                         32 field ->Event-ctouchpad
\                         48 field ->Event-tfinger
\                         32 field ->Event-editExt
\                          4 field ->Event-type
\                         20 field ->Event-jaxis
\                         12 field ->Event-jdevice
\                         16 field ->Event-syswm
\                         56 field ->Event-padding
\                          8 field ->Event-quit
\                         32 field ->Event-user
\                         44 field ->Event-text
\                         16 field ->Event-jbattery



\ ***  Continue definitions in SDL2 vocabulary  ********************************

SDL2 definitions
SDL_structures

: SDL_Color!  { r g b addr -- }
      r addr ->Color-r C!
      g addr ->Color-g C!
      b addr ->Color-b C!
    $ff addr ->Color-a C!
  ;

\ example:
\ create border-color SDL_Color allot
\   $ff $00 $00 border-color SDL_Color!


: SDL_Point!  { x y addr -- }
    x addr ->Point-x L!
    y addr ->Point-y L!
  ;

\ example:
\ create start-pos SDL_Point allot
\   25 70 start-pos SDL_Point!


: SDL_Rect!  { x y w h addr -- }
    x addr ->Rect-x L!
    y addr ->Rect-y L!
    w addr ->Rect-w L!
    h addr ->Rect-h L!
  ;

\ example:
\ create ext-bord SDL_Rect allot
\   25 70 100 100 ext-bord SDL_Rect!
