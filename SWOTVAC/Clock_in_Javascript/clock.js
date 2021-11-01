console.log('Loading clock class');

class Clock {

    constructor() {
        this.currentTime = new Date(); // Note that declaring it this way makes it public and not protected
        this.printTime();
    }

    tick() {
        this.currentTime.setSeconds(this.currentTime.getSeconds() + 1);
        this.printTime();
    }

    printTime() {
        console.log(this.currentTime.toTimeString());
    }

    resetTime() {
        this.currentTime = new Date('1-1-2021')
        this.printTime();
    }
}

