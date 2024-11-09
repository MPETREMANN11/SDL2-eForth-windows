\ *********************************************************************
\ SDL2 / Simple DirectMedia Player for eForth - structures definition
\    Filename:      SD2_STRUCTURES.fs
\    Date:          28 oct 2024
\    Updated:       07 nov 2024
\    File Version:  1.0
\    Forth:         eFORTH Windows
\    Author:        Marc PETREMANN
\    GNU General Public License
\ *********************************************************************


.( load SDL2_STRUCTURES.fs )


vocabulary SDL_structures
SDL_structures definitions


struct SDL_Color ( -- 4 )               \ OK 2024-11-06
     i8 field ->Color-r
     i8 field ->Color-g
     i8 field ->Color-b
     i8 field ->Color-a

struct SDL_Palette  ( -- 16 )           \ OK 2024-11-06
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

struct SDL_Point  ( -- 8 )              \ OK 2024-11-06                 
    i32 field ->Point-x
    i32 field ->Point-y

struct SDL_Rect  ( -- 16 )              \ OK 2024-11-06
    i32 field ->Rect-x
    i32 field ->Rect-y
    i32 field ->Rect-w
    i32 field ->Rect-h

: ->SDL_Rect { item addr0 -- addr1 }
    SDL_Rect item * addr0 +
  ;





\ struct SDL_Surface
\ {
\     SDL_SurfaceFlags flags;     /**< The flags of the surface, read-only */
\     SDL_PixelFormat format;     /**< The format of the surface, read-only */
\     int w;                      /**< The width of the surface, read-only. */
\     int h;                      /**< The height of the surface, read-only. */
\     int pitch;                  /**< The distance in bytes between rows of pixels, read-only */
\     void *pixels;               /**< A pointer to the pixels of the surface, the pixels are writeable if non-NULL */
\ 
\     int refcount;               /**< Application reference count, used when freeing surface */
\ 
\     void *reserved;             /**< Reserved for internal use */
\ };

struct SDL_Surface
    i32 field ->Surface-flags
    $48 field ->Surface-format    \ valeur fixe temporaire - pour tests
    i32 field ->Surface-w
    i32 field ->Surface-h
    i32 field ->Surface-pitch






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

\ source: https://github.com/zielmicha/SDL2/blob/master/include/SDL_events.h#L127

struct SDL_GenericEvent
    i32 field ->GenericEvent-type
    i32 field ->GenericEvent-timestamp

struct SDL_WindowEvent
    i32 field ->WindowEvent-type
    i32 field ->WindowEvent-timestamp
    i32 field ->WindowEvent-windowID    \ The associated window
     i8 field ->WindowEvent-event       \ SDL_WindowEventID
     i8 field ->WindowEvent-padding1
     i8 field ->WindowEvent-padding2
     i8 field ->WindowEvent-padding3
    i32 field ->WindowEvent-data1       \ event dependent data
    i32 field ->WindowEvent-data2       \ event dependent data


\ The SDL keyboard scancode representation
struct SDL_Scancode
    i32 field ->scancode

\ The SDL virtual key representation
struct SDL_Keycode
    i32 field ->Keycode-sym

\ The SDL keysym structure, used in key events
struct SDL_Keysym
    SDL_Scancode    field ->Keysym-scancode     \ SDL physical key code - see SDL_Scancode for details
    SDL_Keycode     field ->Keycode-sym         \ SDL virtual key code - see SDL_Keycode for details
    i16 field ->Keysym-mod                      \ current key modifiers
    i32 field ->Keysym-unused

\ Keyboard button event structure (event.key.*)
struct SDL_KeyboardEvent
    i32 field ->KeyboardEvent-type              \ SDL_KEYDOWN or SDL_KEYUP
    i32 field ->KeyboardEvent-timestamp
    i32 field ->KeyboardEvent-windowID          \ The window with keyboard focus, if any
     i8 field ->KeyboardEvent-state             \ SDL_PRESSED or SDL_RELEASED
     i8 field ->KeyboardEvent-repeat            \ Non-zero if this is a key repeat
     i8 field ->KeyboardEvent-padding2
     i8 field ->KeyboardEvent-padding3
    SDL_Keysym  field ->KeyboardEvent-keysym    \ The key that was pressed or released



\ Keyboard text editing event structure (event.edit.*)
struct SDL_TextEditingEvent
    i32 field ->TextEditingEvent-type                               \ SDL_TEXTEDITING
    i32 field ->TextEditingEvent-timestamp                          \ In milliseconds, populated using SDL_GetTicks
    i32 field ->TextEditingEvent-windowID                           \ The window with keyboard focus, if any
    SDL_TEXTEDITINGEVENT_TEXT_SIZE field ->TextEditingEvent-text    \ The editing text
    i32 field ->TextEditingEvent-start                              \ The start cursor of selected editing text
    i32 field ->TextEditingEvent-length                             \ The length of selected editing text




\ union SDL_Event
struct SDL_Event
                        i32 field ->Event-type
    SDL_GenericEvent        field ->Event-generic
    SDL_WindowEvent         field ->Event-window
    SDL_KeyboardEvent       field ->Event-key
    SDL_TextEditingEvent    field ->Event-edit

\ Information about the version of SDL in use
struct SDL_version    ( -- 3 )              \ OK 2024-11-06 
     i8 field ->version-major
     i8 field ->version-minor
     i8 field ->version-patch




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




