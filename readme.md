This program was written to have som fun with SHA256 algorithm and trying to reverse some of it's internal functions.

I was able to successfully reverse sigma0 function which does:

`ROTATE_RIGHT(X, 7) ^ ROTATE_RIGHT(X, 18) ^ SHIFT_RIGHT(X, 3)`

The program produces the following output:

```
Sigma 0 sha256 hacking
Input:
00000000000000000011111111111111

Sigma0 output:
11110001111111111100011110000000

Sigma0 reversed:
00000000000000000011111111111111
```

