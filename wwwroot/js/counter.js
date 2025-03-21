document.addEventListener('alpine:initializing', () => {
    console.log("loading counter store (counter.js)...")

    Alpine.store('counter', {
        value: Alpine.$persist(0)
        , step: 1
        , increment() {
            this.value += this.step
        }
        , decrement() {
            this.value -= this.step
        }
        , reset() {
            this.value = 0;
        }
    })
})
