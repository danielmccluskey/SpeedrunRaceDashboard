window.initializeTooltips = () => {
    var tooltipTriggerList = [].slice.call(document.querySelectorAll('[data-bs-toggle="tooltip"]'));
    var tooltipList = tooltipTriggerList.map(function (tooltipTriggerEl) {
        return new bootstrap.Tooltip(tooltipTriggerEl);
    });
};
window.scrollToElement = (id) => {
    const element = document.getElementById(id);
    if (element) {
        element.scrollIntoView();
    }
};
window.initializePopovers = () => {
    var popoverTriggerList = [].slice.call(document.querySelectorAll('[data-bs-toggle="popover"]'));
    var popoverList = popoverTriggerList.map(function (popoverTriggerEl) {
        return new bootstrap.Popover(popoverTriggerEl);
    });
};

window.getLocalStorageItem = function (key) {
    return localStorage.getItem(key);
}

window.clickMatureContentButton = () => {
    const button = document.querySelector('button[data-a-target="player-overlay-mature-accept"]');
    if (button) {
        button.click();
    }
};
window.newtwitchEmbed = {
    players: {},
    init: function (elementId, channel) {



        //Check if the player already exists
        if (this.players[elementId]) {
            //If it does, destroy it
            this.players[elementId].destroy();
            delete this.players[elementId];


        }



        this.players[elementId] = new Twitch.Player(elementId, {
            channel: channel,
            width: '100%',
            height: '100%'
        });

        this.players[elementId].addEventListener(Twitch.Player.READY, () => {
            this.resizePlayer(elementId);
            window.addEventListener("resize", () => this.resizePlayer(elementId));
        });
    },
    resizePlayer: function (elementId) {
        const container = document.getElementById(elementId);
        const containerWidth = container.clientWidth;
        const containerHeight = containerWidth * (9 / 16);
        //this.players[elementId].setWidth(containerWidth);
        //this.players[elementId].setHeight(containerHeight);
    },
    play: function (elementId) {
        if (this.players[elementId]) {
            this.players[elementId].play();
        }
    },
    pause: function (elementId) {
        if (this.players[elementId]) {
            this.players[elementId].pause();
        }
    },
    mute: function (elementId) {
        if (this.players[elementId]) {
            this.players[elementId].setMuted(true);
        }
    },
    unmute: function (elementId) {
        if (this.players[elementId]) {
            this.players[elementId].setMuted(false);
        }
    },
    delete: function (elementId) {
        if (this.players[elementId]) {
            this.players[elementId].destroy();  // using Twitch.Player's destroy method
            delete this.players[elementId];
        }
    }

};


window.Carousel = {
    initCarousel: function (elementId) {
        try {
            var myCarousel = document.getElementById(elementId);
            if (myCarousel) {
                var carousel = new bootstrap.Carousel(myCarousel, {
                    interval: 20000, // Adjust the interval (in milliseconds) to change the speed
                    wrap: true,
                    // Other carousel options can be added here
                });
            } else {
                console.error('Carousel element not found');
            }
        } catch (error) {
            console.error('Error initializing carousel:', error);
        }
    },

    initCarouselFade: function (elementId) {
        try {
            var myCarousel = document.getElementById(elementId);
            if (myCarousel) {
                var carousel = new bootstrap.Carousel(myCarousel, {
                    interval: 30000, // Adjust the interval (in milliseconds) to change the speed
                    wrap: true,
                    // Other carousel options can be added here
                });
            } else {
                console.error('Carousel element not found');
            }
        } catch (error) {
            console.error('Error initializing carousel fade:', error);
        }
    },
    initCarouselAndListenForEnd: function (carouselId, dotNetObjRef) {
        try {
            var myCarousel = document.getElementById(carouselId);

            if (myCarousel) {
                var carousel = new bootstrap.Carousel(myCarousel, {
                    interval: 1000, // Adjust the interval (in milliseconds) to change the speed
                });

                myCarousel.addEventListener('slid.bs.carousel', function (event) {
                    // Check if this is the last slide
                    var carouselItems = myCarousel.querySelectorAll('.carousel-item');
                    var lastCarouselItem = carouselItems[carouselItems.length - 1];

                    if (lastCarouselItem.classList.contains('active')) {
                        // Invoke C# method to reload random facts
                        dotNetObjRef.invokeMethodAsync('ReloadRandomFacts');

                        // After invoking C# method, reset to the first slide without animation
                        carousel._config.interval = 0; // Temporarily set interval to 0 to remove animation
                        carousel.to(0); // Go to first slide
                        carousel._config.interval = 5000; // Reset interval to original value

                        // Since we can't know exactly when the C# method has finished reloading
                        // random facts, you can use a setTimeout function to delay the move
                        // to the second slide.
                        setTimeout(function () {
                            carousel.next();
                        }, 100);
                    }
                });
            }
        } catch (error) {
            console.error('Error initializing carousel and listening for end:', error);

        }
    },
    disposeCarousel: function (elementId) {
        try {
            var carouselElement = document.getElementById(elementId);
            if (carouselElement && carouselElement.carouselInstance) {
                carouselElement.carouselInstance.dispose();
            }
        } catch (error) {
            console.error('Error disposing carousel:', error);
        }

    }
}





//Set video of a certain id to 0 seconds and play it
function playVideo(videoId) {
    var video = document.getElementById(videoId);
    video.currentTime = 0;
    video.play();
}

//Set video of a certain id to 0 seconds and pause it
function pauseVideo(videoId) {
    var video = document.getElementById(videoId);
    video.currentTime = 0;
    video.pause();
}

window.FontLoader = {
    waitForFonts: () => {
        return new Promise((resolve) => {
            if (document.fonts && document.fonts.ready) {
                document.fonts.ready.then(() => {
                    document.documentElement.classList.remove('loading');
                    document.documentElement.classList.add('loaded');
                    resolve();
                });
            } else {
                // Fallback for older browsers
                document.documentElement.classList.remove('loading');
                document.documentElement.classList.add('loaded');
                resolve();
            }
        });
    }
};




window.addClass = (elementId, className) => {
    document.getElementById(elementId).classList.add(className);
};

window.removeClass = (elementId, className) => {
    document.getElementById(elementId).classList.remove(className);
};


function hideStream(id) {
    document.getElementById('stream-' + id).style.display = 'none';
}

function showStream(id) {
    document.getElementById('stream-' + id).style.display = '';
}

function toggleStream(id, show) {
    const el = document.getElementById('stream-' + id);
    if (el) {
        if (show) {
            el.classList.remove('d-none');
        } else {
            el.classList.add('d-none');
        }
    }
}
