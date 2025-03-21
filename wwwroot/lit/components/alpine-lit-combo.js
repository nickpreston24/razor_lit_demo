import {html, css, LitElement} from 'https://cdn.jsdelivr.net/gh/lit/dist@2.4.0/core/lit-core.min.js';

export class AlpineLitCombo extends LitElement {
    constructor() {
        super();
        // this.foo = 'bar';
    }

    render() {
        return html`
            <div x-data="{ open: false }">
                <button @click="open = true">Expand</button>

                <span x-show="open">
                    Content...
                </span>
            </div>
        `
    }

}

customElements.define('alpine-lit-combo', AlpineLitCombo);