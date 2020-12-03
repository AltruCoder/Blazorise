module.exports = {
    future: {
        purgeLayersByDefault: true,
    },
    //purge: {
    //    // Learn more on https://tailwindcss.com/docs/controlling-file-size/#removing-unused-css
    //    enabled: process.env.NODE_ENV === 'production',
    //    content: [
    //        '**/*.razor'
    //    ]
    //},
    theme: {
        extend: {
            animation: {
                fadeOut: 'fadeOut 1s forwards',
                fadeInBottomRight: 'fadeInBottomRight 1s forwards',
                fadeInLeft: 'fadeInLeft 1s forwards',
                dropdownEnter: 'dropdownEnter .2s forwards ease-out',
                dropdownLeave: 'dropdownLeave .1s forwards ease-in'
            },
            keyframes: {
                fadeOut: {
                    from: {
                        opacity: 1
                    },
                    to: {
                        opacity: 0,
                        visibility: 'hidden'
                    }
                },
                fadeInBottomRight: {
                    from: {
                        opacity: 0,
                        transform: 'translate3d(100%, 100%, 0)'
                    },
                    to: {
                        opacity: 1,
                        transform: 'translate3d(0, 0, 0)'
                    }
                },
                fadeInLeft: {
                    from: {
                        opacity: 0,
                        transform: 'translate3d(-100%, 0, 0)'
                    },
                    to: {
                        opacity: 1,
                        transform: 'translate3d(0, 0, 0)'
                    }
                },
                dropdownEnter: {
                    from: {
                        opacity: 0,
                        transform: 'scale(.95)'
                    },
                    to: {
                        opacity: 100,
                        transform: 'scale(1.0)'
                    }
                },
                dropdownLeave: {
                    from: {
                        opacity: 100,
                        transform: 'scale(1.0)'
                    },
                    to: {
                        opacity: 0,
                        transform: 'scale(.95)'
                    }
                }
            }
        },
    },
    variants: {
        extend: {
            opacity: ['disabled'],
        }
    },
    plugins: [
        require('@tailwindcss/ui'),
    ],
}