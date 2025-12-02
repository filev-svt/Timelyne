import { SVGAttributes } from 'react';

export default function AppLogoIcon(props: SVGAttributes<SVGElement>) {
    return (
        <svg
            {...props}
            viewBox="0 0 64 64"
            xmlns="http://www.w3.org/2000/svg"
            fill="currentColor"
        >
            {/* Vertical anchor line */}
            <rect x="30" y="10" width="4" height="44" rx="2" />

            {/* Three task blocks aligned along the vertical line */}
            <rect x="14" y="16" width="12" height="10" rx="3" />
            <rect x="38" y="28" width="12" height="10" rx="3" />
            <rect x="14" y="40" width="12" height="10" rx="3" />

            {/* Smooth timeline curve */}
            <path
                d="
                M 20 20
                C 36 22, 36 36, 20 42
                "
                stroke="currentColor"
                strokeWidth="4"
                fill="none"
                strokeLinecap="round"
            />
        </svg>
    );
}
