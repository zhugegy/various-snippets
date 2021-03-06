#!/bin/sh
convert ui*.png -resize 354x162 -background black -alpha remove -gravity center -extent 354x162 nor%03d.png
convert ui*.png -resize 354x162 -background black -compose Copy -alpha extract -gravity center -extent 354x162 prem%03d.png
convert prem*.png -negate mas%03d.png
montage nor*.png -tile 16x1 -geometry +0+0 out1.png
montage mas*.png -tile 16x1 -geometry +0+0 out2.png
montage out*.png -tile 1x2 -geometry +0+0 $1.png
