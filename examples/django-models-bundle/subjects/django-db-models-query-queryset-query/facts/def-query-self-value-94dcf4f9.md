# Fact 94dcf4f9

Store id: bce5fc4a-a3bc-4d95-81eb-76abc132127a

## Text

```text
def query(self, value)
```

## Attributes

- Kind: code
- Status: live
- Confidence: 1
- Tags: `entity:method`, `decorator:query.setter`

## Provenance

- actor: `dossier-cli`
- actor_type: `tool`
- channel: `cli`
- posted_at: `2026-11-09T23:44:55.8323910+00:00`

## Data

```json
{
  "end_line": 397,
  "entity_kind": "method",
  "parent": "QuerySet",
  "start_line": 393,
  "symbol": "QuerySet.query"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/query.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":393,"selector":"L393-L397","symbol":"QuerySet.query"}`

## Referenced by

None.

## Subject

[django/db/models/query::QuerySet.query](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 397,
    "entity_kind": "method",
    "parent": "QuerySet",
    "start_line": 393,
    "symbol": "QuerySet.query"
  },
  "id": "bce5fc4a-a3bc-4d95-81eb-76abc132127a",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:44:55.8323910+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 393,
        "selector": "L393-L397",
        "symbol": "QuerySet.query"
      },
      "rel": "derived_from",
      "target": "django/db/models/query.py"
    }
  ],
  "status": "live",
  "subject_id": "c54350e8-cbf0-403c-875d-e6a19cb8aa92",
  "subject_name": "django/db/models/query::QuerySet.query",
  "tags": [
    "entity:method",
    "decorator:query.setter"
  ],
  "text": "def query(self, value)"
}
```
