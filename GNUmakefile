NETVERSION ?= net7.0
PUBFLAGS ?= --framework $(NETVERSION) -c Release -p GeneratePackageOnBuild=false -p PublishAot=true -p AssemblyName=libxdg

ifeq ($(OS),Windows_NT)
	OSFLAG += win
	ifeq ($(PROCESSOR_ARCHITEW6432),AMD64)
		:= $(OSFLAG)-x64
	else
		ifeq ($(PROCESSOR_ARCHITECTURE),AMD64)
			:= $(OSFLAG)-x64
		endif
		ifeq ($(PROCESSOR_ARCHITECTURE),x86)
			:= $(OSFLAG)-x86
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

publish: src/Xdg.Directories/bin/Release/$(NETVERSION)/$(OSFLAG)/publish

src/Xdg.Directories/bin/Release/$(NETVERSION)/$(OSFLAG)/publish:
	dotnet publish ./src/Xdg.Directories $(PUBFLAGS)

.PHONY: install
install: publish
	make NETVERSION=$(NETVERSION) -C src/Xdg.Directories install

.PHONY: uninstall
uninstall:
	make -C src/Xdg.Directories uninstall