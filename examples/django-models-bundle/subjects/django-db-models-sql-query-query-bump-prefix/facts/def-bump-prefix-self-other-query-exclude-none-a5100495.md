# Fact a5100495

Store id: 49d32fa6-f4ac-4dec-bdc0-d421399bbd9b

## Text

```text
def bump_prefix(self, other_query, exclude=None)
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
- posted_at: `2026-11-09T22:39:51.3088600+00:00`

## Data

```json
{
  "end_line": 1110,
  "entity_kind": "method",
  "parent": "Query",
  "start_line": 1057,
  "symbol": "Query.bump_prefix"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/sql/query.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":1057,"selector":"L1057-L1110","symbol":"Query.bump_prefix"}`

## Items

```json
[
  {
    "text": "Change the alias prefix to the next letter in the alphabet in a way that the other query's aliases and this query's aliases will not conflict. Even tables that previously had no alias will get an alias after this call. To prevent changing aliases use the exclude parameter.",
    "locator": {
      "line": 1058
    }
  }
]
```

## Referenced by

None.

## Subject

[django/db/models/sql/query::Query.bump_prefix](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 1110,
    "entity_kind": "method",
    "parent": "Query",
    "start_line": 1057,
    "symbol": "Query.bump_prefix"
  },
  "id": "49d32fa6-f4ac-4dec-bdc0-d421399bbd9b",
  "items": [
    {
      "locator": {
        "line": 1058
      },
      "text": "Change the alias prefix to the next letter in the alphabet in a way that the other query's aliases and this query's aliases will not conflict. Even tables that previously had no alias will get an alias after this call. To prevent changing aliases use the exclude parameter."
    }
  ],
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T22:39:51.3088600+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 1057,
        "selector": "L1057-L1110",
        "symbol": "Query.bump_prefix"
      },
      "rel": "derived_from",
      "target": "django/db/models/sql/query.py"
    }
  ],
  "status": "live",
  "subject_id": "469d9860-a149-43c7-9b01-85d9e5521c29",
  "subject_name": "django/db/models/sql/query::Query.bump_prefix",
  "tags": [
    "entity:method"
  ],
  "text": "def bump_prefix(self, other_query, exclude=None)"
}
```
