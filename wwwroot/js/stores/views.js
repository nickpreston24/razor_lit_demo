Alpine.data('views', function () {
        console.log('initializing view toggles ...')
        return {
            open: this.$persist(true),

            tabs: {
                refactors: {
                    show: this.$persist(true)
                    , toggle() {
                        this.show = !this.show
                    }
                },
                forklifts: {
                    show: this.$persist(true)
                    , toggle() {
                        this.show = !this.show
                    }
                },
                hydrations: {
                    show: false, toggle() {
                        this.show = !this.show
                    }
                },
                // navbars: { 
                //     center: { show: true, toggle() {this.show = ! this.show}  },
                //     start: { show: true, toggle() {this.show = ! this.show}  },
                //     end: { show: true, toggle() {this.show = ! this.show}  },
                // },
            },
            toggle() {
                this.open = !this.open
            }
        }
    }
)