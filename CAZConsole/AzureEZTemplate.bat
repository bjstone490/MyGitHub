
set myserver=THE_NEW_MACHINE_NAME

if Exist \\10.81.16.48\E$\data\Ops\\triggers\OnDemandUpdate.bat start \\10.81.16.48\E$\data\Ops\\triggers\OnDemandUpdate.bat %myserver%

exit