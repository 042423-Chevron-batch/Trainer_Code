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

## Making Http Requests
- Angular provides HttpClient class (which lives in HttpClientModule) for making http calls, these return Observables, which you have to subscribe to.

## Lifecycle Hooks
- Components go through different life stages (from Initialization to Destory) and you can "hook" onto any of those stages to insert your own logic

## Forms
Angular has two types of forms: Template based and Reactive forms. Template based form is suitable for simple forms, and most of form logic lives in the template (aka html). Reactive form scales better because your data control and logic lives in your typescript class.


## Services
- *Services* are reusable pieces of *logic*. They don't have views associated to them!
- Use services for:
    - Business logic needs (data processing, sending http calls, etc)
    - Sharing data between components