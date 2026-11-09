# Fact 68a12c8c

Store id: 1f0efee2-7cfb-4ca5-bfc9-65ffd389231b

## Text

```text
def has_results(self, using)
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
- posted_at: `2026-11-09T22:39:51.2690160+00:00`

## Data

```json
{
  "end_line": 686,
  "entity_kind": "method",
  "parent": "Query",
  "start_line": 683,
  "symbol": "Query.has_results"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/sql/query.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":683,"selector":"L683-L686","symbol":"Query.has_results"}`

## Referenced by

None.

## Subject

[django/db/models/sql/query::Query.has_results](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 686,
    "entity_kind": "method",
    "parent": "Query",
    "start_line": 683,
    "symbol": "Query.has_results"
  },
  "id": "1f0efee2-7cfb-4ca5-bfc9-65ffd389231b",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T22:39:51.2690160+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 683,
        "selector": "L683-L686",
        "symbol": "Query.has_results"
      },
      "rel": "derived_from",
      "target": "django/db/models/sql/query.py"
    }
  ],
  "status": "live",
  "subject_id": "c22555c4-e470-4f2d-9597-614541754668",
  "subject_name": "django/db/models/sql/query::Query.has_results",
  "tags": [
    "entity:method"
  ],
  "text": "def has_results(self, using)"
}
```
