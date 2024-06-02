module.exports = {
    content: ['./**/*.{razor,html,cshtml}', '../TunaPortfolio1.Client/**/*.{razor,html,cshtml}'],
    theme: {
        extend: {},
    },
    plugins: [
        require('daisyui'),
    ],
    daisyui: {
        themes: ["light", "dark", "night", "cupcake"],
    },
}