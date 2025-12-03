## 🏗️ Directory Structure

The project structure is inspired by [Bulletproof React](https://github.com/alan2207/bulletproof-react) to ensure scalability and maintainability.

```
resources/react/
├── api/                 # TypeScript definitions for Laravel models and API responses
├── app.tsx              # Main Inertia.js + React entry point
├── components/          # Generic, reusable UI components (Buttons, Inputs, Layouts)
├── features/            # Domain-specific features (e.g., Task, StatusColumn, Auth)
├── pages/               # Inertia.js page components (Controllers map to these)
├── utils/               # Shared utility functions and hooks
└── tsconfig.json        # TypeScript configuration
```

## 📏 Code Conventions

We prioritize **pragmatism over dogmatism**. The goal is to write code that is easy to read, easy to delete, and easy to refactor.

### 1. Component Organization (`@components` vs `@features`)

-   **`@components`**: Contains **generic** UI components that are agnostic to the business logic (e.g., `Button`, `Modal`, `Input`). These should not import from `@features`.
-   **`@features`**: Contains **domain-specific** components that implement business logic (e.g., `AddToCartButton`, `ProductHero`).
    -   Keep related code (components, hooks, types, utils) collocated within the feature folder.
    -   If a feature grows too large, break it down into sub-features or move shared parts to `@components` or `@utils` only if truly necessary.
-   **One exported component or hook per file, use barrels for grouping**

### 2. Imports and Barrel Files

Make use of Path aliases. Optionally, use barrel files, but no need to enforce this.

### 3. Naming Conventions

-   **Components**: Use `PascalCase` (e.g., `ProductCard.tsx`).
-   **Files**: Match the component name (e.g., `ProductCard.tsx`).
-   **Hooks**: Use `camelCase` with `use` prefix (e.g., `useAddToCart.ts`).
-   **Props**: Use `Interface` definitions, generally named `{ComponentName}Props`.

### 4. TypeScript & Data Types

-   **Backend Data**: Types matching Laravel models live in `@api/types.ts`. Keep these in sync with the backend resources/models.
-   **Component Props**: Define props explicitly. Avoid using `any`.
-   **Path Aliases**: Use configured aliases for cleaner imports:
    -   `@components/*`
    -   `@features/*`
    -   `@utils/*`
    -   `@api/*`

### 5. Server-Side Rendering (SSR) & Hydration

This project uses Inertia SSR. To avoid **Hydration Mismatches**:

-   **Avoid** conditional rendering based on `window` or `document` presence if possible.
-   **Avoid** using random values (`Math.random()`) or current time (`Date.now()`) during render without `useEffect`.
-   **Ensure** the initial HTML rendered by the server matches the client's first render exactly.
-   **Restart** the SSR process (or container) after deploying changes to React files.

### 6. State Management

-   **Server State**: Use Inertia props (passed from Laravel controllers) for initial data.
-   **URL State**: Use query parameters for filter/sort state (searchable, shareable URLs).
-   **Local State**: Use `useState` / `useReducer` for UI state (modals, dropdowns).
-   **Global State**: Keep it minimal. Inertia handles page transitions and data updates, reducing the need for a complex global store like Redux.

## 🤝 Collaboration

-   Keep components small and focused.
-   Extract logic into custom hooks when a component becomes too complex.
-   Leave comments for complex business logic, but let the code speak for itself otherwise.