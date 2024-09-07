import java.util.*;

class DFSMaxScore {

    public static int dfs(List<Integer> balloons,Map<List<Integer>,Integer> memoMap) {

		if (memoMap.containsKey(balloons)) {
            return memoMap.get(balloons);
        }

        int maxSum = 0;
        int currSum = 0;

		if(balloons.size() == 1){
			currSum =  balloons.get(0);
			memoMap.put(new ArrayList<>(balloons), currSum);
			return currSum;
		}
            

        for(int i = 0; i < balloons.size(); i++){

            int elementRemoved = balloons.remove(i);
			currSum = dfs(balloons,memoMap);
			balloons.add(i,elementRemoved);
			if(i-1 < 0)
				maxSum = Integer.max(balloons.get(i+1) + currSum,maxSum);
			else if(i+1 >= balloons.size())
				maxSum = Integer.max(balloons.get(i-1) + currSum,maxSum);
			else{
				if(i > 0 && i < balloons.size()-1)
				maxSum = Integer.max(balloons.get(i-1) * balloons.get(i+1) + currSum,maxSum);
			}

            currSum = 0;
        }

		memoMap.put(new ArrayList<>(balloons), maxSum);
		
        return maxSum;
    }

	public static void main(String []args) // driver function
	{
        List<Integer> balloonScores = new LinkedList<>(Arrays.asList(111,222,333,4444,5555,6666,7777,11111,22222,3333,999,23,12,34,15,156,123));
		Map<List<Integer>, Integer> memoMap = new HashMap<>();
		start = System.currentTimeMillis();
        System.out.println(dfs(balloonScores,memoMap));
		end = System.currentTimeMillis();

		execution = (end - start);
		System.out.println(execution + " milliseconds");
		System.out.println();
			
    }
}



