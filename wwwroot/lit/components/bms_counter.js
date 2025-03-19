import {
  html,
  css,
  LitElement,
} from "https://cdn.jsdelivr.net/gh/lit/dist@2.4.0/core/lit-core.min.js";

export class BMSCounter extends LitElement {
  static properties = {
    counter: { state: true },
  };

  constructor() {
    super();
    this.counter = 0;
  }

  increment() {
    this.counter++;
  }

  decrement() {
    this.counter--;
  }
}

customElements.define("bms-counter", BMSCounter);
