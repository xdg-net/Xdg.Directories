PREFIX ?= /usr/local
LIB ?= lib64
DOTNET ?= dotnet
NETVERSION ?= net7.0
PUBFLAGS ?= --framework $(NETVERSION) -c Release

ifeq ($(OS),Windows_NT)
	OSFLAG += win
	ifeq ($(PROCESSOR_ARCHITEW6432),AMD64)
		OSFLAG := $(OSFLAG)-x64
	else
		ifeq ($(PROCESSOR_ARCHITECTURE),AMD64)
			OSFLAG := $(OSFLAG)-x64
		endif
		ifeq ($(PROCESSOR_ARCHITECTURE),x86)
			OSFLAG := $(OSFLAG)-x86
		endif
	endif
else
	UNAME_S := $(shell uname -s)
	ifeq ($(UNAME_S),Linux)
		OSFLAG += linux
	endif
	ifeq ($(UNAME_S),Darwin)
		OSFLAG += osx
	endif
	UNAME_M := $(shell uname -m)
	ifeq ($(UNAME_M),x86_64)
		OSFLAG := $(OSFLAG)-x64
	endif
	ifeq ($(UNAME_M),x86)
		OSFLAG := $(OSFLAG)-x86
	endif
	ifeq ($(UNAME_M),arm64)
		OSFLAG := $(OSFLAG)-arm64
	endif
	ifeq ($(UNAME_M),arm)
		OSFLAG := $(OSFLAG)-arm
	endif
endif

PUBFLAGS += -r $(OSFLAG)
BASE ?= bin/Release/$(NETVERSION)/$(OSFLAG)/publish

publish: bin/Release/$(NETVERSION)/$(OSFLAG)/publish

bin/Release/$(NETVERSION)/$(OSFLAG)/publish:
	dotnet publish $(PUBFLAGS)

.PHONY: install
install:
	sed -i 's|prefix=.*|prefix=$(PREFIX)|' $(BASE)/xdg.pc
	install -Dm755 $(BASE)/libxdg.so $(PREFIX)/$(LIB)
	install -Dm644 $(BASE)/xdg.pc $(PREFIX)/$(LIB)/pkgconfig
	install -Dm644 $(BASE)/include/xdg.h $(PREFIX)/include

.PHONY: uninstall
uninstall:
	rm $(PREFIX)/$(LIB)/libxdg.so
	rm $(PREFIX)/$(LIB)/pkgconfig/xdg.pc
	rm $(PREFIX)/include/xdg.h

.PHONY: clean
clean:
	rm -rf bin obj