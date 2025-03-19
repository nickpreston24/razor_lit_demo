import {html, css, LitElement} from 'https://cdn.jsdelivr.net/gh/lit/dist@2.4.0/core/lit-core.min.js';

export class DownCircleButton extends LitElement {
    static get styles() {
        return css`p {
            color: fuchsia;
        }`;
    }

    static get properties() {
        return {
            name: {
                rem: String, viewbox: String, strokeWidth: String,
            }
        }
    }

    constructor() {
        super();
        this.rem = '1.75rem';
        this.viewbox = '0 0 24 24';
        this.strokeWidth = '1.5';
    }

    render() {
        return html`
            <svg
                    width="${this.rem}"
                    xmlns="http://www.w3.org/2000/svg"
                    fill="${this.fill}"
                    viewBox="${this.viewbox}"
                    stroke-width="${this.strokeWidth}"
                    stroke="currentColor"
                    class="size-6 text-primary bg-white">
                <path stroke-linecap="round"
                      stroke-linejoin="round"
                      d="m9 12.75 3 3m0 0 3-3m-3 3v-7.5M21 12a9 9 0 1 1-18 0 9 9 0 0 1 18 0Z"/>
            </svg>
        `
    }

}

customElements.define('down-circle-button', DownCircleButton);