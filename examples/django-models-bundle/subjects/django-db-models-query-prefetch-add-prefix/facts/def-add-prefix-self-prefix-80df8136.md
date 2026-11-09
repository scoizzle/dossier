# Fact 80df8136

Store id: 72eecac4-5a40-4647-bb96-c6b709f0303f

## Text

```text
def add_prefix(self, prefix)
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
- posted_at: `2026-11-09T23:44:56.2866600+00:00`

## Data

```json
{
  "end_line": 2606,
  "entity_kind": "method",
  "parent": "Prefetch",
  "start_line": 2604,
  "symbol": "Prefetch.add_prefix"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/query.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":2604,"selector":"L2604-L2606","symbol":"Prefetch.add_prefix"}`

## Referenced by

None.

## Subject

[django/db/models/query::Prefetch.add_prefix](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 2606,
    "entity_kind": "method",
    "parent": "Prefetch",
    "start_line": 2604,
    "symbol": "Prefetch.add_prefix"
  },
  "id": "72eecac4-5a40-4647-bb96-c6b709f0303f",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:44:56.2866600+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 2604,
        "selector": "L2604-L2606",
        "symbol": "Prefetch.add_prefix"
      },
      "rel": "derived_from",
      "target": "django/db/models/query.py"
    }
  ],
  "status": "live",
  "subject_id": "73fdba31-f401-4ef9-ba8a-a4e33943f901",
  "subject_name": "django/db/models/query::Prefetch.add_prefix",
  "tags": [
    "entity:method"
  ],
  "text": "def add_prefix(self, prefix)"
}
```
