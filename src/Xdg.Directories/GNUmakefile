PREFIX ?= /usr/local
LIB ?= lib64
BASE ?= bin/Release/$(NETVERSION)/linux-x64/publish


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