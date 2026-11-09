# Fact 60b46030

Store id: 6883e422-ee9d-4755-8ebc-44dfeabf3347

## Text

```text
def join(self, join, reuse=None)
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
- posted_at: `2026-11-09T23:44:58.7629500+00:00`

## Data

```json
{
  "end_line": 1186,
  "entity_kind": "method",
  "parent": "Query",
  "start_line": 1134,
  "symbol": "Query.join"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/sql/query.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":1134,"selector":"L1134-L1186","symbol":"Query.join"}`

## Items

```json
[
  {
    "text": "Return an alias for the 'join', either reusing an existing alias for that join or creating a new one. 'join' is either a base_table_class or join_class.",
    "locator": {
      "line": 1135
    }
  }
]
```

## Referenced by

None.

## Subject

[django/db/models/sql/query::Query.join](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 1186,
    "entity_kind": "method",
    "parent": "Query",
    "start_line": 1134,
    "symbol": "Query.join"
  },
  "id": "6883e422-ee9d-4755-8ebc-44dfeabf3347",
  "items": [
    {
      "locator": {
        "line": 1135
      },
      "text": "Return an alias for the 'join', either reusing an existing alias for that join or creating a new one. 'join' is either a base_table_class or join_class."
    }
  ],
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:44:58.7629500+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 1134,
        "selector": "L1134-L1186",
        "symbol": "Query.join"
      },
      "rel": "derived_from",
      "target": "django/db/models/sql/query.py"
    }
  ],
  "status": "live",
  "subject_id": "ff62b731-ca1e-41e8-be90-ae1cb6bbcd43",
  "subject_name": "django/db/models/sql/query::Query.join",
  "tags": [
    "entity:method"
  ],
  "text": "def join(self, join, reuse=None)"
}
```
