const atimport = require("postcss-import");
const { dest, src, task } = require("gulp");
const postcss = require("gulp-postcss");
const purgecss = require("@fullhuman/postcss-purgecss");
const tailwindcss = require("tailwindcss");

const TAILWIND_CONFIG = "./tailwind.config.js";
const SOURCE_STYLESHEET = "./styles/blazorise.tailwind.css";
const DESTINATION_STYLESHEET = "./wwwroot/";

task("css", () =>
    src(SOURCE_STYLESHEET)
        .pipe(
            postcss([
                atimport(),
                tailwindcss(TAILWIND_CONFIG),
                ...(process.env.NODE_ENV === "production"
                    ? [
                        purgecss({
                            content: ["**/*.razor"],
                            defaultExtractor: content =>
                                content.match(/[\w-/:]+(?<!:)/g) || []
                        })
                    ]
                    : [])
            ])
        )
        .pipe(dest(DESTINATION_STYLESHEET))
);