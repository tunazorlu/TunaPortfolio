module.exports = {
    content: ['./**/*.{razor,html,cshtml}', '../TunaPortfolio.Client/**/*.{razor,html,cshtml}'],
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