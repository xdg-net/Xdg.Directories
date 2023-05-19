# FFI
Here lies the code that is used for the C FFI.
This is not meant to be used by .NET but rather by any language that can interface with C.

## Building
To build the library for production, use the included `gmake` file.
```sh
make
sudo make install
```

## TODO
- [x] pkg-config file
- [x] Makefile
- [ ] manpage, probably make it with scdoc?
	- maybe use pandoc instead?
- [ ] Examples
	- Maybe some bindings for other languages as a POC?
- [ ] Tests
	- Test from C or C#?