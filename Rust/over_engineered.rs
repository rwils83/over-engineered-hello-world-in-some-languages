fn main() {
    let hello_array: [char; 5] = ['H', 'e', 'l', 'l', 'o'];
    let world_array: [char; 5] = ['W', 'o', 'r', 'l', 'd'];

    let mut hello_str = String::from("");
    let mut world_str = String::from("");

    for x in &hello_array {
        hello_str.push(*x);
    }

    for y in &world_array {
        world_str.push(*y);
    }
    
    print!("{} ", hello_str);
    print!("{}!\n", world_str);
}