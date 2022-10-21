use std::{collections::BTreeSet};

fn lexical_order(n: i32) -> Vec<i32> {
        let mut set=BTreeSet::new();
        for i in 1..= n{
            set.insert(i.to_string());
        }
        set.iter().map(|x| x.parse::<i32>().unwrap()).collect()
}
fn main() {
    lexical_order(15);
//    println!("01986774784\n");    
}
