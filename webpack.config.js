var path = require("path");
var webpack = require("webpack");
var root = path.resolve("public");

var cfg = {
    devtool: "source-map",
    entry: "app",
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
        ],
        loaders: [
            { 
                test: /\.ts$/, 
                exclude: /node_modules/,
                loader: 'ts-loader' 
            }
        ]
    },
    resolve: {
        extensions: ['', '.ts', '.js'],
        root: [
            path.resolve('.'),
            path.resolve('./src'),
            path.resolve('./build/fsx'),
        ]
    }
};

module.exports = cfg;