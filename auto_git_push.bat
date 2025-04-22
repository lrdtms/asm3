@echo off
set /p commitMsg="Enter your commit message: "
git add .
git commit -m "%commitMsg%"
git push
pause