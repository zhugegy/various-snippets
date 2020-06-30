#!/bin/bash
SRC="./source"
DES="./destination"
find $SRC -name "* *" -type f | rename 's/ /./g'
currenttime=$(date +"%m-%d-%y")
FIND="$(find $SRC -mtime -10 -type f)"
for file in $FIND
do
zip "$file$currenttime.zip" "$file" 
mv "$file$currenttime.zip" "$DES"
done

