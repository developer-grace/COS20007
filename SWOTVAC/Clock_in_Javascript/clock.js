console.log('Loading clock class, et al');

class Counter {
    constructor(name, overflow) {
        this.name = name || "Default name";
        this.ticks = 0;
        this.overflow = overflow
    }

    // Returns true if we overflowed, false if not.
    increment() {
        this.ticks++;
        if(this.ticks === this.overflow) {
            this.ticks = 0;
            return true;
        } else {
            return false;
        }
    }
    reset() {
        this.ticks = 0;
    }

    // Left pad the ticks with zeros.
    toString() {
        return `0${this.ticks}`.slice(-2);
    }

    set(value) {
        if(value <= this.overflow) {
            this.ticks = value;
        } else {
            throw new Error(`Tried to set counter to a value (${value}) greater than or equal to the overflow (${this.overflow})`);
        }
    }
}

class Clock {

    constructor(name = "Default name") {

        this.name = name;

        this.hours = new Counter('hours', 24);
        this.minutes = new Counter('minutes', 60);
        this.seconds = new Counter('seconds', 60);
        

        this.printTime();
    }

    tick() {
        if(this.seconds.increment()) {
            if(this.minutes.increment()) {
                if(this.hours.increment()) {
                    this.hours.reset();
                }
            }
        }
        this.printTime();
    }

    /**
     * Give us the time in the format: "hh:mm:ss"
     */
    setTime(time) {
        var parts = time.split(":").map(part => parseInt(part));
        this.hours.set(parts[0]);
        this.minutes.set(parts[1]);
        this.seconds.set(parts[2]);
    }

    printTime() {
        console.log(this.toString());
    }
    toString() {
        return `${this.hours}:${this.minutes}:${this.seconds}`;
    }
    
    resetTime() {
        this.currentTime = new Date('1-1-2021')
        this.printTime();
    }
}

