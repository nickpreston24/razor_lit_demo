// console.log('hello??')
document.addEventListener('alpine:initializing', () => {
    console.log('initializing view toggles store ...')

    Alpine.store('theme', {
        value: 'lemonade', set(val) {
            this.value = val;
        }
    })

    Alpine.store('darkMode', {
        on: false,

        toggle() {
            this.on = !this.on
        }
    })

    Alpine.data('views', function () {
        console.log('beep')
        return {
            open: this.$persist(true), foo: this.$persist('bar'),

            tabs: {
                refactors: {
                    name: 'hi, i am refactors', show: this.$persist(true), toggle() {
                        this.show = !this.show
                    }
                }, forklifts: {
                    show: this.$persist(true), toggle() {
                        this.show = !this.show
                    }
                }, hydrations: {
                    show: false, toggle() {
                        this.show = !this.show
                    }
                }, // navbars: {
                //     center: { show: true, toggle() {this.show = ! this.show}  },
                //     start: { show: true, toggle() {this.show = ! this.show}  },
                //     end: { show: true, toggle() {this.show = ! this.show}  },
                // },
            }, toggle() {
                this.open = !this.open
            }
        }
    })
})


function myData() {
    return {
        greeting: Alpine.$persist("hello world"), tabs: Alpine.$persist({
            title: 'refactors', // title: 'foo',
            show: true
        }), theme: 'dark'
        // tabs: {
        //     refactors: {
        //         name: 'hi, i am refactors',
        //         // show: this.$persist(true), toggle() {
        //         //     this.show = !this.show
        //         // }
        //     }, forklifts: {
        //         show: this.$persist(true), toggle() {
        //             this.show = !this.show
        //         }
        //     },
        // }
    };
}

window.myData = myData;
