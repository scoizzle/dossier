# Fact 94dcf4f9

Store id: ad9cedc4-20a7-4ab2-b2e0-306ea5323971

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
- posted_at: `2026-11-09T23:32:04.3094470+00:00`

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
  "id": "ad9cedc4-20a7-4ab2-b2e0-306ea5323971",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:32:04.3094470+00:00"
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
  "subject_id": "bc6d165a-d894-4bd6-9d8a-c9740fe6f072",
  "subject_name": "django/db/models/query::QuerySet.query",
  "tags": [
    "entity:method",
    "decorator:query.setter"
  ],
  "text": "def query(self, value)"
}
```
