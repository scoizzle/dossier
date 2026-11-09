# Fact e525fd7c

Store id: 21cf2ee4-d609-4416-b2a4-0b0dfd399948

## Text

```text
def process_rhs(self, compiler, connection)
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
- posted_at: `2026-11-09T23:31:57.9242680+00:00`

## Data

```json
{
  "end_line": 312,
  "entity_kind": "method",
  "parent": "CaseInsensitiveMixin",
  "start_line": 308,
  "symbol": "CaseInsensitiveMixin.process_rhs"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/fields/json.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":308,"selector":"L308-L312","symbol":"CaseInsensitiveMixin.process_rhs"}`

## Referenced by

None.

## Subject

[django/db/models/fields/json::CaseInsensitiveMixin.process_rhs](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 312,
    "entity_kind": "method",
    "parent": "CaseInsensitiveMixin",
    "start_line": 308,
    "symbol": "CaseInsensitiveMixin.process_rhs"
  },
  "id": "21cf2ee4-d609-4416-b2a4-0b0dfd399948",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:31:57.9242680+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 308,
        "selector": "L308-L312",
        "symbol": "CaseInsensitiveMixin.process_rhs"
      },
      "rel": "derived_from",
      "target": "django/db/models/fields/json.py"
    }
  ],
  "status": "live",
  "subject_id": "5731c286-642a-4257-8727-4baef06dd3f8",
  "subject_name": "django/db/models/fields/json::CaseInsensitiveMixin.process_rhs",
  "tags": [
    "entity:method"
  ],
  "text": "def process_rhs(self, compiler, connection)"
}
```
