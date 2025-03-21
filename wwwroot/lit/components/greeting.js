﻿import {html, css, LitElement} from 'https://cdn.jsdelivr.net/gh/lit/dist@2.4.0/core/lit-core.min.js';

export class SimpleGreeting extends LitElement {
    static get styles() {
        return css`p {
            color: fuchsia;
        }`;
    }

    static get properties() {
        return {
            name: {
                type: String
                , rem: String
            }
        }
    }

    constructor() {
        super();
        this.name = 'Somebody';
        this.rem = '1.75rem';
    }

    down_button() {
        return html`
            <svg
                    width="${this.rem}"
                    xmlns="http://www.w3.org/2000/svg"
                    fill="none"
                    viewBox="0 0 24 24"
                    stroke-width="1.5"
                    stroke="currentColor" class="size-6">
                <path stroke-linecap="round" stroke-linejoin="round"
                      d="m9 12.75 3 3m0 0 3-3m-3 3v-7.5M21 12a9 9 0 1 1-18 0 9 9 0 0 1 18 0Z"/>
            </svg>
        `
    }

    render() {
        return html`<p class="dog-body text-primary">Hello, ${this.name}!</p>`;
    }
}

customElements.define('simple-greeting', SimpleGreeting);