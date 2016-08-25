var path = require("path");
var webpack = require("webpack");
var root = path.resolve("public");

var cfg = {
    devtool: "source-map",
    entry: "Main.js",
    output: {
        path: root,
        filename: "bundle.js"
    },
    module: {
        preLoaders: [
            {
                test: /\.js$/,
                exclude: /node_modules/,
                loader: "source-map-loader"
            }
        ]
    },
    resolve: {
        root: [
            path.resolve('.'),
            path.resolve('./src'),
            path.resolve('./temp'),
        ]
    }
};

module.exports = cfg;