DOTNET ?= dotnet
NETVERSION ?= net8.0

.PHONY: publish
publish:
	make DOTNET=$(DOTNET) NETVERSION=$(NETVERSION) -C src/Xdg.Directories.FFI publish

.PHONY: install
install: publish
	make DOTNET=$(DOTNET) NETVERSION=$(NETVERSION) -C src/Xdg.Directories.FFI install

.PHONY: uninstall
uninstall:
	make -C src/Xdg.Directories.FFI uninstall

.PHONY: clean
clean:
	make -C src/Xdg.Directories.FFI clean
