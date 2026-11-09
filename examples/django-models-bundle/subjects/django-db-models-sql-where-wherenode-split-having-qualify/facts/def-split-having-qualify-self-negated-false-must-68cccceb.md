# Fact 68cccceb

Store id: d011b579-7470-4673-9751-5069664f96e6

## Text

```text
def split_having_qualify(self, negated=False, must_group_by=False)
```

## Attributes

- Kind: code
- Status: live
- Confidence: 1
- Tags: `entity:method`

## Provenance

- actor: `dossier-cli`
- actor_type: `tool`
- channel: `cli`
- posted_at: `2026-11-09T23:44:59.6779030+00:00`

## Data

```json
{
  "end_line": 114,
  "entity_kind": "method",
  "parent": "WhereNode",
  "start_line": 40,
  "symbol": "WhereNode.split_having_qualify"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/sql/where.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":40,"selector":"L40-L114","symbol":"WhereNode.split_having_qualify"}`

## Items

```json
[
  {
    "text": "Return three possibly None nodes: one for those parts of self that should be included in the WHERE clause, one for those parts of self that must be included in the HAVING clause, and one for those parts that refer to window functions.",
    "locator": {
      "line": 41
    }
  }
]
```

## Referenced by

None.

## Subject

[django/db/models/sql/where::WhereNode.split_having_qualify](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 114,
    "entity_kind": "method",
    "parent": "WhereNode",
    "start_line": 40,
    "symbol": "WhereNode.split_having_qualify"
  },
  "id": "d011b579-7470-4673-9751-5069664f96e6",
  "items": [
    {
      "locator": {
        "line": 41
      },
      "text": "Return three possibly None nodes: one for those parts of self that should be included in the WHERE clause, one for those parts of self that must be included in the HAVING clause, and one for those parts that refer to window functions."
    }
  ],
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:44:59.6779030+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 40,
        "selector": "L40-L114",
        "symbol": "WhereNode.split_having_qualify"
      },
      "rel": "derived_from",
      "target": "django/db/models/sql/where.py"
    }
  ],
  "status": "live",
  "subject_id": "b13a0d54-0399-49d0-9bd7-0c107f8754c3",
  "subject_name": "django/db/models/sql/where::WhereNode.split_having_qualify",
  "tags": [
    "entity:method"
  ],
  "text": "def split_having_qualify(self, negated=False, must_group_by=False)"
}
```
