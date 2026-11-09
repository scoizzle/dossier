# Fact 4172c0fa

Store id: 2bc31de4-4b7f-46ad-af52-4aab0278f1db

## Text

```text
def bitxor(self, other)
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
- posted_at: `2026-11-09T22:39:41.4806500+00:00`

## Data

```json
{
  "end_line": 121,
  "entity_kind": "method",
  "parent": "Combinable",
  "start_line": 120,
  "symbol": "Combinable.bitxor"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/expressions.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":120,"selector":"L120-L121","symbol":"Combinable.bitxor"}`

## Referenced by

None.

## Subject

[django/db/models/expressions::Combinable.bitxor](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 121,
    "entity_kind": "method",
    "parent": "Combinable",
    "start_line": 120,
    "symbol": "Combinable.bitxor"
  },
  "id": "2bc31de4-4b7f-46ad-af52-4aab0278f1db",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T22:39:41.4806500+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 120,
        "selector": "L120-L121",
        "symbol": "Combinable.bitxor"
      },
      "rel": "derived_from",
      "target": "django/db/models/expressions.py"
    }
  ],
  "status": "live",
  "subject_id": "4aec4fc8-ffc3-43ec-b119-bfcf85a516e2",
  "subject_name": "django/db/models/expressions::Combinable.bitxor",
  "tags": [
    "entity:method"
  ],
  "text": "def bitxor(self, other)"
}
```
