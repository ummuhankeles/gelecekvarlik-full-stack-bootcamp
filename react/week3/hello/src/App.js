import { useState, useEffect } from 'react'
import './App.css'
import { Ekle } from './components/Ekle'
import { Layout } from './components/Layout'
import { Listele } from './components/Listele'
import avatar from './services/http/avatar'
import simpsons from './services/http/simpsons'
function App() {
  const [kisiler, setKisiler] = useState([])
  const [movie, setMovie] = useState('all')
  const handleKisiEkle = (isim) => {
    setKisiler([
      ...kisiler,
      { name: isim, number: Math.ceil(Math.random() * 100) + 1 },
    ])
  }

  useEffect(() => {
    if (movie === 'all') {
      Promise.allSettled([
        simpsons.getFamilyList(),
        avatar.getFamilyList(),
      ]).then(([r1, r2]) => {
        const t_r1 = r1.value ? r1.value.data : []
        const t_r2 = r2.value ? r2.value.data : []
        setKisiler([
          ...t_r1
            .map((simpson) => ({
              name: simpson.name,
              number: simpson.id,
            }))
            .slice(50, 70),
          ...t_r2
            .map((simpson) => ({
              name: simpson.name,
              number: simpson.id,
            }))
            .slice(0, 20),
        ])
      })
    } else if (movie === 'avatar') {
      avatar.getFamilyList().then((res) => {
        setKisiler(
          res.data
            .map((simpson) => ({
              name: simpson.name,
              number: simpson.id,
            }))
            .slice(0, 20)
        )
      })
    } else if (movie === 'simpsons') {
      simpsons.getFamilyList().then((res) => {
        setKisiler(
          res.data
            .map((simpson) => ({
              name: simpson.name,
              number: simpson.id,
            }))
            .slice(50, 70)
        )
      })
    }
  }, [movie])

  return (
    <div className="App">
      <Layout
        sol={
          <>
            <Ekle onSave={handleKisiEkle} />
            <Listele list={kisiler} />
          </>
        }
        sag={'Sağ'}
        baslik={
          <>
            <select onChange={(e) => setMovie(e.target.value)}>
              <option value="avatar">Avatar</option>
              <option value="simpsons">Simpsons</option>
              <option value="all">All</option>
            </select>
          </>
        }
      />
    </div>
  )
}

export default App
