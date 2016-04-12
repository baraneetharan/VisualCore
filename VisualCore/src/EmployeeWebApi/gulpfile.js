/// <binding Clean='clean' />
"use strict";




var gulp = require("gulp"),
    rimraf = require("rimraf"),
    concat = require("gulp-concat"),
    cssmin = require("gulp-cssmin"),
    uglify = require("gulp-uglify"),
    Server = require('karma').Server;
    
var paths = {
    webroot: "./wwwroot/"
};

var angularpath = { Scripts : "./Scripts/"};

paths.js = paths.webroot + "js/**/*.js";
paths.minJs = paths.webroot + "js/**/*.min.js";
paths.css = paths.webroot + "css/**/*.css";
paths.minCss = paths.webroot + "css/**/*.min.css";
paths.concatJsDest = paths.webroot + "js/site.min.js";
paths.concatCssDest = paths.webroot + "css/site.min.css";
angularpath.controller = angularpath.Scripts + "Controller/*.js";
angularpath.Service = angularpath.Scripts + "Service/*.js";
angularpath.module = angularpath.Scripts + "app.js";
angularpath.minApp = paths.webroot + "app.js";
angularpath.concatJsDest = paths.webroot + "app.js";
  

gulp.task("min:apjs", function () {
    return gulp.src([angularpath.module,angularpath.Service,angularpath.controller], { base: "." })
        .pipe(concat(angularpath.concatJsDest))
        .pipe(uglify())
        .pipe(gulp.dest("."));
});



gulp.task('test', function (done) {
  new Server({
    configFile: __dirname + '/karma.conf.js',
    singleRun: true
  }, done).start();
});

/**
 * Watch for file changes and re-run tests on each change
 */
gulp.task('tdd', function (done) {
  new Server({
    configFile: __dirname + '/karma.conf.js'
  }, done).start();
});

gulp.task('default', ['tdd']);


gulp.task("clean:js", function (cb) {
    rimraf(paths.concatJsDest, cb);
});

gulp.task("clean:css", function (cb) {
    rimraf(paths.concatCssDest, cb);
});

gulp.task("clean", ["clean:js", "clean:css"]);

gulp.task("min:js", function () {
    return gulp.src([paths.js, "!" + paths.minJs], { base: "." })
        .pipe(concat(paths.concatJsDest))
        .pipe(uglify())
        .pipe(gulp.dest("."));
});

gulp.task("min:css", function () {
    return gulp.src([paths.css, "!" + paths.minCss])
        .pipe(concat(paths.concatCssDest))
        .pipe(cssmin())
        .pipe(gulp.dest("."));
});

gulp.task("min", ["min:js", "min:css"]);
gulp.task("minangular", ["min:apjs"]);
gulp.task("default",["min","minangular"]);
