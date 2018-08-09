struct Foo {
    int x;
    void bar() {
        cout << "Hello World" << endl;
    }
    void baz() {
        cout << x << endl;
    }
};
int main() {
    Foo *foo = NULL;
    foo->bar(); // OK
    foo->baz(); // crash
}
