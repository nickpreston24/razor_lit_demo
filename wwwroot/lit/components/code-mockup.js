import {html, css, LitElement} from 'https://cdn.jsdelivr.net/gh/lit/dist@2.4.0/core/lit-core.min.js';

export class CodeMockup extends LitElement {
    static get styles() {
        return css`p {
        }`;
    }

    static get properties() {
        return {
            name: {}
        }
    }

    constructor() {
        super();
        // this.rem = '1.75rem';
        // this.viewbox = '0 0 24 24';
        // this.strokeWidth = '1.5';
    }

    render() {
        return html`
            <div class="mockup-code w-full">
                <pre data-prefix="1"><code>npm i daisyui</code></pre>
                <pre data-prefix="2"><code>installing...</code></pre>
                <pre data-prefix="3" class="bg-warning text-warning-content"><code>Error!</code></pre>
            </div>
        `
    }

}

customElements.define('code-mockup', CodeMockup);