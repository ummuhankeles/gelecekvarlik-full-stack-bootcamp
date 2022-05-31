import { useState } from 'react'
import Styled from './Ekle.styled'
function Ekle({ onSave }) {
  const [isim, setIsim] = useState('')
  return (
    <Styled>
    <span className='baslik'>Buradan kişi ekleyin</span>
      <input
        value={isim}
        onChange={(e) => {
          setIsim(e.target.value)
        }}
      />
      <button
        onClick={() => {
          onSave(isim)
          setIsim('')
        }}
      >
        Ekle
      </button>
    </Styled>
  )
}
export default Ekle
