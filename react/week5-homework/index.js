const person1 = {
    name: 'hakan',
    surname: 'özoğlu',
    age: '30',
    location: 'istanbul',
    gender: 'man',
    score: 10,
    workingDays: 90,
    books: 1,
}
const person2 = {
    name: 'akif',
    surname: 'özoğlu',
    age: '32',
    location: 'istanbul',
    gender: 'man',
    score: 17,
    workingDays: 17,
    books: 9,
}
const person3 = {
    name: 'beyza',
    surname: 'özoğlu',
    age: '16',
    location: 'trabzon',
    gender: 'woman',
    score: 28,
    workingDays: 64,
    books: 178,
}
const person4 = {
    name: 'alp',
    surname: 'öztürk',
    age: '28',
    location: 'aydın',
    gender: 'man',
    score: 28,
    workingDays: 64,
    books: 178,
    }
const person5 = {
    name: 'serdar',
    surname: 'çakır',
    age: '22',
    location: 'istanbul',
    gender: 'man',
    score: 28,
    workingDays: 64,
    books: 178,
    }
const person6 = {
    name: 'rümeysa',
    surname: 'türkan',
    age: '22',
    location: 'istanbul',
    gender: 'man',
    score: 28,
    workingDays: 64,
    books: 178,
}
const person7 = {
    name: 'mehmet ali',
    surname: 'tunay',
    age: '30',
    location: 'istanbul',
    gender: 'man',
    score: 28,
    workingDays: 64,
    books: 178,
}
const person8 = {
    name: 'furkan',
    surname: 'atsan',
    age: '23',
    location: 'ankara',
    gender: 'man',
    score: 28,
    workingDays: 64,
    books: 178,
}
const person9 = {
    name: 'kader',
    surname: 'arslan',
    age: '24',
    location: 'adana',
    gender: 'man',
    score: 28,
    workingDays: 64,
    books: 178,
}
const person10 = {
    name: 'uğurcan',
    surname: 'uçar',
    age: '24',
    location: 'trabzon',
    gender: 'man',
    score: 28,
    workingDays: 64,
    books: 178,
}

const people = [person1, person2, person3, person4, person5, person6, person7, person8, person9, person10]

// yaşadıkları şehre göre gruplama
let groupCity = people.reduce((result, person) => {
    // dizi varsa özelliği ekle, yoksa oluşturup ekle
    (result[person.location] = result[person.location] || []).push(person)
    return result
},{})
console.log(`yaşadıkları şehre göre gruplama`, groupCity)

// ismin baş harfine göre gruplama
let groupFirstLetter = people.reduce((result,person) => {
    // ilk harfi bul
    let letter = person.name[0]
    // harfle özellik yoksa oluştur
    if(!result[letter]) {
        result[letter] = {letter, items: [person.name]}
    }
    // özellik varsa, o harf için mevcut elemanı diziye ekle
    else {
        result[letter].items.push(person.name)
    }
    return result
},{})
console.log(`ismin baş harfine göre gruplama`, groupFirstLetter)