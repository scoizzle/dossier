# Fact aab97160

Store id: 1baf562b-f190-4cab-ad1b-ab5b9805a5a2

## Text

```text
def as_oracle(self, compiler, connection)
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
- posted_at: `2026-11-09T22:39:41.7480320+00:00`

## Data

```json
{
  "end_line": 1995,
  "entity_kind": "method",
  "parent": "OrderBy",
  "start_line": 1980,
  "symbol": "OrderBy.as_oracle"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/expressions.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":1980,"selector":"L1980-L1995","symbol":"OrderBy.as_oracle"}`

## Referenced by

None.

## Subject

[django/db/models/expressions::OrderBy.as_oracle](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 1995,
    "entity_kind": "method",
    "parent": "OrderBy",
    "start_line": 1980,
    "symbol": "OrderBy.as_oracle"
  },
  "id": "1baf562b-f190-4cab-ad1b-ab5b9805a5a2",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T22:39:41.7480320+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 1980,
        "selector": "L1980-L1995",
        "symbol": "OrderBy.as_oracle"
      },
      "rel": "derived_from",
      "target": "django/db/models/expressions.py"
    }
  ],
  "status": "live",
  "subject_id": "e63ac347-9518-4c74-b385-bbba0f9ee5f3",
  "subject_name": "django/db/models/expressions::OrderBy.as_oracle",
  "tags": [
    "entity:method"
  ],
  "text": "def as_oracle(self, compiler, connection)"
}
```
