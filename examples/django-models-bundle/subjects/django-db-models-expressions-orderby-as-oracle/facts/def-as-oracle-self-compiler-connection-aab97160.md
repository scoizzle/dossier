# Fact aab97160

Store id: 4e765d4c-e94b-4b0a-bd54-d645fd27b320

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
- posted_at: `2026-11-09T23:44:49.6605460+00:00`

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
  "id": "4e765d4c-e94b-4b0a-bd54-d645fd27b320",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:44:49.6605460+00:00"
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
  "subject_id": "9ed8e6e0-4c81-4809-a7e7-e6f7785c0b56",
  "subject_name": "django/db/models/expressions::OrderBy.as_oracle",
  "tags": [
    "entity:method"
  ],
  "text": "def as_oracle(self, compiler, connection)"
}
```
