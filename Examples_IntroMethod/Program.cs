int a1 = 244;
int b1 = 452;
int c1 = 112;
int a2 = 234;
int b2 = 2668;
int c2 = 5621;
int a3 = 2654;
int b3 = 2325;
int c3 = 8582;

int max = a1;
if(b1 > max) max = b1;
if(c1 > max) max = c1;

if(a2 > max) max = a2;
if(b2 > max) max = b2;
if(c2 > max) max = c2;

if(a3 > max) max = a3;
if(b3 > max) max = b3;
if(c3 > max) max = c3;

Console.WriteLine(max);
