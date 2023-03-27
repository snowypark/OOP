## c#으로 스택 구현하기

1번 연결리스트

![화면 캡처 2023-03-27 122021](https://user-images.githubusercontent.com/100844814/227838006-bf7430c8-673c-4351-9191-1652d22be259.png)

LinkedList<T> 클래스

.NET에는 링크드 리스트를 구현한 LinkedList<T> 클래스가 있다. 이 LinkedList 클래스는 이중 링크드 리스트로 구현되어 있으며, 리스트 노드는 LinkedListNode 클래스로 표현된다. 노드의 추가는 AddFirst, AddLast, AddBefore, AddAfter 등의 메서드들을 호출하여 처음 또는 끝, 혹은 특정 노드의 앞, 뒤에 새 노드를 추가할 수 있다. 아래 예는 Banana 노드 뒤에 Grape노드를 추가하는 예이다.

[참고 링크] : https://www.csharpstudy.com/DS/linkedlist.aspx

##


2번 배열

![화면 캡처 2023-03-27 130232](https://user-images.githubusercontent.com/100844814/227838010-990e82ae-b1b0-431f-8463-62ac563a765a.png)

다음 코드는 제네릭 클래스의 여러 메서드를 Stack<T> 보여 줍니다. 이 코드 예제에서는 기본 용량이 있는 문자열 스택을 만들고 메서드를 Push 사용하여 5개의 문자열을 스택에 푸시합니다. 스택의 요소는 열거되며 스택의 상태는 변경되지 않습니다. 이 Pop 메서드는 스택에서 첫 번째 문자열을 팝하는 데 사용됩니다. 이 Peek 메서드는 스택에서 다음 항목을 보는 데 사용되며, 이 Pop 메서드는 이 항목을 팝오프하는 데 사용됩니다.

이 ToArray 메서드는 배열을 만들고 스택 요소를 복사하는 데 사용되며, 배열이 사용되는 IEnumerable<T>생성자에 전달되어 Stack<T> 요소 순서가 반대로 바뀌는 스택의 복사본을 만듭니다. 복사본의 요소가 표시됩니다.

[참고 링크] : https://learn.microsoft.com/ko-kr/dotnet/api/system.collections.generic.stack-1?view=net-7.0 
