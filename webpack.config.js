var path = require("path");
var webpack = require("webpack");
var root = path.resolve("public");

var cfg = {
    devtool: "source-map",
    entry: "./temp/Main.js",
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
    }
};

module.exports = cfg;