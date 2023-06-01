# Angular

## Single Page Application

## Angular
is a frontend framework that allows developers to easily and quickly build SPAs
React, Next.js, Vue, etc.

## Angular Commands
- `npm install --global @angular/cli` to install angular globally in your machine, so you can do `ng` command everywhere
- `ng new application-name` to create new angular application
- `ng generate component <name>` to generate new components
    - `ng g c component-name` : shortcut
- `ng serve` : aka dotnet run but angular version
    - `ng s`: shorthand
    - `ng serve -o`

## Components
- *Components* are reusable views with their own logic and style.
- They need to be registered in a module in order for angular to recognize

## Decorators

## Directives
Directives bring programmatic functionality to html
- *Structural directives* modify the structure of the DOM (*ngIf, *ngFor, etc)
- *Attribute directives* modify the attributes of existing html elemnts (they modify the look and feel of html elements) (ngClass, etc.)

## Data Binding
1. String Interpolation `{{}}`
2. Event Binding: `(eventName)="eventListener"`
3. Attribute Binding: `[attribute]="propertyName"`

## Services
- *Services* are reusable pieces of *logic*. They don't have views associated to them!
- Use services for:
    - Business logic needs (data processing, sending http calls, etc)
    - Sharing data between components